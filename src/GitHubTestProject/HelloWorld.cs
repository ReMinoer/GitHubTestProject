using GitHubTestProject.Dependency;

namespace GitHubTestProject
{
    public static class HelloWorld
    {
        public static string Get() => "Hello World " + Punctuation.ExclamationMark;
    }
}
