internal class FooBar<T> where T : class
{
    // generic class with explicit cast operatos
    // to FooBar<object> and to another generic type FooBar<T>


    private T fooOrBar;

    public FooBar(T fooOrBar)
    {
        this.fooOrBar = fooOrBar;
    }

    public override string ToString()
    {
        Foo? foo = fooOrBar as Foo;
        Bar? bar = fooOrBar as Bar;

        if (foo is not null)
        {
            return foo.ToString();
        }

        else if (bar is not null)
        {
            return bar.ToString();
        }

        return "I don't know, which I am :(";
    }

    // nullable cast operator from base type
    public static explicit operator FooBar<T>?(FooBar<object> v)
    {
        T? t = v.fooOrBar as T;

        if (t is null)
            return null;

        return new FooBar<T>(t);
    }

    // cast operator to base type
    public static explicit operator FooBar<object>(FooBar<T> v)
    {
        return new FooBar<object>(v.fooOrBar);

        // The wrong way
        // return v as FooBar<object>;
    }
}
