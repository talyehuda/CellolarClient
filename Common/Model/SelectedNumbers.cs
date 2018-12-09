using System.ComponentModel.DataAnnotations;

namespace Common.Model
{
    public class SelectedNumbers
    {
        public SelectedNumbers(int id, string firstNumber, string secondNumber, string thirdNumber)
        {
            Id = id;
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            ThirdNumber = thirdNumber;
        }
        public SelectedNumbers()
        {

        }

        [Key]
        public int Id { get; set; }
        public string FirstNumber { get; set; }
        public string SecondNumber { get; set; }
        public string ThirdNumber { get; set; }
        public void EditSelectedNumbers(SelectedNumbers selectedNumbers)
        {
            FirstNumber = selectedNumbers.FirstNumber;
            SecondNumber = selectedNumbers.SecondNumber;
            ThirdNumber = selectedNumbers.ThirdNumber;
        }
        public SelectedNumbers NewSelectedNumbers(string firstNumber, string secondNumber, string thirdNumber)
        {
            return new SelectedNumbers
            {
                FirstNumber = firstNumber,
                SecondNumber = secondNumber,
                ThirdNumber = thirdNumber
            };
        }
    }
}