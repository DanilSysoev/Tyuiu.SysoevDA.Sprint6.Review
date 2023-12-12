
namespace Tyuiu.SysoevDA.Sprint6.TaskReview.V18
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonHelp_SDA = new System.Windows.Forms.Button();
            this.buttonDone_SDA = new System.Windows.Forms.Button();
            this.groupBoxOutput_SDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewArray_SDA = new System.Windows.Forms.DataGridView();
            this.c0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SDA = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBoxVarN_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_SDA = new System.Windows.Forms.GroupBox();
            this.labelVarN_SDA = new System.Windows.Forms.Label();
            this.textBoxVarM_SDA = new System.Windows.Forms.TextBox();
            this.labelVarM_SDA = new System.Windows.Forms.Label();
            this.textBoxVarn1_SDA = new System.Windows.Forms.TextBox();
            this.textBoxVarn2_SDA = new System.Windows.Forms.TextBox();
            this.labelVarn1_SDA = new System.Windows.Forms.Label();
            this.labelVarn2_SDA = new System.Windows.Forms.Label();
            this.textBoxVarK_SDA = new System.Windows.Forms.TextBox();
            this.textBoxVarL_SDA = new System.Windows.Forms.TextBox();
            this.labelVarK_SDA = new System.Windows.Forms.Label();
            this.labelVarL_SDA = new System.Windows.Forms.Label();
            this.textBoxVarR_SDA = new System.Windows.Forms.TextBox();
            this.labelVarR_SDA = new System.Windows.Forms.Label();
            this.textBoxResult_SDA = new System.Windows.Forms.TextBox();
            this.labelResult_SDA = new System.Windows.Forms.Label();
            this.groupBoxOutput_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray_SDA)).BeginInit();
            this.groupBoxTask_SDA.SuspendLayout();
            this.groupBoxInput_SDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHelp_SDA
            // 
            this.buttonHelp_SDA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHelp_SDA.Location = new System.Drawing.Point(430, 378);
            this.buttonHelp_SDA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHelp_SDA.Name = "buttonHelp_SDA";
            this.buttonHelp_SDA.Size = new System.Drawing.Size(209, 49);
            this.buttonHelp_SDA.TabIndex = 23;
            this.buttonHelp_SDA.Text = "Справка";
            this.buttonHelp_SDA.UseVisualStyleBackColor = false;
            this.buttonHelp_SDA.Click += new System.EventHandler(this.buttonHelp_SDA_Click);
            // 
            // buttonDone_SDA
            // 
            this.buttonDone_SDA.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone_SDA.Location = new System.Drawing.Point(39, 378);
            this.buttonDone_SDA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDone_SDA.Name = "buttonDone_SDA";
            this.buttonDone_SDA.Size = new System.Drawing.Size(208, 49);
            this.buttonDone_SDA.TabIndex = 22;
            this.buttonDone_SDA.Text = "Выполнить";
            this.buttonDone_SDA.UseVisualStyleBackColor = false;
            this.buttonDone_SDA.Click += new System.EventHandler(this.buttonDone_SDA_Click);
            // 
            // groupBoxOutput_SDA
            // 
            this.groupBoxOutput_SDA.Controls.Add(this.labelResult_SDA);
            this.groupBoxOutput_SDA.Controls.Add(this.textBoxResult_SDA);
            this.groupBoxOutput_SDA.Controls.Add(this.dataGridViewArray_SDA);
            this.groupBoxOutput_SDA.Location = new System.Drawing.Point(675, 13);
            this.groupBoxOutput_SDA.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxOutput_SDA.Name = "groupBoxOutput_SDA";
            this.groupBoxOutput_SDA.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxOutput_SDA.Size = new System.Drawing.Size(367, 414);
            this.groupBoxOutput_SDA.TabIndex = 21;
            this.groupBoxOutput_SDA.TabStop = false;
            this.groupBoxOutput_SDA.Text = "Вывод данных";
            // 
            // dataGridViewArray_SDA
            // 
            this.dataGridViewArray_SDA.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewArray_SDA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArray_SDA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewArray_SDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray_SDA.ColumnHeadersVisible = false;
            this.dataGridViewArray_SDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c0,
            this.c1,
            this.c2,
            this.c3,
            this.c4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewArray_SDA.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewArray_SDA.Location = new System.Drawing.Point(25, 23);
            this.dataGridViewArray_SDA.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewArray_SDA.Name = "dataGridViewArray_SDA";
            this.dataGridViewArray_SDA.RowHeadersVisible = false;
            this.dataGridViewArray_SDA.RowHeadersWidth = 20;
            this.dataGridViewArray_SDA.Size = new System.Drawing.Size(324, 273);
            this.dataGridViewArray_SDA.TabIndex = 6;
            // 
            // c0
            // 
            this.c0.HeaderText = "c0";
            this.c0.MinimumWidth = 6;
            this.c0.Name = "c0";
            this.c0.Width = 40;
            // 
            // c1
            // 
            this.c1.HeaderText = "c1";
            this.c1.MinimumWidth = 6;
            this.c1.Name = "c1";
            this.c1.Width = 40;
            // 
            // c2
            // 
            this.c2.HeaderText = "c2";
            this.c2.MinimumWidth = 6;
            this.c2.Name = "c2";
            this.c2.Width = 40;
            // 
            // c3
            // 
            this.c3.HeaderText = "c3";
            this.c3.MinimumWidth = 6;
            this.c3.Name = "c3";
            this.c3.Width = 40;
            // 
            // c4
            // 
            this.c4.HeaderText = "c4";
            this.c4.MinimumWidth = 6;
            this.c4.Name = "c4";
            this.c4.Width = 40;
            // 
            // groupBoxTask_SDA
            // 
            this.groupBoxTask_SDA.Controls.Add(this.textBoxTask_SDA);
            this.groupBoxTask_SDA.Location = new System.Drawing.Point(16, 13);
            this.groupBoxTask_SDA.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTask_SDA.Name = "groupBoxTask_SDA";
            this.groupBoxTask_SDA.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTask_SDA.Size = new System.Drawing.Size(631, 121);
            this.groupBoxTask_SDA.TabIndex = 20;
            this.groupBoxTask_SDA.TabStop = false;
            this.groupBoxTask_SDA.Text = "Условие";
            // 
            // textBoxTask_SDA
            // 
            this.textBoxTask_SDA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTask_SDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SDA.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_SDA.Location = new System.Drawing.Point(23, 23);
            this.textBoxTask_SDA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTask_SDA.Multiline = true;
            this.textBoxTask_SDA.Name = "textBoxTask_SDA";
            this.textBoxTask_SDA.ReadOnly = true;
            this.textBoxTask_SDA.Size = new System.Drawing.Size(600, 95);
            this.textBoxTask_SDA.TabIndex = 0;
            this.textBoxTask_SDA.Text = resources.GetString("textBoxTask_SDA.Text");
            // 
            // textBoxVarN_SDA
            // 
            this.textBoxVarN_SDA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxVarN_SDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVarN_SDA.Location = new System.Drawing.Point(23, 37);
            this.textBoxVarN_SDA.Name = "textBoxVarN_SDA";
            this.textBoxVarN_SDA.Size = new System.Drawing.Size(116, 22);
            this.textBoxVarN_SDA.TabIndex = 24;
            // 
            // groupBoxInput_SDA
            // 
            this.groupBoxInput_SDA.Controls.Add(this.labelVarL_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.labelVarR_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.labelVarn2_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.labelVarM_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.labelVarK_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.labelVarn1_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.labelVarN_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.textBoxVarL_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.textBoxVarK_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.textBoxVarR_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.textBoxVarn2_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.textBoxVarn1_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.textBoxVarM_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.textBoxVarN_SDA);
            this.groupBoxInput_SDA.Location = new System.Drawing.Point(16, 141);
            this.groupBoxInput_SDA.Name = "groupBoxInput_SDA";
            this.groupBoxInput_SDA.Size = new System.Drawing.Size(631, 191);
            this.groupBoxInput_SDA.TabIndex = 25;
            this.groupBoxInput_SDA.TabStop = false;
            this.groupBoxInput_SDA.Text = "Ввод данных";
            // 
            // labelVarN_SDA
            // 
            this.labelVarN_SDA.AutoSize = true;
            this.labelVarN_SDA.Location = new System.Drawing.Point(20, 18);
            this.labelVarN_SDA.Name = "labelVarN_SDA";
            this.labelVarN_SDA.Size = new System.Drawing.Size(22, 17);
            this.labelVarN_SDA.TabIndex = 25;
            this.labelVarN_SDA.Text = "N:";
            // 
            // textBoxVarM_SDA
            // 
            this.textBoxVarM_SDA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxVarM_SDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVarM_SDA.Location = new System.Drawing.Point(23, 82);
            this.textBoxVarM_SDA.Name = "textBoxVarM_SDA";
            this.textBoxVarM_SDA.Size = new System.Drawing.Size(116, 22);
            this.textBoxVarM_SDA.TabIndex = 24;
            // 
            // labelVarM_SDA
            // 
            this.labelVarM_SDA.AutoSize = true;
            this.labelVarM_SDA.Location = new System.Drawing.Point(20, 63);
            this.labelVarM_SDA.Name = "labelVarM_SDA";
            this.labelVarM_SDA.Size = new System.Drawing.Size(23, 17);
            this.labelVarM_SDA.TabIndex = 25;
            this.labelVarM_SDA.Text = "M:";
            // 
            // textBoxVarn1_SDA
            // 
            this.textBoxVarn1_SDA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxVarn1_SDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVarn1_SDA.Location = new System.Drawing.Point(247, 37);
            this.textBoxVarn1_SDA.Name = "textBoxVarn1_SDA";
            this.textBoxVarn1_SDA.Size = new System.Drawing.Size(116, 22);
            this.textBoxVarn1_SDA.TabIndex = 24;
            // 
            // textBoxVarn2_SDA
            // 
            this.textBoxVarn2_SDA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxVarn2_SDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVarn2_SDA.Location = new System.Drawing.Point(247, 82);
            this.textBoxVarn2_SDA.Name = "textBoxVarn2_SDA";
            this.textBoxVarn2_SDA.Size = new System.Drawing.Size(116, 22);
            this.textBoxVarn2_SDA.TabIndex = 24;
            // 
            // labelVarn1_SDA
            // 
            this.labelVarn1_SDA.AutoSize = true;
            this.labelVarn1_SDA.Location = new System.Drawing.Point(244, 18);
            this.labelVarn1_SDA.Name = "labelVarn1_SDA";
            this.labelVarn1_SDA.Size = new System.Drawing.Size(28, 17);
            this.labelVarn1_SDA.TabIndex = 25;
            this.labelVarn1_SDA.Text = "n1:";
            // 
            // labelVarn2_SDA
            // 
            this.labelVarn2_SDA.AutoSize = true;
            this.labelVarn2_SDA.Location = new System.Drawing.Point(244, 63);
            this.labelVarn2_SDA.Name = "labelVarn2_SDA";
            this.labelVarn2_SDA.Size = new System.Drawing.Size(28, 17);
            this.labelVarn2_SDA.TabIndex = 25;
            this.labelVarn2_SDA.Text = "n2:";
            // 
            // textBoxVarK_SDA
            // 
            this.textBoxVarK_SDA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxVarK_SDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVarK_SDA.Location = new System.Drawing.Point(487, 37);
            this.textBoxVarK_SDA.Name = "textBoxVarK_SDA";
            this.textBoxVarK_SDA.Size = new System.Drawing.Size(116, 22);
            this.textBoxVarK_SDA.TabIndex = 24;
            // 
            // textBoxVarL_SDA
            // 
            this.textBoxVarL_SDA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxVarL_SDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVarL_SDA.Location = new System.Drawing.Point(487, 82);
            this.textBoxVarL_SDA.Name = "textBoxVarL_SDA";
            this.textBoxVarL_SDA.Size = new System.Drawing.Size(116, 22);
            this.textBoxVarL_SDA.TabIndex = 24;
            // 
            // labelVarK_SDA
            // 
            this.labelVarK_SDA.AutoSize = true;
            this.labelVarK_SDA.Location = new System.Drawing.Point(484, 18);
            this.labelVarK_SDA.Name = "labelVarK_SDA";
            this.labelVarK_SDA.Size = new System.Drawing.Size(21, 17);
            this.labelVarK_SDA.TabIndex = 25;
            this.labelVarK_SDA.Text = "K:";
            // 
            // labelVarL_SDA
            // 
            this.labelVarL_SDA.AutoSize = true;
            this.labelVarL_SDA.Location = new System.Drawing.Point(484, 63);
            this.labelVarL_SDA.Name = "labelVarL_SDA";
            this.labelVarL_SDA.Size = new System.Drawing.Size(20, 17);
            this.labelVarL_SDA.TabIndex = 25;
            this.labelVarL_SDA.Text = "L:";
            // 
            // textBoxVarR_SDA
            // 
            this.textBoxVarR_SDA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxVarR_SDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVarR_SDA.Location = new System.Drawing.Point(247, 126);
            this.textBoxVarR_SDA.Name = "textBoxVarR_SDA";
            this.textBoxVarR_SDA.Size = new System.Drawing.Size(116, 22);
            this.textBoxVarR_SDA.TabIndex = 24;
            // 
            // labelVarR_SDA
            // 
            this.labelVarR_SDA.AutoSize = true;
            this.labelVarR_SDA.Location = new System.Drawing.Point(244, 107);
            this.labelVarR_SDA.Name = "labelVarR_SDA";
            this.labelVarR_SDA.Size = new System.Drawing.Size(22, 17);
            this.labelVarR_SDA.TabIndex = 25;
            this.labelVarR_SDA.Text = "R:";
            // 
            // textBoxResult_SDA
            // 
            this.textBoxResult_SDA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxResult_SDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_SDA.Location = new System.Drawing.Point(154, 372);
            this.textBoxResult_SDA.Name = "textBoxResult_SDA";
            this.textBoxResult_SDA.ReadOnly = true;
            this.textBoxResult_SDA.Size = new System.Drawing.Size(185, 15);
            this.textBoxResult_SDA.TabIndex = 7;
            // 
            // labelResult_SDA
            // 
            this.labelResult_SDA.AutoSize = true;
            this.labelResult_SDA.Location = new System.Drawing.Point(94, 370);
            this.labelResult_SDA.Name = "labelResult_SDA";
            this.labelResult_SDA.Size = new System.Drawing.Size(54, 17);
            this.labelResult_SDA.TabIndex = 26;
            this.labelResult_SDA.Text = "Сумма:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 459);
            this.Controls.Add(this.groupBoxInput_SDA);
            this.Controls.Add(this.buttonHelp_SDA);
            this.Controls.Add(this.buttonDone_SDA);
            this.Controls.Add(this.groupBoxOutput_SDA);
            this.Controls.Add(this.groupBoxTask_SDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SprintReview #6";
            this.groupBoxOutput_SDA.ResumeLayout(false);
            this.groupBoxOutput_SDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray_SDA)).EndInit();
            this.groupBoxTask_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.PerformLayout();
            this.groupBoxInput_SDA.ResumeLayout(false);
            this.groupBoxInput_SDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHelp_SDA;
        private System.Windows.Forms.Button buttonDone_SDA;
        private System.Windows.Forms.GroupBox groupBoxOutput_SDA;
        private System.Windows.Forms.DataGridView dataGridViewArray_SDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn c0;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.GroupBox groupBoxTask_SDA;
        private System.Windows.Forms.TextBox textBoxTask_SDA;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBoxVarN_SDA;
        private System.Windows.Forms.GroupBox groupBoxInput_SDA;
        private System.Windows.Forms.Label labelVarL_SDA;
        private System.Windows.Forms.Label labelVarR_SDA;
        private System.Windows.Forms.Label labelVarn2_SDA;
        private System.Windows.Forms.Label labelVarM_SDA;
        private System.Windows.Forms.Label labelVarK_SDA;
        private System.Windows.Forms.Label labelVarn1_SDA;
        private System.Windows.Forms.Label labelVarN_SDA;
        private System.Windows.Forms.TextBox textBoxVarL_SDA;
        private System.Windows.Forms.TextBox textBoxVarK_SDA;
        private System.Windows.Forms.TextBox textBoxVarR_SDA;
        private System.Windows.Forms.TextBox textBoxVarn2_SDA;
        private System.Windows.Forms.TextBox textBoxVarn1_SDA;
        private System.Windows.Forms.TextBox textBoxVarM_SDA;
        private System.Windows.Forms.Label labelResult_SDA;
        private System.Windows.Forms.TextBox textBoxResult_SDA;
    }
}

