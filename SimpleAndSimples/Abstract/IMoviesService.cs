using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAndSimples_1
{
    interface IMoviesService
    {
        void Add(Movie movie);
        void Delete();
        void Update();
        void ListOf(Movie movie);
    }
}
