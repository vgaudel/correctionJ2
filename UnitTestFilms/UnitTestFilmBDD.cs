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
            //préparation
            using (Dal dal = new Dal())
            {
                //Nous supprimons et créons la DB avant le test
                dal.DeleteCreateDatabase();
                //action
                dal.CreerFilm("Vacances à Chamonix, hivers 2018, Le retour du Yéti", 2014, "Jason Revillard", true);
                //vérification du résultat
                List<Film> films = dal.ObtenirTousLesFilms();
                Assert.NotNull(films);
                Assert.Single(films);
                Assert.Equal(2014,films[0].Année);
                Assert.Equal("Vacances à Chamonix, hivers 2018, Le retour du Yéti", films[0].Titre);
                Assert.Equal("Jason Revillard", films[0].Realisateur);
                Assert.True(films[0].Visionne);
                //nettoyage
                dal.DeleteCreateDatabase();
            }

        }
        [Fact]
        public void TestAjoutFilm2()
        {
            //préparation
            using (Dal dal = new Dal())
            {
                //Nous supprimons et créons la DB avant le test
                dal.DeleteCreateDatabase();
                //action
                dal.CreerFilm("Vacances à Chamonix, hivers 2017, Rencontre avec le Yéti", 2017, "Jason Revillard", true);
                //vérification du résultat
                List<Film> films = dal.ObtenirTousLesFilms();
                Assert.NotNull(films);
                Assert.Single(films);
                Assert.Equal(2017, films[0].Année);
                Assert.Equal("Vacances à Chamonix, hivers 2017, Rencontre avec le Yéti", films[0].Titre);
                Assert.Equal("Jason Revillard", films[0].Realisateur);
                Assert.True(films[0].Visionne);
                //nettoyage
                dal.DeleteCreateDatabase();
            }

        }

        [Fact]
        public void TestAjoutFilm3()
        {
            //préparation
            using (Dal dal = new Dal())
            {
                //Nous supprimons et créons la DB avant le test
                dal.DeleteCreateDatabase();
                //action
                dal.CreerFilm("Vacances à Chamonix, hivers 2018, Le retour du Yéti", 2014, "Jason Revillard", true);
                //vérification du résultat
                List<Film> films = dal.ObtenirTousLesFilms();
                Assert.NotNull(films);
                Assert.Single(films);
                Assert.Equal(2014, films[0].Année);
                Assert.Equal("Vacances à Chamonix, hivers 2018, Le retour du Yéti", films[0].Titre);
                Assert.Equal("Jason Revillard", films[0].Realisateur);
                Assert.True(films[0].Visionne);
                //nettoyage
                dal.DeleteCreateDatabase();
            }

        }

        [Fact]
        public void TestAjoutFilm4()
        {
            //préparation
            using (Dal dal = new Dal())
            {
                //Nous supprimons et créons la DB avant le test
                dal.DeleteCreateDatabase();
                //action
                dal.CreerFilm("Vacances à Chamonix, hivers 2018, Le retour du Yéti", 2014, "Jason Revillard", true);
                //vérification du résultat
                List<Film> films = dal.ObtenirTousLesFilms();
                Assert.NotNull(films);
                Assert.Single(films);
                Assert.Equal(2014, films[0].Année);
                Assert.Equal("Vacances à Chamonix, hivers 2018, Le retour du Yéti", films[0].Titre);
                Assert.Equal("Jason Revillard", films[0].Realisateur);
                Assert.True(films[0].Visionne);
                //nettoyage
                dal.DeleteCreateDatabase();
            }

        }
    }
}
