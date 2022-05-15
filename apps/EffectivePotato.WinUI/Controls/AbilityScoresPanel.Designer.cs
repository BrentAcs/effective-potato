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
            this.strengthModifierTextBox = new System.Windows.Forms.TextBox();
            this.strengthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.intelligenceModifierTextBox = new System.Windows.Forms.TextBox();
            this.intelligenceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wisdomModifierTextBox = new System.Windows.Forms.TextBox();
            this.wisdomTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dexterifyModifierTextBox = new System.Windows.Forms.TextBox();
            this.dexterifyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.constiutionModifierTextBox = new System.Windows.Forms.TextBox();
            this.constiutionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.constiutionModifierTextBox);
            this.groupBox1.Controls.Add(this.constiutionTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dexterifyModifierTextBox);
            this.groupBox1.Controls.Add(this.dexterifyTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.wisdomModifierTextBox);
            this.groupBox1.Controls.Add(this.wisdomTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.intelligenceModifierTextBox);
            this.groupBox1.Controls.Add(this.intelligenceTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.strengthModifierTextBox);
            this.groupBox1.Controls.Add(this.strengthTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ability Scores";
            // 
            // strengthModifierTextBox
            // 
            this.strengthModifierTextBox.Location = new System.Drawing.Point(137, 17);
            this.strengthModifierTextBox.Name = "strengthModifierTextBox";
            this.strengthModifierTextBox.ReadOnly = true;
            this.strengthModifierTextBox.Size = new System.Drawing.Size(43, 23);
            this.strengthModifierTextBox.TabIndex = 2;
            // 
            // strengthTextBox
            // 
            this.strengthTextBox.Location = new System.Drawing.Point(88, 17);
            this.strengthTextBox.Name = "strengthTextBox";
            this.strengthTextBox.Size = new System.Drawing.Size(43, 23);
            this.strengthTextBox.TabIndex = 1;
            this.strengthTextBox.TextChanged += new System.EventHandler(this.strengthTextBox_TextChanged);
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
            // intelligenceModifierTextBox
            // 
            this.intelligenceModifierTextBox.Location = new System.Drawing.Point(137, 46);
            this.intelligenceModifierTextBox.Name = "intelligenceModifierTextBox";
            this.intelligenceModifierTextBox.ReadOnly = true;
            this.intelligenceModifierTextBox.Size = new System.Drawing.Size(43, 23);
            this.intelligenceModifierTextBox.TabIndex = 5;
            // 
            // intelligenceTextBox
            // 
            this.intelligenceTextBox.Location = new System.Drawing.Point(88, 46);
            this.intelligenceTextBox.Name = "intelligenceTextBox";
            this.intelligenceTextBox.Size = new System.Drawing.Size(43, 23);
            this.intelligenceTextBox.TabIndex = 4;
            this.intelligenceTextBox.TextChanged += new System.EventHandler(this.intelligenceTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inteligence:";
            // 
            // wisdomModifierTextBox
            // 
            this.wisdomModifierTextBox.Location = new System.Drawing.Point(137, 75);
            this.wisdomModifierTextBox.Name = "wisdomModifierTextBox";
            this.wisdomModifierTextBox.ReadOnly = true;
            this.wisdomModifierTextBox.Size = new System.Drawing.Size(43, 23);
            this.wisdomModifierTextBox.TabIndex = 8;
            // 
            // wisdomTextBox
            // 
            this.wisdomTextBox.Location = new System.Drawing.Point(88, 75);
            this.wisdomTextBox.Name = "wisdomTextBox";
            this.wisdomTextBox.Size = new System.Drawing.Size(43, 23);
            this.wisdomTextBox.TabIndex = 7;
            this.wisdomTextBox.TextChanged += new System.EventHandler(this.wisdomTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wisdom:";
            // 
            // dexterifyModifierTextBox
            // 
            this.dexterifyModifierTextBox.Location = new System.Drawing.Point(137, 104);
            this.dexterifyModifierTextBox.Name = "dexterifyModifierTextBox";
            this.dexterifyModifierTextBox.ReadOnly = true;
            this.dexterifyModifierTextBox.Size = new System.Drawing.Size(43, 23);
            this.dexterifyModifierTextBox.TabIndex = 11;
            // 
            // dexterifyTextBox
            // 
            this.dexterifyTextBox.Location = new System.Drawing.Point(88, 104);
            this.dexterifyTextBox.Name = "dexterifyTextBox";
            this.dexterifyTextBox.Size = new System.Drawing.Size(43, 23);
            this.dexterifyTextBox.TabIndex = 10;
            this.dexterifyTextBox.TextChanged += new System.EventHandler(this.dexterifyTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dexterity:";
            // 
            // constiutionModifierTextBox
            // 
            this.constiutionModifierTextBox.Location = new System.Drawing.Point(137, 133);
            this.constiutionModifierTextBox.Name = "constiutionModifierTextBox";
            this.constiutionModifierTextBox.ReadOnly = true;
            this.constiutionModifierTextBox.Size = new System.Drawing.Size(43, 23);
            this.constiutionModifierTextBox.TabIndex = 14;
            // 
            // constiutionTextBox
            // 
            this.constiutionTextBox.Location = new System.Drawing.Point(88, 133);
            this.constiutionTextBox.Name = "constiutionTextBox";
            this.constiutionTextBox.Size = new System.Drawing.Size(43, 23);
            this.constiutionTextBox.TabIndex = 13;
            this.constiutionTextBox.TextChanged += new System.EventHandler(this.constiutionTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Constitution:";
            // 
            // AbilityScoresPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "AbilityScoresPanel";
            this.Size = new System.Drawing.Size(199, 168);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

   }

   #endregion

   private GroupBox groupBox1;
   private TextBox strengthModifierTextBox;
   private TextBox strengthTextBox;
   private Label label1;
   private TextBox constiutionModifierTextBox;
   private TextBox constiutionTextBox;
   private Label label5;
   private TextBox dexterifyModifierTextBox;
   private TextBox dexterifyTextBox;
   private Label label4;
   private TextBox wisdomModifierTextBox;
   private TextBox wisdomTextBox;
   private Label label3;
   private TextBox intelligenceModifierTextBox;
   private TextBox intelligenceTextBox;
   private Label label2;
}
