﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Claims_Dept_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramUI program = new ProgramUI();
           // DataTable table = GetTable();
             program.Run();

          
           
        }

        //static DataTable GetTable()
        //{
        //    // Step 2: here we create a DataTable.
        //    // ... We add 4 columns, each with a Type.
        //    DataTable table = new DataTable();
        //    table.Columns.Add("Dosage", typeof(int));
        //    table.Columns.Add("Drug", typeof(string));
        //    table.Columns.Add("Diagnosis", typeof(string));
        //    table.Columns.Add("Date", typeof(DateTime));

        //    // Step 3: here we add rows.
        //    table.Rows.Add(25, "Drug A", "Disease A", DateTime.Now);
        //    table.Rows.Add(50, "Drug Z", "Problem Z", DateTime.Now);
        //    table.Rows.Add(10, "Drug Q", "Disorder Q", DateTime.Now);
        //    table.Rows.Add(21, "Medicine A", "Diagnosis A", DateTime.Now);
        //    return table;
        //}
    }
}
