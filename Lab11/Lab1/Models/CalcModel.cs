namespace Lab1.Models {
    public class CalcModel(int x, int y, string sum, string dif, string mult, string div)
    {
        public readonly int X = x;
        public readonly int Y = y;
        public readonly string Sum = sum;
        public readonly string Dif = dif;
        public readonly string Mult = mult;
        public readonly string Div = div;
    }
}
