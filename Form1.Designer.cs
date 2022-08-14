
namespace ToDoList
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbx_list = new System.Windows.Forms.ListBox();
            this.toDoListRealDataSet = new ToDoList.ToDoListRealDataSet();
            this.txb_newItem = new System.Windows.Forms.TextBox();
            this.toDoListRealDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toDoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toDoTableAdapter = new ToDoList.ToDoListRealDataSetTableAdapters.ToDoTableAdapter();
            this.toDoListRealDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toDoListRealDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.toDoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListRealDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListRealDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListRealDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListRealDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(258, 205);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 40);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "To Do";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbx_list
            // 
            this.lbx_list.FormattingEnabled = true;
            this.lbx_list.Location = new System.Drawing.Point(528, 96);
            this.lbx_list.Name = "lbx_list";
            this.lbx_list.Size = new System.Drawing.Size(260, 342);
            this.lbx_list.TabIndex = 2;
            // 
            // toDoListRealDataSet
            // 
            this.toDoListRealDataSet.DataSetName = "ToDoListRealDataSet";
            this.toDoListRealDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txb_newItem
            // 
            this.txb_newItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_newItem.Location = new System.Drawing.Point(37, 168);
            this.txb_newItem.Name = "txb_newItem";
            this.txb_newItem.Size = new System.Drawing.Size(296, 31);
            this.txb_newItem.TabIndex = 3;
            // 
            // toDoListRealDataSetBindingSource
            // 
            this.toDoListRealDataSetBindingSource.DataSource = this.toDoListRealDataSet;
            this.toDoListRealDataSetBindingSource.Position = 0;
            // 
            // toDoBindingSource
            // 
            this.toDoBindingSource.DataMember = "ToDo";
            this.toDoBindingSource.DataSource = this.toDoListRealDataSet;
            // 
            // toDoTableAdapter
            // 
            this.toDoTableAdapter.ClearBeforeFill = true;
            // 
            // toDoListRealDataSetBindingSource1
            // 
            this.toDoListRealDataSetBindingSource1.DataSource = this.toDoListRealDataSet;
            this.toDoListRealDataSetBindingSource1.Position = 0;
            // 
            // toDoListRealDataSetBindingSource2
            // 
            this.toDoListRealDataSetBindingSource2.DataSource = this.toDoListRealDataSet;
            this.toDoListRealDataSetBindingSource2.Position = 0;
            // 
            // toDoBindingSource1
            // 
            this.toDoBindingSource1.DataMember = "ToDo";
            this.toDoBindingSource1.DataSource = this.toDoListRealDataSetBindingSource;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(808, 25);
            this.fillToolStrip.TabIndex = 5;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(138, 281);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(88, 40);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(232, 281);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(101, 40);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.txb_newItem);
            this.Controls.Add(this.lbx_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toDoListRealDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListRealDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListRealDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListRealDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx_list;
        private System.Windows.Forms.TextBox txb_newItem;
        private ToDoListRealDataSet toDoListRealDataSet;
        private System.Windows.Forms.BindingSource toDoListRealDataSetBindingSource;
        private System.Windows.Forms.BindingSource toDoBindingSource;
        private ToDoListRealDataSetTableAdapters.ToDoTableAdapter toDoTableAdapter;
        private System.Windows.Forms.BindingSource toDoListRealDataSetBindingSource1;
        private System.Windows.Forms.BindingSource toDoBindingSource1;
        private System.Windows.Forms.BindingSource toDoListRealDataSetBindingSource2;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_remove;
    }
}

