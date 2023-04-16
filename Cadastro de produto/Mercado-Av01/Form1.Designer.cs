
namespace Mercado_Av01
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MostrarDados = new System.Windows.Forms.Button();
            this.LimparForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.H1 = new System.Windows.Forms.Label();
            this.ProdPerec = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NomeProd = new System.Windows.Forms.TextBox();
            this.DescProd = new System.Windows.Forms.TextBox();
            this.UnidProd = new System.Windows.Forms.ComboBox();
            this.SimPerec = new System.Windows.Forms.RadioButton();
            this.NaoPerec = new System.Windows.Forms.RadioButton();
            this.ParticPromo = new System.Windows.Forms.CheckBox();
            this.LimitEstoq = new System.Windows.Forms.CheckBox();
            this.LocalRefrig = new System.Windows.Forms.CheckBox();
            this.DataFabric = new System.Windows.Forms.DateTimePicker();
            this.DataValid = new System.Windows.Forms.DateTimePicker();
            this.DetalheProd = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SairForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DetalheProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // MostrarDados
            // 
            this.MostrarDados.BackColor = System.Drawing.Color.Green;
            this.MostrarDados.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.MostrarDados, "MostrarDados");
            this.MostrarDados.ForeColor = System.Drawing.Color.White;
            this.MostrarDados.Name = "MostrarDados";
            this.MostrarDados.UseVisualStyleBackColor = false;
            this.MostrarDados.Click += new System.EventHandler(this.MostrarDados_Click);
            // 
            // LimparForm
            // 
            this.LimparForm.BackColor = System.Drawing.Color.White;
            this.LimparForm.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.LimparForm, "LimparForm");
            this.LimparForm.ForeColor = System.Drawing.Color.Green;
            this.LimparForm.Name = "LimparForm";
            this.LimparForm.UseVisualStyleBackColor = false;
            this.LimparForm.Click += new System.EventHandler(this.LimparForm_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // H1
            // 
            resources.ApplyResources(this.H1, "H1");
            this.H1.BackColor = System.Drawing.Color.White;
            this.H1.ForeColor = System.Drawing.Color.Green;
            this.H1.Name = "H1";
            // 
            // ProdPerec
            // 
            resources.ApplyResources(this.ProdPerec, "ProdPerec");
            this.ProdPerec.Name = "ProdPerec";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mercado_Av01.Properties.Resources.undraw_online_groceries_a02y__2_;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // NomeProd
            // 
            this.NomeProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.NomeProd, "NomeProd");
            this.NomeProd.Name = "NomeProd";
            // 
            // DescProd
            // 
            this.DescProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.DescProd, "DescProd");
            this.DescProd.Name = "DescProd";
            // 
            // UnidProd
            // 
            this.UnidProd.BackColor = System.Drawing.Color.White;
            this.UnidProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnidProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnidProd.ForeColor = System.Drawing.Color.Black;
            this.UnidProd.FormattingEnabled = true;
            this.UnidProd.Items.AddRange(new object[] {
            resources.GetString("UnidProd.Items"),
            resources.GetString("UnidProd.Items1"),
            resources.GetString("UnidProd.Items2"),
            resources.GetString("UnidProd.Items3"),
            resources.GetString("UnidProd.Items4"),
            resources.GetString("UnidProd.Items5"),
            resources.GetString("UnidProd.Items6"),
            resources.GetString("UnidProd.Items7"),
            resources.GetString("UnidProd.Items8")});
            resources.ApplyResources(this.UnidProd, "UnidProd");
            this.UnidProd.Name = "UnidProd";
            // 
            // SimPerec
            // 
            resources.ApplyResources(this.SimPerec, "SimPerec");
            this.SimPerec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SimPerec.Name = "SimPerec";
            this.SimPerec.TabStop = true;
            this.SimPerec.UseVisualStyleBackColor = true;
            // 
            // NaoPerec
            // 
            resources.ApplyResources(this.NaoPerec, "NaoPerec");
            this.NaoPerec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NaoPerec.Name = "NaoPerec";
            this.NaoPerec.TabStop = true;
            this.NaoPerec.UseVisualStyleBackColor = true;
            // 
            // ParticPromo
            // 
            resources.ApplyResources(this.ParticPromo, "ParticPromo");
            this.ParticPromo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ParticPromo.Name = "ParticPromo";
            this.ParticPromo.UseVisualStyleBackColor = true;
            // 
            // LimitEstoq
            // 
            resources.ApplyResources(this.LimitEstoq, "LimitEstoq");
            this.LimitEstoq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LimitEstoq.Name = "LimitEstoq";
            this.LimitEstoq.UseVisualStyleBackColor = true;
            // 
            // LocalRefrig
            // 
            resources.ApplyResources(this.LocalRefrig, "LocalRefrig");
            this.LocalRefrig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LocalRefrig.Name = "LocalRefrig";
            this.LocalRefrig.UseVisualStyleBackColor = true;
            // 
            // DataFabric
            // 
            this.DataFabric.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.DataFabric, "DataFabric");
            this.DataFabric.Name = "DataFabric";
            // 
            // DataValid
            // 
            this.DataValid.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.DataValid, "DataValid");
            this.DataValid.Name = "DataValid";
            // 
            // DetalheProd
            // 
            this.DetalheProd.Controls.Add(this.ParticPromo);
            this.DetalheProd.Controls.Add(this.LimitEstoq);
            this.DetalheProd.Controls.Add(this.LocalRefrig);
            resources.ApplyResources(this.DetalheProd, "DetalheProd");
            this.DetalheProd.Name = "DetalheProd";
            this.DetalheProd.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // SairForm
            // 
            this.SairForm.BackColor = System.Drawing.Color.White;
            this.SairForm.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.SairForm, "SairForm");
            this.SairForm.ForeColor = System.Drawing.Color.Green;
            this.SairForm.Name = "SairForm";
            this.SairForm.UseVisualStyleBackColor = false;
            this.SairForm.Click += new System.EventHandler(this.SairForm_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SairForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DetalheProd);
            this.Controls.Add(this.DataValid);
            this.Controls.Add(this.DataFabric);
            this.Controls.Add(this.NaoPerec);
            this.Controls.Add(this.SimPerec);
            this.Controls.Add(this.UnidProd);
            this.Controls.Add(this.DescProd);
            this.Controls.Add(this.NomeProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProdPerec);
            this.Controls.Add(this.H1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LimparForm);
            this.Controls.Add(this.MostrarDados);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DetalheProd.ResumeLayout(false);
            this.DetalheProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button MostrarDados;
        private System.Windows.Forms.Button LimparForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label H1;
        private System.Windows.Forms.Label ProdPerec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeProd;
        private System.Windows.Forms.TextBox DescProd;
        private System.Windows.Forms.ComboBox UnidProd;
        private System.Windows.Forms.RadioButton SimPerec;
        private System.Windows.Forms.RadioButton NaoPerec;
        private System.Windows.Forms.CheckBox ParticPromo;
        private System.Windows.Forms.CheckBox LimitEstoq;
        private System.Windows.Forms.CheckBox LocalRefrig;
        private System.Windows.Forms.DateTimePicker DataFabric;
        private System.Windows.Forms.DateTimePicker DataValid;
        private System.Windows.Forms.GroupBox DetalheProd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SairForm;
    }
}

