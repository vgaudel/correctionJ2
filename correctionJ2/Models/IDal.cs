using System;
using System.Collections.Generic;

namespace correctionJ2.Models
{
    public interface IDal : IDisposable
    {
        void DeleteCreateDatabase();
        List<Film> ObtenirTousLesFilms();
    }
}
