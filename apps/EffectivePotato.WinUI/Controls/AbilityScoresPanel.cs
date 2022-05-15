using System.DirectoryServices.ActiveDirectory;
using EffectivePotato.Core;
using EffectivePotato.Core.Extensions;

namespace EffectivePotato.WinUI.Controls;
public partial class AbilityScoresPanel : UserControl
{
   protected ActorBase _actor;

   public AbilityScoresPanel()
   {
      InitializeComponent();
   }

   public ActorBase Actor
   {
      get => _actor;
      set
      {
         _actor = value;
         OnPropertiesChanged();
      }
   }

   private static void UpdateModifier(TextBox scoreBox, TextBox modifierBox)
   {
      int.TryParse(scoreBox.Text, out int score);
      int modifier = score.GetAbilityModifier();
      modifierBox.Text = $"{(modifier > 0 ? "+" : "")}{modifier}";
   }

   protected void OnPropertiesChanged()
   {
      strengthTextBox.Text = $"{_actor.GetBaseAbilityScore(AbilityScoreType.Strength)}";
   }

   private void strengthTextBox_TextChanged(object sender, EventArgs e) =>
      UpdateModifier(strengthTextBox, strengthModifierTextBox);

}
