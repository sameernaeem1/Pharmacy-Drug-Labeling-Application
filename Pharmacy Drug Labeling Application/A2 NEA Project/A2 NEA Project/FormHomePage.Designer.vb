<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHomepage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLabelCreator = New System.Windows.Forms.Button()
        Me.lblLabelCreator = New System.Windows.Forms.Label()
        Me.lblPatientHistory = New System.Windows.Forms.Label()
        Me.btn_patient_history = New System.Windows.Forms.Button()
        Me.lblLink = New System.Windows.Forms.Label()
        Me.btnWebsite = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLabelCreator
        '
        Me.btnLabelCreator.Location = New System.Drawing.Point(88, 157)
        Me.btnLabelCreator.Name = "btnLabelCreator"
        Me.btnLabelCreator.Size = New System.Drawing.Size(234, 103)
        Me.btnLabelCreator.TabIndex = 0
        Me.btnLabelCreator.UseVisualStyleBackColor = True
        '
        'lblLabelCreator
        '
        Me.lblLabelCreator.AutoSize = True
        Me.lblLabelCreator.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabelCreator.Location = New System.Drawing.Point(107, 72)
        Me.lblLabelCreator.Name = "lblLabelCreator"
        Me.lblLabelCreator.Size = New System.Drawing.Size(194, 39)
        Me.lblLabelCreator.TabIndex = 2
        Me.lblLabelCreator.Text = "Label Creator"
        '
        'lblPatientHistory
        '
        Me.lblPatientHistory.AutoSize = True
        Me.lblPatientHistory.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientHistory.Location = New System.Drawing.Point(494, 72)
        Me.lblPatientHistory.Name = "lblPatientHistory"
        Me.lblPatientHistory.Size = New System.Drawing.Size(214, 39)
        Me.lblPatientHistory.TabIndex = 3
        Me.lblPatientHistory.Text = "Patient History"
        '
        'btn_patient_history
        '
        Me.btn_patient_history.Location = New System.Drawing.Point(488, 157)
        Me.btn_patient_history.Name = "btn_patient_history"
        Me.btn_patient_history.Size = New System.Drawing.Size(234, 103)
        Me.btn_patient_history.TabIndex = 5
        Me.btn_patient_history.UseVisualStyleBackColor = True
        '
        'lblLink
        '
        Me.lblLink.AutoSize = True
        Me.lblLink.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLink.Location = New System.Drawing.Point(190, 289)
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(441, 33)
        Me.lblLink.TabIndex = 6
        Me.lblLink.Text = "Click Here For More Drug Information"
        '
        'btnWebsite
        '
        Me.btnWebsite.Location = New System.Drawing.Point(290, 348)
        Me.btnWebsite.Name = "btnWebsite"
        Me.btnWebsite.Size = New System.Drawing.Size(234, 66)
        Me.btnWebsite.TabIndex = 7
        Me.btnWebsite.UseVisualStyleBackColor = True
        '
        'FormHomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnWebsite)
        Me.Controls.Add(Me.lblLink)
        Me.Controls.Add(Me.btn_patient_history)
        Me.Controls.Add(Me.lblPatientHistory)
        Me.Controls.Add(Me.lblLabelCreator)
        Me.Controls.Add(Me.btnLabelCreator)
        Me.Name = "FormHomepage"
        Me.Text = "Home Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLabelCreator As Button
    Friend WithEvents lblLabelCreator As Label
    Friend WithEvents lblPatientHistory As Label
    Friend WithEvents btn_patient_history As Button
    Friend WithEvents lblLink As Label
    Friend WithEvents btnWebsite As Button
End Class
