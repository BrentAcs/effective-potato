using EffectivePotato.Core.Extensions;

namespace EffectivePotato.Core;

public abstract class ActorBase
{
   public int Level { get; set; } = 1;
   public int[] BaseAbilityScores { get; set; }

   protected ActorBase()
   {
      if (BaseAbilityScores is null)
      {
         BaseAbilityScores = new int[Enum.GetNames<AbilityScoreType>().Length];

         foreach (var score in Enum.GetValues<AbilityScoreType>())
         {
            BaseAbilityScores[(int)score] = 10;
         }
      }
   }
}

public static class ActorConstants
{
   public const int BaseEncumbrance = 100;
   public const int EncumbranceModifierMultiplier = 20;
}

public static class ActorBaseExtensions
{
   public static int GetBaseAbilityScore(this ActorBase actor, AbilityScoreType scoreType) => 
      actor.BaseAbilityScores[(int) scoreType];
   public static void SetBaseAbilityScore(this ActorBase actor, AbilityScoreType scoreType, int score) =>
      actor.BaseAbilityScores[(int)scoreType] = score;

   public static int GetAbilityScoreModifier(this ActorBase actor, AbilityScoreType scoreType) =>
      actor.BaseAbilityScores[(int)scoreType].GetAbilityModifier();

   public static int GetMaxEncumbrance(this ActorBase actor) =>
      ActorConstants.BaseEncumbrance + actor.GetAbilityScoreModifier(AbilityScoreType.Strength) * ActorConstants.EncumbranceModifierMultiplier;
}

public class TestActor : ActorBase
{

}


public enum AbilityScoreType
{
   /// <summary>
   /// Strength
   /// Modifier affects: melee attacks, weight carried
   /// </summary>
   Strength,

   /// <summary>
   /// Intelligence
   /// Modifier affects: mystic attacks, 
   /// </summary>
   Intelligence,

   /// <summary>
   /// Wisdom
   /// Modifier affects: mystic defense
   /// </summary>
   Wisdom,

   /// <summary>
   /// Dexterity
   /// Modifier affects: ranged attacks, physical defense, action points
   /// </summary>
   Dexterity,

   /// <summary>
   /// Constitution
   /// Modifier affects: Health
   /// </summary>
   Constitution,
}


//public class AbilityScore
//{
//   public int BaseScore { get; set; }
//   public int Modifier => BaseScore.GetAbilityModifier();
//   public int Score => BaseScore;
//}

//public class AbilityScores
//{
//   public AbilityScore Strength { get; set; }
//}
