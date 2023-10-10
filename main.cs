using System;
using System.Collections.Generic;
using myMatch;
using myTeam;

class Program
{
    static void Main(string[] args)
    {
        List<Match> matches = new List<Match>
        {
            new Match { Team1 = "Real Madrid", Team1Goals = 3, Team2 = "Manchester United", Team2Goals = 2 },
            new Match { Team1 = "Juventus", Team1Goals = 2, Team2 = "Real Madrid", Team2Goals = 5 },
            new Match { Team1 = "Manchester United", Team1Goals = 4, Team2 = "Juventus", Team2Goals = 1 },
        };

        List<Team> teams = new List<Team>
        {
            new Team { Name = "Real Madrid" },
            new Team { Name = "Manchester United" },
            new Team { Name = "Juventus" },
        };

        try
        {
            while (true)
            {
                Console.WriteLine("1. Add match result");
                Console.WriteLine("2. Add a team");
                Console.WriteLine("3. Remove a team");
                Console.WriteLine("4. Display results");
                Console.WriteLine("5. Display all teams");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Select an option:");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter the name of the first team:");
                        string team1 = Console.ReadLine();

                        Console.WriteLine("Enter the number of goals for the first team:");
                        int goals1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the name of the second team:");
                        string team2 = Console.ReadLine();

                        Console.WriteLine("Enter the number of goals for the second team:");
                        int goals2 = int.Parse(Console.ReadLine());

                        matches.Add(new Match { Team1 = team1, Team1Goals = goals1, Team2 = team2, Team2Goals = goals2 });
                        break;
                    case "2":
                        Console.WriteLine("Enter the team name:");
                        string teamName = Console.ReadLine();

                        teams.Add(new Team { Name = teamName });
                        break;
                    case "3":
                        Console.WriteLine("Enter the team name to remove:");
                        string nameToRemove = Console.ReadLine();

                        teams.RemoveAll(t => t.Name == nameToRemove);
                        break;
                    case "4":
                        foreach (var match in matches)
                        {
                            Console.WriteLine($"{match.Team1} {match.Team1Goals} - {match.Team2Goals} {match.Team2}");
                        }
                        break;
                    case "5":
                            Console.WriteLine("Teams:");
                            foreach (var team in teams)
                        {
                            Console.WriteLine($"{team.Name}");
                        }
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Unknown option");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

