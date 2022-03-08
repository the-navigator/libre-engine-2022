using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.Data.SQLite;
using System.Data;  


namespace LibreEngine_Root;
public class LibreEngine
{
    public static string databaseName; //Since this is designed to be flexible, it will adapt to the database name
    static string  connectionString = "DataSource=" +
     Environment.CurrentDirectory + "\\" + databaseName; 

    SQLiteConnection databaseCn = new SQLiteConnection(connectionString);
    
    public static void locateDatabase (string CurrentLocation)
    {

        

    }
    
}
    