using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEF.DAO;
using TestEF.Models;
namespace TestEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Parcour p = new Parcour();
            Set a = new Set() { Name = "A" };
            a.Parcour = p;
            Figure _61 = new Figure() { Id = 61, Coefficient = 5 };
            Figure _54 = new Figure() { Id = 54, Coefficient = 8 };
            Figure _95 = new Figure() { Id = 95, Coefficient = 7 };
            Figure _78 = new Figure() { Id = 78, Coefficient = 10 };
            Figure _9 = new Figure() { Id = 9, Coefficient = 6 };
            Figure _71 = new Figure() { Id = 71, Coefficient = 9 };
            Figure _93 = new Figure() { Id = 93, Coefficient = 5 };
            Figure _53 = new Figure() { Id = 53, Coefficient = 8 };
            Figure _4 = new Figure() { Id = 4, Coefficient = 7 };
            Figure _68 = new Figure() { Id = 68, Coefficient = 10 };

            List<Figure> figuresSetA = new List<Figure>{ 
                new Figure() { Id = 61, Coefficient = 5 },
                new Figure() { Id = 54, Coefficient = 8 },
                new Figure() { Id = 95, Coefficient = 7 },
                new Figure() { Id = 78, Coefficient = 10 },
                new Figure() { Id = 9, Coefficient = 6 },
                new Figure() { Id = 71, Coefficient = 9 },
                new Figure() { Id = 93, Coefficient = 5 },
                new Figure() { Id = 53, Coefficient = 8 },
                new Figure() { Id = 4, Coefficient = 7 },
                new Figure() { Id = 68, Coefficient = 10 }
            };
            Context ctx = new Context();
            ctx.Parcours.Add(p);
            ctx.Sets.Add(a);
            int i = 1;
            foreach (Figure f in figuresSetA)
            {
                ctx.Figures.Add(f);
                ctx.FiguresInSet.Add(new FigureInSet(){Figure=f, Set = a, Order = i});
                i++;
            }

            ctx.SaveChanges();

            Console.WriteLine(ctx.FiguresInSet.Where(fis => fis.Set.Name == "A").Sum(s => s.Figure.Coefficient));
            Console.ReadLine();

        }
    }
}
