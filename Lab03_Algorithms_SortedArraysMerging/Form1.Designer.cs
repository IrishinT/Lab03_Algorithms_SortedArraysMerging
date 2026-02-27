namespace Lab03_Algorithms_SortedArraysMerging
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
            splitContainer1 = new SplitContainer();
            clearBtn = new Button();
            label1 = new Label();
            minValNuD = new NumericUpDown();
            maxValNuD = new NumericUpDown();
            maxValLb = new Label();
            genBtn = new Button();
            arr2LenNuD = new NumericUpDown();
            arr1LenNuD = new NumericUpDown();
            mergeBtn = new Button();
            arrSize2label = new Label();
            arrSize1label = new Label();
            groupBox1 = new GroupBox();
            inPlaceMergeLb = new Label();
            inPlaceMergeList = new ListBox();
            simpleMergeList = new ListBox();
            simpleMergeLb = new Label();
            arr2InfoLb = new Label();
            arr1InfoLb = new Label();
            arr2List = new ListBox();
            arr1List = new ListBox();
            dataGridView1 = new DataGridView();
            Algorithm = new DataGridViewTextBoxColumn();
            time = new DataGridViewTextBoxColumn();
            operations_count = new DataGridViewTextBoxColumn();
            memory = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minValNuD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxValNuD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arr2LenNuD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arr1LenNuD).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(clearBtn);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(minValNuD);
            splitContainer1.Panel1.Controls.Add(maxValNuD);
            splitContainer1.Panel1.Controls.Add(maxValLb);
            splitContainer1.Panel1.Controls.Add(genBtn);
            splitContainer1.Panel1.Controls.Add(arr2LenNuD);
            splitContainer1.Panel1.Controls.Add(arr1LenNuD);
            splitContainer1.Panel1.Controls.Add(mergeBtn);
            splitContainer1.Panel1.Controls.Add(arrSize2label);
            splitContainer1.Panel1.Controls.Add(arrSize1label);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(1020, 330);
            splitContainer1.SplitterDistance = 337;
            splitContainer1.TabIndex = 6;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clearBtn.Location = new Point(216, 264);
            clearBtn.Margin = new Padding(3, 2, 3, 2);
            clearBtn.Name = "clearBtn";
            clearBtn.RightToLeft = RightToLeft.No;
            clearBtn.Size = new Size(88, 54);
            clearBtn.TabIndex = 14;
            clearBtn.Text = "Очистить";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(13, 124);
            label1.Name = "label1";
            label1.Size = new Size(215, 19);
            label1.TabIndex = 13;
            label1.Text = "Введите минимальное значение";
            // 
            // minValNuD
            // 
            minValNuD.Location = new Point(11, 143);
            minValNuD.Margin = new Padding(3, 2, 3, 2);
            minValNuD.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            minValNuD.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            minValNuD.Name = "minValNuD";
            minValNuD.Size = new Size(239, 23);
            minValNuD.TabIndex = 12;
            // 
            // maxValNuD
            // 
            maxValNuD.Location = new Point(11, 201);
            maxValNuD.Margin = new Padding(3, 2, 3, 2);
            maxValNuD.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            maxValNuD.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            maxValNuD.Name = "maxValNuD";
            maxValNuD.Size = new Size(239, 23);
            maxValNuD.TabIndex = 11;
            maxValNuD.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // maxValLb
            // 
            maxValLb.AutoSize = true;
            maxValLb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maxValLb.Location = new Point(10, 182);
            maxValLb.Name = "maxValLb";
            maxValLb.Size = new Size(219, 19);
            maxValLb.TabIndex = 10;
            maxValLb.Text = "Введите максимальное значение";
            // 
            // genBtn
            // 
            genBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            genBtn.Location = new Point(10, 264);
            genBtn.Margin = new Padding(3, 2, 3, 2);
            genBtn.Name = "genBtn";
            genBtn.RightToLeft = RightToLeft.No;
            genBtn.Size = new Size(97, 54);
            genBtn.TabIndex = 9;
            genBtn.Text = "Заполнить массив";
            genBtn.UseVisualStyleBackColor = true;
            genBtn.Click += genBtn_Click;
            // 
            // arr2LenNuD
            // 
            arr2LenNuD.Location = new Point(10, 88);
            arr2LenNuD.Margin = new Padding(3, 2, 3, 2);
            arr2LenNuD.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            arr2LenNuD.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            arr2LenNuD.Name = "arr2LenNuD";
            arr2LenNuD.Size = new Size(239, 23);
            arr2LenNuD.TabIndex = 8;
            arr2LenNuD.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // arr1LenNuD
            // 
            arr1LenNuD.Location = new Point(10, 38);
            arr1LenNuD.Margin = new Padding(3, 2, 3, 2);
            arr1LenNuD.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            arr1LenNuD.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            arr1LenNuD.Name = "arr1LenNuD";
            arr1LenNuD.Size = new Size(239, 23);
            arr1LenNuD.TabIndex = 7;
            arr1LenNuD.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // mergeBtn
            // 
            mergeBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mergeBtn.Location = new Point(122, 264);
            mergeBtn.Margin = new Padding(3, 2, 3, 2);
            mergeBtn.Name = "mergeBtn";
            mergeBtn.RightToLeft = RightToLeft.No;
            mergeBtn.Size = new Size(80, 54);
            mergeBtn.TabIndex = 6;
            mergeBtn.Text = "Слияние";
            mergeBtn.UseVisualStyleBackColor = true;
            mergeBtn.Click += mergeBtn_Click;
            // 
            // arrSize2label
            // 
            arrSize2label.AutoSize = true;
            arrSize2label.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            arrSize2label.Location = new Point(10, 68);
            arrSize2label.Name = "arrSize2label";
            arrSize2label.Size = new Size(219, 19);
            arrSize2label.TabIndex = 3;
            arrSize2label.Text = "Введите размер второго массива";
            // 
            // arrSize1label
            // 
            arrSize1label.AutoSize = true;
            arrSize1label.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            arrSize1label.Location = new Point(10, 17);
            arrSize1label.Name = "arrSize1label";
            arrSize1label.Size = new Size(220, 19);
            arrSize1label.TabIndex = 1;
            arrSize1label.Text = "Введите размер первого массива";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(inPlaceMergeLb);
            groupBox1.Controls.Add(inPlaceMergeList);
            groupBox1.Controls.Add(simpleMergeList);
            groupBox1.Controls.Add(simpleMergeLb);
            groupBox1.Controls.Add(arr2InfoLb);
            groupBox1.Controls.Add(arr1InfoLb);
            groupBox1.Controls.Add(arr2List);
            groupBox1.Controls.Add(arr1List);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(679, 330);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Результаты";
            // 
            // inPlaceMergeLb
            // 
            inPlaceMergeLb.AutoSize = true;
            inPlaceMergeLb.Location = new Point(470, 186);
            inPlaceMergeLb.Name = "inPlaceMergeLb";
            inPlaceMergeLb.Size = new Size(106, 15);
            inPlaceMergeLb.TabIndex = 8;
            inPlaceMergeLb.Text = "Слияние на месте";
            // 
            // inPlaceMergeList
            // 
            inPlaceMergeList.FormattingEnabled = true;
            inPlaceMergeList.ItemHeight = 15;
            inPlaceMergeList.Location = new Point(470, 224);
            inPlaceMergeList.Name = "inPlaceMergeList";
            inPlaceMergeList.Size = new Size(145, 94);
            inPlaceMergeList.TabIndex = 7;
            // 
            // simpleMergeList
            // 
            simpleMergeList.FormattingEnabled = true;
            simpleMergeList.ItemHeight = 15;
            simpleMergeList.Location = new Point(319, 224);
            simpleMergeList.Name = "simpleMergeList";
            simpleMergeList.Size = new Size(145, 94);
            simpleMergeList.TabIndex = 6;
            // 
            // simpleMergeLb
            // 
            simpleMergeLb.AutoSize = true;
            simpleMergeLb.Location = new Point(319, 186);
            simpleMergeLb.Name = "simpleMergeLb";
            simpleMergeLb.Size = new Size(103, 15);
            simpleMergeLb.TabIndex = 5;
            simpleMergeLb.Text = "Простое слияние";
            // 
            // arr2InfoLb
            // 
            arr2InfoLb.AutoSize = true;
            arr2InfoLb.Location = new Point(168, 185);
            arr2InfoLb.Name = "arr2InfoLb";
            arr2InfoLb.Size = new Size(145, 15);
            arr2InfoLb.TabIndex = 4;
            arr2InfoLb.Text = "Массив не сгенерирован";
            // 
            // arr1InfoLb
            // 
            arr1InfoLb.AutoSize = true;
            arr1InfoLb.Location = new Point(6, 186);
            arr1InfoLb.Name = "arr1InfoLb";
            arr1InfoLb.Size = new Size(145, 15);
            arr1InfoLb.TabIndex = 3;
            arr1InfoLb.Text = "Массив не сгенерирован";
            // 
            // arr2List
            // 
            arr2List.FormattingEnabled = true;
            arr2List.ItemHeight = 15;
            arr2List.Location = new Point(168, 224);
            arr2List.Name = "arr2List";
            arr2List.Size = new Size(145, 94);
            arr2List.TabIndex = 2;
            // 
            // arr1List
            // 
            arr1List.FormattingEnabled = true;
            arr1List.ItemHeight = 15;
            arr1List.Location = new Point(6, 224);
            arr1List.Name = "arr1List";
            arr1List.Size = new Size(156, 94);
            arr1List.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Algorithm, time, operations_count, memory });
            dataGridView1.Location = new Point(5, 22);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(561, 131);
            dataGridView1.TabIndex = 0;
            // 
            // Algorithm
            // 
            Algorithm.HeaderText = "Алгоритм";
            Algorithm.MinimumWidth = 6;
            Algorithm.Name = "Algorithm";
            Algorithm.ReadOnly = true;
            Algorithm.Width = 125;
            // 
            // time
            // 
            time.HeaderText = "Время (мс)";
            time.MinimumWidth = 6;
            time.Name = "time";
            time.ReadOnly = true;
            time.Width = 125;
            // 
            // operations_count
            // 
            operations_count.HeaderText = "Кол-во операций";
            operations_count.MinimumWidth = 6;
            operations_count.Name = "operations_count";
            operations_count.ReadOnly = true;
            operations_count.Width = 125;
            // 
            // memory
            // 
            memory.HeaderText = "Использование памяти";
            memory.MinimumWidth = 6;
            memory.Name = "memory";
            memory.ReadOnly = true;
            memory.Width = 125;
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1020, 330);
            panel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 330);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Слияние отсортированных массивов";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)minValNuD).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxValNuD).EndInit();
            ((System.ComponentModel.ISupportInitialize)arr2LenNuD).EndInit();
            ((System.ComponentModel.ISupportInitialize)arr1LenNuD).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label arrSize2label;
        private Label arrSize1label;
        private Panel panel1;
        private Button mergeBtn;
        private NumericUpDown arr2LenNuD;
        private NumericUpDown arr1LenNuD;
        private Button genBtn;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private NumericUpDown maxValNuD;
        private Label maxValLb;
        private NumericUpDown minValNuD;
        private Label label1;
        private Button clearBtn;
        private DataGridViewTextBoxColumn Algorithm;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn operations_count;
        private DataGridViewTextBoxColumn memory;
        private ListBox arr1List;
        private ListBox arr2List;
        private Label arr2InfoLb;
        private Label arr1InfoLb;
        private ListBox simpleMergeList;
        private Label simpleMergeLb;
        private Label inPlaceMergeLb;
        private ListBox inPlaceMergeList;
    }
}
