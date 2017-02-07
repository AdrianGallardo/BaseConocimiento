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
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.lblRecords = new System.Windows.Forms.ToolStripLabel();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.richKBase = new System.Windows.Forms.RichTextBox();
      this.btnFilter = new System.Windows.Forms.ToolStripButton();
      this.btnNOFilter = new System.Windows.Forms.ToolStripButton();
      this.btnDownload = new System.Windows.Forms.ToolStripButton();
      this.btnFirst = new System.Windows.Forms.ToolStripButton();
      this.btnPrev = new System.Windows.Forms.ToolStripButton();
      this.btnNext = new System.Windows.Forms.ToolStripButton();
      this.btnLast = new System.Windows.Forms.ToolStripButton();
      this.btnResume = new System.Windows.Forms.ToolStripButton();
      this.btnComplete = new System.Windows.Forms.ToolStripButton();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip1
      // 
      this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtTextFind,
            this.toolStripSeparator4,
            this.btnFilter,
            this.btnNOFilter,
            this.btnDownload,
            this.toolStripSeparator1,
            this.btnFirst,
            this.btnPrev,
            this.btnNext,
            this.btnLast,
            this.toolStripSeparator3,
            this.lblRecords,
            this.toolStripSeparator2,
            this.btnResume,
            this.btnComplete});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(1048, 32);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripLabel1
      // 
      this.toolStripLabel1.Name = "toolStripLabel1";
      this.toolStripLabel1.Size = new System.Drawing.Size(124, 29);
      this.toolStripLabel1.Text = "Texto a buscar";
      // 
      // txtTextFind
      // 
      this.txtTextFind.Name = "txtTextFind";
      this.txtTextFind.Size = new System.Drawing.Size(300, 32);
      this.txtTextFind.ToolTipText = "RegEx";
      this.txtTextFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyPress);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 32);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
      // 
      // lblRecords
      // 
      this.lblRecords.Name = "lblRecords";
      this.lblRecords.Size = new System.Drawing.Size(0, 29);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
      // 
      // richKBase
      // 
      this.richKBase.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richKBase.Location = new System.Drawing.Point(0, 32);
      this.richKBase.Name = "richKBase";
      this.richKBase.Size = new System.Drawing.Size(1048, 616);
      this.richKBase.TabIndex = 2;
      this.richKBase.Text = "";
      // 
      // btnFilter
      // 
      this.btnFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnFilter.Image = global::BaseConocimiento.Properties.Resources.shopping_2;
      this.btnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnFilter.Name = "btnFilter";
      this.btnFilter.Size = new System.Drawing.Size(28, 29);
      this.btnFilter.ToolTipText = "Buscar Tickets";
      this.btnFilter.Click += new System.EventHandler(this.toolStripButton1_Click);
      // 
      // btnNOFilter
      // 
      this.btnNOFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnNOFilter.Image = global::BaseConocimiento.Properties.Resources.shopping_9;
      this.btnNOFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnNOFilter.Name = "btnNOFilter";
      this.btnNOFilter.Size = new System.Drawing.Size(28, 29);
      this.btnNOFilter.Text = "toolStripButton1";
      this.btnNOFilter.ToolTipText = "Recargar Tickets";
      this.btnNOFilter.Click += new System.EventHandler(this.btnNOFilter_Click);
      // 
      // btnDownload
      // 
      this.btnDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnDownload.Image = global::BaseConocimiento.Properties.Resources.shopping_10;
      this.btnDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnDownload.Name = "btnDownload";
      this.btnDownload.Size = new System.Drawing.Size(28, 29);
      this.btnDownload.ToolTipText = "Descargar todos los Tickets de la BD";
      this.btnDownload.Click += new System.EventHandler(this.toolStripButton1_Click_1);
      // 
      // btnFirst
      // 
      this.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnFirst.Image = global::BaseConocimiento.Properties.Resources.arrows_6;
      this.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnFirst.Name = "btnFirst";
      this.btnFirst.Size = new System.Drawing.Size(28, 29);
      this.btnFirst.ToolTipText = "Primero";
      this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
      // 
      // btnPrev
      // 
      this.btnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnPrev.Image = global::BaseConocimiento.Properties.Resources.arrows_78;
      this.btnPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnPrev.Name = "btnPrev";
      this.btnPrev.Size = new System.Drawing.Size(28, 29);
      this.btnPrev.Text = "toolStripButton3";
      this.btnPrev.ToolTipText = "Anterior";
      this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
      // 
      // btnNext
      // 
      this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnNext.Image = global::BaseConocimiento.Properties.Resources.arrows_7;
      this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnNext.Name = "btnNext";
      this.btnNext.Size = new System.Drawing.Size(28, 29);
      this.btnNext.Text = "toolStripButton4";
      this.btnNext.ToolTipText = "Siguiente";
      this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
      // 
      // btnLast
      // 
      this.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnLast.Image = global::BaseConocimiento.Properties.Resources.arrows_5;
      this.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnLast.Name = "btnLast";
      this.btnLast.Size = new System.Drawing.Size(28, 29);
      this.btnLast.Text = "toolStripButton5";
      this.btnLast.ToolTipText = "Último";
      this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
      // 
      // btnResume
      // 
      this.btnResume.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.btnResume.ForeColor = System.Drawing.Color.Green;
      this.btnResume.Image = global::BaseConocimiento.Properties.Resources.note;
      this.btnResume.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnResume.Name = "btnResume";
      this.btnResume.Size = new System.Drawing.Size(112, 29);
      this.btnResume.Text = "Resumen";
      this.btnResume.ToolTipText = "Vista Resumen";
      this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
      // 
      // btnComplete
      // 
      this.btnComplete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.btnComplete.ForeColor = System.Drawing.Color.MediumBlue;
      this.btnComplete.Image = global::BaseConocimiento.Properties.Resources.agenda;
      this.btnComplete.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnComplete.Name = "btnComplete";
      this.btnComplete.Size = new System.Drawing.Size(117, 29);
      this.btnComplete.Text = "Completa";
      this.btnComplete.ToolTipText = "Vista Completa";
      this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1048, 648);
      this.Controls.Add(this.richKBase);
      this.Controls.Add(this.toolStrip1);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Base de Conocimiento SOPORTE CAPGEMINI-BIMBO";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    private System.Windows.Forms.ToolStripTextBox txtTextFind;
    private System.Windows.Forms.ToolStripButton btnFilter;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripLabel lblRecords;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripButton btnFirst;
    private System.Windows.Forms.ToolStripButton btnPrev;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton btnNext;
    private System.Windows.Forms.ToolStripButton btnLast;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.RichTextBox richKBase;
    private System.Windows.Forms.ToolStripButton btnNOFilter;
    private System.Windows.Forms.ToolStripButton btnDownload;
    private System.Windows.Forms.ToolStripButton btnResume;
    private System.Windows.Forms.ToolStripButton btnComplete;
  }
}

