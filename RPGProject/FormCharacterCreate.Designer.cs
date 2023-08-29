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
            label1 = new Label();
            lblStr = new Label();
            lblDex = new Label();
            label4 = new Label();
            lblCon = new Label();
            label6 = new Label();
            lblInt = new Label();
            label8 = new Label();
            lblWis = new Label();
            label10 = new Label();
            lblChr = new Label();
            label12 = new Label();
            btnReRoll = new Button();
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
            Cbo_CharacterClass.SelectedIndexChanged += Cbo_CharacterClass_SelectedIndexChanged;
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
            Btn_StartGame.Text = "Create";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(512, 43);
            label1.Name = "label1";
            label1.Size = new Size(38, 21);
            label1.TabIndex = 9;
            label1.Text = "STR";
            // 
            // lblStr
            // 
            lblStr.AutoSize = true;
            lblStr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStr.Location = new Point(615, 43);
            lblStr.Name = "lblStr";
            lblStr.Size = new Size(19, 21);
            lblStr.TabIndex = 10;
            lblStr.Text = "0";
            // 
            // lblDex
            // 
            lblDex.AutoSize = true;
            lblDex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDex.Location = new Point(615, 63);
            lblDex.Name = "lblDex";
            lblDex.Size = new Size(19, 21);
            lblDex.TabIndex = 12;
            lblDex.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(512, 63);
            label4.Name = "label4";
            label4.Size = new Size(41, 21);
            label4.TabIndex = 11;
            label4.Text = "DEX";
            // 
            // lblCon
            // 
            lblCon.AutoSize = true;
            lblCon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCon.Location = new Point(615, 85);
            lblCon.Name = "lblCon";
            lblCon.Size = new Size(19, 21);
            lblCon.TabIndex = 14;
            lblCon.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(512, 85);
            label6.Name = "label6";
            label6.Size = new Size(45, 21);
            label6.TabIndex = 13;
            label6.Text = "CON";
            // 
            // lblInt
            // 
            lblInt.AutoSize = true;
            lblInt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInt.Location = new Point(615, 104);
            lblInt.Name = "lblInt";
            lblInt.Size = new Size(19, 21);
            lblInt.TabIndex = 16;
            lblInt.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(513, 105);
            label8.Name = "label8";
            label8.Size = new Size(37, 21);
            label8.TabIndex = 15;
            label8.Text = "INT";
            // 
            // lblWis
            // 
            lblWis.AutoSize = true;
            lblWis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWis.Location = new Point(615, 125);
            lblWis.Name = "lblWis";
            lblWis.Size = new Size(19, 21);
            lblWis.TabIndex = 18;
            lblWis.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(512, 125);
            label10.Name = "label10";
            label10.Size = new Size(40, 21);
            label10.TabIndex = 17;
            label10.Text = "WIS";
            // 
            // lblChr
            // 
            lblChr.AutoSize = true;
            lblChr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblChr.Location = new Point(615, 146);
            lblChr.Name = "lblChr";
            lblChr.Size = new Size(19, 21);
            lblChr.TabIndex = 20;
            lblChr.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(512, 146);
            label12.Name = "label12";
            label12.Size = new Size(43, 21);
            label12.TabIndex = 19;
            label12.Text = "CHA";
            // 
            // btnReRoll
            // 
            btnReRoll.Location = new Point(513, 183);
            btnReRoll.Margin = new Padding(3, 2, 3, 2);
            btnReRoll.Name = "btnReRoll";
            btnReRoll.Size = new Size(107, 31);
            btnReRoll.TabIndex = 21;
            btnReRoll.Text = "Re-Roll";
            btnReRoll.UseVisualStyleBackColor = true;
            btnReRoll.Click += btnReRoll_Click;
            // 
            // FormCharacterCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 264);
            Controls.Add(btnReRoll);
            Controls.Add(lblChr);
            Controls.Add(label12);
            Controls.Add(lblWis);
            Controls.Add(label10);
            Controls.Add(lblInt);
            Controls.Add(label8);
            Controls.Add(lblCon);
            Controls.Add(label6);
            Controls.Add(lblDex);
            Controls.Add(label4);
            Controls.Add(lblStr);
            Controls.Add(label1);
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
        private Label label1;
        private Label lblStr;
        private Label lblDex;
        private Label label4;
        private Label lblCon;
        private Label label6;
        private Label lblInt;
        private Label label8;
        private Label lblWis;
        private Label label10;
        private Label lblChr;
        private Label label12;
        private Button btnReRoll;
    }
}