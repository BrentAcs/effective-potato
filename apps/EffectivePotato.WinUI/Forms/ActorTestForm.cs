using EffectivePotato.Core;
using EffectivePotato.Core.Extensions;
using EffectivePotato.WinUI.Extensions;

namespace EffectivePotato.WinUI.Forms;
public partial class ActorTestForm : Form
{
   private const string TestActorFilename = "../../../../../test-actor.json";

   private TestActor? _testActor;

   public ActorTestForm()
   {
      InitializeComponent();
   }

   public void OnPropertiesChanged(object sender, EventArgs e) => 
      OnInternalPropertiesChanged();

   protected void OnInternalPropertiesChanged()
   {
      if (_testActor is null)
         return;

      levelTextBox.Text = $"{_testActor.Level}";


      var builder = new StringBuilder();
      builder.AppendLine($"Max Encumbrance: {_testActor.GetMaxEncumbrance()}");

      statsTextBox.Text = builder.ToString();
   }

   private void ActorTestForm_Load(object sender, EventArgs e)
   {
      Settings.Default.ActorTestFormSettings.ApplyTo(this);

      if (File.Exists(TestActorFilename) )
      {
         var json = File.ReadAllText(TestActorFilename);
         if (!string.IsNullOrWhiteSpace(json))
         {
            _testActor = JsonSerializer.Deserialize<TestActor>(json);
         }
      }

      _testActor ??= new TestActor();
      abilityScoresPanel.Actor = _testActor;
      abilityScoresPanel.OnPropertiesChanged += OnPropertiesChanged;
      OnInternalPropertiesChanged();
   }

   private void ActorTestForm_FormClosed(object sender, FormClosedEventArgs e)
   {
      Settings.Default.ActorTestFormSettings.ApplyFrom(this);
      Settings.Default.Save();

      var options = new JsonSerializerOptions
      {
         WriteIndented = true
      };
      File.WriteAllText(TestActorFilename, JsonSerializer.Serialize(_testActor, options));
   }

   private void levelTextBox_TextChanged(object sender, EventArgs e)
   {
      int.TryParse(levelTextBox.Text, out int level);
      int modifier = level.GetProficiencyModifier();
      levelModifierTextBox.Text = $"{(modifier > 0 ? "+" : "")}{modifier}";

      if (_testActor != null)
      {
         _testActor.Level = level;
      }
   }
}

