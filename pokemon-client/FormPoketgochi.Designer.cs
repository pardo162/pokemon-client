
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
            this.labelType = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.labelAttack = new System.Windows.Forms.Label();
            this.picturePokemon = new System.Windows.Forms.PictureBox();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.buttonFight = new System.Windows.Forms.Button();
            this.labelLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePokemon)).BeginInit();
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
            this.comboBoxPokemons.SelectedIndexChanged += new System.EventHandler(this.comboBoxPokemons_SelectedIndexChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelType.Location = new System.Drawing.Point(581, 118);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(40, 20);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "Type";
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelHP.Location = new System.Drawing.Point(581, 156);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(31, 20);
            this.labelHP.TabIndex = 9;
            this.labelHP.Text = "HP:";
            // 
            // labelAttack
            // 
            this.labelAttack.AutoSize = true;
            this.labelAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelAttack.Location = new System.Drawing.Point(580, 195);
            this.labelAttack.Name = "labelAttack";
            this.labelAttack.Size = new System.Drawing.Size(32, 20);
            this.labelAttack.TabIndex = 10;
            this.labelAttack.Text = "Att:";
            // 
            // picturePokemon
            // 
            this.picturePokemon.Location = new System.Drawing.Point(296, 208);
            this.picturePokemon.Name = "picturePokemon";
            this.picturePokemon.Size = new System.Drawing.Size(185, 177);
            this.picturePokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePokemon.TabIndex = 11;
            this.picturePokemon.TabStop = false;
            // 
            // buttonFeed
            // 
            this.buttonFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonFeed.Location = new System.Drawing.Point(86, 92);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(94, 28);
            this.buttonFeed.TabIndex = 12;
            this.buttonFeed.Text = "Feed";
            this.buttonFeed.UseVisualStyleBackColor = false;
            // 
            // buttonFight
            // 
            this.buttonFight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonFight.Location = new System.Drawing.Point(86, 149);
            this.buttonFight.Name = "buttonFight";
            this.buttonFight.Size = new System.Drawing.Size(94, 29);
            this.buttonFight.TabIndex = 13;
            this.buttonFight.Text = "Fight";
            this.buttonFight.UseVisualStyleBackColor = false;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelLevel.Location = new System.Drawing.Point(581, 232);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(36, 20);
            this.labelLevel.TabIndex = 14;
            this.labelLevel.Text = "Exp:";
            // 
            // FormPoketgochi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.buttonFight);
            this.Controls.Add(this.buttonFeed);
            this.Controls.Add(this.picturePokemon);
            this.Controls.Add(this.labelAttack);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.labelType);
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
            ((System.ComponentModel.ISupportInitialize)(this.picturePokemon)).EndInit();
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
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelAttack;
        private System.Windows.Forms.PictureBox picturePokemon;
        private System.Windows.Forms.Button buttonFeed;
        private System.Windows.Forms.Button buttonFight;
        private System.Windows.Forms.Label labelLevel;
    }
}

