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
            this.sendtxtbox = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.rawtxtbox = new System.Windows.Forms.TextBox();
            this.modelbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 292);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(558, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslbl
            // 
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(39, 17);
            this.statuslbl.Text = "Status";
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
            // rawtxtbox
            // 
            this.rawtxtbox.Location = new System.Drawing.Point(12, 88);
            this.rawtxtbox.Multiline = true;
            this.rawtxtbox.Name = "rawtxtbox";
            this.rawtxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rawtxtbox.Size = new System.Drawing.Size(293, 201);
            this.rawtxtbox.TabIndex = 6;
            // 
            // modelbl
            // 
            this.modelbl.Name = "modelbl";
            this.modelbl.Size = new System.Drawing.Size(38, 17);
            this.modelbl.Text = "Mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 314);
            this.Controls.Add(this.rawtxtbox);
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
        private System.Windows.Forms.TextBox rawtxtbox;
        private System.Windows.Forms.ToolStripStatusLabel modelbl;
    }
}

