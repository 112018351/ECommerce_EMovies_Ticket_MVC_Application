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
              //   context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();

                    // 1. Cinemas
                    if (!context.Cinemas.Any())
                    {
                        context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Bollywood Cinema Neon",
                            Logo = "https://images.pexels.com/photos/1117132/pexels-photo-1117132.jpeg",
                            Description = "Classic Bollywood cinema with dazzling neon marquees."
                        },
                        new Cinema()
                        {
                            Name = "Retro Reel",
                            Logo = "https://img.freepik.com/premium-vector/vintage-logo-design_657992-131.jpg",
                            Description = "Vintage-style theater with retro ambiance and classic films."
                        },
                        new Cinema()
                        {
                            Name = "Modern Multiplex",
                            Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.m.wikipedia.org%2Fwiki%2FFile%3AMultiplex_logo.svg&psig=AOvVaw3t8tmY3wSxh-uT3MoA-eIz&ust=1756748126114000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIDDvu_KtY8DFQAAAAAdAAAAABAE",
                            Description = "State-of-the-art multiplex with 4K screens and recliner seating."
                        },
                        new Cinema()
                        {
                            Name = "Indie Art House",
                            Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTjlzb1gxUbKGZ8X9lx1AT3IYOFBkPWIqvCAA&s",
                            Description = "Cozy cinema showcasing independent and arthouse films."
                        },
                        new Cinema()
                        {
                            Name = "Open-Air Arena",
                            Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSZ3FAnpO2vKsE08DsdXZEP6ABcuWd-s15wBw&s",
                            Description = "Outdoor cinema perfect for summer nights under the stars."
                        }
                    });
                        context.SaveChanges();
                    }

                    // 2. Producers
                    if (!context.Producers.Any())
                    {
                        context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Kevin Feige",
                            Bio = "President of Marvel Studios and blockbuster producer of the Marvel Cinematic Universe.",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/licensed-image?q=tbn:ANd9GcSR2WH8RHjrDfKMbltj_TjiSUiPzaGPQfeSXNN-Y56rmIJTkc_PF2QTnJ1byphfSMY29dvqU92H8jwMecPlMnfigd-EQf_8fz64XjhXmSAy7qLo6hjHPalyZAlWCjRnJzPiKM1k6CbF"
                        },
                        new Producer()
                        {
                            FullName = "Todd Phillips",
                            Bio = "Director, producer, and screenwriter known for The Hangover trilogy and Joker.",
                            ProfilePictureURL = "data:image/webp;base64,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"
                        },
                        new Producer()
                        {
                            FullName = "Frank Darabont",
                            Bio = "Renowned director and producer known for The Shawshank Redemption and The Green Mile.",
                            ProfilePictureURL = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRFg_L-GOVgZvA6Gd3N7AGWCXraDFgfK3gVbfkkI1iZA0zJN4lDr_4BvbmsS47AiKwEOBFocz4fUeVdIjzOkbJm5A"
                        }
                    });
                        context.SaveChanges();
                    }

                    // 3. Actors
                    if (!context.Actors.Any())
                    {
                        context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor
                        {
                            FullName = "Shah Rukh Khan",
                            Bio = "Often referred to as the 'King of Bollywood', one of the most successful film actors in the world.",
                            ProfilePictureURL = "https://in.bmscdn.com/iedb/artist/images/website/poster/large/shah-rukh-khan-2092-12-09-2017-02-10-43.jpg"
                        },
                       
                        new Actor
                        {
                            FullName = "Salman Khan",
                            Bio = "A superstar actor in Hindi cinema, producer, and humanitarian known for his strong screen presence.",
                            ProfilePictureURL = "https://c.ndtvimg.com/2025-06/q3tab73c_salman-khan_625x300_15_June_25.jpg?im=FeatureCrop,algorithm=dnn,width=1200,height=738"
                        },
                        new Actor
                        {
                            FullName = "Deepika Padukone",
                            Bio = "Leading Bollywood actress with global recognition for her versatility.",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BYmNlZTQzMjQtODEwZi00MjljLTgzNDktY2Q1MmY0N2Q4ZTQzXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg"
                        },
                        new Actor
                        {
                            FullName = "Priyanka Chopra",
                            Bio = "International actress and producer, one of Bollywood’s most successful exports.",
                            ProfilePictureURL = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQRTWkp3wF4JRuDwuWxw-XWb2ECC5JTK_8uoWDTANvrxZuDuR5C4LXOodrKD4uWxCPRvUgwJkze0NUNNc5ukJzsfQ"
                        }
                    });
                        context.SaveChanges();
                    }

                    // 4. Movies
                    if (!context.Movies.Any())
                    {
                        context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Action Thriller",
                            Description = "High-octane action in a thrilling adventure.",
                            Price = 10.0,
                            ImageUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQQ52AuuNHs-VekZPRUjguzxoZ_PtcBMl8hrUUVGmbfx2ogJqsANI_kOClmkmLqjhf2PvP63zlgSdLCWYs2REXR6TB7PdBdn3MxmMHkB51-ww",
                            StartDate = DateTime.Now.AddDays(-2),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Slapstick Comedy",
                            Description = "Laugh out loud in this fun comedy.",
                            Price = 8.0,
                            ImageUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQh6rPd9hx_fUGzorshx1fG5kzUM5FGCSYmm2YBuLU3uSFFI5BviIWd6hrHbw",
                            StartDate = DateTime.Now.AddDays(-1),
                            EndDate = DateTime.Now.AddDays(14),
                            CinemaId = 2,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Drama Unfolded",
                            Description = "A touching drama that explores human emotions.",
                            Price = 9.0,
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTRfaS2jGg7GPXrGabIx4BvXfrCzDwyA2qubQ&usqp=CAU",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 3,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Nature Documentary",
                            Description = "Explore the wonders of the natural world in this documentary.",
                            Price = 7.0,
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQh6rPd9hx_fUGzorshx1fG5kzUM5FGCSYmm2YBuLU3uSFFI5BviIWd6hrHbw",
                            StartDate = DateTime.Now.AddDays(5),
                            EndDate = DateTime.Now.AddDays(30),
                            CinemaId = 4,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Cartoon Fun",
                            Description = "Toon antics for kids and grown-ups.",
                            Price = 6.0,
                            ImageUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQQ52AuuNHs-VekZPRUjguzxoZ_PtcBMl8hrUUVGmbfx2ogJqsANI_kOClmkmLqjhf2PvP63zlgSdLCWYs2REXR6TB7PdBdn3MxmMHkB51-ww",
                            StartDate = DateTime.Now.AddDays(2),
                            EndDate = DateTime.Now.AddDays(18),
                            CinemaId = 5,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Cartoon
                        }
                    });
                        context.SaveChanges();
                    }

                    // 5. Actor & Movies
                    if (!context.Actor_Movies.Any())
                    {
                        context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {
                        // Shah Rukh Khan in Action Thriller and Slapstick Comedy
                        new Actor_Movie() { ActorId = 1, MovieId = 1 },
                        new Actor_Movie() { ActorId = 1, MovieId = 2 },

                        // Salman Khan in Drama Unfolded and Nature Documentary
                        new Actor_Movie() { ActorId = 2, MovieId = 3 },
                        new Actor_Movie() { ActorId = 2, MovieId = 4 },

                        // Deepika Padukone in Cartoon Fun
                        new Actor_Movie() { ActorId = 3, MovieId = 5 },

                        // Priyanka Chopra in Slapstick Comedy and Drama Unfolded
                        new Actor_Movie() { ActorId = 4, MovieId = 2 },
                        new Actor_Movie() { ActorId = 4, MovieId = 3 }
                    });
                        context.SaveChanges();
                    }
                }
            }
        }
    }
