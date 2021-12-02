using System;
using System.IO;
namespace MoviesFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static string[] getMoviesFromfile()
        {
            string FilePath = @"C:\Users\opilane\samples\LOGITpe21\Movies.txt";
            string[] dataFromFile = File.ReadAllLines(FilePath);

            return dataFromFile;

        }
        public static void ShowDataFromArray(string[] someArray)
        {
          foreach (string line in someArray)
          {        
             Console.WriteLine(line);
          }
           
        }   
    
    }

}        
    

