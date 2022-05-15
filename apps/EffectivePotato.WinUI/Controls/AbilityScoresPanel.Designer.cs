namespace EffectivePotato.WinUI.Controls;

partial class AbilityScoresPanel
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

   #region Component Designer generated code

   /// <summary> 
   /// Required method for Designer support - do not modify 
   /// the contents of this method with the code editor.
   /// </summary>
   private void InitializeComponent()
   {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.strengthTextBox = new System.Windows.Forms.TextBox();
            this.strengthModifierTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.strengthModifierTextBox);
            this.groupBox1.Controls.Add(this.strengthTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ability Scores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Strength:";
            // 
            // strengthTextBox
            // 
            this.strengthTextBox.Location = new System.Drawing.Point(67, 22);
            this.strengthTextBox.Name = "strengthTextBox";
            this.strengthTextBox.Size = new System.Drawing.Size(43, 23);
            this.strengthTextBox.TabIndex = 1;
            this.strengthTextBox.TextChanged += new System.EventHandler(this.strengthTextBox_TextChanged);
            // 
            // strengthModifierTextBox
            // 
            this.strengthModifierTextBox.Location = new System.Drawing.Point(116, 22);
            this.strengthModifierTextBox.Name = "strengthModifierTextBox";
            this.strengthModifierTextBox.ReadOnly = true;
            this.strengthModifierTextBox.Size = new System.Drawing.Size(43, 23);
            this.strengthModifierTextBox.TabIndex = 2;
            // 
            // AbilityScoresPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "AbilityScoresPanel";
            this.Size = new System.Drawing.Size(295, 283);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

   }

   #endregion

   private GroupBox groupBox1;
   private TextBox strengthModifierTextBox;
   private TextBox strengthTextBox;
   private Label label1;
}
