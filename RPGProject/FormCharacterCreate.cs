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
using System.Data.SqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RPGProject
{
    public partial class FormCharacterCreate : Form
    {
        public FormCharacterCreate()
        {
            InitializeComponent();
            lbl_ErrorGender.Visible = false;
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
                String query = $"INSERT INTO Character (name, female, classid) VALUES ('{Txt_CharacterName.Text}', {isFemale}, {Cbo_CharacterClass.SelectedValue} )";
                // Prepare the command to be executed on the db
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Let's ask the db to execute the query
                    int rowsAdded = cmd.ExecuteNonQuery();
                    if (rowsAdded > 0)
                    {
                        MessageBox.Show("Character Created!!");
                        this.Hide();
                    }
                    else
                    {
                        // Well this should never really happen
                        MessageBox.Show("No row inserted");
                    }
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
    }
}
