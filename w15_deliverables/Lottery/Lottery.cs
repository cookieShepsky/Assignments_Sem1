using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_Lottery;

internal class Lottery
{
    private int max;
    private int amount;
    private Random random;
    private Stack<int> result;

    public Lottery(int max, int amount)
    {
        this.max = max;
        this.amount = amount;
        random = new Random();
        this.result = new Stack<int>();
        int newNum;

        // Generate specified amount of unique winning numbers and add to stack
        while (result.Count < amount)
        {
            newNum = random.Next(1, max + 1);
            if (!result.Contains(newNum))
            {
                result.Push(newNum);
                Debug.WriteLine($"added number {result.Count} to result");
            }
            Debug.WriteLine("cycle");
            if (result.Count == amount)
            {
                break;
            }

        }
    }

    public int[] DrawAll()
    {
        int[] remainingNums = result.ToArray();
        result.Clear();
        return remainingNums;
    }

    public int DrawNext()
    {
        return result.Pop();
    }

    public bool IsFinished()
    {
        if (result.Count == 0)
        {
            return true;
        }
        return false;
    }
}
