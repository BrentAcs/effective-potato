namespace EffectivePotato.WinUI.Extensions;

public static class FormSettingsExtensions
{
   public static void ApplyTo(this FormSettings settings, Form form)
   {
      form.Location = settings.Location;
      form.Size = settings.Size;
   }
}
