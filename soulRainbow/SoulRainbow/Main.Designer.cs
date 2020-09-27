namespace SoulRainbow
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label_title = new System.Windows.Forms.Label();
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_messaging = new System.Windows.Forms.Button();
            this.button_XmlRequest = new System.Windows.Forms.Button();
            this.button_WS = new System.Windows.Forms.Button();
            this.button_DNS = new System.Windows.Forms.Button();
            this.button_CORS2 = new System.Windows.Forms.Button();
            this.loadXML = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_title.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label_title.ForeColor = System.Drawing.Color.Crimson;
            this.label_title.Location = new System.Drawing.Point(258, 32);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(247, 48);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Soul Rainbow";
            this.label_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_title.Controls.Add(this.panel4);
            this.panel_title.Controls.Add(this.label_title);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(718, 182);
            this.panel_title.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 118);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.panel4.Size = new System.Drawing.Size(718, 64);
            this.panel4.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button_messaging, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_XmlRequest, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_WS, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_DNS, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_CORS2, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_messaging
            // 
            this.button_messaging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_messaging.Location = new System.Drawing.Point(432, 3);
            this.button_messaging.Name = "button_messaging";
            this.button_messaging.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_messaging.Size = new System.Drawing.Size(137, 58);
            this.button_messaging.TabIndex = 2;
            this.button_messaging.Text = "Messaging";
            this.button_messaging.UseVisualStyleBackColor = true;
            this.button_messaging.Click += new System.EventHandler(this.button_messaging_Click);
            // 
            // button_XmlRequest
            // 
            this.button_XmlRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_XmlRequest.Location = new System.Drawing.Point(146, 3);
            this.button_XmlRequest.Name = "button_XmlRequest";
            this.button_XmlRequest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_XmlRequest.Size = new System.Drawing.Size(137, 58);
            this.button_XmlRequest.TabIndex = 0;
            this.button_XmlRequest.Text = "XMLrequestPolling";
            this.button_XmlRequest.UseVisualStyleBackColor = true;
            this.button_XmlRequest.Click += new System.EventHandler(this.button_XmlRequest_Click);
            // 
            // button_WS
            // 
            this.button_WS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_WS.Location = new System.Drawing.Point(3, 3);
            this.button_WS.Name = "button_WS";
            this.button_WS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_WS.Size = new System.Drawing.Size(137, 58);
            this.button_WS.TabIndex = 4;
            this.button_WS.Text = "Web Socket";
            this.button_WS.UseVisualStyleBackColor = true;
            this.button_WS.Click += new System.EventHandler(this.button_WS_Click);
            // 
            // button_DNS
            // 
            this.button_DNS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DNS.Location = new System.Drawing.Point(289, 3);
            this.button_DNS.Name = "button_DNS";
            this.button_DNS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_DNS.Size = new System.Drawing.Size(137, 58);
            this.button_DNS.TabIndex = 3;
            this.button_DNS.Text = "DNS tunnel";
            this.button_DNS.UseVisualStyleBackColor = true;
            this.button_DNS.Click += new System.EventHandler(this.button_DNS_Click);
            // 
            // button_CORS2
            // 
            this.button_CORS2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CORS2.Location = new System.Drawing.Point(575, 3);
            this.button_CORS2.Name = "button_CORS2";
            this.button_CORS2.Size = new System.Drawing.Size(138, 58);
            this.button_CORS2.TabIndex = 5;
            this.button_CORS2.Text = "CORS";
            this.button_CORS2.UseVisualStyleBackColor = true;
            this.button_CORS2.Click += new System.EventHandler(this.button_CORS2_Click);
            // 
            // loadXML
            // 
            this.loadXML.Dock = System.Windows.Forms.DockStyle.Top;
            this.loadXML.Location = new System.Drawing.Point(0, 0);
            this.loadXML.Name = "loadXML";
            this.loadXML.Size = new System.Drawing.Size(75, 54);
            this.loadXML.TabIndex = 0;
            this.loadXML.Text = "Load XML file";
            this.loadXML.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 356);
            this.panel1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(620, 577);
            this.Name = "Main";
            this.Text = "SoulRainbow";
            this.panel_title.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_WS;
        private System.Windows.Forms.Button button_DNS;
        private System.Windows.Forms.Button button_messaging;
        private System.Windows.Forms.Button button_XmlRequest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_CORS2;
        private System.Windows.Forms.Button loadXML;
        private System.Windows.Forms.Panel panel1;
    }
}