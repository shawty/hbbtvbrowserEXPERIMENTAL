namespace EdgeWebView2Test
{
  partial class FrmMainForm
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
      this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
      this.txtAddressBar = new System.Windows.Forms.TextBox();
      this.btnGo = new System.Windows.Forms.Button();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.btnBack = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // webView
      // 
      this.webView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.webView.BackColor = System.Drawing.SystemColors.ControlDark;
      this.webView.Location = new System.Drawing.Point(12, 39);
      this.webView.Name = "webView";
      this.webView.Size = new System.Drawing.Size(1280, 720);
      this.webView.Source = new System.Uri("http://portaltv.tv/testing/", System.UriKind.Absolute);
      this.webView.TabIndex = 0;
      //this.webView.Text = "webView";
      this.webView.ZoomFactor = 1D;
      // 
      // txtAddressBar
      // 
      this.txtAddressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtAddressBar.Location = new System.Drawing.Point(94, 10);
      this.txtAddressBar.Name = "txtAddressBar";
      this.txtAddressBar.Size = new System.Drawing.Size(1036, 20);
      this.txtAddressBar.TabIndex = 1;
      // 
      // btnGo
      // 
      this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnGo.Location = new System.Drawing.Point(1136, 9);
      this.btnGo.Name = "btnGo";
      this.btnGo.Size = new System.Drawing.Size(75, 23);
      this.btnGo.TabIndex = 2;
      this.btnGo.Text = "<-- GO";
      this.btnGo.UseVisualStyleBackColor = true;
      this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
      // 
      // btnRefresh
      // 
      this.btnRefresh.Location = new System.Drawing.Point(1217, 9);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(75, 23);
      this.btnRefresh.TabIndex = 3;
      this.btnRefresh.Text = "Refresh";
      this.btnRefresh.UseVisualStyleBackColor = true;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // btnBack
      // 
      this.btnBack.Location = new System.Drawing.Point(13, 9);
      this.btnBack.Name = "btnBack";
      this.btnBack.Size = new System.Drawing.Size(75, 23);
      this.btnBack.TabIndex = 4;
      this.btnBack.Text = "Go Back";
      this.btnBack.UseVisualStyleBackColor = true;
      this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
      // 
      // FrmMainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1304, 771);
      this.Controls.Add(this.btnBack);
      this.Controls.Add(this.btnRefresh);
      this.Controls.Add(this.btnGo);
      this.Controls.Add(this.txtAddressBar);
      this.Controls.Add(this.webView);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(1324, 814);
      this.MinimumSize = new System.Drawing.Size(1324, 814);
      this.Name = "FrmMainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "HBBTV Browser";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    private System.Windows.Forms.TextBox txtAddressBar;
    private System.Windows.Forms.Button btnGo;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.Button btnBack;
  }
}

