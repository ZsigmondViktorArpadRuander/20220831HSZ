namespace ab
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Jarmuvek = new System.Windows.Forms.ListBox();
            this.bt_UjJarmu = new System.Windows.Forms.Button();
            this.bt_JarmuModositas = new System.Windows.Forms.Button();
            this.bt_JarmuTorles = new System.Windows.Forms.Button();
            this.bt_JarmuToXML = new System.Windows.Forms.Button();
            this.bt_XMLToJarmu = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lb_Jarmuvek
            // 
            this.lb_Jarmuvek.FormattingEnabled = true;
            this.lb_Jarmuvek.Location = new System.Drawing.Point(12, 12);
            this.lb_Jarmuvek.Name = "lb_Jarmuvek";
            this.lb_Jarmuvek.Size = new System.Drawing.Size(427, 420);
            this.lb_Jarmuvek.TabIndex = 0;
            // 
            // bt_UjJarmu
            // 
            this.bt_UjJarmu.Location = new System.Drawing.Point(12, 438);
            this.bt_UjJarmu.Name = "bt_UjJarmu";
            this.bt_UjJarmu.Size = new System.Drawing.Size(427, 23);
            this.bt_UjJarmu.TabIndex = 1;
            this.bt_UjJarmu.Text = "Uj jarmu";
            this.bt_UjJarmu.UseVisualStyleBackColor = true;
            this.bt_UjJarmu.Click += new System.EventHandler(this.bt_UjJarmu_Click);
            // 
            // bt_JarmuModositas
            // 
            this.bt_JarmuModositas.Location = new System.Drawing.Point(12, 467);
            this.bt_JarmuModositas.Name = "bt_JarmuModositas";
            this.bt_JarmuModositas.Size = new System.Drawing.Size(427, 23);
            this.bt_JarmuModositas.TabIndex = 2;
            this.bt_JarmuModositas.Text = "Jarmu modositas";
            this.bt_JarmuModositas.UseVisualStyleBackColor = true;
            this.bt_JarmuModositas.Click += new System.EventHandler(this.bt_JarmuModositas_Click);
            // 
            // bt_JarmuTorles
            // 
            this.bt_JarmuTorles.Location = new System.Drawing.Point(12, 496);
            this.bt_JarmuTorles.Name = "bt_JarmuTorles";
            this.bt_JarmuTorles.Size = new System.Drawing.Size(427, 23);
            this.bt_JarmuTorles.TabIndex = 3;
            this.bt_JarmuTorles.Text = "Jarmu torles";
            this.bt_JarmuTorles.UseVisualStyleBackColor = true;
            this.bt_JarmuTorles.Click += new System.EventHandler(this.bt_JarmuTorles_Click);
            // 
            // bt_JarmuToXML
            // 
            this.bt_JarmuToXML.Location = new System.Drawing.Point(12, 525);
            this.bt_JarmuToXML.Name = "bt_JarmuToXML";
            this.bt_JarmuToXML.Size = new System.Drawing.Size(207, 23);
            this.bt_JarmuToXML.TabIndex = 4;
            this.bt_JarmuToXML.Text = "Jarmuvek XML-be";
            this.bt_JarmuToXML.UseVisualStyleBackColor = true;
            this.bt_JarmuToXML.Click += new System.EventHandler(this.bt_JarmuToXML_Click);
            // 
            // bt_XMLToJarmu
            // 
            this.bt_XMLToJarmu.Location = new System.Drawing.Point(232, 525);
            this.bt_XMLToJarmu.Name = "bt_XMLToJarmu";
            this.bt_XMLToJarmu.Size = new System.Drawing.Size(207, 23);
            this.bt_XMLToJarmu.TabIndex = 5;
            this.bt_XMLToJarmu.Text = "Jarmuvek XML-bol";
            this.bt_XMLToJarmu.UseVisualStyleBackColor = true;
            this.bt_XMLToJarmu.Click += new System.EventHandler(this.bt_XMLToJarmu_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 560);
            this.Controls.Add(this.bt_XMLToJarmu);
            this.Controls.Add(this.bt_JarmuToXML);
            this.Controls.Add(this.bt_JarmuTorles);
            this.Controls.Add(this.bt_JarmuModositas);
            this.Controls.Add(this.bt_UjJarmu);
            this.Controls.Add(this.lb_Jarmuvek);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jarmuvek";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Jarmuvek;
        private System.Windows.Forms.Button bt_UjJarmu;
        private System.Windows.Forms.Button bt_JarmuModositas;
        private System.Windows.Forms.Button bt_JarmuTorles;
        private System.Windows.Forms.Button bt_JarmuToXML;
        private System.Windows.Forms.Button bt_XMLToJarmu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

