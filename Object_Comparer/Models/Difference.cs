using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Comparer.Models {
    public class Difference {
        public string ObjectFieldName { get; set; }
        public object ObjectValue1 { get; set; }
        public object ObjectValue2 { get; set; }
    }
}
