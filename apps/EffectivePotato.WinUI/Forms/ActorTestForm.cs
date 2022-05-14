using EffectivePotato.WinUI.Extensions;

namespace EffectivePotato.WinUI.Forms;
public partial class ActorTestForm : Form
{
   public ActorTestForm()
   {
      InitializeComponent();
   }

   private void ActorTestForm_Load(object sender, EventArgs e)
   {
      //Settings.Default.ActorTestFormSettings.ApplyTo(this);
   }

   private void ActorTestForm_FormClosed(object sender, FormClosedEventArgs e)
   {
      
   }
}
