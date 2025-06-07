namespace RootScript.Tests;

public class ProjectPathsTests
{
    [Test]
    public void ProjectRootPathExistsTest()
    {
        Assert.Multiple(() =>
        {
            Assert.That(Directory.Exists(Project.SolutionPath));
            Assert.That(Directory.Exists(Project.RootScript));
            Assert.That(Directory.Exists(Project.RootScriptTests));
        });
    }
}