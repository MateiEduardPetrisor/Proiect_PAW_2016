using System;
using System.IO;
using System.Windows.Forms;

namespace Proiect_PAW
{
    static class Program
    {
        public static void SalvareFisierLoguri(Exception _Exception)
        {
            try
            {
                String TimeStamp = DateTime.Now.ToString();
                StreamWriter streamWriter = new StreamWriter("Logs.txt", true);
                streamWriter.Write(TimeStamp);
                streamWriter.Write(_Exception.Message);
                streamWriter.WriteLine();
                streamWriter.Flush();
                streamWriter.Close();
            }
            catch (UnauthorizedAccessException _UnauthorizedAccessException)
            {
                MessageBox.Show("Nu Aveti Drepturi Read/Write Asupra Folderului In Care Se Afla Aplicatia!\n" + _UnauthorizedAccessException.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Proiect_PAWForm());
        }
    }
}
