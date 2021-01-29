using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAndSimples_1
{
    class MovieManager : IMoviesService
    {
        public void Add(Movie movie)
        {
            Console.WriteLine(movie.Name+"("+movie.MoveYear+")"+" Adlı Film Kütüphaneye Eklenmiştir ");
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void ListOf(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
