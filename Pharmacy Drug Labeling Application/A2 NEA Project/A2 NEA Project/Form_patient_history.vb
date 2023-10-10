'This code loads data into the patient data table.
Public Class Form_patient_history
    Private Sub Form_patient_history_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.PatientDataTableAdapter.Fill(Me.DrugsDatabaseDataSet1.PatientData)

    End Sub

    Private Sub PatientDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Try
            PatientDataBindingSource.EndEdit()
            PatientDataTableAdapter.Update(DrugsDatabaseDataSet1.PatientData)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        Try
            PatientDataBindingSource.EndEdit()
            PatientDataTableAdapter.Update(DrugsDatabaseDataSet1.PatientData)
        Catch ex As Exception

        End Try
    End Sub

    'This function causes the program to close once the exit button is clicked under the file tab.
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As Integer
        result = MsgBox("Do you want to exit?", vbYesNo)
        If result = vbYes Then
            Application.Exit()
        End If
    End Sub



    'These functions allow the datagrid to be printed by taking its dimensions and also creating a preview for this.

    Dim bitmap1 As Bitmap

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Dim height As Integer = DataGridView1.Height
        DataGridView1.Height = (DataGridView1.RowCount + 1) * DataGridView1.RowTemplate.Height
        bitmap1 = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bitmap1, New Rectangle(0, 0, Me.DataGridView1.Width, DataGridView1.Height))
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        DataGridView1.Height = height
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap1, 0, 0)
        Dim printview As RectangleF = e.PageSettings.PrintableArea
        If Me.DataGridView1.Height - printview.Height > 0 Then
            e.HasMorePages = True
        End If
    End Sub


End Class



