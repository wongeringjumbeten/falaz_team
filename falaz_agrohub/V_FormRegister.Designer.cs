namespace falaz_agrohub
{
    partial class V_FormRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterUsernameTextbox = new System.Windows.Forms.TextBox();
            this.RegisterPasswordTextbox = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTER";
            // 
            // RegisterUsernameTextbox
            // 
            this.RegisterUsernameTextbox.Location = new System.Drawing.Point(130, 150);
            this.RegisterUsernameTextbox.Name = "RegisterUsernameTextbox";
            this.RegisterUsernameTextbox.Size = new System.Drawing.Size(314, 20);
            this.RegisterUsernameTextbox.TabIndex = 1;
            // 
            // RegisterPasswordTextbox
            // 
            this.RegisterPasswordTextbox.Location = new System.Drawing.Point(130, 227);
            this.RegisterPasswordTextbox.Name = "RegisterPasswordTextbox";
            this.RegisterPasswordTextbox.Size = new System.Drawing.Size(314, 20);
            this.RegisterPasswordTextbox.TabIndex = 2;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(228, 313);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(122, 49);
            this.RegisterBtn.TabIndex = 3;
            this.RegisterBtn.Text = "REGISTER";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // V_FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.RegisterPasswordTextbox);
            this.Controls.Add(this.RegisterUsernameTextbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "V_FormRegister";
            this.Text = "V_FormRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegisterUsernameTextbox;
        private System.Windows.Forms.TextBox RegisterPasswordTextbox;
        private System.Windows.Forms.Button RegisterBtn;
    }
}