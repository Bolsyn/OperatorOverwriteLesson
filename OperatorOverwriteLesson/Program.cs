using System;

namespace OperatorOverwriteLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 10 + 5; // Операнд1 оператор Операнд2
            // var text = "Мой " + "текст";
            // var anotherText = string.Concat("Мой ", "текст");

            // var pair = new Pair(new Shoe[] { new Shoe(1), new Shoe(2) }, 2);
            var firstShoe = new Shoe(1);
            var secondShoe = new Shoe(1);

            var PaieShoes = firstShoe + secondShoe;
        }
    }
}
