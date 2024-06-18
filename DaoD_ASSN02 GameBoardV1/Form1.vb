'***********************************************************************
'	PROGRAMME NAME	    :	ASSN02 GameBoard
'
'	PROGRAMME OUTLINE	:	This programme allows the user to roll 2 dices 100 time and move to a space that is counted 
'                           everytime it Is landed. If space 13 Is landed On Or consecutive doubles are rolled, it will Return To space 5.
'
'	PROGRAMMER		    :	Derek Dao
'
'	DATE				:	Nov 8, 2019
'***********************************************************************
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picTitle.Image = My.Resources.Standing1
    End Sub
    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
