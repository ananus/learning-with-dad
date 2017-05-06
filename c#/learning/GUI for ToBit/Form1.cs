using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_for_ToBin
{
    public partial class Form1 : Form
    {
        static string ToBin(Int64 dec, Int64 b)
        {
            string s = "";
            while (dec > 0)
            {
                s = dec % b + s;
                dec /= b;
            }
            return s;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string theText = textBox1.Text;
            string trimmed = theText.Trim();
            Int64 num;
            if (Int64.TryParse(trimmed, out num))
            {
                for (int b = 2; b <=2; b++)
                {
                    string s = ToBin(num, b);

                
                converted.Text = s;
                }
            }
            
        }
    }
}
