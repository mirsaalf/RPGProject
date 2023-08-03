namespace RPGProject
{
    partial class FormCharacterCreate
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
            Lbl_CharacterName = new Label();
            Txt_CharacterName = new TextBox();
            Lbl_Title = new Label();
            GBox_Gender = new GroupBox();
            Rdo_GenderFemale = new RadioButton();
            Rdo_GenderMale = new RadioButton();
            Cbo_CharacterClass = new ComboBox();
            Lbl_CharacterClass = new Label();
            Btn_StartGame = new Button();
            GBox_Gender.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_CharacterName
            // 
            Lbl_CharacterName.AutoSize = true;
            Lbl_CharacterName.Location = new Point(31, 70);
            Lbl_CharacterName.Name = "Lbl_CharacterName";
            Lbl_CharacterName.Size = new Size(49, 20);
            Lbl_CharacterName.TabIndex = 0;
            Lbl_CharacterName.Text = "Name";
            // 
            // Txt_CharacterName
            // 
            Txt_CharacterName.Location = new Point(97, 63);
            Txt_CharacterName.Name = "Txt_CharacterName";
            Txt_CharacterName.Size = new Size(175, 27);
            Txt_CharacterName.TabIndex = 1;
            // 
            // Lbl_Title
            // 
            Lbl_Title.AutoSize = true;
            Lbl_Title.Font = new Font("Perpetua Titling MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Title.Location = new Point(116, 9);
            Lbl_Title.Name = "Lbl_Title";
            Lbl_Title.Size = new Size(389, 33);
            Lbl_Title.TabIndex = 2;
            Lbl_Title.Text = "Create Your Character";
            // 
            // GBox_Gender
            // 
            GBox_Gender.Controls.Add(Rdo_GenderFemale);
            GBox_Gender.Controls.Add(Rdo_GenderMale);
            GBox_Gender.Location = new Point(31, 118);
            GBox_Gender.Name = "GBox_Gender";
            GBox_Gender.Size = new Size(241, 67);
            GBox_Gender.TabIndex = 3;
            GBox_Gender.TabStop = false;
            GBox_Gender.Text = "Gender";
            // 
            // Rdo_GenderFemale
            // 
            Rdo_GenderFemale.AutoSize = true;
            Rdo_GenderFemale.Location = new Point(118, 26);
            Rdo_GenderFemale.Name = "Rdo_GenderFemale";
            Rdo_GenderFemale.Size = new Size(78, 24);
            Rdo_GenderFemale.TabIndex = 1;
            Rdo_GenderFemale.TabStop = true;
            Rdo_GenderFemale.Text = "Female";
            Rdo_GenderFemale.UseVisualStyleBackColor = true;
            // 
            // Rdo_GenderMale
            // 
            Rdo_GenderMale.AutoSize = true;
            Rdo_GenderMale.Location = new Point(22, 26);
            Rdo_GenderMale.Name = "Rdo_GenderMale";
            Rdo_GenderMale.Size = new Size(63, 24);
            Rdo_GenderMale.TabIndex = 0;
            Rdo_GenderMale.TabStop = true;
            Rdo_GenderMale.Text = "Male";
            Rdo_GenderMale.UseVisualStyleBackColor = true;
            // 
            // Cbo_CharacterClass
            // 
            Cbo_CharacterClass.FormattingEnabled = true;
            Cbo_CharacterClass.Items.AddRange(new object[] { "Mage", "Paladin", "Cleric", "Rogue", "Lumberjack" });
            Cbo_CharacterClass.Location = new Point(149, 204);
            Cbo_CharacterClass.Name = "Cbo_CharacterClass";
            Cbo_CharacterClass.Size = new Size(151, 28);
            Cbo_CharacterClass.TabIndex = 4;
            // 
            // Lbl_CharacterClass
            // 
            Lbl_CharacterClass.AutoSize = true;
            Lbl_CharacterClass.Location = new Point(31, 212);
            Lbl_CharacterClass.Name = "Lbl_CharacterClass";
            Lbl_CharacterClass.Size = new Size(109, 20);
            Lbl_CharacterClass.TabIndex = 5;
            Lbl_CharacterClass.Text = "Character Class";
            // 
            // Btn_StartGame
            // 
            Btn_StartGame.Location = new Point(178, 265);
            Btn_StartGame.Name = "Btn_StartGame";
            Btn_StartGame.Size = new Size(122, 41);
            Btn_StartGame.TabIndex = 6;
            Btn_StartGame.Text = "Start";
            Btn_StartGame.UseVisualStyleBackColor = true;
            // 
            // FormCharacterCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 336);
            Controls.Add(Btn_StartGame);
            Controls.Add(Lbl_CharacterClass);
            Controls.Add(Cbo_CharacterClass);
            Controls.Add(GBox_Gender);
            Controls.Add(Lbl_Title);
            Controls.Add(Txt_CharacterName);
            Controls.Add(Lbl_CharacterName);
            Name = "FormCharacterCreate";
            Text = "Character Creation";
            GBox_Gender.ResumeLayout(false);
            GBox_Gender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_CharacterName;
        private TextBox Txt_CharacterName;
        private Label Lbl_Title;
        private GroupBox GBox_Gender;
        private RadioButton Rdo_GenderFemale;
        private RadioButton Rdo_GenderMale;
        private ComboBox Cbo_CharacterClass;
        private Label Lbl_CharacterClass;
        private Button Btn_StartGame;
    }
}