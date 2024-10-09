using correctionJ2.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTestFilms
{
    [Collection("Sequential")]
    public class UnitTestFilmBDD
    {
        [Fact]
        public void TestAjoutFilm()
        {
            //pr�paration
            using (Dal dal = new Dal())
            {
                //Nous supprimons et cr�ons la DB avant le test
                dal.DeleteCreateDatabase();
                //action
                dal.CreerFilm("Vacances � Chamonix, hivers 2018, Le retour du Y�ti", 2014, "Jason Revillard", true);
                //v�rification du r�sultat
                List<Film> films = dal.ObtenirTousLesFilms();
                Assert.NotNull(films);
                Assert.Single(films);
                Assert.Equal(2014,films[0].Ann�e);
                Assert.Equal("Vacances � Chamonix, hivers 2018, Le retour du Y�ti", films[0].Titre);
                Assert.Equal("Jason Revillard", films[0].Realisateur);
                Assert.True(films[0].Visionne);
                //nettoyage
                dal.DeleteCreateDatabase();
            }

        }
        [Fact]
        public void TestAjoutFilm2()
        {
            //pr�paration
            using (Dal dal = new Dal())
            {
                //Nous supprimons et cr�ons la DB avant le test
                dal.DeleteCreateDatabase();
                //action
                dal.CreerFilm("Vacances � Chamonix, hivers 2017, Rencontre avec le Y�ti", 2017, "Jason Revillard", true);
                //v�rification du r�sultat
                List<Film> films = dal.ObtenirTousLesFilms();
                Assert.NotNull(films);
                Assert.Single(films);
                Assert.Equal(2017, films[0].Ann�e);
                Assert.Equal("Vacances � Chamonix, hivers 2017, Rencontre avec le Y�ti", films[0].Titre);
                Assert.Equal("Jason Revillard", films[0].Realisateur);
                Assert.True(films[0].Visionne);
                //nettoyage
                dal.DeleteCreateDatabase();
            }

        }

        [Fact]
        public void TestAjoutFilm3()
        {
            //pr�paration
            using (Dal dal = new Dal())
            {
                //Nous supprimons et cr�ons la DB avant le test
                dal.DeleteCreateDatabase();
                //action
                dal.CreerFilm("Vacances � Chamonix, hivers 2018, Le retour du Y�ti", 2014, "Jason Revillard", true);
                //v�rification du r�sultat
                List<Film> films = dal.ObtenirTousLesFilms();
                Assert.NotNull(films);
                Assert.Single(films);
                Assert.Equal(2014, films[0].Ann�e);
                Assert.Equal("Vacances � Chamonix, hivers 2018, Le retour du Y�ti", films[0].Titre);
                Assert.Equal("Jason Revillard", films[0].Realisateur);
                Assert.True(films[0].Visionne);
                //nettoyage
                dal.DeleteCreateDatabase();
            }

        }

        [Fact]
        public void TestAjoutFilm4()
        {
            //pr�paration
            using (Dal dal = new Dal())
            {
                //Nous supprimons et cr�ons la DB avant le test
                dal.DeleteCreateDatabase();
                //action
                dal.CreerFilm("Vacances � Chamonix, hivers 2018, Le retour du Y�ti", 2014, "Jason Revillard", true);
                //v�rification du r�sultat
                List<Film> films = dal.ObtenirTousLesFilms();
                Assert.NotNull(films);
                Assert.Single(films);
                Assert.Equal(2014, films[0].Ann�e);
                Assert.Equal("Vacances � Chamonix, hivers 2018, Le retour du Y�ti", films[0].Titre);
                Assert.Equal("Jason Revillard", films[0].Realisateur);
                Assert.True(films[0].Visionne);
                //nettoyage
                dal.DeleteCreateDatabase();
            }

        }
    }
}
