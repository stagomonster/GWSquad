using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLiteNetExtensions;
using SQLiteNetExtensionsAsync;
using SQLiteNetExtensionsAsync.Extensions;

namespace GWSquad
{
    public class SquadDatabase //mostly using the same template
    {
        static SQLiteAsyncConnection Database;


        public static readonly AsyncLazy<SquadDatabase> Instance = new AsyncLazy<SquadDatabase>(async () => //establish database
        {
            var instance = new SquadDatabase();

            CreateTableResult result = await Database.CreateTableAsync<Squad>(); //table for squad
            CreateTableResult result2 = await Database.CreateTableAsync<Build>(); //table for builds -> Preset Build Choices to Add to your squad.

            return instance;
        });

        public SquadDatabase() //Constructor
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }

        public Task<List<Squad>> GetSquadsAsync()//gets a list of the Squads in the Database.
        {
            var result = Database.Table<Squad>().ToListAsync();
            return result;

        }

        public Task<List<Build>> GetBuildsAsync() //gets a list of Builds in the Database.
        {
            var result = Database.Table<Build>().ToListAsync();
            return result;

        }


        public Task<List<Build>> GetItemsByID(int id) //New Method: Gets the Build with the Specified Public ID. This is NOT Autoincremented or uses the normal ID system.
                                                      //This is locally saved in the code. It is used to differentiate between preset builds without using autoincrement.
        {
            return Database.QueryAsync<Build>("SELECT * FROM [Build] WHERE [PublicID] = " + id.ToString());
        }

        public Task<Squad> SquadGetItemAsync(int id) //Not used currently.
        {
            return Database.GetAsync<Squad>(id);
            
        }

        public Task<Build> BuildGetItemAsync(int id) // Not used currently.
        {
            return Database.GetAsync<Build>(id);

        }

        public Task SaveItemAsync(Squad item) // Saving Squad item to database
        {
            
            if (item.Id != 0)
            {
                Task s = Database.UpdateAsync(item); 
                return s;
                
                
                
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task SaveItemAsync(Build item) //same for build
        {
            if (item.Id != 0)
            {
                Task s = Database.UpdateAsync(item); 
                return s;



            }
            else
            {
                return Database.InsertAsync(item);
            }
        }
        

        public Task<int> DeleteItemAsync(Squad item) //Delete Squad 
        {
            return Database.DeleteAsync(item);
           
       
        }
        public Task<int> DeleteAllItemsAsync() //Delete all Squad
        {
            return Database.DeleteAllAsync<Squad>();
        }

        public Task<int> DeleteAllBuildAsync() // Delete all Build
        {
            return Database.DeleteAllAsync<Build>();
        }
    }
}
