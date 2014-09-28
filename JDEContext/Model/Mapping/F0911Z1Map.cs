using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JDEContext
{
    public class F0911Z1Map : EntityTypeConfiguration<F0911Z1>
    {
        public F0911Z1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.VNEDUS, t.VNEDTN, t.VNEDLN, t.VNEDBT });

            // Properties
            this.Property(t => t.VNEDUS)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.VNEDTY)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNEDTN)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(22);

            this.Property(t => t.VNEDCT)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.VNEDLN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VNEDTS)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.VNEDFT)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.VNEDER)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNEDSP)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNEDTC)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNEDTR)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNEDBT)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.VNEDGL)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNKCO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.VNDCT)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.VNEXTL)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.VNPOST)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNICUT)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.VNCO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.VNANI)
                .IsFixedLength()
                .HasMaxLength(29);

            this.Property(t => t.VNAM)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNAID)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.VNMCU)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.VNOBJ)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.VNSUB)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.VNSBL)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.VNSBLT)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNLT)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.VNFQ)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.VNCRCD)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.VNUM)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.VNGLC)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.VNRE)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNEXA)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.VNEXR)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.VNR1)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.VNR2)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.VNR3)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.VNSFX)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.VNODCT)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.VNOSFX)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.VNPKCO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.VNOKCO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.VNPDCT)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.VNCN)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.VNASID)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.VNBRE)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNRCND)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNSUMM)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNPRGE)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNTNN)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNALT1)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNALT2)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNALT3)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNALT4)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNALT5)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNALT6)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNALT7)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNALT8)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNALT9)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNALT0)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNALTT)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNALTU)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNALTV)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNALTW)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNALTX)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNALTZ)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNDLNA)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNCFF1)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNCFF2)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNASM)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNBC)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNVINV)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.VNWR01)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.VNPO)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.VNPSFX)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.VNDCTO)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.VNFNLP)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNJBCD)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.VNJBST)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.VNHMCU)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.VNALID)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.VNALTY)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.VNTORG)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.VNUSER)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.VNPID)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.VNJOBN)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.VNCRRM)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNABR1)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.VNABR2)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.VNABR3)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.VNABR4)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.VNABT1)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNABT2)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNABT3)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNABT4)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNPM01)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNPM02)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNPM03)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNPM04)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNPM05)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNPM06)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNPM07)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNPM08)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNPM09)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNPM10)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNBCRC)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.VNEXR1)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.VNTXA1)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.VNACTB)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.VNTKTX)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNCKNU)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.VNBUPC)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.VNAHBU)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.VNEPGC)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.VNJPGC)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.VNOFM)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("F0911Z1", "PRODDTA");
            this.Property(t => t.VNEDUS).HasColumnName("VNEDUS");
            this.Property(t => t.VNEDTY).HasColumnName("VNEDTY");
            this.Property(t => t.VNEDSQ).HasColumnName("VNEDSQ");
            this.Property(t => t.VNEDTN).HasColumnName("VNEDTN");
            this.Property(t => t.VNEDCT).HasColumnName("VNEDCT");
            this.Property(t => t.VNEDLN).HasColumnName("VNEDLN");
            this.Property(t => t.VNEDTS).HasColumnName("VNEDTS");
            this.Property(t => t.VNEDFT).HasColumnName("VNEDFT");
            this.Property(t => t.VNEDDT).HasColumnName("VNEDDT");
            this.Property(t => t.VNEDER).HasColumnName("VNEDER");
            this.Property(t => t.VNEDDL).HasColumnName("VNEDDL");
            this.Property(t => t.VNEDSP).HasColumnName("VNEDSP");
            this.Property(t => t.VNEDTC).HasColumnName("VNEDTC");
            this.Property(t => t.VNEDTR).HasColumnName("VNEDTR");
            this.Property(t => t.VNEDBT).HasColumnName("VNEDBT");
            this.Property(t => t.VNEDGL).HasColumnName("VNEDGL");
            this.Property(t => t.VNEDAN).HasColumnName("VNEDAN");
            this.Property(t => t.VNKCO).HasColumnName("VNKCO");
            this.Property(t => t.VNDCT).HasColumnName("VNDCT");
            this.Property(t => t.VNDOC).HasColumnName("VNDOC");
            this.Property(t => t.VNDGJ).HasColumnName("VNDGJ");
            this.Property(t => t.VNJELN).HasColumnName("VNJELN");
            this.Property(t => t.VNEXTL).HasColumnName("VNEXTL");
            this.Property(t => t.VNPOST).HasColumnName("VNPOST");
            this.Property(t => t.VNICU).HasColumnName("VNICU");
            this.Property(t => t.VNICUT).HasColumnName("VNICUT");
            this.Property(t => t.VNDICJ).HasColumnName("VNDICJ");
            this.Property(t => t.VNDSYJ).HasColumnName("VNDSYJ");
            this.Property(t => t.VNTICU).HasColumnName("VNTICU");
            this.Property(t => t.VNCO).HasColumnName("VNCO");
            this.Property(t => t.VNANI).HasColumnName("VNANI");
            this.Property(t => t.VNAM).HasColumnName("VNAM");
            this.Property(t => t.VNAID).HasColumnName("VNAID");
            this.Property(t => t.VNMCU).HasColumnName("VNMCU");
            this.Property(t => t.VNOBJ).HasColumnName("VNOBJ");
            this.Property(t => t.VNSUB).HasColumnName("VNSUB");
            this.Property(t => t.VNSBL).HasColumnName("VNSBL");
            this.Property(t => t.VNSBLT).HasColumnName("VNSBLT");
            this.Property(t => t.VNLT).HasColumnName("VNLT");
            this.Property(t => t.VNPN).HasColumnName("VNPN");
            this.Property(t => t.VNCTRY).HasColumnName("VNCTRY");
            this.Property(t => t.VNFY).HasColumnName("VNFY");
            this.Property(t => t.VNFQ).HasColumnName("VNFQ");
            this.Property(t => t.VNCRCD).HasColumnName("VNCRCD");
            this.Property(t => t.VNCRR).HasColumnName("VNCRR");
            this.Property(t => t.VNHCRR).HasColumnName("VNHCRR");
            this.Property(t => t.VNHDGJ).HasColumnName("VNHDGJ");
            this.Property(t => t.VNAA).HasColumnName("VNAA");
            this.Property(t => t.VNU).HasColumnName("VNU");
            this.Property(t => t.VNUM).HasColumnName("VNUM");
            this.Property(t => t.VNGLC).HasColumnName("VNGLC");
            this.Property(t => t.VNRE).HasColumnName("VNRE");
            this.Property(t => t.VNEXA).HasColumnName("VNEXA");
            this.Property(t => t.VNEXR).HasColumnName("VNEXR");
            this.Property(t => t.VNR1).HasColumnName("VNR1");
            this.Property(t => t.VNR2).HasColumnName("VNR2");
            this.Property(t => t.VNR3).HasColumnName("VNR3");
            this.Property(t => t.VNSFX).HasColumnName("VNSFX");
            this.Property(t => t.VNODOC).HasColumnName("VNODOC");
            this.Property(t => t.VNODCT).HasColumnName("VNODCT");
            this.Property(t => t.VNOSFX).HasColumnName("VNOSFX");
            this.Property(t => t.VNPKCO).HasColumnName("VNPKCO");
            this.Property(t => t.VNOKCO).HasColumnName("VNOKCO");
            this.Property(t => t.VNPDCT).HasColumnName("VNPDCT");
            this.Property(t => t.VNAN8).HasColumnName("VNAN8");
            this.Property(t => t.VNCN).HasColumnName("VNCN");
            this.Property(t => t.VNDKJ).HasColumnName("VNDKJ");
            this.Property(t => t.VNDKC).HasColumnName("VNDKC");
            this.Property(t => t.VNASID).HasColumnName("VNASID");
            this.Property(t => t.VNBRE).HasColumnName("VNBRE");
            this.Property(t => t.VNRCND).HasColumnName("VNRCND");
            this.Property(t => t.VNSUMM).HasColumnName("VNSUMM");
            this.Property(t => t.VNPRGE).HasColumnName("VNPRGE");
            this.Property(t => t.VNTNN).HasColumnName("VNTNN");
            this.Property(t => t.VNALT1).HasColumnName("VNALT1");
            this.Property(t => t.VNALT2).HasColumnName("VNALT2");
            this.Property(t => t.VNALT3).HasColumnName("VNALT3");
            this.Property(t => t.VNALT4).HasColumnName("VNALT4");
            this.Property(t => t.VNALT5).HasColumnName("VNALT5");
            this.Property(t => t.VNALT6).HasColumnName("VNALT6");
            this.Property(t => t.VNALT7).HasColumnName("VNALT7");
            this.Property(t => t.VNALT8).HasColumnName("VNALT8");
            this.Property(t => t.VNALT9).HasColumnName("VNALT9");
            this.Property(t => t.VNALT0).HasColumnName("VNALT0");
            this.Property(t => t.VNALTT).HasColumnName("VNALTT");
            this.Property(t => t.VNALTU).HasColumnName("VNALTU");
            this.Property(t => t.VNALTV).HasColumnName("VNALTV");
            this.Property(t => t.VNALTW).HasColumnName("VNALTW");
            this.Property(t => t.VNALTX).HasColumnName("VNALTX");
            this.Property(t => t.VNALTZ).HasColumnName("VNALTZ");
            this.Property(t => t.VNDLNA).HasColumnName("VNDLNA");
            this.Property(t => t.VNCFF1).HasColumnName("VNCFF1");
            this.Property(t => t.VNCFF2).HasColumnName("VNCFF2");
            this.Property(t => t.VNASM).HasColumnName("VNASM");
            this.Property(t => t.VNBC).HasColumnName("VNBC");
            this.Property(t => t.VNVINV).HasColumnName("VNVINV");
            this.Property(t => t.VNIVD).HasColumnName("VNIVD");
            this.Property(t => t.VNWR01).HasColumnName("VNWR01");
            this.Property(t => t.VNPO).HasColumnName("VNPO");
            this.Property(t => t.VNPSFX).HasColumnName("VNPSFX");
            this.Property(t => t.VNDCTO).HasColumnName("VNDCTO");
            this.Property(t => t.VNLNID).HasColumnName("VNLNID");
            this.Property(t => t.VNWY).HasColumnName("VNWY");
            this.Property(t => t.VNWN).HasColumnName("VNWN");
            this.Property(t => t.VNFNLP).HasColumnName("VNFNLP");
            this.Property(t => t.VNOPSQ).HasColumnName("VNOPSQ");
            this.Property(t => t.VNJBCD).HasColumnName("VNJBCD");
            this.Property(t => t.VNJBST).HasColumnName("VNJBST");
            this.Property(t => t.VNHMCU).HasColumnName("VNHMCU");
            this.Property(t => t.VNDOI).HasColumnName("VNDOI");
            this.Property(t => t.VNALID).HasColumnName("VNALID");
            this.Property(t => t.VNALTY).HasColumnName("VNALTY");
            this.Property(t => t.VNDSVJ).HasColumnName("VNDSVJ");
            this.Property(t => t.VNTORG).HasColumnName("VNTORG");
            this.Property(t => t.VNREG_).HasColumnName("VNREG#");
            this.Property(t => t.VNPYID).HasColumnName("VNPYID");
            this.Property(t => t.VNUSER).HasColumnName("VNUSER");
            this.Property(t => t.VNPID).HasColumnName("VNPID");
            this.Property(t => t.VNJOBN).HasColumnName("VNJOBN");
            this.Property(t => t.VNUPMJ).HasColumnName("VNUPMJ");
            this.Property(t => t.VNUPMT).HasColumnName("VNUPMT");
            this.Property(t => t.VNCRRM).HasColumnName("VNCRRM");
            this.Property(t => t.VNACR).HasColumnName("VNACR");
            this.Property(t => t.VNDGM).HasColumnName("VNDGM");
            this.Property(t => t.VNDGD).HasColumnName("VNDGD");
            this.Property(t => t.VNDGY).HasColumnName("VNDGY");
            this.Property(t => t.VNDG_).HasColumnName("VNDG#");
            this.Property(t => t.VNDICM).HasColumnName("VNDICM");
            this.Property(t => t.VNDICD).HasColumnName("VNDICD");
            this.Property(t => t.VNDICY).HasColumnName("VNDICY");
            this.Property(t => t.VNDIC_).HasColumnName("VNDIC#");
            this.Property(t => t.VNDSYM).HasColumnName("VNDSYM");
            this.Property(t => t.VNDSYD).HasColumnName("VNDSYD");
            this.Property(t => t.VNDSYY).HasColumnName("VNDSYY");
            this.Property(t => t.VNDSY_).HasColumnName("VNDSY#");
            this.Property(t => t.VNDKM).HasColumnName("VNDKM");
            this.Property(t => t.VNDKD).HasColumnName("VNDKD");
            this.Property(t => t.VNDKY).HasColumnName("VNDKY");
            this.Property(t => t.VNDK_).HasColumnName("VNDK#");
            this.Property(t => t.VNDSVM).HasColumnName("VNDSVM");
            this.Property(t => t.VNDSVD).HasColumnName("VNDSVD");
            this.Property(t => t.VNDSVY).HasColumnName("VNDSVY");
            this.Property(t => t.VNDSV_).HasColumnName("VNDSV#");
            this.Property(t => t.VNHDGM).HasColumnName("VNHDGM");
            this.Property(t => t.VNHDGD).HasColumnName("VNHDGD");
            this.Property(t => t.VNHDGY).HasColumnName("VNHDGY");
            this.Property(t => t.VNHDG_).HasColumnName("VNHDG#");
            this.Property(t => t.VNDKCM).HasColumnName("VNDKCM");
            this.Property(t => t.VNDKCD).HasColumnName("VNDKCD");
            this.Property(t => t.VNDKCY).HasColumnName("VNDKCY");
            this.Property(t => t.VNDKC_).HasColumnName("VNDKC#");
            this.Property(t => t.VNIVDM).HasColumnName("VNIVDM");
            this.Property(t => t.VNIVDD).HasColumnName("VNIVDD");
            this.Property(t => t.VNIVDY).HasColumnName("VNIVDY");
            this.Property(t => t.VNIVD_).HasColumnName("VNIVD#");
            this.Property(t => t.VNABR1).HasColumnName("VNABR1");
            this.Property(t => t.VNABR2).HasColumnName("VNABR2");
            this.Property(t => t.VNABR3).HasColumnName("VNABR3");
            this.Property(t => t.VNABR4).HasColumnName("VNABR4");
            this.Property(t => t.VNABT1).HasColumnName("VNABT1");
            this.Property(t => t.VNABT2).HasColumnName("VNABT2");
            this.Property(t => t.VNABT3).HasColumnName("VNABT3");
            this.Property(t => t.VNABT4).HasColumnName("VNABT4");
            this.Property(t => t.VNITM).HasColumnName("VNITM");
            this.Property(t => t.VNPM01).HasColumnName("VNPM01");
            this.Property(t => t.VNPM02).HasColumnName("VNPM02");
            this.Property(t => t.VNPM03).HasColumnName("VNPM03");
            this.Property(t => t.VNPM04).HasColumnName("VNPM04");
            this.Property(t => t.VNPM05).HasColumnName("VNPM05");
            this.Property(t => t.VNPM06).HasColumnName("VNPM06");
            this.Property(t => t.VNPM07).HasColumnName("VNPM07");
            this.Property(t => t.VNPM08).HasColumnName("VNPM08");
            this.Property(t => t.VNPM09).HasColumnName("VNPM09");
            this.Property(t => t.VNPM10).HasColumnName("VNPM10");
            this.Property(t => t.VNBCRC).HasColumnName("VNBCRC");
            this.Property(t => t.VNEXR1).HasColumnName("VNEXR1");
            this.Property(t => t.VNTXA1).HasColumnName("VNTXA1");
            this.Property(t => t.VNTXITM).HasColumnName("VNTXITM");
            this.Property(t => t.VNACTB).HasColumnName("VNACTB");
            this.Property(t => t.VNSTAM).HasColumnName("VNSTAM");
            this.Property(t => t.VNCTAM).HasColumnName("VNCTAM");
            this.Property(t => t.VNAG).HasColumnName("VNAG");
            this.Property(t => t.VNAGF).HasColumnName("VNAGF");
            this.Property(t => t.VNTKTX).HasColumnName("VNTKTX");
            this.Property(t => t.VNDLNID).HasColumnName("VNDLNID");
            this.Property(t => t.VNCKNU).HasColumnName("VNCKNU");
            this.Property(t => t.VNBUPC).HasColumnName("VNBUPC");
            this.Property(t => t.VNAHBU).HasColumnName("VNAHBU");
            this.Property(t => t.VNEPGC).HasColumnName("VNEPGC");
            this.Property(t => t.VNJPGC).HasColumnName("VNJPGC");
            this.Property(t => t.VNRC5).HasColumnName("VNRC5");
            this.Property(t => t.VNSFXE).HasColumnName("VNSFXE");
            this.Property(t => t.VNOFM).HasColumnName("VNOFM");
        }
    }
}
