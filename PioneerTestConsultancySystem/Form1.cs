using EmployeeDataAcces;
using PioneerTestConsultancySys.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PioneerTestConsultancySystem
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void CompanyID_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            EmployeeModel Emodel = new EmployeeModel()
            {
                First_Name = FirstNametextbox.Text,
                Last_Name = LastNametextbox.Text,
                Email = Emailtextbox.Text,
                Mobile_Number = Convert.ToInt64(MobileNumbertextbox.Text),
                AlternateMobileNumber = Convert.ToInt64(AlternateMobileNumbertextbox.Text),
                Address1 = Address1textbox.Text,
                Address2 = Address2textbox.Text,
                Current_Country = CurrentCountrytextbox.Text,
                Home_Country = HomeCountrytextbox.Text,
                ZipCode = Convert.ToInt32(Zipcodetextbox.Text)
            };
            EmployeeAccess EA = new EmployeeAccess();
            EA.SaveEmployee(Emodel);

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            FirstNametextbox.Text = String.Empty;
            LastNametextbox.Text = String.Empty;
            Emailtextbox.Text = String.Empty;
            MobileNumbertextbox.Text = String.Empty;
            AlternateMobileNumbertextbox.Text = String.Empty;
            Address1textbox.Text = String.Empty;
            Address2textbox.Text = String.Empty;
            CurrentCountrytextbox.Text = String.Empty;
            HomeCountrytextbox.Text = String.Empty;
            Zipcodetextbox.Text = String.Empty;
        }

        private void FirstNametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int EmployeeID = Convert.ToInt32(EmployeeIDtextbox.Text);
                string connectionstring = @"Data Source=DESKTOP-GQMFKE5\SQLEXPRESS;Initial Catalog=PioneerEmployeeDB;" +
                       " Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqlEmployeeDetails = ("SELECT * FROM Employee_Details WHERE EmployeeID=" + EmployeeID);
                string sqlEducationDetails = ("SELECT * FROM Education_Details WHERE EmployeeID=" + EmployeeID);
                string sqlTechnicalDetails = ("SELECT * FROM Technical_Details WHERE EmployeeID=" + EmployeeID);
                string sqlCompanyDetails = ("SELECT * FROM Company_Details WHERE EmployeeID=" + EmployeeID);
                string sqlProjectDetails = ("SELECT * FROM Project_Details WHERE EmployeeID=" + EmployeeID);

                SqlCommand command;
                command = new SqlCommand(sqlEmployeeDetails, mysqlconnection);
                SqlDataReader EmployeeData = command.ExecuteReader();
                BindingSource gridview = new BindingSource();
                gridview.DataSource = EmployeeData;
                EmployeeDetails.DataSource = gridview;
                EmployeeData.Close();
                // string r = ("SELECT * FROM Education_Details WHERE EmployeeID=" + EmployeeID);

                command = new SqlCommand(sqlEducationDetails, mysqlconnection);
                SqlDataReader sd = command.ExecuteReader();
                BindingSource b = new BindingSource();
                b.DataSource = sd;
                EducationalDetails.DataSource = b;
                sd.Close();
                command = new SqlCommand(sqlTechnicalDetails, mysqlconnection);
                SqlDataReader dr = command.ExecuteReader();
                BindingSource a = new BindingSource();
                a.DataSource = dr;
                TechnicalDetails.DataSource = a;
                dr.Close();
                command = new SqlCommand(sqlCompanyDetails, mysqlconnection);
                SqlDataReader rd = command.ExecuteReader();
                BindingSource i = new BindingSource();
                i.DataSource = rd;
                CompanyDetails.DataSource = i;
                rd.Close();
                command = new SqlCommand(sqlProjectDetails, mysqlconnection);
                SqlDataReader cd = command.ExecuteReader();
                BindingSource v = new BindingSource();
                v.DataSource = cd;
                ProjectDetails.DataSource = v;
                cd.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*try
            {*/
            EducationModel EduModel = new EducationModel();
            EduModel.CourseType = CourseTypetextbox.Text;
            EduModel.CourseSpecialisation = CourseSpecialisationtextbox.Text;
            EduModel.YearOfPass = Convert.ToInt32(YearOfPasstextbox.Text);
            EducationAccess EdA = new EducationAccess();
            EdA.SaveEducation(EduModel);
        }

        /* string connectionstring = @"Data Source=DESKTOP-GQMFKE5\SQLEXPRESS;Initial Catalog=PioneerEmployeeDB;" +
               " Integrated Security=True";
        SqlConnection mysqlconnection = new SqlConnection(connectionstring);
        mysqlconnection.Open();
            string q = @"INSERT INTO Education_Details(CourseType,CourseSpecialisation,YearOfPass)VALUES('"+CourseType+"',"+"'"+CourseSpecialisation+"',"+""+YearOfPass+")";
        SqlCommand command;
        command = new SqlCommand(q, mysqlconnection);
        command.ExecuteNonQuery();
        mysqlconnection.Close();
        }
        catch(Exception ex)
        {
            MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
        }

    } */

        public void button3_Click(object sender, EventArgs e)
        {
            /*try
            {*/
            TehnicalModel Tmodel = new TehnicalModel();
            Tmodel.UI = UItextbox.Text;
            Tmodel.Programming_Languages = Programmingtextbox.Text;
            Tmodel.ORM_Technologies = ORMtextbox.Text;
            Tmodel.Databases = Databasestextbox.Text;
            TechnicalAccess TA = new TechnicalAccess();
            TA.SaveTech(Tmodel);


            /*string connectionstring = @"Data Source=DESKTOP-GQMFKE5\SQLEXPRESS;Initial Catalog=PioneerEmployeeDB;" +
                   " Integrated Security=True";
            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
            string q = @"INSERT INTO Technical_Details(UI,Programming_Languages,ORM_Technologies,Databases)VALUES('" + UI + "'," + "'" + Programming_Languages + "'," + "'" + ORM_Technologies + "'," + "'" + Databases + "')";
            SqlCommand command;
            command = new SqlCommand(q, mysqlconnection);
            command.ExecuteNonQuery();
            mysqlconnection.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
        }*/

        }
    
            private void button9_Click(object sender, EventArgs e)
            {
            /*try
            {*/
            CompanyModel CModel = new CompanyModel();
           
            CModel.Employer_Name = Employertextbox.Text;
            CModel.Contact_Number = Convert.ToInt64(ContactNumbertextbox.Text);
            CModel.Location = Locationtextbox.Text;
            CModel.Website = Websitetextbox.Text;
          
            CompanyAccess CA = new CompanyAccess();
            CA.SaveCompany1(CModel);


        }

            private void label30_Click(object sender, EventArgs e)
            {

            }

            private void button5_Click(object sender, EventArgs e)
            {
            /* try
             {*/
            ProjectModel PModel = new ProjectModel();
            PModel.EmployeeID = Convert.ToInt32(EmployeeID1textbox.Text);
            PModel.Project_Name = ProjectNametextbox.Text;
            PModel.Client_Name = ClientNametextbox.Text;
            PModel.Location = ProjectLocationtextbox.Text;
            PModel.Roles = Roletextbox.Text;
            PModel.Databases = Databasestextbox.Text;
                ProjectAccess PA = new ProjectAccess();
                PA.SaveProject(PModel);
                /*string connectionstring = @"Data Source=DESKTOP-GQMFKE5\SQLEXPRESS;Initial Catalog=PioneerEmployeeDB;" +
                       " Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string q = @"INSERT INTO Project_Details(EmployeeID,Project_Name,Client_Name,Location,Roles)VALUES("+EmployeeID+","+"'"+Project_Name+"',"+"'"+Client_Name+"',"+"'"+Location+"',"+"'"+Roles+"')";
                SqlCommand command;
                command = new SqlCommand(q, mysqlconnection);
                command.ExecuteNonQuery();
                mysqlconnection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
                } */

            }

            private void button6_Click(object sender, EventArgs e)
            {
                CourseTypetextbox.Text = String.Empty;
                CourseSpecialisationtextbox.Text = String.Empty;
                YearOfPasstextbox.Text = String.Empty;
            }

            private void Clear2_Click(object sender, EventArgs e)
            {
                UItextbox.Text = String.Empty;
                Programmingtextbox.Text = String.Empty;
                ORMtextbox.Text = String.Empty;
                Databasestextbox.Text = String.Empty;
            }

            private void Clear3_Click(object sender, EventArgs e)
            {
                EmployeeID1textbox.Text = String.Empty;
                ProjectNametextbox.Text = String.Empty;
                ClientNametextbox.Text = String.Empty;
                ProjectLocationtextbox.Text = String.Empty;
                Roletextbox.Text = String.Empty;
            }

            private void Clear4_Click(object sender, EventArgs e)
            {

                Employertextbox.Text = String.Empty;
                ContactNumbertextbox.Text = String.Empty;
                Locationtextbox.Text = String.Empty;
                Websitetextbox.Text = String.Empty;
                MessageBox.Show("You have cleared:");
            }

 
    }
    }