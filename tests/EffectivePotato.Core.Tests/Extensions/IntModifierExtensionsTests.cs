using EffectivePotato.Core.Extensions;

namespace EffectivePotato.Core.Tests.Extensions;

public class IntModifierExtensionsTests
{
   [SetUp]
   public void Setup()
   {
   }

   [TestCase(0, -5)]
   [TestCase(1, -5)]
   [TestCase(2, -4)]
   [TestCase(3, -4)]
   [TestCase(4, -3)]
   [TestCase(5, -3)]
   [TestCase(6, -2)]
   [TestCase(7, -2)]
   [TestCase(8, -1)]
   [TestCase(9, -1)]
   [TestCase(10, 0)]
   [TestCase(11, 0)]
   [TestCase(12, 1)]
   [TestCase(13, 1)]
   [TestCase(14, 2)]
   [TestCase(15, 2)]
   [TestCase(16, 3)]
   [TestCase(17, 3)]
   [TestCase(18, 4)]
   [TestCase(19, 4)]
   [TestCase(20, 5)]
   [TestCase(21, 5)]
   public void TestGetAbilityModifier(int score, int modifer)
   {
      int result = score.GetAbilityModifier();

      Assert.That(modifer, Is.EqualTo(result));
   }


   [TestCase(1, 2)]
   [TestCase(4, 2)]
   [TestCase(5, 3)]
   [TestCase(8, 3)]
   [TestCase(9, 4)]
   [TestCase(12, 4)]
   [TestCase(13, 5)]
   [TestCase(16, 5)]
   [TestCase(17, 6)]
   [TestCase(21, 6)]
   public void TestGetProficiencyModifier(int level, int modifier)
   {
      int result = level.GetProficiencyModifier();

      Assert.That(modifier, Is.EqualTo(result));
   }
}
