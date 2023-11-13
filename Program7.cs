using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSort
{
     internal static class Program7
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        ///int length = 15;
        ///int[] data = new int[length];
        ///Random random = new Random();
        ///int[] array = new int[length];
        static int length = 15;
        //static int[] data=new int[lenght];
        static int[] polePRB = new int[length];
        static int[] poleRPBorigin = new int[length];
        private static Form6 form, formOrigin;

        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form3());
            //int length = 15;
            //int[] data = new int[length];
            Random random = new Random();
            //int[] array = new int[length];
            int pomocA = 1, pomocB = 0;

            for (int i = 0; i < length; i++)
            {
                polePRB[i] = random.Next(101); // Generates a random number between 0 and 100
                poleRPBorigin[i] = polePRB[i];
            }

            //Application.Run(new Form5(array));
         
            form = new Form6(polePRB);
            formOrigin = new Form6(poleRPBorigin);
            //Application.Run(form);
            
            form.Show();
            formOrigin.Show();
            form.Location = new System.Drawing.Point(10, 10);
            formOrigin.Location = new System.Drawing.Point(500, 10);
            System.Threading.Thread.Sleep(10);

            int n = polePRB.Length;

            bool swapped;
            int lastSwapIndex = 0;
            do
            {
                swapped = false;
                lastSwapIndex = 0;

                for (int i = 1; i < n; i++)
                {

                    {
                        if (pomocA != pomocB)
                        {
                            if (polePRB[i - 1] > polePRB[i])
                            {
                                if (polePRB[i - 1] != polePRB[i])
                                {
                                    // Swap elements
                                    pomocA = polePRB[i - 1]; pomocB = polePRB[i];

                                    int temp = polePRB[i - 1];
                                    polePRB[i - 1] = polePRB[i];
                                    polePRB[i] = temp;

                                    swapped = true;
                                    lastSwapIndex = i ; // nacitani kolik zmen probehlo a nacitase
                                }
                            }
                        }
                        // Display the progress after each comparison
                        form.showData(i, n);
                        System.Threading.Thread.Sleep(10);
                    }


                }
                //n--; //poctani puvodni zmenseni pole prochazeni
                n = lastSwapIndex; //inicializace kroku podle zmen
            }

            
            while (swapped);

            BubleSortSimple();

            // Display the final sorted data
            //form.showData();
            System.Threading.Thread.Sleep(10);
            form.Show();

        }


        private static void BubleSortSimple()
        {
            for (int y = 0; y < poleRPBorigin.Length - 1; y++)
            { for (int x = 0; x < poleRPBorigin.Length - 1; x++)
                {
                    if (poleRPBorigin[x] > poleRPBorigin[x + 1]) {
                        int pom = poleRPBorigin[x];
                        poleRPBorigin[x] = poleRPBorigin[x + 1];
                        poleRPBorigin[x + 1] = pom;
                    }
                    formOrigin.showData(x, x + 1);
                    System.Threading.Thread.Sleep(10);
                    //pocetPruchodu++; // kolik proslo neni def
            }
                //pocetVnejsiSmyckou++; //kolik proslo vnejsi casti 
            }
        
        }


    }
}





