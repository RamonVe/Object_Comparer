// See https://aka.ms/new-console-template for more information
using Object_Comparer;
using Object_Comparer.Models;
using Object_Comparer.Utilities;

using (var context = new Object_ComparerContext()) {
    // Adding SomeObject
    //SomeObject someObject = new SomeObject {
    //    SomeObjectName = "ipsum",
    //    SomeObjectValue = 1
    //};

    //context.SomeObjects.Add(someObject);
    //context.SaveChanges();

    var fooObject = context.SomeObjects.First(someObject => someObject.SomeObjectId == 1);
    var fooObjectUpdate = new SomeObject {
        SomeObjectId = 1,
        SomeObjectName = "foo",
        SomeObjectValue = 2
    };

    fooObject.CompareWith(fooObjectUpdate);
}