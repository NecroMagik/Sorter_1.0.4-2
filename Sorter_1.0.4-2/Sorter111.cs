using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sorter_1._0._4_2
{
    public partial class Sorter : Form
    {
        public Sorter()
        {
            InitializeComponent();
        }




        #region Диалоги

        bool ConfirmCloseRU()
        {
            DialogResult confirm = MessageBox.Show("Закрыть?", "Подтвердите закрытие", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool ConfirmCloseEN()
        {
            DialogResult confirm = MessageBox.Show("Close?", "Confirm closing", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        int Les = 0;
        int Change = 0;

       public void Leng1()
        {
            int Loc = Convert.ToInt32(textBox1.Text);

            if (Loc > 0)
            {
                RUS();

            }
            else
            {
                ENG();

            }
        }

        void Leng2()
        {
            int Loc = Convert.ToInt32(textBox1.Text);

            if (Loc > 0)
            {
                ENG();

            }
            else
            {
                RUS();

            }
        }

        #region Локализация
        public void RUS()
        {

            

            roundButton1.Text = "Сменить язык";

            this.Text = "Сортировщик";
            
            Change = 1;
        }
        public void ENG()
        {

            

            roundButton1.Text = "Change language";
            this.Text = "Sorter";
            
            Change = -1;
        }
        #endregion

        

        private void Sorter_Load(object sender, EventArgs e)
        {
            ControlBox = false;

            int Loc = Convert.ToInt32(textBox1.Text);

            if (Loc > 0)
            {
                RUS();
                Les = 1;

            }
            else
            {
                ENG();
                Les = -1;

            }
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Change > 0)
            {
                if (ConfirmCloseRU())
                {
                    Form ifrm = Application.OpenForms[0];
                    ifrm.Close();
                }
                else
                {
                    MessageBox.Show("Отменено");
                }
            }
            else
            {
                if (ConfirmCloseEN())
                {
                    Form ifrm = Application.OpenForms[0];
                    ifrm.Close();
                }
                else
                {
                    MessageBox.Show("Canceled");
                }
            }

        }


        private void roundButton1_Click(object sender, EventArgs e)
        {
            if(Les > 0)
            {
                ENG();
                Les = -1;
                Refresh();
            }
            else
            {
                RUS();
                Les = 1;
                Refresh();
            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage3);
            tabControl1.SelectTab(tabPage3);
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.SelectTab(tabPage2);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    

