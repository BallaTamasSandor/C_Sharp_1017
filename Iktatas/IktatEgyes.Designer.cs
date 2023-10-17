
namespace Iktatas
{
    partial class IktatEgyes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IktatEgyes));
            System.Windows.Forms.Label id_IktatLabel;
            System.Windows.Forms.Label iktatoszamLabel;
            System.Windows.Forms.Label idUserLabel;
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.Label idTemaLabel;
            System.Windows.Forms.Label leirasLabel;
            this.iktatEgyesDS = new Iktatas.IktatEgyesDS();
            this.iktatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iktatTableAdapter = new Iktatas.IktatEgyesDSTableAdapters.IktatTableAdapter();
            this.tableAdapterManager = new Iktatas.IktatEgyesDSTableAdapters.TableAdapterManager();
            this.iktatBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.iktatBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_IktatLabel1 = new System.Windows.Forms.Label();
            this.iktatoszamTextBox = new System.Windows.Forms.TextBox();
            this.idUserComboBox = new System.Windows.Forms.ComboBox();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTemaComboBox = new System.Windows.Forms.ComboBox();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            id_IktatLabel = new System.Windows.Forms.Label();
            iktatoszamLabel = new System.Windows.Forms.Label();
            idUserLabel = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            idTemaLabel = new System.Windows.Forms.Label();
            leirasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iktatEgyesDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingNavigator)).BeginInit();
            this.iktatBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iktatEgyesDS
            // 
            this.iktatEgyesDS.DataSetName = "IktatEgyesDS";
            this.iktatEgyesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iktatBindingSource
            // 
            this.iktatBindingSource.DataMember = "Iktat";
            this.iktatBindingSource.DataSource = this.iktatEgyesDS;
            // 
            // iktatTableAdapter
            // 
            this.iktatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IktatTableAdapter = this.iktatTableAdapter;
            this.tableAdapterManager.TemakTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Iktatas.IktatEgyesDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // iktatBindingNavigator
            // 
            this.iktatBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iktatBindingNavigator.BindingSource = this.iktatBindingSource;
            this.iktatBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iktatBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iktatBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.iktatBindingNavigatorSaveItem});
            this.iktatBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iktatBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iktatBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iktatBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iktatBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iktatBindingNavigator.Name = "iktatBindingNavigator";
            this.iktatBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iktatBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.iktatBindingNavigator.TabIndex = 0;
            this.iktatBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // iktatBindingNavigatorSaveItem
            // 
            this.iktatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iktatBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iktatBindingNavigatorSaveItem.Image")));
            this.iktatBindingNavigatorSaveItem.Name = "iktatBindingNavigatorSaveItem";
            this.iktatBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.iktatBindingNavigatorSaveItem.Text = "Save Data";
            this.iktatBindingNavigatorSaveItem.Click += new System.EventHandler(this.iktatBindingNavigatorSaveItem_Click_1);
            // 
            // id_IktatLabel
            // 
            id_IktatLabel.AutoSize = true;
            id_IktatLabel.Location = new System.Drawing.Point(29, 55);
            id_IktatLabel.Name = "id_IktatLabel";
            id_IktatLabel.Size = new System.Drawing.Size(58, 13);
            id_IktatLabel.TabIndex = 1;
            id_IktatLabel.Text = "Azonosító:";
            // 
            // id_IktatLabel1
            // 
            this.id_IktatLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iktatBindingSource, "Id_Iktat", true));
            this.id_IktatLabel1.Location = new System.Drawing.Point(96, 55);
            this.id_IktatLabel1.Name = "id_IktatLabel1";
            this.id_IktatLabel1.Size = new System.Drawing.Size(200, 23);
            this.id_IktatLabel1.TabIndex = 2;
            this.id_IktatLabel1.Text = "label1";
            // 
            // iktatoszamLabel
            // 
            iktatoszamLabel.AutoSize = true;
            iktatoszamLabel.Location = new System.Drawing.Point(29, 84);
            iktatoszamLabel.Name = "iktatoszamLabel";
            iktatoszamLabel.Size = new System.Drawing.Size(61, 13);
            iktatoszamLabel.TabIndex = 3;
            iktatoszamLabel.Text = "Iktatószám:";
            // 
            // iktatoszamTextBox
            // 
            this.iktatoszamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iktatBindingSource, "Iktatoszam", true));
            this.iktatoszamTextBox.Location = new System.Drawing.Point(96, 81);
            this.iktatoszamTextBox.Name = "iktatoszamTextBox";
            this.iktatoszamTextBox.Size = new System.Drawing.Size(200, 20);
            this.iktatoszamTextBox.TabIndex = 4;
            // 
            // idUserLabel
            // 
            idUserLabel.AutoSize = true;
            idUserLabel.Location = new System.Drawing.Point(29, 110);
            idUserLabel.Name = "idUserLabel";
            idUserLabel.Size = new System.Drawing.Size(66, 13);
            idUserLabel.TabIndex = 5;
            idUserLabel.Text = "Felhasználó:";
            // 
            // idUserComboBox
            // 
            this.idUserComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iktatBindingSource, "idUser", true));
            this.idUserComboBox.DataSource = this.iktatEgyesDS;
            this.idUserComboBox.DisplayMember = "Users.Nev";
            this.idUserComboBox.FormattingEnabled = true;
            this.idUserComboBox.Location = new System.Drawing.Point(96, 107);
            this.idUserComboBox.Name = "idUserComboBox";
            this.idUserComboBox.Size = new System.Drawing.Size(200, 21);
            this.idUserComboBox.TabIndex = 6;
            this.idUserComboBox.ValueMember = "Users.Id_user";
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Location = new System.Drawing.Point(29, 138);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(41, 13);
            datumLabel.TabIndex = 7;
            datumLabel.Text = "Dátum:";
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.iktatBindingSource, "Datum", true));
            this.datumDateTimePicker.Location = new System.Drawing.Point(96, 134);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datumDateTimePicker.TabIndex = 8;
            // 
            // idTemaLabel
            // 
            idTemaLabel.AutoSize = true;
            idTemaLabel.Location = new System.Drawing.Point(29, 163);
            idTemaLabel.Name = "idTemaLabel";
            idTemaLabel.Size = new System.Drawing.Size(37, 13);
            idTemaLabel.TabIndex = 9;
            idTemaLabel.Text = "Téma:";
            // 
            // idTemaComboBox
            // 
            this.idTemaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iktatBindingSource, "idTema", true));
            this.idTemaComboBox.DataSource = this.iktatEgyesDS;
            this.idTemaComboBox.DisplayMember = "Temak.Tema";
            this.idTemaComboBox.FormattingEnabled = true;
            this.idTemaComboBox.Location = new System.Drawing.Point(96, 160);
            this.idTemaComboBox.Name = "idTemaComboBox";
            this.idTemaComboBox.Size = new System.Drawing.Size(200, 21);
            this.idTemaComboBox.TabIndex = 10;
            this.idTemaComboBox.ValueMember = "Temak.Id_Tema";
            // 
            // leirasLabel
            // 
            leirasLabel.AutoSize = true;
            leirasLabel.Location = new System.Drawing.Point(29, 190);
            leirasLabel.Name = "leirasLabel";
            leirasLabel.Size = new System.Drawing.Size(40, 13);
            leirasLabel.TabIndex = 11;
            leirasLabel.Text = "Leírás:";
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iktatBindingSource, "Leiras", true));
            this.leirasTextBox.Location = new System.Drawing.Point(96, 187);
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(200, 20);
            this.leirasTextBox.TabIndex = 12;
            // 
            // IktatEgyes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(id_IktatLabel);
            this.Controls.Add(this.id_IktatLabel1);
            this.Controls.Add(iktatoszamLabel);
            this.Controls.Add(this.iktatoszamTextBox);
            this.Controls.Add(idUserLabel);
            this.Controls.Add(this.idUserComboBox);
            this.Controls.Add(datumLabel);
            this.Controls.Add(this.datumDateTimePicker);
            this.Controls.Add(idTemaLabel);
            this.Controls.Add(this.idTemaComboBox);
            this.Controls.Add(leirasLabel);
            this.Controls.Add(this.leirasTextBox);
            this.Controls.Add(this.iktatBindingNavigator);
            this.Name = "IktatEgyes";
            this.Text = "Iktató lap";
            this.Load += new System.EventHandler(this.IktatEgyes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iktatEgyesDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingNavigator)).EndInit();
            this.iktatBindingNavigator.ResumeLayout(false);
            this.iktatBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IktatEgyesDS iktatEgyesDS;
        private System.Windows.Forms.BindingSource iktatBindingSource;
        private IktatEgyesDSTableAdapters.IktatTableAdapter iktatTableAdapter;
        private IktatEgyesDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iktatBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton iktatBindingNavigatorSaveItem;
        private System.Windows.Forms.Label id_IktatLabel1;
        private System.Windows.Forms.TextBox iktatoszamTextBox;
        private System.Windows.Forms.ComboBox idUserComboBox;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.ComboBox idTemaComboBox;
        private System.Windows.Forms.TextBox leirasTextBox;
    }
}