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
        public int SaveEmployee(string First_Name, string Last_Name, string Email, long Mobile_Number, long AlternateMobileNumber, string Address1, string Address2, string Current_Country, string Home_Country, int ZipCode)
        {
            int result = 0;
            try
            {
                string connectionstring = @"Data Source=DESKTOP-GQMFKE5\SQLEXPRESS;Initial Catalog=PioneerEmployeeDB;" + "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqlEmployee = @"INSERT INTO Employee_Details(First_Name,Last_Name,Email,Mobile_Number,AlternateMobileNumber,Address1,Adress2,Current_Country,Home_Country,Zipcode)VALUES('" + First_Name + "'," + "'" + Last_Name + "'," + "'" + Email + "'," + "" + Mobile_Number + "," + "" + AlternateMobileNumber + "," + "'" + Address1 + "'," + "'" + Address2 + "'," + "'" + Current_Country + "'," + "'" + Home_Country + "'," + "" + ZipCode + ")";
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
        public int SaveProject(int EmployeeID, string Project_Name, string Client_Name, string Location, string Roles)
        {
            int result = 0;
            try
            {
                string connectionstring = @"Data Source=DESKTOP-GQMFKE5\SQLEXPRESS;Initial Catalog=PioneerEmployeeDB;" +
                           " Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string q = @"INSERT INTO Project_Details(EmployeeID,Project_Name,Client_Name,Location,Roles)VALUES(" + EmployeeID + "," + "'" + Project_Name + "'," + "'" + Client_Name + "'," + "'" + Location + "'," + "'" + Roles + "')";
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
        public int SaveEducation(string CourseType, string CourseSpecialisation, int YearOfPass)
        {
            int result = 0;
            try
            {

                string connectionstring = @"Data Source=DESKTOP-GQMFKE5\SQLEXPRESS;Initial Catalog=PioneerEmployeeDB;" +
                           " Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string q = @"INSERT INTO Education_Details(CourseType,CourseSpecialisation,YearOfPass)VALUES('" + CourseType + "'," + "'" + CourseSpecialisation + "'," + "" + YearOfPass + ")";
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
        public int SaveTech(string UI, string Programming_Languages, string ORM_Technologies, string Databases)
        {
            int result = 0;
            try
            {
                string connectionstring = @"Data Source=DESKTOP-GQMFKE5\SQLEXPRESS;Initial Catalog=PioneerEmployeeDB;" +
                           " Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string q = @"INSERT INTO Technical_Details(UI,Programming_Languages,ORM_Technologies,Databases)VALUES('" + UI + "'," + "'" + Programming_Languages + "'," + "'" + ORM_Technologies + "'," + "'" + Databases + "')";
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
}







