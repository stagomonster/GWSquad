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
    public class SquadDatabase
    {
        static SQLiteAsyncConnection Database;


        public static readonly AsyncLazy<SquadDatabase> Instance = new AsyncLazy<SquadDatabase>(async () =>
        {
            var instance = new SquadDatabase();

            CreateTableResult result = await Database.CreateTableAsync<Squad>();
            _ = await Database.CreateTableAsync<Build>();
            return instance;
        });

        public SquadDatabase()
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }

        public Task<List<Squad>> GetItemsAsync()
        {
            //return Database.Table<Squad>().ToListAsync();
            return Database.GetAllWithChildrenAsync<Squad>(); //returning NULL (fixed, Build Table creation)
            //return Database.GetAllWithChildrenAsync<Squad>().FirstOrDefaultAsync();
        }

        public Task<List<Squad>> GettemsByName()
        {
            // SQL queries are also possible
            return Database.QueryAsync<Squad>("SELECT * FROM [Contact] WHERE [Name] = Bob");
        }

        public Task<Squad> GetItemAsync(int id)
        {
            //return Database.Table<Squad>().Where(i => i.Id == id).FirstOrDefaultAsync();
            return Database.GetWithChildrenAsync<Squad>(id);
            
        }

        public Task/*<int>*/ SaveItemAsync(Squad item)
        {
            
            if (item.Id != 0)
            {
                //return Database.UpdateAsync(item);
                Task s = Database.UpdateWithChildrenAsync(item); //task Method is null and the Task.Status is Faulted.
                return s;
                
                //return /*(Task<int>)*/Database.UpdateWithChildrenAsync(item);
                
                
            }
            else
            {
                return /*(Task<int>)*/Database.InsertWithChildrenAsync(item);
                //return Database.InsertOrReplaceWithChildrenAsync(item);
            }
        }
        

        public Task<int> DeleteItemAsync(Squad item)
        {
            return Database.DeleteAsync(item);
           
       
        }
        public Task<int> DeleteAllItemsAsync()
        {
            return Database.DeleteAllAsync<Squad>();
        }
        //https://stackoverflow.com/questions/32581955/using-textblobbed-in-sqlite-net-extensions
    }
}
