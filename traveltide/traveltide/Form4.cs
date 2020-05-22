using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traveltide
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            customizedesign();
        }
        private void customizedesign()
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panel2.Visible == true)
                panel2.Visible = false;
            if (panel3.Visible == true)
                panel3.Visible = false;
            if (panel4.Visible == true)
                panel4.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form10 f10 = new Form10();
            f10.TopLevel = false;
            f10.TopMost = true;
            panel5.Controls.Add(f10);
            f10.Show();
            openChildForm(new Form10());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Form7());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Form8());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form5 f5 = new Form5();
            f5.TopLevel = false;
            f5.TopMost = true;
            panel5.Controls.Add(f5);
            f5.Show();
            openChildForm(new Form5());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showSubMenu(panel3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form6 f6 = new Form6();
            f6.TopLevel = false;
            f6.TopMost = true;
            panel5.Controls.Add(f6);
            f6.Show();
            openChildForm(new Form6());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showSubMenu(panel4);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel5.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
