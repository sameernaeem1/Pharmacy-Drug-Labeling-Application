<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_patient_history
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Patient_NameLabel As System.Windows.Forms.Label
        Dim Date_of_prescriptionLabel As System.Windows.Forms.Label
        Dim Drug_givenLabel As System.Windows.Forms.Label
        Dim Extra_infoLabel As System.Windows.Forms.Label
        Dim AllergiesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_patient_history))
        Me.PatientDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DrugsDatabaseDataSet1 = New A2_NEA_Project.drugsDatabaseDataSet1()
        Me.Patient_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_prescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Drug_givenTextBox = New System.Windows.Forms.TextBox()
        Me.Extra_infoTextBox = New System.Windows.Forms.TextBox()
        Me.AllergiesTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PatientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfPrescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugGivenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtraInfoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AllergiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientDataTableAdapter = New A2_NEA_Project.drugsDatabaseDataSet1TableAdapters.PatientDataTableAdapter()
        Me.TableAdapterManager = New A2_NEA_Project.drugsDatabaseDataSet1TableAdapters.TableAdapterManager()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Patient_NameLabel = New System.Windows.Forms.Label()
        Date_of_prescriptionLabel = New System.Windows.Forms.Label()
        Drug_givenLabel = New System.Windows.Forms.Label()
        Extra_infoLabel = New System.Windows.Forms.Label()
        AllergiesLabel = New System.Windows.Forms.Label()
        CType(Me.PatientDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrugsDatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Patient_NameLabel
        '
        Patient_NameLabel.AutoSize = True
        Patient_NameLabel.Location = New System.Drawing.Point(12, 132)
        Patient_NameLabel.Name = "Patient_NameLabel"
        Patient_NameLabel.Size = New System.Drawing.Size(74, 13)
        Patient_NameLabel.TabIndex = 1
        Patient_NameLabel.Text = "Patient Name:"
        '
        'Date_of_prescriptionLabel
        '
        Date_of_prescriptionLabel.AutoSize = True
        Date_of_prescriptionLabel.Location = New System.Drawing.Point(12, 158)
        Date_of_prescriptionLabel.Name = "Date_of_prescriptionLabel"
        Date_of_prescriptionLabel.Size = New System.Drawing.Size(102, 13)
        Date_of_prescriptionLabel.TabIndex = 3
        Date_of_prescriptionLabel.Text = "Date of prescription:"
        '
        'Drug_givenLabel
        '
        Drug_givenLabel.AutoSize = True
        Drug_givenLabel.Location = New System.Drawing.Point(12, 184)
        Drug_givenLabel.Name = "Drug_givenLabel"
        Drug_givenLabel.Size = New System.Drawing.Size(62, 13)
        Drug_givenLabel.TabIndex = 5
        Drug_givenLabel.Text = "Drug given:"
        '
        'Extra_infoLabel
        '
        Extra_infoLabel.AutoSize = True
        Extra_infoLabel.Location = New System.Drawing.Point(12, 210)
        Extra_infoLabel.Name = "Extra_infoLabel"
        Extra_infoLabel.Size = New System.Drawing.Size(54, 13)
        Extra_infoLabel.TabIndex = 7
        Extra_infoLabel.Text = "Extra info:"
        '
        'AllergiesLabel
        '
        AllergiesLabel.AutoSize = True
        AllergiesLabel.Location = New System.Drawing.Point(12, 236)
        AllergiesLabel.Name = "AllergiesLabel"
        AllergiesLabel.Size = New System.Drawing.Size(49, 13)
        AllergiesLabel.TabIndex = 9
        AllergiesLabel.Text = "Allergies:"
        '
        'PatientDataBindingSource
        '
        Me.PatientDataBindingSource.DataMember = "PatientData"
        Me.PatientDataBindingSource.DataSource = Me.DrugsDatabaseDataSet1
        '
        'DrugsDatabaseDataSet1
        '
        Me.DrugsDatabaseDataSet1.DataSetName = "drugsDatabaseDataSet1"
        Me.DrugsDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Patient_NameTextBox
        '
        Me.Patient_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientDataBindingSource, "Patient Name", True))
        Me.Patient_NameTextBox.Location = New System.Drawing.Point(120, 129)
        Me.Patient_NameTextBox.Name = "Patient_NameTextBox"
        Me.Patient_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Patient_NameTextBox.TabIndex = 2
        '
        'Date_of_prescriptionTextBox
        '
        Me.Date_of_prescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientDataBindingSource, "Date of prescription", True))
        Me.Date_of_prescriptionTextBox.Location = New System.Drawing.Point(120, 155)
        Me.Date_of_prescriptionTextBox.Name = "Date_of_prescriptionTextBox"
        Me.Date_of_prescriptionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Date_of_prescriptionTextBox.TabIndex = 4
        '
        'Drug_givenTextBox
        '
        Me.Drug_givenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientDataBindingSource, "Drug given", True))
        Me.Drug_givenTextBox.Location = New System.Drawing.Point(120, 181)
        Me.Drug_givenTextBox.Name = "Drug_givenTextBox"
        Me.Drug_givenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Drug_givenTextBox.TabIndex = 6
        '
        'Extra_infoTextBox
        '
        Me.Extra_infoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientDataBindingSource, "Extra info", True))
        Me.Extra_infoTextBox.Location = New System.Drawing.Point(120, 207)
        Me.Extra_infoTextBox.Name = "Extra_infoTextBox"
        Me.Extra_infoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Extra_infoTextBox.TabIndex = 8
        '
        'AllergiesTextBox
        '
        Me.AllergiesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientDataBindingSource, "Allergies", True))
        Me.AllergiesTextBox.Location = New System.Drawing.Point(120, 233)
        Me.AllergiesTextBox.Name = "AllergiesTextBox"
        Me.AllergiesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AllergiesTextBox.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientNameDataGridViewTextBoxColumn, Me.DateOfPrescriptionDataGridViewTextBoxColumn, Me.DrugGivenDataGridViewTextBoxColumn, Me.ExtraInfoDataGridViewTextBoxColumn, Me.AllergiesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PatientDataBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(245, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(543, 356)
        Me.DataGridView1.TabIndex = 11
        '
        'PatientNameDataGridViewTextBoxColumn
        '
        Me.PatientNameDataGridViewTextBoxColumn.DataPropertyName = "Patient Name"
        Me.PatientNameDataGridViewTextBoxColumn.HeaderText = "Patient Name"
        Me.PatientNameDataGridViewTextBoxColumn.Name = "PatientNameDataGridViewTextBoxColumn"
        '
        'DateOfPrescriptionDataGridViewTextBoxColumn
        '
        Me.DateOfPrescriptionDataGridViewTextBoxColumn.DataPropertyName = "Date of prescription"
        Me.DateOfPrescriptionDataGridViewTextBoxColumn.HeaderText = "Date of prescription"
        Me.DateOfPrescriptionDataGridViewTextBoxColumn.Name = "DateOfPrescriptionDataGridViewTextBoxColumn"
        '
        'DrugGivenDataGridViewTextBoxColumn
        '
        Me.DrugGivenDataGridViewTextBoxColumn.DataPropertyName = "Drug given"
        Me.DrugGivenDataGridViewTextBoxColumn.HeaderText = "Drug given"
        Me.DrugGivenDataGridViewTextBoxColumn.Name = "DrugGivenDataGridViewTextBoxColumn"
        '
        'ExtraInfoDataGridViewTextBoxColumn
        '
        Me.ExtraInfoDataGridViewTextBoxColumn.DataPropertyName = "Extra info"
        Me.ExtraInfoDataGridViewTextBoxColumn.HeaderText = "Extra info"
        Me.ExtraInfoDataGridViewTextBoxColumn.Name = "ExtraInfoDataGridViewTextBoxColumn"
        '
        'AllergiesDataGridViewTextBoxColumn
        '
        Me.AllergiesDataGridViewTextBoxColumn.DataPropertyName = "Allergies"
        Me.AllergiesDataGridViewTextBoxColumn.HeaderText = "Allergies"
        Me.AllergiesDataGridViewTextBoxColumn.Name = "AllergiesDataGridViewTextBoxColumn"
        '
        'PatientDataTableAdapter
        '
        Me.PatientDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.PatientDataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = A2_NEA_Project.drugsDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form_patient_history
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Patient_NameLabel)
        Me.Controls.Add(Me.Patient_NameTextBox)
        Me.Controls.Add(Date_of_prescriptionLabel)
        Me.Controls.Add(Me.Date_of_prescriptionTextBox)
        Me.Controls.Add(Drug_givenLabel)
        Me.Controls.Add(Me.Drug_givenTextBox)
        Me.Controls.Add(Extra_infoLabel)
        Me.Controls.Add(Me.Extra_infoTextBox)
        Me.Controls.Add(AllergiesLabel)
        Me.Controls.Add(Me.AllergiesTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_patient_history"
        Me.Text = "Patient History"
        CType(Me.PatientDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrugsDatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrugsDatabaseDataSet1 As drugsDatabaseDataSet1
    Friend WithEvents PatientDataBindingSource As BindingSource
    Friend WithEvents PatientDataTableAdapter As drugsDatabaseDataSet1TableAdapters.PatientDataTableAdapter
    Friend WithEvents TableAdapterManager As drugsDatabaseDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Patient_NameTextBox As TextBox
    Friend WithEvents Date_of_prescriptionTextBox As TextBox
    Friend WithEvents Drug_givenTextBox As TextBox
    Friend WithEvents Extra_infoTextBox As TextBox
    Friend WithEvents AllergiesTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PatientNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfPrescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugGivenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExtraInfoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AllergiesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
