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
            this.levelModifierTextBox = new System.Windows.Forms.TextBox();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // abilityScoresPanel
            // 
            this.abilityScoresPanel.Actor = null;
            this.abilityScoresPanel.Location = new System.Drawing.Point(12, 41);
            this.abilityScoresPanel.Name = "abilityScoresPanel";
            this.abilityScoresPanel.Size = new System.Drawing.Size(195, 171);
            this.abilityScoresPanel.TabIndex = 0;
            // 
            // levelModifierTextBox
            // 
            this.levelModifierTextBox.Location = new System.Drawing.Point(149, 12);
            this.levelModifierTextBox.Name = "levelModifierTextBox";
            this.levelModifierTextBox.ReadOnly = true;
            this.levelModifierTextBox.Size = new System.Drawing.Size(43, 23);
            this.levelModifierTextBox.TabIndex = 5;
            // 
            // levelTextBox
            // 
            this.levelTextBox.Location = new System.Drawing.Point(100, 12);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.Size = new System.Drawing.Size(43, 23);
            this.levelTextBox.TabIndex = 4;
            this.levelTextBox.TextChanged += new System.EventHandler(this.levelTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Level:";
            // 
            // statsTextBox
            // 
            this.statsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statsTextBox.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statsTextBox.Location = new System.Drawing.Point(348, 15);
            this.statsTextBox.Multiline = true;
            this.statsTextBox.Name = "statsTextBox";
            this.statsTextBox.ReadOnly = true;
            this.statsTextBox.Size = new System.Drawing.Size(422, 442);
            this.statsTextBox.TabIndex = 6;
            // 
            // ActorTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 469);
            this.Controls.Add(this.statsTextBox);
            this.Controls.Add(this.levelModifierTextBox);
            this.Controls.Add(this.levelTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.abilityScoresPanel);
            this.Name = "ActorTestForm";
            this.Text = "ActorTestForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActorTestForm_FormClosed);
            this.Load += new System.EventHandler(this.ActorTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

   }

   #endregion

   private Controls.AbilityScoresPanel abilityScoresPanel;
   private TextBox levelModifierTextBox;
   private TextBox levelTextBox;
   private Label label1;
   private TextBox statsTextBox;
}
