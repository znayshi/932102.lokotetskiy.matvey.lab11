using System;

namespace lab11.Models
{
    public class CalculationModel
    {
        public int firstNumber { get; set; }
        public int secondNumber { get; set; }

        public CalculationModel()
        {
            GenerateRandomNumbers();
        }

        public CalculationModel(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }
        private void GenerateRandomNumbers()
        {
            var rand = new Random(DateTime.Now.Millisecond);
            firstNumber = rand.Next(10);
            secondNumber = rand.Next(10);
        }
    }
}
