Installation
=================
To install this library, you can use the NuGet package by typing this line :
`Install-Package Pinch`

You may also need to install this package : 
`Install-Package Microsoft.Bcl.Async`

You can also use the package file that is in the root directory and manually install it.


Configuration
==================
To authenticate yourself :
````cs
using System;
using System.Threading.Tasks;
...
using pinch;

namespace MyNamespace
{
    class MyProgram
    {
        private static PinchClient client;

        static void Main(string[] args)
        {
            client = new PinchClient("MY_API_KEY", "myemail@example.com");
        }
    }
}

````

Issues
================
If you have any issues : https://github.com/Uelb/pinch-csharp/issues

Usage
================
For further documentation, please refer to [the documentation website](http://doc-company.inchbase.com/?cs)