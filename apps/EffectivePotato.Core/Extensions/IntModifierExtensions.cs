namespace EffectivePotato.Core.Extensions;

public static class IntModifierExtensions
{
   public static int GetModifier(this int score)
   {
      if (score <= 1)
         return -5;
      if (score <= 3)
         return -4;
      if (score <= 5)
         return -3;

      if (score <= 7)
         return -2;

      if (score <= 9)
         return -1;

      if (score <= 11)
         return 0;

      if (score <= 13)
         return 1;

      if (score <= 15)
         return 2;

      if (score <= 17)
         return 3;

      if (score <= 19)
         return 4;

      return 5;
   }
}
