using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Countdown
{
    class NumbersRound
    {
        Random rnd = new Random();
        const int AMOUNT_OF_NUMBERS = 6;
        public List<int> numbers = new List<int>();
        int[] PoolBig = { 25, 50, 75, 100 };
        int[] PoolSmall = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public int NumberGoal = 0;
        public void ChangeNumberGoal()
        {
            NumberGoal = rnd.Next(101, 1000);
        }
        public void AddBig()
        {
            if (IsFull()) return;
            numbers.Add(PoolBig[rnd.Next(PoolBig.Length)]);
        }
        public void AddSmall()
        {
            if (IsFull()) return;
            numbers.Add(PoolSmall[rnd.Next(PoolSmall.Length)]);
        }
        public bool IsFull()
        {
            return (AMOUNT_OF_NUMBERS == numbers.Count);
        }
        public void Clear()
        {
            numbers = new List<int>();
        }
        public int ComputeFormula(string c)
        {
            return Convert.ToInt32(new DataTable().Compute(c, null));
        }
    }
}
