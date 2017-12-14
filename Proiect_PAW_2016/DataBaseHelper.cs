using System.Collections.Generic;
using System.Data.SQLite;

namespace Proiect_PAW
{
    public class DataBaseHelper
    {
        private SQLiteConnection conexiune = null;
        private const string NUME_BD = "DB.DB";
        private const string NUME_TABEL = "Detalii";
        private const string COLOANA_ID = "ID";
        private const string COLOANA_NUME = "Nume";
        private const string COLOANA_GEN = "Gen";
        private const string COLOANA_RECENZIE = "Recenzie";
        private const string COLOANA_VIZUALIZAT = "Vizualizat";
        private const string CREARE_TABEL = "CREATE TABLE " + NUME_TABEL + "(" + COLOANA_ID + " INTEGER PRIMARY KEY AUTOINCREMENT "
            + "," + COLOANA_NUME + " TEXT NOT NULL " + "," + COLOANA_GEN + " TEXT NOT NULL " + "," + COLOANA_RECENZIE + " TEXT NOT NULL "
            + "," + COLOANA_VIZUALIZAT + " TEXT NOT NULL " + ")" + ";";
        private const string INSERARE_INREGISTRARE_TABEL = "INSERT INTO " + NUME_TABEL + "(" + COLOANA_NUME + "," + COLOANA_GEN + ","
            + COLOANA_RECENZIE + "," + COLOANA_VIZUALIZAT + ")" + " VALUES " + "(" + "@" + COLOANA_NUME + "," + "@" + COLOANA_GEN + ","
            + "@" + COLOANA_RECENZIE + "," + "@" + COLOANA_VIZUALIZAT + ")" + ";";
        private const string STERGERE_INREGISTRARE_TABEL = "DELETE FROM " + NUME_TABEL + " WHERE " + COLOANA_NUME + "=" + "@" + COLOANA_NUME + ";";
        private const string STERGERE_TABEL = "DROP TABLE " + NUME_TABEL + ";";
        private const string ACTUALIZARE_INREGISTRARE = "UPDATE " + NUME_TABEL + " SET " + COLOANA_NUME + "=" + "@" + COLOANA_NUME + ","
            + COLOANA_GEN + "=" + "@" + COLOANA_GEN + "," + COLOANA_RECENZIE + "=" + "@" + COLOANA_RECENZIE + "," + COLOANA_VIZUALIZAT + "="
            + "@" + COLOANA_VIZUALIZAT + " WHERE " + COLOANA_NUME + "=" + "@" + "PARAM" + ";";
        private const string SELECTARE_INREGISTRARE = "SELECT * FROM " + NUME_TABEL + " WHERE " + COLOANA_NUME + "=" + "@" + COLOANA_NUME + ";";

        public DataBaseHelper()
        {
            if (this.conexiune != null)
            {
                this.conexiune.Close();
            }
            else
            {
                this.conexiune = new SQLiteConnection(@"Data Source = " + NUME_BD);
            }
        }

        public void CreareTabel()
        {
            if (this.conexiune != null)
            {
                try
                {
                    this.conexiune.Open();
                    SQLiteCommand sQLiteCommand = new SQLiteCommand(this.conexiune);
                    sQLiteCommand.CommandText = CREARE_TABEL;
                    sQLiteCommand.ExecuteNonQuery();
                    this.conexiune.Close();
                }
                catch (SQLiteException _Exception)
                {
                    Program.SalvareFisierLoguri(_Exception);
                    this.conexiune.Close();
                }
            }
        }

        public void StergereTabel()
        {
            if (this.conexiune != null)
            {
                try
                {
                    this.conexiune.Open();
                    SQLiteCommand sQLiteCommand = new SQLiteCommand(this.conexiune);
                    sQLiteCommand.CommandText = STERGERE_TABEL;
                    sQLiteCommand.ExecuteNonQuery();
                    this.conexiune.Close();
                }
                catch (SQLiteException _Exception)
                {
                    Program.SalvareFisierLoguri(_Exception);
                    this.conexiune.Close();
                }
            }
        }

