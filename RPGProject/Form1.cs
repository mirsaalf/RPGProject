namespace RPGProject
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void Btn_CreateCharacter_Click(object sender, EventArgs e)
        {
            FormCharacterCreate charcreator = new FormCharacterCreate();
            charcreator.Show();
        }

        private void Btn_Credits_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            credits.Show();
        }
    }
}