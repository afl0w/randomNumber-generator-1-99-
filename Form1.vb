Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Local Variables

        Dim intRandNum As Double
        Dim intMax As Integer
        Dim intMin As Integer
        Dim intAvg As Double
        Dim intCount As Integer
        Dim intTotal As Integer

        Dim objRandObject As New Random
        Const Upper_SUB As Integer = 20
        Dim intnumber(Upper_SUB) As Integer


        'Max, Min, Total , Average calcualtion 


        For intCount = 0 To Upper_SUB
            intRandNum = objRandObject.Next(100)
            intnumber(intCount) = intRandNum
            intTotal += intRandNum
            lstNumbers.Items.Add(intCount + 1 & "." & vbTab & intRandNum)
        Next

        intMax = intnumber.Max
        intMin = intnumber.Min
        intAvg = intTotal / intnumber.Length

        TextBoxMax.Text = intMax
        TextBoxMin.Text = intMin
        TextBoxTotal.Text = intTotal
        TextBoxAvg.Text = intAvg






    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Clears all TextBoxes and ListBox 


        TextBoxMax.Text = ""
        TextBoxMin.Text = ""
        TextBoxTotal.Text = ""
        TextBoxAvg.Text = ""
        lstNumbers.Items.Clear()
    End Sub
End Class
