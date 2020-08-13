namespace SoulRainbow
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_save = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 48);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_port);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 66);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(50, 5, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // textBox_port
            // 
            this.textBox_port.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_port.Location = new System.Drawing.Point(91, 29);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(174, 20);
            this.textBox_port.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_help);
            this.panel3.Controls.Add(this.button_save);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 106);
            this.panel3.TabIndex = 3;
            // 
            // button_save
            // 
            this.button_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_save.Location = new System.Drawing.Point(0, 83);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(289, 23);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Save changes";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_help
            // 
            this.button_help.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_help.Location = new System.Drawing.Point(0, 60);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(289, 23);
            this.button_help.TabIndex = 1;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 272);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(305, 311);
            this.Name = "Form2";
            this.Text = "Configuration";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Button button_save;
    }
}