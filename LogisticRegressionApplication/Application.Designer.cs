namespace LogisticRegressionApplication
{
    partial class Application
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
            this.dgv_VisualizedData = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_InputPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_LearningRate = new System.Windows.Forms.TextBox();
            this.tb_Iterations = new System.Windows.Forms.TextBox();
            this.bt_train = new System.Windows.Forms.Button();
            this.bt_test = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_KFold = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Folds = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_testDataPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_SaveLoad = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Load = new System.Windows.Forms.Button();
            this.bt_ROCCURVE = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_learningDataPath = new System.Windows.Forms.Button();
            this.bt_TestPath = new System.Windows.Forms.Button();
            this.bt_ModelPath = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VisualizedData)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.58559F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.41441F));
            this.tableLayoutPanel1.Controls.Add(this.elementHost1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_VisualizedData, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.37597F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.62403F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1651, 1157);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(590, 3);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1058, 472);
            this.elementHost1.TabIndex = 1;
            this.elementHost1.Text = "ChartLoss";
            this.elementHost1.Child = this.cartesianChart1;
            // 
            // dgv_VisualizedData
            // 
            this.dgv_VisualizedData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VisualizedData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_VisualizedData.Location = new System.Drawing.Point(590, 481);
            this.dgv_VisualizedData.Name = "dgv_VisualizedData";
            this.dgv_VisualizedData.RowTemplate.Height = 28;
            this.dgv_VisualizedData.Size = new System.Drawing.Size(1058, 673);
            this.dgv_VisualizedData.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.75F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel9, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(581, 472);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tb_InputPath
            // 
            this.tb_InputPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_InputPath.Location = new System.Drawing.Point(3, 3);
            this.tb_InputPath.Name = "tb_InputPath";
            this.tb_InputPath.Size = new System.Drawing.Size(367, 26);
            this.tb_InputPath.TabIndex = 0;
            this.tb_InputPath.TextChanged += new System.EventHandler(this.tb_InputPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Learning Data Path:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb_LearningRate, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_Iterations, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb_Folds, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(395, 124);
            this.tableLayoutPanel3.TabIndex = 2;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Learning Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Iterations:";
            // 
            // tb_LearningRate
            // 
            this.tb_LearningRate.Location = new System.Drawing.Point(133, 3);
            this.tb_LearningRate.Name = "tb_LearningRate";
            this.tb_LearningRate.Size = new System.Drawing.Size(94, 26);
            this.tb_LearningRate.TabIndex = 2;
            this.tb_LearningRate.Text = "1";
            // 
            // tb_Iterations
            // 
            this.tb_Iterations.Location = new System.Drawing.Point(133, 42);
            this.tb_Iterations.Name = "tb_Iterations";
            this.tb_Iterations.Size = new System.Drawing.Size(94, 26);
            this.tb_Iterations.TabIndex = 3;
            this.tb_Iterations.Text = "100";
            // 
            // bt_train
            // 
            this.bt_train.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_train.Location = new System.Drawing.Point(3, 3);
            this.bt_train.Name = "bt_train";
            this.bt_train.Size = new System.Drawing.Size(98, 52);
            this.bt_train.TabIndex = 4;
            this.bt_train.Text = "TRAIN";
            this.bt_train.UseVisualStyleBackColor = true;
            this.bt_train.Click += new System.EventHandler(this.bt_train_Click);
            // 
            // bt_test
            // 
            this.bt_test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_test.Location = new System.Drawing.Point(107, 3);
            this.bt_test.Name = "bt_test";
            this.bt_test.Size = new System.Drawing.Size(98, 52);
            this.bt_test.TabIndex = 5;
            this.bt_test.Text = "TEST";
            this.bt_test.UseVisualStyleBackColor = true;
            this.bt_test.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(233, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 39);
            this.label6.TabIndex = 6;
            this.label6.Text = "*10e-3";
            // 
            // bt_KFold
            // 
            this.bt_KFold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_KFold.Location = new System.Drawing.Point(211, 3);
            this.bt_KFold.Name = "bt_KFold";
            this.bt_KFold.Size = new System.Drawing.Size(98, 52);
            this.bt_KFold.TabIndex = 7;
            this.bt_KFold.Text = "K-Fold CV";
            this.bt_KFold.UseVisualStyleBackColor = true;
            this.bt_KFold.Click += new System.EventHandler(this.bt_KFold_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 44);
            this.label8.TabIndex = 8;
            this.label8.Text = "Folds:";
            // 
            // tb_Folds
            // 
            this.tb_Folds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Folds.Location = new System.Drawing.Point(133, 83);
            this.tb_Folds.Name = "tb_Folds";
            this.tb_Folds.Size = new System.Drawing.Size(94, 26);
            this.tb_Folds.TabIndex = 9;
            this.tb_Folds.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Training Parameters:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Test Data Path:";
            // 
            // tb_testDataPath
            // 
            this.tb_testDataPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_testDataPath.Location = new System.Drawing.Point(3, 3);
            this.tb_testDataPath.Name = "tb_testDataPath";
            this.tb_testDataPath.Size = new System.Drawing.Size(367, 26);
            this.tb_testDataPath.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Save/Load Path";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(155, 323);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.55556F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.44444F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(423, 146);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // tb_SaveLoad
            // 
            this.tb_SaveLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_SaveLoad.Location = new System.Drawing.Point(3, 3);
            this.tb_SaveLoad.Name = "tb_SaveLoad";
            this.tb_SaveLoad.Size = new System.Drawing.Size(361, 26);
            this.tb_SaveLoad.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.bt_Save, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.bt_Load, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 47);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(417, 96);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // bt_Save
            // 
            this.bt_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Save.Location = new System.Drawing.Point(3, 3);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(133, 90);
            this.bt_Save.TabIndex = 0;
            this.bt_Save.Text = "SAVE";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Load
            // 
            this.bt_Load.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Load.Location = new System.Drawing.Point(142, 3);
            this.bt_Load.Name = "bt_Load";
            this.bt_Load.Size = new System.Drawing.Size(133, 90);
            this.bt_Load.TabIndex = 1;
            this.bt_Load.Text = "LOAD";
            this.bt_Load.UseVisualStyleBackColor = true;
            this.bt_Load.Click += new System.EventHandler(this.bt_Load_Click);
            // 
            // bt_ROCCURVE
            // 
            this.bt_ROCCURVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_ROCCURVE.Location = new System.Drawing.Point(315, 3);
            this.bt_ROCCURVE.Name = "bt_ROCCURVE";
            this.bt_ROCCURVE.Size = new System.Drawing.Size(99, 52);
            this.bt_ROCCURVE.TabIndex = 2;
            this.bt_ROCCURVE.Text = "AUC";
            this.bt_ROCCURVE.UseVisualStyleBackColor = true;
            this.bt_ROCCURVE.Click += new System.EventHandler(this.bt_ROCCURVE_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.bt_train, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.bt_test, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.bt_ROCCURVE, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.bt_KFold, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 133);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(417, 58);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(155, 123);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(423, 194);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.Controls.Add(this.tb_InputPath, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.bt_learningDataPath, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(155, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(423, 54);
            this.tableLayoutPanel8.TabIndex = 8;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel9.Controls.Add(this.tb_testDataPath, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.bt_TestPath, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(155, 63);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(423, 54);
            this.tableLayoutPanel9.TabIndex = 9;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel10.Controls.Add(this.tb_SaveLoad, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.bt_ModelPath, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(417, 38);
            this.tableLayoutPanel10.TabIndex = 2;
            // 
            // bt_learningDataPath
            // 
            this.bt_learningDataPath.Location = new System.Drawing.Point(376, 3);
            this.bt_learningDataPath.Name = "bt_learningDataPath";
            this.bt_learningDataPath.Size = new System.Drawing.Size(44, 40);
            this.bt_learningDataPath.TabIndex = 1;
            this.bt_learningDataPath.Text = "...";
            this.bt_learningDataPath.UseVisualStyleBackColor = true;
            this.bt_learningDataPath.Click += new System.EventHandler(this.bt_learningDataPath_Click);
            // 
            // bt_TestPath
            // 
            this.bt_TestPath.Location = new System.Drawing.Point(376, 3);
            this.bt_TestPath.Name = "bt_TestPath";
            this.bt_TestPath.Size = new System.Drawing.Size(44, 40);
            this.bt_TestPath.TabIndex = 6;
            this.bt_TestPath.Text = "...";
            this.bt_TestPath.UseVisualStyleBackColor = true;
            this.bt_TestPath.Click += new System.EventHandler(this.bt_TestPath_Click);
            // 
            // bt_ModelPath
            // 
            this.bt_ModelPath.Location = new System.Drawing.Point(370, 3);
            this.bt_ModelPath.Name = "bt_ModelPath";
            this.bt_ModelPath.Size = new System.Drawing.Size(44, 32);
            this.bt_ModelPath.TabIndex = 1;
            this.bt_ModelPath.Text = "...";
            this.bt_ModelPath.UseVisualStyleBackColor = true;
            this.bt_ModelPath.Click += new System.EventHandler(this.bt_ModelPath_Click);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 1157);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Application";
            this.Text = "Logistic Regression";
            this.Load += new System.EventHandler(this.Application_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VisualizedData)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tb_InputPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.CartesianChart cartesianChart1;
        private System.Windows.Forms.DataGridView dgv_VisualizedData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_LearningRate;
        private System.Windows.Forms.TextBox tb_Iterations;
        private System.Windows.Forms.Button bt_train;
        private System.Windows.Forms.Button bt_test;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_testDataPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tb_SaveLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_Load;
        private System.Windows.Forms.Button bt_KFold;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Folds;
        private System.Windows.Forms.Button bt_ROCCURVE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button bt_learningDataPath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button bt_ModelPath;
        private System.Windows.Forms.Button bt_TestPath;
    }
}

