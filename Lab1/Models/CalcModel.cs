namespace Lab1.Models {
    public class CalcModel {
        public readonly int X;
        public readonly int Y;
        public readonly string Sum;
        public readonly string Sub;
        public readonly string Mult;
        public readonly string Div;
        public CalcModel(int x, int y, string sum, string sub, string mult, string div) {
            X = x;
            Y = y;
            Sum = sum;
            Sub = sub;
            Mult = mult;
            Div = div;
        }
    }
}
