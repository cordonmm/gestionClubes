<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits MetroFramework.Forms.MetroForm





    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SociosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeneficiariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BonosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeSociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpresiónDeCarnetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarSociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CuotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContabilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.SociosToolStripMenuItem, Me.CuotasToolStripMenuItem, Me.ContabilidadToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1201, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoUsuariosToolStripMenuItem, Me.PermisosToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'ListadoUsuariosToolStripMenuItem
        '
        Me.ListadoUsuariosToolStripMenuItem.Name = "ListadoUsuariosToolStripMenuItem"
        Me.ListadoUsuariosToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ListadoUsuariosToolStripMenuItem.Text = "Listado usuarios"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.PermisosToolStripMenuItem.Text = "Permisos"
        '
        'SociosToolStripMenuItem
        '
        Me.SociosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SociosToolStripMenuItem1, Me.BeneficiariosToolStripMenuItem, Me.BonosToolStripMenuItem, Me.ListadoDeSociosToolStripMenuItem, Me.ImpresiónDeCarnetsToolStripMenuItem, Me.ImportarSociosToolStripMenuItem, Me.ToolStripSeparator1})
        Me.SociosToolStripMenuItem.Name = "SociosToolStripMenuItem"
        Me.SociosToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.SociosToolStripMenuItem.Text = "Socios"
        '
        'SociosToolStripMenuItem1
        '
        Me.SociosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ListadoToolStripMenuItem})
        Me.SociosToolStripMenuItem1.Name = "SociosToolStripMenuItem1"
        Me.SociosToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.SociosToolStripMenuItem1.Text = "Socios"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ListadoToolStripMenuItem
        '
        Me.ListadoToolStripMenuItem.Name = "ListadoToolStripMenuItem"
        Me.ListadoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListadoToolStripMenuItem.Text = "Listado"
        '
        'BeneficiariosToolStripMenuItem
        '
        Me.BeneficiariosToolStripMenuItem.Name = "BeneficiariosToolStripMenuItem"
        Me.BeneficiariosToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.BeneficiariosToolStripMenuItem.Text = "Beneficiarios"
        '
        'BonosToolStripMenuItem
        '
        Me.BonosToolStripMenuItem.Name = "BonosToolStripMenuItem"
        Me.BonosToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.BonosToolStripMenuItem.Text = "Bonos"
        '
        'ListadoDeSociosToolStripMenuItem
        '
        Me.ListadoDeSociosToolStripMenuItem.Name = "ListadoDeSociosToolStripMenuItem"
        Me.ListadoDeSociosToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ListadoDeSociosToolStripMenuItem.Text = "Listado de socios"
        '
        'ImpresiónDeCarnetsToolStripMenuItem
        '
        Me.ImpresiónDeCarnetsToolStripMenuItem.Name = "ImpresiónDeCarnetsToolStripMenuItem"
        Me.ImpresiónDeCarnetsToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ImpresiónDeCarnetsToolStripMenuItem.Text = "Impresión de carnets"
        '
        'ImportarSociosToolStripMenuItem
        '
        Me.ImportarSociosToolStripMenuItem.Name = "ImportarSociosToolStripMenuItem"
        Me.ImportarSociosToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ImportarSociosToolStripMenuItem.Text = "Importar socios"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(181, 6)
        '
        'CuotasToolStripMenuItem
        '
        Me.CuotasToolStripMenuItem.Name = "CuotasToolStripMenuItem"
        Me.CuotasToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.CuotasToolStripMenuItem.Text = "Cuotas"
        '
        'ContabilidadToolStripMenuItem
        '
        Me.ContabilidadToolStripMenuItem.Name = "ContabilidadToolStripMenuItem"
        Me.ContabilidadToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.ContabilidadToolStripMenuItem.Text = "Contabilidad"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 649)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "Club Social Cultural y Deportivo Fernando Varela"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PermisosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SociosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BeneficiariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BonosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeSociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpresiónDeCarnetsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportarSociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CuotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContabilidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
End Class
