using connectfour.enums;

namespace connectfour.Classes
{
    public class GameBoard
    {
        public GamePiece[,] Board {get; set;}

        public GameBoard()
        {
            Board = new GamePiece[7, 6];
            ClearBoard();
        }
        
        public void ClearBoard()
        {
            var yAxisLength = Board.GetLength(0);
            for(int y = 0; y < yAxisLength; y++) 
            {
                var xAxisLength =  Board.GetLength(1);
                for(int x = 0; x < xAxisLength; x++)
                {
                    Board[y, x] = new GamePiece(PieceColor.Empty);
                }
            }
        }
    }
}