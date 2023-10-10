<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLabel
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
        Me.lblDrug = New System.Windows.Forms.Label()
        Me.btnDrug = New System.Windows.Forms.Button()
        Me.lblPatient = New System.Windows.Forms.Label()
        Me.btnPatient = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.btnExtra = New System.Windows.Forms.Button()
        Me.lblExtra = New System.Windows.Forms.Label()
        Me.txtDrugName = New System.Windows.Forms.TextBox()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.pnlPreview = New System.Windows.Forms.Panel()
        Me.txtAllergy = New System.Windows.Forms.TextBox()
        Me.txtAdviceThree = New System.Windows.Forms.TextBox()
        Me.txtAdviceTwo = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.txtExtra = New System.Windows.Forms.TextBox()
        Me.txtAdviceOne = New System.Windows.Forms.TextBox()
        Me.btnAllergies = New System.Windows.Forms.Button()
        Me.lblAllergies = New System.Windows.Forms.Label()
        Me.lblSave = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlPreview.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDrug
        '
        Me.lblDrug.AutoSize = True
        Me.lblDrug.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrug.Location = New System.Drawing.Point(8, 74)
        Me.lblDrug.Name = "lblDrug"
        Me.lblDrug.Size = New System.Drawing.Size(133, 29)
        Me.lblDrug.TabIndex = 0
        Me.lblDrug.Text = "Drug Name:"
        '
        'btnDrug
        '
        Me.btnDrug.Location = New System.Drawing.Point(221, 74)
        Me.btnDrug.Name = "btnDrug"
        Me.btnDrug.Size = New System.Drawing.Size(126, 29)
        Me.btnDrug.TabIndex = 1
        Me.btnDrug.UseVisualStyleBackColor = True
        '
        'lblPatient
        '
        Me.lblPatient.AutoSize = True
        Me.lblPatient.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatient.Location = New System.Drawing.Point(8, 28)
        Me.lblPatient.Name = "lblPatient"
        Me.lblPatient.Size = New System.Drawing.Size(157, 29)
        Me.lblPatient.TabIndex = 2
        Me.lblPatient.Text = "Patient Name:"
        '
        'btnPatient
        '
        Me.btnPatient.Location = New System.Drawing.Point(221, 28)
        Me.btnPatient.Name = "btnPatient"
        Me.btnPatient.Size = New System.Drawing.Size(126, 29)
        Me.btnPatient.TabIndex = 3
        Me.btnPatient.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(461, 24)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(67, 29)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date:"
        '
        'btnDate
        '
        Me.btnDate.Location = New System.Drawing.Point(662, 24)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(126, 29)
        Me.btnDate.TabIndex = 5
        Me.btnDate.UseVisualStyleBackColor = True
        '
        'btnExtra
        '
        Me.btnExtra.Location = New System.Drawing.Point(221, 118)
        Me.btnExtra.Name = "btnExtra"
        Me.btnExtra.Size = New System.Drawing.Size(126, 29)
        Me.btnExtra.TabIndex = 6
        Me.btnExtra.UseVisualStyleBackColor = True
        '
        'lblExtra
        '
        Me.lblExtra.AutoSize = True
        Me.lblExtra.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtra.Location = New System.Drawing.Point(8, 114)
        Me.lblExtra.Name = "lblExtra"
        Me.lblExtra.Size = New System.Drawing.Size(134, 58)
        Me.lblExtra.TabIndex = 7
        Me.lblExtra.Text = "Extra " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Information"
        '
        'txtDrugName
        '
        Me.txtDrugName.BackColor = System.Drawing.Color.White
        Me.txtDrugName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDrugName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrugName.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtDrugName.Location = New System.Drawing.Point(3, 29)
        Me.txtDrugName.Multiline = True
        Me.txtDrugName.Name = "txtDrugName"
        Me.txtDrugName.Size = New System.Drawing.Size(769, 31)
        Me.txtDrugName.TabIndex = 8
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreview.Location = New System.Drawing.Point(357, 178)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(94, 29)
        Me.lblPreview.TabIndex = 9
        Me.lblPreview.Text = "Preview"
        '
        'pnlPreview
        '
        Me.pnlPreview.BackColor = System.Drawing.Color.White
        Me.pnlPreview.Controls.Add(Me.txtAllergy)
        Me.pnlPreview.Controls.Add(Me.txtAdviceThree)
        Me.pnlPreview.Controls.Add(Me.txtAdviceTwo)
        Me.pnlPreview.Controls.Add(Me.txtDate)
        Me.pnlPreview.Controls.Add(Me.txtPatientName)
        Me.pnlPreview.Controls.Add(Me.txtExtra)
        Me.pnlPreview.Controls.Add(Me.txtAdviceOne)
        Me.pnlPreview.Controls.Add(Me.txtDrugName)
        Me.pnlPreview.Location = New System.Drawing.Point(13, 210)
        Me.pnlPreview.Name = "pnlPreview"
        Me.pnlPreview.Size = New System.Drawing.Size(775, 228)
        Me.pnlPreview.TabIndex = 10
        '
        'txtAllergy
        '
        Me.txtAllergy.BackColor = System.Drawing.Color.White
        Me.txtAllergy.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAllergy.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllergy.ForeColor = System.Drawing.Color.Green
        Me.txtAllergy.Location = New System.Drawing.Point(3, 205)
        Me.txtAllergy.Multiline = True
        Me.txtAllergy.Name = "txtAllergy"
        Me.txtAllergy.Size = New System.Drawing.Size(769, 20)
        Me.txtAllergy.TabIndex = 15
        '
        'txtAdviceThree
        '
        Me.txtAdviceThree.BackColor = System.Drawing.Color.White
        Me.txtAdviceThree.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAdviceThree.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdviceThree.Location = New System.Drawing.Point(3, 144)
        Me.txtAdviceThree.Multiline = True
        Me.txtAdviceThree.Name = "txtAdviceThree"
        Me.txtAdviceThree.Size = New System.Drawing.Size(769, 33)
        Me.txtAdviceThree.TabIndex = 14
        '
        'txtAdviceTwo
        '
        Me.txtAdviceTwo.BackColor = System.Drawing.Color.White
        Me.txtAdviceTwo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAdviceTwo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdviceTwo.Location = New System.Drawing.Point(3, 105)
        Me.txtAdviceTwo.Multiline = True
        Me.txtAdviceTwo.Name = "txtAdviceTwo"
        Me.txtAdviceTwo.Size = New System.Drawing.Size(769, 33)
        Me.txtAdviceTwo.TabIndex = 13
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.Color.White
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(500, 3)
        Me.txtDate.Multiline = True
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(272, 20)
        Me.txtDate.TabIndex = 12
        '
        'txtPatientName
        '
        Me.txtPatientName.BackColor = System.Drawing.Color.White
        Me.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPatientName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientName.Location = New System.Drawing.Point(3, 3)
        Me.txtPatientName.Multiline = True
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(269, 20)
        Me.txtPatientName.TabIndex = 11
        '
        'txtExtra
        '
        Me.txtExtra.BackColor = System.Drawing.Color.White
        Me.txtExtra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExtra.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExtra.ForeColor = System.Drawing.Color.Lime
        Me.txtExtra.Location = New System.Drawing.Point(3, 183)
        Me.txtExtra.Multiline = True
        Me.txtExtra.Name = "txtExtra"
        Me.txtExtra.Size = New System.Drawing.Size(769, 20)
        Me.txtExtra.TabIndex = 10
        '
        'txtAdviceOne
        '
        Me.txtAdviceOne.BackColor = System.Drawing.Color.White
        Me.txtAdviceOne.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAdviceOne.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdviceOne.ForeColor = System.Drawing.Color.Red
        Me.txtAdviceOne.Location = New System.Drawing.Point(3, 66)
        Me.txtAdviceOne.Multiline = True
        Me.txtAdviceOne.Name = "txtAdviceOne"
        Me.txtAdviceOne.Size = New System.Drawing.Size(769, 33)
        Me.txtAdviceOne.TabIndex = 9
        '
        'btnAllergies
        '
        Me.btnAllergies.Location = New System.Drawing.Point(662, 74)
        Me.btnAllergies.Name = "btnAllergies"
        Me.btnAllergies.Size = New System.Drawing.Size(126, 29)
        Me.btnAllergies.TabIndex = 11
        Me.btnAllergies.UseVisualStyleBackColor = True
        '
        'lblAllergies
        '
        Me.lblAllergies.AutoSize = True
        Me.lblAllergies.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllergies.Location = New System.Drawing.Point(461, 74)
        Me.lblAllergies.Name = "lblAllergies"
        Me.lblAllergies.Size = New System.Drawing.Size(107, 29)
        Me.lblAllergies.TabIndex = 12
        Me.lblAllergies.Text = "Allergies:"
        '
        'lblSave
        '
        Me.lblSave.AutoSize = True
        Me.lblSave.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSave.Location = New System.Drawing.Point(461, 118)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(113, 29)
        Me.lblSave.TabIndex = 13
        Me.lblSave.Text = "Save label"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(662, 118)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(126, 29)
        Me.btnSave.TabIndex = 14
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'FormLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblSave)
        Me.Controls.Add(Me.lblAllergies)
        Me.Controls.Add(Me.btnAllergies)
        Me.Controls.Add(Me.pnlPreview)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.lblExtra)
        Me.Controls.Add(Me.btnExtra)
        Me.Controls.Add(Me.btnDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnPatient)
        Me.Controls.Add(Me.lblPatient)
        Me.Controls.Add(Me.btnDrug)
        Me.Controls.Add(Me.lblDrug)
        Me.Name = "FormLabel"
        Me.Text = "Drug Label Creator"
        Me.pnlPreview.ResumeLayout(False)
        Me.pnlPreview.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDrug As Label
    Friend WithEvents btnDrug As Button
    Friend WithEvents lblPatient As Label
    Friend WithEvents btnPatient As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents btnDate As Button
    Friend WithEvents btnExtra As Button
    Friend WithEvents lblExtra As Label
    Friend WithEvents txtDrugName As TextBox
    Friend WithEvents lblPreview As Label
    Friend WithEvents pnlPreview As Panel
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents txtExtra As TextBox
    Friend WithEvents txtAdviceOne As TextBox
    Friend WithEvents txtAdviceThree As TextBox
    Friend WithEvents txtAdviceTwo As TextBox
    Friend WithEvents txtAllergy As TextBox
    Friend WithEvents btnAllergies As Button
    Friend WithEvents lblAllergies As Label
    Friend WithEvents lblSave As Label
    Friend WithEvents btnSave As Button
End Class
