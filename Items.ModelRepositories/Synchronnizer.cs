using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Items.DataStores
{
    /// <summary>
    /// Performs synchronization between two iDataStore repositories of common Type .
    /// </summary>
    public class Synchronizer<T>
    {
        /// <summary>
        /// 
        /// </summary>
        public async Task<bool> Sync(IDataStore<T> fromStore, IDataStore<T> toStore)
        {
            return true;
        }
        
    }
}
