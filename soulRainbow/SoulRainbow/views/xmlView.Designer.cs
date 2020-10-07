namespace SoulRainbow.views
{
    partial class xmlView
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

        #region Component Designer generated code

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
            this.button_triki = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.button_configuration = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_listen = new System.Windows.Forms.Button();
            this.panel_general.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panel_general.Location = new System.Drawing.Point(0, 0);
            this.panel_general.Name = "panel_general";
            this.panel_general.Size = new System.Drawing.Size(697, 407);
            this.panel_general.TabIndex = 3;
            // 
            // list_ActConnections
            // 
            this.list_ActConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_ActConnections.FormattingEnabled = true;
            this.list_ActConnections.Location = new System.Drawing.Point(0, 100);
            this.list_ActConnections.Name = "list_ActConnections";
            this.list_ActConnections.Size = new System.Drawing.Size(394, 307);
            this.list_ActConnections.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label_connections);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 100);
            this.panel3.TabIndex = 2;
            // 
            // label_connections
            // 
            this.label_connections.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_connections.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_connections.Location = new System.Drawing.Point(84, 36);
            this.label_connections.Name = "label_connections";
            this.label_connections.Size = new System.Drawing.Size(288, 30);
            this.label_connections.TabIndex = 0;
            this.label_connections.Text = "Active Connections XHR";
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
            this.panel2.Size = new System.Drawing.Size(0, 407);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button_triki);
            this.panel1.Controls.Add(this.button_help);
            this.panel1.Controls.Add(this.button_configuration);
            this.panel1.Controls.Add(this.button_stop);
            this.panel1.Controls.Add(this.button_listen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(394, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(303, 407);
            this.panel1.TabIndex = 0;
            // 
            // button_triki
            // 
            this.button_triki.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_triki.Location = new System.Drawing.Point(0, 193);
            this.button_triki.Name = "button_triki";
            this.button_triki.Size = new System.Drawing.Size(303, 47);
            this.button_triki.TabIndex = 4;
            this.button_triki.Text = "Triki";
            this.button_triki.UseVisualStyleBackColor = true;
            this.button_triki.Click += new System.EventHandler(this.button_triki_Click);
            // 
            // button_help
            // 
            this.button_help.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_help.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_help.Location = new System.Drawing.Point(0, 139);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(303, 54);
            this.button_help.TabIndex = 3;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = false;
            // 
            // button_configuration
            // 
            this.button_configuration.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_configuration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_configuration.Location = new System.Drawing.Point(0, 362);
            this.button_configuration.Name = "button_configuration";
            this.button_configuration.Size = new System.Drawing.Size(303, 45);
            this.button_configuration.TabIndex = 2;
            this.button_configuration.Text = "Configuration";
            this.button_configuration.UseVisualStyleBackColor = false;
            this.button_configuration.Click += new System.EventHandler(this.button_configuration_Click);
            // 
            // button_stop
            // 
            this.button_stop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_stop.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_stop.Location = new System.Drawing.Point(0, 69);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(303, 70);
            this.button_stop.TabIndex = 1;
            this.button_stop.Text = "Stop Listen";
            this.button_stop.UseVisualStyleBackColor = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_listen
            // 
            this.button_listen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_listen.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_listen.Location = new System.Drawing.Point(0, 0);
            this.button_listen.Name = "button_listen";
            this.button_listen.Size = new System.Drawing.Size(303, 69);
            this.button_listen.TabIndex = 0;
            this.button_listen.Text = "Start Listen";
            this.button_listen.UseVisualStyleBackColor = false;
            this.button_listen.Click += new System.EventHandler(this.button_listen_Click);
            // 
            // xmlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_general);
            this.Name = "xmlView";
            this.Size = new System.Drawing.Size(697, 407);
            this.panel_general.ResumeLayout(false);
            this.panel_general.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_general;
        private System.Windows.Forms.ListBox list_ActConnections;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_connections;
        private System.Windows.Forms.Button button_CORS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_triki;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Button button_configuration;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_listen;
    }
}
