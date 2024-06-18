Public Class Form2
    Private rollTotal As Integer
    Private spaceCount(15) As Integer
    Private Sub BtnRoll_Click_1(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim boardSquares() As Button = {btnSpace1, btnSpace2, btnSpace3, btnSpace4, btnSpace5, btnSpace6, btnSpace7, btnSpace8, btnSpace9, btnSpace10, btnSpace11, btnSpace12, btnSpace13, btnSpace14, btnSpace15, btnSpace16}
        Dim rand As New Random
        Dim dices() As PictureBox = {picDice1, picDice2}
        Dim count As Integer
        Dim doubles As Integer
        Dim NUM_ROLLS(1) As Integer

        picPokemon.Image = My.Resources.PikachuIdle
        For gameReset = 0 To boardSquares.Length - 1
            boardSquares(gameReset).Text = ""
            spaceCount(gameReset) = 0
        Next

        Do
            For i = 0 To dices.Length - 1
                NUM_ROLLS(i) = rand.Next(1, 7)
                Call Roll(NUM_ROLLS(i), dices(i))
            Next

            If NUM_ROLLS(0) = NUM_ROLLS(1) Then
                doubles += 1
                If doubles = 2 Then
                    rollTotal = 5
                    Call DisplayCounts(boardSquares(rollTotal - 1))
                    MessageBox.Show("Pikachu is now tried of training! Returning back to Pokemon Centre...", "Got Consecutive Doubles!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    doubles = 0
                End If
            Else
                doubles = 0
            End If

            If rollTotal > 16 Then
                rollTotal -= 16
            ElseIf rollTotal = 13 Then
                Call DisplayCounts(boardSquares(12))
                rollTotal = 5
                MessageBox.Show("Pikachu is going to faint! Returning back to pokeball... Going back to Pokemon Centre...", "Landed On Space 13", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Call DisplayCounts(boardSquares(rollTotal - 1))
            count += 1
        Loop Until count = 100
    End Sub
    Private Sub Roll(NUM_ROLLS As Integer, dices As PictureBox)
        Select Case NUM_ROLLS
            Case 1
                dices.Image = My.Resources.Dice_1_b_svg
                rollTotal += 1
            Case 2
                dices.Image = My.Resources.Dice_2_b_svg
                rollTotal += 2
            Case 3
                dices.Image = My.Resources.Dice_3_b_svg
                rollTotal += 3
            Case 4
                dices.Image = My.Resources.Dice_4_b_svg
                rollTotal += 4
            Case 5
                dices.Image = My.Resources.Dice_5_b_svg
                rollTotal += 5
            Case 6
                dices.Image = My.Resources._1024px_Dice_6a_b_svg
                rollTotal += 6
        End Select
    End Sub
    Private Sub DisplayCounts(boardSquares As Button)
        spaceCount(rollTotal - 1) += 1
        boardSquares.Text = spaceCount(rollTotal - 1)
        boardSquares.BackColor = Color.Yellow
        Threading.Thread.Sleep(200)
        Refresh()
        boardSquares.BackColor = Color.Green
    End Sub
    Private Sub BtnPause_Click_1(sender As Object, e As EventArgs) Handles btnPause.Click
        Application.Exit()
    End Sub
End Class