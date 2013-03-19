using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));
                engine.AddObject(currBlock);
            }

            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));

            engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            //Upper border
            for (int col = 0; col <= WorldCols; col++)
            {
                GameObject block = new IndestructibleBlock(new MatrixCoords(0,col));
                engine.AddObject(block);
            }
            //Left border
            for (int row = 0; row < WorldRows; row++)
            {
                GameObject block = new IndestructibleBlock(new MatrixCoords(row, 0));
                engine.AddObject(block);
            }
            //Right border
            for (int row = 0; row < WorldRows; row++)
            {
                GameObject block = new IndestructibleBlock(new MatrixCoords(row, WorldCols-1));
                engine.AddObject(block);
            }
            MeteoriteBall meteorite = new MeteoriteBall(new MatrixCoords(5, 10), new MatrixCoords(1, -1));
            engine.AddObject(new TrailObject(new MatrixCoords(5,5),4));
            engine.AddObject(new UnstopableBall(new MatrixCoords(15, 15), new MatrixCoords(-1, -1)));
            engine.AddObject(new UnpassableBlock(new MatrixCoords(20, 20)));
            engine.AddObject(meteorite);
            engine.AddObject(theRacket);
            
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
