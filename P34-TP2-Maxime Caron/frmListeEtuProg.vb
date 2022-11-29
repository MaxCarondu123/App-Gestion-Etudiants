'================================================================================
'Author:		Maxime Caron
'Create date:   29 Juin 2022
'Description:	Page du code du formulaire de liste des etudiants par programme
'================================================================================

Public Class frmListeEtuProg
    ''' <summary>
    ''' Cette procedure permet de remplir crystal report view
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmListeEtuProg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim rapEtuProg As New RapEtuProg

            daEtuProg.Fill(DsRapportEtuProg1.T_etudiants)
            rapEtuProg.SetDataSource(DsRapportEtuProg1)
            crvEtuProg.ReportSource = rapEtuProg
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet mettre faux quand le formualire se ferme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmListeEtuProg_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        listEtuProgBool = False
    End Sub
End Class