using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernFormUI
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }


        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            panelCalculator.BackColor = Color.FromArgb(100,0,0,0);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(FirstValue.Text);
            double txt2 = Convert.ToDouble(SecondValue.Text);

            double add = txt1 + txt2;

            lblResult.Text = add.ToString();
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(FirstValue.Text);
            double txt2 = Convert.ToDouble(SecondValue.Text);

            double sub = txt1 - txt2;

            lblResult.Text = sub.ToString();
        }

        private void MultBtn_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(FirstValue.Text);
            double txt2 = Convert.ToDouble(SecondValue.Text);

            double mult = txt1 * txt2;

            lblResult.Text = mult.ToString();
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(FirstValue.Text);
            double txt2 = Convert.ToDouble(SecondValue.Text);

            double div = txt1 / txt2;

            lblResult.Text = div.ToString();
        }
    }
}
