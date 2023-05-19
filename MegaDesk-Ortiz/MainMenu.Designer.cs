namespace MegaDesk_Ortiz
{
   partial class MainMenu
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
         AddQuote = new Button();
         SearchQuotes = new Button();
         ViewAllQuotes = new Button();
         Exit = new Button();
         label1 = new Label();
         pictureBox1 = new PictureBox();
         ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
         SuspendLayout();
         // 
         // AddQuote
         // 
         AddQuote.Location = new Point(25, 137);
         AddQuote.Margin = new Padding(3, 4, 3, 4);
         AddQuote.Name = "AddQuote";
         AddQuote.Size = new Size(128, 31);
         AddQuote.TabIndex = 0;
         AddQuote.Text = "AddQuote";
         AddQuote.UseVisualStyleBackColor = true;
         AddQuote.Click += AddQuote_Click;
         // 
         // SearchQuotes
         // 
         SearchQuotes.Location = new Point(25, 196);
         SearchQuotes.Margin = new Padding(3, 4, 3, 4);
         SearchQuotes.Name = "SearchQuotes";
         SearchQuotes.Size = new Size(128, 31);
         SearchQuotes.TabIndex = 1;
         SearchQuotes.Text = "SearchQuotes";
         SearchQuotes.UseVisualStyleBackColor = true;
         SearchQuotes.Click += SearchQuotes_Click;
         // 
         // ViewAllQuotes
         // 
         ViewAllQuotes.Location = new Point(25, 256);
         ViewAllQuotes.Margin = new Padding(3, 4, 3, 4);
         ViewAllQuotes.Name = "ViewAllQuotes";
         ViewAllQuotes.Size = new Size(128, 31);
         ViewAllQuotes.TabIndex = 2;
         ViewAllQuotes.Text = "ViewAllQuotes";
         ViewAllQuotes.UseVisualStyleBackColor = true;
         ViewAllQuotes.Click += ViewAllQuotes_Click;
         // 
         // Exit
         // 
         Exit.Location = new Point(25, 313);
         Exit.Margin = new Padding(3, 4, 3, 4);
         Exit.Name = "Exit";
         Exit.Size = new Size(128, 31);
         Exit.TabIndex = 3;
         Exit.Text = "Exit";
         Exit.UseVisualStyleBackColor = true;
         Exit.Click += Exit_Click;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
         label1.Location = new Point(195, 39);
         label1.Name = "label1";
         label1.Size = new Size(151, 30);
         label1.TabIndex = 4;
         label1.Text = "MegaDesk 2.0";
         label1.Click += label1_Click;
         // 
         // pictureBox1
         // 
         pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
         pictureBox1.Location = new Point(236, 154);
         pictureBox1.Name = "pictureBox1";
         pictureBox1.Size = new Size(280, 173);
         pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
         pictureBox1.TabIndex = 5;
         pictureBox1.TabStop = false;
         pictureBox1.Click += pictureBox1_Click_1;
         // 
         // MainMenu
         // 
         AutoScaleDimensions = new SizeF(8F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(553, 415);
         Controls.Add(pictureBox1);
         Controls.Add(label1);
         Controls.Add(Exit);
         Controls.Add(ViewAllQuotes);
         Controls.Add(SearchQuotes);
         Controls.Add(AddQuote);
         Margin = new Padding(3, 4, 3, 4);
         Name = "MainMenu";
         StartPosition = FormStartPosition.CenterScreen;
         Text = "Menu";
         ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Button AddQuote;
      private Button SearchQuotes;
      private Button ViewAllQuotes;
      private Button Exit;
      private Label label1;
      private PictureBox pictureBox1;
   }
}