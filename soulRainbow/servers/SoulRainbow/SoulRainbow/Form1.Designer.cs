namespace SoulRainbow
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
            this.panel_general = new System.Windows.Forms.Panel();
            this.list_ActConnections = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_connections = new System.Windows.Forms.Label();
            this.button_CORS = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_help = new System.Windows.Forms.Button();
            this.button_configuration = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_listen = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_messaging = new System.Windows.Forms.Button();
            this.button_XmlRequ = new System.Windows.Forms.Button();
            this.button_WS = new System.Windows.Forms.Button();
            this.button_DNS = new System.Windows.Forms.Button();
            this.button_CORS2 = new System.Windows.Forms.Button();
            this.loadXML = new System.Windows.Forms.Button();
            this.panel_general.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_title.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_general
            // 
            this.panel_general.Controls.Add(this.list_ActConnections);
            this.panel_general.Controls.Add(this.panel3);
            this.panel_general.Controls.Add(this.button_CORS);
            this.panel_general.Controls.Add(this.panel2);
            this.panel_general.Controls.Add(this.panel1);
            this.panel_general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_general.Location = new System.Drawing.Point(0, 182);
            this.panel_general.Name = "panel_general";
            this.panel_general.Size = new System.Drawing.Size(804, 356);
            this.panel_general.TabIndex = 2;
            this.panel_general.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_general_Paint);
            // 
            // list_ActConnections
            // 
            this.list_ActConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_ActConnections.FormattingEnabled = true;
            this.list_ActConnections.Location = new System.Drawing.Point(0, 100);
            this.list_ActConnections.Name = "list_ActConnections";
            this.list_ActConnections.Size = new System.Drawing.Size(501, 256);
            this.list_ActConnections.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label_connections);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 100);
            this.panel3.TabIndex = 2;
            // 
            // label_connections
            // 
            this.label_connections.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_connections.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_connections.Location = new System.Drawing.Point(137, 36);
            this.label_connections.Name = "label_connections";
            this.label_connections.Size = new System.Drawing.Size(224, 30);
            this.label_connections.TabIndex = 0;
            this.label_connections.Text = "Active Connections";
            this.label_connections.Click += new System.EventHandler(this.label_connections_Click);
            // 
            // button_CORS
            // 
            this.button_CORS.Location = new System.Drawing.Point(182, -11);
            this.button_CORS.Name = "button_CORS";
            this.button_CORS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_CORS.Size = new System.Drawing.Size(105, 30);
            this.button_CORS.TabIndex = 1;
            this.button_CORS.Text = "CORS";
            this.button_CORS.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(0, 356);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button_help);
            this.panel1.Controls.Add(this.button_configuration);
            this.panel1.Controls.Add(this.button_stop);
            this.panel1.Controls.Add(this.button_listen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(501, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(303, 356);
            this.panel1.TabIndex = 0;
            // 
            // button_help
            // 
            this.button_help.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_help.Location = new System.Drawing.Point(0, 139);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(303, 54);
            this.button_help.TabIndex = 3;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = true;
            // 
            // button_configuration
            // 
            this.button_configuration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_configuration.Location = new System.Drawing.Point(0, 286);
            this.button_configuration.Name = "button_configuration";
            this.button_configuration.Size = new System.Drawing.Size(303, 70);
            this.button_configuration.TabIndex = 2;
            this.button_configuration.Text = "Configuration";
            this.button_configuration.UseVisualStyleBackColor = true;
            this.button_configuration.Click += new System.EventHandler(this.button_configuration_Click);
            // 
            // button_stop
            // 
            this.button_stop.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_stop.Location = new System.Drawing.Point(0, 69);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(303, 70);
            this.button_stop.TabIndex = 1;
            this.button_stop.Text = "Stop Listen";
            this.button_stop.UseVisualStyleBackColor = true;
            // 
            // button_listen
            // 
            this.button_listen.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_listen.Location = new System.Drawing.Point(0, 0);
            this.button_listen.Name = "button_listen";
            this.button_listen.Size = new System.Drawing.Size(303, 69);
            this.button_listen.TabIndex = 0;
            this.button_listen.Text = "Start Listen";
            this.button_listen.UseVisualStyleBackColor = true;
            this.button_listen.Click += new System.EventHandler(this.button_listen_Click);
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label_title.ForeColor = System.Drawing.Color.Crimson;
            this.label_title.Location = new System.Drawing.Point(301, 32);
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
            this.panel_title.Size = new System.Drawing.Size(804, 182);
            this.panel_title.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 118);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.panel4.Size = new System.Drawing.Size(804, 64);
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
            this.tableLayoutPanel1.Controls.Add(this.button_XmlRequ, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_WS, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_DNS, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_CORS2, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_messaging
            // 
            this.button_messaging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_messaging.Location = new System.Drawing.Point(483, 3);
            this.button_messaging.Name = "button_messaging";
            this.button_messaging.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_messaging.Size = new System.Drawing.Size(154, 58);
            this.button_messaging.TabIndex = 2;
            this.button_messaging.Text = "Messaging";
            this.button_messaging.UseVisualStyleBackColor = true;
            // 
            // button_XmlRequ
            // 
            this.button_XmlRequ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_XmlRequ.Location = new System.Drawing.Point(163, 3);
            this.button_XmlRequ.Name = "button_XmlRequ";
            this.button_XmlRequ.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_XmlRequ.Size = new System.Drawing.Size(154, 58);
            this.button_XmlRequ.TabIndex = 0;
            this.button_XmlRequ.Text = "XMLrequestPolling";
            this.button_XmlRequ.UseVisualStyleBackColor = true;
            this.button_XmlRequ.Click += new System.EventHandler(this.button_XmlRequ_Click);
            // 
            // button_WS
            // 
            this.button_WS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_WS.Location = new System.Drawing.Point(3, 3);
            this.button_WS.Name = "button_WS";
            this.button_WS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_WS.Size = new System.Drawing.Size(154, 58);
            this.button_WS.TabIndex = 4;
            this.button_WS.Text = "Web Socket";
            this.button_WS.UseVisualStyleBackColor = true;
            this.button_WS.Click += new System.EventHandler(this.button_WS_Click);
            // 
            // button_DNS
            // 
            this.button_DNS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DNS.Location = new System.Drawing.Point(323, 3);
            this.button_DNS.Name = "button_DNS";
            this.button_DNS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_DNS.Size = new System.Drawing.Size(154, 58);
            this.button_DNS.TabIndex = 3;
            this.button_DNS.Text = "DNS tunnel";
            this.button_DNS.UseVisualStyleBackColor = true;
            // 
            // button_CORS2
            // 
            this.button_CORS2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CORS2.Location = new System.Drawing.Point(643, 3);
            this.button_CORS2.Name = "button_CORS2";
            this.button_CORS2.Size = new System.Drawing.Size(156, 58);
            this.button_CORS2.TabIndex = 5;
            this.button_CORS2.Text = "CORS";
            this.button_CORS2.UseVisualStyleBackColor = true;
            // 
            // loadXML
            // 
            this.loadXML.Location = new System.Drawing.Point(0, 0);
            this.loadXML.Name = "loadXML";
            this.loadXML.Size = new System.Drawing.Size(75, 23);
            this.loadXML.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 538);
            this.Controls.Add(this.panel_general);
            this.Controls.Add(this.panel_title);
            this.MinimumSize = new System.Drawing.Size(620, 577);
            this.Name = "Form1";
            this.Text = "SoulRainbow";
            this.panel_general.ResumeLayout(false);
            this.panel_general.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_title.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_general;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox list_ActConnections;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_connections;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Button button_configuration;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_listen;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_WS;
        private System.Windows.Forms.Button button_DNS;
        private System.Windows.Forms.Button button_messaging;
        private System.Windows.Forms.Button button_CORS;
        private System.Windows.Forms.Button button_XmlRequ;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_CORS2;
        private System.Windows.Forms.Button loadXML;
    }
}