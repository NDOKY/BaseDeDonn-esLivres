using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BaseDeDonnéesLivres.Data;
using System;
using System.Linq;

namespace BaseDeDonnéesLivres.Models
{
    public class SeddData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BaseDeDonnéesLivresContext(
                serviceProvider.GetRequiredService<DbContextOptions<BaseDeDonnéesLivresContext>>()))
            {
                //Chercher livre desire
                if (context.LivreDesire.Any())
                {
                    return;
                }

                context.LivreDesire.AddRange(
                    new LivreDesire
                    {
                        titre = "Comment se faire des amis",
                        anneePublication = DateTime.Parse("2019-2-25"),
                        auteur = "Josue Khira"
                    });
                //Chercher un livre
                if (context.Livre.Any())
                {
                    return;
                }

                context.Livre.AddRange(
                    new Livre
                    {
                        titre = "Comment se faire des amis",
                        anneePublication = DateTime.Parse("2019-2-25"),
                        auteur = "Josue Khira",
                        prix = 8.99M
                    },

                    new Livre
                    {
                        titre = "Naruto Shippuden",
                        anneePublication = DateTime.Parse("1998-2-25"),
                        auteur = "Masashi Kishimoto",
                       prix = 5.99M
                    },

                    new Livre
                    {
                        titre = "One Piece",
                        anneePublication = DateTime.Parse("1995-2-25"),
                        auteur = "Eichiro Oda",
                        prix = 10.99M
                    });

                context.SaveChanges();

                

            }
        }
    }
}
