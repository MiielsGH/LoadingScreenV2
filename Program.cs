int TotalSteps = 100;
int Step = 1;
while (Step <= TotalSteps)
{
    Console.WriteLine($"Loading... Step {Step} of {TotalSteps}");
    if (Step % 10 == 0)
    {
        Console.WriteLine($"loading {Step}% complete!");
    }
    Step++;
}