using EMovies_Ticket.Enum;
using EMovies_Ticket.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EMovies_Ticket.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
              //  context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSe62GNFtYPWOW09NmlQ0ZBsw4cTFJpNGzA_w&s",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://i.ytimg.com/vi/XdmwQ-UvVOw/hq720.jpg?sqp=-oaymwEhCK4FEIIDSFryq4qpAxMIARUAAAAAGAElAADIQj0AgKJD&rs=AOn4CLDikzSck1fHr0ACkyQ2QSZIRmXMVQ",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "https://i.pinimg.com/736x/8d/30/db/8d30db5df5d6a501c8fe50de99db7815.jpg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "https://www.shutterstock.com/image-vector/cinema-camera-roll-film-logo-260nw-2113680914.jpg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRw9L5xI6EmhoCP4WTNqOMCgi-84gDQmhNswg&s",
                            Description = "This is the description of the first cinema"
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
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcRNW5_PY7EhaPpWamQLAlXZlQ2U28FZpfcSmffSY62jEbB13GiZKKNJGsmOK3VAsiqsjZ2YLQjqtUDj-TXDBOnBNQ"

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRRXBWxXHdX7CpOWTjTCnzXkY4KLOdYrGR4J5C606AFZewjtJEPLd1E_bGnTI_eYUmlR54UjWOmQp0Pds3HhoqC3Q"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://pbs.twimg.com/media/GzmmSFabAAABkpK.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS4zHL5wZeZYr5WPcTuROTafdClkO43RY9eGEVX7dvmci_ExlmY3lmUHcbosUoRO7GsFyJwaIX3-_JiYxsBqPOYeQ"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTFJawMVKK3s_WuMxdmTuZpxgq6YJHoScmftdzUVFSVFHdjxYlQz40SU1LpC3KHu1aGiafxOg_1FshpyrV4Quvtmw"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first producer",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQJxOjad23mscmMrOBO3ybROewdxk7zsyDXng&s"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second producer",
                            ProfilePictureURL = "https://media.gettyimages.com/id/512923237/photo/cameraman-on-set.jpg?s=612x612&w=gi&k=20&c=azn8_oEEtQSGReY6OXZCR1HvvEjZwqumR9yfuG9anmE="
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second producer",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQK-XYRCs88MdCA47Wc4aUQroujgKABX7ZHhw&s"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the second producer",
                            ProfilePictureURL = "https://c8.alamy.com/comp/2YY2P5F/mumbai-india-18th-dec-2024-l-r-indian-film-producers-atlee-kumar-priya-atlee-indian-film-actress-keerthy-suresh-bollywood-actor-varun-dhawan-child-actor-zara-sundarashwaran-actress-wamiqa-gabbi-director-kalees-and-producer-murad-khetani-pose-for-a-photo-after-the-press-meet-of-their-upcoming-film-baby-john-in-mumbai-credit-sopa-images-limitedalamy-live-news-2YY2P5F.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the second producer",
                            ProfilePictureURL = "https://media.istockphoto.com/id/485252737/photo/young-producer-with-film-reel.jpg?s=612x612&w=0&k=20&c=Xvqq45hfYVH8GO2BPkNr0rZeYPiqC2OblnuWB0BQLGI="
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
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTDPLDpkfBltZQeounwzxEmECvC5Fh-OxUn_m0NBXArNU1iyZTTuaUnib08l2PTExXbEBY&usqp=CAU",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageUrl = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/012019/untitled-1_33.jpg?bDrwXp2Rthy6T7xm6wVsavaYf35JCXiS&itok=L3GstEOI",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQN5WBsKZe26RVZM2frqobP0eKF6mF65alBwQ&s",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageUrl = "https://stat4.bollywoodhungama.in/wp-content/uploads/2020/05/23-10-1-306x393.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageUrl = "https://pbs.twimg.com/media/D_J8fb5UEAEHv4c.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZTY0YzdiYWMtZjg0OC00MzFmLWJhMjYtNjcyYjk4YjZhN2FmXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
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
        
    
