# GenericCastExample

Simple example of dealing with \<generic> type casting, using `explicit` cast `operator`.

Our guests today are

```csharp
FooBar<Foo> fooBarishFoo;
FooBar<Bar> fooBarishBar;
FooBar<object> fooBarishObject;
```

Program output:

    Stage 1. List of FooBar'ish Bars
    I'm Bar
    I'm Bar
    I'm Bar
    I'm Bar

    Stage 2. List of FooBar'ish Foos
    I'm Foo
    I'm Foo
    I'm Foo
    I'm Foo

    Stage 3. List of FooBar'ish objects
    I'm Bar
    I'm Foo
    I'm Bar
    I'm Bar

    Stage 4. Checking if FooBar'ish Bars are FooBar'ish Bars
    True
    True
    True
    True

    Stage 5. Checking if FooBar'ish Foos are FooBar'ish Bars
    False
    False
    False
    False

    Stage 6. [Good way] Checking if FooBar'ish objects are FooBar'ish Foos
    False
    True
    False
    False

## Environment

This project is built with **Visual Studio 2022** and uses **.NET 6.0** as its target framework.
