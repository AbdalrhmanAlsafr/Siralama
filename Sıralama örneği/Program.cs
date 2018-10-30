using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Sonuc3
    {
        public static float BubbleSort(int[] dizi)
        {
            int simdi = Convert.ToInt32(DateTime.Now.Millisecond);
            int uzn = dizi.Length;
            int temp;
            for (int outer = uzn; outer >= 1; outer--)
            {
                for (int inner = 0; inner < outer - 1; inner++)
                    if ((int)dizi[inner] > dizi[inner + 1])
                    {
                        temp = dizi[inner];
                        dizi[inner] = dizi[inner + 1];
                        dizi[inner + 1] = temp;
                        dizi[inner] = temp;
                    }

            }
            int sonra = Convert.ToInt32(DateTime.Now.Millisecond);
            float sonuc3 = Convert.ToInt32(sonra - simdi);

            return sonuc3;
        }
    }
    class Sonuc2
    {
        //Seçmeli (selection) Sıralaması
        public static float SelectionSort(int[] dizi)
        {
            int simdi = Convert.ToInt32(DateTime.Now.Millisecond);
            int uzn = dizi.Length;
            int min, temp;
            for (int outer = 0; outer < uzn; outer++)
            {
                min = outer;
                for (int inner = outer + 1; inner < uzn; inner++)
                    if (dizi[inner] < dizi[min])
                        min = inner;
                temp = dizi[outer];
                dizi[outer] = dizi[min];
                dizi[min] = temp;
            }
            int sonra = Convert.ToInt32(DateTime.Now.Millisecond);
            float sonuc2 = Convert.ToInt32(sonra - simdi);

            return sonuc2;
        }
    }
    class Program
    {
        public static float InsertionSort(int[] dizi)
        {
            int simdi = Convert.ToInt32(DateTime.Now.Millisecond);
            int uzn = dizi.Length;
            int inner, temp;
            for (int outer = 1; outer < uzn; outer++)
            {
                temp = dizi[outer];
                inner = outer;
                while (inner > 0 && dizi[inner - 1] >= temp)
                {
                    dizi[inner] = dizi[inner - 1];
                    inner -= 1;
                }
                dizi[inner] = temp;
            }
            int sonra = Convert.ToInt32(DateTime.Now.Millisecond);
            float sonuc = Convert.ToInt32(sonra - simdi);

            return sonuc;
        }




        static void Main(string[] args)
        {
            int[] dizi = new int[2000];
            Random uretec = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = uretec.Next(50, 500);

            }
            //Araya Ekleme(Insertion) Sıralaması
            float sonuc1 = InsertionSort(dizi);




            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = uretec.Next(50, 500);

            }


            //Seçmeli (selection) Sıralaması
            float sonuc2 = Sonuc2.SelectionSort(dizi);



            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = uretec.Next(50, 500);

            }
            //Kabarcık (Bubble) Sıralaması
            float sonuc3 = Sonuc3.BubbleSort(dizi);



            if (sonuc1 < sonuc2 && sonuc1 < sonuc3 & sonuc2 < sonuc3)
            {
                Console.WriteLine("En hızlı olan Insertion sort işlem   " + sonuc1 + "  Millisanyde gerçekleştirdi");
                Console.WriteLine("sonra selection sort işlem   " + sonuc2 + "  Millisanyde gerçekleştirdi");
                Console.WriteLine("sonra Bubble sort işlem  " + sonuc3 + "  Millisanyde gerçekleştirdi");
            }
            else if (sonuc1 < sonuc2 && sonuc1 < sonuc3 & sonuc3 < sonuc2)
            {
                Console.WriteLine("En hızlı olan Insertion işlem   " + sonuc1 + "  Millisanyde gerçekleştirdi");

                Console.WriteLine("sonra Bubble sort işlem   " + sonuc3 + "  Millisanyde gerçekleştirdi");
                Console.WriteLine("sonra selection sort işlem   " + sonuc2 + "  Millisanyde gerçekleştirdi");
            }
            else if (sonuc2 < sonuc1 && sonuc2 < sonuc3 && sonuc1 < sonuc3)
            {
                Console.WriteLine("En hızlı olan selection sort işlem  " + sonuc2 + "  Millisanyde gerçekleştirdi");
                Console.WriteLine("sonra Insertion işlem  " + sonuc1 + "  Millisanyde gerçekleştirdi");
                Console.WriteLine("sonra Bubble sort işlem   " + sonuc3 + "  Millisanyde gerçekleştirdi");
            }
            else if (sonuc2 < sonuc1 && sonuc2 < sonuc3 && sonuc3 < sonuc1)
            {
                Console.WriteLine("En hızlı olan selection sort işlem " + sonuc2 + "  Millisanyde gerçekleştirdi");
                Console.WriteLine("sonra Bubble sort işlem " + sonuc3 + "  Millisanyde gerçekleştirdi");
                Console.WriteLine("sonra Insertion işlem  " + sonuc1 + "  Millisanyde gerçekleştirdi");

            }
            else if (sonuc3 < sonuc1 & sonuc3 < sonuc2 & sonuc1 < sonuc2)
            {
                Console.WriteLine("En hızlı olan Bubble sort işlem  " + sonuc3 + "  Millisanyde gerçekleştirdi");
                Console.WriteLine("sonra Insertion işlem  " + sonuc1 + "  Millisanyde gerçekleştirdi");
                Console.WriteLine("sonra selection sort işlem  " + sonuc2 + "  Millisanyde gerçekleştirdi");


            }
            else if (sonuc3 < sonuc1 & sonuc3 < sonuc2 & sonuc2 < sonuc1)
            {
                Console.WriteLine("En hızlı olan Bubble sort işlem " + sonuc3 + "Millisanyde gerçekleştirdi");
                Console.WriteLine("sonra selection sort işlem " + sonuc2 + "Millisanyde gerçekleştirdi");
                Console.WriteLine("sonra Insertion işlem" + sonuc1 + "Millisanyde gerçekleştirdi");



            }

            Console.ReadLine();
        }
    }
}
