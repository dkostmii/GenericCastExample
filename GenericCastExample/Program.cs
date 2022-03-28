
var listOfBars = new List<FooBar<Bar>>()
{
    new FooBar<Bar>(new Bar()),
    new FooBar<Bar>(new Bar()),
    new FooBar<Bar>(new Bar()),
    new FooBar<Bar>(new Bar())
};
var listOfFoos = new List<FooBar<Foo>>()
{
    new FooBar<Foo>(new Foo()),
    new FooBar<Foo>(new Foo()),
    new FooBar<Foo>(new Foo()),
    new FooBar<Foo>(new Foo())
};
var listOfObjects = new List<FooBar<object>>()
{
    new FooBar<object>(new Bar()),
    new FooBar<object>(new Foo()),
    new FooBar<object>(new Bar()),
    new FooBar<object>(new Bar())
};

Console.WriteLine("Stage 1. List of FooBar'ish Bars");
Console.WriteLine(listOfBars.Select(fooBar => fooBar.ToString()).Aggregate("", (acc, val) => $"{acc}{val}\n"));
Console.WriteLine("Stage 2. List of FooBar'ish Foos");
Console.WriteLine(listOfFoos.Select(fooBar => fooBar.ToString()).Aggregate("", (acc, val) => $"{acc}{val}\n"));
Console.WriteLine("Stage 3. List of FooBar'ish objects");
Console.WriteLine(listOfObjects.Select(fooBar => fooBar.ToString()).Aggregate("", (acc, val) => $"{acc}{val}\n"));

Console.WriteLine("Stage 4. Checking if FooBar'ish Bars are FooBar'ish Bars");
Console.WriteLine(listOfBars.Select(foobar => ((FooBar<Bar>?)(FooBar<object>)foobar is FooBar<Bar>).ToString()).Aggregate("", (acc, val) => $"{acc}{val}\n"));

Console.WriteLine("Stage 5. Checking if FooBar'ish Foos are FooBar'ish Bars");
Console.WriteLine(listOfFoos.Select(foobar => ((FooBar<Bar>?)(FooBar<object>)foobar is FooBar<Bar>).ToString()).Aggregate("", (acc, val) => $"{acc}{val}\n"));

// Uses explicit cast operator in FooBar<T> class
Console.WriteLine("Stage 6. [Good way] Checking if FooBar'ish objects are FooBar'ish Foos");
Console.WriteLine(listOfObjects.Select(foobar => ((FooBar<Foo>?)foobar is FooBar<Foo>).ToString()).Aggregate("", (acc, val) => $"{acc}{val}\n"));

// Does not
// Throws InvalidCastException
/*
Console.WriteLine("Stage 7. [Wrong way] Checking if FooBar'ish objects are FooBar'ish Foos");
Console.WriteLine(listOfObjects.Cast<FooBar<Foo>?>().Select(foobar => (foobar is FooBar<Foo>).ToString()).Aggregate("", (acc, val) => $"{acc}{val}\n"));
*/

