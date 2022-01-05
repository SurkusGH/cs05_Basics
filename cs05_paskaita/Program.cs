using System;
using System.Collections.Generic;

namespace cs05_paskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs05_PASKAITA!");

            #region TEORIJA - Jokios teorijos. Sprendžiame uždavinius

            #endregion

            #region TEORIJA -
            #endregion

            #region TEORIJA -
            #endregion

            //ClassWork1();
            //ClassWork2();
            //ClassWork2_ALT();
            //ClassWork3();
            //ClassWork4();
            ClassWork5();
            //ClassWork6();
            ClassWork7();
            //ClassWork8();
            ClassWork9();
            //ClassWork10();
        }
        public static void ClassWork1()
        {
            // Sukurti du masyvus ir užpildyti atsitiktiniais skaičiais,
            // sujungti juos į vieną surūšiuoti ir išvesti
            var randomNum = new Random();

            int[] myNums = new int[5];
            int[] myNums2 = new int[5];
            int[] myNums3 = new int[10]; // <-- šitą susikuriu didesnį, nes tam, kad sutalpinti pirmus du reikia 10 vietų;

            Console.WriteLine("Array1:");
            for (int i = 0; i < 5; i++)
            {
                myNums[i] = randomNum.Next(1, 10);
            }
            foreach (var item in myNums)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("");
            Console.WriteLine("Array2:");
            for (int i = 0; i < 5; i++)
            {
                myNums2[i] = randomNum.Next(1, 10);
            }
            foreach (var item in myNums2)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("");
            Console.WriteLine("Array3:");
            for (int i = 0; i < 5; i++)
            {
                myNums3[i] = myNums[i];
            }
            for (int i = 5; i < 10; i++)
            {
                myNums3[i] = myNums2[i - 5];
            }
            foreach (var item in myNums3)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("");
            Console.WriteLine("Sorted Array3:");
            Array.Sort(myNums3);
            foreach (var item in myNums3)
            {
                Console.Write($"{item}, ");
            }
        }

        public static void ClassWork2()
        {
            // Užpildyti masyvą atsitiktiniais skaičiais
            // ir parodyti kiek kartų kartojasi kiekvienas elementas;

            var randomNumbersList = new List<int>();
            var randomNum = new Random();

            for (int i = 0; i < 100; i++)
            {
                randomNumbersList.Add(randomNum.Next(1, 10));
            }

            foreach (var item in randomNumbersList)
            {
                Console.Write($"{item}, ");
            }
            int counter1 = 0, counter2 = 0, counter3 = 0, counter4 = 0, counter5 = 0;

            foreach (var item in randomNumbersList)
            {
                if (item == 1) counter1++;
                else if (item == 2) counter2++;
                else if (item == 3) counter3++;
                else if (item == 4) counter4++;
                else if (item == 5) counter5++;
            }
            Console.WriteLine("");
            Console.WriteLine("---");
            Console.WriteLine($" Vienetų: {counter1}");
            Console.WriteLine($" Dvejetų: {counter2}");
            Console.WriteLine($" Trejetų: {counter3}");
            Console.WriteLine($"Ketvertų: {counter4}");
            Console.WriteLine($" Penketų: {counter5}");
        }

        public static void ClassWork2_ALT()
        {
            // Užpildyti masyvą atsitiktiniais skaičiais
            // ir parodyti kiek kartų kartojasi kiekvienas elementas;

            var randomNumbersList = new List<int>();
            var randomNum = new Random();

            for (int i = 0; i < 100; i++)
            {
                randomNumbersList.Add(randomNum.Next(1, 10));
            }

            foreach (var item in randomNumbersList)
            {
                Console.Write($"{item}, ");
            }
        }

        public static void ClassWork3()
        {
            // Parašyti programą, kurioje ištrinamas, bet kuris masyvo elementas.
            // (!) Pastaba – masyvas nukopijuojamas į naują masyvą BE pasirinkto elemento.
            // Rezultatas parodomas.

            int[] myNums = new int[10];
            var randomNum = new Random();

            for (int i = 0; i < 10; i++)
            {
                myNums[i] = randomNum.Next(1, 10);
            }
            foreach (var item in myNums)
            {
                Console.Write($"{item}, ");
            }

            int[] myNums2 = new int[10];
            Console.WriteLine("");
            Console.WriteLine("Type target index, to be removed");
            //foreach (var item in myNums2)
            //{
            //    Console.Write($"{item}, ");
            //}
            var input = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                if (input - 1 == i) continue;
                else myNums2[i] = myNums[i];
            }
            foreach (var item in myNums2)
            {
                Console.Write($"{item}, ");
                // array resize. // <-- čia dar reikės pažaisti
            }
        }

        public static void ClassWork4()
        {
            // Parodyti antrą didžiausią ir antrą mažiausią elementą masyve
            int[] myNums = new int[10];
            var randomNum = new Random();

            for (int i = 0; i < 10; i++)
            {
                myNums[i] = randomNum.Next(1, 10);
            }
            Console.WriteLine("Random numbers: ");
            foreach (var item in myNums)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("");
            Console.WriteLine("Sorted random numbers: ");
            Array.Sort(myNums);
            foreach (var item in myNums)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("");
            Console.WriteLine($"2nd min: {myNums[1]}");
            Console.WriteLine($"2nd max: {myNums[myNums.Length - 2]}");
        }

        public static void ClassWork5()
        {
            //Sukurti 3x3 matricą.
            //Išvesti:
            // 1. Visų matricos elementų sumą
            // 2. Kiekvienos eilutės elementų sumą
            // 3. Kiekvieno stulpelio elementų sumą

            int[,] array2D = new int[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            var count = 0;

            for (int i = 0; i < 3; i++)       //
            {                                 // ciklas tiesiog kuria koordinates
                for (int j = 0; j < 3; j++)   // indeksui, kuris spausdinamas
                {
                    Console.Write($" {array2D[i, j]} ");
                    count++;
                    if (count == 3 | count == 6 | count == 9) Console.WriteLine(""); // grupavimas?
                }
            }

            // 1. Visų matricos elementų sumą
            var array2DTotal = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array2DTotal += array2D[i, j];
                }
            }
            Console.WriteLine("---");
            Console.WriteLine($"Sum: {array2DTotal}");

            // 2. Kiekvienos eilutės elementų sumą
            var array2Drow1 = 0;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array2Drow1 += array2D[i, j];
                }
            }
            Console.WriteLine("---");
            Console.WriteLine($"row1Sum: {array2Drow1}");

            var array2Drow2 = 0;
            for (int i = 1; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array2Drow2 += array2D[i, j];
                }
            }
            Console.WriteLine($"row2Sum: {array2Drow2}");

            var array2Drow3 = 0;
            for (int i = 2; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array2Drow3 += array2D[i, j];
                }
            }
            Console.WriteLine($"row3Sum: {array2Drow3}");

            // 3. Kiekvieno stulpelio elementų sumą
            var array2Dcol1 = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    array2Dcol1 += array2D[i, j];
                }
            }
            Console.WriteLine("---");
            Console.WriteLine($"col1Sum: {array2Dcol1}");

            var array2Dcol2 = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j < 2; j++)
                {
                    array2Dcol2 += array2D[i, j];
                }
            }
            Console.WriteLine($"col2Sum: {array2Dcol2}");

            var array2Dcol3 = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 2; j < 3; j++)
                {
                    array2Dcol3 += array2D[i, j];
                }
            }
            Console.WriteLine($"col3Sum: {array2Dcol3}");
        }

        public static void ClassWork6()
        {
            // Sukurti vardų sąrašą ~5.Papildyti sąrašą
            // 2 vardais „Napoleonas“, „ Asterisas “.
            // Ištrinti trečią, vietoj „Napoleonas“ įterpti „Kleopatra“

            var nameList = new List<string>() { "Marius", "Gedas", "Jonas", "Giedrius", "Edvinas" };
            nameList.Add("Napaleonas");
            nameList.Add("Asterisas");
            foreach (var item in nameList) Console.Write($"{item}, ");

            Console.WriteLine(""); // <-- catskiriu eilutes

            nameList.Remove("Napaleonas");
            nameList.Insert(5, "Kleopatra"); // <-- integeris nutaiko į list index'ą, stringu užpildo adresą
            foreach (var item in nameList) Console.Write($"{item}, ");
        }

        public static void ClassWork7()
        {
            // Padaryti meniu tipo programą
            // Parodomas pažymių sąrašas.
            // Galimi veiksmai:
            // 0 papildyti,
            // 1 ištrinti,
            // 2 įterpti,
            // 3 parodyti pažymių vidurkį,
            // 4 išeiti iš programos

            var randomNum = new Random();
            var randomList = new List<int>();
            Console.WriteLine("List size? Enter integer: ");
            var lSize = int.Parse(Console.ReadLine());
            // Generuoju random pažymių sąrašą;
            for (int i = 0; i < lSize; i++)
            {
                randomList.Add(randomNum.Next(1, 10));
            }
            //Console.WriteLine("Your randomized list: ");
            //foreach (var item in randomList) Console.Write($"{item}, ");
            //Console.WriteLine("");

            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Current state of list: ");
                foreach (var item in randomList) Console.Write($"{item}, ");
                Console.WriteLine("");

                Console.WriteLine("Menu: ");
                Console.WriteLine("      0: add");
                Console.WriteLine("      1: remove");
                Console.WriteLine("      2: insert");
                Console.WriteLine("      3: average");
                Console.WriteLine("      4: exit");
                Console.WriteLine();

                switch (int.Parse(Console.ReadLine()))
                {
                    case 0:
                        Console.WriteLine("Enter an integer: ");
                        var input0 = int.Parse(Console.ReadLine());
                        randomList.Add(input0);
                        break;

                    case 1:
                        Console.WriteLine("Give index to remove int from list: ");
                        var input1 = int.Parse(Console.ReadLine());
                        randomList.RemoveAt(input1 - 1);
                        Console.WriteLine($"Do you want to add int into the same index (index {input1 - 1})? y/n");
                        if (Console.ReadLine() == "y")
                        {
                            Console.WriteLine("enter int");
                            randomList.Insert(input1 - 1, int.Parse(Console.ReadLine()));
                        }
                        else if (Console.ReadLine() == "n") break;
                        break;

                    case 2:
                        //Console.WriteLine($"Last removed index was {input1}");
                        foreach (var item in randomList) Console.Write($"{item}, ");
                        Console.WriteLine("");
                        Console.WriteLine("1st input target index, 2nd integer that is being inserted: ");
                        randomList.Insert(int.Parse(Console.ReadLine()) - 1, int.Parse(Console.ReadLine()));
                        break;

                    case 3:
                        foreach (var item in randomList) Console.Write($"{item}, ");
                        Console.WriteLine("");
                        var sum = 0;
                        foreach (var item in randomList)
                        {
                            sum += item;
                        }
                        Console.WriteLine($"Average is {sum / randomList.Count}");
                        break;

                    case 4:
                        loop = false;
                        break;
                }
            }
        }

        public static void ClassWork8()
        {
            // Sukurti 2 sąrašus, užpildyti duomenimis
            // ir patikrinti ar antras sąrašas įeina į pirmąjį
            // Pvz s1= 1,2,4,8,16; s2 = 2,4,8
            // Atsakymas: taip, s2 yra s1 dalimi

            var s1 = new List<int>() { 1, 2, 4, 8, 16 };
            var s2 = new List<int>() { 2, 4, 8 };

            Console.WriteLine("---");
            for (int i = 0; i < 5; i++)
            {
                if (s2[0] == s1[i] && s2[1] == s1[i + 1] && s2[2] == s1[i + 2]) Console.WriteLine($"s2 yra s1 dalimi");
            }
        }

        public static void ClassWork9()
        {
            // Viename sąraše yra RNA grandinė
            // Galimos raidės A U G C
            // Sukurti DNA grandinę, pvz:
            // RNA: A   A   U   C   G
            // DNA: A-T A-T T-A C-G G-C

            Console.WriteLine("Veskite 5 RNA Raides (Galimos vesti A C G U)");
            var rna = Console.ReadLine().ToLower();

            Console.WriteLine($"RNA: {rna[0]}, {rna[1]}, {rna[2]}, {rna[3]}, {rna[4]}");
            Console.Write($"DNA: ");
            for (int i = 0; i < 5; i++)
            {
                if (rna[i] == 'a') Console.Write($"A-T ");
                if (rna[i] == 'c') Console.Write($"C-G ");
                if (rna[i] == 'g') Console.Write($"G-C ");
                if (rna[i] == 'u') Console.Write($"T-A ");
            }
        }

        public static void ClassWork10()
        {

        }

        public static void ClassWork11()
        {

        }
    }
}

