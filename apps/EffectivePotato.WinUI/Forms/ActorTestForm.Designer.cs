namespace EffectivePotato.WinUI.Forms;

partial class ActorTestForm
{
   /// <summary>
   /// Required designer variable.
   /// </summary>
   private System.ComponentModel.IContainer components = null;

   /// <summary>
   /// Clean up any resources being used.
   /// </summary>
   /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
   protected override void Dispose(bool disposing)
   {
      if (disposing && (components != null))
      {
         components.Dispose();
      }
      base.Dispose(disposing);
   }

   #region Windows Form Designer generated code

   /// <summary>
   /// Required method for Designer support - do not modify
   /// the contents of this method with the code editor.
   /// </summary>
   private void InitializeComponent()
   {
            this.abilityScoresPanel = new EffectivePotato.WinUI.Controls.AbilityScoresPanel();
            this.SuspendLayout();
            // 
            // abilityScoresPanel
            // 
            this.abilityScoresPanel.Location = new System.Drawing.Point(12, 32);
            this.abilityScoresPanel.Name = "abilityScoresPanel";
            this.abilityScoresPanel.Size = new System.Drawing.Size(295, 283);
            this.abilityScoresPanel.TabIndex = 0;
            // 
            // ActorTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 471);
            this.Controls.Add(this.abilityScoresPanel);
            this.Name = "ActorTestForm";
            this.Text = "ActorTestForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActorTestForm_FormClosed);
            this.Load += new System.EventHandler(this.ActorTestForm_Load);
            this.ResumeLayout(false);

   }

   #endregion

   private Controls.AbilityScoresPanel abilityScoresPanel;
}
