namespace Cuota_Prestamo_9_2_24
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
            lbl_Monto=new Label();
            lbl_Tasa_Interes=new Label();
            lbl_Anos=new Label();
            lbl_Cuotas=new Label();
            btn_Calcular=new Button();
            btn_Limpiar=new Button();
            btn_Salir=new Button();
            txt_Monto=new TextBox();
            txt_Tasa_Interes=new TextBox();
            txt_Cuotas=new TextBox();
            txt_Anos=new TextBox();
            lbl_Total=new Label();
            txt_Total=new TextBox();
            label1=new Label();
            SuspendLayout();
            // 
            // lbl_Monto
            // 
            lbl_Monto.AutoSize=true;
            lbl_Monto.Font=new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_Monto.Location=new Point(237, 116);
            lbl_Monto.Name="lbl_Monto";
            lbl_Monto.Size=new Size(51, 19);
            lbl_Monto.TabIndex=0;
            lbl_Monto.Text="Monto";
            // 
            // lbl_Tasa_Interes
            // 
            lbl_Tasa_Interes.AutoSize=true;
            lbl_Tasa_Interes.Font=new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_Tasa_Interes.Location=new Point(237, 158);
            lbl_Tasa_Interes.Name="lbl_Tasa_Interes";
            lbl_Tasa_Interes.Size=new Size(90, 19);
            lbl_Tasa_Interes.TabIndex=1;
            lbl_Tasa_Interes.Text="Tasa_Interes";
            // 
            // lbl_Anos
            // 
            lbl_Anos.AutoSize=true;
            lbl_Anos.Font=new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_Anos.Location=new Point(239, 220);
            lbl_Anos.Name="lbl_Anos";
            lbl_Anos.Size=new Size(41, 19);
            lbl_Anos.TabIndex=2;
            lbl_Anos.Text="Anos";
            // 
            // lbl_Cuotas
            // 
            lbl_Cuotas.AutoSize=true;
            lbl_Cuotas.Font=new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_Cuotas.Location=new Point(237, 311);
            lbl_Cuotas.Name="lbl_Cuotas";
            lbl_Cuotas.Size=new Size(55, 19);
            lbl_Cuotas.TabIndex=3;
            lbl_Cuotas.Text="Cuotas";
            // 
            // btn_Calcular
            // 
            btn_Calcular.BackColor=SystemColors.GradientActiveCaption;
            btn_Calcular.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Calcular.Location=new Point(592, 141);
            btn_Calcular.Name="btn_Calcular";
            btn_Calcular.Size=new Size(82, 34);
            btn_Calcular.TabIndex=4;
            btn_Calcular.Text="Calcular";
            btn_Calcular.UseVisualStyleBackColor=false;
            btn_Calcular.Click+=btn_Calcular_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor=SystemColors.GradientActiveCaption;
            btn_Limpiar.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Limpiar.Location=new Point(592, 204);
            btn_Limpiar.Name="btn_Limpiar";
            btn_Limpiar.Size=new Size(82, 34);
            btn_Limpiar.TabIndex=5;
            btn_Limpiar.Text="Limpiar";
            btn_Limpiar.UseVisualStyleBackColor=false;
            btn_Limpiar.Click+=btn_Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor=SystemColors.GradientActiveCaption;
            btn_Salir.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Salir.Location=new Point(592, 266);
            btn_Salir.Name="btn_Salir";
            btn_Salir.Size=new Size(82, 34);
            btn_Salir.TabIndex=6;
            btn_Salir.Text="Salir";
            btn_Salir.UseVisualStyleBackColor=false;
            btn_Salir.Click+=btn_Salir_Click;
            // 
            // txt_Monto
            // 
            txt_Monto.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Monto.Location=new Point(385, 113);
            txt_Monto.Name="txt_Monto";
            txt_Monto.Size=new Size(100, 26);
            txt_Monto.TabIndex=7;
            // 
            // txt_Tasa_Interes
            // 
            txt_Tasa_Interes.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Tasa_Interes.Location=new Point(385, 167);
            txt_Tasa_Interes.Name="txt_Tasa_Interes";
            txt_Tasa_Interes.Size=new Size(100, 26);
            txt_Tasa_Interes.TabIndex=8;
            // 
            // txt_Cuotas
            // 
            txt_Cuotas.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Cuotas.Location=new Point(385, 311);
            txt_Cuotas.Name="txt_Cuotas";
            txt_Cuotas.Size=new Size(100, 26);
            txt_Cuotas.TabIndex=9;
            // 
            // txt_Anos
            // 
            txt_Anos.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Anos.Location=new Point(385, 212);
            txt_Anos.Name="txt_Anos";
            txt_Anos.Size=new Size(100, 26);
            txt_Anos.TabIndex=10;
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize=true;
            lbl_Total.Font=new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_Total.Location=new Point(241, 265);
            lbl_Total.Name="lbl_Total";
            lbl_Total.Size=new Size(42, 19);
            lbl_Total.TabIndex=11;
            lbl_Total.Text="Total";
            // 
            // txt_Total
            // 
            txt_Total.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Total.Location=new Point(385, 265);
            txt_Total.Name="txt_Total";
            txt_Total.Size=new Size(100, 26);
            txt_Total.TabIndex=12;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(299, 9);
            label1.Name="label1";
            label1.Size=new Size(211, 31);
            label1.TabIndex=13;
            label1.Text="Cuota_Prestamo";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txt_Total);
            Controls.Add(lbl_Total);
            Controls.Add(txt_Anos);
            Controls.Add(txt_Cuotas);
            Controls.Add(txt_Tasa_Interes);
            Controls.Add(txt_Monto);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Calcular);
            Controls.Add(lbl_Cuotas);
            Controls.Add(lbl_Anos);
            Controls.Add(lbl_Tasa_Interes);
            Controls.Add(lbl_Monto);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Monto;
        private Label lbl_Tasa_Interes;
        private Label lbl_Anos;
        private Label lbl_Cuotas;
        private Button btn_Calcular;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private TextBox txt_Monto;
        private TextBox txt_Tasa_Interes;
        private TextBox txt_Cuotas;
        private TextBox txt_Anos;
        private Label lbl_Total;
        private TextBox txt_Total;
        private Label label1;
    }
}