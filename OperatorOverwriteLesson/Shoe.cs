using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverwriteLesson
{
    public class Shoe
    {
        private string material;
        private int weight;

        public Shoe(int weight)
        {
            this.weight = weight;
        }

        public int GetWeight()
        {
            return weight;
        }

        public static Pair operator + (Shoe firstShoe, Shoe secondShoe)
        {
            return new Pair(new Shoe[] { firstShoe, secondShoe }, firstShoe.GetWeight() + secondShoe.GetWeight()); 
        }
    }
}
