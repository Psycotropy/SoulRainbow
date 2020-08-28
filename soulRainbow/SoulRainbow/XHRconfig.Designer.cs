namespace SoulRainbow
{
    partial class XHRconfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XHRconfig));
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label_port = new System.Windows.Forms.Label();
            this.button_saveXHR = new System.Windows.Forms.Button();
            this.textBox_serverPath = new System.Windows.Forms.TextBox();
            this.label_serverPath = new System.Windows.Forms.Label();
            this.button_browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_title.Location = new System.Drawing.Point(147, 38);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(189, 26);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "XHR configuration";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(198, 103);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(216, 20);
            this.textBox_Port.TabIndex = 3;
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_port.Location = new System.Drawing.Point(48, 98);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(134, 25);
            this.label_port.TabIndex = 4;
            this.label_port.Text = "Listening port:";
            // 
            // button_saveXHR
            // 
            this.button_saveXHR.Location = new System.Drawing.Point(198, 288);
            this.button_saveXHR.Name = "button_saveXHR";
            this.button_saveXHR.Size = new System.Drawing.Size(138, 35);
            this.button_saveXHR.TabIndex = 5;
            this.button_saveXHR.Text = "Save changes";
            this.button_saveXHR.UseVisualStyleBackColor = true;
            this.button_saveXHR.Click += new System.EventHandler(this.button_saveXHR_Click);
            // 
            // textBox_serverPath
            // 
            this.textBox_serverPath.Location = new System.Drawing.Point(198, 151);
            this.textBox_serverPath.Name = "textBox_serverPath";
            this.textBox_serverPath.Size = new System.Drawing.Size(216, 20);
            this.textBox_serverPath.TabIndex = 6;
            // 
            // label_serverPath
            // 
            this.label_serverPath.AutoSize = true;
            this.label_serverPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_serverPath.Location = new System.Drawing.Point(3, 145);
            this.label_serverPath.Name = "label_serverPath";
            this.label_serverPath.Size = new System.Drawing.Size(179, 25);
            this.label_serverPath.TabIndex = 7;
            this.label_serverPath.Text = "Server folder Path: ";
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(420, 151);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(75, 23);
            this.button_browse.TabIndex = 8;
            this.button_browse.Text = "browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // XHRconfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 353);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.label_serverPath);
            this.Controls.Add(this.textBox_serverPath);
            this.Controls.Add(this.button_saveXHR);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.label_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(541, 392);
            this.MinimumSize = new System.Drawing.Size(541, 392);
            this.Name = "XHRconfig";
            this.Text = "XHR configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.Button button_saveXHR;
        private System.Windows.Forms.TextBox textBox_serverPath;
        private System.Windows.Forms.Label label_serverPath;
        private System.Windows.Forms.Button button_browse;
    }
}