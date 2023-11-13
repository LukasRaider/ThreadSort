using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSort
{
     internal static class Program5
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
         
        [STAThread]
        static void Mainx()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form3());
            int length = 15;
            int[] data = new int[length];
            Random random = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(101); // Generates a random number between 0 and 100
            }

            //Application.Run(new Form5(array));
         
            Form5 form = new Form5(array);
       
            //Application.Run(form);
            
            form.Show();
            form.showData();
            System.Threading.Thread.Sleep(1000);


        }




    }
}
