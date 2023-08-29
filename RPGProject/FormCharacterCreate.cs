using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RPGProject
{
    public partial class FormCharacterCreate : Form
    {
        public FormCharacterCreate()
        {
            InitializeComponent();
            lbl_ErrorName.Visible = false;
            PopulateClass();
        }

        private void PopulateClass()
        {
            SqlConnection con = new SqlConnection();

            try
            {
                String query = "select classid, classname from class order by classname";
                con = GlobalFunctions.ConnectToDatabase(query);
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                //fill the dataset                
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Class");
                con.Close();
                Cbo_CharacterClass.DisplayMember = "classname";
                Cbo_CharacterClass.ValueMember = "classid";
                Cbo_CharacterClass.DataSource = ds.Tables["Class"];
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void generateStats(int classid)
        {
            SqlConnection con = new SqlConnection();
            int[] minsList = new int[6];

            try
            {
                String query = $"select str_min, dex_min, con_min, int_min, wis_min, cha_min from class where classid={classid}";
                con = GlobalFunctions.ConnectToDatabase();
                SqlCommand command = new SqlCommand(query, con);

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    minsList[0] = (Convert.ToInt32(reader["cha_min"]));
                    minsList[1] = (Convert.ToInt32(reader["con_min"]));
                    minsList[2] = (Convert.ToInt32(reader["dex_min"]));
                    minsList[3] = (Convert.ToInt32(reader["int_min"]));
                    minsList[4] = (Convert.ToInt32(reader["str_min"]));
                    minsList[5] = (Convert.ToInt32(reader["wis_min"]));
                }

                lblChr.Text = randomNumber(minsList[0]);
                lblCon.Text = randomNumber(minsList[1]);
                lblDex.Text = randomNumber(minsList[2]);
                lblInt.Text = randomNumber(minsList[3]);
                lblStr.Text = randomNumber(minsList[4]);
                lblWis.Text = randomNumber(minsList[5]);

                // Call Close when done reading.
                reader.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private string randomNumber(int min)
        {
            Random rnd = new Random();
            return rnd.Next(min, 18).ToString();
        }

        private void Btn_StartGame_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            try
            {
                //validation
                if (String.IsNullOrEmpty(Txt_CharacterName.Text))
                {
                    lbl_ErrorName.Visible = true;
                    return;
                }
                //set gender bit
                Int16 isFemale = 0;
                if (Rdo_GenderFemale.Checked)
                {
                    isFemale = 1;
                }

                con = GlobalFunctions.ConnectToDatabase();
                String query = $"INSERT INTO Character (name, female, classid) OUTPUT Inserted.charid VALUES ('{Txt_CharacterName.Text}', {isFemale}, {Cbo_CharacterClass.SelectedValue} )";
                // Prepare the command to be executed on the db
                SqlCommand cmd = new SqlCommand(query, con);

                // Let's ask the db to execute the query
                int charid = Convert.ToInt32(cmd.ExecuteScalar());

                if (charid != 0)
                {
                    MessageBox.Show("Character Created!!");
                }
                else
                {
                    // Well this should never really happen
                    MessageBox.Show("No row inserted");
                    return;
                }

                query = $"INSERT INTO CharacterStats (charid, charisma, constitution, dexterity, intelligence, strength, wisdom) VALUES ({charid}, {lblChr.Text}, {lblCon.Text}, {lblDex.Text}, {lblInt.Text}, {lblStr.Text}, {lblWis.Text})";
                // Prepare the command to be executed on the db
                cmd = new SqlCommand(query, con);

                // Let's ask the db to execute the query
                int rowsAdded = cmd.ExecuteNonQuery();
                if (rowsAdded > 0)
                {
                    MessageBox.Show("Character Stats Created!!");
                    this.Hide();
                }
                else
                {
                    // Well this should never really happen
                    MessageBox.Show("No row inserted");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }


        }

        private void Cbo_CharacterClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;
            int selectedClass = Convert.ToInt32(comboBox.SelectedValue);
            generateStats(selectedClass);
        }

        private void btnReRoll_Click(object sender, EventArgs e)
        {
            generateStats(Convert.ToInt32(Cbo_CharacterClass.SelectedValue));
        }
    }
}
