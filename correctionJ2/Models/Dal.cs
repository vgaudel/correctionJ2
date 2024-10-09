using System;
using System.Collections.Generic;
using System.Linq;

namespace correctionJ2.Models
{
    public class Dal : IDal
    {
        private BddContext _bddContext;

        public Dal()
        {
            _bddContext = new BddContext();
        }

        public void DeleteCreateDatabase()
        {
            _bddContext.Database.EnsureDeleted(); // vérifie si la base de données existe et si oui, on la supprime
            _bddContext.Database.EnsureCreated(); // vérifie si la base de données n'existe pas et si c'est le cas, on la créé
        }

        public List<Film> ObtenirTousLesFilms()
        {
            return _bddContext.Films.ToList();
        }

        public int CreerFilm(string titre, int année, string realisateur, bool visionne)
        {
            Film film = new Film() { Titre = titre , 
                Année = année,
                Realisateur = realisateur,  
                Visionne = visionne
            }; 
            this._bddContext.Films.Add(film);
            this._bddContext.SaveChanges();
            Console.WriteLine("Id unique du fil ajouté " + film.Id);
            return film.Id;
        }

        public void UpdateFilm(int id, string titre, int année, string realisateur, bool visionne)
        {
            Film oldFilm = this._bddContext.Films.Find(id);
            if (oldFilm != null)
            {
                oldFilm.Titre = titre;
                oldFilm.Année = année;
                oldFilm.Realisateur = realisateur;
                oldFilm.Visionne = visionne;
                this._bddContext.SaveChanges(); 
            }
        }

        public void DeleteFilm(int id)
        {
            Film oldFilm = this._bddContext.Films.Find(id);
            if (oldFilm != null)
            {
                _bddContext.Films.Remove(oldFilm);
                _bddContext.SaveChanges();
            }
        }

        public void InitializeDB()
        {
            this.DeleteCreateDatabase();
            CreerFilm("Avatar", 2009, "James Cameron", false);
            CreerFilm("Forest Gump", 1994, "Robert Zemeckis", false);
            CreerFilm("Le Parrain", 1972, "Francis Ford Coppola", true);
            CreerFilm("Vacances à Quimper été 2020", 2020, "Vincent Gaudel", false);
            CreerFilm("Vacances à Chamonix, hivers 2018, Le retour du Yéti", 2014, "Jason Revillard", true);

            UpdateFilm(4, "Vacances à Quimper été 2020", 2019, "Vincent Gaudel", false);
            //DeleteFilm(4);
        }

        public void Dispose()
        {
            _bddContext.Dispose();
        }
    }
}
