﻿using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public static class SeedData
    {
        public static void SeedMovie(this ModelBuilder model)
        {
            model.Entity<Movie>().HasData(new Movie[] {
                new Movie(){
                    Id = 1,
                    Title = "Main on Fire",
                    Year = 2004,
                    Description = "John, an ex-CIA officer, is entrusted with the responsibility of safeguarding an entrepreneur's daughter. When the girl gets kidnapped, John vows to seek revenge.",
                    Duration = new TimeSpan(2,26,00),
                    Genre = "Drama/Action/Triller"
                },
                new Movie(){
                    Id = 2,
                    Title = "Gladiator",
                    Year = 2000,
                    Description = "Commodus takes over power and demotes Maximus, one of the preferred generals of his father, Emperor Marcus Aurelius. As a result, Maximus is relegated to fighting till death as a gladiator.",
                    Duration = new TimeSpan(2,35,00),
                    Genre = "History/Drama/Action"
                },
                new Movie(){
                    Id = 3,
                    Title = "Only the Brave",
                    Year = 2017,
                    Description = "When a group of firefighters from California ignores a warning by Superintendent Eric Marsh about a wildfire, he decides to get his crew certified as wildfire hotshots.",
                    Duration = new TimeSpan(2,13,00),
                    Genre = "History/Triller"
                },
                new Movie(){
                    Id = 4,
                    Title = "Serenity",
                    Year = 2019,
                    Description = "Baker Dill is a fishing boat captain who leads tours off of the tranquil enclave of Plymouth Island. His peaceful life is soon shattered when his ex-wife Karen tracks him down. Desperate for help, Karen begs Baker to save her -- and their young son -- from her abusive husband. She wants him to take the brute out for a fishing excursion -- then throw him overboard to the sharks. Thrust back into a life that he wanted to forget, Baker now finds himself struggling to choose between right and wrong.",
                    Duration = new TimeSpan(1,46,00),
                    Genre = "Drama/Triller"
                },
                new Movie(){
                    Id = 5,
                    Title = "Unstoppable",
                    Year = 2010,
                    Description = "An unmanned, half-mile-long freight train hurtles towards a town at breakneck speed. An engineer and a young conductor, who happen to be on the same route, must race against time to try and stop it.",
                    Duration = new TimeSpan(1,38,00),
                    Genre = "Action/Drama"
                },
            });
        }

    }
}
