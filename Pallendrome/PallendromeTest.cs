using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pallendrome
{
  [TestClass]
  public class PallendromeTest
  {
    [TestMethod]
    public void IsAlreadyAPallendrome()
    {
      const string expected = "abba";

      var actual = Pallendrome.SmallestPossiblePallendrome(expected);

      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Value_aabb_Returns_aabbaa()
    {
      const string original = "aabb";

      var actual = Pallendrome.SmallestPossiblePallendrome(original);

      const string expected = "aabbaa";
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Value_abab_Returns_ababa()
    {
      const string original = "abab";

      var actual = Pallendrome.SmallestPossiblePallendrome(original);

      const string expected = "ababa";
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Value_aaab_Returns_aaabaaa()
    {
      const string original = "aaab";

      var actual = Pallendrome.SmallestPossiblePallendrome(original);

      const string expected = "aaabaaa";
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Value_baaa_Returns_baaab()
    {
      const string original = "baaa";

      var actual = Pallendrome.SmallestPossiblePallendrome(original);

      const string expected = "baaab";
      Assert.AreEqual(expected, actual);
    }
  }
}