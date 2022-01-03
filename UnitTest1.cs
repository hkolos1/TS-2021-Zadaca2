using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zadaca1;
using System.Collections.Generic;


namespace UnitTestiranje
{
    [TestClass]
    public class UnitTest
    {
        List<Osoba> osoba = new List<Osoba>();

        [TestInitialize]
        public void napuni()
        {
            
            osoba.Add(new Osoba("harun", "kolos", "1997-09-03", 187, 85));
            osoba.Add(new Osoba("haso", "hasic", "1998-09-03", 185, 80));
            osoba.Add(new Osoba("mujo", "mujic", "2001-12-13", 181, 81));
            osoba.Add(new Osoba("berin", "masovic", "2001-05-12", 180, 75));

        }

        [TestMethod]
        public void TestZaTestInitialize()
        {
            AlgoritamBubbleSort.BubbleSort(ref osoba, 0);

            Assert.AreEqual(osoba[0].ime, "berin");
            Assert.AreEqual(osoba[1].ime, "harun");
            Assert.AreEqual(osoba[2].ime, "haso");
            Assert.AreEqual(osoba[3].ime, "mujo");

        }

        [TestMethod]
        public void SelectionSortTest()
        {
            Lazna a = new Lazna();
            string[] imena = a.ime();

            AlgoritamSelectionSort.SelectionSort(ref imena);

            Assert.AreEqual(imena[0], "Armin");
            Assert.AreEqual(imena[1], "Hamza");
            Assert.AreEqual(imena[2], "Harun");
            Assert.AreEqual(imena[3], "Mirza");


            Lazna b = new Lazna();
            string[] prezima = b.prezime();

            AlgoritamSelectionSort.SelectionSort(ref prezima);

            Assert.AreEqual(prezima[0], "Alic");
            Assert.AreEqual(prezima[1], "Hodzic");
            Assert.AreEqual(prezima[2], "Kolos");
            Assert.AreEqual(prezima[3], "Mesihovic");



            Lazna c = new Lazna();
            int[] tezine = c.tezina();

            AlgoritamSelectionSort.SelectionSort(ref tezine);

            Assert.AreEqual(tezine[0], 64);
            Assert.AreEqual(tezine[1], 72);
            Assert.AreEqual(tezine[2], 80);
            Assert.AreEqual(tezine[3], 91);


            Lazna d = new Lazna();
            int[] visine = d.visina();

            AlgoritamSelectionSort.SelectionSort(ref visine);

            Assert.AreEqual(visine[0], 150);
            Assert.AreEqual(visine[1], 171);
            Assert.AreEqual(visine[2], 185);
            Assert.AreEqual(visine[3], 194);

            Lazna e = new Lazna();
            string[] datum = e.datum_rodenja();

            AlgoritamSelectionSort.SelectionSort(ref datum);

            Assert.AreEqual(datum[0], "1995-04-17");
            Assert.AreEqual(datum[1], "1999-12-06");
            Assert.AreEqual(datum[2], "2001-09-03");
            Assert.AreEqual(datum[3], "2010-11-20");

           
            char[] charovi = { 'A', 'Z', 'G' };

            AlgoritamSelectionSort.SelectionSort(ref charovi);
            Assert.AreEqual(charovi[0], 'A');
            Assert.AreEqual(charovi[1], 'G');
            Assert.AreEqual(charovi[2], 'Z');


            double[] dublovi = { 2.65, 1.44, 2.54 };

            AlgoritamSelectionSort.SelectionSort(ref dublovi);
            Assert.AreEqual(dublovi[0], 1.44);
            Assert.AreEqual(dublovi[1], 2.54);
            Assert.AreEqual(dublovi[2], 2.65);
        }

        
        [TestMethod]
        public void ShellSortTest()
        {
            Lazna a = new Lazna();
            string[] imena = a.ime();

            AlgoritamShellSort.ShellSort(ref imena);

            Assert.AreEqual(imena[0], "Armin");
            Assert.AreEqual(imena[1], "Hamza");
            Assert.AreEqual(imena[2], "Harun");
            Assert.AreEqual(imena[3], "Mirza");

            Lazna b = new Lazna();
            string[] prezima = b.prezime();

            AlgoritamShellSort.ShellSort(ref prezima);

            Assert.AreEqual(prezima[0], "Alic");
            Assert.AreEqual(prezima[1], "Hodzic");
            Assert.AreEqual(prezima[2], "Kolos");
            Assert.AreEqual(prezima[3], "Mesihovic");



            Lazna c = new Lazna();
            int[] tezine = c.tezina();

            AlgoritamShellSort.ShellSort(ref tezine);

            Assert.AreEqual(tezine[0], 64);
            Assert.AreEqual(tezine[1], 72);
            Assert.AreEqual(tezine[2], 80);
            Assert.AreEqual(tezine[3], 91);


            Lazna d = new Lazna();
            int[] visine = d.visina();

            AlgoritamShellSort.ShellSort(ref visine);

            Assert.AreEqual(visine[0], 150);
            Assert.AreEqual(visine[1], 171);
            Assert.AreEqual(visine[2], 185);
            Assert.AreEqual(visine[3], 194);

            Lazna e = new Lazna();
            string[] datum = e.datum_rodenja();

            AlgoritamShellSort.ShellSort(ref datum);

            Assert.AreEqual(datum[0], "1995-04-17");
            Assert.AreEqual(datum[1], "1999-12-06");
            Assert.AreEqual(datum[2], "2001-09-03");
            Assert.AreEqual(datum[3], "2010-11-20");


            char[] charovi = { 'A', 'Z', 'G' };

            AlgoritamShellSort.ShellSort(ref charovi);
            Assert.AreEqual(charovi[0], 'A');
            Assert.AreEqual(charovi[1], 'G');
            Assert.AreEqual(charovi[2], 'Z');


            double[] dublovi = { 2.65, 1.44, 2.54 };

            AlgoritamShellSort.ShellSort(ref dublovi);
            Assert.AreEqual(dublovi[0], 1.44);
            Assert.AreEqual(dublovi[1], 2.54);
            Assert.AreEqual(dublovi[2], 2.65);
        }

