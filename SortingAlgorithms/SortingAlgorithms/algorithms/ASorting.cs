using System;
using System.Diagnostics;

namespace SortingAlgorithms.algorithms
{
    public abstract class ASorting
    {
        // There is no point creating new Stopwatch every time 
        private static Stopwatch _stopwatch = new Stopwatch();
       
        // Constructor

        public abstract void Sort(int[] tab);    // this should be implemented in every class, that 'extends' this abstract class

        // Design and implement method which will measure time for given sorting methods (use polymorphism)
        // It should measure time and 'return' results of that measurement (i.e. write file, write on console, etc).
        
        
    }
}