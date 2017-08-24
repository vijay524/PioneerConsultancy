using PioneerTestConsultancySys.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmployeeDataAcces
{
    public class EmployeeAccess
    {
        public int SaveEmployee(EmployeeModel Emp )
        {
            int result = 0;
            try
            {
                string connectionstring = @"Data Source=DESKTOP-GQMFKE5\SQLEXPRESS;Initial Catalog=PioneerEmployeeDB;" + "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqlEmployee = @"INSERT INTO Employee_Details(First_Name,Last_Name,Email,Mobile_Number,AlternateMobileNumber,Address1,Adress2,Current_Country,Home_Country,Zipcode)VALUES('" + Emp.First_Name + "'," + "'" + Emp.Last_Name + "'," + "'" +Emp.Email + "'," + "" +Emp. Mobile_Number + "," + "" +Emp. AlternateMobileNumber + "," + "'" + Emp.Address1 + "'," + "'" + Emp.Address2 + "'," + "'" + Emp.Current_Country + "'," + "'" + Emp.Home_Country + "'," + "" + Emp.ZipCode + ")";
                SqlCommand command = new SqlCommand(sqlEmployee, mysqlconnection);
                result = command.ExecuteNonQuery();
                if(result>0)
                {
                    MessageBox.Show("Data have save Successfully.Thank you");
                }
                mysqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
            return result;
        }
    }


    public class ProjectAccess

    {
        public int SaveProject(ProjectModel ProjM)
        {
            int result = 0;
            try
            {
                string connectionstring = @"Data Source=DESKTOP-GQMFKE5\SQLEXPRESS;Initial Catalog=PioneerEmployeeDB;" +
                           " Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string q = @"INSERT INTO Project_Details(EmployeeID,Project_Name,Client_Name,Location,Roles)VALUES(" + ProjM.EmployeeID + "," + "'" + ProjM.Project_Name + "'," + "'" + ProjM.Client_Name + "'," + "'" + ProjM.Location + "'," + "'" + ProjM.Roles + "')";
                SqlCommand command;
                command = new SqlCommand(q, mysqlconnection);
                result = command.ExecuteNonQuery();
                if(result>0)
                {
                    MessageBox.Show("Data have save Successfully.Thank you");
                }
                mysqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
            return result;
        }

    }


    public class EducationAccess
    {
        public int SaveEducation(EducationModel EduModel)
        {
            int result = 0;
            try
            {

                string connectionstring = @"Data Source=DESKTOP-GQMFKE5\SQLEXPRESS;Initial Catalog=PioneerEmployeeDB;" +
                           " Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string q = @"INSERT INTO Education_Details(CourseType,CourseSpecialisation,YearOfPass)VALUES('" + EduModel.CourseType + "'," + "'" + EduModel.CourseSpecialisation + "'," + "" + EduModel.YearOfPass + ")";
                SqlCommand command;
                command = new SqlCommand(q, mysqlconnection);
                result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data have save Successfully.Thank you");
                }
                mysqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
            return result;

        }
    }


    public class TechnicalAccess
    {
        public int SaveTech(TehnicalModel TechModel)
        {
            int result = 0;
            try
            {
                string connectionstring = @"Data Source=DESKTOP-GQMFKE5\SQLEXPRESS;Initial Catalog=PioneerEmployeeDB;" +
                           " Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string q = @"INSERT INTO Technical_Details(UI,Programming_Languages,ORM_Technologies,Databases)VALUES('" + TechModel.UI + "'," + "'" + TechModel.Programming_Languages + "'," + "'" + TechModel.ORM_Technologies + "'," + "'" + TechModel.Databases + "')";
                SqlCommand command;
                command = new SqlCommand(q, mysqlconnection);
               result= command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data have save Successfully.Thank you");
                }
                mysqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }


            return result;
        }
        



    }
    public class CompanyAccess
    {
        public int SaveCompany1(CompanyModel Comp)
        {
            int result = 0;
            try
            {
                string connectionstring = @"Data Source=DESKTOP-GQMFKE5\SQLEXPRESS;Initial Catalog=PioneerEmployeeDB;" +
                                       " Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string q = @"INSERT INTO Company_Details(Employer_Name,Contact_Number,Location,Website)VALUES('" + Comp.Employer_Name + "'," + "" + Comp.Contact_Number + "," + "'" + Comp.Location + "'," + "'" + Comp.Website + "')";
                SqlCommand command;
                command = new SqlCommand(q, mysqlconnection);
                result = command.ExecuteNonQuery();
                mysqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
            return result;
        }
    }
}







