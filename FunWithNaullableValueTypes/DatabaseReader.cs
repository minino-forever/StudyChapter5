using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithNaullableValueTypes
{
    internal class DatabaseReader
    {
        public int? numericValue = null;

        public bool? boolValue = true;

        public int? GetIntFromDatabase()
        {
            return numericValue;
        }

        public bool? GetBoolFromDatebase()
        {
            return boolValue;
        }
    }
}
