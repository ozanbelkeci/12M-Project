
namespace ExampleProject
{
    partial class StiTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StiTable));
            this.malKodutxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.getListButton = new DevExpress.XtraEditors.SimpleButton();
            this.excelButton = new DevExpress.XtraEditors.SimpleButton();
            this.printButton = new DevExpress.XtraEditors.SimpleButton();
            this.stiGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.baslangicTarihInput = new DevExpress.XtraEditors.DateEdit();
            this.bitisTarihInput = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.malKodutxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baslangicTarihInput.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baslangicTarihInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitisTarihInput.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitisTarihInput.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // malKodutxt
            // 
            this.malKodutxt.Location = new System.Drawing.Point(990, 17);
            this.malKodutxt.Name = "malKodutxt";
            this.malKodutxt.Size = new System.Drawing.Size(125, 22);
            this.malKodutxt.TabIndex = 0;
            this.malKodutxt.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(921, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mal Kodu";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(883, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Başlangıç Tarihi";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(913, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Bitiş Tarihi";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // getListButton
            // 
            this.getListButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("getListButton.ImageOptions.SvgImage")));
            this.getListButton.Location = new System.Drawing.Point(990, 101);
            this.getListButton.LookAndFeel.SkinName = "DevExpress Style";
            this.getListButton.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.getListButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.getListButton.LookAndFeel.UseWindowsXPTheme = true;
            this.getListButton.Name = "getListButton";
            this.getListButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.getListButton.Size = new System.Drawing.Size(125, 48);
            this.getListButton.TabIndex = 6;
            this.getListButton.Text = "Listele";
            this.getListButton.Click += new System.EventHandler(this.getListButton_Click);
            // 
            // excelButton
            // 
            this.excelButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("excelButton.ImageOptions.SvgImage")));
            this.excelButton.Location = new System.Drawing.Point(990, 155);
            this.excelButton.LookAndFeel.SkinName = "DevExpress Style";
            this.excelButton.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.excelButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.excelButton.LookAndFeel.UseWindowsXPTheme = true;
            this.excelButton.Name = "excelButton";
            this.excelButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.excelButton.Size = new System.Drawing.Size(125, 48);
            this.excelButton.TabIndex = 7;
            this.excelButton.Text = "Excel Al";
            this.excelButton.Click += new System.EventHandler(this.excelButton_Click);
            // 
            // printButton
            // 
            this.printButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("printButton.ImageOptions.SvgImage")));
            this.printButton.Location = new System.Drawing.Point(990, 209);
            this.printButton.LookAndFeel.SkinName = "DevExpress Style";
            this.printButton.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.printButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.printButton.LookAndFeel.UseWindowsXPTheme = true;
            this.printButton.Name = "printButton";
            this.printButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.printButton.Size = new System.Drawing.Size(125, 48);
            this.printButton.TabIndex = 8;
            this.printButton.Text = "Yazdır";
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // stiGrid
            // 
            this.stiGrid.Location = new System.Drawing.Point(13, 12);
            this.stiGrid.MainView = this.gridView1;
            this.stiGrid.Name = "stiGrid";
            this.stiGrid.Size = new System.Drawing.Size(853, 426);
            this.stiGrid.TabIndex = 9;
            this.stiGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            this.stiGrid.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.stiGrid;
            this.gridView1.Name = "gridView1";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.stiGrid;
            this.gridView2.Name = "gridView2";
            // 
            // baslangicTarihInput
            // 
            this.baslangicTarihInput.EditValue = null;
            this.baslangicTarihInput.Location = new System.Drawing.Point(990, 45);
            this.baslangicTarihInput.Name = "baslangicTarihInput";
            this.baslangicTarihInput.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.baslangicTarihInput.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.baslangicTarihInput.Size = new System.Drawing.Size(125, 22);
            this.baslangicTarihInput.TabIndex = 10;
            // 
            // bitisTarihInput
            // 
            this.bitisTarihInput.EditValue = null;
            this.bitisTarihInput.Location = new System.Drawing.Point(990, 73);
            this.bitisTarihInput.Name = "bitisTarihInput";
            this.bitisTarihInput.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bitisTarihInput.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bitisTarihInput.Size = new System.Drawing.Size(125, 22);
            this.bitisTarihInput.TabIndex = 11;
            // 
            // StiTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 581);
            this.Controls.Add(this.bitisTarihInput);
            this.Controls.Add(this.baslangicTarihInput);
            this.Controls.Add(this.stiGrid);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.excelButton);
            this.Controls.Add(this.getListButton);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.malKodutxt);
            this.Name = "StiTable";
            this.Text = "Stok Tablosu";
            this.Load += new System.EventHandler(this.StiTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.malKodutxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baslangicTarihInput.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baslangicTarihInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitisTarihInput.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitisTarihInput.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit malKodutxt;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton getListButton;
        private DevExpress.XtraEditors.SimpleButton excelButton;
        private DevExpress.XtraEditors.SimpleButton printButton;
        private DevExpress.XtraGrid.GridControl stiGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit baslangicTarihInput;
        private DevExpress.XtraEditors.DateEdit bitisTarihInput;
    }
}