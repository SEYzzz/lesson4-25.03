
namespace xml
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmnHotelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageRooms = new System.Windows.Forms.TabPage();
            this.tabPageBuns = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clmnNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFridge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAddPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageRooms.SuspendLayout();
            this.tabPageBuns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPageRooms);
            this.tabControl.Controls.Add(this.tabPageBuns);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabPage1.Controls.Add(this.btnSerialize);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Type of the hotels";
            // 
            // btnSerialize
            // 
            this.btnSerialize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerialize.BackColor = System.Drawing.Color.Transparent;
            this.btnSerialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerialize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSerialize.Location = new System.Drawing.Point(547, 179);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(116, 33);
            this.btnSerialize.TabIndex = 1;
            this.btnSerialize.Text = "Deserialize";
            this.btnSerialize.UseVisualStyleBackColor = false;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnHotelName});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(410, 421);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clmnHotelName
            // 
            this.clmnHotelName.HeaderText = "Название отеля";
            this.clmnHotelName.MinimumWidth = 6;
            this.clmnHotelName.Name = "clmnHotelName";
            this.clmnHotelName.ReadOnly = true;
            // 
            // tabPageRooms
            // 
            this.tabPageRooms.BackColor = System.Drawing.Color.Linen;
            this.tabPageRooms.Controls.Add(this.dataGridView2);
            this.tabPageRooms.Location = new System.Drawing.Point(4, 25);
            this.tabPageRooms.Name = "tabPageRooms";
            this.tabPageRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRooms.Size = new System.Drawing.Size(792, 421);
            this.tabPageRooms.TabIndex = 1;
            this.tabPageRooms.Text = "Rooms";
            // 
            // tabPageBuns
            // 
            this.tabPageBuns.BackColor = System.Drawing.Color.Honeydew;
            this.tabPageBuns.Controls.Add(this.dataGridView3);
            this.tabPageBuns.Location = new System.Drawing.Point(4, 25);
            this.tabPageBuns.Name = "tabPageBuns";
            this.tabPageBuns.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuns.Size = new System.Drawing.Size(792, 421);
            this.tabPageBuns.TabIndex = 2;
            this.tabPageBuns.Text = "Buns";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnNum,
            this.clmnBed,
            this.clmnView,
            this.clmnFridge,
            this.clmnPrice,
            this.clmnBun});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(786, 415);
            this.dataGridView2.TabIndex = 0;
            // 
            // clmnNum
            // 
            this.clmnNum.HeaderText = "Номер номера";
            this.clmnNum.MinimumWidth = 6;
            this.clmnNum.Name = "clmnNum";
            this.clmnNum.ReadOnly = true;
            // 
            // clmnBed
            // 
            this.clmnBed.HeaderText = "Кол-во кроватей";
            this.clmnBed.MinimumWidth = 6;
            this.clmnBed.Name = "clmnBed";
            this.clmnBed.ReadOnly = true;
            // 
            // clmnView
            // 
            this.clmnView.HeaderText = "Красивый вид";
            this.clmnView.MinimumWidth = 6;
            this.clmnView.Name = "clmnView";
            this.clmnView.ReadOnly = true;
            // 
            // clmnFridge
            // 
            this.clmnFridge.HeaderText = "Холодильник";
            this.clmnFridge.MinimumWidth = 6;
            this.clmnFridge.Name = "clmnFridge";
            this.clmnFridge.ReadOnly = true;
            // 
            // clmnPrice
            // 
            this.clmnPrice.HeaderText = "Цена";
            this.clmnPrice.MinimumWidth = 6;
            this.clmnPrice.Name = "clmnPrice";
            this.clmnPrice.ReadOnly = true;
            // 
            // clmnBun
            // 
            this.clmnBun.HeaderText = "Плюшки";
            this.clmnBun.MinimumWidth = 6;
            this.clmnBun.Name = "clmnBun";
            this.clmnBun.ReadOnly = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnName,
            this.clmnAddPrice});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(786, 415);
            this.dataGridView3.TabIndex = 0;
            // 
            // clmnName
            // 
            this.clmnName.HeaderText = "Название";
            this.clmnName.MinimumWidth = 6;
            this.clmnName.Name = "clmnName";
            this.clmnName.ReadOnly = true;
            // 
            // clmnAddPrice
            // 
            this.clmnAddPrice.HeaderText = "Является ли услуга платной";
            this.clmnAddPrice.MinimumWidth = 6;
            this.clmnAddPrice.Name = "clmnAddPrice";
            this.clmnAddPrice.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageRooms.ResumeLayout(false);
            this.tabPageBuns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageRooms;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPageBuns;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnHotelName;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFridge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBun;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAddPrice;
    }
}

