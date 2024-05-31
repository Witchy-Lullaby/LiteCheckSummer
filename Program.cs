using LLM.CheckSummer.Actions;

string[] arguments = RemoveDump(Environment.GetCommandLineArgs());

Console.WriteLine($"[INFO] Arguments received: \nAmount: {arguments.Length} \nArguments:{string.Join(' ', arguments)}");

new ArgumentAction().SetData(arguments).Start();




string[] RemoveDump(string[] arguments)
{
    if (!arguments[0].Contains("--"))
    {
        var argsToChange = arguments.ToList();
        while (argsToChange.Count > 0 && !argsToChange[0].Contains("--"))
        {
            argsToChange.RemoveAt(0);
        }
        return argsToChange.ToArray();
    }
    return arguments;
}