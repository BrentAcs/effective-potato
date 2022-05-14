using EffectivePotato.Core;
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
}
