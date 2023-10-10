Imports System.Data.OleDb

'Declaration of variables

Public Class FormLabel

    Dim inc As Integer
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim drugID As Integer
    Dim patientName As String
    Dim extraInfo As String
    Dim drugdate As String
    Dim allergy As String

    Dim connnstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection



    'This function is for the label creating form.
    'It is used to link the databse of drugs and their advice to the form.
    'dbProvider is what is used to connect to the database and dbSource specifies where the database is located on the computer.
    'The variable con holds the connection object that is needed to connect to the database.
    'As microsoft access is being used for the database, OLEDB is the connection object that needs to be used. 
    'The connection object is opened and the table called DrugData is selected from the database.
    'This allows information to be read from this table and entered automatically in to the program at a later stage.


    Private Sub FormLabel_load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = D:\Pharmacy Drug Labeling Application\drugsDatabase.accdb"

        con.ConnectionString = dbProvider & dbSource

        con.Open()

        sql = "SELECT * FROM DrugData"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "drugsDatabase")

        con.Close()

    End Sub


    'This function is what happens when the button is clicked next to drug name on the form.
    'An input box appears that gives the names of the different drugs in the database along with a number for each one.
    'The user must enter one of these numbers based on which drug they would like to create a label for.
    'The number that the user enters is then stored as a variable with the name drugID.
    'This number directly corresponds to the ID for that drug in the DrugData table in the database and is compared with it.
    'In the preview box, the first textbox shows the name of the drug, which is in the second collumn of the table.
    'The next three text boxes show the advice for that drug in order of importance.


    Private Sub btnDrug_Click(sender As Object, e As EventArgs) Handles btnDrug.Click

        drugID = InputBox("Enter the number corresponding to the drug." & vbCrLf & "0. Aspirin dispersible tablets" & vbCrLf & "1. Doxycycline" & vbCrLf & "2. Sodium valproate tablets" & vbCrLf & "3. Prednisolone soluble tablets" & vbCrLf & "4. Paramax soluble tablets" & vbCrLf & "5. Nitrofurantoin modified-release capsules" & vbCrLf & "6. Metronidazole tablets" & vbCrLf & "7. Aspirin gastro-resistant tablets", "Drug Name")

        If drugID = 0 Or drugID = 1 Or drugID = 2 Or drugID = 3 Or drugID = 4 Or drugID = 5 Or drugID = 6 Or drugID = 7 Then
            txtDrugName.Text = (ds.Tables("drugsDatabase").Rows(drugID).Item(1))
            txtAdviceOne.Text = ("1. " & ds.Tables("drugsDatabase").Rows(drugID).Item(2))
            txtAdviceTwo.Text = ("2. " & ds.Tables("drugsDatabase").Rows(drugID).Item(3))
            txtAdviceThree.Text = ("3. " & ds.Tables("drugsDatabase").Rows(drugID).Item(4))
        Else
            MsgBox("Please select a number from the list given.", MsgBoxStyle.Information, "Drug name")
        End If





        Dim strsql As String
        strsql = "select id,drug,1,2,3 from DrugData where id=" + drugID.ToString + ""

    End Sub


    Private Sub NavigateRecords()

        txtDrugName.Text = ds.Tables("drugsDatabase").Rows(drugID).Item(1)

    End Sub

    'This function is what happens when the button is clicked next to patient name.
    'An input box appears and asks the user to enter a name which is stored as a variable.
    'The name entered then appears in the preview panel at the top in a text box.

    Private Sub btnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click

        patientName = InputBox("Enter the patient's name.", "Patient Name")
        txtPatientName.Text = patientName

    End Sub

    'This function is what happens when the button is clicked next to extra information.
    'An input box appears that asks the user to enter any extra information and stores it as a variable.
    'This extra infromation is shown underneath the advice on the label and is highlighted in green so it is easily identified.

    Private Sub btnExtra_Click(sender As Object, e As EventArgs) Handles btnExtra.Click

        extraInfo = InputBox("Add any extra information here.", "Extra Information")
        txtExtra.Text = extraInfo

    End Sub

    'This function is what happens when the button is clicked next to date.
    'An input box appears that asks the user to enter the date and stores it as a variable.
    'This is shown at the top of the preview panel next to the patient's name.

    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click

        drugdate = InputBox("Enter the date.", "Date")
        txtDate.Text = drugdate

    End Sub

    'This function is what happens when the button is clicked next to Allergies.
    'An input box appears that asks the user to enter any allergies the patient may have.
    'This information is shown at the bottom of the label.

    Private Sub btnAllergies_Click(sender As Object, e As EventArgs) Handles btnAllergies.Click

        allergy = InputBox("Enter any allergies here.", "Allergies")
        txtAllergy.Text = allergy

    End Sub


    'This function is what happens when the save label button is clicked.
    'Once all of the different aspects of the label have been filled out by the user, they can click this button to save the information they have entered.
    'When clicked, all of the information is written to a table called PatientData.
    'An information box then pops up to notify the user that the process has been successfully completed.

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        connnstring = dbProvider & dbSource
        myconnection.ConnectionString = connnstring
        myconnection.Open()

        command = "insert into PatientData ([Patient Name],[Date of prescription],[Drug Given],[Extra info],[Allergies]) values ('" & patientName & "','" & drugdate & "','" & txtDrugName.Text & "','" & extraInfo & "','" & allergy & "')"

        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("Patient Name", CType(patientName, String)))
        cmd.Parameters.Add(New OleDbParameter("Date of prescription", CType(drugdate, String)))
        cmd.Parameters.Add(New OleDbParameter("Drug given", CType(txtDrugName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Extra info", CType(extraInfo, String)))
        cmd.Parameters.Add(New OleDbParameter("Allergies", CType(allergy, String)))
        MsgBox("Label information saved.", MsgBoxStyle.Information, "Save label")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


End Class

