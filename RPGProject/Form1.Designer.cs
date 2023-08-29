namespace RPGProject
{
    partial class Form_Menu
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
            Lbl_GameTitle = new Label();
            Btn_CreateCharacter = new Button();
            Btn_LoadGame = new Button();
            Btn_GameStats = new Button();
            Btn_Credits = new Button();
            SuspendLayout();
            // 
            // Lbl_GameTitle
            // 
            Lbl_GameTitle.AutoSize = true;
            Lbl_GameTitle.Font = new Font("Perpetua Titling MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_GameTitle.Location = new Point(24, 7);
            Lbl_GameTitle.Name = "Lbl_GameTitle";
            Lbl_GameTitle.Size = new Size(422, 32);
            Lbl_GameTitle.TabIndex = 0;
            Lbl_GameTitle.Text = "RPG Game Title Goes Here";
            // 
            // Btn_CreateCharacter
            // 
            Btn_CreateCharacter.Location = new Point(24, 119);
            Btn_CreateCharacter.Margin = new Padding(3, 2, 3, 2);
            Btn_CreateCharacter.Name = "Btn_CreateCharacter";
            Btn_CreateCharacter.Size = new Size(157, 32);
            Btn_CreateCharacter.TabIndex = 1;
            Btn_CreateCharacter.Text = "Create a Character";
            Btn_CreateCharacter.UseVisualStyleBackColor = true;
            Btn_CreateCharacter.Click += Btn_CreateCharacter_Click;
            // 
            // Btn_LoadGame
            // 
            Btn_LoadGame.Location = new Point(204, 119);
            Btn_LoadGame.Margin = new Padding(3, 2, 3, 2);
            Btn_LoadGame.Name = "Btn_LoadGame";
            Btn_LoadGame.Size = new Size(157, 32);
            Btn_LoadGame.TabIndex = 2;
            Btn_LoadGame.Text = "Load Game";
            Btn_LoadGame.UseVisualStyleBackColor = true;
            // 
            // Btn_GameStats
            // 
            Btn_GameStats.Location = new Point(24, 164);
            Btn_GameStats.Margin = new Padding(3, 2, 3, 2);
            Btn_GameStats.Name = "Btn_GameStats";
            Btn_GameStats.Size = new Size(157, 32);
            Btn_GameStats.TabIndex = 3;
            Btn_GameStats.Text = "Stats";
            Btn_GameStats.UseVisualStyleBackColor = true;
            // 
            // Btn_Credits
            // 
            Btn_Credits.Location = new Point(204, 164);
            Btn_Credits.Margin = new Padding(3, 2, 3, 2);
            Btn_Credits.Name = "Btn_Credits";
            Btn_Credits.Size = new Size(157, 32);
            Btn_Credits.TabIndex = 4;
            Btn_Credits.Text = "Credits";
            Btn_Credits.UseVisualStyleBackColor = true;
            Btn_Credits.Click += Btn_Credits_Click;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 232);
            Controls.Add(Btn_Credits);
            Controls.Add(Btn_GameStats);
            Controls.Add(Btn_LoadGame);
            Controls.Add(Btn_CreateCharacter);
            Controls.Add(Lbl_GameTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_Menu";
            Text = "RPG Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_GameTitle;
        private Button Btn_CreateCharacter;
        private Button Btn_LoadGame;
        private Button Btn_GameStats;
        private Button Btn_Credits;
    }
}