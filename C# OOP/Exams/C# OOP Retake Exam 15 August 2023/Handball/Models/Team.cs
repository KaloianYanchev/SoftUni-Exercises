using Handball.Models.Contracts;
using Handball.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handball.Models
{
    public class Team : ITeam
    {
        private string name;
        private int pointsEarned;
        private double overallRating;
        private List<IPlayer> players;

        public Team(string name)
        {
            Name = name;
            PointsEarned = 0;
            players = new List<IPlayer>();
        }

        public string Name
        {
            get => name; 
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.TeamNameNull));
                }

                name = value;
            }
        }

        public int PointsEarned
        {
            get => pointsEarned; 
            private set
            {
                pointsEarned = value;
            }
        }

        public double OverallRating
        {
            get
            {
                if (players.Count > 0)
                {
                    double averageRating = players.Select(p => p.Rating).Average();
                    double roundedAverage = Math.Round(averageRating, 2);

                    return roundedAverage;
                }
                else
                {
                    return 0;
                }
            }
            private set
            {
                overallRating = value;
            }
        }

        public IReadOnlyCollection<IPlayer> Players => players;

        public void Draw()
        {
            PointsEarned += 1;
            foreach (var player in players.Where(p => p.GetType().Name == "Goalkeeper"))
            {
                player.IncreaseRating();
            }
        }

        public void Lose()
        {
            foreach (var player in players)
            {
                player.DecreaseRating();
            }
        }

        public void SignContract(IPlayer player)
        {
            players.Add(player);
        }

        public void Win()
        {
            PointsEarned += 3;
            foreach (var player in players)
            {
                player.IncreaseRating();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Team: {Name} Points: {PointsEarned}");
            sb.AppendLine($"--Overall rating: {OverallRating}");

            if ( players.Count > 0 )
            {
                sb.AppendLine($"--Players: {string.Join(", ", players.Select(p => p.Name))}");
            }
            else
            {
                sb.AppendLine($"--Players: none");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
