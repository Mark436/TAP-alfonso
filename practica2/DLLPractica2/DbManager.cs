using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DLLPractica2
{
    public class DbManager
    {
        private static string wholeText = null;
        public static string Text { get { return wholeText; } }
        private static DataTable dataTable = null;
        public static DataTable Table { get { return dataTable; } }
        public static void readFile(string path)
        {
            wholeText = File.ReadAllText(path);
            string[] lines = File.ReadAllLines(path);
            DataTable table=new DataTable();

            table.Columns.Add("ID",typeof(int));
            table.Columns.Add("Nombre Completo",typeof(string));
            table.Columns.Add("Telefono",typeof(string));

            foreach (string data in lines )
            {
                string[] usuarioData=data.Split(',');
                if (usuarioData.Length < 5) continue;
                string telefono = Regex.Replace(usuarioData[4].Trim(),"[^0-9]","");
                string nombre = usuarioData[2];
                string apellido = usuarioData[1];
                int id = int.Parse(usuarioData[0]);
                table.Rows.Add(id, nombre + " " + apellido, telefono);
            }
            dataTable = table;
        }
    }
}
