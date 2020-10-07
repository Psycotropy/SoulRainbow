namespace SoulRainbow.views
{
    partial class dnsView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_help = new System.Windows.Forms.Button();
            this.button_configuration = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_listen = new System.Windows.Forms.Button();
            this.label_connections = new System.Windows.Forms.Label();
            this.list_ActConnections = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            this.panel1.Controls.Add(this.button_help);
            this.panel1.Controls.Add(this.button_configuration);
            this.panel1.Controls.Add(this.button_stop);
            this.panel1.Controls.Add(this.button_listen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(327, 100);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(303, 318);
            this.panel1.TabIndex = 4;
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
            this.button_configuration.Location = new System.Drawing.Point(0, 273);
            this.button_configuration.Name = "button_configuration";
            this.button_configuration.Size = new System.Drawing.Size(303, 45);
            this.button_configuration.TabIndex = 2;
            this.button_configuration.Text = "Configuration";
            this.button_configuration.UseVisualStyleBackColor = false;
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
            // label_connections
            // 
            this.label_connections.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_connections.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_connections.Location = new System.Drawing.Point(180, 34);
            this.label_connections.Name = "label_connections";
            this.label_connections.Size = new System.Drawing.Size(284, 37);
            this.label_connections.TabIndex = 0;
            this.label_connections.Text = "Active Connections DNS";
            // 
            // list_ActConnections
            // 
            this.list_ActConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_ActConnections.FormattingEnabled = true;
            this.list_ActConnections.Location = new System.Drawing.Point(0, 100);
            this.list_ActConnections.Name = "list_ActConnections";
            this.list_ActConnections.Size = new System.Drawing.Size(630, 318);
            this.list_ActConnections.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            this.panel3.Controls.Add(this.label_connections);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 100);
            this.panel3.TabIndex = 5;
            // 
            // dnsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.list_ActConnections);
            this.Controls.Add(this.panel3);
            this.Name = "dnsView";
            this.Size = new System.Drawing.Size(630, 418);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Button button_configuration;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_listen;
        private System.Windows.Forms.Label label_connections;
        private System.Windows.Forms.ListBox list_ActConnections;
        private System.Windows.Forms.Panel panel3;
    }
}
