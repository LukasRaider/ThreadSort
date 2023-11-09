using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThreadSort
{
    public class Form2 : Form
    {


        public Form2()
        {
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.pBar2 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // pBar1
            this.pBar1.Location = new System.Drawing.Point(10, 10);
            this.pBar1.Margin = new System.Windows.Forms.Padding(1);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(200, 20);
            this.pBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar1.TabIndex = 0;
            //}
            // pBar2
            this.pBar2.Location = new System.Drawing.Point(10, 40);
            this.pBar2.Name = "pBar2";
            this.pBar2.Size = new System.Drawing.Size(200, 20);
            this.pBar2.TabIndex = 1;
            // Form2       
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 262);
            this.Controls.Add(this.pBar2);
            this.Controls.Add(this.pBar1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.ProgressBar pBar1;
        private System.Windows.Forms.ProgressBar pBar2;
    }
}
