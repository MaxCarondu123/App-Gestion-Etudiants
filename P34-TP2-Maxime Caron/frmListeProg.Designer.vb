<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeProg
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
        Me.daProgramme = New System.Data.SqlClient.SqlDataAdapter()
        Me.DsRapportProg1 = New P34_TP2_Maxime_Caron.DsRapportProg()
        Me.crvProg = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DsRapportProg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'daProgramme
        '
        Me.daProgramme.SelectCommand = Me.SqlSelectCommand1
        Me.daProgramme.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_programme", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("pro_nom", "pro_nom"), New System.Data.Common.DataColumnMapping("pro_nbr_unites", "pro_nbr_unites"), New System.Data.Common.DataColumnMapping("pro_nbr_heures", "pro_nbr_heures")})})
        '
        'DsRapportProg1
        '
        Me.DsRapportProg1.DataSetName = "DsRapportProg"
        Me.DsRapportProg1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'crvProg
        '
        Me.crvProg.ActiveViewIndex = -1
        Me.crvProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvProg.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvProg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvProg.Location = New System.Drawing.Point(0, 0)
        Me.crvProg.Name = "crvProg"
        Me.crvProg.Size = New System.Drawing.Size(1187, 571)
        Me.crvProg.TabIndex = 0
        '
        'frmListeProg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1187, 571)
        Me.Controls.Add(Me.crvProg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmListeProg"
        Me.Text = "frmListeProg"
        CType(Me.DsRapportProg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents CON As SqlClient.SqlConnection
    Friend WithEvents daProgramme As SqlClient.SqlDataAdapter
    Friend WithEvents DsRapportProg1 As DsRapportProg
    Friend WithEvents crvProg As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
