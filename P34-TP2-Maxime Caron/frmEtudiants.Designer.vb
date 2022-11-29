<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEtudiants
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grpEtudiant = New System.Windows.Forms.GroupBox()
        Me.grpSexe = New System.Windows.Forms.GroupBox()
        Me.optMasculin = New System.Windows.Forms.RadioButton()
        Me.optFeminin = New System.Windows.Forms.RadioButton()
        Me.cboProvince = New System.Windows.Forms.ComboBox()
        Me.Bs_Etudiant = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEtudiant1 = New P34_TP2_Maxime_Caron.DsEtudiant()
        Me.cboNoProg = New System.Windows.Forms.ComboBox()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.mskCodePostal = New System.Windows.Forms.MaskedTextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.mskTel = New System.Windows.Forms.MaskedTextBox()
        Me.lblCodePostal = New System.Windows.Forms.Label()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblNoProg = New System.Windows.Forms.Label()
        Me.mskDa = New System.Windows.Forms.MaskedTextBox()
        Me.lblDa = New System.Windows.Forms.Label()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnEnlever = New System.Windows.Forms.Button()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.dgEtudiants = New System.Windows.Forms.DataGridView()
        Me.EtudaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtunomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuprenomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtusexeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuadresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuvilleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuprovinceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtutelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtucodepostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.CON = New System.Data.SqlClient.SqlConnection()
        Me.DaEtudiant = New System.Data.SqlClient.SqlDataAdapter()
        Me.grpEtudiant.SuspendLayout()
        Me.grpSexe.SuspendLayout()
        CType(Me.Bs_Etudiant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEtudiant1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEtudiants, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpEtudiant
        '
        Me.grpEtudiant.Controls.Add(Me.grpSexe)
        Me.grpEtudiant.Controls.Add(Me.cboProvince)
        Me.grpEtudiant.Controls.Add(Me.cboNoProg)
        Me.grpEtudiant.Controls.Add(Me.txtVille)
        Me.grpEtudiant.Controls.Add(Me.txtAdresse)
        Me.grpEtudiant.Controls.Add(Me.txtNom)
        Me.grpEtudiant.Controls.Add(Me.txtPrenom)
        Me.grpEtudiant.Controls.Add(Me.lblProvince)
        Me.grpEtudiant.Controls.Add(Me.mskCodePostal)
        Me.grpEtudiant.Controls.Add(Me.lblTelephone)
        Me.grpEtudiant.Controls.Add(Me.mskTel)
        Me.grpEtudiant.Controls.Add(Me.lblCodePostal)
        Me.grpEtudiant.Controls.Add(Me.lblVille)
        Me.grpEtudiant.Controls.Add(Me.lblAdresse)
        Me.grpEtudiant.Controls.Add(Me.lblNom)
        Me.grpEtudiant.Controls.Add(Me.lblPrenom)
        Me.grpEtudiant.Controls.Add(Me.lblNoProg)
        Me.grpEtudiant.Controls.Add(Me.mskDa)
        Me.grpEtudiant.Controls.Add(Me.lblDa)
        Me.grpEtudiant.Enabled = False
        Me.grpEtudiant.Location = New System.Drawing.Point(24, 22)
        Me.grpEtudiant.Name = "grpEtudiant"
        Me.grpEtudiant.Size = New System.Drawing.Size(924, 247)
        Me.grpEtudiant.TabIndex = 1
        Me.grpEtudiant.TabStop = False
        Me.grpEtudiant.Text = "Etudiant"
        '
        'grpSexe
        '
        Me.grpSexe.Controls.Add(Me.optMasculin)
        Me.grpSexe.Controls.Add(Me.optFeminin)
        Me.grpSexe.Location = New System.Drawing.Point(16, 179)
        Me.grpSexe.Name = "grpSexe"
        Me.grpSexe.Size = New System.Drawing.Size(208, 54)
        Me.grpSexe.TabIndex = 33
        Me.grpSexe.TabStop = False
        Me.grpSexe.Text = "Sexe"
        '
        'optMasculin
        '
        Me.optMasculin.AutoSize = True
        Me.optMasculin.Location = New System.Drawing.Point(100, 25)
        Me.optMasculin.Name = "optMasculin"
        Me.optMasculin.Size = New System.Drawing.Size(89, 24)
        Me.optMasculin.TabIndex = 1
        Me.optMasculin.TabStop = True
        Me.optMasculin.Text = "Masculin"
        Me.optMasculin.UseVisualStyleBackColor = True
        '
        'optFeminin
        '
        Me.optFeminin.AutoSize = True
        Me.optFeminin.Location = New System.Drawing.Point(6, 25)
        Me.optFeminin.Name = "optFeminin"
        Me.optFeminin.Size = New System.Drawing.Size(83, 24)
        Me.optFeminin.TabIndex = 0
        Me.optFeminin.TabStop = True
        Me.optFeminin.Text = "Feminin"
        Me.optFeminin.UseVisualStyleBackColor = True
        '
        'cboProvince
        '
        Me.cboProvince.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bs_Etudiant, "etu_province", True))
        Me.cboProvince.FormattingEnabled = True
        Me.cboProvince.Location = New System.Drawing.Point(551, 105)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(218, 28)
        Me.cboProvince.TabIndex = 32
        '
        'Bs_Etudiant
        '
        Me.Bs_Etudiant.DataMember = "T_etudiants"
        Me.Bs_Etudiant.DataSource = Me.DsEtudiant1
        '
        'DsEtudiant1
        '
        Me.DsEtudiant1.DataSetName = "DsEtudiant"
        Me.DsEtudiant1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboNoProg
        '
        Me.cboNoProg.DataSource = Me.Bs_Etudiant
        Me.cboNoProg.DisplayMember = "pro_no"
        Me.cboNoProg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNoProg.FormattingEnabled = True
        Me.cboNoProg.Location = New System.Drawing.Point(148, 69)
        Me.cboNoProg.Name = "cboNoProg"
        Me.cboNoProg.Size = New System.Drawing.Size(121, 28)
        Me.cboNoProg.TabIndex = 31
        Me.cboNoProg.ValueMember = "pro_no"
        '
        'txtVille
        '
        Me.txtVille.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bs_Etudiant, "etu_ville", True))
        Me.txtVille.Location = New System.Drawing.Point(551, 68)
        Me.txtVille.MaxLength = 50
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(218, 26)
        Me.txtVille.TabIndex = 30
        '
        'txtAdresse
        '
        Me.txtAdresse.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bs_Etudiant, "etu_adresse", True))
        Me.txtAdresse.Location = New System.Drawing.Point(551, 31)
        Me.txtAdresse.MaxLength = 100
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(334, 26)
        Me.txtAdresse.TabIndex = 29
        '
        'txtNom
        '
        Me.txtNom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bs_Etudiant, "etu_nom", True))
        Me.txtNom.Location = New System.Drawing.Point(148, 143)
        Me.txtNom.MaxLength = 20
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(255, 26)
        Me.txtNom.TabIndex = 28
        '
        'txtPrenom
        '
        Me.txtPrenom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bs_Etudiant, "etu_prenom", True))
        Me.txtPrenom.Location = New System.Drawing.Point(148, 105)
        Me.txtPrenom.MaxLength = 20
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(255, 26)
        Me.txtPrenom.TabIndex = 27
        '
        'lblProvince
        '
        Me.lblProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProvince.Location = New System.Drawing.Point(420, 104)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(125, 26)
        Me.lblProvince.TabIndex = 25
        Me.lblProvince.Text = "Province:"
        Me.lblProvince.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mskCodePostal
        '
        Me.mskCodePostal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bs_Etudiant, "etu_codepostal", True))
        Me.mskCodePostal.Location = New System.Drawing.Point(551, 143)
        Me.mskCodePostal.Mask = "L9L-9L9"
        Me.mskCodePostal.Name = "mskCodePostal"
        Me.mskCodePostal.Size = New System.Drawing.Size(93, 26)
        Me.mskCodePostal.TabIndex = 24
        '
        'lblTelephone
        '
        Me.lblTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTelephone.Location = New System.Drawing.Point(420, 178)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(125, 26)
        Me.lblTelephone.TabIndex = 23
        Me.lblTelephone.Text = "Telephone:"
        Me.lblTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mskTel
        '
        Me.mskTel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bs_Etudiant, "etu_telephone", True))
        Me.mskTel.Location = New System.Drawing.Point(551, 179)
        Me.mskTel.Mask = "(999) 999-9999"
        Me.mskTel.Name = "mskTel"
        Me.mskTel.Size = New System.Drawing.Size(142, 26)
        Me.mskTel.TabIndex = 22
        '
        'lblCodePostal
        '
        Me.lblCodePostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodePostal.Location = New System.Drawing.Point(420, 142)
        Me.lblCodePostal.Name = "lblCodePostal"
        Me.lblCodePostal.Size = New System.Drawing.Size(125, 26)
        Me.lblCodePostal.TabIndex = 21
        Me.lblCodePostal.Text = "Code Postal:"
        Me.lblCodePostal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVille
        '
        Me.lblVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVille.Location = New System.Drawing.Point(420, 67)
        Me.lblVille.Name = "lblVille"
        Me.lblVille.Size = New System.Drawing.Size(125, 26)
        Me.lblVille.TabIndex = 19
        Me.lblVille.Text = "Ville:"
        Me.lblVille.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdresse
        '
        Me.lblAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdresse.Location = New System.Drawing.Point(420, 31)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(125, 26)
        Me.lblAdresse.TabIndex = 17
        Me.lblAdresse.Text = "Adresse:"
        Me.lblAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNom
        '
        Me.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNom.Location = New System.Drawing.Point(16, 143)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(125, 26)
        Me.lblNom.TabIndex = 15
        Me.lblNom.Text = "Nom:"
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrenom
        '
        Me.lblPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrenom.Location = New System.Drawing.Point(16, 105)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(125, 26)
        Me.lblPrenom.TabIndex = 13
        Me.lblPrenom.Text = "Prenom:"
        Me.lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNoProg
        '
        Me.lblNoProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNoProg.Location = New System.Drawing.Point(16, 68)
        Me.lblNoProg.Name = "lblNoProg"
        Me.lblNoProg.Size = New System.Drawing.Size(125, 26)
        Me.lblNoProg.TabIndex = 11
        Me.lblNoProg.Text = "No. Prog:"
        Me.lblNoProg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mskDa
        '
        Me.mskDa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bs_Etudiant, "etu_da", True))
        Me.mskDa.Location = New System.Drawing.Point(147, 31)
        Me.mskDa.Mask = "9999999"
        Me.mskDa.Name = "mskDa"
        Me.mskDa.Size = New System.Drawing.Size(77, 26)
        Me.mskDa.TabIndex = 10
        '
        'lblDa
        '
        Me.lblDa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDa.Location = New System.Drawing.Point(16, 31)
        Me.lblDa.Name = "lblDa"
        Me.lblDa.Size = New System.Drawing.Size(125, 26)
        Me.lblDa.TabIndex = 9
        Me.lblDa.Text = "DA:"
        Me.lblDa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnModifier
        '
        Me.btnModifier.Location = New System.Drawing.Point(965, 165)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(87, 28)
        Me.btnModifier.TabIndex = 18
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Enabled = False
        Me.btnAnnuler.Location = New System.Drawing.Point(965, 131)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(87, 28)
        Me.btnAnnuler.TabIndex = 17
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Enabled = False
        Me.btnOk.Location = New System.Drawing.Point(965, 97)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(87, 28)
        Me.btnOk.TabIndex = 16
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnEnlever
        '
        Me.btnEnlever.Location = New System.Drawing.Point(965, 199)
        Me.btnEnlever.Name = "btnEnlever"
        Me.btnEnlever.Size = New System.Drawing.Size(87, 28)
        Me.btnEnlever.TabIndex = 15
        Me.btnEnlever.Text = "Enlever"
        Me.btnEnlever.UseVisualStyleBackColor = True
        '
        'btnNouveau
        '
        Me.btnNouveau.Location = New System.Drawing.Point(965, 63)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(87, 28)
        Me.btnNouveau.TabIndex = 14
        Me.btnNouveau.Text = "Nouveau"
        Me.btnNouveau.UseVisualStyleBackColor = True
        '
        'dgEtudiants
        '
        Me.dgEtudiants.AutoGenerateColumns = False
        Me.dgEtudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEtudiants.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EtudaDataGridViewTextBoxColumn, Me.PronoDataGridViewTextBoxColumn, Me.EtunomDataGridViewTextBoxColumn, Me.EtuprenomDataGridViewTextBoxColumn, Me.EtusexeDataGridViewTextBoxColumn, Me.EtuadresseDataGridViewTextBoxColumn, Me.EtuvilleDataGridViewTextBoxColumn, Me.EtuprovinceDataGridViewTextBoxColumn, Me.EtutelephoneDataGridViewTextBoxColumn, Me.EtucodepostalDataGridViewTextBoxColumn, Me.Expr1DataGridViewTextBoxColumn})
        Me.dgEtudiants.DataSource = Me.Bs_Etudiant
        Me.dgEtudiants.Location = New System.Drawing.Point(24, 293)
        Me.dgEtudiants.MultiSelect = False
        Me.dgEtudiants.Name = "dgEtudiants"
        Me.dgEtudiants.ReadOnly = True
        Me.dgEtudiants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEtudiants.Size = New System.Drawing.Size(1044, 318)
        Me.dgEtudiants.TabIndex = 19
        '
        'EtudaDataGridViewTextBoxColumn
        '
        Me.EtudaDataGridViewTextBoxColumn.DataPropertyName = "etu_da"
        Me.EtudaDataGridViewTextBoxColumn.HeaderText = "etu_da"
        Me.EtudaDataGridViewTextBoxColumn.Name = "EtudaDataGridViewTextBoxColumn"
        Me.EtudaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronoDataGridViewTextBoxColumn
        '
        Me.PronoDataGridViewTextBoxColumn.DataPropertyName = "pro_no"
        Me.PronoDataGridViewTextBoxColumn.HeaderText = "pro_no"
        Me.PronoDataGridViewTextBoxColumn.Name = "PronoDataGridViewTextBoxColumn"
        Me.PronoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtunomDataGridViewTextBoxColumn
        '
        Me.EtunomDataGridViewTextBoxColumn.DataPropertyName = "etu_nom"
        Me.EtunomDataGridViewTextBoxColumn.HeaderText = "etu_nom"
        Me.EtunomDataGridViewTextBoxColumn.Name = "EtunomDataGridViewTextBoxColumn"
        Me.EtunomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtuprenomDataGridViewTextBoxColumn
        '
        Me.EtuprenomDataGridViewTextBoxColumn.DataPropertyName = "etu_prenom"
        Me.EtuprenomDataGridViewTextBoxColumn.HeaderText = "etu_prenom"
        Me.EtuprenomDataGridViewTextBoxColumn.Name = "EtuprenomDataGridViewTextBoxColumn"
        Me.EtuprenomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtusexeDataGridViewTextBoxColumn
        '
        Me.EtusexeDataGridViewTextBoxColumn.DataPropertyName = "etu_sexe"
        Me.EtusexeDataGridViewTextBoxColumn.HeaderText = "etu_sexe"
        Me.EtusexeDataGridViewTextBoxColumn.Name = "EtusexeDataGridViewTextBoxColumn"
        Me.EtusexeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtuadresseDataGridViewTextBoxColumn
        '
        Me.EtuadresseDataGridViewTextBoxColumn.DataPropertyName = "etu_adresse"
        Me.EtuadresseDataGridViewTextBoxColumn.HeaderText = "etu_adresse"
        Me.EtuadresseDataGridViewTextBoxColumn.Name = "EtuadresseDataGridViewTextBoxColumn"
        Me.EtuadresseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtuvilleDataGridViewTextBoxColumn
        '
        Me.EtuvilleDataGridViewTextBoxColumn.DataPropertyName = "etu_ville"
        Me.EtuvilleDataGridViewTextBoxColumn.HeaderText = "etu_ville"
        Me.EtuvilleDataGridViewTextBoxColumn.Name = "EtuvilleDataGridViewTextBoxColumn"
        Me.EtuvilleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtuprovinceDataGridViewTextBoxColumn
        '
        Me.EtuprovinceDataGridViewTextBoxColumn.DataPropertyName = "etu_province"
        Me.EtuprovinceDataGridViewTextBoxColumn.HeaderText = "etu_province"
        Me.EtuprovinceDataGridViewTextBoxColumn.Name = "EtuprovinceDataGridViewTextBoxColumn"
        Me.EtuprovinceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtutelephoneDataGridViewTextBoxColumn
        '
        Me.EtutelephoneDataGridViewTextBoxColumn.DataPropertyName = "etu_telephone"
        Me.EtutelephoneDataGridViewTextBoxColumn.HeaderText = "etu_telephone"
        Me.EtutelephoneDataGridViewTextBoxColumn.Name = "EtutelephoneDataGridViewTextBoxColumn"
        Me.EtutelephoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtucodepostalDataGridViewTextBoxColumn
        '
        Me.EtucodepostalDataGridViewTextBoxColumn.DataPropertyName = "etu_codepostal"
        Me.EtucodepostalDataGridViewTextBoxColumn.HeaderText = "etu_codepostal"
        Me.EtucodepostalDataGridViewTextBoxColumn.Name = "EtucodepostalDataGridViewTextBoxColumn"
        Me.EtucodepostalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr1DataGridViewTextBoxColumn
        '
        Me.Expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1"
        Me.Expr1DataGridViewTextBoxColumn.HeaderText = "Expr1"
        Me.Expr1DataGridViewTextBoxColumn.Name = "Expr1DataGridViewTextBoxColumn"
        Me.Expr1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Expr1DataGridViewTextBoxColumn.Visible = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        T_etudiants.*, T_programme.pro_no AS Expr1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            T_etudi" &
    "ants INNER JOIN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                         T_programme ON T_etudiants.pro_no = T_" &
    "programme.pro_no"
        Me.SqlSelectCommand1.Connection = Me.CON
        '
        'CON
        '
        Me.CON.ConnectionString = "Data Source=DESKTOP-TNIO8BB\SQLEXPRESS;Initial Catalog=tp_p44;Integrated Security" &
    "=True"
        Me.CON.FireInfoMessageEventOnUserErrors = False
        '
        'DaEtudiant
        '
        Me.DaEtudiant.SelectCommand = Me.SqlSelectCommand1
        Me.DaEtudiant.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("etu_da", "etu_da"), New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("etu_nom", "etu_nom"), New System.Data.Common.DataColumnMapping("etu_prenom", "etu_prenom"), New System.Data.Common.DataColumnMapping("etu_sexe", "etu_sexe"), New System.Data.Common.DataColumnMapping("etu_adresse", "etu_adresse"), New System.Data.Common.DataColumnMapping("etu_ville", "etu_ville"), New System.Data.Common.DataColumnMapping("etu_province", "etu_province"), New System.Data.Common.DataColumnMapping("etu_telephone", "etu_telephone"), New System.Data.Common.DataColumnMapping("etu_codepostal", "etu_codepostal"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1")})})
        '
        'frmEtudiants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1085, 624)
        Me.Controls.Add(Me.dgEtudiants)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnEnlever)
        Me.Controls.Add(Me.btnNouveau)
        Me.Controls.Add(Me.grpEtudiant)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmEtudiants"
        Me.Text = "Etudiants"
        Me.grpEtudiant.ResumeLayout(False)
        Me.grpEtudiant.PerformLayout()
        Me.grpSexe.ResumeLayout(False)
        Me.grpSexe.PerformLayout()
        CType(Me.Bs_Etudiant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEtudiant1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEtudiants, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpEtudiant As GroupBox
    Friend WithEvents grpSexe As GroupBox
    Friend WithEvents optMasculin As RadioButton
    Friend WithEvents optFeminin As RadioButton
    Friend WithEvents cboProvince As ComboBox
    Friend WithEvents cboNoProg As ComboBox
    Friend WithEvents txtVille As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents lblProvince As Label
    Friend WithEvents mskCodePostal As MaskedTextBox
    Friend WithEvents lblTelephone As Label
    Friend WithEvents mskTel As MaskedTextBox
    Friend WithEvents lblCodePostal As Label
    Friend WithEvents lblVille As Label
    Friend WithEvents lblAdresse As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblPrenom As Label
    Friend WithEvents lblNoProg As Label
    Friend WithEvents mskDa As MaskedTextBox
    Friend WithEvents lblDa As Label
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents btnEnlever As Button
    Friend WithEvents btnNouveau As Button
    Friend WithEvents dgEtudiants As DataGridView
    Friend WithEvents Bs_Etudiant As BindingSource
    Friend WithEvents DsEtudiant1 As DsEtudiant
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents CON As SqlClient.SqlConnection
    Friend WithEvents DaEtudiant As SqlClient.SqlDataAdapter
    Friend WithEvents EtudaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtunomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuprenomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtusexeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuadresseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuvilleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuprovinceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtutelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtucodepostalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
