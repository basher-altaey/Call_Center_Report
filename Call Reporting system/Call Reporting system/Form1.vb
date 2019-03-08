Imports System.IO


Public Class Form1

    Dim todaydate As String
    Dim employeemasterstring As String = "EmployeeMaster.txt"
    Private employeestreamreader As StreamReader
    Dim formstreamreader As StreamReader
    Friend arrayemployee(50) As employee
    Private outputfile As String
    Private employeestreamwriter As StreamWriter
    Private isdirtyboolean As Boolean
    Friend employeecountinteger As Integer
    Dim index As Integer
    Structure employee
        Dim Id As String
        Dim name As String
        Dim totalcalls As Integer
        Dim sucesscalls As Integer
        Dim totalphonetime As Integer
        Dim workedhours As Decimal
        Dim successrate As Integer
        Dim mincpercall As Decimal
        Dim EmployeeEntered As Integer
    End Structure


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       
        Try
            employeestreamreader = New StreamReader(employeemasterstring)
        Catch ex As Exception
            MessageBox.Show("File not found or is invalid.", "Data Error")
            End
        End Try
        readallrcords()
        closeemployeefile()
        populatecboboxes()


    End Sub

    Private Sub readallrcords()
        Do While employeestreamreader.Peek <> -1
            Try
                arrayemployee(employeecountinteger).Id = employeestreamreader.ReadLine.ToString
                arrayemployee(employeecountinteger).name = employeestreamreader.ReadLine.ToString
                employeecountinteger += 1

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Loop
    End Sub
    Private Sub populatecboboxes()
        For i As Integer = 0 To employeecountinteger - 1
            Me.EmployeeIDComboBox.Items.Add(arrayemployee(i).Id)
        Next
    End Sub
    Private Sub closeemployeefile()
        If Not employeestreamreader Is Nothing Then
            employeestreamreader.Close()

        End If
    End Sub

    Private Sub EmployeeIDComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeIDComboBox.SelectedIndexChanged

        If EmployeeIDComboBox.SelectedIndex > -1 Then

            nameLabel.Text = arrayemployee(EmployeeIDComboBox.SelectedIndex).name
        End If

    End Sub

    Private Sub saveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveButton.Click
        Dim RespondDialogResult As DialogResult
        Dim totalcallsinteger, totalsccessfullcallsinteger, totalamounthoursinteger As Integer
        Dim totalhourworkeddecimal As Decimal
        Dim indexinteger As Integer = EmployeeIDComboBox.SelectedIndex
        Dim messagestring As String = " "
        Try
            ValidateDate()

            totalcallsinteger = Integer.Parse(totalcallsTextBox.Text)
            totalsccessfullcallsinteger = Integer.Parse(TotalsuccessfulcallsTextBox.Text)
            totalamounthoursinteger = Integer.Parse(TotalphonetimeTextBox.Text)
            totalhourworkeddecimal = Integer.Parse(TotalhoursworkedTextBox.Text)


            If totalcallsinteger < totalsccessfullcallsinteger Then
                MessageBox.Show("total calls must be more than total sccessfull cals")
            End If

            If totalamounthoursinteger / 60 > totalhourworkeddecimal Then
                MessageBox.Show("The work must be more than telphone time ")
            End If
         
            If totalcallsTextBox.Text = "" Then
                MessageBox.Show("Please enter your Tatal calls ")

            ElseIf TotalsuccessfulcallsTextBox.Text = "" Then
                MessageBox.Show("Please enter your successfull calls ")

            ElseIf TotalphonetimeTextBox.Text = "" Then
                MessageBox.Show("Please enter the time spand on time calls")

            ElseIf TotalhoursworkedTextBox.Text = "" Then
                MessageBox.Show("Please enter the work hours")

            Else

                totalcallsTextBox.Clear()
                TotalhoursworkedTextBox.Clear()
                TotalphonetimeTextBox.Clear()
                TotalsuccessfulcallsTextBox.Clear()
                isdirtyboolean = False

            End If


            arrayemployee(indexinteger).totalcalls = totalcallsinteger
            arrayemployee(indexinteger).sucesscalls = totalsccessfullcallsinteger
            arrayemployee(indexinteger).totalphonetime = totalamounthoursinteger
            arrayemployee(indexinteger).workedhours = totalhourworkeddecimal
            arrayemployee(indexinteger).successrate = arrayemployee(indexinteger).sucesscalls / arrayemployee(indexinteger).totalcalls * 100
            arrayemployee(indexinteger).mincpercall = arrayemployee(indexinteger).totalphonetime / arrayemployee(indexinteger).totalcalls
        Catch
            MessageBox.Show("The form is not complete")
        End Try

        Try
            formstreamreader = New StreamReader(outputfile)


            While formstreamreader.Peek <> -1
                arrayemployee(index).name = formstreamreader.ReadLine.ToString
                arrayemployee(index).Id = formstreamreader.ReadLine
                arrayemployee(index).totalcalls = formstreamreader.ReadLine
                arrayemployee(index).sucesscalls = formstreamreader.ReadLine
                arrayemployee(index).totalphonetime = formstreamreader.ReadLine
                arrayemployee(index).workedhours = formstreamreader.ReadLine
                arrayemployee(index).successrate = formstreamreader.ReadLine
                arrayemployee(index).mincpercall = formstreamreader.ReadLine
                index += 1
            End While


            index = EmployeeIDComboBox.SelectedIndex




            If arrayemployee(index).Id = Me.EmployeeIDComboBox.SelectedItem Then

                If arrayemployee(index).totalcalls = totalcallsinteger And
                    arrayemployee(index).sucesscalls = totalsccessfullcallsinteger And
                    arrayemployee(index).totalphonetime = totalamounthoursinteger And
                    arrayemployee(index).workedhours = totalhourworkeddecimal Then


                Else

                    messagestring += "exist total Total Calls : " & arrayemployee(index).totalcalls.ToString & "  and new number is: Total Calls " & totalcallsinteger & ControlChars.NewLine & _
                   "exist total successful Calls : " & arrayemployee(index).sucesscalls.ToString & "  new Total Successful Calls " & totalsccessfullcallsinteger & ControlChars.NewLine & _
                  "exist total Time spand on calls : " & arrayemployee(index).totalphonetime.ToString & " new n Total Amount of calls time " & totalamounthoursinteger & ControlChars.NewLine & _
                     "exist Total hours worked  : " & arrayemployee(index).workedhours.ToString & "  new  Total Worked Hours " & totalhourworkeddecimal & ControlChars.NewLine


                End If
                If MessageBox.Show(messagestring.ToString, "   ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    arrayemployee(index).totalcalls = totalcallsinteger
                    arrayemployee(index).sucesscalls = totalsccessfullcallsinteger
                    arrayemployee(index).totalphonetime = totalamounthoursinteger
                    arrayemployee(index).workedhours = totalhourworkeddecimal

                End If
            End If
            arrayemployee(index).successrate = arrayemployee(index).sucesscalls / arrayemployee(index).totalcalls * 100
            arrayemployee(index).mincpercall = arrayemployee(index).totalphonetime / arrayemployee(index).totalcalls
            formstreamreader.Close()
        Catch

            MessageBox.Show("NOT WORKING")
        End Try



    End Sub
    Sub copyarraytofile()

        Try


            outputfile = "Dailylog" + Date.Parse(dateTextBox.Text).ToString("ddMMyy") + ".txt"

            employeestreamwriter = New StreamWriter(outputfile)
            For i = 0 To employeecountinteger - 1
                employeestreamwriter.WriteLine(arrayemployee(i).name)
                employeestreamwriter.WriteLine(arrayemployee(i).Id)
                employeestreamwriter.WriteLine(arrayemployee(i).totalcalls.ToString)
                employeestreamwriter.WriteLine(arrayemployee(i).sucesscalls.ToString)
                employeestreamwriter.WriteLine(arrayemployee(i).totalphonetime.ToString)
                employeestreamwriter.WriteLine(arrayemployee(i).workedhours.ToString)
                employeestreamwriter.WriteLine(arrayemployee(i).successrate.ToString)
                employeestreamwriter.WriteLine(arrayemployee(i).mincpercall.ToString)

            Next

            employeestreamwriter.Close()

        Catch
            MessageBox.Show(" The file haven't been saved")

        End Try
    End Sub
    Sub checkbalnkfield()
        If totalcallsTextBox.Text <> String.Empty Or TotalsuccessfulcallsTextBox.Text <> String.Empty Or TotalphonetimeTextBox.Text <> String.Empty Or TotalhoursworkedTextBox.Text <> String.Empty Then
            isdirtyboolean = True

        End If
    End Sub

    Private Sub displayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles displayButton.Click
        Dim i As Integer
        Dim n As Integer
        For i = 0 To employeecountinteger - 1
            n = report.DataGridView1.Rows.Add
            report.DataGridView1.Rows.Item(n).Cells(0).Value = arrayemployee(i).name
            report.DataGridView1.Rows.Item(n).Cells(1).Value = arrayemployee(i).Id
            report.DataGridView1.Rows.Item(n).Cells(2).Value = arrayemployee(i).totalcalls.ToString("F0")
            report.DataGridView1.Rows.Item(n).Cells(3).Value = arrayemployee(i).sucesscalls.ToString("F0")
            report.DataGridView1.Rows.Item(n).Cells(4).Value = arrayemployee(i).totalphonetime.ToString("F0")
            report.DataGridView1.Rows.Item(n).Cells(5).Value = arrayemployee(i).workedhours.ToString("F0")
            report.DataGridView1.Rows.Item(n).Cells(6).Value = arrayemployee(i).successrate.ToString("F0") & ("%")
            report.DataGridView1.Rows.Item(n).Cells(7).Value = arrayemployee(i).mincpercall.ToString("F")

        Next

        report.Text = "  "
        report.Show()
    End Sub



    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click

        EmployeeIDComboBox.SelectedIndex = -1
    

        totalcallsTextBox.Clear()
        TotalhoursworkedTextBox.Clear()
        TotalphonetimeTextBox.Clear()
        TotalsuccessfulcallsTextBox.Clear()

        With dateTextBox
            .Clear()
            .Enabled = True
            .Text = "dd/mm/yy"
        End With
        nameLabel.Text = ""
        index = 0
        For i = 0 To 27

            arrayemployee(index).totalcalls = 0
            arrayemployee(index).sucesscalls = 0
            arrayemployee(index).totalphonetime = 0
            arrayemployee(index).workedhours = 0
            arrayemployee(index).successrate = 0
            arrayemployee(index).mincpercall = 0
            index += 1
        Next


    End Sub

    Private Sub PrintAllPrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintAllPrintDocument.PrintPage


        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim PrintLineString As String

        Dim totaloftotalcalls As Integer
        Dim totalsuccesscalls As Integer
        Dim totalrate As Integer
        Dim totalmin As Decimal
        Using HeadingFont

            PrintLineString = "Daily Call Success Rate Report - " & Date.Today.ToLongDateString

            e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += LineHeightSingle + 2

        End Using

        PrintLineString = "_____________________________________________________________________________"

        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle



        PrintLineString = "  Employee" & "          " & "    Employee" & "        Total" & "      Successful" & "    Success" & "    Minutes Per" & "      Hours" & ControlChars.NewLine & "     Name" & "                        ID" & "             Calls" & "          Calls" & _
            "         Rate (%)" & "    Call (AVG)" & "      Worked" & Environment.NewLine & "_____________________________________________________________________________" & ControlChars.NewLine
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle



        For i = 0 To 26

            PrintLineString = ControlChars.NewLine & ControlChars.NewLine & arrayemployee(index).name & ControlChars.Tab & "       " & arrayemployee(index).Id & ControlChars.Tab & " " & arrayemployee(index).totalcalls & _
            ControlChars.Tab & "    " & arrayemployee(index).sucesscalls & ControlChars.Tab & "          " & arrayemployee(index).successrate & "%" & ControlChars.Tab & "      " & _
            arrayemployee(index).mincpercall & ControlChars.Tab & "          " & arrayemployee(index).workedhours & ControlChars.NewLine
            e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += LineHeightSingle

            index += 1

            totaloftotalcalls += arrayemployee(index).totalcalls
            totalsuccesscalls += arrayemployee(index).sucesscalls
            totalrate += arrayemployee(index).successrate
            totalmin += arrayemployee(index).mincpercall
        Next



        PrintLineString = ControlChars.NewLine


        PrintLineString = ControlChars.NewLine & "_____________________________________________________________________________" & ControlChars.NewLine
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle


        PrintLineString = ControlChars.NewLine & "Total" & ControlChars.Tab & "                   " & totaloftotalcalls & ControlChars.Tab & "        " & totalsuccesscalls & _
            ControlChars.Tab & "          " & totalrate & ControlChars.Tab & "        " & totalmin
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle



    End Sub


    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click

       

        PrintPreviewDialog1.Document = PrintAllPrintDocument

        PrintPreviewDialog1.ShowDialog()


    End Sub

    Private Sub WriteToFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WriteToFileToolStripMenuItem.Click

        Dim responsedialogresult As DialogResult



        todaydate = dateTextBox.Text
        If todaydate = " " Then
            MessageBox.Show("Please enter a Date ,ddmmyy", "invalid Date Error", MessageBoxButtons.OK)
            dateTextBox.SelectAll()
            dateTextBox.Focus()
            Exit Sub
        ElseIf (IsDate(todaydate) = False) Then
            MessageBox.Show("Date is not Valid ", "Invalid Date Error", MessageBoxButtons.OK)
            dateTextBox.SelectAll()
            dateTextBox.Focus()
            Exit Sub
            outputfile = "dailylog" + Date.Parse(dateTextBox.Text).ToString("ddmmyy") + ".txt"

        End If
        checkbalnkfield()
        If isdirtyboolean Then
            responsedialogresult = MessageBox.Show("Do you want to save the current ", "unsaved data will be lost", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If responsedialogresult = DialogResult.No Then
                MessageBox.Show("The current data will not be written to the file", "write to file", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                saveButton_Click(sender, e)
            End If
        Else
            copyarraytofile()

        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim responsedialogresult As DialogResult
        checkbalnkfield()
        If isdirtyboolean Then
            responsedialogresult = MessageBox.Show("Do you want to exit without saving the current data", "Unsaved data will be lost", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            If responsedialogresult = DialogResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Function DataAlreadyExist(ByVal EmployeeId As String) As Boolean

        For i = 0 To employeecountinteger - 1
            If arrayemployee(i).Id = EmployeeId And arrayemployee(i).EmployeeEntered Then
                DataAlreadyExist = True
                Exit Function
            End If
        Next
        DataAlreadyExist = False

    End Function

    Private Sub ValidateDate()

            todaydate = dateTextBox.Text
            If todaydate = " " Then
                MessageBox.Show("Please enter a Date ,ddmmyy", "invalid Date Error", MessageBoxButtons.OK)
                dateTextBox.SelectAll()
                dateTextBox.Focus()
                Exit Sub
            ElseIf (IsDate(todaydate) = False) Then
                MessageBox.Show("Date is not Valid ", "Invalid Date Error", MessageBoxButtons.OK)
                dateTextBox.SelectAll()
                dateTextBox.Focus()
                Exit Sub
            Else
                outputfile = "dailylog" + Date.Parse(dateTextBox.Text).ToString("ddMMyy") + ".txt"
            dateTextBox.Enabled = False
            End If

    End Sub
   
    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