        [TestMethod]
        public void BubbleSortTest()
        {

            Lazna a = new Lazna();
            string[] imena = a.ime();

            AlgoritamBubbleSort.BubbleSort(ref imena);

            Assert.AreEqual(imena[0], "Armin");
            Assert.AreEqual(imena[1], "Hamza");
            Assert.AreEqual(imena[2], "Harun");
            Assert.AreEqual(imena[3], "Mirza");


            Lazna b = new Lazna();
            string[] prezima = b.prezime();

            AlgoritamBubbleSort.BubbleSort(ref prezima);

            Assert.AreEqual(prezima[0], "Alic");
            Assert.AreEqual(prezima[1], "Hodzic");
            Assert.AreEqual(prezima[2], "Kolos");
            Assert.AreEqual(prezima[3], "Mesihovic");



            Lazna c = new Lazna();
            int[] tezine = c.tezina();

            AlgoritamBubbleSort.BubbleSort(ref tezine);

            Assert.AreEqual(tezine[0], 64);
            Assert.AreEqual(tezine[1], 72);
            Assert.AreEqual(tezine[2], 80);
            Assert.AreEqual(tezine[3], 91);

            Lazna d = new Lazna();
            int[] visine = d.visina();

            AlgoritamBubbleSort.BubbleSort(ref visine);

            Assert.AreEqual(visine[0], 150);
            Assert.AreEqual(visine[1], 171);
            Assert.AreEqual(visine[2], 185);
            Assert.AreEqual(visine[3], 194);


            Lazna e = new Lazna();
            string[] datum = e.datum_rodenja();

            AlgoritamBubbleSort.BubbleSort(ref datum);

            Assert.AreEqual(datum[0], "1995-04-17");
            Assert.AreEqual(datum[1], "1999-12-06");
            Assert.AreEqual(datum[2], "2001-09-03");
            Assert.AreEqual(datum[3], "2010-11-20");



            char[] charovi = { 'A', 'Z', 'G' };

            AlgoritamBubbleSort.BubbleSort(ref charovi);
            Assert.AreEqual(charovi[0], 'A');
            Assert.AreEqual(charovi[1], 'G');
            Assert.AreEqual(charovi[2], 'Z');


            double[] dublovi = { 2.65, 1.44, 2.54 };

            AlgoritamBubbleSort.BubbleSort(ref dublovi);
            Assert.AreEqual(dublovi[0], 1.44);
            Assert.AreEqual(dublovi[1], 2.54);
            Assert.AreEqual(dublovi[2], 2.65);
        }

