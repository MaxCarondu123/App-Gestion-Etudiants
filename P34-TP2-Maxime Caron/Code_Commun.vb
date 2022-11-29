'================================================================================
'Author:		Maxime Caron
'Create date:   29 Juin 2022
'Description:	Page du code commun pour tous les pages
'================================================================================

Module Code_Commun
    Public actionChoisi As String
    Public progBool As Boolean
    Public etuBool As Boolean
    Public listProgBool As Boolean
    Public listEtuBool As Boolean
    Public listEtuProgBool As Boolean

    ''' <summary>
    ''' Cette procedure permet de barrer certains controles sur la page
    ''' </summary>
    ''' <param name="ctrl"></param>
    Public Sub Barrer(ParamArray ctrl() As Control)
        For Each c As Control In ctrl
            c.Enabled = False
        Next
    End Sub

    ''' <summary>
    ''' Cette procedure permet de debarrer certains controles sur la page
    ''' </summary>
    ''' <param name="ctrl"></param>
    Public Sub DeBarrer(ParamArray ctrl() As Control)
        For Each c As Control In ctrl
            c.Enabled = True
        Next
    End Sub

    ''' <summary>
    ''' Cette procedure permet de vider les champs du formulaire programme
    ''' </summary>
    ''' <param name="grpProgramme"></param>
    Public Sub Vider_EcranProg(grpProgramme As Control)
        For Each c As Control In grpProgramme.Controls
            If TypeOf (c) Is TextBox Or TypeOf (c) Is MaskedTextBox Then
                c.Text = ""
            End If
        Next
    End Sub

    ''' <summary>
    ''' Cette procedure permet de vider les champs du formulaire etudiant
    ''' </summary>
    ''' <param name="grpEtudiant"></param>
    Public Sub Vider_EcranEtud(grpEtudiant As Control)
        For Each c As Control In grpEtudiant.Controls
            If TypeOf (c) Is TextBox Or TypeOf (c) Is MaskedTextBox Then
                c.Text = ""
            End If
        Next
    End Sub

    ''' <summary>
    ''' Cette procedure permet de valider le text
    ''' </summary>
    ''' <param name="e"></param>
    Public Sub Valider_Text(e)
        If Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.keychar) Or e.keychar = Chr(8) Or e.keychar = "'" _
           Or e.keychar = "-" Or e.keychar = "é" Or e.keychar = "è" Or e.keychar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Module
