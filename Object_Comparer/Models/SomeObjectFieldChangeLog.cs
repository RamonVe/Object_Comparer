using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Comparer.Models {
    public class SomeObjectFieldChangeLog {
        public long SomeObjectFieldChangeLogId { get; set; }
        public long SomeObjectId { get; set; }
        public string? SomeObjectFieldName { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public DateTime ChangeDateTime { get; set; }
    }
}
