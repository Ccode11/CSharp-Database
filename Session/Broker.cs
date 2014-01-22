using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using Domain;
using System.Data;

namespace Session
{
    public class Broker
    {
        OleDbConnection connection;
        OleDbCommand command;

        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;Persist Security Info=False");
            command = connection.CreateCommand();
        }

        public Broker()
        {
            ConnectTo();
        }

        public void Insert(Person p)
        {
            try
            {
                command.CommandText = "INSERT INTO TPersons([firstname], [lastname], [dob], [position], [catagory], [gender]) VALUES('" + p.Firstname + "','" + p.Lastname + "', '" + p.Dob + "','" + p.Position + "', '" + p.Catagory + "', '" + p.Gender + "')";
                command.CommandType = CommandType.Text;
                connection.Open();
                
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close(); 
                }
            }
        }
        
        public List<Person> FillComboBox()
        {
            List<Person> personslist = new List<Person>();

            try
            {
                command.CommandText = "SELECT * FROM TPersons";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Person p = new Person();

                    p.Id = Convert.ToInt32(reader["ID"].ToString());
                    p.Firstname = reader["firstname"].ToString();
                    p.Lastname = reader["lastname"].ToString();
                    p.Gender = reader["gender"].ToString();
                    p.Catagory = reader["catagory"].ToString();
                    p.Dob = reader["dob"].ToString();

                    personslist.Add(p);
                }

                return personslist;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

            public void Update(Person oldPerson, Person newPerson)
            {
                List<Person> personslist = new List<Person>();

            try
            {
                command.CommandText = "UPDATE Tpersons SET [FirstName]= '"+newPerson.Firstname +"', [LastName]= '"+newPerson.Lastname+"', [DOB] = '"+newPerson.Dob+"', [Gender] = '"+newPerson.Gender+"', [Position] = '"+newPerson.Position+"', [Catagory] = '"+newPerson.Catagory+"' WHERE [ID] = " +oldPerson.Id;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            }

            public void Delete(Person p)
            {
                try
            {
                command.CommandText = "DELETE FROM TPersons WHERE ID= "+p.Id;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            }
            }
        }



    

