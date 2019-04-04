using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string maths = "5 * 2";
            var value = EvalProvider
            Console.WriteLine(value);
            Console.ReadKey();
        }
        public double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
    }
}
