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
            List<Figure> figures = new List<Figure>
            {
                new Figure() { Id = 1, Coefficient = 5 },
                new Figure() { Id = 2, Coefficient = 6 },
                new Figure() { Id = 3, Coefficient = 5 },
                new Figure() { Id = 4, Coefficient = 7 },
                new Figure() { Id = 5, Coefficient = 5 },
                new Figure() { Id = 6, Coefficient = 8 },
                new Figure() { Id = 7, Coefficient = 6 },
                new Figure() { Id = 8, Coefficient = 8 },
                new Figure() { Id = 9, Coefficient = 6 },
                new Figure() { Id = 10, Coefficient = 9 },
                new Figure() { Id = 11, Coefficient = 5 },
                new Figure() { Id = 12, Coefficient = 9 },
                new Figure() { Id = 13, Coefficient = 5 },
                new Figure() { Id = 14, Coefficient = 9 },
                new Figure() { Id = 15, Coefficient = 7 },
                new Figure() { Id = 16, Coefficient = 8 },
                new Figure() { Id = 17, Coefficient = 8 },
                new Figure() { Id = 18, Coefficient = 8 },
                new Figure() { Id = 19, Coefficient = 7 },
                new Figure() { Id = 20, Coefficient = 7 },
                new Figure() { Id = 21, Coefficient = 5 },
                new Figure() { Id = 22, Coefficient = 7 },
                new Figure() { Id = 23, Coefficient = 7 },
                new Figure() { Id = 24, Coefficient = 9 },
                new Figure() { Id = 25, Coefficient = 7 },
                new Figure() { Id = 26, Coefficient = 8 },
                new Figure() { Id = 27, Coefficient = 5 },
                new Figure() { Id = 28, Coefficient = 10 },
                new Figure() { Id = 29, Coefficient = 7 },
                new Figure() { Id = 30, Coefficient = 10 },
                new Figure() { Id = 31, Coefficient = 5 },
                new Figure() { Id = 32, Coefficient = 10 },
                new Figure() { Id = 33, Coefficient = 5 },
                new Figure() { Id = 34, Coefficient = 10 },
                new Figure() { Id = 35, Coefficient = 7 },
                new Figure() { Id = 36, Coefficient = 10 },
                new Figure() { Id = 37, Coefficient = 6 },
                new Figure() { Id = 38, Coefficient = 7 },
                new Figure() { Id = 39, Coefficient = 8 },
                new Figure() { Id = 40, Coefficient = 8 },
                new Figure() { Id = 41, Coefficient = 5 },
                new Figure() { Id = 42, Coefficient = 9 },
                new Figure() { Id = 43, Coefficient = 8 },
                new Figure() { Id = 44, Coefficient = 10 },
                new Figure() { Id = 45, Coefficient = 8 },
                new Figure() { Id = 46, Coefficient = 8 },
                new Figure() { Id = 47, Coefficient = 6 },
                new Figure() { Id = 48, Coefficient = 7 },
                new Figure() { Id = 49, Coefficient = 8 },
                new Figure() { Id = 50, Coefficient = 9 },
                new Figure() { Id = 51, Coefficient = 5 },
                new Figure() { Id = 52, Coefficient = 8 },
                new Figure() { Id = 53, Coefficient = 8 },
                new Figure() { Id = 54, Coefficient = 8 },
                new Figure() { Id = 55, Coefficient = 6 },
                new Figure() { Id = 56, Coefficient = 9 },
                new Figure() { Id = 57, Coefficient = 6 },
                new Figure() { Id = 58, Coefficient = 10 },
                new Figure() { Id = 59, Coefficient = 5 },
                new Figure() { Id = 60, Coefficient = 10 },
                new Figure() { Id = 61, Coefficient = 5 },
                new Figure() { Id = 62, Coefficient = 10 },
                new Figure() { Id = 63, Coefficient = 7 },
                new Figure() { Id = 64, Coefficient = 10 },
                new Figure() { Id = 65, Coefficient = 7 },
                new Figure() { Id = 66, Coefficient = 10 },
                new Figure() { Id = 67, Coefficient = 6 },
                new Figure() { Id = 68, Coefficient = 10 },
                new Figure() { Id = 69, Coefficient = 5 },
                new Figure() { Id = 70, Coefficient = 7 },
                new Figure() { Id = 71, Coefficient = 9 },
                new Figure() { Id = 72, Coefficient = 10 },
                new Figure() { Id = 73, Coefficient = 5 },
                new Figure() { Id = 74, Coefficient = 7 },
                new Figure() { Id = 75, Coefficient = 8 },
                new Figure() { Id = 76, Coefficient = 8 },
                new Figure() { Id = 77, Coefficient = 8 },
                new Figure() { Id = 78, Coefficient = 10 },
                new Figure() { Id = 79, Coefficient = 5 },
                new Figure() { Id = 80, Coefficient = 7 },
                new Figure() { Id = 81, Coefficient = 7 },
                new Figure() { Id = 82, Coefficient = 10 },
                new Figure() { Id = 83, Coefficient = 5 },
                new Figure() { Id = 84, Coefficient = 10 },
                new Figure() { Id = 85, Coefficient = 5 },
                new Figure() { Id = 86, Coefficient = 6 },
                new Figure() { Id = 87, Coefficient = 8 },
                new Figure() { Id = 88, Coefficient = 10 },
                new Figure() { Id = 89, Coefficient = 5 },
                new Figure() { Id = 90, Coefficient = 8 },
                new Figure() { Id = 91, Coefficient = 9 },
                new Figure() { Id = 92, Coefficient = 10 },
                new Figure() { Id = 93, Coefficient = 5 },
                new Figure() { Id = 94, Coefficient = 7 },
                new Figure() { Id = 95, Coefficient = 7 },
                new Figure() { Id = 96, Coefficient = 9 },
                new Figure() { Id = 97, Coefficient = 7 },
                new Figure() { Id = 98, Coefficient = 10 },
                new Figure() { Id = 99, Coefficient = 6 },
                new Figure() { Id = 100, Coefficient = 10 }
            };

            
            Context ctx = new Context();
            ctx.Figures.AddRange(figures);
            
            //ctx.Sets.Add(a);
            ctx.SaveChanges();
            Dictionary<string, List<int>> parcour1 = new Dictionary<string,List<int>>{
                {"A", new List<int>(){ 61,54,95,78,09,71,93,53,04,68}},
                {"B", new List<int>(){ 41,06,63,72,02,50,69,18,94,66}},
                {"C", new List<int>(){ 03,49,97,44,67,24,83,46,25,92}},
                {"D", new List<int>(){ 33,45,65,82,86,10,05,75,29,58}},
                {"E", new List<int>(){ 01,52,38,62,99,42,27,76,15,34}},
                {"F", new List<int>(){ 79,08,80,64,57,96,11,77,19,32}},
                {"G", new List<int>(){ 73,87,35,30,47,12,89,26,23,88}},
                {"H", new List<int>(){ 59,40,20,28,55,91,51,43,70,98}},
                {"I", new List<int>(){ 21,39,81,60,07,56,31,90,48,84}},
                {"J", new List<int>(){ 13,16,74,36,37,14,85,17,22,100}}
            };
            createParcour(parcour1, ctx);
            Dictionary<string, List<int>> p2 = new Dictionary<string,List<int>>{
                {"K", new List<int>(){5,18,29,32,47,96,79,54,74,82}},
                {"L", new List<int>(){93,17,25,98,7,42,73,45,20,60}},
                {"M", new List<int>(){11,46,48,84,67,56,33,52,80,28}},
                {"N", new List<int>(){83,76,23,100,2,10,61,40,38,64}},
                {"O", new List<int>(){27,75,22,66,57,14,3,16,63,78}},
                {"P", new List<int>(){69,90,15,58,37,50,41,8,95,44}},
                {"Q", new List<int>(){85,77,19,34,99,12,13,49,35,72}},
                {"R", new List<int>(){51,26,70,88,86,24,59,39,81,62}},
                {"S", new List<int>(){31,43,4,92,55,71,1,6,97,36}},
                {"T", new List<int>(){89,53,94,68,9,91,21,87,65,30 }}
            };
            createParcour(p2, ctx);

            foreach (Set s in ctx.Sets)
            {
                Console.WriteLine(s.FigureInSets.Sum(fis=>fis.Figure.Coefficient));
            }
            
            Console.ReadLine();

        }

        public static void createParcour(Dictionary<string, List<int>> parcour, Context ctx)
        {
            Parcour p1 = new Parcour();
            ctx.Parcours.Add(p1);
            foreach (string setName in parcour.Keys)
            {
                Set s = new Set() { Name = setName };
                s.Parcour = p1;
                int cpt = 1;
                foreach (int figureId in parcour[setName])
                {
                    ctx.FiguresInSet.Add(new FigureInSet() { Figure = ctx.Figures.Find(figureId), Set = s, Order = cpt });
                    cpt++;
                }
                ctx.Sets.Add(s);
            }

            ctx.SaveChanges();
        }
    }
}
