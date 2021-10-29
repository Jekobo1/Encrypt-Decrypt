namespace EncryptDecrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_value = new System.Windows.Forms.Label();
            this.lbl_encrypt = new System.Windows.Forms.Label();
            this.lbl_decrypt = new System.Windows.Forms.Label();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.txt_encypt = new System.Windows.Forms.TextBox();
            this.txt_decrypt = new System.Windows.Forms.TextBox();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Location = new System.Drawing.Point(17, 12);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(34, 13);
            this.lbl_value.TabIndex = 0;
            this.lbl_value.Text = "Value";
            // 
            // lbl_encrypt
            // 
            this.lbl_encrypt.AutoSize = true;
            this.lbl_encrypt.Location = new System.Drawing.Point(17, 44);
            this.lbl_encrypt.Name = "lbl_encrypt";
            this.lbl_encrypt.Size = new System.Drawing.Size(43, 13);
            this.lbl_encrypt.TabIndex = 1;
            this.lbl_encrypt.Text = "Encrypt";
            // 
            // lbl_decrypt
            // 
            this.lbl_decrypt.AutoSize = true;
            this.lbl_decrypt.Location = new System.Drawing.Point(16, 70);
            this.lbl_decrypt.Name = "lbl_decrypt";
            this.lbl_decrypt.Size = new System.Drawing.Size(44, 13);
            this.lbl_decrypt.TabIndex = 1;
            this.lbl_decrypt.Text = "Decrypt";
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(66, 9);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(285, 20);
            this.txt_value.TabIndex = 2;
            // 
            // txt_encypt
            // 
            this.txt_encypt.Location = new System.Drawing.Point(66, 37);
            this.txt_encypt.Name = "txt_encypt";
            this.txt_encypt.Size = new System.Drawing.Size(285, 20);
            this.txt_encypt.TabIndex = 3;
            // 
            // txt_decrypt
            // 
            this.txt_decrypt.Location = new System.Drawing.Point(66, 63);
            this.txt_decrypt.Name = "txt_decrypt";
            this.txt_decrypt.Size = new System.Drawing.Size(285, 20);
            this.txt_decrypt.TabIndex = 4;
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(66, 89);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_encrypt.TabIndex = 5;
            this.btn_encrypt.Text = "Encrypt";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(276, 89);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_decrypt.TabIndex = 6;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 126);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.txt_decrypt);
            this.Controls.Add(this.txt_encypt);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.lbl_decrypt);
            this.Controls.Add(this.lbl_encrypt);
            this.Controls.Add(this.lbl_value);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(390, 165);
            this.MinimumSize = new System.Drawing.Size(390, 165);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E&D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.Label lbl_encrypt;
        private System.Windows.Forms.Label lbl_decrypt;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.TextBox txt_encypt;
        private System.Windows.Forms.TextBox txt_decrypt;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_decrypt;
    }
}

