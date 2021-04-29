
namespace ProjetoLogin.Apresentacao {
    partial class CadastreSe {
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
            this.cadastrarBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginTXB = new System.Windows.Forms.TextBox();
            this.senhaTXB = new System.Windows.Forms.TextBox();
            this.confirmarSenhaTXB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cadastrarBTN
            // 
            this.cadastrarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarBTN.Location = new System.Drawing.Point(117, 155);
            this.cadastrarBTN.Name = "cadastrarBTN";
            this.cadastrarBTN.Size = new System.Drawing.Size(100, 30);
            this.cadastrarBTN.TabIndex = 0;
            this.cadastrarBTN.Text = "CADASTRAR";
            this.cadastrarBTN.UseVisualStyleBackColor = false;
            this.cadastrarBTN.Click += new System.EventHandler(this.cadastrarBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMAIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "SENHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "CONFIRMAR SENHA";
            // 
            // loginTXB
            // 
            this.loginTXB.Location = new System.Drawing.Point(99, 15);
            this.loginTXB.Name = "loginTXB";
            this.loginTXB.Size = new System.Drawing.Size(224, 20);
            this.loginTXB.TabIndex = 4;
            // 
            // senhaTXB
            // 
            this.senhaTXB.Location = new System.Drawing.Point(99, 48);
            this.senhaTXB.Name = "senhaTXB";
            this.senhaTXB.PasswordChar = '*';
            this.senhaTXB.Size = new System.Drawing.Size(224, 20);
            this.senhaTXB.TabIndex = 5;
            // 
            // confirmarSenhaTXB
            // 
            this.confirmarSenhaTXB.Location = new System.Drawing.Point(223, 90);
            this.confirmarSenhaTXB.Name = "confirmarSenhaTXB";
            this.confirmarSenhaTXB.PasswordChar = '*';
            this.confirmarSenhaTXB.Size = new System.Drawing.Size(100, 20);
            this.confirmarSenhaTXB.TabIndex = 6;
            // 
            // CadastreSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 222);
            this.Controls.Add(this.confirmarSenhaTXB);
            this.Controls.Add(this.senhaTXB);
            this.Controls.Add(this.loginTXB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cadastrarBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastreSe";
            this.Text = "CadastreSe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastrarBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginTXB;
        private System.Windows.Forms.TextBox senhaTXB;
        private System.Windows.Forms.TextBox confirmarSenhaTXB;
    }
}