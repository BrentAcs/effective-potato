namespace EffectivePotato.WinUI.Extensions;

public static class FormSettingsExtensions
{
   public static void ApplyTo(this FormSettings? settings, Form form)
   {
      settings ??= new FormSettings();

      form.Location = settings.Location;
      form.Size = settings.Size;
   }

   public static void ApplyFrom(this FormSettings settings, Form form)
   {
      settings.Location = form.Location;
      settings.Size = form.Size;
   }

   public static string ToXml(this FormSettings settings)
   {
      using var stream = new MemoryStream();
      var writer = new XmlTextWriter(stream, Encoding.Default);
      new XmlSerializer(typeof(FormSettings)).Serialize(writer, settings);
      var xml = Encoding.Default.GetString(stream.ToArray());
      return xml;
   }
}
