using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_butów
{
    public enum KindOfDuck
    {
        Mallord,
        Muscovy,
        Decoy
    }
   public class Duck:Ptak, IComparable<Duck>
    {
        public int size { get; set; }
        public KindOfDuck Kind { get; set; }

        public int CompareTo(Duck ducktoCompare)
        {
            if (this.size > ducktoCompare.size)
                return 1;
            else if (this.size < ducktoCompare.size)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return this.size.ToString() + "-centymetrowa kaczka " + this.Kind.ToString();
        }



    }

    public class DuckComparerBySize:IComparer<Duck>
    {
        public int Compare(Duck x,Duck y)
        {
            if (x.size < y.size)
                return -1;
            if (x.size > y.size)
                return 1;
            return 0;
        }


    }
}
