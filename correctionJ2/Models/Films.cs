using System.Collections.Generic;

namespace correctionJ2.Models
{
    public class Films
    {
        public static List<Film> ObtenirFilms()
        {
            return new List<Film>()
            {
                new Film() { Titre = "Avatar", Année = 2009, Realisateur="James Cameron", Visionne=false},
                new Film() { Titre = "Forest Gump", Année = 1994, Realisateur="Robert Zemeckis", Visionne=false},
                new Film() { Titre = "Le Parrain", Année = 1972, Realisateur="Francis Ford Coppola", Visionne=true},
                new Film() { Titre = "Vacances à Quimper été 2020", Année = 2020, Realisateur="Vincent Gaudel", Visionne=false}
            };
        }
    }
}
