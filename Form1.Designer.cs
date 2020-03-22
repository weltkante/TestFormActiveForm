namespace TestFormActiveForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ///
            /// Button1
            /// 
            this.Button1 = new System.Windows.Forms.Button();
            this.Button1.Name = "Button1";
            this.Button1.Text = this.Button1.Name;
            this.Button1.Size = new System.Drawing.Size(45, 20);
            this.Button1.Location = new System.Drawing.Point(10, 10);
            this.Button1.Click += this.Button1_Click;
            ///
            /// Form1
            ///
            this.Controls.Add(this.Button1);
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 300);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = false;
            this.Text = "Form1";
            this.UseWaitCursor = false;
            this.AllowDrop = false;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.DoubleBuffered = false;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CausesValidation = true;
            this.AutoScroll = false;
            this.AutoScroll = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.Location = new System.Drawing.Point(3, 23);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.KeyPreview = false;
            this.ControlBox = true;
            this.HelpButton = false;
            this.IsMdiContainer = false;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.ShowIcon = true;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Auto;
            this.TopMost = false;
        }

        private System.Windows.Forms.Button Button1;
        #endregion
    }
}

