Public Class Form1
    'Luhn algorithm
    Private Function CardValidator(ByVal value As String) As Boolean
        Dim checksum As Integer = 0 'This will store sum of the digits.
        Dim doubleflag As Boolean = (value.Length Mod 2 = 0) 'Loop will pick every alternate digit starting from the 2nd from left.
        Dim digit As Char 'Digit stored as a character (onr character at the time)
        Dim digitvalue As Integer 'Digitvalue stored in memory as an integer.
        For Each digit In value 'Each alternate digit will be doubled.
            digitvalue = Integer.Parse(digit) 'String converted to an Integer.
            If doubleflag Then 
                digitvalue *= 2
                If digitvalue > 9 Then
                    digitvalue -= 9 'If the doubled result is greater then 9 program will substract 9 from the result.
                End If
            End If
            'Adding all of the digits, doubled and not.
            checksum += digitvalue 'adding the dubled value to the existing value
            doubleflag = Not doubleflag 'toggle the value of variable
        Next
        Return (checksum Mod 10 = 0) 'Verification If final result is divisible by 10 without a reminder.
    End Function
    Private Sub ValBt_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValBt.Click
        'Pop up windows with alert for the wrong length of the Card Number.
        If CardNo.Text.Length <> 16 Then
            MsgBox("Invalid Card Number. Please provide 16 digits")
            'Pop-up windows with alert for the worng length of the CVV Number.
        ElseIf CVV.Text.Length <> 3 Then
            MsgBox("CVV must contain 3 digits")
            'If above conditions are met then program continue to the validation process.
        ElseIf CardValidator(CardNo.Text) Then
            MsgBox("Card is Valid") 'Pop-up window with Valid message if the sum of the digits is divisible by 10 without a reminder.
        Else
            MsgBox("Card is not valid") 'Pop-up window with invalid message If the division of the sum of the digits have reminder.
        End If
       End Sub

    Private Sub CardNo_TextChanged(sender As Object, e As EventArgs) Handles CardNo.TextChanged
        'This function will restrict input to digits only in the Card Number textbox.
        If Not IsNumeric(CardNo.Text) Then
            MsgBox("Please enter digits only.")
        End If
    End Sub

    Private Sub CVV_TextChanged(sender As Object, e As EventArgs) Handles CVV.TextChanged
        'This function will restrict input to digits only in the CVV textbox.
        If Not IsNumeric(CVV.Text) Then
            MsgBox("Please enter digits only.")
        End If
    End Sub
    'This function will not allow to pick up past date. 
    Private Sub ExDate_ValueChanged(sender As Object, e As EventArgs) Handles ExDate.ValueChanged
        ExDate.MinDate = Date.Today
    End Sub
End Class
