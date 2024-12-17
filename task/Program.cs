namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fibonacci fibonacci = new fibonacci();
            //fibonacci.Find();
            //Factorial factorial = new Factorial();
            //factorial.fact();
            //Prime prime = new Prime();
            //prime.prime();
            //LargestPrimeFactor largest = new LargestPrimeFactor();
            //largest.lgpf();
            //PerfectNumber perfectNumber = new PerfectNumber();
            //perfectNumber.PfNumber();
            //ArmstrongNumber armstrong = new ArmstrongNumber();
            //armstrong.Armstrong();
            //Armstrong2 armstrong2 = new Armstrong2();
            //armstrong2.Armst();
            //SumofN sumofN = new SumofN();
            //sumofN.sumofn();
            //NaturalN naturalN = new NaturalN();
            //naturalN.Naturaln();
            //FactorN factorN = new FactorN();
            //factorN.factorn();
            //Absolute absolute = new Absolute();
            //absolute.absolute();
            //AmicableN amicableN = new AmicableN();
            //amicableN.amicableN();
            //SquareRoot squareRoot = new SquareRoot();
            //squareRoot.squareroot();
            //CubeRoot cubeRoot = new CubeRoot();
            //cubeRoot.cuberoot();

            //CalculateFractionPower calculateFractionPower = new CalculateFractionPower();
            //calculateFractionPower.Calculate();

            //PowerOfThree powerOfThree = new PowerOfThree();
            //powerOfThree.Show();

            //PowerFunction powerFunction = new PowerFunction();
            //powerFunction.Powerf();

            //Process process = new Process();
            //process.Print();


            // Example input for student marks and subjects
            string[] subjects = { "Mathematics", "Science", "English", "History", "Geography" };
            int[] marks = { 85, 90, 75, 80, 95 };

            // Create a student object
            Student1 student = new Student1("Hughie Campbell", 101, subjects, marks);

            // Display the marksheet for the student
            student.DisplayMarksheet();
            Console.WriteLine("Hello, World!");
        }
    }
}
