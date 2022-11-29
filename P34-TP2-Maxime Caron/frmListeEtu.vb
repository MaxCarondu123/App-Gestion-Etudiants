'================================================================================
'Author:		Maxime Caron
'Create date:   29 Juin 2022
'Description:	Page du code du formulaire de la liste des etudiants
'================================================================================

Public Class frmListeEtu
    ''' <summary>
    ''' Cette procedure permet de remplir crystal report view
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmListeEtu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim rapEtu As New RapEtu

            daEtudiant.Fill(DsRapportEtu1.T_etudiants)
            rapEtu.SetDataSource(DsRapportEtu1)
            crvEtudiant.ReportSource = rapEtu
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet mettre faux quand le formualire se ferme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmListeEtu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        listEtuBool = False
    End Sub
End Class