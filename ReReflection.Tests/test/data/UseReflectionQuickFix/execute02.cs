namespace N
{
  class A
  {
	private static string M(int a, float b)
	{
		return string.Empty;
	}
  }
  
  class C
  {
    static void Main(string[] args)
    {
      string s = A.M{caret}(0, 0.1);
    }
  }
}
