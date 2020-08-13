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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.list_ActConnections = new System.Windows.Forms.ListBox();
            this.label_connections = new System.Windows.Forms.Label();
            this.button_listen = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_configuration = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel_general.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_general
            // 
            this.panel_general.Controls.Add(this.list_ActConnections);
            this.panel_general.Controls.Add(this.panel3);
            this.panel_general.Controls.Add(this.panel2);
            this.panel_general.Controls.Add(this.panel1);
            this.panel_general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_general.Location = new System.Drawing.Point(0, 67);
            this.panel_general.Name = "panel_general";
            this.panel_general.Size = new System.Drawing.Size(804, 471);
            this.panel_general.TabIndex = 2;
            this.panel_general.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_general_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button_help);
            this.panel1.Controls.Add(this.button_configuration);
            this.panel1.Controls.Add(this.button_stop);
            this.panel1.Controls.Add(this.button_listen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(503, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(301, 471);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(0, 471);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label_connections);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 100);
            this.panel3.TabIndex = 2;
            // 
            // list_ActConnections
            // 
            this.list_ActConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_ActConnections.FormattingEnabled = true;
            this.list_ActConnections.Location = new System.Drawing.Point(0, 100);
            this.list_ActConnections.Name = "list_ActConnections";
            this.list_ActConnections.Size = new System.Drawing.Size(503, 371);
            this.list_ActConnections.TabIndex = 3;
            // 
            // label_connections
            // 
            this.label_connections.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_connections.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_connections.Location = new System.Drawing.Point(138, 36);
            this.label_connections.Name = "label_connections";
            this.label_connections.Size = new System.Drawing.Size(224, 30);
            this.label_connections.TabIndex = 0;
            this.label_connections.Text = "Active Connections";
            this.label_connections.Click += new System.EventHandler(this.label_connections_Click);
            // 
            // button_listen
            // 
            this.button_listen.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_listen.Location = new System.Drawing.Point(0, 0);
            this.button_listen.Name = "button_listen";
            this.button_listen.Size = new System.Drawing.Size(301, 69);
            this.button_listen.TabIndex = 0;
            this.button_listen.Text = "Start Listen";
            this.button_listen.UseVisualStyleBackColor = true;
            this.button_listen.Click += new System.EventHandler(this.button_listen_Click);
            // 
            // button_stop
            // 
            this.button_stop.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_stop.Location = new System.Drawing.Point(0, 69);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(301, 70);
            this.button_stop.TabIndex = 1;
            this.button_stop.Text = "Stop Listen";
            this.button_stop.UseVisualStyleBackColor = true;
            // 
            // button_configuration
            // 
            this.button_configuration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_configuration.Location = new System.Drawing.Point(0, 401);
            this.button_configuration.Name = "button_configuration";
            this.button_configuration.Size = new System.Drawing.Size(301, 70);
            this.button_configuration.TabIndex = 2;
            this.button_configuration.Text = "Configuration";
            this.button_configuration.UseVisualStyleBackColor = true;
            this.button_configuration.Click += new System.EventHandler(this.button_configuration_Click);
            // 
            // button_help
            // 
            this.button_help.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_help.Location = new System.Drawing.Point(0, 139);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(301, 54);
            this.button_help.TabIndex = 3;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = true;
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label_title.ForeColor = System.Drawing.Color.Crimson;
            this.label_title.Location = new System.Drawing.Point(278, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(247, 48);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Soul Rainbow";
            this.label_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_title.Controls.Add(this.label_title);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(804, 67);
            this.panel_title.TabIndex = 1;
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
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_title.ResumeLayout(false);
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
    }
}