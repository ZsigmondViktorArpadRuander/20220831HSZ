using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ab
{
    internal static class ABKezelo
    {
        #region Adattagok
        static SqlConnection connection;
        static SqlCommand command;
        #endregion

        #region Alprogramok
        public static void Csatlakozas()
        {
            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection.Open();

                command = new SqlCommand();
                command.Connection = connection;
            }
            catch (Exception ex)
            {
                throw new ABKivetel("Sikertelen csatlakozas!", ex);
            }
        }

        public static void Lecsatlakozas()
        {
            try
            {
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                throw new ABKivetel("Sikertelen lecsatlakozas!", ex);
            }
        }

        public static List<Jarmu> JarmuvekKiolvasasa()
        {
            try
            {
                List<Jarmu> jarmuvek = new List<Jarmu>();

                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM [Jarmuvek] INNER JOIN [Autok] ON [Jarmuvek].[Rendszam] = [Autok].[Rendszam]";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        jarmuvek.Add(new Auto((AutoTipus)(int)reader["AutoTipus"], (double)reader["CsomagterL"], reader["Rendszam"].ToString(), reader["Gyarto"].ToString(), reader["Tipus"].ToString(), (double)reader["Hengerurtartalom"]));
                    }

                    reader.Close();
                }

                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM [Jarmuvek] INNER JOIN [Motorok] ON [Jarmuvek].[Rendszam] = [Motorok].[Rendszam]";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        jarmuvek.Add(new Motor((MotorTipus)(int)reader["MotorTipus"], reader["Rendszam"].ToString(), reader["Gyarto"].ToString(), reader["Tipus"].ToString(), (double)reader["Hengerurtartalom"]));
                    }

                    reader.Close();
                }

                return jarmuvek;
            }
            catch (Exception ex)
            {
                throw new ABKivetel("Sikertelen lekerdezes!", ex);
            }
        }

        public static void AutoFelvitel(Auto a)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "INSERT INTO [Jarmuvek] VALUES (@r, @g, @t, @h)";
                command.Parameters.AddWithValue("@r", a.Rendszam);
                command.Parameters.AddWithValue("@g", a.Gyarto);
                command.Parameters.AddWithValue("@t", a.Tipus);
                command.Parameters.AddWithValue("@h", a.Hengerurtartalom);

                command.ExecuteNonQuery();

                command.Parameters.Clear();
                command.CommandText = "INSERT INTO [Autok] VALUES (@r, @a, @c)";
                command.Parameters.AddWithValue("@r", a.Rendszam);
                command.Parameters.AddWithValue("@a", (int)a.AutoTipus);
                command.Parameters.AddWithValue("@c", a.CsomagterL);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ABKivetel("Sikertelen felvitel!", ex);
            }
        }

        public static void MotorFelvitel(Motor m)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "INSERT INTO [Jarmuvek] VALUES (@r, @g, @t, @h)";
                command.Parameters.AddWithValue("@r", m.Rendszam);
                command.Parameters.AddWithValue("@g", m.Gyarto);
                command.Parameters.AddWithValue("@t", m.Tipus);
                command.Parameters.AddWithValue("@h", m.Hengerurtartalom);

                command.ExecuteNonQuery();

                command.Parameters.Clear();
                command.CommandText = "INSERT INTO [Motorok] VALUES(@r, @m, @j)";
                command.Parameters.AddWithValue("@r", m.Rendszam);
                command.Parameters.AddWithValue("@m", (int)m.MotorTipus);
                command.Parameters.AddWithValue("@j", m.Jogositvany);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ABKivetel("Sikertelen felvitel!", ex);
            }
        }

        public static void AutoTorles(Auto a)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "DELETE FROM [Autok] WHERE [Rendszam] = @r";
                command.Parameters.AddWithValue("@r", a.Rendszam);

                command.ExecuteNonQuery();

                command.Parameters.Clear();
                command.CommandText = "DELETE FROM [Jarmuvek] WHERE [Rendszam] = @r";
                command.Parameters.AddWithValue("@r", a.Rendszam);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ABKivetel("Sikertelen torles!", ex);
            }
        }

        public static void MotorTorles(Motor m)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "DELETE FROM [Motorok] WHERE [Rendszam] = @r";
                command.Parameters.AddWithValue("@r", m.Rendszam);

                command.ExecuteNonQuery();

                command.Parameters.Clear();
                command.CommandText = "DELETE FROM [Jarmuvek] WHERE [Rendszam] = @r";
                command.Parameters.AddWithValue("@r", m.Rendszam);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ABKivetel("Sikertelen torles!", ex);
            }
        }

        public static void AutoModositas(Auto a)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "UPDATE [Autok] SET [CsomagterL] = @c WHERE [Rendszam] = @r";
                command.Parameters.AddWithValue("@c", a.CsomagterL);
                command.Parameters.AddWithValue("@r", a.Rendszam);

                command.ExecuteNonQuery();

                command.Parameters.Clear();
                command.CommandText = "UPDATE [Jarmuvek] SET [Gyarto] = @g, [Tipus] = @t, [Hengerurtartalom] = @h WHERE [Rendszam] = @r";
                command.Parameters.AddWithValue("@g", a.Gyarto);
                command.Parameters.AddWithValue("@t", a.Tipus);
                command.Parameters.AddWithValue("@h", a.Hengerurtartalom);
                command.Parameters.AddWithValue("@r", a.Rendszam);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ABKivetel("Sikertelen modositas!", ex);
            }
        }

        public static void MotorModositas(Motor m)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "UPDATE [Motorok] SET [Jogostivany] = @j WHERE [Rendszam] = @r";
                command.Parameters.AddWithValue("@j", m.Jogositvany);
                command.Parameters.AddWithValue("@r", m.Rendszam);

                command.ExecuteNonQuery();

                command.Parameters.Clear();
                command.CommandText = "UPDATE [Jarmuvek] SET [Gyarto] = @g, [Tipus] = @t, [Hengerurtartalom] = @h WHERE [Rendszam] = @r";
                command.Parameters.AddWithValue("@g", m.Gyarto);
                command.Parameters.AddWithValue("@t", m.Tipus);
                command.Parameters.AddWithValue("@h", m.Hengerurtartalom);
                command.Parameters.AddWithValue("@r", m.Rendszam);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ABKivetel("Sikertelen modositas!", ex);
            }
        }

        public static void ABUrites()
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "DELETE FROM [Motorok]";

                command.ExecuteNonQuery();

                command.Parameters.Clear();
                command.CommandText = "DELETE FROM [Autok]";

                command.ExecuteNonQuery();

                command.Parameters.Clear();
                command.CommandText = "DELETE FROM [Jarmuvek]";

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ABKivetel("Sikertelen urites!", ex);
            }
        }
        #endregion
    }
}
