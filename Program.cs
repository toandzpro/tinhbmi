class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vui lòng nhập chiều cao");
        double Chieucao = float.Parse(Console.ReadLine());
        Console.WriteLine("Vui lòng nhập cân nặng của bạn");
        double cannnag = float.Parse(Console.ReadLine());
        double bmi = cannnag / Math.Pow(Chieucao, 2);
        bmi = Math.Round(bmi, 1);
        Console.Write("BMI: " + bmi);

        if (bmi < 18)
        {
            Console.WriteLine(" Bạn đang thiếu cân");
        }

        else if (bmi < 25.0)
        {
            Console.WriteLine(" Bạn có cân nặng bình thường");
        }
        else if (bmi < 30.0)
        {
            Console.WriteLine(" Bạn đang thừa cân");
        }
        else
        {
            Console.WriteLine(" Bạn đang béo phì");
        }
    }
}