        [TestMethod]
        public void InsertionSortTest()
        {

            Lazna a = new Lazna();
            string[] imena = a.ime();

            AlgoritamInsertionSort.InsertionSort(ref imena);

            Assert.AreEqual(imena[0], "Armin");
            Assert.AreEqual(imena[1], "Hamza");
            Assert.AreEqual(imena[2], "Harun");
            Assert.AreEqual(imena[3], "Mirza");

            Lazna b = new Lazna();
            string[] prezima= b.prezime();

            AlgoritamInsertionSort.InsertionSort(ref prezima);

            Assert.AreEqual(prezima[0], "Alic");
            Assert.AreEqual(prezima[1], "Hodzic");
            Assert.AreEqual(prezima[2], "Kolos");
            Assert.AreEqual(prezima[3], "Mesihovic");



            Lazna c = new Lazna();
            int[] tezine = c.tezina();

            AlgoritamInsertionSort.InsertionSort(ref tezine);

            Assert.AreEqual(tezine[0], 64);
            Assert.AreEqual(tezine[1], 72);
            Assert.AreEqual(tezine[2], 80);
            Assert.AreEqual(tezine[3], 91);

            Lazna d = new Lazna();
            int[] visine = d.visina();

            AlgoritamInsertionSort.InsertionSort(ref visine);

            Assert.AreEqual(visine[0], 150);
            Assert.AreEqual(visine[1], 171);
            Assert.AreEqual(visine[2], 185);
            Assert.AreEqual(visine[3], 194);

            Lazna e = new Lazna();
            string[] datum = e.datum_rodenja();

            AlgoritamInsertionSort.InsertionSort(ref datum);

            Assert.AreEqual(datum[0], "1995-04-17");
            Assert.AreEqual(datum[1], "1999-12-06");
            Assert.AreEqual(datum[2], "2001-09-03");
            Assert.AreEqual(datum[3], "2010-11-20");



            char[] charovi = { 'A', 'Z', 'G' };

            AlgoritamInsertionSort.InsertionSort(ref charovi);
            Assert.AreEqual(charovi[0], 'A');
            Assert.AreEqual(charovi[1], 'G');
            Assert.AreEqual(charovi[2], 'Z');


            double[] dublovi = { 2.65, 1.44, 2.54 };

            AlgoritamInsertionSort.InsertionSort(ref dublovi);
            Assert.AreEqual(dublovi[0], 1.44);
            Assert.AreEqual(dublovi[1], 2.54);
            Assert.AreEqual(dublovi[2], 2.65);

        }


        [TestMethod]
        public void CombSortTest()
        {

            Lazna a = new Lazna();
            string[] imena = a.ime();

            AlgoritamCombSort.CombSort(ref imena);

            Assert.AreEqual(imena[0], "Armin");
            Assert.AreEqual(imena[1], "Hamza");
            Assert.AreEqual(imena[2], "Harun");
            Assert.AreEqual(imena[3], "Mirza");

            Lazna b = new Lazna();
            string[] prezima = b.prezime();

            AlgoritamCombSort.CombSort(ref prezima);

            Assert.AreEqual(prezima[0], "Alic");
            Assert.AreEqual(prezima[1], "Hodzic");
            Assert.AreEqual(prezima[2], "Kolos");
            Assert.AreEqual(prezima[3], "Mesihovic");



            Lazna c = new Lazna();
            int[] tezine = c.tezina();

            AlgoritamCombSort.CombSort(ref tezine);

            Assert.AreEqual(tezine[0], 64);
            Assert.AreEqual(tezine[1], 72);
            Assert.AreEqual(tezine[2], 80);
            Assert.AreEqual(tezine[3], 91);

            Lazna d = new Lazna();
            int[] visine = d.visina();

            AlgoritamCombSort.CombSort(ref visine);

            Assert.AreEqual(visine[0], 150);
            Assert.AreEqual(visine[1], 171);
            Assert.AreEqual(visine[2], 185);
            Assert.AreEqual(visine[3], 194);

            Lazna e = new Lazna();
            string[] datum = e.datum_rodenja();

            AlgoritamCombSort.CombSort(ref datum);

            Assert.AreEqual(datum[0], "1995-04-17");
            Assert.AreEqual(datum[1], "1999-12-06");
            Assert.AreEqual(datum[2], "2001-09-03");
            Assert.AreEqual(datum[3], "2010-11-20");

            char[] charovi = { 'A', 'Z', 'G' };

            AlgoritamCombSort.CombSort(ref charovi);
            Assert.AreEqual(charovi[0], 'A');
            Assert.AreEqual(charovi[1], 'G');
            Assert.AreEqual(charovi[2], 'Z');


            double[] dublovi = { 2.65, 1.44, 2.54 };

            AlgoritamCombSort.CombSort(ref dublovi);
            Assert.AreEqual(dublovi[0], 1.44);
            Assert.AreEqual(dublovi[1], 2.54);
            Assert.AreEqual(dublovi[2], 2.65);

        }


