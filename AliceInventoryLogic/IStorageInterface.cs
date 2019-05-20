using System;
using System.Collections.Generic;
using System.Text;

namespace TestLogic
{
    //this interface implements the functions provided by the Alice skill given to the user
    interface IStorageInterface
    {
        void Add(Entry entry);
        void DeleteEntry(Entry entry);
        HashSet<Entry> ReadAll();
        void ClearAll();
    }
}