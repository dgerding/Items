using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Items.DataStores
{
    public interface IDataStore<T>
    {
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string id);
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
        
        /// <summary>
        /// True if this DataStore is accessing persistence runtime local to client runtime and does not require Internet connection, i.e., ItemSQLiteDataStore. 
        /// </summary>
        bool IsLocal();
    }
}