        [TestMethod]
        public void CocktailSortTest()
        {
            Lazna a = new Lazna();
            string[] imena = a.ime();

            AlgoritamCocktailSort.CocktailSort(ref imena);

            Assert.AreEqual(imena[0], "Armin");
            Assert.AreEqual(imena[1], "Hamza");
            Assert.AreEqual(imena[2], "Harun");
            Assert.AreEqual(imena[3], "Mirza");

            Lazna b = new Lazna();
            string[] prezima = b.prezime();

            AlgoritamCocktailSort.CocktailSort(ref prezima);

            Assert.AreEqual(prezima[0], "Alic");
            Assert.AreEqual(prezima[1], "Hodzic");
            Assert.AreEqual(prezima[2], "Kolos");
            Assert.AreEqual(prezima[3], "Mesihovic");



            Lazna c = new Lazna();
            int[] tezine = c.tezina();

            AlgoritamCocktailSort.CocktailSort(ref tezine);

            Assert.AreEqual(tezine[0], 64);
            Assert.AreEqual(tezine[1], 72);
            Assert.AreEqual(tezine[2], 80);
            Assert.AreEqual(tezine[3], 91);

            Lazna d = new Lazna();
            int[] visine = d.visina();

            AlgoritamCocktailSort.CocktailSort(ref visine);

            Assert.AreEqual(visine[0], 150);
            Assert.AreEqual(visine[1], 171);
            Assert.AreEqual(visine[2], 185);
            Assert.AreEqual(visine[3], 194);

            Lazna e = new Lazna();
            string[] datum = e.datum_rodenja();

            AlgoritamCocktailSort.CocktailSort(ref datum);

            Assert.AreEqual(datum[0], "1995-04-17");
            Assert.AreEqual(datum[1], "1999-12-06");
            Assert.AreEqual(datum[2], "2001-09-03");
            Assert.AreEqual(datum[3], "2010-11-20");


            char[] charovi = { 'A', 'Z', 'G' };

            AlgoritamCocktailSort.CocktailSort(ref charovi);
            Assert.AreEqual(charovi[0], 'A');
            Assert.AreEqual(charovi[1], 'G');
            Assert.AreEqual(charovi[2], 'Z');


            double[] dublovi = { 2.65, 1.44, 2.54 };

            AlgoritamCocktailSort.CocktailSort(ref dublovi);
            Assert.AreEqual(dublovi[0], 1.44);
            Assert.AreEqual(dublovi[1], 2.54);
            Assert.AreEqual(dublovi[2], 2.65);

        }


        [TestMethod]
        public void HeapSortTest()
        {
            Lazna a = new Lazna();
            string[] imena = a.ime();

            AlgoritamHeapSort.HeapSort(ref imena);

            Assert.AreEqual(imena[0], "Armin");
            Assert.AreEqual(imena[1], "Hamza");
            Assert.AreEqual(imena[2], "Harun");
            Assert.AreEqual(imena[3], "Mirza");

            Lazna b = new Lazna();
            string[] prezima = b.prezime();

            AlgoritamHeapSort.HeapSort(ref prezima);

            Assert.AreEqual(prezima[0], "Alic");
            Assert.AreEqual(prezima[1], "Hodzic");
            Assert.AreEqual(prezima[2], "Kolos");
            Assert.AreEqual(prezima[3], "Mesihovic");



            Lazna c = new Lazna();
            int[] tezine = c.tezina();

            AlgoritamHeapSort.HeapSort(ref tezine);

            Assert.AreEqual(tezine[0], 64);
            Assert.AreEqual(tezine[1], 72);
            Assert.AreEqual(tezine[2], 80);
            Assert.AreEqual(tezine[3], 91);

            Lazna d = new Lazna();
            int[] visine = d.visina();

            AlgoritamHeapSort.HeapSort(ref visine);

            Assert.AreEqual(visine[0], 150);
            Assert.AreEqual(visine[1], 171);
            Assert.AreEqual(visine[2], 185);
            Assert.AreEqual(visine[3], 194);

            Lazna e = new Lazna();
            string[] datum = e.datum_rodenja();

            AlgoritamHeapSort.HeapSort(ref datum);

            Assert.AreEqual(datum[0], "1995-04-17");
            Assert.AreEqual(datum[1], "1999-12-06");
            Assert.AreEqual(datum[2], "2001-09-03");
            Assert.AreEqual(datum[3], "2010-11-20");



            char[] charovi = { 'A', 'Z', 'G' };

            AlgoritamHeapSort.HeapSort(ref charovi);
            Assert.AreEqual(charovi[0], 'A');
            Assert.AreEqual(charovi[1], 'G');
            Assert.AreEqual(charovi[2], 'Z');


            double[] dublovi = { 2.65, 1.44, 2.54 };

            AlgoritamHeapSort.HeapSort(ref dublovi);
            Assert.AreEqual(dublovi[0], 1.44);
            Assert.AreEqual(dublovi[1], 2.54);
            Assert.AreEqual(dublovi[2], 2.65);

        }


