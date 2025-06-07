namespace RootScript;

public class Project
{
    private static string GetPath()
    {
        // get path to the current directory
        var pathParts = Directory.GetCurrentDirectory().Split('\\').ToList();
        pathParts.RemoveRange(pathParts.Count - 4, 4);
        return string.Join('\\', pathParts);
    }

    public static string SolutionPath => GetPath();
    public static string RootScript => $"{SolutionPath}\\RootScript";
    public static string RootScriptTests => $"{SolutionPath}\\RootScript.Tests";
}