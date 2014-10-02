namespace MultithreadApprenticeForm
{
  partial class MainForm
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
      this.buttonThread = new System.Windows.Forms.Button();
      this.pictureBox = new System.Windows.Forms.PictureBox();
      this.buttonNoThread = new System.Windows.Forms.Button();
      this.btnCopy = new System.Windows.Forms.Button();
      this.lblInfo = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonThread
      // 
      this.buttonThread.Location = new System.Drawing.Point(12, 12);
      this.buttonThread.Name = "buttonThread";
      this.buttonThread.Size = new System.Drawing.Size(98, 23);
      this.buttonThread.TabIndex = 0;
      this.buttonThread.Text = "Use thread";
      this.buttonThread.UseVisualStyleBackColor = true;
      this.buttonThread.Click += new System.EventHandler(this.buttonThread_Click);
      // 
      // pictureBox
      // 
      this.pictureBox.Location = new System.Drawing.Point(121, 12);
      this.pictureBox.Name = "pictureBox";
      this.pictureBox.Size = new System.Drawing.Size(115, 109);
      this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox.TabIndex = 1;
      this.pictureBox.TabStop = false;
      // 
      // buttonNoThread
      // 
      this.buttonNoThread.Location = new System.Drawing.Point(12, 41);
      this.buttonNoThread.Name = "buttonNoThread";
      this.buttonNoThread.Size = new System.Drawing.Size(98, 23);
      this.buttonNoThread.TabIndex = 2;
      this.buttonNoThread.Text = "Don\'t use thread";
      this.buttonNoThread.UseVisualStyleBackColor = true;
      this.buttonNoThread.Click += new System.EventHandler(this.buttonNoThread_Click);
      // 
      // btnCopy
      // 
      this.btnCopy.Location = new System.Drawing.Point(12, 97);
      this.btnCopy.Name = "btnCopy";
      this.btnCopy.Size = new System.Drawing.Size(98, 23);
      this.btnCopy.TabIndex = 3;
      this.btnCopy.Text = "Copy 100x";
      this.btnCopy.UseVisualStyleBackColor = true;
      this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
      // 
      // lblInfo
      // 
      this.lblInfo.AutoSize = true;
      this.lblInfo.Location = new System.Drawing.Point(12, 74);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(44, 13);
      this.lblInfo.TabIndex = 4;
      this.lblInfo.Text = "Nothing";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(248, 132);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.btnCopy);
      this.Controls.Add(this.buttonNoThread);
      this.Controls.Add(this.pictureBox);
      this.Controls.Add(this.buttonThread);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "MainForm";
      this.Text = "Thumbnail";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonThread;
    public System.Windows.Forms.PictureBox pictureBox;
    private System.Windows.Forms.Button buttonNoThread;
    private System.Windows.Forms.Button btnCopy;
    public System.Windows.Forms.Label lblInfo;
  }
}

