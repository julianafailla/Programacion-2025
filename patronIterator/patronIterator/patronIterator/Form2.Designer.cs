namespace patronIterator
{
    partial class Form2
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
            TextBox textBoxUsuario;
            UsuarioLabel = new Label();
            buttonNext = new Button();
            buttonPrior = new Button();
            buttonGoFirst = new Button();
            buttonGoLast = new Button();
            buttonVerNext = new Button();
            buttonBuscar = new Button();
            textBoxUsuario = new TextBox();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(207, 109);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(204, 27);
            textBoxUsuario.TabIndex = 0;
            textBoxUsuario.TextChanged += textBoxUsuario_TextChanged;
            // 
            // UsuarioLabel
            // 
            UsuarioLabel.AutoSize = true;
            UsuarioLabel.Location = new Point(439, 113);
            UsuarioLabel.Name = "UsuarioLabel";
            UsuarioLabel.Size = new Size(59, 20);
            UsuarioLabel.TabIndex = 1;
            UsuarioLabel.Text = "Usuario";
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(130, 224);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(81, 40);
            buttonNext.TabIndex = 2;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonPrior
            // 
            buttonPrior.Location = new Point(227, 225);
            buttonPrior.Name = "buttonPrior";
            buttonPrior.Size = new Size(84, 40);
            buttonPrior.TabIndex = 3;
            buttonPrior.Text = "Prior";
            buttonPrior.UseVisualStyleBackColor = true;
            buttonPrior.Click += buttonPrior_Click;
            // 
            // buttonGoFirst
            // 
            buttonGoFirst.Location = new Point(321, 224);
            buttonGoFirst.Name = "buttonGoFirst";
            buttonGoFirst.Size = new Size(90, 44);
            buttonGoFirst.TabIndex = 4;
            buttonGoFirst.Text = "Go First";
            buttonGoFirst.UseVisualStyleBackColor = true;
            buttonGoFirst.Click += buttonGoFirst_Click;
            // 
            // buttonGoLast
            // 
            buttonGoLast.Location = new Point(418, 225);
            buttonGoLast.Name = "buttonGoLast";
            buttonGoLast.Size = new Size(80, 40);
            buttonGoLast.TabIndex = 5;
            buttonGoLast.Text = "Go Last";
            buttonGoLast.UseVisualStyleBackColor = true;
            buttonGoLast.Click += buttonGoLast_Click;
            // 
            // buttonVerNext
            // 
            buttonVerNext.Location = new Point(504, 225);
            buttonVerNext.Name = "buttonVerNext";
            buttonVerNext.Size = new Size(98, 43);
            buttonVerNext.TabIndex = 6;
            buttonVerNext.Text = "Ver Next";
            buttonVerNext.UseVisualStyleBackColor = true;
            buttonVerNext.Click += buttonVerNext_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(341, 309);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(81, 30);
            buttonBuscar.TabIndex = 7;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonVerNext);
            Controls.Add(buttonGoLast);
            Controls.Add(buttonGoFirst);
            Controls.Add(buttonPrior);
            Controls.Add(buttonNext);
            Controls.Add(UsuarioLabel);
            Controls.Add(textBoxUsuario);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuario;
        private Label UsuarioLabel;
        private Button buttonNext;
        private Button buttonPrior;
        private Button buttonGoFirst;
        private Button buttonGoLast;
        private Button buttonVerNext;
        private Button buttonBuscar;
    }
}