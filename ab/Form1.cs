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
    public partial class Form1 : Form
    {
        #region Adattagok
        List<Jarmu> jarmuvek;
        #endregion

        #region Konstruktor
        public Form1()
        {
            InitializeComponent();
            ABKezelo.Csatlakozas();
            jarmuvek = ABKezelo.JarmuvekKiolvasasa();
            LBFrissit();
        }
        #endregion

        #region Alprogramok
        private void LBFrissit()
        {
            lb_Jarmuvek.DataSource = null;
            lb_Jarmuvek.DataSource = jarmuvek;
            
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Extensible Markup Language|*.xml";

            saveFileDialog1.Filter = "Extensible Markup Language|*.xml";
        }

        private void bt_UjJarmu_Click(object sender, EventArgs e)
        {
            frm_JarmuUrlap frm = new frm_JarmuUrlap();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (frm.Jarmu is Auto a)
                    {
                        ABKezelo.AutoFelvitel(a);
                    }
                    else if (frm.Jarmu is Motor m)
                    {
                        ABKezelo.MotorFelvitel(m);
                    }
                    jarmuvek = ABKezelo.JarmuvekKiolvasasa();
                    LBFrissit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }     
            }
        }

        private void bt_JarmuModositas_Click(object sender, EventArgs e)
        {
            if (lb_Jarmuvek.SelectedIndex < 0)
            {
                MessageBox.Show("Jarmu modositashoz jeloljon ki egy jarmuvet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int index = lb_Jarmuvek.SelectedIndex;
                Jarmu jarmu = jarmuvek[index];

                frm_JarmuUrlap frm = new frm_JarmuUrlap(jarmu);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (jarmu is Auto a)
                        {
                            ABKezelo.AutoModositas(a);
                        }
                        else if (jarmu is Motor m)
                        {
                            ABKezelo.MotorModositas(m);
                        }
                        jarmuvek = ABKezelo.JarmuvekKiolvasasa();
                        LBFrissit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bt_JarmuTorles_Click(object sender, EventArgs e)
        {
            if (lb_Jarmuvek.SelectedIndex < 0)
            {
                MessageBox.Show("Jarmu torleshez jeloljon ki egy jarmuvet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Biztos torli a jarmuvet?", "Torles", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        Jarmu torlendo = (Jarmu)lb_Jarmuvek.SelectedItem;

                        if (torlendo is Auto a)
                        {
                            ABKezelo.AutoTorles(a);
                        }
                        else if (torlendo is Motor m)
                        {
                            ABKezelo.MotorTorles(m);
                        }
                        jarmuvek = ABKezelo.JarmuvekKiolvasasa();
                        LBFrissit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ABKezelo.Lecsatlakozas();
        }

        private async void bt_JarmuToXML_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    await XMLKezelo.JarmuToXML(jarmuvek, saveFileDialog1.FileName);

                    MessageBox.Show("Sikeres XML exportalas!", "Mentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Sikertelen XML exportalas!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_XMLToJarmu_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ABKezelo.ABUrites();
                    jarmuvek.Clear();
                    jarmuvek = XMLKezelo.XMLToJarmu(openFileDialog1.FileName);

                    foreach (Jarmu j in jarmuvek)
                    {
                        if (j is Auto a)
                        {
                            ABKezelo.AutoFelvitel(a);
                        }
                        else if (j is Motor m)
                        {
                            ABKezelo.MotorFelvitel(m);
                        }
                    }

                    LBFrissit();
                }
            }
            catch
            {
                MessageBox.Show("Sikertelen XML importalas!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
        #endregion
    }
}
