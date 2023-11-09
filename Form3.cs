using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThreadSort
{
    public class Form3 : Form
    {
        int rowWidth = 200;
        int rowHeight = 10;
        int spaceBetweenRows = 10;
        int numberOfProgressBar = 15; // Počet ProgressBar prvků
        int value = 5;

        public Form3()
        {
            for (int i = 1;i<= numberOfProgressBar; i++) {

                ProgressBar pBar = new ProgressBar();

                pBar.Value = value * i;
                pBar.Location = new Point(10, (spaceBetweenRows + rowHeight) * i);
        
                pBar.Name = "pBar" + i;
                pBar.Size = new Size(rowWidth, 10);
                
                Controls.Add(pBar);

               

                int clientHeight = (rowHeight + spaceBetweenRows) * numberOfProgressBar + spaceBetweenRows + 10;
                int clientWidth = rowWidth + 2 * spaceBetweenRows; // Přidáme okraje vlevo a vpravo

                ClientSize = new Size(clientWidth, clientHeight);

                /*pBar.Location = new Point(10, (spaceBetweenRows + 10) * i );
                pBar.Name = "pBar" + i+1;
                pBar.Size = new Size(rowWidth, 10);

                Controls.Add(pBar);*/

                //pBar.Location = new Point();
            }
            /*
            this.pBar2 = new ProgressBar();
            this.pBar2.Location = new Point(10, 30);
            this.pBar2.Name = "pBar1";
            this.pBar2.Size = new Size(200, 10);
            this.Controls.Add(this.pBar2);
            */
            
            // Form2
            /*   
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 262);
            this.Controls.Add(this.pBar2);
            this.Controls.Add(this.pBar1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            */
        }
        private System.Windows.Forms.ProgressBar pBar1;
        private System.Windows.Forms.ProgressBar pBar2;
    }
}
