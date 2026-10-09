

namespace Grid_Notation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            static string ReverseString(string s)
            {
                char[] array = s.ToCharArray();
                Array.Reverse(array);
                return new string(array);
            }
            string[][] BaseGrid = new string[][]
                {
                    new string[] {"A", "B", "C", "D", "E"},
                    new string[] {"F", "G", "H", "I", "J"},
                    new string[] {"K", "L", "M", "N", "O"},
                    new string[] {"P", "Q", "R", "S", "T"},
                    new string[] {"U", "V", "W", "X", "Y"}
                };

            string CordinateRefrence = ReverseString(Console.ReadLine());

            long x = 1, y = 1;

            int NumberOfRows = 5;

            for (int i = 0; i < CordinateRefrence.Length; i++)
            {
                string CurrentCharachter = Convert.ToString(CordinateRefrence[i]);

                for (int row = 0; row < BaseGrid.GetLength(0); row++)
                {
                    for (int col = 0; col < BaseGrid[row].Length; col++)
                    {
                        if (BaseGrid[row][col] == CurrentCharachter)
                        {
                            x += Convert.ToInt64(Math.Pow(5, i) * col );
                            y += Convert.ToInt64(Math.Pow(5, i) * (NumberOfRows - row - 1) );
                        }
                    }
                }
            }

            Console.WriteLine($"{x} {y}");
        }
    }
}
