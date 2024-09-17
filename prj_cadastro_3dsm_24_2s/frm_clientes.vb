﻿Public Class frm_clientes
    Private Sub Img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO" 'Título da janela
                .InitialDirectory = Application.StartupPath & "\fotos\"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub Frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
    End Sub
End Class