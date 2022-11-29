'================================================================================
'Author:		Maxime Caron
'Create date:   29 Juin 2022
'Description:	Page du code du formulaire principal (Accueil)
'================================================================================

Public Class frmPrincipal
    ''' <summary>
    ''' Cette procedure permet d'ouvrir le formulaire programme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuProgramme_Click(sender As Object, e As EventArgs) Handles mnuProgramme.Click
        Dim programme As New frmProgramme()
        programme.MdiParent = Me

        If progBool = False Then
            programme.Show()
            progBool = True
        Else
            MsgBox("Formulaire des programmes deja ouvert")
        End If
    End Sub

    ''' <summary>
    ''' Cette procedure permet d'ouvrir le formulaire etudiant
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEtudiants_Click(sender As Object, e As EventArgs) Handles mnuEtudiants.Click
        Dim etudiants As New frmEtudiants()
        etudiants.MdiParent = Me

        If etuBool = False Then
            etudiants.Show()
            etuBool = True
        Else
            MsgBox("Formulaire des etudiants deja ouvert")
        End If
    End Sub

    ''' <summary>
    ''' Cette procedure permet d'ouvrir le formulaire list programme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuListeProg_Click(sender As Object, e As EventArgs) Handles mnuListeProg.Click
        Dim listeProg As New frmListeProg()
        listeProg.MdiParent = Me

        If listProgBool = False Then
            listeProg.Show()
            listProgBool = True
        Else
            MsgBox("Formulaire de la liste des programmes deja ouvert")
        End If
    End Sub

    ''' <summary>
    ''' Cette procedure permet d'ouvrir le formulaire list etudiant
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuListeEtu_Click(sender As Object, e As EventArgs) Handles mnuListeEtu.Click
        Dim listeEtu As New frmListeEtu()
        listeEtu.MdiParent = Me

        If listEtuBool = False Then
            listeEtu.Show()
            listEtuBool = True
        Else
            MsgBox("Formulaire de la liste des etudiants deja ouvert")
        End If
    End Sub

    ''' <summary>
    ''' Cette procedure permet d'ouvrir le formulaire list etudaiant par programme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuListeEtudProg_Click(sender As Object, e As EventArgs) Handles mnuListeEtudProg.Click
        Dim listeEtuProg As New frmListeEtuProg()
        listeEtuProg.MdiParent = Me

        If listEtuProgBool = False Then
            listeEtuProg.Show()
            listEtuProgBool = True
        Else
            MsgBox("Formulaire de la liste des etudiants par programme deja ouvert")
        End If
    End Sub
End Class
