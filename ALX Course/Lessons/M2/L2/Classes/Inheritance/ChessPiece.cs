using ALX_Course.Lessons.M1.L2.Enums;

namespace AFALXCourse.Lessons.M2.L2.Classes.Inheritance
{
    public abstract class ChessPiece //nie da sie zrobic obiektu klasy abstract, ale mozna po niej dziedziczyc
    {
        public ChessColor? Color { get; set; }
        public ChessFigureType? Type { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public bool IsAlive { get; set; }

        public ChessPiece()
        {
            IsAlive = true;
        }

        public void Move()
        {
            Console.WriteLine("Chess Piece is moving...");
        }

        public void Present()
        {
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"X position: {XPosition}");
            Console.WriteLine($"Y position: {YPosition}");
            Console.WriteLine($"Is it alive?: {IsAlive}");
        }
    }
}
