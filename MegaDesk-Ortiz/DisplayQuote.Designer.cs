﻿namespace MegaDesk_Ortiz
{
   partial class DisplayQuoteForm
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
         label1 = new Label();
         label2 = new Label();
         label3 = new Label();
         label4 = new Label();
         label5 = new Label();
         MenuBtn = new Button();
         SuspendLayout();
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new Point(15, 40);
         label1.Name = "label1";
         label1.Size = new Size(78, 20);
         label1.TabIndex = 0;
         label1.Text = "Quote For:";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new Point(268, 40);
         label2.Name = "label2";
         label2.Size = new Size(100, 20);
         label2.TabIndex = 1;
         label2.Text = "Date Created:";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Location = new Point(16, 125);
         label3.Name = "label3";
         label3.Size = new Size(73, 20);
         label3.TabIndex = 2;
         label3.Text = "Base Cost";
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.Location = new Point(16, 158);
         label4.Name = "label4";
         label4.Size = new Size(126, 20);
         label4.TabIndex = 3;
         label4.Text = "Surface Area Cost";
         // 
         // label5
         // 
         label5.AutoSize = true;
         label5.Location = new Point(16, 191);
         label5.Name = "label5";
         label5.Size = new Size(99, 20);
         label5.TabIndex = 4;
         label5.Text = "Drawers Cost:";
         // 
         // MenuBtn
         // 
         MenuBtn.Location = new Point(447, 374);
         MenuBtn.Name = "MenuBtn";
         MenuBtn.Size = new Size(94, 29);
         MenuBtn.TabIndex = 5;
         MenuBtn.Text = "Menu";
         MenuBtn.UseVisualStyleBackColor = true;
         MenuBtn.Click += button1_Click;
         // 
         // DisplayQuoteForm
         // 
         AutoScaleDimensions = new SizeF(8F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(553, 415);
         Controls.Add(MenuBtn);
         Controls.Add(label5);
         Controls.Add(label4);
         Controls.Add(label3);
         Controls.Add(label2);
         Controls.Add(label1);
         Margin = new Padding(3, 4, 3, 4);
         Name = "DisplayQuoteForm";
         Text = "DisplayQuote";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Label label1;
      private Label label2;
      private Label label3;
      private Label label4;
      private Label label5;
      private Button MenuBtn;
   }
}