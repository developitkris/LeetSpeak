using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetspeakApp;

namespace LeetspeakApp.Tests
{
  [TestClass]
  public class LeetspeakTest
  {
    // public void Dispose()
    // {
    //
    // }
    [TestMethod]
    public void ConvertSentence_ReturnSentence_OriginalSentence()
    {
      string sentence = "if";
      string sentence2 = "if";
      Assert.AreEqual(sentence, Leetspeak.ConvertSentence(sentence2));
    }

    // public void ConvertSentence_ConvertE_b33f()
    // {
    //   string word1 = "beef";
    //   string word2 = "b33f";
    //   Assert.AreEqual(word2, ConvertE(word1));
    // }
  }
}
