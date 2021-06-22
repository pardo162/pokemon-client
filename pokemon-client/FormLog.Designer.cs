
namespace pokemon_client
{
    partial class FormPoketgochi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPoketgochi));
            this.pictureMain = new System.Windows.Forms.PictureBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.comboBoxPokemons = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureMain
            // 
            this.pictureMain.Image = ((System.Drawing.Image)(resources.GetObject("pictureMain.Image")));
            this.pictureMain.Location = new System.Drawing.Point(5, 12);
            this.pictureMain.Name = "pictureMain";
            this.pictureMain.Size = new System.Drawing.Size(783, 414);
            this.pictureMain.TabIndex = 1;
            this.pictureMain.TabStop = false;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonLogIn.Location = new System.Drawing.Point(141, 208);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(125, 40);
            this.buttonLogIn.TabIndex = 2;
            this.buttonLogIn.Text = "LogIn";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textName.Location = new System.Drawing.Point(141, 93);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(125, 27);
            this.textName.TabIndex = 3;
            this.textName.Text = "test";
            this.textName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textPassword.Location = new System.Drawing.Point(141, 149);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(125, 27);
            this.textPassword.TabIndex = 4;
            this.textPassword.Text = "1234";
            this.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelName.Location = new System.Drawing.Point(50, 96);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 20);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "  Name:  ";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelPassword.Location = new System.Drawing.Point(50, 152);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 20);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password:";
            this.labelPassword.UseMnemonic = false;
            // 
            // comboBoxPokemons
            // 
            this.comboBoxPokemons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxPokemons.FormattingEnabled = true;
            this.comboBoxPokemons.Location = new System.Drawing.Point(581, 60);
            this.comboBoxPokemons.Name = "comboBoxPokemons";
            this.comboBoxPokemons.Size = new System.Drawing.Size(151, 28);
            this.comboBoxPokemons.TabIndex = 7;
            // 
            // FormPoketgochi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxPokemons);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.pictureMain);
            this.Name = "FormPoketgochi";
            this.Text = "Poketgochi";
            this.Load += new System.EventHandler(this.FormPoketgochi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureMain;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.ComboBox comboBoxPokemons;
    }
}

