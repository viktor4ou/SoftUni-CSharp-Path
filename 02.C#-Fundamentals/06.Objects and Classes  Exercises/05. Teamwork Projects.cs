namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Team> teams = new List<Team>();

            CreateTeam(teams);
            JoinTeams(teams);
            PrintValidTeams(teams);
            PrintTeamsToDisband(teams);
        }
        static void CreateTeam(List<Team> teams)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine()
                    .Split('-',StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string creator = cmd[0];
                string teamName = cmd[1];
                Team team = new Team(creator, teamName);
                if (teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }

            }
        }
        static void JoinTeams(List<Team> teams)
        {
            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {

                string[] cmdArgs = command.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string creator = cmdArgs[0];
                string teamName = cmdArgs[1];
                Team team = new Team(creator, teamName);


                if (AlreadyCreatedATeam(teams, creator))
                {
                    Console.WriteLine($"Member {creator} cannot join team {teamName}!");
                }
                else if (!TeamExist(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else
                {
                    Team teamToJoin = teams
                        .First(t => t.TeamName == teamName);
                    teamToJoin.Members.Add(creator);
                }
            }
        }

        static bool AlreadyCreatedATeam(List<Team> teams, string creator)
        {
            return teams.Any(t => t.Creator == creator || teams.Any(x=> x.Members.Contains(creator)));
        }
        static bool TeamExist(List<Team> teams, string teamName)
        {
            return teams.Any(t => t.TeamName == teamName);
        }

        static void PrintValidTeams(List<Team> teams)
        {
            foreach (Team team in teams
               .Where(x => x.Members.Count > 0)
               .OrderByDescending(s => s.Members.Count)
               .ThenBy((t => t.TeamName)))
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Creator}");
                foreach (string member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }
        static void PrintTeamsToDisband(List<Team> teams)
        {
            Console.WriteLine("Teams to disband:");
            foreach (var team in teams
                .Where(c => c.Members.Count == 0)
                .OrderBy(t => t.TeamName))
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
    class Team
    {
        public Team(string creator, string teamName)
        {
            this.TeamName = teamName;
            this.Creator = creator;
            this.Members = new List<string>();

        }

        public string TeamName { get; private set; }
        public string Creator { get; private set; }
        public List<string> Members { get; private set; }

    }
}