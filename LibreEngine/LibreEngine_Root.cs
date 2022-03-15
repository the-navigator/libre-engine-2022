using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


using System.Data;  


namespace LibreEngine_Root;
public class LibreEngine
{
    public static string databaseName; //Since this is designed to be flexible, it will adapt to the database name
    static string  connectionString = "DataSource=" +
     Environment.CurrentDirectory + "\\" + databaseName; 
// Setting up some variables for the Datbase Connection
    
    SQLiteConnection databaseCn = new SQLiteConnection(connectionString);
    SQLiteCommand databaseCommand = new SQLiteCommand();
    SQLiteDataAdapter libreDataAdapter = new SQLiteDataAdapter();
    public DataTable libreDataTable = new DataTable();

    public int rowcount;

     string tableSource = "ResourceDB";
        
    
    public void locateDatabase (string CurrentLocation)
    {

       databaseCn.Open();   
       libreDataAdapter = new SQLiteDataAdapter("SELECT * FROM [ResourceDB]", databaseCn);

       libreDataAdapter.Fill(libreDataTable);
       rowcount = libreDataTable.Rows.Count;
       databaseCn.Close();


    }
    
}
    