        [TestMethod]
        public void GnomeSortTest()
        {
            Lazna a = new Lazna();
            string[] imena = a.ime();

            AlgoritamGnomeSort.GnomeSort(ref imena, 4);

            Assert.AreEqual(imena[0], "Armin");
            Assert.AreEqual(imena[1], "Hamza");
            Assert.AreEqual(imena[2], "Harun");
            Assert.AreEqual(imena[3], "Mirza");

            Lazna b = new Lazna();
            string[] prezima = b.prezime();

            AlgoritamGnomeSort.GnomeSort(ref prezima, 4);

            Assert.AreEqual(prezima[0], "Alic");
            Assert.AreEqual(prezima[1], "Hodzic");
            Assert.AreEqual(prezima[2], "Kolos");
            Assert.AreEqual(prezima[3], "Mesihovic");



            Lazna c = new Lazna();
            int[] tezine = c.tezina();

            AlgoritamGnomeSort.GnomeSort(ref tezine, 4);

            Assert.AreEqual(tezine[0], 64);
            Assert.AreEqual(tezine[1], 72);
            Assert.AreEqual(tezine[2], 80);
            Assert.AreEqual(tezine[3], 91);

            Lazna d = new Lazna();
            int[] visine = d.visina();

            AlgoritamGnomeSort.GnomeSort(ref visine, 4);

            Assert.AreEqual(visine[0], 150);
            Assert.AreEqual(visine[1], 171);
            Assert.AreEqual(visine[2], 185);
            Assert.AreEqual(visine[3], 194);

            Lazna e = new Lazna();
            string[] datum = e.datum_rodenja();

            AlgoritamGnomeSort.GnomeSort(ref datum, 4);

            Assert.AreEqual(datum[0], "1995-04-17");
            Assert.AreEqual(datum[1], "1999-12-06");
            Assert.AreEqual(datum[2], "2001-09-03");
            Assert.AreEqual(datum[3], "2010-11-20");



            char[] charovi = { 'A', 'Z', 'G' };

            AlgoritamGnomeSort.GnomeSort(ref charovi, 3);
            Assert.AreEqual(charovi[0], 'A');
            Assert.AreEqual(charovi[1], 'G');
            Assert.AreEqual(charovi[2], 'Z');


            double[] dublovi = { 2.65, 1.44, 2.54 };

            AlgoritamGnomeSort.GnomeSort(ref dublovi, 3);
            Assert.AreEqual(dublovi[0], 1.44);
            Assert.AreEqual(dublovi[1], 2.54);
            Assert.AreEqual(dublovi[2], 2.65);

        }


