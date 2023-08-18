using FootballTeam;
using NUnit.Framework;
using System;

namespace FootballTeam
{
    [TestFixture]
    public class FootballTeamTests
    {
        [Test]
        public void TestAddNewPlayerSuccess()
        {
            // Arrange
            FootballTeam team = new FootballTeam("TeamName", 20);
            FootballPlayer player = new FootballPlayer("PlayerName", 10, "Forward");

            // Act
            string result = team.AddNewPlayer(player);

            // Assert
            Assert.AreEqual($"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}", result);
            Assert.AreEqual(1, team.Players.Count);
            Assert.AreEqual(player, team.PickPlayer("PlayerName"));
        }

        [Test]
        public void TestAddNewPlayerCapacityExceeded()
        {
            // Arrange
            FootballTeam team = new FootballTeam("TeamName", 1);
            FootballPlayer player1 = new FootballPlayer("Player1", 10, "Forward");
            FootballPlayer player2 = new FootballPlayer("Player2", 11, "Midfielder");

            // Act
            string result1 = team.AddNewPlayer(player1);
            string result2 = team.AddNewPlayer(player2);

            // Assert
            Assert.AreEqual($"Added player {player1.Name} in position {player1.Position} with number {player1.PlayerNumber}", result1);
            Assert.AreEqual("No more positions available!", result2);
            Assert.AreEqual(1, team.Players.Count);
            Assert.AreEqual(player1, team.PickPlayer("Player1"));
            Assert.IsNull(team.PickPlayer("Player2"));
        }

        [Test]
        public void TestPlayerScore()
        {
            // Arrange
            FootballTeam team = new FootballTeam("TeamName", 20);
            FootballPlayer player = new FootballPlayer("PlayerName", 10, "Forward");
            team.AddNewPlayer(player);

            // Act
            string result = team.PlayerScore(10);

            // Assert
            Assert.AreEqual($"{player.Name} scored and now has {player.ScoredGoals} for this season!", result);
            Assert.AreEqual(1, player.ScoredGoals);
        }

        [Test]
        public void TestPlayerScore_PlayerNotFound()
        {
            // Arrange
            FootballTeam team = new FootballTeam("TeamName", 20);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => team.PlayerScore(10));
        }
    }
}
