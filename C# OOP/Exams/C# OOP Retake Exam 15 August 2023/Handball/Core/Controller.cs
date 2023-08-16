using Handball.Core.Contracts;
using Handball.Models;
using Handball.Models.Contracts;
using Handball.Repositories;
using Handball.Repositories.Contracts;
using Handball.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handball.Core
{
    public class Controller : IController
    {
        private readonly IRepository<IPlayer> players;
        private readonly IRepository<ITeam> teams;

        public Controller()
        {
            players = new PlayerRepository();
            teams = new TeamRepository();
        }

        public string LeagueStandings()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***League Standings***");

            foreach (var team in teams.Models
                .OrderByDescending(t => t.PointsEarned)
                .ThenByDescending(t => t.OverallRating)
                .ThenBy(t => t.Name))
            {
                sb.AppendLine(team.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string NewContract(string playerName, string teamName)
        {
            if (!players.ExistsModel(playerName))
            {
                return string.Format(OutputMessages.PlayerNotExisting, playerName, players.GetType().Name);
            }
            if (!teams.ExistsModel(teamName))
            {
                return string.Format(OutputMessages.TeamNotExisting, teamName, teams.GetType().Name);
            }

            IPlayer player = players.GetModel(playerName);
            ITeam team = teams.GetModel(teamName);

            if (player.Team != null)
            {
                return string.Format(OutputMessages.PlayerAlreadySignedContract, playerName, player.Team);
            }

            player.JoinTeam(teamName);
            team.SignContract(player);
            return string.Format(OutputMessages.SignContract, playerName, teamName);

        }

        public string NewGame(string firstTeamName, string secondTeamName)
        {
            ITeam firstTeam = teams.GetModel(firstTeamName);
            ITeam secondTeam = teams.GetModel(secondTeamName);

            if (firstTeam.OverallRating >  secondTeam.OverallRating)
            {
                firstTeam.Win();
                secondTeam.Lose();
                
                return string.Format(OutputMessages.GameHasWinner, firstTeamName, secondTeamName);
            }
            else if (firstTeam.OverallRating < secondTeam.OverallRating)
            {
                firstTeam.Lose();
                secondTeam.Win();

                return string.Format(OutputMessages.GameHasWinner, secondTeamName, firstTeamName);
            }
            else
            {
                firstTeam.Draw();
                secondTeam.Draw();

                return string.Format(OutputMessages.GameIsDraw, firstTeamName, secondTeamName);
            }
        }

        public string NewPlayer(string typeName, string name)
        {
            IPlayer player;

            if (typeName != "Goalkeeper" && typeName != "CenterBack" && typeName != "ForwardWing")
            {
                return string.Format(OutputMessages.InvalidTypeOfPosition, typeName);
            }
            if (players.ExistsModel(name))
            {
                return string.Format(OutputMessages.PlayerIsAlreadyAdded, name, players.GetType().Name, players.GetModel(name).GetType().Name); // Check this
            }

            if (typeName == "Goalkeeper")
            {
                player = new Goalkeeper(name);
            }
            else if (typeName == "CenterBack")
            {
                player = new CenterBack(name);
            }
            else
            {
                player = new ForwardWing(name);
            }

            players.AddModel(player);
            return string.Format(OutputMessages.PlayerAddedSuccessfully, name);
        }

        public string NewTeam(string name)
        {
            if (teams.ExistsModel(name))
            {
                return string.Format(OutputMessages.TeamAlreadyExists, name, teams.GetType().Name);
            }

            ITeam team = new Team(name);
            teams.AddModel(team);
            return string.Format(OutputMessages.TeamSuccessfullyAdded, name, teams.GetType().Name);
        }

        public string PlayerStatistics(string teamName)
        {
            ITeam team = teams.GetModel(teamName);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"***{team.Name}***");

            foreach (var player in team.Players
                .OrderByDescending(p => p.Rating)
                .ThenBy(p => p.Name))
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
