
namespace WindowsFormsApp1
{
    partial class CalculadoraForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Numero1numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Numero2numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Resultadolabel4 = new System.Windows.Forms.Label();
            this.OpcioncomboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numero1numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numero2numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.OpcioncomboBox1);
            this.panel1.Controls.Add(this.Resultadolabel4);
            this.panel1.Controls.Add(this.Numero2numericUpDown1);
            this.panel1.Controls.Add(this.Numero1numericUpDown1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 254);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULADORA SIMPLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUMERO 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NUMERO 2";
            // 
            // Numero1numericUpDown1
            // 
            this.Numero1numericUpDown1.Location = new System.Drawing.Point(118, 66);
            this.Numero1numericUpDown1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Numero1numericUpDown1.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.Numero1numericUpDown1.Name = "Numero1numericUpDown1";
            this.Numero1numericUpDown1.Size = new System.Drawing.Size(133, 20);
            this.Numero1numericUpDown1.TabIndex = 3;
            // 
            // Numero2numericUpDown1
            // 
            this.Numero2numericUpDown1.Location = new System.Drawing.Point(118, 111);
            this.Numero2numericUpDown1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Numero2numericUpDown1.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.Numero2numericUpDown1.Name = "Numero2numericUpDown1";
            this.Numero2numericUpDown1.Size = new System.Drawing.Size(133, 20);
            this.Numero2numericUpDown1.TabIndex = 4;
            // 
            // Resultadolabel4
            // 
            this.Resultadolabel4.AutoSize = true;
            this.Resultadolabel4.BackColor = System.Drawing.SystemColors.Control;
            this.Resultadolabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultadolabel4.ForeColor = System.Drawing.Color.Green;
            this.Resultadolabel4.Location = new System.Drawing.Point(52, 213);
            this.Resultadolabel4.Name = "Resultadolabel4";
            this.Resultadolabel4.Size = new System.Drawing.Size(119, 17);
            this.Resultadolabel4.TabIndex = 5;
            this.Resultadolabel4.Text = "RESULTADO ES:";
            // 
            // OpcioncomboBox1
            // 
            this.OpcioncomboBox1.FormattingEnabled = true;
            this.OpcioncomboBox1.Items.AddRange(new object[] {
            "SUMA",
            "RESTA",
            "MULTIPLICACION",
            "DIVISION"});
            this.OpcioncomboBox1.Location = new System.Drawing.Point(118, 152);
            this.OpcioncomboBox1.Name = "OpcioncomboBox1";
            this.OpcioncomboBox1.Size = new System.Drawing.Size(133, 21);
            this.OpcioncomboBox1.TabIndex = 6;
            this.OpcioncomboBox1.SelectedIndexChanged += new System.EventHandler(this.OpcioncomboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "OPCION";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalculadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 277);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "CalculadoraForm";
            this.ShowIcon = false;
            this.Text = "Calculadora";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numero1numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numero2numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Numero2numericUpDown1;
        private System.Windows.Forms.NumericUpDown Numero1numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox OpcioncomboBox1;
        private System.Windows.Forms.Label Resultadolabel4;
    }
}

