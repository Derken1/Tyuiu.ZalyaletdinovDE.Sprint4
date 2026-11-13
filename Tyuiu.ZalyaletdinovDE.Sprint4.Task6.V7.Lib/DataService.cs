using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZalyaletdinovDE.Sprint4.Task6.V7.Lib
{
    public class DataService : ISprint4Task6V7
    {
        public int Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, x => x.Length > 8);
            return mas.Length;
        }
    }
}