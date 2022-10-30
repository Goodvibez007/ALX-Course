using ALX_Course.Lessons.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALX_Course.Lessons.L2
{
    public class L2EnumsAndSwitch
    {
        public static void Run()
        {
            var whiteQueen = new ChessFigures(ChessFigureTypes.QUEEN, ChessColor.WHITE);

            var blackQueen = new ChessFigures();
            blackQueen.FigureTypes = ChessFigureTypes.QUEEN;
            blackQueen.FigureColor = ChessColor.BLACK;

            var whiteKing = new ChessFigures
            {
                FigureTypes = ChessFigureTypes.KING,
                FigureColor = ChessColor.WHITE,
            };

            var blackBishop = new ChessFigures(ChessFigureTypes.BISHOP, ChessColor.BLACK);

            GetFigureTypes(whiteQueen);
            GetFigureTypes(blackQueen);
            GetFigureTypes(whiteKing);
            GetFigureTypes(blackBishop);
        }

        private static void GetFigureTypes(ChessFigures chessFigures)
        {
            switch(chessFigures.FigureTypes)
            {
                case ChessFigureTypes.QUEEN:
                    Console.WriteLine("The figure is a queen");
                    break;
                case ChessFigureTypes.KING:
                    Console.WriteLine("The figure is a king");
                    break;
                case ChessFigureTypes.ROOK:
                    Console.WriteLine("The figure is a rook");
                    break;
                case ChessFigureTypes.BISHOP:
                    Console.WriteLine("The figure is a bishop");
                    break;
                case ChessFigureTypes.KNIGHT:
                    Console.WriteLine("The figure is a knight");
                    break;
                case ChessFigureTypes.PAWN:
                    Console.WriteLine("The figure is a pawn");
                    break;
                default:
                    Console.WriteLine("The type is undafined...");
                    break;
            }
            Console.WriteLine("The figure has been classified.");

        }
    }
}
