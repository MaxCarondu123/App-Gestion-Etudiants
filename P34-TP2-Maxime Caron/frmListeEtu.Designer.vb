<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeEtu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.CON = New System.Data.SqlClient.SqlConnection()
        Me.daEtudiant = New System.Data.SqlClient.SqlDataAdapter()
        Me.DsRapportEtu1 = New P34_TP2_Maxime_Caron.DsRapportEtu()
        Me.crvEtudiant = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DsRapportEtu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        T_etudiants.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            T_etudiants"
        Me.SqlSelectCommand1.Connection = Me.CON
        '
        'CON
        '
        Me.CON.ConnectionString = "Data Source=DESKTOP-TNIO8BB\SQLEXPRESS;Initial Catalog=tp_p44;Integrated Security" &
    "=True"
        Me.CON.FireInfoMessageEventOnUserErrors = False
        '
        'daEtudiant
        '
        Me.daEtudiant.SelectCommand = Me.SqlSelectCommand1
        Me.daEtudiant.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("etu_da", "etu_da"), New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("etu_nom", "etu_nom"), New System.Data.Common.DataColumnMapping("etu_prenom", "etu_prenom"), New System.Data.Common.DataColumnMapping("etu_sexe", "etu_sexe"), New System.Data.Common.DataColumnMapping("etu_adresse", "etu_adresse"), New System.Data.Common.DataColumnMapping("etu_ville", "etu_ville"), New System.Data.Common.DataColumnMapping("etu_province", "etu_province"), New System.Data.Common.DataColumnMapping("etu_telephone", "etu_telephone"), New System.Data.Common.DataColumnMapping("etu_codepostal", "etu_codepostal")})})
        '
        'DsRapportEtu1
        '
        Me.DsRapportEtu1.DataSetName = "DsRapportEtu"
        Me.DsRapportEtu1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'crvEtudiant
        '
        Me.crvEtudiant.ActiveViewIndex = -1
        Me.crvEtudiant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvEtudiant.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvEtudiant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvEtudiant.Location = New System.Drawing.Point(0, 0)
        Me.crvEtudiant.Name = "crvEtudiant"
        Me.crvEtudiant.Size = New System.Drawing.Size(1200, 593)
        Me.crvEtudiant.TabIndex = 0
        '
        'frmListeEtu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1200, 593)
        Me.Controls.Add(Me.crvEtudiant)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmListeEtu"
        Me.Text = "frmListeEtu"
        CType(Me.DsRapportEtu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents CON As SqlClient.SqlConnection
    Friend WithEvents daEtudiant As SqlClient.SqlDataAdapter
    Friend WithEvents DsRapportEtu1 As DsRapportEtu
    Friend WithEvents crvEtudiant As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
