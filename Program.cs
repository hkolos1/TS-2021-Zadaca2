using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace Zadaca1
{

    public class AlgoritamSelectionSort
    {
        static void Swap(ref int a, ref int b)
        {
            var t = a;
            a = b;
            b = t;
        }
        public static void SelectionSort<T>(ref T[] input) where T : IComparable<T>
        {
            for (var i = 0; i < input.Length; i++)
            {
                var min = i;

                for (var j = i + 1; j < input.Length; j++)
                {
                    if (input[min].CompareTo(input[j]) > 0)
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    T temp = input[min];
                    input[min] = input[i];
                    input[i] = temp;
                }
            }

        }

        public static void SelectionSort(ref List<Osoba> input, int op)
        {
            dynamic opcija;
            if (op == 0 || op == 1 || op == 2)
                opcija = op.ToString();
            else
                opcija = op;


            for (var i = 0; i < input.Count; i++)
            {
                var min = i;

                for (var j = i + 1; j < input.Count; j++)
                {
                    if (input[min].daj(opcija).CompareTo(input[j].daj(opcija)) > 0)
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    var temp = input[min];
                    input[min] = input[i];
                    input[i] = temp;
                }
            }

        }

    }

    public class AlgoritamShellSort
    {
        public static void ShellSort<T>(ref T[] array) where T : IComparable<T>
        {
            // Udaljenost između elemenata koji se porede
            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d].CompareTo(array[j]) > 0))
                    {
                        T temp = array[j - d];
                        array[j - d] = array[j];
                        array[j] = temp;
                        j = j - d;
                    }
                }
                d = d / 2;
            }
        }
        public static void ShellSort(ref List<Osoba> array, int op)
        {
            dynamic opcija;
            if (op == 0 || op == 1 || op == 2)
                opcija = op.ToString();
            else
                opcija = op;
            // Udaljenost između elemenata koji se porede
            var d = array.Count / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Count; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d].daj(opcija).CompareTo(array[j].daj(opcija)) > 0))
                    {
                        var temp = array[j - d];
                        array[j - d] = array[j];
                        array[j] = temp;
                        j = j - d;
                    }
                }
                d = d / 2;
            }
        }

    }
    public class AlgoritamBubbleSort
    {

        public static void BubbleSort<T>(ref T[] niz) where T : IComparable<T>
        {
            //Opadajući ispis niza
            T temp;
            for (int i = 0; i < niz.Length; i++)
            {
                for (int j = i + 1; j < niz.Length; j++)
                {
                    if (niz[i].CompareTo(niz[j]) > 0)
                    {
                        temp = niz[i];
                        niz[i] = niz[j];
                        niz[j] = temp;
                    }
                }
            }
        }

        public static void BubbleSort(ref List<Osoba> niz, int op)
        {

            dynamic opcija;
            if (op == 0 || op == 1 || op == 2)
                opcija = op.ToString();
            else
                opcija = op;
            //Opadajući ispis niza

            for (int i = 0; i < niz.Count; i++)
            {
                for (int j = i + 1; j < niz.Count; j++)
                {
                    if (niz[i].daj(opcija).CompareTo(niz[j].daj(opcija)) > 0)
                    {
                        var temp = niz[i];
                        niz[i] = niz[j];
                        niz[j] = temp;
                    }
                }
            }
        }
        static void Trade(int[] arr)
        {

            int j = 1;
            int temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
        }

    }
    public class AlgoritamInsertionSort
    {
        public static void InsertionSort<T>(ref T[] input) where T : IComparable<T>
        {

            for (int i = 0; i < input.Count(); i++)
            {
                T item = input[i];
                var currentIndex = i;

                while (currentIndex > 0 && input[currentIndex - 1].CompareTo(item) > 0)
                {
                    input[currentIndex] = input[currentIndex - 1];
                    currentIndex--;
                }

                input[currentIndex] = item;
            }
        }

        public static void InsertionSort(ref List<Osoba> input, int op)
        {

            dynamic opcija;
            if (op == 0 || op == 1 || op == 2)
                opcija = op.ToString();
            else
                opcija = op;

            for (int i = 0; i < input.Count(); i++)
            {
                var item = input[i];
                var currentIndex = i;

                while (currentIndex > 0 && input[currentIndex - 1].daj(opcija).CompareTo(item.daj(opcija)) > 0)
                {
                    input[currentIndex] = input[currentIndex - 1];
                    currentIndex--;
                }

                input[currentIndex] = item;
            }
        }

    }

    public class AlgoritamCombSort
    {
        static int getNextGap(int gap)
        {
            gap = (gap * 10) / 13;
            if (gap < 1)
                return 1;
            return gap;
        }

        public static void CombSort<T>(ref T[] input) where T : IComparable<T>
        {
            int n = input.Length;
            int gap = n;
            bool swapped = true;

            while (gap != 1 || swapped == true)
            {
                gap = getNextGap(gap);
                swapped = false;

                for (int i = 0; i < n - gap; i++)
                {
                    if (input[i].CompareTo(input[i + gap]) > 0)
                    {
                        T temp = input[i];
                        input[i] = input[i + gap];
                        input[i + gap] = temp;

                        swapped = true;
                    }
                }
            }
        }

        public static void CombSort(ref List<Osoba> input, int op)
        {

            dynamic opcija;
            if (op == 0 || op == 1 || op == 2)
                opcija = op.ToString();
            else
                opcija = op;

            int n = input.Count;
            int gap = n;
            bool swapped = true;

            while (gap != 1 || swapped == true)
            {
                gap = getNextGap(gap);
                swapped = false;

                for (int i = 0; i < n - gap; i++)
                {
                    if (input[i].daj(opcija).CompareTo(input[i + gap].daj(opcija)) > 0)
                    {
                        var temp = input[i];
                        input[i] = input[i + gap];
                        input[i + gap] = temp;

                        swapped = true;
                    }
                }
            }
        }

    }

    public class AlgoritamCocktailSort
    {
        public static void CocktailSort<T>(ref T[] input) where T : IComparable<T>
        {
            bool swapped = true;
            int start = 0;
            int end = input.Length;

            while (swapped == true)
            {
                swapped = false;

                for (int i = start; i < end - 1; ++i)
                {
                    if (input[i].CompareTo(input[i + 1]) > 0)
                    {
                        T temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;

                swapped = false;

                end = end - 1;

                for (int i = end - 1; i >= start; i--)
                {
                    if (input[i].CompareTo(input[i + 1]) > 0)
                    {
                        T temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        swapped = true;
                    }
                }

                start = start + 1;
            }

        }

        public static void CocktailSort(ref List<Osoba> input, int op)
        {

            dynamic opcija;
            if (op == 0 || op == 1 || op == 2)
                opcija = op.ToString();
            else
                opcija = op;

            bool swapped = true;
            int start = 0;
            int end = input.Count;

            while (swapped == true)
            {
                swapped = false;

                for (int i = start; i < end - 1; ++i)
                {
                    if (input[i].daj(opcija).CompareTo(input[i + 1].daj(opcija)) > 0)
                    {
                        var temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;

                swapped = false;

                end = end - 1;

                for (int i = end - 1; i >= start; i--)
                {
                    if (input[i].daj(opcija).CompareTo(input[i + 1].daj(opcija)) > 0)
                    {
                        var temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        swapped = true;
                    }
                }

                start = start + 1;
            }

        }

    }

    public class AlgoritamHeapSort
    {
        public static void HeapSort<T>(ref T[] arr) where T : IComparable<T>
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);

            for (int i = n - 1; i > 0; i--)
            {

                T temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                heapify(arr, i, 0);
            }
        }

        public static void HeapSort(ref List<Osoba> arr, int op)
        {
            int n = arr.Count;

            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i, op);

            for (int i = n - 1; i > 0; i--)
            {

                var temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                heapify(arr, i, 0, op);
            }
        }

        static void heapify<T>(T[] arr, int n, int i) where T : IComparable<T>
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && arr[l].CompareTo(arr[largest]) > 0)
                largest = l;

            if (r < n && arr[r].CompareTo(arr[largest]) > 0)
                largest = r;

            if (largest != i)
            {
                T swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                heapify(arr, n, largest);
            }
        }

        static void heapify(List<Osoba> arr, int n, int i, int op)
        {

            dynamic opcija;
            if (op == 0 || op == 1 || op == 2)
                opcija = op.ToString();
            else
                opcija = op;

            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && arr[l].daj(opcija).CompareTo(arr[largest].daj(opcija)) > 0)
                largest = l;

            if (r < n && arr[r].daj(opcija).CompareTo(arr[largest].daj(opcija)) > 0)
                largest = r;

            if (largest != i)
            {
                var swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                heapify(arr, n, largest, op);
            }
        }

    }

    public class AlgoritamGnomeSort
    {
        public static void GnomeSort<T>(ref T[] arr, int n) where T : IComparable<T>
        {
            int index = 0;

            while (index < n)
            {
                if (index == 0)
                    index++;
                if (arr[index].CompareTo(arr[index - 1]) >= 0)
                    index++;
                else
                {
                    T temp;
                    temp = arr[index];
                    arr[index] = arr[index - 1];
                    arr[index - 1] = temp;
                    index--;
                }
            }
            return;
        }


        public static void GnomeSort(ref List<Osoba> arr, int n, int op)
        {
            dynamic opcija;
            if (op == 0 || op == 1 || op == 2)
                opcija = op.ToString();
            else
                opcija = op;

            int index = 0;

            while (index < n)
            {
                if (index == 0)
                    index++;
                if (arr[index].daj(opcija).CompareTo(arr[index - 1].daj(opcija)) >= 0)
                    index++;
                else
                {
                    var temp = arr[index];
                    arr[index] = arr[index - 1];
                    arr[index - 1] = temp;
                    index--;
                }
            }
            return;
        }
    }

    public class AlgoritamOddEvenSort
    { 
        public static void OddEvenSort<T>(ref T[] arr, int n) where T : IComparable<T>
        {
            // Initially array is unsorted
            bool isSorted = false;

            while (!isSorted)
            {
                isSorted = true;

                // Perform Bubble sort on
                // odd indexed element
                for (int i = 1; i <= n - 2; i = i + 2)
                {
                    if (arr[i].CompareTo(arr[i + 1]) > 0)
                    {
                        T temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        isSorted = false;
                    }
                }

                // Perform Bubble sort on
                // even indexed element
                for (int i = 0; i <= n - 2; i = i + 2)
                {
                    if (arr[i].CompareTo(arr[i + 1]) > 0)
                    {
                        T temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        isSorted = false;
                    }
                }
            }
            return;
        }

        public static void OddEvenSort(ref List<Osoba> arr, int n, int op) 
        {

            dynamic opcija;
            if (op == 0 || op == 1 || op == 2)
                opcija = op.ToString();
            else
                opcija = op;

            // Initially array is unsorted
            bool isSorted = false;

            while (!isSorted)
            {
                isSorted = true;

                // Perform Bubble sort on
                // odd indexed element
                for (int i = 1; i <= n - 2; i = i + 2)
                {
                    if (arr[i].daj(opcija).CompareTo(arr[i + 1].daj(opcija)) > 0)
                    {
                        var temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        isSorted = false;
                    }
                }

                // Perform Bubble sort on
                // even indexed element
                for (int i = 0; i <= n - 2; i = i + 2)
                {
                    if (arr[i].daj(opcija).CompareTo(arr[i + 1].daj(opcija)) > 0)
                    {
                        var temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        isSorted = false;
                    }
                }
            }
            return;
        }

    }
    class RandomDateTime
    {
        public static string RandomDate(int startYear = 1960, string outputDateFormat = "yyyy-MM-dd")
        {
            DateTime start = new DateTime(startYear, 1, 1);
            Random gen = new Random(Guid.NewGuid().GetHashCode());
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range)).ToString(outputDateFormat);
        }

    }

    public class Osoba
    {

        public string ime { get; set; }
        public string prezime { get; set; }
        public string datum_rodenja { get; set; }
        public int visina { get; set; }
        public int tezina { get; set; }

        public Osoba() { }

        public Osoba(string ime, string prezime, string datum_rodenja, int visina, int tezina)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.datum_rodenja = datum_rodenja;
            this.visina = visina;
            this.tezina = tezina;
        }

        public string daj(string ope)
        {

            if (Convert.ToString(ope) == "0")
            {
                return this.ime;

            }
            else if (Convert.ToString(ope) == "1")
            {
                return this.prezime;

            }
            else if (Convert.ToString(ope) == "2")
            {
                return this.datum_rodenja;

            }

            return "";

        }

        public int daj(object op)
        {

            if (Convert.ToInt32(op) == 3)
            {
                return this.visina;

            }
            else if (Convert.ToInt32(op) == 4)
            {
                return this.tezina;

            }

            return 0;

        }

        public string vrati(int op)
        {

            if (op == 0)
            {
                return "imenu";

            }
            else if (op == 1)
            {
                return "prezimenu";

            }
            else if (op == 2)
            {
                return "datumu rodenja";

            }
            else if (op == 3)
            {
                return "visini";

            }
            else if (op == 4)
            {
                return "tezini";

            }

            return "";

        }


    }
    
    public interface BazaPodataka
    {
        string[] ime();
        string[] prezime();
        string[] datum_rodenja();
        int[] visina();
        int[] tezina();

   
    }
    public class Lazna : BazaPodataka
    {
        public string[] ime()
        {
            string[] imena = { "Harun", "Mirza", "Hamza", "Armin" };
            return imena;
        }
        public string[] prezime()
        {
            string[] prezimena = { "Kolos", "Mesihovic", "Hodzic", "Alic" };
            return prezimena;
        }
        public string[] datum_rodenja()
        {
            string[] datumi = { "2001-09-03", "1999-12-06", "1995-04-17", "2010-11-20" };
            return datumi;
        }
        public int[] visina()
        {
            int[] visine = { 171, 194, 185, 150};
            return visine;
        }
        public int[] tezina()
        {
            int[] tezine = { 72, 80, 91, 64 };
            return tezine;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            int odabirTipa = 0;
            Console.Write("Odaberite zeljeni tip:\n");
            Console.Write("1 - int\n");
            Console.Write("2 - string\n");
            Console.Write("3 - osoba\n");
            Console.Write("\n");

            odabirTipa = Convert.ToInt32(Console.ReadLine());

            switch (odabirTipa)
            {
                case 1:

                    int odabirVel = 0;

                    Console.Write("\nOdaberite zeljenu veličinu niza :\n");
                    Console.Write("1 - 10\n");
                    Console.Write("2 - 100\n");
                    Console.Write("3 - 1000\n");
                    Console.Write("4 - vlastiti unos\n");
                    Console.Write("\n");

                    odabirVel = Convert.ToInt32(Console.ReadLine());

                    int vel = 0;

                    switch (odabirVel)
                    {
                        case 1:
                            vel = 10;
                            break;

                        case 2:
                            vel = 100;
                            break;

                        case 3:
                            vel = 1000;
                            break;

                        case 4:
                            Console.Write("\nUnesite broj elemenata niza:");
                            vel = Convert.ToInt32(Console.ReadLine());
                            break;

                        default:
                            Console.WriteLine("Pogrešan unos");
                            return;

                    }


                    int Min = 0;
                    int Max = 1000;
                    int[] test1 = new int[vel];

                    Random randNum = new Random();
                    for (int i = 0; i < test1.Length; i++)
                    {
                        test1[i] = randNum.Next(Min, Max);
                    }


                    Console.Write("\nOdaberite zeljeni algoritam:\n");
                    Console.Write("1 - SelectionSort\n");
                    Console.Write("2 - ShellSort\n");
                    Console.Write("3 - BubbleSort\n");
                    Console.Write("4 - InsertionSort\n");
                    Console.Write("5 - CombSort\n");
                    Console.Write("6 - CocktailSort\n");
                    Console.Write("7 - HeapSort\n");
                    Console.Write("8 - GnomeSort\n");
                    Console.Write("9 - OddEvenSort\n");

                    Console.Write("\n");

                    int odabir = Convert.ToInt32(Console.ReadLine());
                    Stopwatch vrijeme = new Stopwatch();

                    switch (odabir)
                    {
                        case 1:

                            Console.WriteLine("\nOdabrali ste SelectionSort\n");
                            vrijeme.Start();
                            AlgoritamSelectionSort.SelectionSort(ref test1);
                            Console.WriteLine("Sortiran niz glasi: {0}", string.Join(",", test1));
                            vrijeme.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme.Elapsed);

                            break;

                        case 2:

                            Console.WriteLine("\nOdabrali ste ShellSort\n");
                            vrijeme.Start();
                            AlgoritamShellSort.ShellSort(ref test1);
                            Console.WriteLine("Sortiran niz glasi: {0}", string.Join(",", test1));
                            vrijeme.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme.Elapsed);

                            break;

                        case 3:
                            Console.WriteLine("\nOdabrali ste BubbleSort\n");
                            vrijeme.Start();
                            AlgoritamBubbleSort.BubbleSort(ref test1);
                            Console.WriteLine("Sortiran niz glasi: {0}", string.Join(",", test1));
                            vrijeme.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme.Elapsed);

                            break;

                        case 4:
                            Console.WriteLine("\nOdabrali ste InsertionSort\n");
                            vrijeme.Start();
                            AlgoritamInsertionSort.InsertionSort(ref test1);
                            Console.WriteLine("Sortiran niz glasi: {0}", string.Join(",", test1));
                            vrijeme.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme.Elapsed);

                            break;

                        case 5:
                            Console.WriteLine("\nOdabrali ste CombSort\n");
                            vrijeme.Start();
                            AlgoritamCombSort.CombSort(ref test1);
                            Console.WriteLine("Sortiran niz glasi: {0}", string.Join(",", test1));
                            vrijeme.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme.Elapsed);

                            break;

                        case 6:
                            Console.WriteLine("\nOdabrali ste CocktailSort\n");
                            vrijeme.Start();
                            AlgoritamCocktailSort.CocktailSort(ref test1);
                            Console.WriteLine("Sortiran niz glasi: {0}", string.Join(",", test1));
                            vrijeme.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme.Elapsed);

                            break;

                        case 7:
                            Console.WriteLine("\nOdabrali ste HeapSort\n");
                            vrijeme.Start();
                            AlgoritamHeapSort.HeapSort(ref test1);
                            Console.WriteLine("Sortiran niz glasi: {0}", string.Join(",", test1));
                            vrijeme.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme.Elapsed);

                            break;

                        case 8:

                            Console.WriteLine("\nOdabrali ste GnomeSort\n");
                            vrijeme.Start();
                            AlgoritamGnomeSort.GnomeSort(ref test1, test1.Length);
                            Console.WriteLine("Sortiran niz glasi: {0}", string.Join(",", test1));
                            vrijeme.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme.Elapsed);

                            break;

                        case 9:

                            Console.WriteLine("\nOdabrali ste OddEvenSort\n");
                            vrijeme.Start();
                            AlgoritamOddEvenSort.OddEvenSort(ref test1, test1.Length);
                            Console.WriteLine("Sortiran niz glasi: {0}", string.Join(",", test1));
                            vrijeme.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme.Elapsed);

                            break;

                        default:
                            Console.WriteLine("Pogrešan unos");
                            return;

                    }
                    

                    break;

                case 2:

                    int odabirVel2 = 0;

                    Console.Write("\nOdaberite zeljenu veličinu niza :\n");
                    Console.Write("1 - 10\n");
                    Console.Write("2 - 100\n");
                    Console.Write("3 - 1000\n");
                    Console.Write("4 - vlastiti unos\n");
                    Console.Write("\n");

                    odabirVel2 = Convert.ToInt32(Console.ReadLine());

                    int vel2 = 0;

                    switch (odabirVel2)
                    {
                        case 1:
                            vel2 = 10;
                            break;

                        case 2:
                            vel2 = 100;
                            break;

                        case 3:
                            vel2 = 1000;
                            break;

                        case 4:
                            Console.Write("\nUnesite broj elemenata niza:");
                            vel2 = Convert.ToInt32(Console.ReadLine());
                            break;

                        default:
                            Console.WriteLine("Pogrešan unos");
                            return;

                    }

                    string[] test2 = new string[vel2];

                    Random randNum2 = new Random();

                    int brSlova = 0;
                    Console.Write("\nUnesite broj slova po riječi:\n");
                    brSlova = Convert.ToInt32(Console.ReadLine());

                    int num_letters = brSlova;
                    int num_words = vel2;

                    char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

                    Random rand = new Random();


                    for (int i = 0; i < num_words; i++)
                    {

                        string word = "";
                        for (int j = 0; j < num_letters; j++)
                        {

                            int letter_num = rand.Next(0, letters.Length);
                            word += letters[letter_num];

                        }

                        test2[i] = word;

                    }


                    Console.Write("\nOdaberite zeljeni algoritam:\n");
                    Console.Write("1 - SelectionSort\n");
                    Console.Write("2 - ShellSort\n");
                    Console.Write("3 - BubbleSort\n");
                    Console.Write("4 - InsertionSort\n");
                    Console.Write("5 - CombSort\n");
                    Console.Write("6 - CocktailSort\n");
                    Console.Write("7 - HeapSort\n");
                    Console.Write("8 - GnomeSort\n");
                    Console.Write("9 - OddEvenSort\n");
                    Console.Write("\n");

                    int odabir2 = Convert.ToInt32(Console.ReadLine());
                    Stopwatch vrijeme2 = new Stopwatch();

                    switch (odabir2)
                    {
                        case 1:

                            Console.WriteLine("\nOdabrali ste SelectionSort\n");
                            vrijeme2.Start();
                            AlgoritamSelectionSort.SelectionSort(ref test2);
                            Console.WriteLine("Sortiran niz glasi: {0}", string.Join(",", test2));
                            vrijeme2.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme2.Elapsed);

                            break;

                        case 2:

                            Console.WriteLine("\nOdabrali ste ShellSort\n");
                            vrijeme2.Start();
                            AlgoritamShellSort.ShellSort(ref test2);
                            Console.WriteLine("Sortiran niz glasi: {0}", string.Join(",", test2));
                            vrijeme2.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme2.Elapsed);

                            break;

                        case 3:
                            Console.WriteLine("\nOdabrali ste BubbleSort\n");
                            vrijeme2.Start();
                            AlgoritamBubbleSort.BubbleSort(ref test2);
                            Console.WriteLine("Sortiran niz glasi: {0}", string.Join(",", test2));
                            vrijeme2.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme2.Elapsed);

                            break;

                        case 4:
                            Console.WriteLine("\nOdabrali ste InsertionSort\n");
                            vrijeme2.Start();
                            AlgoritamInsertionSort.InsertionSort(ref test2);
                            Console.WriteLine("Sortiran niz glasi: {0}", string.Join(",", test2));
                            vrijeme2.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme2.Elapsed);

                            break;

                        case 5:
                            Console.WriteLine("\nOdabrali ste CombSort\n");
                            vrijeme2.Start();
                            AlgoritamCombSort.CombSort(ref test2);
                            Console.WriteLine("Sortiran niz glasi: {0}", string.Join(",", test2));
                            vrijeme2.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme2.Elapsed);

                            break;

                        case 6:
                            Console.WriteLine("\nOdabrali ste CocktailSort\n");
                            vrijeme2.Start();
                            AlgoritamCocktailSort.CocktailSort(ref test2);
                            Console.WriteLine("Sortiran niz glasi: {0}", string.Join(",", test2));
                            vrijeme2.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme2.Elapsed);

                            break;

                        case 7:
                            Console.WriteLine("\nOdabrali ste HeapSort\n");
                            vrijeme2.Start();
                            AlgoritamHeapSort.HeapSort(ref test2);
                            Console.WriteLine("Sortiran niz glasi: {0}", string.Join(",", test2));
                            vrijeme2.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme2.Elapsed);

                            break;

                        case 8:

                            Console.WriteLine("\nOdabrali ste GnomeSort\n");
                            vrijeme2.Start();
                            AlgoritamGnomeSort.GnomeSort(ref test2, test2.Length);
                            Console.WriteLine("Sortiran niz glasi: {0}", string.Join(",", test2));
                            vrijeme2.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme2.Elapsed);

                            break;

                        case 9:

                            Console.WriteLine("\nOdabrali ste OddEvenSort\n");
                            vrijeme2.Start();
                            AlgoritamOddEvenSort.OddEvenSort(ref test2, test2.Length);
                            Console.WriteLine("Sortiran niz glasi: {0}", string.Join(",", test2));
                            vrijeme2.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme2.Elapsed);

                            break;

                        default:
                            Console.WriteLine("Pogrešan unos");
                            return;
                            
                    }

                    break;

                case 3:

                    int odabirVel3 = 0;

                    Console.Write("\nOdaberite zeljenu veličinu niza osoba:\n");
                    Console.Write("1 - 10\n");
                    Console.Write("2 - 100\n");
                    Console.Write("3 - 1000\n");
                    Console.Write("4 - vlastiti unos\n");
                    Console.Write("\n");

                    odabirVel3 = Convert.ToInt32(Console.ReadLine());

                    int vel3 = 0;

                    switch (odabirVel3)
                    {
                        case 1:
                            vel3 = 10;
                            break;

                        case 2:
                            vel3 = 100;
                            break;

                        case 3:
                            vel3 = 1000;
                            break;

                        case 4:
                            Console.Write("\nUnesite broj elemenata niza:");
                            vel3 = Convert.ToInt32(Console.ReadLine());
                            break;

                        default:
                            Console.WriteLine("Pogrešan unos");
                            return;

                    }

                    int MinVisina = 150;
                    int MaxVisina = 210;
                    int MinTezina = 25;
                    int MaxTezina = 150;

                    int broj = 0;

                    Random randNum3 = new Random();

                    List<Osoba> test3 = new List<Osoba>();

                    int num_letters3 = 5;
                    int num_words3 = vel3;

                    char[] letters3 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

                    Random rand3 = new Random();


                    for (int i = 0; i < num_words3; i++)
                    {
                        Osoba os = new Osoba();

                        //ime
                        string word = "";
                        for (int j = 0; j < num_letters3; j++)
                        {

                            int letter_num = rand3.Next(0, letters3.Length);
                            word += letters3[letter_num];

                        }

                        os.ime = word;

                        //prezime
                        word = "";
                        for (int j = 0; j < num_letters3; j++)
                        {

                            int letter_num = rand3.Next(0, letters3.Length);
                            word += letters3[letter_num];

                        }

                        os.prezime = word;

                        //datum

                        word = RandomDateTime.RandomDate();
                        os.datum_rodenja = word;

                        //visina
                        broj = randNum3.Next(MinVisina, MaxVisina);
                        os.visina = broj;

                        //tezina
                        broj = randNum3.Next(MinTezina, MaxTezina);
                        os.tezina = broj;

                        test3.Add(os);

                    }

                    Console.Write("\nOdaberite atribut po kojem želite da se izvrši sortiranje:\n");
                    Console.Write("1 - ime\n");
                    Console.Write("2 - prezime\n");
                    Console.Write("3 - datum rođenja\n");
                    Console.Write("4 - visina\n");
                    Console.Write("5 - tezina\n");
                    Console.Write("\n");

                    int vrsta = Convert.ToInt32(Console.ReadLine());
                    Stopwatch vrijeme3 = new Stopwatch();

                    Console.Write("\nOdaberite zeljeni algoritam:\n");
                    Console.Write("1 - SelectionSort\n");
                    Console.Write("2 - ShellSort\n");
                    Console.Write("3 - BubbleSort\n");
                    Console.Write("4 - InsertionSort\n");
                    Console.Write("5 - CombSort\n");
                    Console.Write("6 - CocktailSort\n");
                    Console.Write("7 - HeapSort\n");
                    Console.Write("8 - GnomeSort\n");
                    Console.Write("9 - OddEvenSort\n");
                    Console.Write("\n");

                    int odabir3 = Convert.ToInt32(Console.ReadLine());

                    switch (odabir3)
                    {
                        case 1:

                            Console.WriteLine("\nOdabrali ste SelectionSort sotiranje po {0}\n", test3[0].vrati(vrsta - 1));

                            vrijeme3.Start();
                            AlgoritamSelectionSort.SelectionSort(ref test3, vrsta - 1);
                            Console.WriteLine("Sortiran niz glasi: ");
                            foreach (var osob in test3)
                            {
                                Console.WriteLine("Osoba: {0},{1},{2},{3}cm,{4}kg", osob.ime, osob.prezime, osob.datum_rodenja, osob.visina, osob.tezina);
                            }
                            vrijeme3.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme3.Elapsed);

                            break;

                        case 2:

                            Console.WriteLine("\nOdabrali ste ShellSort sotiranje po {0}\n", test3[0].vrati(vrsta - 1));

                            vrijeme3.Start();
                            AlgoritamShellSort.ShellSort(ref test3, vrsta - 1);
                            Console.WriteLine("Sortiran niz glasi: ");
                            foreach (var osob in test3)
                            {
                                Console.WriteLine("Osoba: {0},{1},{2},{3}cm,{4}kg", osob.ime, osob.prezime, osob.datum_rodenja, osob.visina, osob.tezina);
                            }
                            vrijeme3.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme3.Elapsed);

                            break;

                        case 3:

                            Console.WriteLine("\nOdabrali ste BubbleSort sotiranje po {0}\n", test3[0].vrati(vrsta - 1));

                            vrijeme3.Start();
                            AlgoritamBubbleSort.BubbleSort(ref test3, vrsta - 1);
                            Console.WriteLine("Sortiran niz glasi: ");
                            foreach (var osob in test3)
                            {
                                Console.WriteLine("Osoba: {0},{1},{2},{3}cm,{4}kg", osob.ime, osob.prezime, osob.datum_rodenja, osob.visina, osob.tezina);
                            }
                            vrijeme3.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme3.Elapsed);

                            break;

                        case 4:

                            Console.WriteLine("\nOdabrali ste InsertionSort sotiranje po {0}\n", test3[0].vrati(vrsta - 1));

                            vrijeme3.Start();
                            AlgoritamInsertionSort.InsertionSort(ref test3, vrsta - 1);
                            Console.WriteLine("Sortiran niz glasi: ");
                            foreach (var osob in test3)
                            {
                                Console.WriteLine("Osoba: {0},{1},{2},{3}cm,{4}kg", osob.ime, osob.prezime, osob.datum_rodenja, osob.visina, osob.tezina);
                            }
                            vrijeme3.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme3.Elapsed);

                            break;

                        case 5:

                            Console.WriteLine("\nOdabrali ste CombSort sotiranje po {0}\n", test3[0].vrati(vrsta - 1));

                            vrijeme3.Start();
                            AlgoritamCombSort.CombSort(ref test3, vrsta - 1);
                            Console.WriteLine("Sortiran niz glasi: ");
                            foreach (var osob in test3)
                            {
                                Console.WriteLine("Osoba: {0},{1},{2},{3}cm,{4}kg", osob.ime, osob.prezime, osob.datum_rodenja, osob.visina, osob.tezina);
                            }
                            vrijeme3.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme3.Elapsed);

                            break;

                        case 6:

                            Console.WriteLine("\nOdabrali ste CocktailSort sotiranje po {0}\n", test3[0].vrati(vrsta - 1));

                            vrijeme3.Start();
                            AlgoritamCocktailSort.CocktailSort(ref test3, vrsta - 1);
                            Console.WriteLine("Sortiran niz glasi: ");
                            foreach (var osob in test3)
                            {
                                Console.WriteLine("Osoba: {0},{1},{2},{3}cm,{4}kg", osob.ime, osob.prezime, osob.datum_rodenja, osob.visina, osob.tezina);
                            }
                            vrijeme3.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme3.Elapsed);

                            break;

                        case 7:

                            Console.WriteLine("\nOdabrali ste HeapSort sotiranje po {0}\n", test3[0].vrati(vrsta - 1));

                            vrijeme3.Start();
                            AlgoritamHeapSort.HeapSort(ref test3, vrsta - 1);
                            Console.WriteLine("Sortiran niz glasi: ");
                            foreach (var osob in test3)
                            {
                                Console.WriteLine("Osoba: {0},{1},{2},{3}cm,{4}kg", osob.ime, osob.prezime, osob.datum_rodenja, osob.visina, osob.tezina);
                            }
                            vrijeme3.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme3.Elapsed);

                            break;

                        case 8:

                            Console.WriteLine("\nOdabrali ste GnomeSort sotiranje po {0}\n", test3[0].vrati(vrsta - 1));

                            vrijeme3.Start();
                            AlgoritamGnomeSort.GnomeSort(ref test3, test3.Count, vrsta - 1);
                            Console.WriteLine("Sortiran niz glasi: ");
                            foreach (var osob in test3)
                            {
                                Console.WriteLine("Osoba: {0},{1},{2},{3}cm,{4}kg", osob.ime, osob.prezime, osob.datum_rodenja, osob.visina, osob.tezina);
                            }
                            vrijeme3.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme3.Elapsed);

                            break;

                        case 9:

                            Console.WriteLine("\nOdabrali ste OddEvenSort sotiranje po {0}\n", test3[0].vrati(vrsta - 1));

                            vrijeme3.Start();
                            AlgoritamOddEvenSort.OddEvenSort(ref test3, test3.Count, vrsta - 1);
                            Console.WriteLine("Sortiran niz glasi: ");
                            foreach (var osob in test3)
                            {
                                Console.WriteLine("Osoba: {0},{1},{2},{3}cm,{4}kg", osob.ime, osob.prezime, osob.datum_rodenja, osob.visina, osob.tezina);
                            }
                            vrijeme3.Stop();
                            Console.WriteLine("\nVrijeme potrebno za izvršenje algoritma {0} ms \n", vrijeme3.Elapsed);

                            break;

                        default:
                            Console.WriteLine("Pogrešan unos");
                            return;
                            
                    }

                    break;

                default:
                    Console.WriteLine("Pogrešan unos");
                    return;
            }

        }
    }
}