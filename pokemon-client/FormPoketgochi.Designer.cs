
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
            this.pictureFighter1 = new System.Windows.Forms.PictureBox();
            this.pictureFighter2 = new System.Windows.Forms.PictureBox();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.labelHealth2 = new System.Windows.Forms.Label();
            this.labelHealth1 = new System.Windows.Forms.Label();
            this.pictureHit2 = new System.Windows.Forms.PictureBox();
            this.pictureHit1 = new System.Windows.Forms.PictureBox();
            this.pictureHeart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFighter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFighter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHeart)).BeginInit();
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
            this.buttonFeed.Click += new System.EventHandler(this.buttonFeed_Click);
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
            this.buttonFight.Click += new System.EventHandler(this.buttonFight_Click);
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
            // pictureFighter1
            // 
            this.pictureFighter1.Location = new System.Drawing.Point(512, 182);
            this.pictureFighter1.Name = "pictureFighter1";
            this.pictureFighter1.Size = new System.Drawing.Size(209, 233);
            this.pictureFighter1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFighter1.TabIndex = 15;
            this.pictureFighter1.TabStop = false;
            // 
            // pictureFighter2
            // 
            this.pictureFighter2.Location = new System.Drawing.Point(81, 182);
            this.pictureFighter2.Name = "pictureFighter2";
            this.pictureFighter2.Size = new System.Drawing.Size(209, 233);
            this.pictureFighter2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFighter2.TabIndex = 16;
            this.pictureFighter2.TabStop = false;
            // 
            // buttonAttack
            // 
            this.buttonAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonAttack.Location = new System.Drawing.Point(361, 279);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(94, 47);
            this.buttonAttack.TabIndex = 17;
            this.buttonAttack.Text = "Attack";
            this.buttonAttack.UseVisualStyleBackColor = false;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // labelHealth2
            // 
            this.labelHealth2.AutoSize = true;
            this.labelHealth2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelHealth2.Location = new System.Drawing.Point(130, 118);
            this.labelHealth2.Name = "labelHealth2";
            this.labelHealth2.Size = new System.Drawing.Size(28, 20);
            this.labelHealth2.TabIndex = 18;
            this.labelHealth2.Text = "HP";
            // 
            // labelHealth1
            // 
            this.labelHealth1.AutoSize = true;
            this.labelHealth1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelHealth1.Location = new System.Drawing.Point(627, 118);
            this.labelHealth1.Name = "labelHealth1";
            this.labelHealth1.Size = new System.Drawing.Size(36, 20);
            this.labelHealth1.TabIndex = 19;
            this.labelHealth1.Text = "HP1";
            // 
            // pictureHit2
            // 
            this.pictureHit2.Image = global::pokemon_client.Properties.Resources.hit1;
            this.pictureHit2.Location = new System.Drawing.Point(141, 208);
            this.pictureHit2.Name = "pictureHit2";
            this.pictureHit2.Size = new System.Drawing.Size(71, 75);
            this.pictureHit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHit2.TabIndex = 20;
            this.pictureHit2.TabStop = false;
            // 
            // pictureHit1
            // 
            this.pictureHit1.Image = global::pokemon_client.Properties.Resources.hit;
            this.pictureHit1.Location = new System.Drawing.Point(592, 208);
            this.pictureHit1.Name = "pictureHit1";
            this.pictureHit1.Size = new System.Drawing.Size(71, 75);
            this.pictureHit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHit1.TabIndex = 21;
            this.pictureHit1.TabStop = false;
            // 
            // pictureHeart
            // 
            this.pictureHeart.Image = global::pokemon_client.Properties.Resources.heart;
            this.pictureHeart.Location = new System.Drawing.Point(338, 232);
            this.pictureHeart.Name = "pictureHeart";
            this.pictureHeart.Size = new System.Drawing.Size(66, 64);
            this.pictureHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHeart.TabIndex = 22;
            this.pictureHeart.TabStop = false;
            // 
            // FormPoketgochi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureHeart);
            this.Controls.Add(this.pictureHit1);
            this.Controls.Add(this.pictureHit2);
            this.Controls.Add(this.labelHealth1);
            this.Controls.Add(this.labelHealth2);
            this.Controls.Add(this.buttonAttack);
            this.Controls.Add(this.pictureFighter2);
            this.Controls.Add(this.pictureFighter1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureFighter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFighter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHeart)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureFighter1;
        private System.Windows.Forms.PictureBox pictureFighter2;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Label labelHealth2;
        private System.Windows.Forms.Label labelHealth1;
        private System.Windows.Forms.PictureBox pictureHit2;
        private System.Windows.Forms.PictureBox pictureHit1;
        private System.Windows.Forms.PictureBox pictureHeart;
    }
}

