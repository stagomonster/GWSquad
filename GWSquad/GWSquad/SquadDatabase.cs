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
            CreateTableResult result2 = await Database.CreateTableAsync<Build>();

            return instance;
        });

        public SquadDatabase()
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }

        public Task<List<Squad>> GetSquadsAsync()
        {
            return Database.Table<Squad>().ToListAsync();
            /*            return Database.GetAllAsync<Squad>();*/ //returning NULL (fixed, Build Table creation)
                                                                  //return Database.GetAllWithChildrenAsync<Squad>().FirstOrDefaultAsync();
        }

        public Task<List<Build>> GetBuildsAsync()
        {
            return Database.Table<Build>().ToListAsync();
            /*            return Database.GetAllAsync<Squad>();*/ //returning NULL (fixed, Build Table creation)
                                                                  //return Database.GetAllWithChildrenAsync<Squad>().FirstOrDefaultAsync();
        }
        //public Task<List<Squad>> GettemsByName()
        //{
        //    // SQL queries are also possible
        //    return Database.QueryAsync<Squad>("SELECT * FROM [Contact] WHERE [Name] = Bob");
        //}

        public Task<List<Build>> GetItemsByID(int id)
        {
            return Database.QueryAsync<Build>("SELECT * FROM [Build] WHERE [PublicID] = " + id.ToString());
        }

        public Task<Squad> SquadGetItemAsync(int id)
        {
            //return Database.Table<Squad>().Where(i => i.Id == id).FirstOrDefaultAsync();
            return Database.GetAsync<Squad>(id);
            
        }

        public Task<Build> BuildGetItemAsync(int id)
        {
            //return Database.Table<Squad>().Where(i => i.Id == id).FirstOrDefaultAsync();
            return Database.GetAsync<Build>(id);

        }

        public Task/*<int>*/ SaveItemAsync(Squad item)
        {
            
            if (item.Id != 0)
            {
                //return Database.UpdateAsync(item);
                Task s = Database.UpdateAsync(item); //task Method is null and the Task.Status is Faulted.
                return s;
                
                //return /*(Task<int>)*/Database.UpdateWithChildrenAsync(item);
                
                
            }
            else
            {
                return /*(Task<int>)*/Database.InsertAsync(item);
                //return Database.InsertOrReplaceWithChildrenAsync(item);
            }
        }

        public Task SaveItemAsync(Build item)
        {
            if (item.Id != 0)
            {
                //return Database.UpdateAsync(item);
                Task s = Database.UpdateAsync(item); //task Method is null and the Task.Status is Faulted.
                return s;

                //return /*(Task<int>)*/Database.UpdateWithChildrenAsync(item);


            }
            else
            {
                return /*(Task<int>)*/Database.InsertAsync(item);
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

        public Task<int> DeleteAllBuildAsync()
        {
            return Database.DeleteAllAsync<Build>();
        }
        //https://stackoverflow.com/questions/32581955/using-textblobbed-in-sqlite-net-extensions
    }
}
