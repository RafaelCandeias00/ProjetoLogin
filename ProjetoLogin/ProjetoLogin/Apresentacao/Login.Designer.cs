
namespace ProjetoLogin {
    partial class FormLogin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.entrarBTN = new System.Windows.Forms.Button();
            this.sairBTN = new System.Windows.Forms.Button();
            this.loginLBL = new System.Windows.Forms.Label();
            this.senhaLBL = new System.Windows.Forms.Label();
            this.loginTXB = new System.Windows.Forms.TextBox();
            this.senhaTXB = new System.Windows.Forms.TextBox();
            this.cadastreseBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // entrarBTN
            // 
            this.entrarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrarBTN.Location = new System.Drawing.Point(200, 111);
            this.entrarBTN.Name = "entrarBTN";
            this.entrarBTN.Size = new System.Drawing.Size(100, 30);
            this.entrarBTN.TabIndex = 1;
            this.entrarBTN.Text = "ENTRAR";
            this.entrarBTN.UseVisualStyleBackColor = false;
            this.entrarBTN.Click += new System.EventHandler(this.entrarBTN_Click);
            // 
            // sairBTN
            // 
            this.sairBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairBTN.Location = new System.Drawing.Point(306, 111);
            this.sairBTN.Name = "sairBTN";
            this.sairBTN.Size = new System.Drawing.Size(100, 30);
            this.sairBTN.TabIndex = 2;
            this.sairBTN.Text = "SAIR";
            this.sairBTN.UseVisualStyleBackColor = false;
            this.sairBTN.Click += new System.EventHandler(this.sairBTN_Click);
            // 
            // loginLBL
            // 
            this.loginLBL.AutoSize = true;
            this.loginLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLBL.Location = new System.Drawing.Point(195, 12);
            this.loginLBL.Name = "loginLBL";
            this.loginLBL.Size = new System.Drawing.Size(73, 25);
            this.loginLBL.TabIndex = 3;
            this.loginLBL.Text = "LOGIN";
            this.loginLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // senhaLBL
            // 
            this.senhaLBL.AutoSize = true;
            this.senhaLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaLBL.Location = new System.Drawing.Point(195, 53);
            this.senhaLBL.Name = "senhaLBL";
            this.senhaLBL.Size = new System.Drawing.Size(81, 25);
            this.senhaLBL.TabIndex = 4;
            this.senhaLBL.Text = "SENHA";
            this.senhaLBL.Click += new System.EventHandler(this.label2_Click);
            // 
            // loginTXB
            // 
            this.loginTXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTXB.Location = new System.Drawing.Point(274, 12);
            this.loginTXB.Name = "loginTXB";
            this.loginTXB.Size = new System.Drawing.Size(132, 23);
            this.loginTXB.TabIndex = 5;
            // 
            // senhaTXB
            // 
            this.senhaTXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTXB.Location = new System.Drawing.Point(287, 57);
            this.senhaTXB.Name = "senhaTXB";
            this.senhaTXB.PasswordChar = '*';
            this.senhaTXB.Size = new System.Drawing.Size(118, 23);
            this.senhaTXB.TabIndex = 6;
            this.senhaTXB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cadastreseBTN
            // 
            this.cadastreseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastreseBTN.Location = new System.Drawing.Point(256, 158);
            this.cadastreseBTN.Name = "cadastreseBTN";
            this.cadastreseBTN.Size = new System.Drawing.Size(100, 30);
            this.cadastreseBTN.TabIndex = 7;
            this.cadastreseBTN.Text = "CADASTRE-SE";
            this.cadastreseBTN.UseVisualStyleBackColor = false;
            this.cadastreseBTN.Click += new System.EventHandler(this.cadastreseBTN_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(416, 200);
            this.Controls.Add(this.cadastreseBTN);
            this.Controls.Add(this.senhaTXB);
            this.Controls.Add(this.loginTXB);
            this.Controls.Add(this.senhaLBL);
            this.Controls.Add(this.loginLBL);
            this.Controls.Add(this.sairBTN);
            this.Controls.Add(this.entrarBTN);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button entrarBTN;
        private System.Windows.Forms.Button sairBTN;
        private System.Windows.Forms.Label loginLBL;
        private System.Windows.Forms.Label senhaLBL;
        private System.Windows.Forms.TextBox loginTXB;
        private System.Windows.Forms.TextBox senhaTXB;
        private System.Windows.Forms.Button cadastreseBTN;
    }
}

