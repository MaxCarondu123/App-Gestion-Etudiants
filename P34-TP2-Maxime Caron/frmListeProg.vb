'================================================================================
'Author:		Maxime Caron
'Create date:   29 Juin 2022
'Description:	Page du code du formulaire de la liste des programmes
'================================================================================

Public Class frmListeProg
    ''' <summary>
    ''' Cette procedure permet de remplir crystal report view
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmListeProg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim rapProg As New RapProg

            daProgramme.Fill(DsRapportProg1.T_programme)
            rapProg.SetDataSource(DsRapportProg1)
            crvProg.ReportSource = rapProg
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet mettre faux quand le formualire se ferme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmListeProg_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        listProgBool = False
    End Sub
End Class