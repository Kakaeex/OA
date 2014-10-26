using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace OA.Common
{
    public class CacheHelper
    {
        static int _minutes = 20;
        public static object Get(string key)
        {
            return HttpRuntime.Cache.Get(key);
        }

        public static void Set(string key, object value, int minutes = 0)
        {
            if (minutes <= 0) minutes = _minutes;
            HttpRuntime.Cache.Insert(key, value, null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(minutes));
        }

        public static void Remove(string key)
        {
            if (HttpRuntime.Cache[key] != null)
                HttpRuntime.Cache.Remove(key);
        }

        public static void Clear(string keyRegex = ".*")
        {
            List<string> keys = new List<string>();
            IDictionaryEnumerator enumerator = HttpRuntime.Cache.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var key = enumerator.Key.ToString();
                if (Regex.IsMatch(key, keyRegex, RegexOptions.IgnoreCase))
                    keys.Add(key);
            }

            for (int i = 0; i < keys.Count; i++)
            {
                HttpRuntime.Cache.Remove(keys[i]);
            }
        }

        //如果缓存里没有，则取数据然后缓存起来
        public static F Get<F>(string key, Func<F> getRealData, int minutes = 20)
        {
            var getDataFromCache = new Func<F>(() =>
            {
                F data = default(F);
                var cacheData = Get(key);
                if (cacheData == null)
                {
                    data = getRealData();

                    if (data != null)
                    {
                        if (minutes <= 0) minutes = _minutes;
                        Set(key, data, minutes);
                    }
                }
                else
                {
                    data = (F)cacheData;
                }

                return data;
            });

            return GetItem<F>(key, getDataFromCache);
        }

        public static F Get<F>(string key, int id, Func<int, F> getRealData, int minutes = 20)
        {
            if (minutes <= 0) minutes = _minutes;
            return Get<F, int>(key, id, getRealData, minutes);
        }

        public static F Get<F>(string key, string id, Func<string, F> getRealData, int minutes = 20)
        {
            if (minutes <= 0) minutes = _minutes;
            return Get<F, string>(key, id, getRealData, minutes);
        }

        public static F Get<F>(string key, string branchKey, Func<F> getRealData, int minutes = 20)
        {
            if (minutes <= 0) minutes = _minutes;
            return Get<F, string>(key, branchKey, id => getRealData(), minutes);
        }

        public static F Get<F, T>(string key, T id, Func<T, F> getRealData, int minutes = 20)
        {
            key = string.Format("{0}_{1}", key, id);

            var getDataFromCache = new Func<F>(() =>
            {
                F data = default(F);
                var cacheData = Get(key);
                if (cacheData == null)
                {
                    data = getRealData(id);

                    if (data != null)
                    {
                        if (minutes <= 0) minutes = _minutes;
                        Set(key, data, minutes);
                    }
                }
                else
                {
                    data = (F)cacheData;
                }

                return data;
            });

            return GetItem<F>(key, getDataFromCache);
        }

        #region 以下几个方法从HttpContext.Items缓存页面数据，适合页面生命周期，页面载入后就被移除，而非HttpContext.Cache在整个应用程序都有效
        //如果上下文HttpContext.Current.Items里没有，则取数据然后加入Items，在页面生命周期内有效
        public static F GetItem<F>(string name, Func<F> getRealData)
        {
            if (HttpContext.Current == null)
                return getRealData();

            var httpContextItems = HttpContext.Current.Items;
            if (httpContextItems.Contains(name))
            {
                return (F)httpContextItems[name];
            }
            else
            {
                var data = getRealData();
                if (data != null)
                    httpContextItems[name] = data;
                return data;
            }
        }

        public static F GetItem<F>() where F : new()
        {
            return GetItem<F>(typeof(F).ToString(), () => new F());
        }

        public static F GetItem<F>(Func<F> getRealData)
        {
            return GetItem<F>(typeof(F).ToString(), getRealData);
        }
        #endregion
    }
}
