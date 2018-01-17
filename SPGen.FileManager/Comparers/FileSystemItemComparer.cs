using System.Collections.Generic;
using SPGen.FileManager.Models;

namespace SPGen.FileManager.Comparers
{
    internal class FileSystemItemComparer : IEqualityComparer<Item>
    {
        public bool Equals(Item f1, Item f2)
        {
            return f1?.GetHashCode() == f2?.GetHashCode();
        }

        // Return a hash that reflects the comparison criteria. According to the   
        // rules for IEqualityComparer<T>, if Equals is true, then the hash codes must  
        // also be equal. Because equality as defined here is a simple value equality, not  
        // reference identity, it is possible that two or more objects will produce the same  
        // hash code.  
        public int GetHashCode(Item fi)
        {
            return fi.Path.GetHashCode();
        }
    }
}