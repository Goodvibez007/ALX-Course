using ALX_Course.Lessons.M1.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALX_Course.Lessons.M1.L2
{
    public class L2EnumsAndSwitch
    {
        public static void Run()
        {
            var whiteQueen = new ChessFigures(ChessFigureType.QUEEN, ChessColor.WHITE);

            var blackQueen = new ChessFigures();
            blackQueen.FigureTypes = ChessFigureType.QUEEN;
            blackQueen.FigureColor = ChessColor.BLACK;

            var whiteKing = new ChessFigures
            {
                FigureTypes = ChessFigureType.KING,
                FigureColor = ChessColor.WHITE,
            };

            var blackBishop = new ChessFigures(ChessFigureType.BISHOP, ChessColor.BLACK);

            GetFigureTypes(whiteQueen);
            GetFigureTypes(blackQueen);
            GetFigureTypes(whiteKing);
            GetFigureTypes(blackBishop);
        }

        private static void GetFigureTypes(ChessFigures chessFigures)
        {
            switch(chessFigures.FigureTypes)
            {
                case ChessFigureType.QUEEN:
                    Console.WriteLine("The figure is a queen");
                    break;
                case ChessFigureType.KING:
                    Console.WriteLine("The figure is a king");
                    break;
                case ChessFigureType.ROOK:
                    Console.WriteLine("The figure is a rook");
                    break;
                case ChessFigureType.BISHOP:
                    Console.WriteLine("The figure is a bishop");
                    break;
                case ChessFigureType.KNIGHT:
                    Console.WriteLine("The figure is a knight");
                    break;
                case ChessFigureType.PAWN:
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
