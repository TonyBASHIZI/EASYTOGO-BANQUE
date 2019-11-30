
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyToGoBq.Forms;

using System.Collections;

namespace EasyToGoBq.Classes
{
    public class Glossaire
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        Connection cnx;
        MySqlDataAdapter dt = null;
        MySqlDataReader dr = null;
        MySqlDataAdapter adpr = null;
        DataSet dste;
        private string server;
        private string database;
        private string uid;
        private string password;

        private string port;
        // private string str, code_isn;
        private static Glossaire _instance = null;

        public static Glossaire Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Glossaire();
                return _instance;
            }
        }

        #region Common

        public void InitializeConnection()
        {
            try
            {
                cnx = new Connection(); cnx.Connect();
                con = new MySqlConnection(cnx.path);

                if (!con.State.ToString().ToLower().Equals("open"))
                {
                    con.Open();
                }
            }
            catch (Exception)
            {
                
                //FormProgress re = new FormProgress();
                //re.ShowDialog();
            }

        }


        private void SetParameter(IDbCommand cmd, string name, DbType type, int length, object value)
        {
            IDbDataParameter param = cmd.CreateParameter();

            param.ParameterName = name;
            param.DbType = type;
            param.Size = length;

            if (value == null)
            {
                if (!param.IsNullable)
                {
                    param.DbType = DbType.String;
                }

                param.Value = DBNull.Value;
            }
            else
            {
                param.Value = value;
            }

            cmd.Parameters.Add(param);
        }

        public void GetDatas(DataGridView grid, string field, string table)
        {
           

            try
            {
                InitializeConnection();
                using (cmd = con.CreateCommand())
                {
                    cmd.CommandText = " SELECT " + field + " FROM " + table + " ORDER BY id DESC ";
                    dt = new MySqlDataAdapter((MySqlCommand)cmd);
                    DataSet ds = new DataSet();
                    dt.Fill(ds);
                    grid.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors du chargement des données. \n\nL'Application va s'arrêter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Une erreur s'est produite lors de l'opération : " + ex.Message);
                Application.Exit();
                // MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        public void GetCombosData(ComboBox combo, string field, string table)
        {
            combo.Items.Clear();

            InitializeConnection();

            try
            {
                using (cmd = con.CreateCommand())
                {
                    cmd.CommandText = " SELECT " + field + " FROM " + table;

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        combo.Items.Add(dr[field]).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors du chargement des données. \n\nL'Application va s'arrêter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Une erreur s'est produite lors de l'opération : " + ex.Message);
                Application.Exit();
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Dispose();
            }
        }

        public string getCommission()
        {

            string c = "";
            try
            {

                InitializeConnection();

                string q = "select SUM(commission) as nb from transaction";
                cmd = new MySqlCommand(q, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = dr.GetString("nb");
                }
                else
                {
                    c = "00";
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }


            return c;
        }

        public string getTransact()
        {

            string c = "";
            try
            {

                InitializeConnection();

                string q = "select SUM(fraisTransact) as nb from transaction";
                cmd = new MySqlCommand(q, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = dr.GetString("nb");
                }
                else
                {
                    c = "00";
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }


            return c;
        }

        public string getOperation()
        {

            string c = "";
            try
            {

                InitializeConnection();

                string q = "select SUM(montant) as nb from transaction";
                cmd = new MySqlCommand(q, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = dr.GetString("nb");
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }


            return c;
        }
        public string getOperas(string filt)
        {

            string c = "";
            try
            {

                InitializeConnection();

                string q = "SELECT COUNT(id) as nb FROM `transaction` WHERE montant = '" + filt + "'";
                cmd = new MySqlCommand(q, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = dr.GetString("nb");
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }


            return c;
        }

        public string getCompagnieEtbq()
        {

            string c = "";
            try
            {

                InitializeConnection();

                string q = "select SUM(solde) as nb from compte";
                cmd = new MySqlCommand(q, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = dr.GetString("nb");
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }


            return c;
        }

        public User LoginTest(string username, string password)
        {
            User user = null;

            try
            {
                InitializeConnection();

                cmd = new MySqlCommand("SELECT *  FROM banque where noms ='" + username + "' AND mot_de_passe = '" + password + "'", con);

                dr = cmd.ExecuteReader();
                

                if (dr.Read())
                {
                    //MessageBox.Show("OKKKK");
                    user = new User
                    {
                        IdSession = Convert.ToInt32(dr["id"]),
                        UsernameSession = dr["noms"].ToString(),
                        PasswordSession = dr["mot_de_passe"].ToString()
                    };
                }

               
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }

            return user;
        }
        public DataSet sortietCompte()
        {

            try
            {
                InitializeConnection();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();

                cmd = new MySqlCommand("SELECT designation,description,ref_compagnie,solde from compte", con);
                //cmd = new MySqlCommand("SELECT * from transact ", con);
                adpr = new MySqlDataAdapter(cmd);
                dste = new DataSet();
                adpr.Fill(dste, "compte");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors du chargement des données. \n\nL'Application va s'arrêter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Une erreur s'est produite lors de l'opération : " + ex.Message);
                Application.Exit();
                //MessageBox.Show(ex.Message);
            }

            return dste;
        }

        /// <summary>
        /// Modifier le mot de passe de utilisateur de la banque
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool UpdateUser(User user)
        {
            InitializeConnection();

            using (cmd = con.CreateCommand())
            {
                if (user.Id == 0)
                {
                    cmd.CommandText = "UPDATE `easy_to_go`.`banque` SET `mot_de_passe` = @password " +
                        " WHERE `id` = @idUser; ";

                    SetParameter(cmd, "@idUser", DbType.Int32, 10, User.Instance.IdSession);
                    SetParameter(cmd, "@password", DbType.String, 255, user.Password);
                }

                return cmd.ExecuteNonQuery() != 0 ? true : false;
            }
        }

        public DataSet sortieTransfert()
        {

            try
            {
                InitializeConnection();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();

                cmd = new MySqlCommand("SELECT designation,description,ref_compagnie,solde from compte", con);
                //cmd = new MySqlCommand("SELECT * from transact ", con);
                adpr = new MySqlDataAdapter(cmd);
                dste = new DataSet();
                adpr.Fill(dste, "compte");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dste;
        }

        public string getTotalRecharge()
        {
            string c = "";
            try
            {

                InitializeConnection();

                string q = "select SUM(montant) as nb from rechargehistory";
                cmd = new MySqlCommand(q, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = dr.GetString("nb");
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }


            return c;
        }
        public string getSoldes()
        {
            double rach = double.Parse(getTotalRecharge());
            double opera = double.Parse(getOperation());

            double solde = rach - opera;


            return "" + solde;
        }

        public string getA(string compagnie)
        {
            string c = "";
            try
            {

                InitializeConnection();

                string q = "select SUM(solde) as nb where designation='" + compagnie + "'from agent";
                cmd = new MySqlCommand(q, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = dr.GetString("nb");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }


            return c;

        }

        public string getAgence(string compagnie)
        {
            string c = "";
            try
            {

                InitializeConnection();

                string q = "select solde as nb from compte where designation ='" + compagnie + "'";
                cmd = new MySqlCommand(q, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = dr.GetString("nb");
                }
                else
                {
                    c = "00";
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }


            return c;
        }

        public void Recharge(string code, string montant)
        {

            

            InitializeConnection();
            try
            {
                string q = "update agent set solde=@solde where matricule=@matricule";
                cmd = new MySqlCommand(q, con);
                cmd.Parameters.Add(new MySqlParameter("@matricule", code));
                cmd.Parameters.Add(new MySqlParameter("@solde", montant));


                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Recharge effectué avec succes!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }

        }
        public void Recherche(DataGridView data, string code)
        {

            InitializeConnection();

            
            try
            {
                using (cmd = con.CreateCommand())
                {

                    cmd.CommandText = " SELECT * FROM  agent WHERE matricule LIKE '%" + code + "%' or nom LIKE '%" + code + "%' ";
                    dt = new MySqlDataAdapter((MySqlCommand)cmd);
                    DataSet ds = new DataSet();
                    dt.Fill(ds);
                    data.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();

            }

        }

        public string Trajet(string prix)
        {
            string retour = "0";
            try
            {
                InitializeConnection();
                string q = "SELECT COUNT(id) as nb FROM transaction WHERE montant = '" + prix + "'";
                cmd = new MySqlCommand(q, con);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    retour = dr.GetString("nb");
                }
                

            }catch(Exception ex)
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }

            return retour;
        }

      
       // 
        #endregion
    }
}