        public void StergeInregistrare(Fisier _Fisier)
        {
            if (this.conexiune != null)
            {
                try
                {
                    this.conexiune.Open();
                    SQLiteCommand sQLiteCommand = new SQLiteCommand(this.conexiune);
                    sQLiteCommand.CommandText = STERGERE_INREGISTRARE_TABEL;
                    sQLiteCommand.Parameters.AddWithValue(COLOANA_NUME, _Fisier.GetNumeFisier());
                    sQLiteCommand.ExecuteNonQuery();
                    this.conexiune.Close();
                }
                catch (SQLiteException _Exception)
                {
                    Program.SalvareFisierLoguri(_Exception);
                    this.conexiune.Close();
                }
            }
        }

        public void InserareInregistrare(Fisier _Fisier)
        {
            if (this.conexiune != null)
            {
                try
                {
                    this.conexiune.Open();
                    SQLiteCommand sQLiteCommand = new SQLiteCommand(this.conexiune);
                    sQLiteCommand.CommandText = INSERARE_INREGISTRARE_TABEL;
                    sQLiteCommand.Parameters.AddWithValue(COLOANA_NUME, _Fisier.GetNumeFisier());
                    sQLiteCommand.Parameters.AddWithValue(COLOANA_GEN, _Fisier.GetGen());
                    sQLiteCommand.Parameters.AddWithValue(COLOANA_RECENZIE, _Fisier.GetRecenzie());
                    sQLiteCommand.Parameters.AddWithValue(COLOANA_VIZUALIZAT, _Fisier.GetVizualizat().ToString());
                    sQLiteCommand.ExecuteNonQuery();
                    this.conexiune.Close();
                }
                catch (SQLiteException _Exception)
                {
                    Program.SalvareFisierLoguri(_Exception);
                    this.conexiune.Close();
                }
            }
        }

        public List<string> SelectareInregistrare(Fisier _Fisier)
        {
            List<string> rating = new List<string>();
            if (this.conexiune != null)
            {
                try
                {
                    this.conexiune.Open();
                    SQLiteCommand sQLiteCommand = new SQLiteCommand(this.conexiune);
                    sQLiteCommand.CommandText = SELECTARE_INREGISTRARE;
                    sQLiteCommand.Parameters.AddWithValue(COLOANA_NUME, _Fisier.GetNumeFisier());
                    SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader();
                    while (sQLiteDataReader.Read())
                    {
                        string Gen = (string)sQLiteDataReader[COLOANA_GEN];
                        string Recenzie = (string)sQLiteDataReader[COLOANA_RECENZIE];
                        bool Vizualizat;
                        if ((sQLiteDataReader[COLOANA_VIZUALIZAT].ToString().ToLower()) == "true")
                        {
                            Vizualizat = true;
                        }
                        else
                        {
                            Vizualizat = false;
                        }
                        rating.Add(Gen);
                        rating.Add(Recenzie);
                        rating.Add(Vizualizat.ToString());
                    }
                    sQLiteDataReader.Close();
                    this.conexiune.Close();
                }
                catch (SQLiteException _Exception)
                {
                    Program.SalvareFisierLoguri(_Exception);
                    this.conexiune.Close();
                }
            }
            return rating;
        }

        public void ActualizareInregistrare(string _NumeVechiFisier, Fisier _Fisier)
        {
            if (this.conexiune != null)
            {
                try
                {
                    this.conexiune.Open();
                    SQLiteCommand sQLiteCommand = new SQLiteCommand(this.conexiune);
                    sQLiteCommand.CommandText = ACTUALIZARE_INREGISTRARE;
                    sQLiteCommand.Parameters.AddWithValue(COLOANA_NUME, _Fisier.GetNumeFisier());
                    sQLiteCommand.Parameters.AddWithValue(COLOANA_GEN, _Fisier.GetGen());
                    sQLiteCommand.Parameters.AddWithValue(COLOANA_RECENZIE, _Fisier.GetRecenzie());
                    sQLiteCommand.Parameters.AddWithValue(COLOANA_VIZUALIZAT, _Fisier.GetVizualizat().ToString());
                    sQLiteCommand.Parameters.AddWithValue("PARAM", _NumeVechiFisier);
                    sQLiteCommand.ExecuteNonQuery();
                    this.conexiune.Close();
                }
                catch (SQLiteException _Exception)
                {
                    Program.SalvareFisierLoguri(_Exception);
                    this.conexiune.Close();
                }
            }
        }
    }
}
