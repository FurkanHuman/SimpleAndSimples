using System;

namespace SimpleAndSimples_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie 
            {Name="Demir Adam",MoveYear=2008, FileName="İron Men(2008)", 
                Id=1, IMDBRate=8.2, SeriesOfMovie=true};
            

            IMoviesService moviesM = new MovieManager();
            moviesM.Add(movie1);
        }
    }
}
