//-----------------------------------------------------------------------
// <copyright file="Score.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------

namespace Minesweeper
{
    /// <summary>
    /// Keeps player score
    /// </summary>
    public class Score
    {
        #region Fields

        /// <summary>
        /// Holds the name of the player
        /// </summary>
        private string playerName;

        /// <summary>
        /// Holds the score of the player
        /// </summary>
        private int points;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Score" /> class
        /// </summary>
        public Score() 
        { 
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Score" /> class
        /// </summary>
        /// <param name="playerName">holds the name</param>
        /// <param name="points">holds the points</param>
        public Score(string playerName, int points)
        {
            this.PlayerName = playerName;
            this.Points = points;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the name of the player
        /// </summary>
        public string PlayerName
        {
            get { return this.playerName; }
            set { this.playerName = value; }
        }

        /// <summary>
        /// Gets or sets the earned points
        /// </summary>
        public int Points
        {
            get { return this.points; }
            set { this.points = value; }
        }

        #endregion
    }
}
