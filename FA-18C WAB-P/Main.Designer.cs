namespace FA_18C_WAB_P
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            comboBox_Station9 = new ComboBox();
            splitContainer1 = new SplitContainer();
            trackBar_Fuel = new TrackBar();
            checkBox_AfterburnerTO = new CheckBox();
            textBox_Ammo = new TextBox();
            textBox_Fuel = new TextBox();
            label_Ammo = new Label();
            label_Fuel = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            comboBox_Station2 = new ComboBox();
            comboBox_Station4 = new ComboBox();
            comboBox_Station5 = new ComboBox();
            comboBox_Station3 = new ComboBox();
            comboBox_Station6 = new ComboBox();
            comboBox_Station7 = new ComboBox();
            comboBox_Station8 = new ComboBox();
            comboBox_Station1 = new ComboBox();
            trackBar_Ammo = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_Fuel).BeginInit();
            tabControl1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_Ammo).BeginInit();
            SuspendLayout();
            // 
            // comboBox_Station9
            // 
            comboBox_Station9.FormattingEnabled = true;
            comboBox_Station9.Items.AddRange(new object[] { "Empty", "AIM-9L", "AIM-9M", "AIM-9X", "TCMI Pod" });
            comboBox_Station9.Location = new Point(3, 185);
            comboBox_Station9.Name = "comboBox_Station9";
            comboBox_Station9.Size = new Size(182, 33);
            comboBox_Station9.TabIndex = 5;
            comboBox_Station9.Text = "Station 9";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(10, 573);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ActiveBorder;
            splitContainer1.Panel1.Controls.Add(trackBar_Ammo);
            splitContainer1.Panel1.Controls.Add(trackBar_Fuel);
            splitContainer1.Panel1.Controls.Add(checkBox_AfterburnerTO);
            splitContainer1.Panel1.Controls.Add(textBox_Ammo);
            splitContainer1.Panel1.Controls.Add(textBox_Fuel);
            splitContainer1.Panel1.Controls.Add(label_Ammo);
            splitContainer1.Panel1.Controls.Add(label_Fuel);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Control;
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1456, 359);
            splitContainer1.SplitterDistance = 728;
            splitContainer1.TabIndex = 6;
            // 
            // trackBar_Fuel
            // 
            trackBar_Fuel.Location = new Point(22, 71);
            trackBar_Fuel.Maximum = 100;
            trackBar_Fuel.Name = "trackBar_Fuel";
            trackBar_Fuel.Size = new Size(683, 69);
            trackBar_Fuel.TabIndex = 5;
            trackBar_Fuel.Value = 100;
            // 
            // checkBox_AfterburnerTO
            // 
            checkBox_AfterburnerTO.AutoSize = true;
            checkBox_AfterburnerTO.Location = new Point(22, 307);
            checkBox_AfterburnerTO.Name = "checkBox_AfterburnerTO";
            checkBox_AfterburnerTO.Size = new Size(191, 29);
            checkBox_AfterburnerTO.TabIndex = 4;
            checkBox_AfterburnerTO.Text = "Afterburner Takeoff";
            checkBox_AfterburnerTO.UseVisualStyleBackColor = true;
            checkBox_AfterburnerTO.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox_Ammo
            // 
            textBox_Ammo.Location = new Point(115, 156);
            textBox_Ammo.Name = "textBox_Ammo";
            textBox_Ammo.Size = new Size(150, 31);
            textBox_Ammo.TabIndex = 3;
            // 
            // textBox_Fuel
            // 
            textBox_Fuel.Location = new Point(115, 34);
            textBox_Fuel.Name = "textBox_Fuel";
            textBox_Fuel.Size = new Size(150, 31);
            textBox_Fuel.TabIndex = 2;
            // 
            // label_Ammo
            // 
            label_Ammo.AutoSize = true;
            label_Ammo.Location = new Point(22, 156);
            label_Ammo.Name = "label_Ammo";
            label_Ammo.Size = new Size(71, 25);
            label_Ammo.TabIndex = 1;
            label_Ammo.Text = "Ammo:";
            // 
            // label_Fuel
            // 
            label_Fuel.AutoSize = true;
            label_Fuel.Location = new Point(22, 34);
            label_Fuel.Name = "label_Fuel";
            label_Fuel.Size = new Size(87, 25);
            label_Fuel.TabIndex = 0;
            label_Fuel.Text = "Fuel in %:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-4, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(746, 376);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ActiveBorder;
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(738, 338);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Result";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ActiveBorder;
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(738, 338);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Loadout";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.BackgroundImage = Properties.Resources.FA_18C_Loadout;
            panel1.Controls.Add(comboBox_Station2);
            panel1.Controls.Add(comboBox_Station4);
            panel1.Controls.Add(comboBox_Station5);
            panel1.Controls.Add(comboBox_Station3);
            panel1.Controls.Add(comboBox_Station6);
            panel1.Controls.Add(comboBox_Station7);
            panel1.Controls.Add(comboBox_Station8);
            panel1.Controls.Add(comboBox_Station1);
            panel1.Controls.Add(comboBox_Station9);
            panel1.Location = new Point(10, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1456, 557);
            panel1.TabIndex = 7;
            // 
            // comboBox_Station2
            // 
            comboBox_Station2.FormattingEnabled = true;
            comboBox_Station2.Items.AddRange(new object[] { "Empty", "AIM-9L", "AIM-9M", "AIM-9X", "TCMI Pod" });
            comboBox_Station2.Location = new Point(1153, 296);
            comboBox_Station2.Name = "comboBox_Station2";
            comboBox_Station2.Size = new Size(182, 33);
            comboBox_Station2.TabIndex = 12;
            comboBox_Station2.Text = "Station 2";
            // 
            // comboBox_Station4
            // 
            comboBox_Station4.FormattingEnabled = true;
            comboBox_Station4.Items.AddRange(new object[] { "Empty", "AIM-9L", "AIM-9M", "AIM-9X", "TCMI Pod" });
            comboBox_Station4.Location = new Point(787, 492);
            comboBox_Station4.Name = "comboBox_Station4";
            comboBox_Station4.Size = new Size(182, 33);
            comboBox_Station4.TabIndex = 11;
            comboBox_Station4.Text = "Station 4";
            // 
            // comboBox_Station5
            // 
            comboBox_Station5.FormattingEnabled = true;
            comboBox_Station5.Items.AddRange(new object[] { "Empty", "AIM-9L", "AIM-9M", "AIM-9X", "TCMI Pod" });
            comboBox_Station5.Location = new Point(637, 310);
            comboBox_Station5.Name = "comboBox_Station5";
            comboBox_Station5.Size = new Size(182, 33);
            comboBox_Station5.TabIndex = 10;
            comboBox_Station5.Text = "Station 5";
            // 
            // comboBox_Station3
            // 
            comboBox_Station3.FormattingEnabled = true;
            comboBox_Station3.Items.AddRange(new object[] { "Empty", "AIM-9L", "AIM-9M", "AIM-9X", "TCMI Pod" });
            comboBox_Station3.Location = new Point(987, 391);
            comboBox_Station3.Name = "comboBox_Station3";
            comboBox_Station3.Size = new Size(182, 33);
            comboBox_Station3.TabIndex = 10;
            comboBox_Station3.Text = "Station 3";
            // 
            // comboBox_Station6
            // 
            comboBox_Station6.FormattingEnabled = true;
            comboBox_Station6.Items.AddRange(new object[] { "Empty", "AIM-9L", "AIM-9M", "AIM-9X", "TCMI Pod" });
            comboBox_Station6.Location = new Point(477, 492);
            comboBox_Station6.Name = "comboBox_Station6";
            comboBox_Station6.Size = new Size(182, 33);
            comboBox_Station6.TabIndex = 9;
            comboBox_Station6.Text = "Station 6";
            // 
            // comboBox_Station7
            // 
            comboBox_Station7.FormattingEnabled = true;
            comboBox_Station7.Items.AddRange(new object[] { "Empty", "AIM-9L", "AIM-9M", "AIM-9X", "TCMI Pod" });
            comboBox_Station7.Location = new Point(308, 391);
            comboBox_Station7.Name = "comboBox_Station7";
            comboBox_Station7.Size = new Size(182, 33);
            comboBox_Station7.TabIndex = 8;
            comboBox_Station7.Text = "Station 7";
            // 
            // comboBox_Station8
            // 
            comboBox_Station8.FormattingEnabled = true;
            comboBox_Station8.Items.AddRange(new object[] { "Empty", "AIM-9L", "AIM-9M", "AIM-9X", "TCMI Pod" });
            comboBox_Station8.Location = new Point(145, 296);
            comboBox_Station8.Name = "comboBox_Station8";
            comboBox_Station8.Size = new Size(182, 33);
            comboBox_Station8.TabIndex = 7;
            comboBox_Station8.Text = "Station 8";
            // 
            // comboBox_Station1
            // 
            comboBox_Station1.FormattingEnabled = true;
            comboBox_Station1.Items.AddRange(new object[] { "Empty", "AIM-9L", "AIM-9M", "AIM-9X", "TCMI Pod" });
            comboBox_Station1.Location = new Point(1260, 185);
            comboBox_Station1.Name = "comboBox_Station1";
            comboBox_Station1.Size = new Size(182, 33);
            comboBox_Station1.TabIndex = 6;
            comboBox_Station1.Text = "Station 1";
            // 
            // trackBar_Ammo
            // 
            trackBar_Ammo.Location = new Point(22, 193);
            trackBar_Ammo.Maximum = 578;
            trackBar_Ammo.Name = "trackBar_Ammo";
            trackBar_Ammo.Size = new Size(683, 69);
            trackBar_Ammo.TabIndex = 6;
            trackBar_Ammo.Value = 578;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 944);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F/A-18C Weight and Balance / Performance Calculator";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBar_Fuel).EndInit();
            tabControl1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBar_Ammo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBox_Station9;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox comboBox_Station1;
        private ComboBox comboBox_Station8;
        private ComboBox comboBox_Station6;
        private ComboBox comboBox_Station7;
        private ComboBox comboBox_Station4;
        private ComboBox comboBox_Station5;
        private ComboBox comboBox_Station3;
        private ComboBox comboBox_Station2;
        private Label label_Fuel;
        private Label label_Ammo;
        private TextBox textBox_Fuel;
        private TextBox textBox_Ammo;
        private CheckBox checkBox_AfterburnerTO;
        private TrackBar trackBar_Fuel;
        private TrackBar trackBar_Ammo;
    }
}
