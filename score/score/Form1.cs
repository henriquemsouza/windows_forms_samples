using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace score
{
    public partial class Form1 : Form
    {
        int score = 0;
        int score2 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
       
        
private void menos_Click(object sender, EventArgs e)
        {
            score--;
            lbl.Text = score.ToString();
        }

        private void mais_Click(object sender, EventArgs e)
        {
             score ++;
            lbl.Text = score.ToString();
        }

        private void less2_Click(object sender, EventArgs e)
        {
            score2--;
            lbl2.Text = score2.ToString();
        }

        private void plus2_Click(object sender, EventArgs e)
        {
            score2++;
            lbl2.Text = score2.ToString();
        }
    }
}
