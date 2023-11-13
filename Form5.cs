using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ThreadSort
{
    public class Form5 : Form
    {
        int rowWidth = 400;
        int rowHeight = 20;
        int spaceBetweenRows = 10;
        private int[] data;
        private ProgressBar[] pBars;
        
        public Form5(int[] field)
        {
            this.data = field;
            //ProgressBar[] pBars = new ProgressBar[field.Length];

            this.pBars = new ProgressBar[field.Length];

            for (int i = 0;i< field.Length; i++) {

                
                pBars[i] = new ProgressBar();

               

                pBars[i].Value = field[i];

                //showData();

                pBars[i].Location = new Point(10, (spaceBetweenRows + rowHeight) * i);
        
                pBars[i].Name = "pBar" + i;
                pBars[i].Size = new Size(rowWidth, rowHeight);
                
                Controls.Add(pBars[i]);

                int clientHeight = (rowHeight + spaceBetweenRows) * field.Length + spaceBetweenRows; //+ rowHeight;
                int clientWidth = rowWidth + 2 * spaceBetweenRows; // Přidáme okraje vlevo a vpravo

                ClientSize = new Size(clientWidth, clientHeight);

               
            }
           
         
        }
        private System.Windows.Forms.ProgressBar pBar1;
        private System.Windows.Forms.ProgressBar pBar2;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form3
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form3";
            this.Text = "ProgressBar";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        public void showData() {


            for (int i = 0; i < data.Length; i++)
            {
   
                pBars[i].Value = data[i];

                //Console.WriteLine(pBars[i].Value);
                pBars[i].Refresh();
                System.Threading.Thread.Sleep(100);
            }
            
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
