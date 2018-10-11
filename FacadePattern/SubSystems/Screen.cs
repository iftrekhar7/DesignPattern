using System;

namespace FacadePattern.SubSystems
{
    public class Screen
    {
        internal void Down()
        {
            Console.WriteLine("Theater screen going down");
        }

        internal void Up()
        {
            Console.WriteLine("Theater screen going  up");
        }
    }

}
