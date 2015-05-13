Public Class main

    Private Property outputString As String = ""

    Private Property d2Quantity As Integer = 0
    Private Property d3Quantity As Integer = 0
    Private Property d4Quantity As Integer = 0
    Private Property d6Quantity As Integer = 0
    Private Property d8Quantity As Integer = 0
    Private Property d10Quantity As Integer = 0
    Private Property d12Quantity As Integer = 0
    Private Property d20Quantity As Integer = 0
    Private Property d100Quantity As Integer = 0

    Private Property d2Modifier As Integer = 0
    Private Property d3Modifier As Integer = 0
    Private Property d4Modifier As Integer = 0
    Private Property d6Modifier As Integer = 0
    Private Property d8Modifier As Integer = 0
    Private Property d10Modifier As Integer = 0
    Private Property d12Modifier As Integer = 0
    Private Property d20Modifier As Integer = 0
    Private Property d100Modifier As Integer = 0

    Private Property d2Sum As Integer = 0
    Private Property d3Sum As Integer = 0
    Private Property d4Sum As Integer = 0
    Private Property d6Sum As Integer = 0
    Private Property d8Sum As Integer = 0
    Private Property d10Sum As Integer = 0
    Private Property d12Sum As Integer = 0
    Private Property d20Sum As Integer = 0
    Private Property d100Sum As Integer = 0

    Private Sub rollButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rollButton.Click
        Try
            If d2QuantityBox.Text <> Nothing Then
                If d2ModBox.Text <> Nothing Then
                    d2Modifier = d2ModBox.Text
                End If
                d2Sum = rollDice(2, Convert.ToInt16(d2QuantityBox.Text)) + d2Modifier
                outputString = outputString + "(" + d2QuantityBox.Text + "d2 + " + d2Modifier.ToString + " = " + d2Sum.ToString + ") + "
                d2Quantity = Convert.ToInt32(d2QuantityBox.Text)
            End If
            If d3QuantityBox.Text <> Nothing Then
                If d3ModBox.Text <> Nothing Then
                    d3Modifier = d3ModBox.Text
                End If
                d3Sum = rollDice(3, Convert.ToInt16(d3QuantityBox.Text)) + d3Modifier
                outputString = outputString + "(" + d3QuantityBox.Text + "d3 + " + d3Modifier.ToString + " = " + d3Sum.ToString + ") + "
                d3Quantity = Convert.ToInt32(d3QuantityBox.Text)
            End If
            If d4QuantityBox.Text <> Nothing Then
                If d4ModBox.Text <> Nothing Then
                    d4Modifier = d4ModBox.Text
                End If
                d4Sum = rollDice(4, Convert.ToInt16(d4QuantityBox.Text)) + d4Modifier
                outputString = outputString + "(" + d4QuantityBox.Text + "d4 + " + d4Modifier.ToString + " = " + d4Sum.ToString + ") + "
                d4Quantity = Convert.ToInt32(d4QuantityBox.Text)
            End If
            If d6QuantityBox.Text <> Nothing Then
                If d6ModBox.Text <> Nothing Then
                    d6Modifier = d6ModBox.Text
                End If
                d6Sum = rollDice(6, Convert.ToInt16(d6QuantityBox.Text)) + d6Modifier
                outputString = outputString + "(" + d6QuantityBox.Text + "d6 + " + d6Modifier.ToString + " = " + d6Sum.ToString + ") + "
                d6Quantity = Convert.ToInt32(d6QuantityBox.Text)
            End If
            If d8QuantityBox.Text <> Nothing Then
                If d8ModBox.Text <> Nothing Then
                    d8Modifier = d8ModBox.Text
                End If
                d8Sum = rollDice(8, Convert.ToInt16(d8QuantityBox.Text)) + d8Modifier
                outputString = outputString + "(" + d8QuantityBox.Text + "d8 + " + d8Modifier.ToString + " = " + d8Sum.ToString + ") + "
                d8Quantity = Convert.ToInt32(d8QuantityBox.Text)
            End If
            If d10QuantityBox.Text <> Nothing Then
                If d10ModBox.Text <> Nothing Then
                    d10Modifier = d10ModBox.Text
                End If
                d10Sum = rollDice(10, Convert.ToInt16(d10QuantityBox.Text)) + d10Modifier
                outputString = outputString + "(" + d10QuantityBox.Text + "d10 + " + d10Modifier.ToString + " = " + d10Sum.ToString + ") + "
                d10Quantity = Convert.ToInt32(d10QuantityBox.Text)
            End If
            If d12QuantityBox.Text <> Nothing Then
                If d12ModBox.Text <> Nothing Then
                    d12Modifier = d12ModBox.Text
                End If
                d12Sum = rollDice(12, Convert.ToInt16(d12QuantityBox.Text)) + d12Modifier
                outputString = outputString + "(" + d12QuantityBox.Text + "d12 + " + d12Modifier.ToString + " = " + d12Sum.ToString + ") + "
                d12Quantity = Convert.ToInt32(d12QuantityBox.Text)
            End If
            If d20QuantityBox.Text <> Nothing Then
                If d20ModBox.Text <> Nothing Then
                    d20Modifier = d20ModBox.Text
                End If
                d20Sum = rollDice(20, Convert.ToInt16(d20QuantityBox.Text)) + d20Modifier
                outputString = outputString + "(" + d20QuantityBox.Text + "d20 + " + d20Modifier.ToString + " = " + d20Sum.ToString + ") + "
                d20Quantity = Convert.ToInt32(d20QuantityBox.Text)
            End If
            If d100QuantityBox.Text <> Nothing Then
                If d100ModBox.Text <> Nothing Then
                    d100Modifier = d100ModBox.Text
                End If
                d100Sum = rollDice(100, Convert.ToInt16(d100QuantityBox.Text)) + d100Modifier
                outputString = outputString + "(" + d100QuantityBox.Text + "d100 + " + d100Modifier.ToString + " = " + d100Sum.ToString + ") + "
                d100Quantity = Convert.ToInt32(d100QuantityBox.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + " Please only enter integer values.")
        End Try



        If outputString.Length() > 3 Then
            outputString = outputString.Substring(0, (outputString.Length() - 3)) + " = " + getTotal().ToString + " (Avg. " + getAvg().ToString + ")" + vbNewLine + vbNewLine 'sets output text format
        End If
        outputBox.Text = outputBox.Text.Insert(0, outputString) 'sets output textbox text
        outputString = "" 'resets string
    End Sub

    Private Sub rollStatBlockButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rollStatBlockButton.Click
        outputString = rollStatBlock()
        outputBox.Text = outputBox.Text.Insert(0, outputString) 'sets output textbox text
        outputString = "" 'resets string
    End Sub

    Private Sub percentageButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles percentageButton.Click
        outputString = rollPercentage()
        outputBox.Text = outputBox.Text.Insert(0, outputString) 'sets output textbox text
        outputString = "" 'resets string
    End Sub

    Private Sub clearQuantitiesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearQuantitiesButton.Click
        d2QuantityBox.Text = Nothing
        d3QuantityBox.Text = Nothing
        d4QuantityBox.Text = Nothing
        d6QuantityBox.Text = Nothing
        d8QuantityBox.Text = Nothing
        d10QuantityBox.Text = Nothing
        d12QuantityBox.Text = Nothing
        d20QuantityBox.Text = Nothing
        d100QuantityBox.Text = Nothing
    End Sub

    Private Sub clearResultsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearResultsButton.Click
        outputBox.Text = Nothing
    End Sub

    Private Sub escButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles escButton.Click
        Dim resetCheck As DialogResult = MessageBox.Show("Would you like to exit?",
                                         "Exit?", MessageBoxButtons.YesNo)
        If resetCheck = DialogResult.Yes Then
            Me.Close()
            End
        End If
    End Sub

    Private Function rollStat() As Integer
        Dim roll(3) As Integer
        Dim lowestRoll As Integer = 6
        Dim lowestRollIndex As Integer = 0
        Dim statValue As Integer = 0
        For x = 0 To 3
            roll(x) = 1
            While roll(x) = 1
                roll(x) = rollDice(6, 1)
            End While
            If roll(x) < lowestRoll Then
                lowestRollIndex = x
            End If
        Next
        For x = 0 To 3
            If x <> lowestRollIndex Then
                statValue += roll(x)
            End If
        Next
        Return statValue
    End Function

    Private Function rollStatBlock() As String
        'roll 4d6 6 times. if modifiers added up are lower than +4, reroll.
        Dim points(5) As Integer
        Dim total As Integer = 0
        While total < 75
            total = 0
            For x As Integer = 0 To 5
                points(x) = rollStat()
            Next
            total = points(0) + points(1) + points(2) + points(3) + points(4) + points(5)
        End While
        Array.Sort(points)
        Array.Reverse(points)

        Return points(0).ToString + ", " + points(1).ToString + ", " + points(2).ToString + ", " + points(3).ToString + ", " + points(4).ToString + ", " + points(5).ToString + vbNewLine + vbNewLine
    End Function

    Public Function rollDice(ByVal size As Integer, ByVal quantity As Integer)
        Dim sum As Integer = 0
        For x As Integer = 1 To quantity
            sum = sum + getRandom(1, size + 1)
        Next
        Return sum
    End Function

    Public Function rollPercentage() As String
        Dim tensColumn As Integer = rollDice(10, 1)
        Dim onesColumn As Integer = rollDice(10, 1)
        If onesColumn = 10 And tensColumn = 10 Then
            Return "100" + "%" + vbNewLine + vbNewLine
        ElseIf tensColumn = 10 Then
            Return "0" + onesColumn.ToString + "%" + vbNewLine + vbNewLine
        ElseIf onesColumn = 10 Then
            Return tensColumn.ToString + "0" + "%" + vbNewLine + vbNewLine
        Else
            Return tensColumn.ToString + onesColumn.ToString + "%" + vbNewLine + vbNewLine
        End If
    End Function

    Public Function getRandom(ByVal min As Integer, ByVal max As Integer) As Integer
        Static generator As System.Random = New System.Random()
        Return generator.Next(min, max)
    End Function

    Public Function getTotal() As Integer
        Return d2Sum + d3Sum + d4Sum + d6Sum + d8Sum + d10Sum + d12Sum + d20Sum + d100Sum
    End Function

    Public Function getAvg() As Integer
        Dim avg As Integer = 0
        avg = 1.5 * d2Quantity +
            2 * d3Quantity +
            2.5 * d4Quantity +
            3.5 * d6Quantity +
            4.5 * d8Quantity +
            5.5 * d10Quantity +
            6.5 * d12Quantity +
            10.5 * d20Quantity +
            50.5 * d100Quantity +
            d2Modifier + d3Modifier + d4Modifier + d6Modifier + d8Modifier + d10Modifier + d12Modifier + d20Modifier + d100Modifier
        Return avg
    End Function

End Class