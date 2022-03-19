using Data.Domain;
using Data.Enums;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Seed
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Chaplin MEGA Park",
                            Logo = "https://cdn.kino.kz/cinema/122/p1000x1000.jpg",
                            Address = "st.Makataeva, 127, 3rd floor",
                            Description = "After 22:00, minors can only be in the cinema with their parents/guardians if they have documents for the child."
                        },
                        new Cinema()
                        {
                            Name = "Kinopark 11 IMAX",
                            Logo = "https://cdn.kino.kz/cinema/99/p1000x1000.jpg",
                            Address = "st.Al-Farabi, 77/8, Esentai Mall",
                            Description = "After 22:00, minors can only be in the cinema with their parents/guardians if they have documents for the child."

                        },
                        new Cinema()
                        {
                            Name = "Cinemax (Dostyk Plaza) Dolby Atmos",
                            Logo = "https://cdn.kino.kz/cinema/119/p1000x1000.jpg",
                            Address = "st.Samal-2, 111, Dostyk Plaza",
                            Description = "After 22:00, minors can only be in the cinema with their parents/guardians if they have documents for the child."

                        },
                        new Cinema()
                        {
                            Name = "Kinoplexx 6 Almaty Mall",
                            Logo = "https://cdn.kino.kz/cinema/172/p1000x1000.jpg",
                            Address = "st.Zhandosova, 83, Almaty Mall, 3rd floor",
                            Description = "After 22:00, minors can only be in the cinema with their parents/guardians if they have documents for the child."
                        },
                        new Cinema()
                        {
                            Name = "Arman Asia Park",
                            Logo = "https://cdn.kino.kz/cinema/76/p1000x1000.jpg",
                            Address = "st.Kabanbay batyr, Asia Park, 3rd floor",
                            Description = "After 22:00, minors can only be in the cinema with their parents/guardians if they have documents for the child."
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Tom Holland",
                            Birthdate = new DateTime(1996, 6, 1),
                            PlaceOfBirth = "Kingston upon Thames, England, UK",
                            ProfilePictureURL = "https://www.biography.com/.image/c_fit%2Ccs_srgb%2Cfl_progressive%2Cq_auto:good%2Cw_620/MTQ4MTUwOTQyMDE1OTU2Nzk4/tom-holland-photo-jason-kempin-getty-images-801510482-profile.jpg"

                        },
                        new Actor()
                        {
                            FullName = "Zendaya",
                            Birthdate = new DateTime(1996, 9, 1),
                            PlaceOfBirth = "Oakland, California, USA",
                            ProfilePictureURL = "https://www.film.ru/sites/default/files/news/19488021-878675.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Benedict Cumberbatch",
                            Birthdate = new DateTime(1976, 7, 19),
                            PlaceOfBirth = "Hammersmith, London, England, UK",
                            ProfilePictureURL = "https://i.pinimg.com/originals/f2/0c/07/f20c0744247dc76fde82c2437dbde45d.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Tom Hardy",
                            Birthdate = new DateTime(1977, 9, 15),
                            PlaceOfBirth = "Kingston upon Thames, England, UK",
                            ProfilePictureURL = "https://fs.kinomania.ru/file/person/8/22/82297fb03825734791f88e99cf913877.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Leonardo DiCaprio",
                            Birthdate = new DateTime(1974, 11, 11),
                            PlaceOfBirth = "Hollywood, Los Angeles, California, USA",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/4/46/Leonardo_Dicaprio_Cannes_2019.jpg"
                        }
                    }); ;
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Jon Watts",
                            Birthdate = new DateTime(1981, 6, 28),
                            PlaceOfBirth = "Fountain, Colorado, USA",
                            ProfilePictureURL = "https://thumbs.dfs.ivi.ru/storage15/contents/8/9/6674a8b124f10917abac370e48eae1.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Quentin Tarantino", 
                            Birthdate = new DateTime(1963, 3, 27),
                            PlaceOfBirth = "Knoxville, Tennessee, USA",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Quentin_Tarantino_by_Gage_Skidmore.jpg/640px-Quentin_Tarantino_by_Gage_Skidmore.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Martin Scorsese",
                            Birthdate = new DateTime(1942, 11, 17),
                            PlaceOfBirth = "Queens, New York City, New York, USA",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/f/fb/Martin_Scorsese_Cannes_2010.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Christopher Nolan",
                            Birthdate = new DateTime(1970, 7, 30),
                            PlaceOfBirth = "London, England, UK",
                            ProfilePictureURL = "https://static.wikia.nocookie.net/chrisnolan/images/0/05/Christopher_Nolan.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Guy Ritchie",
                            Birthdate = new DateTime(1968, 9, 10),
                            PlaceOfBirth = "Hatfield, Hertfordshire, England, UK",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/1/14/GuyRitchiebyKathyHutchins.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Spider-Man: No Way Home",
                            Description = "With Spider-Man's identity now revealed, Peter asks Doctor Strange for help. When a spell goes wrong, dangerous foes from other worlds start to appear, forcing Peter to discover what it truly means to be Spider-Man.",
                            Price = 39.50,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BZWMyYzFjYTYtNTRjYi00OGExLWE2YzgtOGRmYjAxZTU3NzBiXkEyXkFqcGdeQXVyMzQ0MzA0NTM@._V1_FMjpg_UX1000_.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 2,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Inception",
                            Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.",
                            Price = 29.50,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_FMjpg_UX1000_.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Legend",
                            Description = "Identical twin gangsters Ronald and Reginald Kray terrorize London during the 1960s.",
                            Price = 39.50,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMjE0MjkyODQ3NF5BMl5BanBnXkFtZTgwNDM1OTk1NjE@._V1_.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Soul",
                            Description = "After landing the gig of a lifetime, a New York jazz pianist suddenly finds himself trapped in a strange land between Earth and the afterlife.",
                            Price = 39.50,
                            ImageURL = "https://itc.ua/wp-content/uploads/2020/03/soul-poster.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Once Upon a Time in... Hollywood",
                            Description = "A faded television actor and his stunt double strive to achieve fame and success in the final years of Hollywood's Golden Age in 1969 Los Angeles.",
                            Price = 39.50,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/ru/e/ef/Once_Upon_a_Time_in_Hollywood_cover.png",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 2,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Gentlemen",
                            Description = "An American expat tries to sell off his highly profitable marijuana empire in London, triggering plots, schemes, bribery and blackmail in an attempt to steal his domain out from under him.",
                            Price = 39.50,
                            ImageURL = "https://images-na.ssl-images-amazon.com/images/S/pv-target-images/cfb3f12f82b18ad989a01e0a2a9bfab06571e6cd94f831b8afbfe6a028e80233._RI_V_TTW_.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 3,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Action
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }

            }

        }

    }
}
