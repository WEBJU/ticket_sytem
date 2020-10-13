using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Ticketing_System.class_folder
{
    class workticketclass
    {

        //getter and setter properties
        //Acts as data carriers in our application
        public int id { get; set; }
        public int ticket_id { get; set; }
        public string employee_id { get; set; }
        public string description { get; set; }
        public string comments { get; set; }
        public string assigned_staff { get; set; }
        public string ticket_status { get; set; }
        public DateTime date_raised { get; set; }
        public string employee_name { get; set; }
        public string employee_department { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string Passcode { get; set; }
        public string UserRole { get; set; }
        public string Expertise { get; set; }

        public string username { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        //select data from database
        public DataTable select()
        {
            //database connnection
            SqlConnection conn = new SqlConnection(myconnstrng);
                DataTable dt = new DataTable();
                try
                {
                    //writing sql query
                    string sql = "SELECT * FROM SoftwIssuesTBL";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
                catch (Exception)
                {

                }
                finally
                {
                    conn.Close();
                }
                return dt;
            }
        
        public DataTable selectHD()
        {
            //database connnection
            SqlConnection conn = new SqlConnection(myconnstrng);
                DataTable dtHD = new DataTable();
                try
                {
                    //writing sql query
                    string sql = "SELECT * FROM HardwIssuesTBL";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dtHD);
                }
                catch (Exception )
                {

                }
                finally
                {
                    conn.Close();
                }
                return dtHD;
            }
        public DataTable selectNT()
        {
            //database connnection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dtNT = new DataTable();
            try
            {
                //writing sql query
                string sql = "SELECT * FROM NetwIssuesTBL";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dtNT);
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return dtNT;
        }

        internal void insertstaffHd(workticketclass c)
        {
            throw new NotImplementedException();
        }

       
       public bool addStaff(workticketclass c)
       {
           bool isSuccess = false;
           SqlConnection conn = new SqlConnection(myconnstrng);
           try
           {        
                   //sql query to add data
                   string sql = "INSERT INTO users(FullName,Email,Department,Passcode,UserRole,username,expertise) VALUES(@FullName,@Email,@Department,@Passcode,@UserRole,@username,@expertise)";
                   SqlCommand cmd = new SqlCommand(sql, conn);
                   //create parameters to add data
                   cmd.Parameters.AddWithValue("@FullName", c.FullName);
                   cmd.Parameters.AddWithValue("@Email", c.Email);
                   cmd.Parameters.AddWithValue("@Department", c.Department);
                   cmd.Parameters.AddWithValue("@Passcode", c.Passcode);
                   cmd.Parameters.AddWithValue("@UserRole", c.UserRole);
                   cmd.Parameters.AddWithValue("@username", c.username);
                   cmd.Parameters.AddWithValue("@expertise", c.Expertise);

                   //open connection
                   conn.Open();
                   int rows = cmd.ExecuteNonQuery();
                   if (rows > 0)
                   {
                       isSuccess = true;
                   }
                   else
                   {
                       isSuccess = false;
                   }
               }
           catch (Exception )
           {

           }
           finally
           {
               conn.Close();
           }
           return isSuccess;
       }
      
        /*public bool insertHD(workticketclass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql query to add data
                string sql = "INSERT INTO raised_tickets (employee_id,ticket_id,description,date_raised,comments,employee_name,employee_department) VALUES(@employee_id,@ticket_id,@description,@date_raised,@comments,@employee_name,@employee_department)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add data
                cmd.Parameters.AddWithValue("@employee_id", c.employee_id);
                cmd.Parameters.AddWithValue("@ticket_id", c.ticket_id);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@date_raised", c.date_raised);
                cmd.Parameters.AddWithValue("@comments", c.comments);
                cmd.Parameters.AddWithValue("@employee_name", c.employee_name);
                cmd.Parameters.AddWithValue("@employee_department", c.Department);

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }*/
      /*  public bool insertNT(workticketclass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql query to add data
                string sql = "INSERT INTO NetwIssuesTBL (EmployeeIDNo,Full_Names,Department,Issues,Issue_Description,Date,Other_Complements) VALUES(@EmployeeIDNo,@Full_Names,@Department,@Issues,@Issue_Description,@Date,@Other_Complements)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add data
                cmd.Parameters.AddWithValue("@EmployeeIDNo", c.EmployeeIDNo);
                cmd.Parameters.AddWithValue("@Full_Names", c.Full_Names);
                cmd.Parameters.AddWithValue("@Department", c.Department);
                cmd.Parameters.AddWithValue("@Issues", c.Issues);
                cmd.Parameters.AddWithValue("@Issue_Description", c.Issue_Description);
                cmd.Parameters.AddWithValue("@Date", c.Date);
                cmd.Parameters.AddWithValue("@Other_Complements", c.Other_Complements);

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }*/
      /*  public bool insertlgn(workticketclass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql query to add data
                string sql = "INSERT INTO EmpSignupTbl (User_Names,Password) VALUES(@User_Names,@Password)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add data

                cmd.Parameters.AddWithValue("@User_Names", c.User_Names);
                cmd.Parameters.AddWithValue("@Password", c.Password);

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        */
       /* public bool insertstaff(workticketclass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql query to add data
                string sql = "INSERT INTO StaffsignupTBL (Names,Expertise,Passcode) VALUES(@Names,@Expertise,@Passcode)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add data

                cmd.Parameters.AddWithValue("@Names", c.Names);
                cmd.Parameters.AddWithValue("@Expertise", c.Expertise);
                cmd.Parameters.AddWithValue("@Passcode", c.Passcode);

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }*/
       /*
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql query to add data
                string sql = "INSERT INTO staffsignupSoftTbl (Names,Expertise,Passcode) VALUES(@Names,@Expertise,@Passcode)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add data

                cmd.Parameters.AddWithValue("@Names", c.Names);
                cmd.Parameters.AddWithValue("@Expertise", c.Expertise);
                cmd.Parameters.AddWithValue("@Passcode", c.Passcode);

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }*/
        /*public bool insertstaffHd(workticketclass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql query to add data
                string sql = "INSERT INTO users (FullName,expertise,Passcode) VALUES(@FullName,@expertise,@Passcode)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add data

                cmd.Parameters.AddWithValue("@Names", c.FullName);
                cmd.Parameters.AddWithValue("@Expertise", c.Expertise);
                cmd.Parameters.AddWithValue("@Passcode", c.Passcode);

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }*/
        /*public bool insertseniorstaff(workticketclass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql query to add data
                string sql = "INSERT INTO SeniorStaffSignupTbl (StaffNames,SecurityCode) VALUES(@StaffNames,@SecurityCode)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add data

                cmd.Parameters.AddWithValue("@StaffNames", c.StaffNames);
                cmd.Parameters.AddWithValue("@SecurityCode", c.SecurityCode);

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }*/
        //method to update data from app
       /* public bool update(workticketclass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql to update data
                string sql = "UPDATE EmployeeTbl SET EmmployeeIDNo = @EmployeeIDNo,Full_Names = @Full_Names,Department = @Department,Issues = @Issues,Issue_Description = @Issue_Description,Date = @Date,Other_Complements = @Other_Complements WHERE EmployeeIDNo = @EmployeeIDNo";

                //sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add value
                cmd.Parameters.AddWithValue("@EmlpoyeeIDNo", c.EmployeeIDNo);
                cmd.Parameters.AddWithValue("@Full_Names", c.Full_Names);
                cmd.Parameters.AddWithValue("@Department", c.Department);
                cmd.Parameters.AddWithValue("@Issues", c.Issues);
                cmd.Parameters.AddWithValue("@Issue_Description", c.Issue_Description);
                cmd.Parameters.AddWithValue("@Date", c.Date);
                cmd.Parameters.AddWithValue("@Other_Complements", c.Other_Complements);
                //open database connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
       */
        //method to delete data
        public bool Delete(workticketclass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql to delete data
                string sql = "DELETE FROM raised_tickets WHERE id = @id";

                //sql command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create parameters to add value
                cmd.Parameters.AddWithValue("@Ticket_No", c.ticket_id);

                //open database connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }

}

