Imports System.Net
Imports System.Text.RegularExpressions
Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer
    Private Declare Function FindWindow Lib "user32.dll" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Private Declare Function PostMessage Lib "user32.dll" Alias "PostMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Private Const WM_CLOSE As Integer = CInt(&H10)
    Function GetModuleHandle(ByVal processx As String, ByVal modulex As String) As IntPtr
        Dim prs As Process() = Process.GetProcessesByName(processx)
        If prs.Length > 0 Then
            On Error Resume Next
            Dim pi As ProcessModuleCollection = prs(0).Modules
            For Each pmod As ProcessModule In pi
                If pmod.ModuleName = (modulex) Then
                    Return pmod.BaseAddress
                Else
                End If
            Next
        End If

    End Function
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        PictureBox3.Visible = True
        PictureBox2.Visible = False
        TrackBar1.Enabled = True
        kosmahızı.Start()
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        PictureBox3.Visible = False
        PictureBox2.Visible = True
        TrackBar1.Enabled = False
        TrackBar1.Value = 0
        kosmahızı.Stop()

        WritePointerInteger(TextBox1.Text, &H6F5C40, 1067869798, &HDC, &H5AC) ' Romy2.bin hizli kosma iptal

    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        PictureBox4.Visible = False
        PictureBox5.Visible = True
        TrackBar2.Enabled = False
        TrackBar2.Value = 0
        saldırıhızı.Stop()
        WriteDMAInteger(TextBox1.Text, GetModuleHandle(TextBox1.Text, TextBox1.Text) + &H2F91E4, {&H8, &H760}, 1067869798, 2, 4) '' Tomris2 Saldırı Hızı
        WritePointerInteger("metin2client.bin", &H6F5C40, 16256, &HD4, &H5B2) ' Rumy2 Saldırı Hızı

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        PictureBox4.Visible = True
        PictureBox5.Visible = False
        TrackBar2.Enabled = True
        saldırıhızı.Start()
    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PictureBox7.Visible = False
        PictureBox6.Visible = True
        TrackBar3.Enabled = True
        rangeattack.Start()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        PictureBox6.Visible = False
        PictureBox7.Visible = True
        TrackBar3.Enabled = False
        TrackBar3.Value = 0
        rangeattack.Stop()
        WriteDMAInteger(TextBox1.Text, GetModuleHandle(TextBox1.Text, TextBox1.Text) + &H2F9198, {&H28C, &H758}, 1067869798, 2, 4) ''Tomris2 Silah UZUNLUĞU
        WritePointerInteger(TextBox1.Text, &H6A35F0, 1067869798, &H0, &H5A8) '' Romy2.bin silah uzunluğu
    End Sub
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        PictureBox8.Visible = False
        PictureBox9.Visible = True
        TrackBar4.Enabled = False
        TrackBar4.Value = 0
        onehit.Stop()
    End Sub
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        PictureBox9.Visible = False
        PictureBox8.Visible = True
        TrackBar4.Enabled = True
        onehit.Start()
    End Sub

    Private Sub Onehit_Tick(sender As Object, e As EventArgs) Handles onehit.Tick
        Try
            WriteDMAInteger(TextBox1.Text, GetModuleHandle(TextBox1.Text, TextBox1.Text) + &H2F91E4, {&H10, &H6BC}, TrackBar4.Value, 2, 4) '' Tomris2 hit
            WritePointerInteger(TextBox1.Text, &H6A35F0, TrackBar4.Value, &H0, &H50C) '' romy2.bin hit


        Catch ex As Exception

        End Try
    End Sub







    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        PictureBox19.Visible = False
        PictureBox20.Visible = True
        Try
            WriteDMAInteger(TextBox1.Text, GetModuleHandle(TextBox1.Text, TextBox1.Text) + &H2B88E0, {&H80, &H90}, 65537, 2, 4) '' tomris2.bin oto vuruş
            WritePointerInteger(TextBox1.Text, &H6F5C0C, 65537, &H60) '' romy2.bin oto vuruş


        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        PictureBox20.Visible = False
        PictureBox19.Visible = True
        Try
            WriteDMAInteger(TextBox1.Text, GetModuleHandle(TextBox1.Text, TextBox1.Text) + &H2B88E0, {&H80, &H90}, 65536, 2, 4) '' tomris2.bin oto vuruş
            WritePointerInteger(TextBox1.Text, &H6F5C0C, 65536, &H60) '' Romy2.bin oto vuruş

        Catch ex As Exception

        End Try
    End Sub
    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        PictureBox21.Visible = False
        PictureBox22.Visible = True
        Me.TopMost = True
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        PictureBox22.Visible = False
        PictureBox21.Visible = True
        Me.TopMost = False
    End Sub


    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        PictureBox25.Visible = True
        PictureBox26.Visible = False
        wallhack.Start()
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        PictureBox25.Visible = False
        PictureBox26.Visible = True
        wallhack.Stop()

        WritePointerInteger(TextBox1.Text, &H6F5BF0, 0, &HC, &H670) ' Romy2.bin Wall Hack

    End Sub

    Private Sub Wallhack_Tick(sender As Object, e As EventArgs) Handles wallhack.Tick
        Try

            WritePointerInteger(TextBox1.Text, &H6F5BF0, 1, &HC, &H670) ' Romy2.bin Wall Hack

        Catch ex As Exception

        End Try

    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        PictureBox28.Visible = False
        PictureBox27.Visible = True

        WriteDMAInteger(TextBox1.Text, GetModuleHandle(TextBox1.Text, TextBox1.Text) + &H23EE0C, {&H48}, 1199479296, 1, 4) '' Romy2.bin ZOOM ETKİN
        WritePointerInteger(TextBox1.Text, &H64AE28, 1199479296, &H7F0) '' Mester2Magic ZOOM ETKİN


    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        PictureBox28.Visible = True
        PictureBox27.Visible = False

        WriteDMAInteger(TextBox1.Text, GetModuleHandle(TextBox1.Text, TextBox1.Text) + &H23EE0C, {&H48}, 1159479296, 1, 4) '' Romy2.bin ZOOM KAPALI
        WritePointerInteger(TextBox1.Text, &H64AE28, 1159479296, &H7F0) '' Mester2Magic ZOOM KAPALI


    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        If TextBox1.Text = "metin2client.bin" Then
            MsgBox("Romy2 PvP Serverinde bu özellik çalışmamaktadır.", MsgBoxStyle.Critical, "")

        End If
        PictureBox29.Visible = True
        PictureBox30.Visible = False
        Try
            WritePointerInteger(TextBox1.Text, &H6B845C, 1085353217, &H268, &H4B8) 'tomris ghost

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click


        PictureBox30.Visible = True
        PictureBox29.Visible = False
        Try
            WritePointerInteger(TextBox1.Text, &H6B845C, 1065353216, &H268, &H4B8) 'tomris ghost

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Saldırıhızı_Tick(sender As Object, e As EventArgs) Handles saldırıhızı.Tick
        Try

            WritePointerInteger(TextBox1.Text, &H6F5C40, PictureBox3.Text, &HD4, &H5B2)  '' romy2 Saldırı Hızı

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Kosmahızı_Tick(sender As Object, e As EventArgs) Handles kosmahızı.Tick
        Try

            WritePointerInteger(TextBox1.Text, &H6F5C40, TrackBar1.Text, &HDC, &H5AC) ' Romy2.bin hizli kosma

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TrackBar1_Click(sender As Object, e As EventArgs) Handles TrackBar1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
