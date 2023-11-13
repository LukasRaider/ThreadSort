using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSort
{
     internal static class Program6
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
        
        [STAThread]
        static void Mainx()
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
            }

            //Application.Run(new Form5(array));
         
            Form6 form = new Form6(polePRB);
       
            //Application.Run(form);
            
            form.Show();
            //form.showData();
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
            for (int y = 0; y < polePRB.Length - 1; y++)
            { for (int x = 0; x < polePRB.Length - 1; x++)
                {
                    if (polePRB[x] > polePRB[x + 1]) { }
            }
            }
        
        }


    }
}





