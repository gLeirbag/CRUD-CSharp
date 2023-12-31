﻿namespace CRUD_CSharp.View
{
    partial class JanelaPrincipal
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
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.txtBoxLucro = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTaxaLucro = new System.Windows.Forms.Label();
            this.txtBoxPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDataValidade = new System.Windows.Forms.Label();
            this.CalDataValidade = new System.Windows.Forms.MonthCalendar();
            this.txtBoxDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dvgTabela = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtBoxPesquisarDesc = new System.Windows.Forms.TextBox();
            this.lblDescPesquisar = new System.Windows.Forms.Label();
            this.btnGraf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Location = new System.Drawing.Point(54, 86);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(69, 20);
            this.txtBoxCodigo.TabIndex = 0;
            this.txtBoxCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxCodigo_KeyUp);
            // 
            // txtBoxLucro
            // 
            this.txtBoxLucro.Location = new System.Drawing.Point(206, 86);
            this.txtBoxLucro.Name = "txtBoxLucro";
            this.txtBoxLucro.Size = new System.Drawing.Size(68, 20);
            this.txtBoxLucro.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(51, 70);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(124, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código(Somente Edição)";
            // 
            // lblTaxaLucro
            // 
            this.lblTaxaLucro.AutoSize = true;
            this.lblTaxaLucro.Location = new System.Drawing.Point(203, 70);
            this.lblTaxaLucro.Name = "lblTaxaLucro";
            this.lblTaxaLucro.Size = new System.Drawing.Size(34, 13);
            this.lblTaxaLucro.TabIndex = 3;
            this.lblTaxaLucro.Text = "Lucro";
            // 
            // txtBoxPreco
            // 
            this.txtBoxPreco.Location = new System.Drawing.Point(206, 136);
            this.txtBoxPreco.Name = "txtBoxPreco";
            this.txtBoxPreco.Size = new System.Drawing.Size(68, 20);
            this.txtBoxPreco.TabIndex = 4;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(203, 120);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 5;
            this.lblPreco.Text = "Preço";
            // 
            // lblDataValidade
            // 
            this.lblDataValidade.AutoSize = true;
            this.lblDataValidade.Location = new System.Drawing.Point(583, 64);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(89, 13);
            this.lblDataValidade.TabIndex = 7;
            this.lblDataValidade.Text = "Data de Validade";
            // 
            // CalDataValidade
            // 
            this.CalDataValidade.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.CalDataValidade.Location = new System.Drawing.Point(586, 86);
            this.CalDataValidade.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.CalDataValidade.MaxSelectionCount = 1;
            this.CalDataValidade.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.CalDataValidade.Name = "CalDataValidade";
            this.CalDataValidade.TabIndex = 8;
            // 
            // txtBoxDescricao
            // 
            this.txtBoxDescricao.Location = new System.Drawing.Point(294, 86);
            this.txtBoxDescricao.Multiline = true;
            this.txtBoxDescricao.Name = "txtBoxDescricao";
            this.txtBoxDescricao.Size = new System.Drawing.Size(280, 162);
            this.txtBoxDescricao.TabIndex = 9;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(291, 70);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 10;
            this.lblDescricao.Text = "Descrição";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(54, 212);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(199, 212);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dvgTabela
            // 
            this.dvgTabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgTabela.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgTabela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgTabela.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dvgTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTabela.Location = new System.Drawing.Point(54, 335);
            this.dvgTabela.Name = "dvgTabela";
            this.dvgTabela.Size = new System.Drawing.Size(990, 191);
            this.dvgTabela.TabIndex = 13;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.AllowDrop = true;
            this.btnAtualizar.Location = new System.Drawing.Point(54, 541);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 14;
            this.btnAtualizar.Text = "Atualizar Tabela";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtBoxPesquisarDesc
            // 
            this.txtBoxPesquisarDesc.Location = new System.Drawing.Point(54, 309);
            this.txtBoxPesquisarDesc.Name = "txtBoxPesquisarDesc";
            this.txtBoxPesquisarDesc.Size = new System.Drawing.Size(316, 20);
            this.txtBoxPesquisarDesc.TabIndex = 15;
            this.txtBoxPesquisarDesc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxPesquisarCodigo_KeyUp);
            // 
            // lblDescPesquisar
            // 
            this.lblDescPesquisar.AutoSize = true;
            this.lblDescPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescPesquisar.Location = new System.Drawing.Point(51, 288);
            this.lblDescPesquisar.Name = "lblDescPesquisar";
            this.lblDescPesquisar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDescPesquisar.Size = new System.Drawing.Size(124, 15);
            this.lblDescPesquisar.TabIndex = 16;
            this.lblDescPesquisar.Text = "Pesquisar por Descrição";
            // 
            // btnGraf
            // 
            this.btnGraf.Location = new System.Drawing.Point(147, 541);
            this.btnGraf.Name = "btnGraf";
            this.btnGraf.Size = new System.Drawing.Size(75, 23);
            this.btnGraf.TabIndex = 17;
            this.btnGraf.Text = "Gráfico";
            this.btnGraf.UseVisualStyleBackColor = true;
            this.btnGraf.Click += new System.EventHandler(this.btnGraf_Click);
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 586);
            this.Controls.Add(this.btnGraf);
            this.Controls.Add(this.lblDescPesquisar);
            this.Controls.Add(this.txtBoxPesquisarDesc);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dvgTabela);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtBoxDescricao);
            this.Controls.Add(this.CalDataValidade);
            this.Controls.Add(this.lblDataValidade);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtBoxPreco);
            this.Controls.Add(this.lblTaxaLucro);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtBoxLucro);
            this.Controls.Add(this.txtBoxCodigo);
            this.Name = "JanelaPrincipal";
            this.Text = "JanelaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dvgTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.TextBox txtBoxLucro;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTaxaLucro;
        private System.Windows.Forms.TextBox txtBoxPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDataValidade;
        private System.Windows.Forms.MonthCalendar CalDataValidade;
        private System.Windows.Forms.TextBox txtBoxDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dvgTabela;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtBoxPesquisarDesc;
        private System.Windows.Forms.Label lblDescPesquisar;
        private System.Windows.Forms.Button btnGraf;
    }
}