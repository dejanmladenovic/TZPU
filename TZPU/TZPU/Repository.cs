using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TZPU.Entities;

namespace TZPU
{
    public class Repository
    {
        private static Repository instance;
        private static object locker = true;

        public static Repository Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                        instance = new Repository();
                }
                return instance;
            }
        }

        public List<Question> _questions { get; set; }
        

        protected Repository()
        {
           
            _questions = new List<Question>();


            ///////////tip testova 1////////////////////////////

            #region 1. tip testova

            List<Data> o1_1 = new List<Data>();
            o1_1.Add(new Image("1/sg_sword.gif"));
            o1_1.Add(new Image("1/sg_hat.gif"));
            o1_1.Add(new Image("1/sg_flipflop.gif"));
            o1_1.Add(new Image("1/sg_safety_pin.gif"));
            Question p1_1 = new Question("Dve slike u prvoj koloni su povezane na određen način. Izabrati sliku koja upotpunjuje drugu kolonu tako da slike budu povezane kao u prvoj.", "2", o1_1, new Image("1/Q3.png"), 1);
            _questions.Add(p1_1);

            List<Data> o1_2 = new List<Data>();
            o1_2.Add(new Image("1/39.1.png"));
            o1_2.Add(new Image("1/39.2.png"));
            o1_2.Add(new Image("1/39.3.png"));
            Question p1_2 = new Question("Lorin otac je pripremio piknik za nju i njenu sestru. Odabrati sliku korpe sa 5 namirnica unutar nje.", "1", o1_2, new Text(""), 1);
            _questions.Add(p1_2);

            List<Data> o1_3 = new List<Data>();
            o1_3.Add(new Image("1/kite.png"));
            o1_3.Add(new Image("1/plane.png"));
            o1_3.Add(new Image("1/rainbow.png"));
            Question p1_3 = new Question("Koja od slika iz odgovora se slaže sa ponuđenim nizom slika.", "3", o1_3, new Image("1/39.png"), 1);
            _questions.Add(p1_3);

            List<Data> o1_4 = new List<Data>();
            o1_4.Add(new Image("1/37.1.png"));
            o1_4.Add(new Image("1/37.2.png"));
            o1_4.Add(new Image("1/37.3.png"));
            Question p1_4 = new Question("Slike u gornjem redu su povezane na neki način. Odabrati sliku koja je povezana sa slikom u donjem redu.", "3", o1_4, new Image("1/37.png"), 1);
            _questions.Add(p1_4);

            List<Data> o1_5 = new List<Data>();
            o1_5.Add(new Image("1/22.1.png"));
            o1_5.Add(new Image("1/22.2.png"));
            o1_5.Add(new Image("1/22.3.png"));
            Question p1_5 = new Question("Slike u gornjem redu su povezane na neki način. Odabrati sliku koja je povezana sa slikom u donjem redu.", "1", o1_5, new Image("1/22.png"), 1);
            _questions.Add(p1_5);

            List<Data> o1_6 = new List<Data>();
            o1_6.Add(new Image("1/train1.png"));
            o1_6.Add(new Image("1/train2.png"));
            o1_6.Add(new Image("1/train3.png"));
            o1_6.Add(new Image("1/train4.png"));
            Question p1_6 = new Question("Odabrati sliku koja popounjava niz.", "4", o1_6, new Image("1/train0.png"), 1);
            _questions.Add(p1_6);

            List<Data> o1_7 = new List<Data>();
            o1_7.Add(new Image("1/calc1.png"));
            o1_7.Add(new Image("1/calc2.png"));
            o1_7.Add(new Image("1/calc3.png"));
            Question p1_7 = new Question("Odabrati sliku koja popounjava niz.", "2", o1_7, new Image("1/calc0.png"), 1);
            _questions.Add(p1_7);

            List<Data> o1_8 = new List<Data>();
            o1_8.Add(new Image("1/20.1.png"));
            o1_8.Add(new Image("1/20.2.png"));
            o1_8.Add(new Image("1/20.3.png"));
            Question p1_8 = new Question("Odabrati kako će papir izgledati nakon otvaranja.", "1", o1_8, new Image("1/20.png"), 1);
            _questions.Add(p1_8);

            List<Data> o1_9 = new List<Data>();
            o1_9.Add(new Image("1/26.1.png"));
            o1_9.Add(new Image("1/26.2.png"));
            o1_9.Add(new Image("1/26.3.png"));
            Question p1_9 = new Question("Odabrati kako će papir izgledati nakon otvaranja.", "2", o1_9, new Image("1/26.png"), 1);
            _questions.Add(p1_9);

            List<Data> o1_10 = new List<Data>();
            o1_10.Add(new Image("1/23.1.png"));
            o1_10.Add(new Image("1/23.2.png"));
            o1_10.Add(new Image("1/23.3.png"));
            Question p1_10 = new Question("Odabrati sliku koja se slaže sa ponuđenim nizom slika.", "2", o1_10, new Image("1/23.png"), 1);
            _questions.Add(p1_10);

            #endregion

            #region 2. tip testova

            List<Data> o2_1 = new List<Data>();
            o2_1.Add(new Image("2/sg_candle.gif"));
            o2_1.Add(new Image("2/sg_flashlight.gif"));
            o2_1.Add(new Image("2/sg_switch.gif"));
            o2_1.Add(new Image("2/sg_tea_pot.gif"));
            Question p2_1 = new Question("Slike u gornjem redu su povezane na neki način. Odabrati sliku koja je povezana sa slikom u donjem redu.", "1", o2_1, new Image("2/Q8.png"), 1);
            _questions.Add(p2_1);

            List<Data> o2_2 = new List<Data>();
            o2_2.Add(new Image("2/Q15A1.png"));
            o2_2.Add(new Image("2/Q15A2.png"));
            o2_2.Add(new Image("2/Q15A3.png"));
            o2_2.Add(new Image("2/Q15A4.png"));
            Question p2_2 = new Question("Milan radi u laboratoriji. Koji od predmeta bi trebao da koristi?", "1", o2_2, new Text(""), 1);
            _questions.Add(p2_2);

            #endregion

            #region 3-ci tip testova
            ///////////tip testova 3////////////////////////////
            List<Data> o3_1 = new List<Data>();
            o3_1.Add(new Text("cvet"));
            o3_1.Add(new Text("seme"));
            o3_1.Add(new Text("drvo"));
            o3_1.Add(new Text("perunika"));
            o3_1.Add(new Text("jama"));
            Question p3_1 = new Question("Prvi par reči povezan je na određen način. Izabrati reč koja upotpunjuje drugi par reči tako da reci budu povezane kao kod prvog para.", "1", o3_1, new Text("breskva → voće : ljiljan → "), 3);
            _questions.Add(p3_1);

            List<Data> o3_2 = new List<Data>();
            o3_2.Add(new Text("vlažna"));
            o3_2.Add(new Text("topla"));
            o3_2.Add(new Text("sveža"));
            o3_2.Add(new Text("postena"));
            o3_2.Add(new Text("slomljena"));
            Question p3_2 = new Question("Izaberite reč koja najbolje dovršava rečenicu.", "1", o3_2, new Text("Milan je vratio majicu u sušilicu za odeću jer je još bila _________."), 3);
            _questions.Add(p3_2);

            List<Data> o3_3 = new List<Data>();
            o3_3.Add(new Text("dzepovi"));
            o3_3.Add(new Text("pantalone"));
            o3_3.Add(new Text("veš"));
            o3_3.Add(new Text("stil"));
            o3_3.Add(new Text("ormar"));
            Question p3_3 = new Question("Izaberite reč koja najbolje odgovara grupi.", "2", o3_3, new Text("čarape sako košulje"), 3);
            _questions.Add(p3_3);

            List<Data> o3_4 = new List<Data>();
            o3_4.Add(new Text("20"));
            o3_4.Add(new Text("22"));
            o3_4.Add(new Text("25"));
            o3_4.Add(new Text("30"));
            o3_4.Add(new Text("40"));
            Question p3_4 = new Question("Odaberite broj koji upotpunjuje treći par tako da pokazuje isti odnos kao prva dva para.", "2", o3_4, new Text("[2 → 4]       [17 → 19]       [20 → ?]"), 3);
            _questions.Add(p3_4);

            List<Data> o3_5 = new List<Data>();
            o3_5.Add(new Text("55"));
            o3_5.Add(new Text("54"));
            o3_5.Add(new Text("40"));
            o3_5.Add(new Text("38"));
            o3_5.Add(new Text("60"));
            Question p3_5 = new Question("Odaberite broj koji upotpunjuje treći par tako da pokazuje isti odnos kao prva dva para.", "1", o3_5, new Text("[10 → 7]       [26 → 23]       [58 → ?]"), 3);
            _questions.Add(p3_5);

            List<Data> o3_6 = new List<Data>();
            o3_6.Add(new Text("4"));
            o3_6.Add(new Text("4.5"));
            o3_6.Add(new Text("5"));
            o3_6.Add(new Text("5.3"));
            o3_6.Add(new Text("45"));
            Question p3_6 = new Question("Koji broj je sledeći u nizu.", "1", o3_6, new Text("0.5     1     1.5     2     2.5     3     3.5     ?"), 3);
            _questions.Add(p3_6);

            List<Data> o3_7 = new List<Data>();
            o3_7.Add(new Text("35"));
            o3_7.Add(new Text("34"));
            o3_7.Add(new Text("16"));
            o3_7.Add(new Text("17"));
            o3_7.Add(new Text("18"));
            Question p3_7 = new Question("Rešiti", "4", o3_6, new Text("26 =  ?  + 9"), 3);
            _questions.Add(p3_7);

            List<Data> o3_8 = new List<Data>();
            o3_8.Add(new Image("3/a3_8_1.png"));
            o3_8.Add(new Image("3/a3_8_2.png"));
            o3_8.Add(new Image("3/a3_8_3.png"));
            o3_8.Add(new Image("3/a3_8_4.png"));
            o3_8.Add(new Image("3/a3_8_5.png"));
            Question p3_8 = new Question("Pogledajte kako se savija kvadratni komad papira i probija rupama. Izaberite sliku koja pokazuje kako ce papir izgledati kada se potpuno rasklopi.", "3", o3_8, new Image("3/q3_8.png"), 3);
            _questions.Add(p3_8);


            List<Data> o3_9 = new List<Data>();
            o3_9.Add(new Image("3/a3_9_1.png"));
            o3_9.Add(new Image("3/a3_9_2.png"));
            o3_9.Add(new Image("3/a3_9_3.png"));
            o3_9.Add(new Image("3/a3_9_4.png"));
            o3_9.Add(new Image("3/a3_9_5.png"));
            Question p3_9 = new Question("Pogledajte kako se savija kvadratni komad papira i probija rupama. Izaberite sliku koja pokazuje kako ce papir izgledati kada se potpuno rasklopi.", "5", o3_9, new Image("3/q3_9.png"), 3);
            _questions.Add(p3_9);

            List<Data> o3_10 = new List<Data>();
            o3_10.Add(new Image("3/a3_10_1.png"));
            o3_10.Add(new Image("3/a3_10_2.png"));
            o3_10.Add(new Image("3/a3_10_3.png"));
            o3_10.Add(new Image("3/a3_10_4.png"));
            o3_10.Add(new Image("3/a3_10_5.png"));
            Question p3_10 = new Question("Dati oblici na vrhu imaju određeni obrazac. Izaberite odgovor za donju sliku koji sledi isti obrazac.", "2", o3_10, new Image("3/q3_10.png"), 3);
            _questions.Add(p3_10);
            #endregion

            #region 4-ti tip testova
            ///////////tip testova 4////////////////////////////
            List<Data> o4_1 = new List<Data>();
            o4_1.Add(new Text("kost"));
            o4_1.Add(new Text("srce"));
            o4_1.Add(new Text("koža"));
            o4_1.Add(new Text("kosa"));
            o4_1.Add(new Text("želudac"));

            Question p4_1 = new Question("Prvi par reči povezan je na određen način. Izabrati reč koja upotpunjuje drugi par reči tako da reci budu povezane kao kod prvog para.", "3", o4_1, new Text("jaje → ljuska : osoba → "), 4);
            _questions.Add(p4_1);


            List<Data> o4_2 = new List<Data>();
            o4_2.Add(new Text("ljobomoran"));
            o4_2.Add(new Text("mrzeo"));
            o4_2.Add(new Text("borio"));
            o4_2.Add(new Text("zavideo"));
            o4_2.Add(new Text("sažaljen"));
            Question p4_2 = new Question("Izaberite reč koja najbolje dovršava rečenicu.", "4", o4_2, new Text("Milan ________ dok su se ostala deca zabavljala u letnjem kampu, dok je on ostajao kod kuće tokom leta"), 4);
            _questions.Add(p4_2);

            List<Data> o4_3 = new List<Data>();
            o4_3.Add(new Text("prtljag"));
            o4_3.Add(new Text("aktentašna"));
            o4_3.Add(new Text("kaiš"));
            o4_3.Add(new Text("sanduk"));
            o4_3.Add(new Text("novčanik"));
            Question p4_3 = new Question("Izaberite reč koja najbolje odgovara grupi.", "2", o4_3, new Text("ranac torbica torba"), 4);
            _questions.Add(p4_3);


            List<Data> o4_4 = new List<Data>();
            o4_4.Add(new Text("30"));
            o4_4.Add(new Text("42"));
            o4_4.Add(new Text("48"));
            o4_4.Add(new Text("56"));
            o4_4.Add(new Text("51"));
            Question p4_4 = new Question("Odaberite broj koji upotpunjuje treći par tako da pokazuje isti odnos kao prva dva para.", "4", o4_4, new Text("[21 → 84]       [7 → 28]       [14 → ?]"), 4);
            _questions.Add(p4_4);

            List<Data> o4_5 = new List<Data>();
            o4_5.Add(new Text("5"));
            o4_5.Add(new Text("1"));
            o4_5.Add(new Text("3"));
            o4_5.Add(new Text("2"));
            o4_5.Add(new Text("4"));
            Question p4_5 = new Question("Rešiti.", "1", o4_5, new Text("2 × 6 =  ?  + 7"), 4);
            _questions.Add(p4_5);

            List<Data> o4_6 = new List<Data>();
            o4_6.Add(new Text("6"));
            o4_6.Add(new Text("8"));
            o4_6.Add(new Text("4"));
            o4_6.Add(new Text("7"));
            o4_6.Add(new Text("5"));
            Question p4_6 = new Question("Koji broj je sledeći u nizu.", "5", o4_6, new Text("10     1     9     2     8     3     7     4     6     ?"), 4);
            _questions.Add(p4_6);

            List<Data> o4_7 = new List<Data>();
            o4_7.Add(new Image("4/a4_7_1.png"));
            o4_7.Add(new Image("4/a4_7_2.png"));
            o4_7.Add(new Image("4/a4_7_3.png"));
            o4_7.Add(new Image("4/a4_7_4.png"));
            o4_7.Add(new Image("4/a4_7_5.png"));
            Question p4_7 = new Question("Dati oblici na vrhu imaju određeni obrazac. Izaberite odgovor za donju sliku koji sledi isti obrazac.", "2", o4_7, new Image("4/q4_7.png"), 4);
            _questions.Add(p4_7);

            List<Data> o4_8 = new List<Data>();
            o4_8.Add(new Image("4/a4_8_1.png"));
            o4_8.Add(new Image("4/a4_8_2.png"));
            o4_8.Add(new Image("4/a4_8_3.png"));
            o4_8.Add(new Image("4/a4_8_4.png"));
            o4_8.Add(new Image("4/a4_8_5.png"));
            Question p4_8 = new Question("Dati oblici imaju određeni obrazac. Izaberite odgovarajući odgovor koji sledi isti obrazac", "1", o4_8, new Image("4/q4_8.png"), 4);
            _questions.Add(p4_8);

            List<Data> o4_9 = new List<Data>();
            o4_9.Add(new Image("4/a4_9_1.png"));
            o4_9.Add(new Image("4/a4_9_2.png"));
            o4_9.Add(new Image("4/a4_9_3.png"));
            o4_9.Add(new Image("4/a4_9_4.png"));
            o4_9.Add(new Image("4/a4_9_5.png"));
            Question p4_9 = new Question("Pogledajte kako se savija kvadratni komad papira i probija rupama. Izaberite sliku koja pokazuje kako ce papir izgledati kada se potpuno rasklopi.", "3", o4_9, new Image("4/q4_9.png"), 4);
            _questions.Add(p4_9);

            List<Data> o4_10 = new List<Data>();
            o4_10.Add(new Image("4/a4_10_1.png"));
            o4_10.Add(new Image("4/a4_10_2.png"));
            o4_10.Add(new Image("4/a4_10_3.png"));
            o4_10.Add(new Image("4/a4_10_4.png"));
            o4_10.Add(new Image("4/a4_10_5.png"));
            Question p4_10 = new Question("Dati oblici na vrhu imaju određeni obrazac. Izaberite odgovor za donju sliku koji sledi isti obrazac.", "5", o4_10, new Image("4/q4_10.png"), 4);
            _questions.Add(p4_10);

            #endregion


            #region 5-ti tip testova
            ///////////tip testova 5////////////////////////////
            List<Data> o5_1 = new List<Data>();
            o5_1.Add(new Text("Medicina"));
            o5_1.Add(new Text("Izlečen"));
            o5_1.Add(new Text("Agent"));
            o5_1.Add(new Text("Bolnica"));
            o5_1.Add(new Text("Doktor"));
            Question p5_1 = new Question("Prvi par reči povezan je na određen način. Izabrati reč koja upotpunjuje drugi par reči tako da reci budu povezane kao kod prvog para.", "2", o5_1, new Text("nagovoriti → ubediti : lečiti → "), 5);
            _questions.Add(p5_1);

            List<Data> o5_2 = new List<Data>();
            o5_2.Add(new Text("klisuru .. upozorila"));
            o5_2.Add(new Text("brdo .. podstila"));
            o5_2.Add(new Text("potok .. zabrinuta"));
            o5_2.Add(new Text("reku .. čestita"));
            o5_2.Add(new Text("klisuru .. oprezana"));
            Question p5_2 = new Question("Izaberite reči koje najbolje dovršavaju rečenicu.", "1", o5_2, new Text("Kada krenete na izlet, pazite da ne upadnete u ________! Markova majka je ___________ njega"), 5);
            _questions.Add(p5_2);


            List<Data> o5_3 = new List<Data>();
            o5_3.Add(new Text("pravac"));
            o5_3.Add(new Text("horizont"));
            o5_3.Add(new Text("verbalno"));
            o5_3.Add(new Text("dijagonalno"));
            o5_3.Add(new Text("brzo"));
            Question p5_3 = new Question("Izaberite reč koja najbolje odgovara grupi.", "4", o5_3, new Text("horizontala vertikala paralela"), 5);
            _questions.Add(p5_3);

            List<Data> o5_4 = new List<Data>();
            o5_4.Add(new Text("Četvrtak"));
            o5_4.Add(new Text("April"));
            o5_4.Add(new Text("Avgust"));
            o5_4.Add(new Text("Subota"));
            o5_4.Add(new Text("Februar"));
            Question p5_4 = new Question("Prvi par reči povezan je na određen način. Izabrati reč koja upotpunjuje drugi par reči tako da reci budu povezane kao kod prvog para.", "2", o5_4, new Text("Utorak → Sreda : Mart → "), 5);
            _questions.Add(p5_4);

            List<Data> o5_5 = new List<Data>();
            o5_5.Add(new Text("31"));
            o5_5.Add(new Text("30"));
            o5_5.Add(new Text("7"));
            o5_5.Add(new Text("5"));
            o5_5.Add(new Text("3"));
            Question p5_5 = new Question("Odaberite broj koji upotpunjuje treći par tako da pokazuje isti odnos kao prva dva para.", "4", o5_5, new Text("[28 → 4]       [21 → 3]       [35 → ?]"), 5);
            _questions.Add(p5_5);

            List<Data> o5_6 = new List<Data>();
            o5_6.Add(new Text("250"));
            o5_6.Add(new Text("125"));
            o5_6.Add(new Text("100"));
            o5_6.Add(new Text("75"));
            o5_6.Add(new Text("25"));
            Question p5_6 = new Question("Rešiti", "2", o5_6, new Text("25 = ? ÷ 5"), 5);
            _questions.Add(p5_6);


            List<Data> o5_7 = new List<Data>();
            o5_7.Add(new Text("10"));
            o5_7.Add(new Text("14"));
            o5_7.Add(new Text("16"));
            o5_7.Add(new Text("18"));
            o5_7.Add(new Text("20"));
            Question p5_7 = new Question("Koji broj je sledeći u nizu.", "2", o5_7, new Text("2     14     6     18     10     22     ?"), 5);
            _questions.Add(p5_7);

            List<Data> o5_8 = new List<Data>();
            o5_8.Add(new Image("5/a5_8_1.png"));
            o5_8.Add(new Image("5/a5_8_2.png"));
            o5_8.Add(new Image("5/a5_8_3.png"));
            o5_8.Add(new Image("5/a5_8_4.png"));
            o5_8.Add(new Image("5/a5_8_5.png"));
            Question p5_8 = new Question("Odaberite oblik koji upotpunjuje donji par tako da ima isti odnos kao gornji.", "3", o5_8, new Image("5/q5_8.png"), 5);
            _questions.Add(p5_8);

            List<Data> o5_9 = new List<Data>();
            o5_9.Add(new Image("5/a5_9_1.png"));
            o5_9.Add(new Image("5/a5_9_2.png"));
            o5_9.Add(new Image("5/a5_9_3.png"));
            o5_9.Add(new Image("5/a5_9_4.png"));
            o5_9.Add(new Image("5/a5_9_5.png"));
            Question p5_9 = new Question("Dati oblici imaju određeni obrazac. Izaberite odgovor koji sledi isti obrazac.", "1", o5_9, new Image("5/q5_9.png"), 5);
            _questions.Add(p5_9);

            List<Data> o5_10 = new List<Data>();
            o5_10.Add(new Image("5/a5_10_1.png"));
            o5_10.Add(new Image("5/a5_10_2.png"));
            o5_10.Add(new Image("5/a5_10_3.png"));
            o5_10.Add(new Image("5/a5_10_4.png"));
            o5_10.Add(new Image("5/a5_10_5.png"));
            Question p5_10 = new Question("Pogledajte kako se savija kvadratni komad papira i probija rupama. Izaberite sliku koja pokazuje kako ce papir izgledati kada se potpuno rasklopi.", "4", o5_10, new Image("5/q5_10.png"), 5);
            _questions.Add(p5_10);
            #endregion


            #region 6-ti tip testova
            ///////////tip testova 6////////////////////////////


            List<Data> o6_1 = new List<Data>();
            o6_1.Add(new Text("biljka"));
            o6_1.Add(new Text("iskustvo"));
            o6_1.Add(new Text("obuka"));
            o6_1.Add(new Text("pametan"));
            o6_1.Add(new Text("razumevanje"));
            Question p6_1 = new Question("Prvi par reči povezan je na određen način. Izabrati reč koja upotpunjuje drugi par reči tako da reci budu povezane kao kod prvog para.", "2", o6_1, new Text("mudrac → mudrost : stručnjak → "), 6);
            _questions.Add(p6_1);

            List<Data> o6_2 = new List<Data>();
            o6_2.Add(new Text("razmatrati .. presuda"));
            o6_2.Add(new Text("rečenica .. trvrdio"));
            o6_2.Add(new Text("misli .. sud"));
            o6_2.Add(new Text("dužnost .. suđenje"));
            o6_2.Add(new Text("dogovoriti .. odluka"));
            Question p6_2 = new Question("Izaberite reči koje najbolje dovršavaju rečenicu.", "1", o6_2, new Text("Porotoa je ____________ duže vreme pre nego sto je objavila svoju ___________."), 6);
            _questions.Add(p6_2);

            List<Data> o6_3 = new List<Data>();
            o6_3.Add(new Text("medved"));
            o6_3.Add(new Text("vuk"));
            o6_3.Add(new Text("pas"));
            o6_3.Add(new Text("lav"));
            o6_3.Add(new Text("ajkula"));
            Question p6_3 = new Question("Izaberite reč koja najbolje odgovara grupi.", "4", o6_3, new Text("jaguar leopard puma"), 6);
            _questions.Add(p6_3);

            List<Data> o6_4 = new List<Data>();
            o6_4.Add(new Text("26"));
            o6_4.Add(new Text("22"));
            o6_4.Add(new Text("21"));
            o6_4.Add(new Text("15"));
            o6_4.Add(new Text("11"));
            Question p6_4 = new Question("Rešiti.", "1", o6_4, new Text(" ?  = x + 15 ; x = 11"), 6);
            _questions.Add(p6_4);

            List<Data> o6_5 = new List<Data>();
            o6_5.Add(new Text("20"));
            o6_5.Add(new Text("21"));
            o6_5.Add(new Text("22"));
            o6_5.Add(new Text("23"));
            o6_5.Add(new Text("24"));
            Question p6_5 = new Question("Odaberite broj koji upotpunjuje treći par tako da pokazuje isti odnos kao prva dva para.", "2", o6_5, new Text("[3 → 13]       [4 → 17]       [5 → ?]"), 6);
            _questions.Add(p6_5);

            List<Data> o6_6 = new List<Data>();
            o6_6.Add(new Text("48"));
            o6_6.Add(new Text("30"));
            o6_6.Add(new Text("21"));
            o6_6.Add(new Text("12"));
            o6_6.Add(new Text("6"));
            Question p6_6 = new Question("Rešiti.", "3", o6_6, new Text(" ?  - 6 = 5 × k ; k = 12 ÷ 4 "), 6);
            _questions.Add(p6_6);

            List<Data> o6_7 = new List<Data>();
            o6_7.Add(new Text("16"));
            o6_7.Add(new Text("18"));
            o6_7.Add(new Text("20"));
            o6_7.Add(new Text("22"));
            o6_7.Add(new Text("24"));
            Question p6_7 = new Question("Koji broj je sledeći u nizu.", "1", o6_7, new Text("2     4     8     4     8     16     8     ?"), 6);
            _questions.Add(p6_7);

            List<Data> o6_8 = new List<Data>();
            o6_8.Add(new Image("6/a6_8_1.png"));
            o6_8.Add(new Image("6/a6_8_2.png"));
            o6_8.Add(new Image("6/a6_8_3.png"));
            o6_8.Add(new Image("6/a6_8_4.png"));
            o6_8.Add(new Image("6/a6_8_5.png"));
            Question p6_8 = new Question("Odaberite oblik koji upotpunjuje donji par tako da ima isti odnos kao gornji.", "2", o6_8, new Image("6/q6_8.png"), 6);
            _questions.Add(p6_8);

            List<Data> o6_9 = new List<Data>();
            o6_9.Add(new Image("6/a6_9_1.png"));
            o6_9.Add(new Image("6/a6_9_2.png"));
            o6_9.Add(new Image("6/a6_9_3.png"));
            o6_9.Add(new Image("6/a6_9_4.png"));
            o6_9.Add(new Image("6/a6_9_5.png"));
            Question p6_9 = new Question("Dati oblici imaju određeni obrazac. Izaberite odgovor koji sledi isti obrazac.", "1", o6_9, new Image("6/q6_9.png"), 6);
            _questions.Add(p6_9);

            List<Data> o6_10 = new List<Data>();
            o6_10.Add(new Image("6/a6_10_1.png"));
            o6_10.Add(new Image("6/a6_10_2.png"));
            o6_10.Add(new Image("6/a6_10_3.png"));
            o6_10.Add(new Image("6/a6_10_4.png"));
            o6_10.Add(new Image("6/a6_10_5.png"));
            Question p6_10 = new Question("Pogledajte kako se savija kvadratni komad papira i probija rupama. Izaberite sliku koja pokazuje kako ce papir izgledati kada se potpuno rasklopi.", "5", o6_10, new Image("6/q6_10.png"), 6);
            _questions.Add(p6_10);


            #endregion


            ///////////tip testova 7////////////////////////////
            ///
            List<Data> odgovori1 = new List<Data>();
            odgovori1.Add(new Text("10"));
            odgovori1.Add(new Text("12"));
            odgovori1.Add(new Text("15"));
            Question p2 = new Question("Pitanj 2", "2", odgovori1, new Text("10"), 7);

            _questions.Add(p2);




            ///////////tip testova 8////////////////////////////


        }
    }
}