        [TestMethod]
        public void OddEvenSortTest()
        {
            Lazna a = new Lazna();
            string[] imena = a.ime();

            AlgoritamOddEvenSort.OddEvenSort(ref imena, 4);

            Assert.AreEqual(imena[0], "Armin");
            Assert.AreEqual(imena[1], "Hamza");
            Assert.AreEqual(imena[2], "Harun");
            Assert.AreEqual(imena[3], "Mirza");

            Lazna b = new Lazna();
            string[] prezima = b.prezime();

            AlgoritamOddEvenSort.OddEvenSort(ref prezima, 4);

            Assert.AreEqual(prezima[0], "Alic");
            Assert.AreEqual(prezima[1], "Hodzic");
            Assert.AreEqual(prezima[2], "Kolos");
            Assert.AreEqual(prezima[3], "Mesihovic");



            Lazna c = new Lazna();
            int[] tezine = c.tezina();

            AlgoritamOddEvenSort.OddEvenSort(ref tezine, 4);

            Assert.AreEqual(tezine[0], 64);
            Assert.AreEqual(tezine[1], 72);
            Assert.AreEqual(tezine[2], 80);
            Assert.AreEqual(tezine[3], 91);

            Lazna d = new Lazna();
            int[] visine = d.visina();

            AlgoritamOddEvenSort.OddEvenSort(ref visine, 4);

            Assert.AreEqual(visine[0], 150);
            Assert.AreEqual(visine[1], 171);
            Assert.AreEqual(visine[2], 185);
            Assert.AreEqual(visine[3], 194);

            Lazna e = new Lazna();
            string[] datum = e.datum_rodenja();

            AlgoritamOddEvenSort.OddEvenSort(ref datum, 4);

            Assert.AreEqual(datum[0], "1995-04-17");
            Assert.AreEqual(datum[1], "1999-12-06");
            Assert.AreEqual(datum[2], "2001-09-03");
            Assert.AreEqual(datum[3], "2010-11-20");



            char[] charovi = { 'A', 'Z', 'G' };

            AlgoritamOddEvenSort.OddEvenSort(ref charovi, 3);
            Assert.AreEqual(charovi[0], 'A');
            Assert.AreEqual(charovi[1], 'G');
            Assert.AreEqual(charovi[2], 'Z');


            double[] dublovi = { 2.65, 1.44, 2.54 };

            AlgoritamOddEvenSort.OddEvenSort(ref dublovi, 3);
            Assert.AreEqual(dublovi[0], 1.44);
            Assert.AreEqual(dublovi[1], 2.54);
            Assert.AreEqual(dublovi[2], 2.65);

        }

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    "|DataDirectory|\\testCsv.csv", "testCsv#csv", DataAccessMethod.Sequential),
                    DeploymentItem("testCsv.csv"), TestMethod]
        public void CSVTestIme()
        {
            string ime = testContextInstance.DataRow[0].ToString();
            string prezime = testContextInstance.DataRow[1].ToString();
            string datum = testContextInstance.DataRow[2].ToString();
            int visina = Int32.Parse(testContextInstance.DataRow[3].ToString());
            int tezina = Int32.Parse(testContextInstance.DataRow[3].ToString());

            Osoba o = new Osoba(ime, prezime, datum, visina, tezina);

            Assert.AreEqual(ime, o.ime);

        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    "|DataDirectory|\\testCsv.csv", "testCsv#csv", DataAccessMethod.Sequential),
                    DeploymentItem("testCsv.csv"), TestMethod]
        public void CSVTestPrezime()
        {
            string ime = testContextInstance.DataRow[0].ToString();
            string prezime = testContextInstance.DataRow[1].ToString();
            string datum = testContextInstance.DataRow[2].ToString();
            int visina = Int32.Parse(testContextInstance.DataRow[3].ToString());
            int tezina = Int32.Parse(testContextInstance.DataRow[3].ToString());

            Osoba o = new Osoba(ime, prezime, datum, visina, tezina);

            Assert.AreEqual(prezime, o.prezime);

        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    "|DataDirectory|\\testCsv.csv", "testCsv#csv", DataAccessMethod.Sequential),
                    DeploymentItem("testCsv.csv"), TestMethod]
        public void CSVTestTezina()
        {
            string ime = testContextInstance.DataRow[0].ToString();
            string prezime = testContextInstance.DataRow[1].ToString();
            string datum = testContextInstance.DataRow[2].ToString();
            int visina = Int32.Parse(testContextInstance.DataRow[3].ToString());
            int tezina = Int32.Parse(testContextInstance.DataRow[3].ToString());

            Osoba o = new Osoba(ime, prezime, datum, visina, tezina);

            Assert.AreEqual(tezina, o.tezina);
            
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    "|DataDirectory|\\testCsv.csv", "testCsv#csv", DataAccessMethod.Sequential),
                    DeploymentItem("testCsv.csv"), TestMethod]
        public void CSVTestVisina()
        {
            string ime = testContextInstance.DataRow[0].ToString();
            string prezime = testContextInstance.DataRow[1].ToString();
            string datum = testContextInstance.DataRow[2].ToString();
            int visina = Int32.Parse(testContextInstance.DataRow[3].ToString());
            int tezina = Int32.Parse(testContextInstance.DataRow[3].ToString());

            Osoba o = new Osoba(ime, prezime, datum, visina, tezina);

            Assert.AreEqual(visina, o.visina);

        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    "|DataDirectory|\\testCsv.csv", "testCsv#csv", DataAccessMethod.Sequential),
                    DeploymentItem("testCsv.csv"), TestMethod]
        public void CSVTestDatum()
        {
            string ime = testContextInstance.DataRow[0].ToString();
            string prezime = testContextInstance.DataRow[1].ToString();
            string datum = testContextInstance.DataRow[2].ToString();
            int visina = Int32.Parse(testContextInstance.DataRow[3].ToString());
            int tezina = Int32.Parse(testContextInstance.DataRow[3].ToString());

            Osoba o = new Osoba(ime, prezime, datum, visina, tezina);

            Assert.AreEqual(datum, o.datum_rodenja);

        }

        [TestMethod]
        public void TestSelectionSortOsoba()
        {
            List<Osoba> test1 = new List<Osoba>();
            test1.Add( new Osoba("harun", "kolos", "1997-09-03", 187, 85));
            test1.Add( new Osoba("haso", "hasic", "1998-09-03", 185, 80));
            test1.Add( new Osoba("mujo", "mujic", "2001-12-13", 181, 81));
            test1.Add( new Osoba("berin", "masovic", "2001-05-12", 180, 75));

            AlgoritamSelectionSort.SelectionSort(ref test1, 0);


            Assert.AreEqual("berin", test1[0].ime);
            Assert.AreEqual("kolos", test1[1].prezime);
            Assert.AreEqual("2001-12-13", test1[3].datum_rodenja);
            Assert.AreEqual(185, test1[2].visina);
            Assert.AreEqual(75, test1[0].tezina);


        }

        [TestMethod]
        public void TestShellSortOsoba()
        {
            List<Osoba> test1 = new List<Osoba>();
            test1.Add(new Osoba("harun", "kolos", "1997-09-03", 187, 85));
            test1.Add(new Osoba("haso", "hasic", "1998-09-03", 185, 80));
            test1.Add(new Osoba("mujo", "mujic", "2001-12-13", 181, 81));
            test1.Add(new Osoba("berin", "masovic", "2001-05-12", 180, 75));

            AlgoritamShellSort.ShellSort(ref test1, 0);


            Assert.AreEqual("berin", test1[0].ime);
            Assert.AreEqual("kolos", test1[1].prezime);
            Assert.AreEqual("2001-12-13", test1[3].datum_rodenja);
            Assert.AreEqual(185, test1[2].visina);
            Assert.AreEqual(75, test1[0].tezina);


        }

        [TestMethod]
        public void TestBubbleSortOsoba()
        {
            List<Osoba> test1 = new List<Osoba>();
            test1.Add(new Osoba("harun", "kolos", "1997-09-03", 187, 85));
            test1.Add(new Osoba("haso", "hasic", "1998-09-03", 185, 80));
            test1.Add(new Osoba("mujo", "mujic", "2001-12-13", 181, 81));
            test1.Add(new Osoba("berin", "masovic", "2001-05-12", 180, 75));

            AlgoritamBubbleSort.BubbleSort(ref test1, 0);


            Assert.AreEqual("berin", test1[0].ime);
            Assert.AreEqual("kolos", test1[1].prezime);
            Assert.AreEqual("2001-12-13", test1[3].datum_rodenja);
            Assert.AreEqual(185, test1[2].visina);
            Assert.AreEqual(75, test1[0].tezina);


        }

        [TestMethod]
        public void TestInsertionSortOsoba()
        {
            List<Osoba> test1 = new List<Osoba>();
            test1.Add(new Osoba("harun", "kolos", "1997-09-03", 187, 85));
            test1.Add(new Osoba("haso", "hasic", "1998-09-03", 185, 80));
            test1.Add(new Osoba("mujo", "mujic", "2001-12-13", 181, 81));
            test1.Add(new Osoba("berin", "masovic", "2001-05-12", 180, 75));

            AlgoritamInsertionSort.InsertionSort(ref test1, 0);


            Assert.AreEqual("berin", test1[0].ime);
            Assert.AreEqual("kolos", test1[1].prezime);
            Assert.AreEqual("2001-12-13", test1[3].datum_rodenja);
            Assert.AreEqual(185, test1[2].visina);
            Assert.AreEqual(75, test1[0].tezina);
        }

        [TestMethod]
        public void TestCombSortOsoba()
        {
            List<Osoba> test1 = new List<Osoba>();
            test1.Add(new Osoba("harun", "kolos", "1997-09-03", 187, 85));
            test1.Add(new Osoba("haso", "hasic", "1998-09-03", 185, 80));
            test1.Add(new Osoba("mujo", "mujic", "2001-12-13", 181, 81));
            test1.Add(new Osoba("berin", "masovic", "2001-05-12", 180, 75));

            AlgoritamCombSort.CombSort(ref test1, 0);


            Assert.AreEqual("berin", test1[0].ime);
            Assert.AreEqual("kolos", test1[1].prezime);
            Assert.AreEqual("2001-12-13", test1[3].datum_rodenja);
            Assert.AreEqual(185, test1[2].visina);
            Assert.AreEqual(75, test1[0].tezina);


        }

        [TestMethod]
        public void TestCocktailSortOsoba()
        {
            List<Osoba> test1 = new List<Osoba>();
            test1.Add(new Osoba("harun", "kolos", "1997-09-03", 187, 85));
            test1.Add(new Osoba("haso", "hasic", "1998-09-03", 185, 80));
            test1.Add(new Osoba("mujo", "mujic", "2001-12-13", 181, 81));
            test1.Add(new Osoba("berin", "masovic", "2001-05-12", 180, 75));

            AlgoritamCocktailSort.CocktailSort(ref test1, 0);


            Assert.AreEqual("berin", test1[0].ime);
            Assert.AreEqual("kolos", test1[1].prezime);
            Assert.AreEqual("2001-12-13", test1[3].datum_rodenja);
            Assert.AreEqual(185, test1[2].visina);
            Assert.AreEqual(75, test1[0].tezina);


        }

        [TestMethod]
        public void TestHeapSortOsoba()
        {
            List<Osoba> test1 = new List<Osoba>();
            test1.Add(new Osoba("harun", "kolos", "1997-09-03", 187, 85));
            test1.Add(new Osoba("haso", "hasic", "1998-09-03", 185, 80));
            test1.Add(new Osoba("mujo", "mujic", "2001-12-13", 181, 81));
            test1.Add(new Osoba("berin", "masovic", "2001-05-12", 180, 75));

            AlgoritamHeapSort.HeapSort(ref test1, 0);


            Assert.AreEqual("berin", test1[0].ime);
            Assert.AreEqual("kolos", test1[1].prezime);
            Assert.AreEqual("2001-12-13", test1[3].datum_rodenja);
            Assert.AreEqual(185, test1[2].visina);
            Assert.AreEqual(75, test1[0].tezina);
        }

        [TestMethod]
        public void TestGnomeSortOsoba()
        {
            List<Osoba> test1 = new List<Osoba>();
            test1.Add(new Osoba("harun", "kolos", "1997-09-03", 187, 85));
            test1.Add(new Osoba("haso", "hasic", "1998-09-03", 185, 80));
            test1.Add(new Osoba("mujo", "mujic", "2001-12-13", 181, 81));
            test1.Add(new Osoba("berin", "masovic", "2001-05-12", 180, 75));

            AlgoritamGnomeSort.GnomeSort(ref test1, test1.Count, 0);


            Assert.AreEqual("berin", test1[0].ime);
            Assert.AreEqual("kolos", test1[1].prezime);
            Assert.AreEqual("2001-12-13", test1[3].datum_rodenja);
            Assert.AreEqual(185, test1[2].visina);
            Assert.AreEqual(75, test1[0].tezina);


        }

        [TestMethod]
        public void TestOddEvenSortOsoba()
        {
            List<Osoba> test1 = new List<Osoba>();
            test1.Add(new Osoba("harun", "kolos", "1997-09-03", 187, 85));
            test1.Add(new Osoba("haso", "hasic", "1998-09-03", 185, 80));
            test1.Add(new Osoba("mujo", "mujic", "2001-12-13", 181, 81));
            test1.Add(new Osoba("berin", "masovic", "2001-05-12", 180, 75));

            AlgoritamOddEvenSort.OddEvenSort(ref test1,test1.Count, 0);


            Assert.AreEqual("berin", test1[0].ime);
            Assert.AreEqual("kolos", test1[1].prezime);
            Assert.AreEqual("2001-12-13", test1[3].datum_rodenja);
            Assert.AreEqual(185, test1[2].visina);
            Assert.AreEqual(75, test1[0].tezina);


        }

        [TestMethod]
        public void TestOsobaVrati()
        {

            List<Osoba> test1 = new List<Osoba>();
            test1.Add(new Osoba("harun", "kolos", "1997-09-03", 187, 85));
            test1.Add(new Osoba("haso", "hasic", "1998-09-03", 185, 80));
            test1.Add(new Osoba("mujo", "mujic", "2001-12-13", 181, 81));
            test1.Add(new Osoba("berin", "masovic", "2001-05-12", 180, 75));

            Assert.AreEqual("imenu", test1[0].vrati(0));
            Assert.AreEqual("prezimenu", test1[0].vrati(1));
            Assert.AreEqual("datumu rodenja", test1[0].vrati(2));
            Assert.AreEqual("visini", test1[0].vrati(3));
            Assert.AreEqual("tezini", test1[0].vrati(4));


        }

        [TestMethod]
        public void TestOsobaDaj()
        {

            List<Osoba> test1 = new List<Osoba>();
            test1.Add(new Osoba("harun", "kolos", "1997-09-03", 187, 85));
            test1.Add(new Osoba("haso", "hasic", "1998-09-03", 185, 80));
            test1.Add(new Osoba("mujo", "mujic", "2001-12-13", 181, 81));
            test1.Add(new Osoba("berin", "masovic", "2001-05-12", 180, 75));

            Assert.AreEqual("harun", test1[0].daj("0"));
            Assert.AreEqual("kolos", test1[0].daj("1"));
            Assert.AreEqual("1997-09-03", test1[0].daj("2"));
            Assert.AreEqual(187, test1[0].daj(3));
            Assert.AreEqual(85, test1[0].daj(4));
        }
    }
}