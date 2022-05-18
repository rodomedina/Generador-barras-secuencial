Imports System.IO

Public Class frmGeneradorBarras

    Dim num As Integer

    Private Function getBitmap(ByVal pCtrl As Control) As Drawing.Bitmap

        Dim myBmp As New Bitmap(pCtrl.Width, pCtrl.Height)
        Dim g As Graphics = Graphics.FromImage(myBmp)

        Dim p As New Point(pCtrl.Parent.Width - pCtrl.Parent.ClientRectangle.Width, pCtrl.Parent.Height - pCtrl.Parent.ClientRectangle.Height)
        g.CopyFromScreen(pCtrl.Parent.Location + pCtrl.Location + p, Point.Empty, myBmp.Size)

        Return myBmp
        g.Dispose()

    End Function

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click

        Me.Close()

    End Sub

    Private Sub frmGeneradorBarras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Muestra.Visible = False
        NombreArchivo.Visible = False
        Muestra.Width = CodigoBarra.Width
        Muestra.Height = CodigoBarra.Height
        txtinicio.Focus()

    End Sub

    Function SoloNumeros(ByVal Keyascii As Short) As Short

        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select

    End Function

    Public Sub verificarFolder(rutaDirectorio)

        If Not Directory.Exists(rutaDirectorio) Then
            Directory.CreateDirectory(rutaDirectorio)
        End If

    End Sub

    Private Sub BtnGenerar_Click(sender As System.Object, e As System.EventArgs) Handles BtnGenerar.Click
        ep.Clear()

        If txtinicio.Text = "" Then
            ep.SetError(txtinicio, "Debe ingresar un Limite inicial para la secuencia de barras.")
            Return
        End If

        If txtfinal.Text = "" Then
            ep.SetError(txtfinal, "Debe ingresar un Limite final para la secuencia de barras.")
            Return
        End If

        If Val(txtinicio.Text) > Val(txtfinal.Text) Then
            ep.SetError(txtinicio, "El limite inicial debe ser menor o igual al final.")
            Return
        End If


        If Val(txtinicio.Text) > Val(txtfinal.Text) Then


        End If
        '--- Variables
        Dim a As Integer
        NombreArchivo.Text = 0

        '--- Verifico Directorio y creo si es necesario
        If Not Directory.Exists("c:/barras generadas") Then
            Directory.CreateDirectory("c:/barras generadas")
        End If

        '--- Efectos Comienzo
        Cursor = Cursors.WaitCursor
        BtnGenerar.Enabled = False
        txtinicio.Text = Val(txtinicio.Text) - 1
        '--- Itero la cantidad de veces del limite
        For a = Val(txtinicio.Text) To Val(txtfinal.Text) - 1

            If txtinicio.Text > txtfinal.Text Then

            Else
                '---- Variables
                NombreArchivo.Text = Val(NombreArchivo.Text) + 1
                txtinicio.Text = Val(txtinicio.Text) + 1
                num = 12 - txtinicio.TextLength
            End If

            '--- Imagen del control


            '---- Generacion Barra
            Dim iSum As Integer = 0
            Dim iDigit As Integer = 0


            '--- Completo los 0 que faltan al numero

            If txtinicio.TextLength = 12 Then
                CodigoBarra.Value = txtinicio.Text
            Else

                For i As Integer = 1 To num
                    txtinicio.Text = "0" + txtinicio.Text
                Next

                If txtinicio.TextLength = 12 Then
                    CodigoBarra.Value = txtinicio.Text
                End If
            End If

            Dim CapturaBarra As Bitmap = getBitmap(CodigoBarra)

            '--- Completo los 0 que faltan al nombre del archivo
            If NombreArchivo.TextLength = 12 Then
                CodigoBarra.Value = txtinicio.Text
            Else

                For i As Integer = 1 To num
                    NombreArchivo.Text = "0" + NombreArchivo.Text
                Next

            End If

            '--- Muestro Numero Completo con Cheksum
            CodigoBarra.ShowBarcodeText = True
            CodigoBarra.ShowCheckSum = True

            '--- Muestra y Save de la Barra
            CapturaBarra.Save("C:\Barras Generadas\" + NombreArchivo.Text + ".png")
            Muestra.Image = CapturaBarra

        Next a

        '--- Limpio Textboxs
        txtinicio.Clear()
        txtfinal.Clear()

        '--- Efectos despues del proceso
        BtnGenerar.Enabled = True
        Cursor = Cursors.Default
        Process.Start("explorer.exe", "c:\Barras Generadas")

    End Sub

    Private Sub AcercadeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AcercadeToolStripMenuItem.Click

        frmAyuda.Show()

    End Sub

    Private Sub txtinicio_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtinicio.KeyPress

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtfinal_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtfinal.KeyPress

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

End Class
