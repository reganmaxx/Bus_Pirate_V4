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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialportscombobox = new System.Windows.Forms.ComboBox();
            this.serialconnect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.modelbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendtxtbox = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.boardcontrolgroupbox = new System.Windows.Forms.GroupBox();
            this.powersupplychckbox = new System.Windows.Forms.CheckBox();
            this.pullupchckbox = new System.Windows.Forms.CheckBox();
            this.macrosgroupdbox = new System.Windows.Forms.GroupBox();
            this.macromenubtn = new System.Windows.Forms.Button();
            this.macrobtn1 = new System.Windows.Forms.Button();
            this.macro2btn = new System.Windows.Forms.Button();
            this.macrobtn3 = new System.Windows.Forms.Button();
            this.macrobtn4 = new System.Windows.Forms.Button();
            this.macrobtn5 = new System.Windows.Forms.Button();
            this.rawdatarichtxtbox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.boardcontrolgroupbox.SuspendLayout();
            this.macrosgroupdbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            // 
            // serialportscombobox
            // 
            this.serialportscombobox.FormattingEnabled = true;
            this.serialportscombobox.Location = new System.Drawing.Point(12, 12);
            this.serialportscombobox.Name = "serialportscombobox";
            this.serialportscombobox.Size = new System.Drawing.Size(121, 21);
            this.serialportscombobox.TabIndex = 1;
            // 
            // serialconnect
            // 
            this.serialconnect.Location = new System.Drawing.Point(139, 10);
            this.serialconnect.Name = "serialconnect";
            this.serialconnect.Size = new System.Drawing.Size(75, 23);
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
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(39, 17);
            this.statuslbl.Text = "Status";
            // 
            // modelbl
            // 
            this.modelbl.Name = "modelbl";
            this.modelbl.Size = new System.Drawing.Size(38, 17);
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
            this.boardcontrolgroupbox.Controls.Add(this.pullupchckbox);
            this.boardcontrolgroupbox.Controls.Add(this.powersupplychckbox);
            this.boardcontrolgroupbox.Location = new System.Drawing.Point(573, 88);
            this.boardcontrolgroupbox.Name = "boardcontrolgroupbox";
            this.boardcontrolgroupbox.Size = new System.Drawing.Size(170, 161);
            this.boardcontrolgroupbox.TabIndex = 7;
            this.boardcontrolgroupbox.TabStop = false;
            this.boardcontrolgroupbox.Text = "Board Control";
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
            // pullupchckbox
            // 
            this.pullupchckbox.AutoSize = true;
            this.pullupchckbox.Location = new System.Drawing.Point(6, 43);
            this.pullupchckbox.Name = "pullupchckbox";
            this.pullupchckbox.Size = new System.Drawing.Size(82, 17);
            this.pullupchckbox.TabIndex = 1;
            this.pullupchckbox.Text = "Pull Up Res";
            this.pullupchckbox.UseVisualStyleBackColor = true;
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
            // macrobtn1
            // 
            this.macrobtn1.Location = new System.Drawing.Point(6, 48);
            this.macrobtn1.Name = "macrobtn1";
            this.macrobtn1.Size = new System.Drawing.Size(27, 23);
            this.macrobtn1.TabIndex = 1;
            this.macrobtn1.Text = "1";
            this.macrobtn1.UseVisualStyleBackColor = true;
            // 
            // macro2btn
            // 
            this.macro2btn.Location = new System.Drawing.Point(39, 48);
            this.macro2btn.Name = "macro2btn";
            this.macro2btn.Size = new System.Drawing.Size(27, 23);
            this.macro2btn.TabIndex = 2;
            this.macro2btn.Text = "2";
            this.macro2btn.UseVisualStyleBackColor = true;
            // 
            // macrobtn3
            // 
            this.macrobtn3.Location = new System.Drawing.Point(72, 48);
            this.macrobtn3.Name = "macrobtn3";
            this.macrobtn3.Size = new System.Drawing.Size(27, 23);
            this.macrobtn3.TabIndex = 3;
            this.macrobtn3.Text = "3";
            this.macrobtn3.UseVisualStyleBackColor = true;
            // 
            // macrobtn4
            // 
            this.macrobtn4.Location = new System.Drawing.Point(105, 48);
            this.macrobtn4.Name = "macrobtn4";
            this.macrobtn4.Size = new System.Drawing.Size(27, 23);
            this.macrobtn4.TabIndex = 4;
            this.macrobtn4.Text = "4";
            this.macrobtn4.UseVisualStyleBackColor = true;
            // 
            // macrobtn5
            // 
            this.macrobtn5.Location = new System.Drawing.Point(138, 48);
            this.macrobtn5.Name = "macrobtn5";
            this.macrobtn5.Size = new System.Drawing.Size(27, 23);
            this.macrobtn5.TabIndex = 5;
            this.macrobtn5.Text = "5";
            this.macrobtn5.UseVisualStyleBackColor = true;
            // 
            // rawdatarichtxtbox
            // 
            this.rawdatarichtxtbox.Location = new System.Drawing.Point(12, 77);
            this.rawdatarichtxtbox.Name = "rawdatarichtxtbox";
            this.rawdatarichtxtbox.Size = new System.Drawing.Size(293, 282);
            this.rawdatarichtxtbox.TabIndex = 9;
            this.rawdatarichtxtbox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 384);
            this.Controls.Add(this.rawdatarichtxtbox);
            this.Controls.Add(this.macrosgroupdbox);
            this.Controls.Add(this.boardcontrolgroupbox);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.sendtxtbox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.serialconnect);
            this.Controls.Add(this.serialportscombobox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.boardcontrolgroupbox.ResumeLayout(false);
            this.boardcontrolgroupbox.PerformLayout();
            this.macrosgroupdbox.ResumeLayout(false);
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
    }
}

