
namespace Jalgpall 
{
    class Program 
    {
        static void Main() 
        {

            Team team1 = new Team("Home");

            Team team2 = new Team("Away");

            Stadium stadium = new Stadium(70, 30);

            team1.GenHTeam();

            team2.GenATeam();

            Game begin = new Game(team1, team2, stadium);

            begin.Start();
            while (true) 
            {
                Console.Clear();
                Console.SetCursorPosition(82,27);
                stadium.Draw();
                begin.Move();
                Thread.Sleep(400);
            }
        }
    }
}
