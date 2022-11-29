'================================================================================
'Author:		Maxime Caron
'Create date:   29 Juin 2022
'Description:	Page du code du formulaire des etudiants
'================================================================================

Public Class frmEtudiants
    Dim Ligne_Select As Integer

    ''' <summary>
    ''' Cette procedure permet remplir le formulaire des donnees
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Etudiants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DaEtudiant.Fill(DsEtudiant1.T_etudiants)

            If DsEtudiant1.T_etudiants.Rows.Count > 0 Then
                Ligne_Select = 0
                Barrer(grpEtudiant, btnOk, btnAnnuler)
                DeBarrer(btnNouveau, btnModifier, btnEnlever, dgEtudiants)
            Else
                Ligne_Select = -1
                Barrer(grpEtudiant, btnOk, btnAnnuler, btnModifier, btnEnlever, dgEtudiants)
                DeBarrer(btnNouveau)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet de choisir l'action de d'ajouter
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        Try
            actionChoisi = "Ajout"
            Barrer(btnNouveau, btnModifier, btnEnlever, dgEtudiants)
            DeBarrer(grpEtudiant, btnOk, btnAnnuler)

            Vider_EcranEtud(grpEtudiant)
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
                Ajout_Etu()
            Else
                Modif_Etu()
            End If

            Barrer(grpEtudiant, btnOk, btnAnnuler)
            DeBarrer(dgEtudiants, btnNouveau, btnModifier, btnEnlever)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet d'ajouter un nouveau etudiant
    ''' </summary>
    Private Sub Ajout_Etu()
        Dim ligne As DsEtudiant.T_etudiantsRow
        ligne = DsEtudiant1.T_etudiants.NewT_etudiantsRow

        DsEtudiant1.T_etudiants.Rows.Add(ligne)
        DaEtudiant.Update(DsEtudiant1.T_etudiants)
        MsgBox("Le programme a ete ajouter avec succes")
    End Sub

    ''' <summary>
    ''' Cette procedure permet de de modifier un etudiant
    ''' </summary>
    Private Sub Modif_Etu()
        Dim ligne As DsEtudiant.T_etudiantsRow
        ligne = DsEtudiant1.T_etudiants.Rows(Ligne_Select)

        DaEtudiant.Update(DsEtudiant1.T_etudiants)
        MsgBox("Le programme a ete modifier avec succes")
    End Sub

    ''' <summary>
    ''' Cette procedure permet de choisir l'action d'annuler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Try
            dgEtudiants.Focus()
            Barrer(grpEtudiant, btnOk, btnAnnuler)
            DeBarrer(dgEtudiants, btnNouveau, btnModifier, btnEnlever)
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
            Barrer(dgEtudiants, btnNouveau, btnModifier, btnEnlever)
            DeBarrer(grpEtudiant, btnOk, btnAnnuler)
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
                MsgBox(Ligne_Select)
                DsEtudiant1.T_etudiants.Rows(Ligne_Select).Delete()
                DaEtudiant.Update(DsEtudiant1.T_etudiants)
                MsgBox("Programme supprimer avec succes")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet de connaitre la ligne selectionner dans le data grid etudiant
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgEtudiants_SelectionChanged(sender As Object, e As EventArgs) Handles dgEtudiants.SelectionChanged
        Try
            If dgEtudiants.SelectedRows.Count > 0 Then
                Ligne_Select = dgEtudiants.CurrentRow.Index

                Dim sexe As Char = dgEtudiants.Item(4, dgEtudiants.CurrentRow.Index).Value

                If sexe = "F" Then
                    optFeminin.Checked = True
                Else
                    optMasculin.Checked = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet mettre faux quand le formualire se ferme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmEtudiants_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            etuBool = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet de valider le texte entrer par l'utilisateur
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtPrenom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVille.KeyPress, txtPrenom.KeyPress, txtNom.KeyPress, txtAdresse.KeyPress, cboProvince.KeyPress
        Valider_Text(e)
    End Sub
End Class