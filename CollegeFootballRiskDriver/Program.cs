using CollegeFootballRisk;
using System;
using System.CommandLine;
using System.CommandLine.Invocation;

namespace CollegeFootballRiskDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            var risk = new Risk();

            var rootCommand = new RootCommand("Command-line driver for CFBRisk library");


            var listTeamsCommand = new Command("list-teams", "List CFBRisk teams")
            {
                Handler = CommandHandler.Create(() => ListTeams(risk))
            };
            rootCommand.Add(listTeamsCommand);



            
            rootCommand.Invoke(args);
        }

        private static void ListTeams(Risk risk)
        {
            foreach (var t in risk.GetTeams())
            {
                Utility.WriteLine(t.ToString());
            }
        }
    }
}
