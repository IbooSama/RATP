using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RATP.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcLineContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcLineContext>>()))
            {

                // Look for any movies.
                if (context.Line.Any())
                {
                    return;   // DB has been seeded
                }

                context.Line.AddRange(
                    new Line
                    {
                        Code = "1",
                        Name = "Métro 1",
                        Directions = "La Defense / Chateau de Vincennes"
                    },
                    new Line
                    {
                        Code = "2",
                        Name = "Métro 2",
                        Directions = "Porte Dauphine / Nation"
                    },
                    new Line
                    {
                        Code = "3",
                        Name = "Métro 3",
                        Directions = "Pont de Levallois - Becon / Gallieni"
                    },
                    new Line
                    {
                        Code = "3b",
                        Name = "Métro 3b",
                        Directions = "Gambetta / Porte des Lilas"
                    },
                    new Line
                    {
                        Code = "4",
                        Name = "Métro 4",
                        Directions = "Mairie de Montrouge / Porte de Clignancourt"
                    },
                    new Line
                    {
                        Code = "5",
                        Name = "Métro 5",
                        Directions = "Place d'Italie / Bobigny - Pablo Picasso"
                    },
                    new Line
                    {
                        Code = "6",
                        Name = "Métro 6",
                        Directions = "Charles de Gaulle - Etoile / Nation"
                    },
                    new Line
                    {
                        Code = "7",
                        Name = "Métro 7",
                        Directions = "Villejuif-L. Aragon / Mairie d'Ivry / la Courneuve - 8 Mai 1945"
                    },
                    new Line
                    {
                        Code = "7b",
                        Name = "Métro 7b",
                        Directions = "Louis Blanc / Pre-Saint-Gervais"
                    },
                    new Line
                    {
                        Code = "8",
                        Name = "Métro 8",
                        Directions = "Pointe du Lac / Balard"
                    },
                    new Line
                    {
                        Code = "9",
                        Name = "Métro 9",
                        Directions = "Mairie de Montreuil / Pont de Sevres"
                    },
                    new Line
                    {
                        Code = "10",
                        Name = "Métro 10",
                        Directions = "Gare d'Austerlitz / Boulogne - Pont de Saint Cloud"
                    },
                    new Line
                    {
                        Code = "11",
                        Name = "Métro 11",
                        Directions = "Chatelet / Mairie des Lilas"
                    },
                    new Line
                    {
                        Code = "12",
                        Name = "Métro 12",
                        Directions = "Front Populaire / Mairie d'Issy"
                    },
                    new Line
                    {
                        Code = "13",
                        Name = "Métro 13",
                        Directions = "St-Denis-Universite/Les Courtilles / Chatillon - Montrouge"
                    },
                    new Line
                    {
                        Code = "14",
                        Name = "Métro 14",
                        Directions = "Olympiades / Saint-Lazare"
                    },
                    new Line
                    {
                        Code = "Fun",
                        Name = "Métro Fun",
                        Directions = "Funiculaire"
                    },
                    new Line
                    {
                        Code = "Orv",
                        Name = "Métro Orv",
                        Directions = "Orly Sud / Antony-RER",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}