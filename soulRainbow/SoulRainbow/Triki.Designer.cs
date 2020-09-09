namespace SoulRainbow
{
    partial class Triki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Triki));
            this.panel_body = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_right = new System.Windows.Forms.Panel();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.panel_headerLeft = new System.Windows.Forms.Panel();
            this.label_info = new System.Windows.Forms.Label();
            this.panel_bodyLeft = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel_body.SuspendLayout();
            this.panel_right.SuspendLayout();
            this.panel_headerLeft.SuspendLayout();
            this.panel_bodyLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.panel_bodyLeft);
            this.panel_body.Controls.Add(this.panel_headerLeft);
            this.panel_body.Controls.Add(this.panel_right);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_body.Location = new System.Drawing.Point(0, 77);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(560, 324);
            this.panel_body.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_title.Location = new System.Drawing.Point(133, 27);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(288, 25);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Triki module for cookie hijacking";
            // 
            // panel_right
            // 
            this.panel_right.Controls.Add(this.button_stop);
            this.panel_right.Controls.Add(this.button_start);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_right.Location = new System.Drawing.Point(355, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(205, 324);
            this.panel_right.TabIndex = 0;
            // 
            // button_start
            // 
            this.button_start.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_start.Location = new System.Drawing.Point(0, 0);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(205, 60);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_stop.Location = new System.Drawing.Point(0, 60);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(205, 60);
            this.button_stop.TabIndex = 1;
            this.button_stop.Text = "stop";
            this.button_stop.UseVisualStyleBackColor = true;
            // 
            // panel_headerLeft
            // 
            this.panel_headerLeft.Controls.Add(this.label_info);
            this.panel_headerLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_headerLeft.Location = new System.Drawing.Point(0, 0);
            this.panel_headerLeft.Name = "panel_headerLeft";
            this.panel_headerLeft.Size = new System.Drawing.Size(355, 29);
            this.panel_headerLeft.TabIndex = 1;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_info.Location = new System.Drawing.Point(3, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(215, 20);
            this.label_info.TabIndex = 0;
            this.label_info.Text = "click start to listen for cookies";
            // 
            // panel_bodyLeft
            // 
            this.panel_bodyLeft.Controls.Add(this.listBox1);
            this.panel_bodyLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bodyLeft.Location = new System.Drawing.Point(0, 35);
            this.panel_bodyLeft.Name = "panel_bodyLeft";
            this.panel_bodyLeft.Size = new System.Drawing.Size(355, 289);
            this.panel_bodyLeft.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(355, 277);
            this.listBox1.TabIndex = 0;
            // 
            // Triki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 401);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel_body);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(576, 440);
            this.MinimumSize = new System.Drawing.Size(576, 440);
            this.Name = "Triki";
            this.Text = "Triki";
            this.panel_body.ResumeLayout(false);
            this.panel_right.ResumeLayout(false);
            this.panel_headerLeft.ResumeLayout(false);
            this.panel_headerLeft.PerformLayout();
            this.panel_bodyLeft.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel panel_bodyLeft;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel_headerLeft;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_title;
    }
}