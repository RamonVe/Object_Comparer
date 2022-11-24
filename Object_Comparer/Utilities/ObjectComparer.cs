using Object_Comparer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8601 // Possible null reference assignment.

namespace Object_Comparer.Utilities {
    public static class ObjectComparer {
        public static List<Difference> CompareWith<T>(this T object1, T object2) {
            List<Difference> differences = new();
            FieldInfo[] fieldInfos = object1.GetType().GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            
            foreach (FieldInfo fieldInfo in fieldInfos) {
                var objectFieldName = fieldInfo.Name.Replace("<", "").Replace(">k__BackingField", "");

                Difference difference = new() {
                    ObjectFieldName = objectFieldName,
                    ObjectValue1 = fieldInfo.GetValue(object1),
                    ObjectValue2 = fieldInfo.GetValue(object2)
                };

                if (!Equals(difference.ObjectValue1, difference.ObjectValue2)) {
                    differences.Add(difference);
                }
            }
            return differences;
        }
    }
}
