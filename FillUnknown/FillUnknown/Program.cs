using System;
using System.Collections.Generic;
using System.Linq;

namespace FillUnknown
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person(0,165,55));
            people.Add(new Person(1,201,95));
            people.Add(new Person(0,171,60));
            people.Add(new Person(1,194,102));
            people.Add(new Person(1, 0, 80));
            people.Add(new Person(1,189,90));

            Console.WriteLine("Hello World!");

            Printer(people);
            Console.WriteLine("\n\n\n\n");
            Euclidean(people);
            Manhattan(people);
            MaxMetric(people);
        }

        public static void Printer(List<Person> people)
        {
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"Patient:{i+1} , gender:{people[i].gender} , {people[i].height} , {people[i].weight}");
            }
        }

        public static void Euclidean(List<Person> people)
        {
            //randamas targetIndex(kelintas yrasas nepilnas) ir ratios masyvas (jo dydis=people.Count)
            int targerIndex=-1;
            List<Double> ratios = new List<double>();
            List<Double> ratios2 = new List<double>();
            for (int i=0;i<people.Count;i++)
            {
                ratios.Add(new double());
                ratios2.Add(new double());
                if (people[i].height == 0)
                    targerIndex = i;
            }
            Console.WriteLine($"TARGET INDEX: {targerIndex}");
            //randa visus ratios isskyrus targetIndex
            for (int i=0;i<people.Count;i++)
            {
                if(i!=targerIndex)
                {
                    ratios[i]=Math.Sqrt(
                        (((people[i].gender + 1) * 10) - ((people[targerIndex].gender + 1) * 10))* (((people[i].gender + 1) * 10) - ((people[targerIndex].gender + 1) * 10))+
                        //((people[i].height-people[targerIndex].height)* (people[i].height - people[targerIndex].height))+
                        ((people[i].weight - people[targerIndex].weight) * (people[i].weight - people[targerIndex].weight)) 
                        );
                    if (people[i].gender == people[targerIndex].gender)
                        ratios2[i] = Math.Sqrt((people[i].weight - people[targerIndex].weight) * (people[i].weight - people[targerIndex].weight));
                    else ratios2[i] = 10000000;
                }
                
            }
            ratios[targerIndex] = 10000000000;
            ratios2[targerIndex] = 10000000000;
            //geriausias ratio
            double bestRatio = ratios.Min();
            Console.WriteLine($"Euclidean(all): {bestRatio} ratio, {ratios.IndexOf(bestRatio)+1} person, new height should be {people[ratios.IndexOf(bestRatio)].height}");
            bestRatio = ratios2.Min();
            Console.WriteLine($"+++Euclidean(weight): {bestRatio} ratio, {ratios2.IndexOf(bestRatio) + 1} person, new height should be {people[ratios2.IndexOf(bestRatio)].height}");

        }
        public static void Manhattan(List<Person> people)
        {
            int targerIndex = -1;
            List<Double> ratios = new List<double>();
            List<Double> ratios2 = new List<double>();
            for (int i = 0; i < people.Count; i++)
            {
                ratios.Add(new double());
                ratios2.Add(new double());
                if (people[i].height == 0)
                    targerIndex = i;
            }
            for (int i = 0; i < people.Count; i++)
            {
                if (i != targerIndex)
                {
                    ratios[i] =
                        Math.Abs(((people[i].gender + 1) * 10) - ((people[targerIndex].gender + 1)*10)) +
                        //Math.Abs((people[i].height - people[targerIndex].height)) +
                        Math.Abs((people[i].weight - people[targerIndex].weight))
                        ;
                    if (people[i].gender == people[targerIndex].gender)
                        ratios2[i] = Math.Abs(people[i].weight - people[targerIndex].weight);
                    else ratios2[i] = 10000000;
                }
            }
            ratios[targerIndex] = 10000000000;
            ratios2[targerIndex] = 10000000000;
            //geriausias ratio
            double bestRatio = ratios.Min();
            Console.WriteLine($"Manhattan(all): {bestRatio} ratio, {ratios.IndexOf(bestRatio)+1} person, new height should be {people[ratios.IndexOf(bestRatio)].height}");
            bestRatio = ratios2.Min();
            Console.WriteLine($"+++Manhattan(weight): {bestRatio} ratio, {ratios2.IndexOf(bestRatio) + 1} person, new height should be {people[ratios2.IndexOf(bestRatio)].height}");

        }
        public static void MaxMetric(List<Person> people)
        {
            int targerIndex = -1;
            List<Double> ratios = new List<double>();
            List<Double> ratios2 = new List<double>();
            for (int i = 0; i < people.Count; i++)
            {
                ratios.Add(new double());
                ratios2.Add(new double());
                if (people[i].height == 0)
                    targerIndex = i;
            }
            //max metodas
            for (int i = 0; i < people.Count; i++)
            {
                if (i != targerIndex)
                {
                    List<double> ratios_all=new List<double>();  
                    ratios_all.Add(Math.Abs(((people[i].gender + 1) * 10) - ((people[targerIndex].gender + 1) * 10)));
                    ratios_all.Add(Math.Abs((people[i].height - people[targerIndex].height)));
                    ratios_all.Add(Math.Abs((people[i].weight - people[targerIndex].weight)));
                    ratios[i] = ratios_all.Max();
                    if (people[i].gender == people[targerIndex].gender)
                        ratios2[i] = Math.Abs(people[i].weight - people[targerIndex].weight);
                    else ratios2[i] = 10000000;
                }
            }
            ratios[targerIndex] = 10000000000;
            ratios2[targerIndex] = 10000000000;
            //geriausias ratio
            double bestRatio = ratios.Min();
            Console.WriteLine($"Max(all): {bestRatio} ratio, {ratios.IndexOf(bestRatio)+1} person, new height should be {people[ratios.IndexOf(bestRatio)].height}");
            bestRatio = ratios2.Min();
            Console.WriteLine($"+++Max(weight): {bestRatio} ratio, {ratios2.IndexOf(bestRatio) + 1} person, new height should be {people[ratios2.IndexOf(bestRatio)].height}");

        }
    }
}
