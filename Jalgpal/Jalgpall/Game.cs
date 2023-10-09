using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpall
{
    public class Game
    {
        public Team HomeTeam { get; } 
        public Team AwayTeam { get; } 
        public Stadium Stadium { get; } 
        public Ball Ball { get; private set; } 
        public Game(Team homeTeam, Team awayTeam, Stadium stadium) 
        {
            HomeTeam = homeTeam;
            homeTeam.Game = this; 
            AwayTeam = awayTeam;
            awayTeam.Game = this;
            Stadium = stadium;
        }

        public void Start() 
        {

            Ball = new Ball(Stadium.Width / 2, Stadium.Height / 2, this);
            HomeTeam.StartGameH(Stadium.Width / 2, Stadium.Height);
            AwayTeam.StartGameA(Stadium.Width / 2, Stadium.Height);
            DrawB(Ball);
        }
        private (double, double) GetPositionForAwayTeam(double x, double y) 
        {
            return (Stadium.Width - x, Stadium.Height - y);
        }

        public (double, double) GetPositionForTeam(Team team, double x, double y) 
        {
            return team == HomeTeam ? (x, y) : GetPositionForAwayTeam(x, y);
        }

        public (double, double) GetBallPositionForTeam(Team team) 
        {
            return GetPositionForTeam(team, Ball.X, Ball.Y);
        }

        public void SetBallSpeedForTeam(Team team, double vx, double vy)
        {
            if (team == HomeTeam)
            {
                Ball.SetSpeed(vx, vy);
            }
            else
            {
                Ball.SetSpeed(-vx, -vy);
            }
        }

        public void Move()
        {
            Console.ForegroundColor= ConsoleColor.Blue;
            HomeTeam.Move();
            Console.ForegroundColor= ConsoleColor.Red;
            AwayTeam.Move();
            Ball.Move();
            DrawB(Ball);
        }
        public static void DrawB(Ball ball)
        {
            int posX = (int)Math.Round(ball.X); 
            int posY = (int)Math.Round(ball.Y); 
            Console.SetCursorPosition(posX, posY);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(ball.sym);
        }

    }
}
 