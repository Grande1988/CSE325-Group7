namespace MegaDesk_Ortiz
{
   partial class AddQuoteForm
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
         Menu = new Button();
         label1 = new Label();
         label2 = new Label();
         label3 = new Label();
         label4 = new Label();
         label5 = new Label();
         label6 = new Label();
         label7 = new Label();
         customerName = new TextBox();
         surfaceMaterial = new ComboBox();
         rushOrder = new ComboBox();
         numericUpDown1 = new NumericUpDown();
         numericUpDown2 = new NumericUpDown();
         numericUpDown3 = new NumericUpDown();
         SubmitBtn = new Button();
         ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
         ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
         ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
         SuspendLayout();
         // 
         // Menu
         // 
         Menu.Location = new Point(322, 371);
         Menu.Margin = new Padding(3, 4, 3, 4);
         Menu.Name = "Menu";
         Menu.Size = new Size(86, 31);
         Menu.TabIndex = 0;
         Menu.Text = "Menu";
         Menu.UseVisualStyleBackColor = true;
         Menu.Click += Menu_Click;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new Point(33, 57);
         label1.Name = "label1";
         label1.Size = new Size(138, 20);
         label1.TabIndex = 1;
         label1.Text = "Customer full name";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new Point(31, 116);
         label2.Name = "label2";
         label2.Size = new Size(145, 20);
         label2.TabIndex = 2;
         label2.Text = "Size of desk in width";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Location = new Point(33, 188);
         label3.Name = "label3";
         label3.Size = new Size(147, 20);
         label3.TabIndex = 3;
         label3.Text = "Size of desk in depth";
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.Location = new Point(33, 247);
         label4.Name = "label4";
         label4.Size = new Size(137, 20);
         label4.TabIndex = 4;
         label4.Text = "Number of drawers";
         // 
         // label5
         // 
         label5.AutoSize = true;
         label5.Location = new Point(274, 188);
         label5.Name = "label5";
         label5.Size = new Size(174, 20);
         label5.TabIndex = 5;
         label5.Text = "Desktop surface material";
         // 
         // label6
         // 
         label6.AutoSize = true;
         label6.Location = new Point(274, 116);
         label6.Name = "label6";
         label6.Size = new Size(134, 20);
         label6.TabIndex = 6;
         label6.Text = "Rush order options";
         // 
         // label7
         // 
         label7.AutoSize = true;
         label7.Location = new Point(215, 12);
         label7.Name = "label7";
         label7.Size = new Size(111, 20);
         label7.TabIndex = 7;
         label7.Text = "Add new quote";
         // 
         // customerName
         // 
         customerName.Location = new Point(193, 53);
         customerName.Margin = new Padding(3, 4, 3, 4);
         customerName.Name = "customerName";
         customerName.Size = new Size(303, 27);
         customerName.TabIndex = 8;
         customerName.TextChanged += customerName_TextChanged;
         // 
         // surfaceMaterial
         // 
         surfaceMaterial.FormattingEnabled = true;
         surfaceMaterial.Location = new Point(448, 177);
         surfaceMaterial.Margin = new Padding(3, 4, 3, 4);
         surfaceMaterial.Name = "surfaceMaterial";
         surfaceMaterial.Size = new Size(93, 28);
         surfaceMaterial.TabIndex = 12;
         surfaceMaterial.SelectedIndexChanged += surfaceMaterial_SelectedIndexChanged;
         // 
         // rushOrder
         // 
         rushOrder.FormattingEnabled = true;
         rushOrder.Location = new Point(448, 112);
         rushOrder.Margin = new Padding(3, 4, 3, 4);
         rushOrder.Name = "rushOrder";
         rushOrder.Size = new Size(93, 28);
         rushOrder.TabIndex = 13;
         // 
         // numericUpDown1
         // 
         numericUpDown1.Location = new Point(182, 105);
         numericUpDown1.Margin = new Padding(3, 4, 3, 4);
         numericUpDown1.Maximum = new decimal(new int[] { 96, 0, 0, 0 });
         numericUpDown1.Minimum = new decimal(new int[] { 24, 0, 0, 0 });
         numericUpDown1.Name = "numericUpDown1";
         numericUpDown1.Size = new Size(57, 27);
         numericUpDown1.TabIndex = 14;
         numericUpDown1.Value = new decimal(new int[] { 24, 0, 0, 0 });
         // 
         // numericUpDown2
         // 
         numericUpDown2.Location = new Point(182, 177);
         numericUpDown2.Margin = new Padding(3, 4, 3, 4);
         numericUpDown2.Maximum = new decimal(new int[] { 48, 0, 0, 0 });
         numericUpDown2.Minimum = new decimal(new int[] { 12, 0, 0, 0 });
         numericUpDown2.Name = "numericUpDown2";
         numericUpDown2.Size = new Size(57, 27);
         numericUpDown2.TabIndex = 15;
         numericUpDown2.Value = new decimal(new int[] { 12, 0, 0, 0 });
         // 
         // numericUpDown3
         // 
         numericUpDown3.Location = new Point(182, 236);
         numericUpDown3.Margin = new Padding(3, 4, 3, 4);
         numericUpDown3.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
         numericUpDown3.Name = "numericUpDown3";
         numericUpDown3.Size = new Size(57, 27);
         numericUpDown3.TabIndex = 16;
         // 
         // SubmitBtn
         // 
         SubmitBtn.Location = new Point(447, 374);
         SubmitBtn.Name = "SubmitBtn";
         SubmitBtn.Size = new Size(94, 29);
         SubmitBtn.TabIndex = 17;
         SubmitBtn.Text = "Save Quote";
         SubmitBtn.UseVisualStyleBackColor = true;
         SubmitBtn.Click += button1_Click;
         // 
         // AddQuoteForm
         // 
         AutoScaleDimensions = new SizeF(8F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(553, 415);
         Controls.Add(SubmitBtn);
         Controls.Add(numericUpDown3);
         Controls.Add(numericUpDown2);
         Controls.Add(numericUpDown1);
         Controls.Add(rushOrder);
         Controls.Add(surfaceMaterial);
         Controls.Add(customerName);
         Controls.Add(label7);
         Controls.Add(label6);
         Controls.Add(label5);
         Controls.Add(label4);
         Controls.Add(label3);
         Controls.Add(label2);
         Controls.Add(label1);
         Controls.Add(Menu);
         Margin = new Padding(3, 4, 3, 4);
         Name = "AddQuoteForm";
         StartPosition = FormStartPosition.CenterScreen;
         Text = "AddQuote";
         ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
         ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
         ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Button Menu;
      private Label label1;
      private Label label2;
      private Label label3;
      private Label label4;
      private Label label5;
      private Label label6;
      private Label label7;
      private TextBox customerName;
      private ComboBox surfaceMaterial;
      private ComboBox rushOrder;
      private NumericUpDown numericUpDown1;
      private NumericUpDown numericUpDown2;
      private NumericUpDown numericUpDown3;
      private Button SubmitBtn;
   }
}