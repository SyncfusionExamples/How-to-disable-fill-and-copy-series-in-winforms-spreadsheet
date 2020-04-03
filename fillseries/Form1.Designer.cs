using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Spreadsheet;
using System.Windows.Forms;

namespace fillseries
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
            Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste spreadsheetCopyPaste1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste();
            Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController formulaRangeSelectionController1 = new Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController();
            this.spreadsheet = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
            this.ribbon = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon();
            this.skinManager = new Syncfusion.Windows.Forms.SkinManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheet
            // 
            this.spreadsheet.AllowCellContextMenu = true;
            this.spreadsheet.AllowExtendRowColumnCount = true;
            this.spreadsheet.AllowFiltering = false;
            this.spreadsheet.AllowFormulaRangeSelection = true;
            this.spreadsheet.AllowTabItemContextMenu = true;
            this.spreadsheet.AllowZooming = true;
            this.spreadsheet.BaseThemeName = "";
            spreadsheetCopyPaste1.AllowPasteOptionPopup = true;
            spreadsheetCopyPaste1.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;
            this.spreadsheet.CopyPaste = spreadsheetCopyPaste1;
            this.spreadsheet.DefaultColumnCount = 101;
            this.spreadsheet.DefaultRowCount = 101;
            this.spreadsheet.DisplayAlerts = true;
            this.spreadsheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheet.FileName = "Book4";
            this.spreadsheet.FormulaBarVisibility = true;
            formulaRangeSelectionController1.AllowMouseSelection = true;
            formulaRangeSelectionController1.AllowSelectionOnEditing = true;
            this.spreadsheet.FormulaRangeSelectionController = formulaRangeSelectionController1;
            this.spreadsheet.IsCustomTabItemContextMenuEnabled = false;
            this.spreadsheet.Location = new System.Drawing.Point(0, 155);
            this.spreadsheet.Name = "spreadsheet";
            this.spreadsheet.SelectedTabIndex = 0;
            this.spreadsheet.SelectedTabItem = null;
            this.spreadsheet.ShowBusyIndicator = true;
            this.spreadsheet.Size = new System.Drawing.Size(800, 295);
            this.spreadsheet.TabIndex = 0;
            this.spreadsheet.TabItemContextMenu = null;
            this.spreadsheet.WorkbookLoaded += Spreadsheet_WorkbookLoaded;
            this.spreadsheet.Create(3);
            this.spreadsheet.WorksheetAdded += Spreadsheet_WorksheetAdded;
            this.spreadsheet.ThemeName = "Default";
            // 
            // ribbon
            // 
            this.ribbon.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.ribbon.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbon.HideMenuButtonToolTip = true;
            this.ribbon.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MenuButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon.MenuButtonText = "FILE";
            this.ribbon.MenuButtonWidth = 60;
            this.ribbon.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.ribbon.Name = "ribbon";
            this.ribbon.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            // 
            // ribbon.OfficeMenu
            // 
            this.ribbon.OfficeMenu.Name = "OfficeMenu";
            this.ribbon.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.ribbon.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ribbon.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbon.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2013;
            this.ribbon.ShowQuickItemsDropDownButton = false;
            this.ribbon.ShowRibbonDisplayOptionButton = false;
            this.ribbon.Size = new System.Drawing.Size(800, 155);
            this.ribbon.Spreadsheet = null;
            this.ribbon.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbon.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbon.TabIndex = 0;
            this.ribbon.ThemeName = "Default";
            this.ribbon.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ribbon.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // skinManager
            // 
            this.skinManager.Controls = null;
            this.skinManager.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016Colorful;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spreadsheet);
            this.Controls.Add(this.ribbon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
        }

        private void Spreadsheet_WorkbookLoaded(object sender, Syncfusion.Windows.Forms.Spreadsheet.Helpers.WorkbookLoadedEventArgs args)
        {
            foreach(var sheet in args.GridCollection)
            {
                sheet.FillSeriesController.AllowFillSeries = false;
            }
        }

        private void Spreadsheet_WorksheetAdded(object sender, Syncfusion.Windows.Forms.Spreadsheet.Helpers.WorksheetAddedEventArgs args)
        {
            spreadsheet.ActiveGrid.FillSeriesController.AllowFillSeries = false;
        }
        
        #endregion

        private Spreadsheet spreadsheet;
        private SpreadsheetRibbon ribbon;
        private SkinManager skinManager;
    }
}

