using System.DirectoryServices.ActiveDirectory;
using EffectivePotato.Core;
using EffectivePotato.Core.Extensions;

namespace EffectivePotato.WinUI.Controls;
public partial class AbilityScoresPanel : UserControl
{
   protected ActorBase? _actor;

   public AbilityScoresPanel()
   {
      InitializeComponent();
   }

   public ActorBase? Actor
   {
      get => _actor;
      set
      {
         _actor = value;
         OnInternalPropertiesChanged();
      }
   }

   public event EventHandler? OnPropertiesChanged;

   protected void OnInternalPropertiesChanged()
   {
      if(_actor is null)
         return;

      strengthTextBox.Text = $"{_actor.GetBaseAbilityScore(AbilityScoreType.Strength)}";
      intelligenceTextBox.Text = $"{_actor.GetBaseAbilityScore(AbilityScoreType.Intelligence)}";
      wisdomTextBox.Text = $"{_actor.GetBaseAbilityScore(AbilityScoreType.Wisdom)}";
      dexterifyTextBox.Text = $"{_actor.GetBaseAbilityScore(AbilityScoreType.Dexterity)}";
      constiutionTextBox.Text = $"{_actor.GetBaseAbilityScore(AbilityScoreType.Constitution)}";
   }

   private void UpdateModifier(TextBox scoreBox, TextBox modifierBox, AbilityScoreType scoreType)
   {
      int.TryParse(scoreBox.Text, out int score);
      int modifier = score.GetAbilityModifier();
      modifierBox.Text = $"{(modifier > 0 ? "+" : "")}{modifier}";

      if (_actor != null)
      {
         _actor.SetBaseAbilityScore(scoreType, score);
      }

      OnPropertiesChanged?.Invoke(this, EventArgs.Empty);
   }

   private void strengthTextBox_TextChanged(object sender, EventArgs e) =>
      UpdateModifier(strengthTextBox, strengthModifierTextBox, AbilityScoreType.Strength);

   private void intelligenceTextBox_TextChanged(object sender, EventArgs e) =>
      UpdateModifier(intelligenceTextBox, intelligenceModifierTextBox, AbilityScoreType.Intelligence);

   private void wisdomTextBox_TextChanged(object sender, EventArgs e) =>
      UpdateModifier(wisdomTextBox, wisdomModifierTextBox, AbilityScoreType.Wisdom);

   private void dexterifyTextBox_TextChanged(object sender, EventArgs e) =>
      UpdateModifier(dexterifyTextBox, dexterifyModifierTextBox, AbilityScoreType.Dexterity);

   private void constiutionTextBox_TextChanged(object sender, EventArgs e) =>
      UpdateModifier(constiutionTextBox, constiutionModifierTextBox, AbilityScoreType.Constitution);
}
