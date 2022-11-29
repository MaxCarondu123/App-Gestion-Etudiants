<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.menuGestion = New System.Windows.Forms.MenuStrip()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProgramme = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEtudiants = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBarre = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuQuitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.RapportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListeProg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListeEtu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListeEtudProg = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuGestion.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuGestion
        '
        Me.menuGestion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionToolStripMenuItem, Me.RapportToolStripMenuItem})
        Me.menuGestion.Location = New System.Drawing.Point(0, 0)
        Me.menuGestion.Name = "menuGestion"
        Me.menuGestion.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.menuGestion.Size = New System.Drawing.Size(1327, 25)
        Me.menuGestion.TabIndex = 2
        Me.menuGestion.Text = "MenuStrip1"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProgramme, Me.mnuEtudiants, Me.mnuBarre, Me.mnuQuitter})
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(59, 19)
        Me.GestionToolStripMenuItem.Text = "Gestion"
        '
        'mnuProgramme
        '
        Me.mnuProgramme.Name = "mnuProgramme"
        Me.mnuProgramme.Size = New System.Drawing.Size(137, 22)
        Me.mnuProgramme.Text = "Programme"
        '
        'mnuEtudiants
        '
        Me.mnuEtudiants.Name = "mnuEtudiants"
        Me.mnuEtudiants.Size = New System.Drawing.Size(137, 22)
        Me.mnuEtudiants.Text = "Etudiants"
        '
        'mnuBarre
        '
        Me.mnuBarre.Name = "mnuBarre"
        Me.mnuBarre.Size = New System.Drawing.Size(134, 6)
        '
        'mnuQuitter
        '
        Me.mnuQuitter.Name = "mnuQuitter"
        Me.mnuQuitter.Size = New System.Drawing.Size(137, 22)
        Me.mnuQuitter.Text = "Quitter"
        '
        'RapportToolStripMenuItem
        '
        Me.RapportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuListeProg, Me.mnuListeEtu, Me.mnuListeEtudProg})
        Me.RapportToolStripMenuItem.Name = "RapportToolStripMenuItem"
        Me.RapportToolStripMenuItem.Size = New System.Drawing.Size(61, 19)
        Me.RapportToolStripMenuItem.Text = "Rapport"
        '
        'mnuListeProg
        '
        Me.mnuListeProg.Name = "mnuListeProg"
        Me.mnuListeProg.Size = New System.Drawing.Size(260, 22)
        Me.mnuListeProg.Text = "Liste des programmes"
        '
        'mnuListeEtu
        '
        Me.mnuListeEtu.Name = "mnuListeEtu"
        Me.mnuListeEtu.Size = New System.Drawing.Size(260, 22)
        Me.mnuListeEtu.Text = "Liste des etudiants"
        '
        'mnuListeEtudProg
        '
        Me.mnuListeEtudProg.Name = "mnuListeEtudProg"
        Me.mnuListeEtudProg.Size = New System.Drawing.Size(260, 22)
        Me.mnuListeEtudProg.Text = "Liste des etudiants par  programme"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1327, 725)
        Me.Controls.Add(Me.menuGestion)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmPrincipal"
        Me.Text = "Form1"
        Me.menuGestion.ResumeLayout(False)
        Me.menuGestion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuGestion As MenuStrip
    Friend WithEvents GestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuProgramme As ToolStripMenuItem
    Friend WithEvents mnuEtudiants As ToolStripMenuItem
    Friend WithEvents mnuBarre As ToolStripSeparator
    Friend WithEvents mnuQuitter As ToolStripMenuItem
    Friend WithEvents RapportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuListeProg As ToolStripMenuItem
    Friend WithEvents mnuListeEtu As ToolStripMenuItem
    Friend WithEvents mnuListeEtudProg As ToolStripMenuItem
End Class
