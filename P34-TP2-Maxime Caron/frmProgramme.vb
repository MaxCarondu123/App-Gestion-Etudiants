'================================================================================
'Author:		Maxime Caron
'Create date:   29 Juin 2022
'Description:	Page du code du formualire des programmes
'================================================================================

Public Class frmProgramme
    Dim Ligne_Select As Integer
    Dim NoProg As String

    ''' <summary>
    ''' Cette procedure permet remplir le formulaire des donnees
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmProgramme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Remplir_DatagridProg()

            If Ds1.T_programme.Rows.Count > 0 Then
                Ligne_Select = 0
                Remplir_DatagridEtu()
                Barrer(grpProgramme, btnOk, btnAnnuler)
                DeBarrer(btnNouveau, btnModifier, btnEnlever, dgProgramme, dgEtudiant)
            Else
                Ligne_Select = -1
                Barrer(grpProgramme, btnOk, btnAnnuler, btnModifier, btnEnlever, dgProgramme, dgEtudiant)
                DeBarrer(btnNouveau)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet remplir le Data grid Programme
    ''' </summary>
    Private Sub Remplir_DatagridProg()
        DaProgramme.Fill(Ds1.T_programme)
    End Sub

    ''' <summary>
    ''' Cette procedure permet remplir le Data grid Etudiant
    ''' </summary>
    Private Sub Remplir_DatagridEtu()
        convert_NoProg()
        DsProgEtu1.T_etudiants.Clear()
        DaProgEtu.SelectCommand.Parameters(0).Value = NoProg
        DaProgEtu.Fill(DsProgEtu1.T_etudiants)
    End Sub

    ''' <summary>
    ''' Cette procedure permet savoir quand on click sur le data grid programme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgProgramme_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProgramme.CellContentClick
        Try
            Remplir_DatagridEtu()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet de connaitre ligne selectionner dans le data grid programme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgProgramme_SelectionChanged(sender As Object, e As EventArgs) Handles dgProgramme.SelectionChanged
        Try
            If dgProgramme.SelectedRows.Count > 0 Then
                Ligne_Select = dgProgramme.CurrentRow.Index
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet l'action d'ajouter
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        Try
            actionChoisi = "Ajout"
            Barrer(btnNouveau, btnModifier, btnEnlever, dgProgramme, dgEtudiant)
            DeBarrer(grpProgramme, btnOk, btnAnnuler)

            Vider_EcranProg(grpProgramme)

            numNbrUnites.Value = 0
            numNbrHeures.Value = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet de choisir l'action d'ajouter ou de modifier
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Try
            If actionChoisi = "Ajout" Then
                Ajout_Prog()
            Else
                Modif_Prog()
            End If

            Barrer(grpProgramme, btnOk, btnAnnuler)
            DeBarrer(dgProgramme, dgEtudiant, btnNouveau, btnModifier, btnEnlever)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet d'ajouter nouveau programme
    ''' </summary>
    Private Sub Ajout_Prog()
        Dim ligne As Ds.T_programmeRow
        ligne = Ds1.T_programme.NewT_programmeRow
        convert_NoProg()
        MsgBox(NoProg)
        ligne.pro_no = NoProg.Trim
        ligne.pro_nom = txtNom.Text.Trim
        ligne.pro_nbr_unites = numNbrUnites.Value
        ligne.pro_nbr_heures = numNbrHeures.Value

        Ds1.T_programme.Rows.Add(ligne)
        DaProgramme.Update(Ds1.T_programme)
        MsgBox("Le programme a ete ajouter avec succes")
    End Sub

    ''' <summary>
    ''' Cette procedure permet de modifier un programme
    ''' </summary>
    Private Sub Modif_Prog()
        Dim ligne As Ds.T_programmeRow
        ligne = Ds1.T_programme.Rows(Ligne_Select)
        convert_NoProg()
        ligne.pro_no = NoProg.Trim
        ligne.pro_nom = txtNom.Text.Trim
        ligne.pro_nbr_unites = numNbrUnites.Value
        ligne.pro_nbr_heures = numNbrHeures.Value

        DaProgramme.Update(Ds1.T_programme)
        MsgBox("Le programme a ete modifier avec succes")
    End Sub

    ''' <summary>
    ''' Cette procedure permet d'annuler l'action choisi
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Try
            dgProgramme.Focus()
            Barrer(grpProgramme, btnOk, btnAnnuler)
            DeBarrer(dgProgramme, dgEtudiant, btnNouveau, btnModifier, btnEnlever)

            mskNo.Text = dgProgramme.Item(0, Ligne_Select).Value
            txtNom.Text = dgProgramme.Item(1, Ligne_Select).Value
            numNbrUnites.Value = dgProgramme.Item(2, Ligne_Select).Value
            numNbrHeures.Value = dgProgramme.Item(3, Ligne_Select).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet de choisir l'action de modifier
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        Try
            actionChoisi = "Modif"
            Barrer(dgProgramme, dgEtudiant, btnNouveau, btnModifier, btnEnlever)
            DeBarrer(grpProgramme, btnOk, btnAnnuler)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet de choisir l'action d'enlever
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnlever_Click(sender As Object, e As EventArgs) Handles btnEnlever.Click
        Try
            If MessageBox.Show("Voulez-vous vraiment supprimer ce programme ?", "Suppression",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Ds1.T_programme.Rows(Ligne_Select).Delete()
                DaProgramme.Update(Ds1.T_programme)
                MsgBox("Programme supprimer avec succes")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub convert_NoProg()
        Dim TextAvant As String = Microsoft.VisualBasic.Left(mskNo.Text, 3)
        Dim textApres As String = Microsoft.VisualBasic.Right(mskNo.Text, 2)
        NoProg = $"{TextAvant}.{textApres}"
    End Sub

    ''' <summary>
    ''' Cette procedure permet mettre faux quand le formualire se ferme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmProgramme_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            progBool = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet de valider le texte entrer par l'utilisateur
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom.KeyPress
        Valider_Text(e)
    End Sub
End Class