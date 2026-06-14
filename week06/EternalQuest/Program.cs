using System;

/*
CREATIVITY ADDED:

1. Player Level System
   Every 1000 points increases level.

2. Eternal Goals display infinity symbol [∞]

3. Score and level displayed continuously.
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}