namespace Bus_Pirate_V4_GUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialportscombobox = new System.Windows.Forms.ComboBox();
            this.serialconnect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.modelbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendtxtbox = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.boardcontrolgroupbox = new System.Windows.Forms.GroupBox();
            this.pwmchckbox = new System.Windows.Forms.CheckBox();
            this.formatlbl = new System.Windows.Forms.Label();
            this.formatcombobox = new System.Windows.Forms.ComboBox();
            this.auxlbl = new System.Windows.Forms.Label();
            this.auxcombobox = new System.Windows.Forms.ComboBox();
            this.voltmeterchckbox = new System.Windows.Forms.CheckBox();
            this.menubtn = new System.Windows.Forms.Button();
            this.versionbtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.selftestbtn = new System.Windows.Forms.Button();
            this.pullupchckbox = new System.Windows.Forms.CheckBox();
            this.powersupplychckbox = new System.Windows.Forms.CheckBox();
            this.macrosgroupdbox = new System.Windows.Forms.GroupBox();
            this.macrobtn5 = new System.Windows.Forms.Button();
            this.macrobtn4 = new System.Windows.Forms.Button();
            this.macrobtn3 = new System.Windows.Forms.Button();
            this.macro2btn = new System.Windows.Forms.Button();
            this.macrobtn1 = new System.Windows.Forms.Button();
            this.macromenubtn = new System.Windows.Forms.Button();
            this.rawdatarichtxtbox = new System.Windows.Forms.RichTextBox();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.baudcombobox = new System.Windows.Forms.ComboBox();
            this.measurementgroupbox = new System.Windows.Forms.GroupBox();
            this.freqbtn = new System.Windows.Forms.Button();
            this.freqtxtbox = new System.Windows.Forms.TextBox();
            this.freqlbl = new System.Windows.Forms.Label();
            this.adconeshotbtn = new System.Windows.Forms.Button();
            this.voltslbl = new System.Windows.Forms.Label();
            this.voltstxtbox = new System.Windows.Forms.TextBox();
            this.helpbtn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.boardcontrolgroupbox.SuspendLayout();
            this.macrosgroupdbox.SuspendLayout();
            this.measurementgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            // 
            // serialportscombobox
            // 
            this.serialportscombobox.FormattingEnabled = true;
            this.serialportscombobox.Location = new System.Drawing.Point(108, 12);
            this.serialportscombobox.Name = "serialportscombobox";
            this.serialportscombobox.Size = new System.Drawing.Size(75, 21);
            this.serialportscombobox.TabIndex = 1;
            // 
            // serialconnect
            // 
            this.serialconnect.Location = new System.Drawing.Point(189, 10);
            this.serialconnect.Name = "serialconnect";
            this.serialconnect.Size = new System.Drawing.Size(69, 23);
            this.serialconnect.TabIndex = 2;
            this.serialconnect.Text = "Connect";
            this.serialconnect.UseVisualStyleBackColor = true;
            this.serialconnect.Click += new System.EventHandler(this.serialconnect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslbl,
            this.modelbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(755, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = false;
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(200, 17);
            this.statuslbl.Text = "Status";
            // 
            // modelbl
            // 
            this.modelbl.AutoSize = false;
            this.modelbl.Name = "modelbl";
            this.modelbl.Size = new System.Drawing.Size(100, 17);
            this.modelbl.Text = "Mode";
            // 
            // sendtxtbox
            // 
            this.sendtxtbox.Location = new System.Drawing.Point(12, 51);
            this.sendtxtbox.Name = "sendtxtbox";
            this.sendtxtbox.Size = new System.Drawing.Size(212, 20);
            this.sendtxtbox.TabIndex = 4;
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(230, 49);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(75, 23);
            this.sendbtn.TabIndex = 5;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // boardcontrolgroupbox
            // 
            this.boardcontrolgroupbox.Controls.Add(this.pwmchckbox);
            this.boardcontrolgroupbox.Controls.Add(this.formatlbl);
            this.boardcontrolgroupbox.Controls.Add(this.formatcombobox);
            this.boardcontrolgroupbox.Controls.Add(this.auxlbl);
            this.boardcontrolgroupbox.Controls.Add(this.auxcombobox);
            this.boardcontrolgroupbox.Controls.Add(this.voltmeterchckbox);
            this.boardcontrolgroupbox.Controls.Add(this.menubtn);
            this.boardcontrolgroupbox.Controls.Add(this.versionbtn);
            this.boardcontrolgroupbox.Controls.Add(this.resetbtn);
            this.boardcontrolgroupbox.Controls.Add(this.selftestbtn);
            this.boardcontrolgroupbox.Controls.Add(this.pullupchckbox);
            this.boardcontrolgroupbox.Controls.Add(this.powersupplychckbox);
            this.boardcontrolgroupbox.Location = new System.Drawing.Point(327, 38);
            this.boardcontrolgroupbox.Name = "boardcontrolgroupbox";
            this.boardcontrolgroupbox.Size = new System.Drawing.Size(416, 211);
            this.boardcontrolgroupbox.TabIndex = 7;
            this.boardcontrolgroupbox.TabStop = false;
            this.boardcontrolgroupbox.Text = "Board Control";
            // 
            // pwmchckbox
            // 
            this.pwmchckbox.AutoSize = true;
            this.pwmchckbox.Location = new System.Drawing.Point(7, 90);
            this.pwmchckbox.Name = "pwmchckbox";
            this.pwmchckbox.Size = new System.Drawing.Size(53, 17);
            this.pwmchckbox.TabIndex = 11;
            this.pwmchckbox.Text = "PWM";
            this.pwmchckbox.UseVisualStyleBackColor = true;
            this.pwmchckbox.CheckedChanged += new System.EventHandler(this.pwmchckbox_CheckedChanged);
            // 
            // formatlbl
            // 
            this.formatlbl.AutoSize = true;
            this.formatlbl.Location = new System.Drawing.Point(23, 156);
            this.formatlbl.Name = "formatlbl";
            this.formatlbl.Size = new System.Drawing.Size(65, 13);
            this.formatlbl.TabIndex = 10;
            this.formatlbl.Text = "Data Format";
            // 
            // formatcombobox
            // 
            this.formatcombobox.FormattingEnabled = true;
            this.formatcombobox.Items.AddRange(new object[] {
            "HEX",
            "DEC",
            "BIN",
            "RAW"});
            this.formatcombobox.Location = new System.Drawing.Point(7, 172);
            this.formatcombobox.Name = "formatcombobox";
            this.formatcombobox.Size = new System.Drawing.Size(91, 21);
            this.formatcombobox.TabIndex = 9;
            this.formatcombobox.SelectedIndexChanged += new System.EventHandler(this.formatcombobox_SelectedIndexChanged);
            // 
            // auxlbl
            // 
            this.auxlbl.AutoSize = true;
            this.auxlbl.Location = new System.Drawing.Point(39, 115);
            this.auxlbl.Name = "auxlbl";
            this.auxlbl.Size = new System.Drawing.Size(25, 13);
            this.auxlbl.TabIndex = 8;
            this.auxlbl.Text = "Aux";
            // 
            // auxcombobox
            // 
            this.auxcombobox.FormattingEnabled = true;
            this.auxcombobox.Items.AddRange(new object[] {
            "Low",
            "High",
            "Read"});
            this.auxcombobox.Location = new System.Drawing.Point(7, 132);
            this.auxcombobox.Name = "auxcombobox";
            this.auxcombobox.Size = new System.Drawing.Size(91, 21);
            this.auxcombobox.TabIndex = 7;
            this.auxcombobox.SelectedIndexChanged += new System.EventHandler(this.auxcombobox_SelectedIndexChanged);
            // 
            // voltmeterchckbox
            // 
            this.voltmeterchckbox.AutoSize = true;
            this.voltmeterchckbox.Location = new System.Drawing.Point(7, 67);
            this.voltmeterchckbox.Name = "voltmeterchckbox";
            this.voltmeterchckbox.Size = new System.Drawing.Size(70, 17);
            this.voltmeterchckbox.TabIndex = 6;
            this.voltmeterchckbox.Text = "Voltmeter";
            this.voltmeterchckbox.UseVisualStyleBackColor = true;
            this.voltmeterchckbox.CheckedChanged += new System.EventHandler(this.voltmeterchckbox_CheckedChanged);
            // 
            // menubtn
            // 
            this.menubtn.Location = new System.Drawing.Point(104, 101);
            this.menubtn.Name = "menubtn";
            this.menubtn.Size = new System.Drawing.Size(60, 23);
            this.menubtn.TabIndex = 5;
            this.menubtn.Text = "Menu";
            this.menubtn.UseVisualStyleBackColor = true;
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // versionbtn
            // 
            this.versionbtn.Location = new System.Drawing.Point(104, 72);
            this.versionbtn.Name = "versionbtn";
            this.versionbtn.Size = new System.Drawing.Size(60, 23);
            this.versionbtn.TabIndex = 4;
            this.versionbtn.Text = "Version";
            this.versionbtn.UseVisualStyleBackColor = true;
            this.versionbtn.Click += new System.EventHandler(this.versionbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(104, 16);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(60, 23);
            this.resetbtn.TabIndex = 3;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // selftestbtn
            // 
            this.selftestbtn.Location = new System.Drawing.Point(104, 43);
            this.selftestbtn.Name = "selftestbtn";
            this.selftestbtn.Size = new System.Drawing.Size(60, 23);
            this.selftestbtn.TabIndex = 2;
            this.selftestbtn.Text = "Test";
            this.selftestbtn.UseVisualStyleBackColor = true;
            this.selftestbtn.Click += new System.EventHandler(this.selftestbtn_Click);
            // 
            // pullupchckbox
            // 
            this.pullupchckbox.AutoSize = true;
            this.pullupchckbox.Location = new System.Drawing.Point(7, 43);
            this.pullupchckbox.Name = "pullupchckbox";
            this.pullupchckbox.Size = new System.Drawing.Size(82, 17);
            this.pullupchckbox.TabIndex = 1;
            this.pullupchckbox.Text = "Pull Up Res";
            this.pullupchckbox.UseVisualStyleBackColor = true;
            // 
            // powersupplychckbox
            // 
            this.powersupplychckbox.AutoSize = true;
            this.powersupplychckbox.Location = new System.Drawing.Point(7, 20);
            this.powersupplychckbox.Name = "powersupplychckbox";
            this.powersupplychckbox.Size = new System.Drawing.Size(91, 17);
            this.powersupplychckbox.TabIndex = 0;
            this.powersupplychckbox.Text = "Power Supply";
            this.powersupplychckbox.UseVisualStyleBackColor = true;
            this.powersupplychckbox.CheckedChanged += new System.EventHandler(this.powersupplychckbox_CheckedChanged);
            // 
            // macrosgroupdbox
            // 
            this.macrosgroupdbox.Controls.Add(this.macrobtn5);
            this.macrosgroupdbox.Controls.Add(this.macrobtn4);
            this.macrosgroupdbox.Controls.Add(this.macrobtn3);
            this.macrosgroupdbox.Controls.Add(this.macro2btn);
            this.macrosgroupdbox.Controls.Add(this.macrobtn1);
            this.macrosgroupdbox.Controls.Add(this.macromenubtn);
            this.macrosgroupdbox.Location = new System.Drawing.Point(573, 255);
            this.macrosgroupdbox.Name = "macrosgroupdbox";
            this.macrosgroupdbox.Size = new System.Drawing.Size(170, 82);
            this.macrosgroupdbox.TabIndex = 8;
            this.macrosgroupdbox.TabStop = false;
            this.macrosgroupdbox.Text = "Macros";
            // 
            // macrobtn5
            // 
            this.macrobtn5.Location = new System.Drawing.Point(138, 48);
            this.macrobtn5.Name = "macrobtn5";
            this.macrobtn5.Size = new System.Drawing.Size(27, 23);
            this.macrobtn5.TabIndex = 5;
            this.macrobtn5.Text = "5";
            this.macrobtn5.UseVisualStyleBackColor = true;
            this.macrobtn5.Click += new System.EventHandler(this.macrobtn5_Click);
            // 
            // macrobtn4
            // 
            this.macrobtn4.Location = new System.Drawing.Point(105, 48);
            this.macrobtn4.Name = "macrobtn4";
            this.macrobtn4.Size = new System.Drawing.Size(27, 23);
            this.macrobtn4.TabIndex = 4;
            this.macrobtn4.Text = "4";
            this.macrobtn4.UseVisualStyleBackColor = true;
            this.macrobtn4.Click += new System.EventHandler(this.macrobtn4_Click);
            // 
            // macrobtn3
            // 
            this.macrobtn3.Location = new System.Drawing.Point(72, 48);
            this.macrobtn3.Name = "macrobtn3";
            this.macrobtn3.Size = new System.Drawing.Size(27, 23);
            this.macrobtn3.TabIndex = 3;
            this.macrobtn3.Text = "3";
            this.macrobtn3.UseVisualStyleBackColor = true;
            this.macrobtn3.Click += new System.EventHandler(this.macrobtn3_Click);
            // 
            // macro2btn
            // 
            this.macro2btn.Location = new System.Drawing.Point(39, 48);
            this.macro2btn.Name = "macro2btn";
            this.macro2btn.Size = new System.Drawing.Size(27, 23);
            this.macro2btn.TabIndex = 2;
            this.macro2btn.Text = "2";
            this.macro2btn.UseVisualStyleBackColor = true;
            this.macro2btn.Click += new System.EventHandler(this.macro2btn_Click);
            // 
            // macrobtn1
            // 
            this.macrobtn1.Location = new System.Drawing.Point(6, 48);
            this.macrobtn1.Name = "macrobtn1";
            this.macrobtn1.Size = new System.Drawing.Size(27, 23);
            this.macrobtn1.TabIndex = 1;
            this.macrobtn1.Text = "1";
            this.macrobtn1.UseVisualStyleBackColor = true;
            this.macrobtn1.Click += new System.EventHandler(this.macrobtn1_Click);
            // 
            // macromenubtn
            // 
            this.macromenubtn.Location = new System.Drawing.Point(6, 19);
            this.macromenubtn.Name = "macromenubtn";
            this.macromenubtn.Size = new System.Drawing.Size(159, 23);
            this.macromenubtn.TabIndex = 0;
            this.macromenubtn.Text = "Macro Menu";
            this.macromenubtn.UseVisualStyleBackColor = true;
            this.macromenubtn.Click += new System.EventHandler(this.macromenubtn_Click);
            // 
            // rawdatarichtxtbox
            // 
            this.rawdatarichtxtbox.Location = new System.Drawing.Point(12, 77);
            this.rawdatarichtxtbox.Name = "rawdatarichtxtbox";
            this.rawdatarichtxtbox.Size = new System.Drawing.Size(293, 282);
            this.rawdatarichtxtbox.TabIndex = 9;
            this.rawdatarichtxtbox.Text = "";
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(264, 10);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(52, 23);
            this.refreshbtn.TabIndex = 10;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // baudcombobox
            // 
            this.baudcombobox.FormattingEnabled = true;
            this.baudcombobox.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.baudcombobox.Location = new System.Drawing.Point(12, 12);
            this.baudcombobox.Name = "baudcombobox";
            this.baudcombobox.Size = new System.Drawing.Size(90, 21);
            this.baudcombobox.TabIndex = 11;
            // 
            // measurementgroupbox
            // 
            this.measurementgroupbox.Controls.Add(this.freqbtn);
            this.measurementgroupbox.Controls.Add(this.freqtxtbox);
            this.measurementgroupbox.Controls.Add(this.freqlbl);
            this.measurementgroupbox.Controls.Add(this.adconeshotbtn);
            this.measurementgroupbox.Controls.Add(this.voltslbl);
            this.measurementgroupbox.Controls.Add(this.voltstxtbox);
            this.measurementgroupbox.Location = new System.Drawing.Point(327, 264);
            this.measurementgroupbox.Name = "measurementgroupbox";
            this.measurementgroupbox.Size = new System.Drawing.Size(200, 73);
            this.measurementgroupbox.TabIndex = 12;
            this.measurementgroupbox.TabStop = false;
            this.measurementgroupbox.Text = "Measurement";
            // 
            // freqbtn
            // 
            this.freqbtn.Location = new System.Drawing.Point(148, 37);
            this.freqbtn.Name = "freqbtn";
            this.freqbtn.Size = new System.Drawing.Size(46, 23);
            this.freqbtn.TabIndex = 16;
            this.freqbtn.Text = "Once";
            this.freqbtn.UseVisualStyleBackColor = true;
            this.freqbtn.Click += new System.EventHandler(this.freqbtn_Click);
            // 
            // freqtxtbox
            // 
            this.freqtxtbox.Location = new System.Drawing.Point(42, 39);
            this.freqtxtbox.Name = "freqtxtbox";
            this.freqtxtbox.Size = new System.Drawing.Size(100, 20);
            this.freqtxtbox.TabIndex = 15;
            // 
            // freqlbl
            // 
            this.freqlbl.AutoSize = true;
            this.freqlbl.Location = new System.Drawing.Point(8, 42);
            this.freqlbl.Name = "freqlbl";
            this.freqlbl.Size = new System.Drawing.Size(28, 13);
            this.freqlbl.TabIndex = 14;
            this.freqlbl.Text = "Freq";
            // 
            // adconeshotbtn
            // 
            this.adconeshotbtn.Location = new System.Drawing.Point(148, 11);
            this.adconeshotbtn.Name = "adconeshotbtn";
            this.adconeshotbtn.Size = new System.Drawing.Size(46, 23);
            this.adconeshotbtn.TabIndex = 13;
            this.adconeshotbtn.Text = "Once";
            this.adconeshotbtn.UseVisualStyleBackColor = true;
            this.adconeshotbtn.Click += new System.EventHandler(this.adconeshotbtn_Click);
            // 
            // voltslbl
            // 
            this.voltslbl.AutoSize = true;
            this.voltslbl.Location = new System.Drawing.Point(6, 16);
            this.voltslbl.Name = "voltslbl";
            this.voltslbl.Size = new System.Drawing.Size(30, 13);
            this.voltslbl.TabIndex = 1;
            this.voltslbl.Text = "Volts";
            // 
            // voltstxtbox
            // 
            this.voltstxtbox.Location = new System.Drawing.Point(42, 13);
            this.voltstxtbox.Name = "voltstxtbox";
            this.voltstxtbox.Size = new System.Drawing.Size(100, 20);
            this.voltstxtbox.TabIndex = 0;
            // 
            // helpbtn
            // 
            this.helpbtn.Location = new System.Drawing.Point(668, 9);
            this.helpbtn.Name = "helpbtn";
            this.helpbtn.Size = new System.Drawing.Size(75, 23);
            this.helpbtn.TabIndex = 13;
            this.helpbtn.Text = "Help";
            this.helpbtn.UseVisualStyleBackColor = true;
            this.helpbtn.Click += new System.EventHandler(this.helpbtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.sendbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 384);
            this.Controls.Add(this.helpbtn);
            this.Controls.Add(this.measurementgroupbox);
            this.Controls.Add(this.baudcombobox);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.rawdatarichtxtbox);
            this.Controls.Add(this.macrosgroupdbox);
            this.Controls.Add(this.boardcontrolgroupbox);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.sendtxtbox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.serialconnect);
            this.Controls.Add(this.serialportscombobox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bus Pirate V4 GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.boardcontrolgroupbox.ResumeLayout(false);
            this.boardcontrolgroupbox.PerformLayout();
            this.macrosgroupdbox.ResumeLayout(false);
            this.measurementgroupbox.ResumeLayout(false);
            this.measurementgroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox serialportscombobox;
        private System.Windows.Forms.Button serialconnect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslbl;
        private System.Windows.Forms.TextBox sendtxtbox;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.ToolStripStatusLabel modelbl;
        private System.Windows.Forms.GroupBox boardcontrolgroupbox;
        private System.Windows.Forms.CheckBox pullupchckbox;
        private System.Windows.Forms.CheckBox powersupplychckbox;
        private System.Windows.Forms.GroupBox macrosgroupdbox;
        private System.Windows.Forms.Button macrobtn5;
        private System.Windows.Forms.Button macrobtn4;
        private System.Windows.Forms.Button macrobtn3;
        private System.Windows.Forms.Button macro2btn;
        private System.Windows.Forms.Button macrobtn1;
        private System.Windows.Forms.Button macromenubtn;
        private System.Windows.Forms.RichTextBox rawdatarichtxtbox;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.ComboBox baudcombobox;
        private System.Windows.Forms.Button versionbtn;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button selftestbtn;
        private System.Windows.Forms.Button menubtn;
        private System.Windows.Forms.CheckBox voltmeterchckbox;
        private System.Windows.Forms.GroupBox measurementgroupbox;
        private System.Windows.Forms.Label voltslbl;
        private System.Windows.Forms.TextBox voltstxtbox;
        private System.Windows.Forms.Label auxlbl;
        private System.Windows.Forms.ComboBox auxcombobox;
        private System.Windows.Forms.Button adconeshotbtn;
        private System.Windows.Forms.Button freqbtn;
        private System.Windows.Forms.TextBox freqtxtbox;
        private System.Windows.Forms.Label freqlbl;
        private System.Windows.Forms.Label formatlbl;
        private System.Windows.Forms.ComboBox formatcombobox;
        private System.Windows.Forms.CheckBox pwmchckbox;
        private System.Windows.Forms.Button helpbtn;
    }
}

