<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProgramme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgramme))
        Me.dgProgramme = New System.Windows.Forms.DataGridView()
        Me.PronoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronbrunitesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronbrheuresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bs_Programme = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds1 = New P34_TP2_Maxime_Caron.Ds()
        Me.dgEtudiant = New System.Windows.Forms.DataGridView()
        Me.EtudaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtunomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuprenomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bs_ProgEtu = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProgEtu1 = New P34_TP2_Maxime_Caron.DsProgEtu()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnEnlever = New System.Windows.Forms.Button()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.grpProgramme = New System.Windows.Forms.GroupBox()
        Me.numNbrHeures = New System.Windows.Forms.NumericUpDown()
        Me.numNbrUnites = New System.Windows.Forms.NumericUpDown()
        Me.mskNo = New System.Windows.Forms.MaskedTextBox()
        Me.lblNbrHeures = New System.Windows.Forms.Label()
        Me.lblNbrUnites = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.CON = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.DaProgramme = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.DaProgEtu = New System.Data.SqlClient.SqlDataAdapter()
        CType(Me.dgProgramme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bs_Programme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEtudiant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bs_ProgEtu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProgEtu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProgramme.SuspendLayout()
        CType(Me.numNbrHeures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numNbrUnites, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgProgramme
        '
        Me.dgProgramme.AutoGenerateColumns = False
        Me.dgProgramme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProgramme.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PronoDataGridViewTextBoxColumn, Me.PronomDataGridViewTextBoxColumn, Me.PronbrunitesDataGridViewTextBoxColumn, Me.PronbrheuresDataGridViewTextBoxColumn})
        Me.dgProgramme.DataSource = Me.Bs_Programme
        Me.dgProgramme.Location = New System.Drawing.Point(60, 204)
        Me.dgProgramme.MultiSelect = False
        Me.dgProgramme.Name = "dgProgramme"
        Me.dgProgramme.ReadOnly = True
        Me.dgProgramme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProgramme.Size = New System.Drawing.Size(442, 335)
        Me.dgProgramme.TabIndex = 16
        '
        'PronoDataGridViewTextBoxColumn
        '
        Me.PronoDataGridViewTextBoxColumn.DataPropertyName = "pro_no"
        Me.PronoDataGridViewTextBoxColumn.HeaderText = "pro_no"
        Me.PronoDataGridViewTextBoxColumn.Name = "PronoDataGridViewTextBoxColumn"
        Me.PronoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronomDataGridViewTextBoxColumn
        '
        Me.PronomDataGridViewTextBoxColumn.DataPropertyName = "pro_nom"
        Me.PronomDataGridViewTextBoxColumn.HeaderText = "pro_nom"
        Me.PronomDataGridViewTextBoxColumn.Name = "PronomDataGridViewTextBoxColumn"
        Me.PronomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronbrunitesDataGridViewTextBoxColumn
        '
        Me.PronbrunitesDataGridViewTextBoxColumn.DataPropertyName = "pro_nbr_unites"
        Me.PronbrunitesDataGridViewTextBoxColumn.HeaderText = "pro_nbr_unites"
        Me.PronbrunitesDataGridViewTextBoxColumn.Name = "PronbrunitesDataGridViewTextBoxColumn"
        Me.PronbrunitesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronbrheuresDataGridViewTextBoxColumn
        '
        Me.PronbrheuresDataGridViewTextBoxColumn.DataPropertyName = "pro_nbr_heures"
        Me.PronbrheuresDataGridViewTextBoxColumn.HeaderText = "pro_nbr_heures"
        Me.PronbrheuresDataGridViewTextBoxColumn.Name = "PronbrheuresDataGridViewTextBoxColumn"
        Me.PronbrheuresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Bs_Programme
        '
        Me.Bs_Programme.DataMember = "T_programme"
        Me.Bs_Programme.DataSource = Me.Ds1
        '
        'Ds1
        '
        Me.Ds1.DataSetName = "Ds"
        Me.Ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgEtudiant
        '
        Me.dgEtudiant.AutoGenerateColumns = False
        Me.dgEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEtudiant.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EtudaDataGridViewTextBoxColumn, Me.PronoDataGridViewTextBoxColumn1, Me.EtunomDataGridViewTextBoxColumn, Me.EtuprenomDataGridViewTextBoxColumn})
        Me.dgEtudiant.DataSource = Me.Bs_ProgEtu
        Me.dgEtudiant.Location = New System.Drawing.Point(590, 12)
        Me.dgEtudiant.MultiSelect = False
        Me.dgEtudiant.Name = "dgEtudiant"
        Me.dgEtudiant.ReadOnly = True
        Me.dgEtudiant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEtudiant.Size = New System.Drawing.Size(445, 527)
        Me.dgEtudiant.TabIndex = 15
        '
        'EtudaDataGridViewTextBoxColumn
        '
        Me.EtudaDataGridViewTextBoxColumn.DataPropertyName = "etu_da"
        Me.EtudaDataGridViewTextBoxColumn.HeaderText = "etu_da"
        Me.EtudaDataGridViewTextBoxColumn.Name = "EtudaDataGridViewTextBoxColumn"
        Me.EtudaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronoDataGridViewTextBoxColumn1
        '
        Me.PronoDataGridViewTextBoxColumn1.DataPropertyName = "pro_no"
        Me.PronoDataGridViewTextBoxColumn1.HeaderText = "pro_no"
        Me.PronoDataGridViewTextBoxColumn1.Name = "PronoDataGridViewTextBoxColumn1"
        Me.PronoDataGridViewTextBoxColumn1.ReadOnly = True
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
        'Bs_ProgEtu
        '
        Me.Bs_ProgEtu.DataMember = "T_etudiants"
        Me.Bs_ProgEtu.DataSource = Me.DsProgEtu1
        '
        'DsProgEtu1
        '
        Me.DsProgEtu1.DataSetName = "DsProgEtu"
        Me.DsProgEtu1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnModifier
        '
        Me.btnModifier.Location = New System.Drawing.Point(451, 132)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(87, 28)
        Me.btnModifier.TabIndex = 14
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Enabled = False
        Me.btnAnnuler.Location = New System.Drawing.Point(451, 98)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(87, 28)
        Me.btnAnnuler.TabIndex = 13
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Enabled = False
        Me.btnOk.Location = New System.Drawing.Point(451, 64)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(87, 28)
        Me.btnOk.TabIndex = 12
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnEnlever
        '
        Me.btnEnlever.Enabled = False
        Me.btnEnlever.Location = New System.Drawing.Point(451, 166)
        Me.btnEnlever.Name = "btnEnlever"
        Me.btnEnlever.Size = New System.Drawing.Size(87, 28)
        Me.btnEnlever.TabIndex = 11
        Me.btnEnlever.Text = "Enlever"
        Me.btnEnlever.UseVisualStyleBackColor = True
        '
        'btnNouveau
        '
        Me.btnNouveau.Location = New System.Drawing.Point(451, 30)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(87, 28)
        Me.btnNouveau.TabIndex = 10
        Me.btnNouveau.Text = "Nouveau"
        Me.btnNouveau.UseVisualStyleBackColor = True
        '
        'grpProgramme
        '
        Me.grpProgramme.Controls.Add(Me.numNbrHeures)
        Me.grpProgramme.Controls.Add(Me.numNbrUnites)
        Me.grpProgramme.Controls.Add(Me.mskNo)
        Me.grpProgramme.Controls.Add(Me.lblNbrHeures)
        Me.grpProgramme.Controls.Add(Me.lblNbrUnites)
        Me.grpProgramme.Controls.Add(Me.txtNom)
        Me.grpProgramme.Controls.Add(Me.lblNom)
        Me.grpProgramme.Controls.Add(Me.lblNo)
        Me.grpProgramme.Enabled = False
        Me.grpProgramme.Location = New System.Drawing.Point(22, 20)
        Me.grpProgramme.Name = "grpProgramme"
        Me.grpProgramme.Size = New System.Drawing.Size(384, 178)
        Me.grpProgramme.TabIndex = 9
        Me.grpProgramme.TabStop = False
        Me.grpProgramme.Text = "Programme"
        '
        'numNbrHeures
        '
        Me.numNbrHeures.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Bs_Programme, "pro_nbr_heures", True))
        Me.numNbrHeures.Location = New System.Drawing.Point(146, 136)
        Me.numNbrHeures.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numNbrHeures.Name = "numNbrHeures"
        Me.numNbrHeures.Size = New System.Drawing.Size(101, 26)
        Me.numNbrHeures.TabIndex = 10
        Me.numNbrHeures.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numNbrUnites
        '
        Me.numNbrUnites.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Bs_Programme, "pro_nbr_unites", True))
        Me.numNbrUnites.DecimalPlaces = 2
        Me.numNbrUnites.Location = New System.Drawing.Point(146, 101)
        Me.numNbrUnites.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numNbrUnites.Name = "numNbrUnites"
        Me.numNbrUnites.Size = New System.Drawing.Size(101, 26)
        Me.numNbrUnites.TabIndex = 9
        Me.numNbrUnites.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mskNo
        '
        Me.mskNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bs_Programme, "pro_no", True))
        Me.mskNo.Location = New System.Drawing.Point(146, 31)
        Me.mskNo.Mask = "LLL.0L"
        Me.mskNo.Name = "mskNo"
        Me.mskNo.Size = New System.Drawing.Size(77, 26)
        Me.mskNo.TabIndex = 8
        '
        'lblNbrHeures
        '
        Me.lblNbrHeures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNbrHeures.Location = New System.Drawing.Point(15, 136)
        Me.lblNbrHeures.Name = "lblNbrHeures"
        Me.lblNbrHeures.Size = New System.Drawing.Size(125, 26)
        Me.lblNbrHeures.TabIndex = 6
        Me.lblNbrHeures.Text = "Nbr. Heures:"
        Me.lblNbrHeures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNbrUnites
        '
        Me.lblNbrUnites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNbrUnites.Location = New System.Drawing.Point(15, 101)
        Me.lblNbrUnites.Name = "lblNbrUnites"
        Me.lblNbrUnites.Size = New System.Drawing.Size(125, 26)
        Me.lblNbrUnites.TabIndex = 4
        Me.lblNbrUnites.Text = "Nbr. Unites:"
        Me.lblNbrUnites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNom
        '
        Me.txtNom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bs_Programme, "pro_nom", True))
        Me.txtNom.Location = New System.Drawing.Point(146, 66)
        Me.txtNom.MaxLength = 50
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(222, 26)
        Me.txtNom.TabIndex = 3
        '
        'lblNom
        '
        Me.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNom.Location = New System.Drawing.Point(15, 66)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(125, 26)
        Me.lblNom.TabIndex = 2
        Me.lblNom.Text = "Nom:"
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNo
        '
        Me.lblNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNo.Location = New System.Drawing.Point(15, 31)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(125, 26)
        Me.lblNo.TabIndex = 0
        Me.lblNo.Text = "No:"
        Me.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        T_programme.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            T_programme"
        Me.SqlSelectCommand1.Connection = Me.CON
        '
        'CON
        '
        Me.CON.ConnectionString = "Data Source=DESKTOP-TNIO8BB\SQLEXPRESS;Initial Catalog=tp_p44;Integrated Security" &
    "=True"
        Me.CON.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.CON
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@pro_nom", System.Data.SqlDbType.VarChar, 0, "pro_nom"), New System.Data.SqlClient.SqlParameter("@pro_nbr_unites", System.Data.SqlDbType.Float, 0, "pro_nbr_unites"), New System.Data.SqlClient.SqlParameter("@pro_nbr_heures", System.Data.SqlDbType.Int, 0, "pro_nbr_heures")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.CON
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@pro_nom", System.Data.SqlDbType.VarChar, 0, "pro_nom"), New System.Data.SqlClient.SqlParameter("@pro_nbr_unites", System.Data.SqlDbType.Float, 0, "pro_nbr_unites"), New System.Data.SqlClient.SqlParameter("@pro_nbr_heures", System.Data.SqlDbType.Int, 0, "pro_nbr_heures"), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_unites", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_unites", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.CON
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_unites", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_unites", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, Nothing)})
        '
        'DaProgramme
        '
        Me.DaProgramme.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaProgramme.InsertCommand = Me.SqlInsertCommand1
        Me.DaProgramme.SelectCommand = Me.SqlSelectCommand1
        Me.DaProgramme.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_programme", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("pro_nom", "pro_nom"), New System.Data.Common.DataColumnMapping("pro_nbr_unites", "pro_nbr_unites"), New System.Data.Common.DataColumnMapping("pro_nbr_heures", "pro_nbr_heures")})})
        Me.DaProgramme.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.CON
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NoProg", System.Data.SqlDbType.VarChar, 6, "pro_no")})
        '
        'DaProgEtu
        '
        Me.DaProgEtu.SelectCommand = Me.SqlSelectCommand2
        Me.DaProgEtu.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("etu_da", "etu_da"), New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("etu_nom", "etu_nom"), New System.Data.Common.DataColumnMapping("etu_prenom", "etu_prenom")})})
        '
        'frmProgramme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1047, 562)
        Me.Controls.Add(Me.dgProgramme)
        Me.Controls.Add(Me.dgEtudiant)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnEnlever)
        Me.Controls.Add(Me.btnNouveau)
        Me.Controls.Add(Me.grpProgramme)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmProgramme"
        Me.Text = "frmProgramme"
        CType(Me.dgProgramme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bs_Programme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEtudiant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bs_ProgEtu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProgEtu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProgramme.ResumeLayout(False)
        Me.grpProgramme.PerformLayout()
        CType(Me.numNbrHeures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numNbrUnites, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgProgramme As DataGridView
    Friend WithEvents dgEtudiant As DataGridView
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents btnEnlever As Button
    Friend WithEvents btnNouveau As Button
    Friend WithEvents grpProgramme As GroupBox
    Friend WithEvents numNbrHeures As NumericUpDown
    Friend WithEvents numNbrUnites As NumericUpDown
    Friend WithEvents mskNo As MaskedTextBox
    Friend WithEvents lblNbrHeures As Label
    Friend WithEvents lblNbrUnites As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents lblNom As Label
    Friend WithEvents lblNo As Label
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents CON As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents DaProgramme As SqlClient.SqlDataAdapter
    Friend WithEvents Ds1 As Ds
    Friend WithEvents PronoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronbrunitesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronbrheuresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Bs_Programme As BindingSource
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents DaProgEtu As SqlClient.SqlDataAdapter
    Friend WithEvents EtudaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EtunomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuprenomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Bs_ProgEtu As BindingSource
    Friend WithEvents DsProgEtu1 As DsProgEtu
End Class
