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
            lbl_ErrorName = new Label();
            lbl_ErrorGender = new Label();
            GBox_Gender.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_CharacterName
            // 
            Lbl_CharacterName.AutoSize = true;
            Lbl_CharacterName.Location = new Point(27, 52);
            Lbl_CharacterName.Name = "Lbl_CharacterName";
            Lbl_CharacterName.Size = new Size(39, 15);
            Lbl_CharacterName.TabIndex = 0;
            Lbl_CharacterName.Text = "Name";
            // 
            // Txt_CharacterName
            // 
            Txt_CharacterName.Location = new Point(85, 47);
            Txt_CharacterName.Margin = new Padding(3, 2, 3, 2);
            Txt_CharacterName.Name = "Txt_CharacterName";
            Txt_CharacterName.Size = new Size(154, 23);
            Txt_CharacterName.TabIndex = 1;
            // 
            // Lbl_Title
            // 
            Lbl_Title.AutoSize = true;
            Lbl_Title.Font = new Font("Perpetua Titling MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Title.Location = new Point(102, 7);
            Lbl_Title.Name = "Lbl_Title";
            Lbl_Title.Size = new Size(306, 26);
            Lbl_Title.TabIndex = 2;
            Lbl_Title.Text = "Create Your Character";
            // 
            // GBox_Gender
            // 
            GBox_Gender.Controls.Add(Rdo_GenderFemale);
            GBox_Gender.Controls.Add(Rdo_GenderMale);
            GBox_Gender.Location = new Point(27, 88);
            GBox_Gender.Margin = new Padding(3, 2, 3, 2);
            GBox_Gender.Name = "GBox_Gender";
            GBox_Gender.Padding = new Padding(3, 2, 3, 2);
            GBox_Gender.Size = new Size(211, 50);
            GBox_Gender.TabIndex = 3;
            GBox_Gender.TabStop = false;
            GBox_Gender.Text = "Gender";
            // 
            // Rdo_GenderFemale
            // 
            Rdo_GenderFemale.AutoSize = true;
            Rdo_GenderFemale.Location = new Point(103, 20);
            Rdo_GenderFemale.Margin = new Padding(3, 2, 3, 2);
            Rdo_GenderFemale.Name = "Rdo_GenderFemale";
            Rdo_GenderFemale.Size = new Size(63, 19);
            Rdo_GenderFemale.TabIndex = 1;
            Rdo_GenderFemale.Text = "Female";
            Rdo_GenderFemale.UseVisualStyleBackColor = true;
            // 
            // Rdo_GenderMale
            // 
            Rdo_GenderMale.AutoSize = true;
            Rdo_GenderMale.Checked = true;
            Rdo_GenderMale.Location = new Point(19, 20);
            Rdo_GenderMale.Margin = new Padding(3, 2, 3, 2);
            Rdo_GenderMale.Name = "Rdo_GenderMale";
            Rdo_GenderMale.Size = new Size(51, 19);
            Rdo_GenderMale.TabIndex = 0;
            Rdo_GenderMale.TabStop = true;
            Rdo_GenderMale.Text = "Male";
            Rdo_GenderMale.UseVisualStyleBackColor = true;
            // 
            // Cbo_CharacterClass
            // 
            Cbo_CharacterClass.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_CharacterClass.FormattingEnabled = true;
            Cbo_CharacterClass.Items.AddRange(new object[] { "Mage", "Paladin", "Cleric", "Rogue", "Lumberjack" });
            Cbo_CharacterClass.Location = new Point(130, 153);
            Cbo_CharacterClass.Margin = new Padding(3, 2, 3, 2);
            Cbo_CharacterClass.Name = "Cbo_CharacterClass";
            Cbo_CharacterClass.Size = new Size(133, 23);
            Cbo_CharacterClass.TabIndex = 4;
            // 
            // Lbl_CharacterClass
            // 
            Lbl_CharacterClass.AutoSize = true;
            Lbl_CharacterClass.Location = new Point(27, 159);
            Lbl_CharacterClass.Name = "Lbl_CharacterClass";
            Lbl_CharacterClass.Size = new Size(88, 15);
            Lbl_CharacterClass.TabIndex = 5;
            Lbl_CharacterClass.Text = "Character Class";
            // 
            // Btn_StartGame
            // 
            Btn_StartGame.Location = new Point(156, 199);
            Btn_StartGame.Margin = new Padding(3, 2, 3, 2);
            Btn_StartGame.Name = "Btn_StartGame";
            Btn_StartGame.Size = new Size(107, 31);
            Btn_StartGame.TabIndex = 6;
            Btn_StartGame.Text = "Start";
            Btn_StartGame.UseVisualStyleBackColor = true;
            Btn_StartGame.Click += Btn_StartGame_Click;
            // 
            // lbl_ErrorName
            // 
            lbl_ErrorName.AutoSize = true;
            lbl_ErrorName.ForeColor = Color.Red;
            lbl_ErrorName.Location = new Point(280, 47);
            lbl_ErrorName.Name = "lbl_ErrorName";
            lbl_ErrorName.Size = new Size(105, 15);
            lbl_ErrorName.TabIndex = 7;
            lbl_ErrorName.Text = "Please enter Name";
            lbl_ErrorName.Visible = false;
            // 
            // lbl_ErrorGender
            // 
            lbl_ErrorGender.AutoSize = true;
            lbl_ErrorGender.ForeColor = Color.Red;
            lbl_ErrorGender.Location = new Point(280, 110);
            lbl_ErrorGender.Name = "lbl_ErrorGender";
            lbl_ErrorGender.Size = new Size(113, 15);
            lbl_ErrorGender.TabIndex = 8;
            lbl_ErrorGender.Text = "Please select gender";
            lbl_ErrorGender.Visible = false;
            // 
            // FormCharacterCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 252);
            Controls.Add(lbl_ErrorGender);
            Controls.Add(lbl_ErrorName);
            Controls.Add(Btn_StartGame);
            Controls.Add(Lbl_CharacterClass);
            Controls.Add(Cbo_CharacterClass);
            Controls.Add(GBox_Gender);
            Controls.Add(Lbl_Title);
            Controls.Add(Txt_CharacterName);
            Controls.Add(Lbl_CharacterName);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label lbl_ErrorName;
        private Label lbl_ErrorGender;
    }
}