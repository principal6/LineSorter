Imports System.ComponentModel

Public Class MainFrm
    Private Const OFFSET_BORDER As Int16 = 10
    Private Const MIN_WINDOW_W As Int16 = 500
    Private Const MIN_WINDOW_H As Int16 = 300

    Private Sub CountCharacters()
        LBTextLen.Text = "글자 수: " & RTBSearch.TextLength & " 자"
    End Sub

    Private Sub MainFrm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub BTNSort_Click(sender As Object, e As EventArgs) Handles BTNSort.Click
        Dim NewS As String
        NewS = RTBSearch.Text

        '### RTB일 땐 vbLf ★ ###
        NewS = NewS.Replace(vbLf & vbLf, "▤▤")
        NewS = NewS.Replace(vbLf, " ")
        NewS = NewS.Replace("▤▤", vbLf)
        NewS = NewS.Replace("    ", " ")
        NewS = NewS.Replace("   ", " ")
        NewS = NewS.Replace("  ", " ")

        RTBSearch.Text = NewS
    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MinimumSize = New Size(MIN_WINDOW_W, MIN_WINDOW_H)
        CountCharacters()
    End Sub

    Private Sub RTBSearch_TextChanged(sender As Object, e As EventArgs) Handles RTBSearch.TextChanged
        CountCharacters()
    End Sub

    Private Sub BTNBroken_Click(sender As Object, e As EventArgs) Handles BTNBroken.Click
        Dim NewS As String
        NewS = RTBSearch.Text

        NewS = Net.WebUtility.HtmlDecode(NewS)

        RTBSearch.Text = NewS
    End Sub

    Private Sub MainFrm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        BTNSort.Left = OFFSET_BORDER

        BTNBroken.Left = Me.Size.Width - BTNBroken.Width - OFFSET_BORDER * 2.5
        RTBSearch.Left = OFFSET_BORDER
        RTBSearch.Width = Me.Size.Width - RTBSearch.Left - OFFSET_BORDER * 2.5
        RTBSearch.Height = Me.Size.Height - RTBSearch.Top - OFFSET_BORDER * 4.5
    End Sub
End Class
