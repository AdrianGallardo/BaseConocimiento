namespace BaseConocimiento
{
  partial class Form1
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
    private void InitializeComponent()
    {
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
      this.txtTextFind = new System.Windows.Forms.ToolStripTextBox();
      this.btnFind = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.btnFirst = new System.Windows.Forms.ToolStripButton();
      this.btnPrev = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.btnNext = new System.Windows.Forms.ToolStripButton();
      this.btnLast = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.label1 = new System.Windows.Forms.Label();
      this.richKBase = new System.Windows.Forms.RichTextBox();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip1
      // 
      this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtTextFind,
            this.btnFind,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSeparator4,
            this.btnFirst,
            this.btnPrev,
            this.toolStripSeparator2,
            this.btnNext,
            this.btnLast,
            this.toolStripSeparator3});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(1048, 31);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripLabel1
      // 
      this.toolStripLabel1.Name = "toolStripLabel1";
      this.toolStripLabel1.Size = new System.Drawing.Size(124, 28);
      this.toolStripLabel1.Text = "Texto a búscar";
      // 
      // txtTextFind
      // 
      this.txtTextFind.Name = "txtTextFind";
      this.txtTextFind.Size = new System.Drawing.Size(300, 31);
      this.txtTextFind.ToolTipText = "RegEx";
      // 
      // btnFind
      // 
      this.btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnFind.Image = global::BaseConocimiento.Properties.Resources.Search;
      this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnFind.Name = "btnFind";
      this.btnFind.Size = new System.Drawing.Size(28, 28);
      this.btnFind.Text = "toolStripButton1";
      this.btnFind.Click += new System.EventHandler(this.toolStripButton1_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
      // 
      // btnFirst
      // 
      this.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnFirst.Image = global::BaseConocimiento.Properties.Resources.Previous;
      this.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnFirst.Name = "btnFirst";
      this.btnFirst.Size = new System.Drawing.Size(28, 28);
      this.btnFirst.Text = "toolStripButton2";
      // 
      // btnPrev
      // 
      this.btnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnPrev.Image = global::BaseConocimiento.Properties.Resources.Previous;
      this.btnPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnPrev.Name = "btnPrev";
      this.btnPrev.Size = new System.Drawing.Size(28, 28);
      this.btnPrev.Text = "toolStripButton3";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
      // 
      // btnNext
      // 
      this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnNext.Image = global::BaseConocimiento.Properties.Resources.Next;
      this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnNext.Name = "btnNext";
      this.btnNext.Size = new System.Drawing.Size(28, 28);
      this.btnNext.Text = "toolStripButton4";
      // 
      // btnLast
      // 
      this.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnLast.Image = global::BaseConocimiento.Properties.Resources.Next;
      this.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnLast.Name = "btnLast";
      this.btnLast.Size = new System.Drawing.Size(28, 28);
      this.btnLast.Text = "toolStripButton5";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
      // 
      // toolStripLabel2
      // 
      this.toolStripLabel2.Name = "toolStripLabel2";
      this.toolStripLabel2.Size = new System.Drawing.Size(135, 28);
      this.toolStripLabel2.Text = "(0 de 0) Tickets ";
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 54);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(169, 20);
      this.label1.TabIndex = 3;
      this.label1.Text = "Base de Conocimiento";
      // 
      // richKBase
      // 
      this.richKBase.Location = new System.Drawing.Point(16, 77);
      this.richKBase.Name = "richKBase";
      this.richKBase.Size = new System.Drawing.Size(1017, 518);
      this.richKBase.TabIndex = 2;
      this.richKBase.Text = "";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1048, 648);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.richKBase);
      this.Controls.Add(this.toolStrip1);
      this.Name = "Form1";
      this.Text = "SOPORTE CAPGEMINI-BIMBO";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    private System.Windows.Forms.ToolStripTextBox txtTextFind;
    private System.Windows.Forms.ToolStripButton btnFind;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripButton btnFirst;
    private System.Windows.Forms.ToolStripButton btnPrev;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton btnNext;
    private System.Windows.Forms.ToolStripButton btnLast;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RichTextBox richKBase;
  }
}

