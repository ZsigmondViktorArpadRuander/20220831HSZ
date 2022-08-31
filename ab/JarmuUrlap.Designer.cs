namespace ab
{
    partial class frm_JarmuUrlap
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
            this.gb_Jarmu = new System.Windows.Forms.GroupBox();
            this.rb_Motor = new System.Windows.Forms.RadioButton();
            this.rb_Auto = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_Hengerurtartalom = new System.Windows.Forms.NumericUpDown();
            this.tb_Tipus = new System.Windows.Forms.TextBox();
            this.tb_Gyarto = new System.Windows.Forms.TextBox();
            this.tb_Rendszam = new System.Windows.Forms.TextBox();
            this.gb_Auto = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_CsomagterL = new System.Windows.Forms.NumericUpDown();
            this.cb_AutoTipus = new System.Windows.Forms.ComboBox();
            this.gb_Motor = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_MotorTipus = new System.Windows.Forms.ComboBox();
            this.bt_Ok = new System.Windows.Forms.Button();
            this.bt_Megse = new System.Windows.Forms.Button();
            this.gb_Jarmu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Hengerurtartalom)).BeginInit();
            this.gb_Auto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CsomagterL)).BeginInit();
            this.gb_Motor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Jarmu
            // 
            this.gb_Jarmu.Controls.Add(this.rb_Motor);
            this.gb_Jarmu.Controls.Add(this.rb_Auto);
            this.gb_Jarmu.Controls.Add(this.label4);
            this.gb_Jarmu.Controls.Add(this.label3);
            this.gb_Jarmu.Controls.Add(this.label2);
            this.gb_Jarmu.Controls.Add(this.label1);
            this.gb_Jarmu.Controls.Add(this.nud_Hengerurtartalom);
            this.gb_Jarmu.Controls.Add(this.tb_Tipus);
            this.gb_Jarmu.Controls.Add(this.tb_Gyarto);
            this.gb_Jarmu.Controls.Add(this.tb_Rendszam);
            this.gb_Jarmu.Location = new System.Drawing.Point(12, 12);
            this.gb_Jarmu.Name = "gb_Jarmu";
            this.gb_Jarmu.Size = new System.Drawing.Size(285, 194);
            this.gb_Jarmu.TabIndex = 0;
            this.gb_Jarmu.TabStop = false;
            this.gb_Jarmu.Text = "Alapadatok";
            // 
            // rb_Motor
            // 
            this.rb_Motor.AutoSize = true;
            this.rb_Motor.Location = new System.Drawing.Point(88, 160);
            this.rb_Motor.Name = "rb_Motor";
            this.rb_Motor.Size = new System.Drawing.Size(52, 17);
            this.rb_Motor.TabIndex = 9;
            this.rb_Motor.Text = "Motor";
            this.rb_Motor.UseVisualStyleBackColor = true;
            this.rb_Motor.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_Auto
            // 
            this.rb_Auto.AutoSize = true;
            this.rb_Auto.Checked = true;
            this.rb_Auto.Location = new System.Drawing.Point(88, 137);
            this.rb_Auto.Name = "rb_Auto";
            this.rb_Auto.Size = new System.Drawing.Size(47, 17);
            this.rb_Auto.TabIndex = 8;
            this.rb_Auto.TabStop = true;
            this.rb_Auto.Text = "Auto";
            this.rb_Auto.UseVisualStyleBackColor = true;
            this.rb_Auto.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ccm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gyarto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rendszam";
            // 
            // nud_Hengerurtartalom
            // 
            this.nud_Hengerurtartalom.DecimalPlaces = 1;
            this.nud_Hengerurtartalom.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_Hengerurtartalom.Location = new System.Drawing.Point(88, 97);
            this.nud_Hengerurtartalom.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud_Hengerurtartalom.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_Hengerurtartalom.Name = "nud_Hengerurtartalom";
            this.nud_Hengerurtartalom.Size = new System.Drawing.Size(178, 20);
            this.nud_Hengerurtartalom.TabIndex = 3;
            this.nud_Hengerurtartalom.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // tb_Tipus
            // 
            this.tb_Tipus.Location = new System.Drawing.Point(88, 71);
            this.tb_Tipus.Name = "tb_Tipus";
            this.tb_Tipus.Size = new System.Drawing.Size(178, 20);
            this.tb_Tipus.TabIndex = 2;
            // 
            // tb_Gyarto
            // 
            this.tb_Gyarto.Location = new System.Drawing.Point(88, 45);
            this.tb_Gyarto.Name = "tb_Gyarto";
            this.tb_Gyarto.Size = new System.Drawing.Size(178, 20);
            this.tb_Gyarto.TabIndex = 1;
            // 
            // tb_Rendszam
            // 
            this.tb_Rendszam.Location = new System.Drawing.Point(88, 19);
            this.tb_Rendszam.Name = "tb_Rendszam";
            this.tb_Rendszam.Size = new System.Drawing.Size(178, 20);
            this.tb_Rendszam.TabIndex = 0;
            // 
            // gb_Auto
            // 
            this.gb_Auto.Controls.Add(this.label6);
            this.gb_Auto.Controls.Add(this.label5);
            this.gb_Auto.Controls.Add(this.nud_CsomagterL);
            this.gb_Auto.Controls.Add(this.cb_AutoTipus);
            this.gb_Auto.Location = new System.Drawing.Point(12, 212);
            this.gb_Auto.Name = "gb_Auto";
            this.gb_Auto.Size = new System.Drawing.Size(285, 103);
            this.gb_Auto.TabIndex = 1;
            this.gb_Auto.TabStop = false;
            this.gb_Auto.Text = "Auto adatok";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Csomagter";
            // 
            // nud_CsomagterL
            // 
            this.nud_CsomagterL.DecimalPlaces = 1;
            this.nud_CsomagterL.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_CsomagterL.Location = new System.Drawing.Point(88, 55);
            this.nud_CsomagterL.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nud_CsomagterL.Name = "nud_CsomagterL";
            this.nud_CsomagterL.Size = new System.Drawing.Size(178, 20);
            this.nud_CsomagterL.TabIndex = 10;
            this.nud_CsomagterL.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // cb_AutoTipus
            // 
            this.cb_AutoTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AutoTipus.FormattingEnabled = true;
            this.cb_AutoTipus.Location = new System.Drawing.Point(88, 28);
            this.cb_AutoTipus.Name = "cb_AutoTipus";
            this.cb_AutoTipus.Size = new System.Drawing.Size(178, 21);
            this.cb_AutoTipus.TabIndex = 0;
            // 
            // gb_Motor
            // 
            this.gb_Motor.Controls.Add(this.label7);
            this.gb_Motor.Controls.Add(this.cb_MotorTipus);
            this.gb_Motor.Enabled = false;
            this.gb_Motor.Location = new System.Drawing.Point(12, 321);
            this.gb_Motor.Name = "gb_Motor";
            this.gb_Motor.Size = new System.Drawing.Size(285, 74);
            this.gb_Motor.TabIndex = 12;
            this.gb_Motor.TabStop = false;
            this.gb_Motor.Text = "Motor adatok";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tipus";
            // 
            // cb_MotorTipus
            // 
            this.cb_MotorTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MotorTipus.FormattingEnabled = true;
            this.cb_MotorTipus.Location = new System.Drawing.Point(88, 28);
            this.cb_MotorTipus.Name = "cb_MotorTipus";
            this.cb_MotorTipus.Size = new System.Drawing.Size(178, 21);
            this.cb_MotorTipus.TabIndex = 0;
            // 
            // bt_Ok
            // 
            this.bt_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Ok.Location = new System.Drawing.Point(141, 421);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(75, 23);
            this.bt_Ok.TabIndex = 13;
            this.bt_Ok.Text = "OK";
            this.bt_Ok.UseVisualStyleBackColor = true;
            this.bt_Ok.Click += new System.EventHandler(this.bt_Ok_Click);
            // 
            // bt_Megse
            // 
            this.bt_Megse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Megse.Location = new System.Drawing.Point(222, 421);
            this.bt_Megse.Name = "bt_Megse";
            this.bt_Megse.Size = new System.Drawing.Size(75, 23);
            this.bt_Megse.TabIndex = 14;
            this.bt_Megse.Text = "Megse";
            this.bt_Megse.UseVisualStyleBackColor = true;
            // 
            // frm_JarmuUrlap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 453);
            this.Controls.Add(this.bt_Megse);
            this.Controls.Add(this.bt_Ok);
            this.Controls.Add(this.gb_Motor);
            this.Controls.Add(this.gb_Auto);
            this.Controls.Add(this.gb_Jarmu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_JarmuUrlap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jarmu Urlap";
            this.gb_Jarmu.ResumeLayout(false);
            this.gb_Jarmu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Hengerurtartalom)).EndInit();
            this.gb_Auto.ResumeLayout(false);
            this.gb_Auto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CsomagterL)).EndInit();
            this.gb_Motor.ResumeLayout(false);
            this.gb_Motor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Jarmu;
        private System.Windows.Forms.NumericUpDown nud_Hengerurtartalom;
        private System.Windows.Forms.TextBox tb_Tipus;
        private System.Windows.Forms.TextBox tb_Gyarto;
        private System.Windows.Forms.TextBox tb_Rendszam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_Motor;
        private System.Windows.Forms.RadioButton rb_Auto;
        private System.Windows.Forms.GroupBox gb_Auto;
        private System.Windows.Forms.NumericUpDown nud_CsomagterL;
        private System.Windows.Forms.ComboBox cb_AutoTipus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_Motor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_MotorTipus;
        private System.Windows.Forms.Button bt_Ok;
        private System.Windows.Forms.Button bt_Megse;
    }
}