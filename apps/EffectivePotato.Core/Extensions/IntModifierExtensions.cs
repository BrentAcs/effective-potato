namespace EffectivePotato.Core.Extensions;

public static class IntModifierExtensions
{
   public static int GetAbilityModifier(this int score) =>
      score switch
      {
         <= 1 => -5,
         <= 3 => -4,
         <= 5 => -3,
         <= 7 => -2,
         <= 9 => -1,
         <= 11 => 0,
         <= 13 => 1,
         <= 15 => 2,
         <= 17 => 3,
         <= 19 => 4,
         _ => 5
      };

   public static int GetProficiencyModifier(this int score) =>
      score switch
      {
         <= 4 => 2,
         <= 8 => 3,
         <= 12 => 4,
         <= 16 => 5,
         _ => 6
      };

}
