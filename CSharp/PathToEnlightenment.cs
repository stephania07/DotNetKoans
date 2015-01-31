namespace DotNetKoans.CSharp
{
    public class PathToEnlightenment : KoanHelpers.IAmThePathToEnlightenment
    {
        public string[] ThePath
        {
            get
            {
                return new string[] {
				"DotNetKoans.CSharp.AboutAsserts",
				"DotNetKoans.CSharp.AboutNil",
				"DotNetKoans.CSharp.AboutArrays",
				"DotNetKoans.CSharp.AboutArrayAssignment",
				"DotNetKoans.CSharp.AboutStrings",
				"DotNetKoans.CSharp.AboutInheritance",
				"DotNetKoans.CSharp.AboutMethods",
				"DotNetKoans.CSharp.AboutControlStatements",
                //Sonnet #1: Love Song To Numbers(Fri)
				"DotNetKoans.CSharp.AboutGenericContainers",
                //Epic #1: Shapes and Colors(Mon)
                //Epic #2: SinglyLinkedList (Wed)
				"DotNetKoans.CSharp.AboutDelegates",
				"DotNetKoans.CSharp.AboutLambdas"
                //Epic #3: cal(Fri)
                };
            }
        }
    }
}
