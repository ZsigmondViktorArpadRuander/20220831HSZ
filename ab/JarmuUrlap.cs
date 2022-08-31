using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ab
{
    public partial class frm_JarmuUrlap : Form
    {
        #region Adattagok
        private Jarmu jarmu;
        #endregion

        #region Konstruktor
        public frm_JarmuUrlap()
        {
            InitializeComponent();
            cb_AutoTipus.DataSource = Enum.GetValues(typeof(AutoTipus));
            cb_MotorTipus.DataSource = Enum.GetValues(typeof(MotorTipus));
        }

        public frm_JarmuUrlap(Jarmu jarmu) : this()
        {
            this.jarmu = jarmu;

            tb_Rendszam.Text = jarmu.Rendszam;
            tb_Gyarto.Text = jarmu.Gyarto;
            tb_Tipus.Text = jarmu.Tipus;
            nud_Hengerurtartalom.Value = (decimal)jarmu.Hengerurtartalom;

            rb_Auto.Enabled = false;
            rb_Motor.Enabled = false;
            tb_Rendszam.Enabled = false;

            if (jarmu is Auto a)
            {
                gb_Auto.Enabled = true;
                gb_Motor.Enabled = false;

                rb_Auto.Checked = true;
                rb_Motor.Checked = false;

                cb_AutoTipus.SelectedItem = a.AutoTipus;
                nud_CsomagterL.Value = (decimal)a.CsomagterL;

                cb_AutoTipus.Enabled = false;
            }
            else if (jarmu is Motor m)
            {
                gb_Auto.Enabled = false;
                gb_Motor.Enabled = true;

                rb_Auto.Checked = false;
                rb_Motor.Checked = true;

                cb_MotorTipus.SelectedItem = m.MotorTipus;

                cb_MotorTipus.Enabled = false;
            }
        }
        #endregion

        #region Alprogramok
        private void bt_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (jarmu == null)
                {
                    if (rb_Auto.Checked)
                    {
                        jarmu = new Auto((AutoTipus)(cb_AutoTipus.SelectedItem), (double)(nud_CsomagterL.Value), tb_Rendszam.Text, tb_Gyarto.Text, tb_Tipus.Text, (double)(nud_Hengerurtartalom.Value));
                    }
                    else
                    {
                        jarmu = new Motor((MotorTipus)(cb_MotorTipus.SelectedItem), tb_Rendszam.Text, tb_Gyarto.Text, tb_Tipus.Text, (double)(nud_Hengerurtartalom.Value));
                    }
                }
                else
                {
                    jarmu.Gyarto = tb_Gyarto.Text;
                    jarmu.Tipus = tb_Tipus.Text;
                    jarmu.Hengerurtartalom = (double)nud_Hengerurtartalom.Value;

                    if (jarmu is Auto a)
                    {
                        a.CsomagterL = (double)nud_CsomagterL.Value;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Auto.Checked)
            {
                gb_Auto.Enabled = true;
                gb_Motor.Enabled = false;
            }
            else
            {
                gb_Auto.Enabled = false;
                gb_Motor.Enabled = true;
            }
        }
        #endregion

        #region Tulajdonsagok
        public Jarmu Jarmu { get => jarmu; }
        #endregion
    }
}
