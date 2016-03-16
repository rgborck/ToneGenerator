namespace ToneGenerator
{
  partial class ToneGenerator
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.trkFrequency = new System.Windows.Forms.TrackBar();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.numStep = new System.Windows.Forms.NumericUpDown();
      this.btnMinus = new System.Windows.Forms.Button();
      this.btnPlus = new System.Windows.Forms.Button();
      this.btnPlay = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.txtFrequency = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.trkFrequency)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numStep)).BeginInit();
      this.SuspendLayout();
      // 
      // trkFrequency
      // 
      this.trkFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trkFrequency.Location = new System.Drawing.Point(6, 19);
      this.trkFrequency.Maximum = 30000;
      this.trkFrequency.Name = "trkFrequency";
      this.trkFrequency.Size = new System.Drawing.Size(309, 45);
      this.trkFrequency.TabIndex = 0;
      this.trkFrequency.Value = 30;
      this.trkFrequency.Scroll += new System.EventHandler(this.trkFrequency_Scroll);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.numStep);
      this.groupBox1.Controls.Add(this.btnMinus);
      this.groupBox1.Controls.Add(this.btnPlus);
      this.groupBox1.Controls.Add(this.btnPlay);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txtFrequency);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.trkFrequency);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(314, 112);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Tone Specification";
      // 
      // numStep
      // 
      this.numStep.Location = new System.Drawing.Point(108, 61);
      this.numStep.Name = "numStep";
      this.numStep.Size = new System.Drawing.Size(91, 20);
      this.numStep.TabIndex = 7;
      this.numStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // btnMinus
      // 
      this.btnMinus.Location = new System.Drawing.Point(72, 58);
      this.btnMinus.Name = "btnMinus";
      this.btnMinus.Size = new System.Drawing.Size(30, 23);
      this.btnMinus.TabIndex = 6;
      this.btnMinus.Text = "-";
      this.btnMinus.UseVisualStyleBackColor = true;
      this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
      // 
      // btnPlus
      // 
      this.btnPlus.Location = new System.Drawing.Point(205, 58);
      this.btnPlus.Name = "btnPlus";
      this.btnPlus.Size = new System.Drawing.Size(30, 23);
      this.btnPlus.TabIndex = 5;
      this.btnPlus.Text = "+";
      this.btnPlus.UseVisualStyleBackColor = true;
      this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
      // 
      // btnPlay
      // 
      this.btnPlay.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPlay.Location = new System.Drawing.Point(274, 85);
      this.btnPlay.Name = "btnPlay";
      this.btnPlay.Size = new System.Drawing.Size(28, 23);
      this.btnPlay.TabIndex = 4;
      this.btnPlay.Text = "►";
      this.btnPlay.UseVisualStyleBackColor = true;
      this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(241, 90);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(20, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Hz";
      // 
      // txtFrequency
      // 
      this.txtFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFrequency.Location = new System.Drawing.Point(72, 87);
      this.txtFrequency.Name = "txtFrequency";
      this.txtFrequency.Size = new System.Drawing.Size(163, 20);
      this.txtFrequency.TabIndex = 2;
      this.txtFrequency.Text = "440";
      this.txtFrequency.TextChanged += new System.EventHandler(this.txtFrequency_TextChanged);
      this.txtFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrequency_KeyPress);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 90);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Frequency:";
      // 
      // ToneGenerator
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(314, 112);
      this.Controls.Add(this.groupBox1);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(2000, 150);
      this.MinimumSize = new System.Drawing.Size(250, 150);
      this.Name = "ToneGenerator";
      this.Text = "Joshuan\'s Tone Generator";
      ((System.ComponentModel.ISupportInitialize)(this.trkFrequency)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numStep)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TrackBar trkFrequency;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtFrequency;
    private System.Windows.Forms.Button btnPlay;
    private System.Windows.Forms.NumericUpDown numStep;
    private System.Windows.Forms.Button btnMinus;
    private System.Windows.Forms.Button btnPlus;
  }
}

