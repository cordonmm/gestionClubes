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
        Me.BeneficiariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BonosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeSociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpresiónDeCarnetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarSociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CuotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContabilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoProToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SociosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnPuerta = New MetroFramework.Controls.MetroButton()
        Me.btnFaturación = New MetroFramework.Controls.MetroButton()
        Me.btnSacarEntrada = New MetroFramework.Controls.MetroButton()
        Me.btnSocios = New MetroFramework.Controls.MetroButton()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.SociosToolStripMenuItem, Me.CuotasToolStripMenuItem, Me.ContabilidadToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(840, 24)
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
        Me.ContabilidadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaFacturaToolStripMenuItem, Me.NuevoProToolStripMenuItem})
        Me.ContabilidadToolStripMenuItem.Name = "ContabilidadToolStripMenuItem"
        Me.ContabilidadToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.ContabilidadToolStripMenuItem.Text = "Contabilidad"
        '
        'NuevaFacturaToolStripMenuItem
        '
        Me.NuevaFacturaToolStripMenuItem.Name = "NuevaFacturaToolStripMenuItem"
        Me.NuevaFacturaToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.NuevaFacturaToolStripMenuItem.Text = "Nueva Factura"
        '
        'NuevoProToolStripMenuItem
        '
        Me.NuevoProToolStripMenuItem.Name = "NuevoProToolStripMenuItem"
        Me.NuevoProToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.NuevoProToolStripMenuItem.Text = "Nuevo Proveedor"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'SociosToolStripMenuItem1
        '
        Me.SociosToolStripMenuItem1.Name = "SociosToolStripMenuItem1"
        Me.SociosToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.SociosToolStripMenuItem1.Text = "Nuevo"
        '
        'MetroButton2
        '
        Me.MetroButton2.BackgroundImage = Global.GestionClubes.My.Resources.Resources.Google__alt_2
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.MetroButton2.ForeColor = System.Drawing.SystemColors.Control
        Me.MetroButton2.Location = New System.Drawing.Point(525, 312)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(123, 109)
        Me.MetroButton2.TabIndex = 6
        Me.MetroButton2.Text = "Reservas"
        Me.MetroButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.BackgroundImage = Global.GestionClubes.My.Resources.Resources.BitLocker
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.MetroButton1.ForeColor = System.Drawing.SystemColors.Control
        Me.MetroButton1.Location = New System.Drawing.Point(378, 312)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(123, 109)
        Me.MetroButton1.TabIndex = 5
        Me.MetroButton1.Text = "Abrir puerta"
        Me.MetroButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroButton1.UseSelectable = True
        '
        'btnPuerta
        '
        Me.btnPuerta.BackgroundImage = Global.GestionClubes.My.Resources.Resources.Services
        Me.btnPuerta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPuerta.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnPuerta.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPuerta.Location = New System.Drawing.Point(525, 188)
        Me.btnPuerta.Name = "btnPuerta"
        Me.btnPuerta.Size = New System.Drawing.Size(123, 109)
        Me.btnPuerta.TabIndex = 4
        Me.btnPuerta.Text = "Configuracion"
        Me.btnPuerta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPuerta.UseSelectable = True
        '
        'btnFaturación
        '
        Me.btnFaturación.BackgroundImage = Global.GestionClubes.My.Resources.Resources.Chart___Google_Docs
        Me.btnFaturación.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFaturación.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnFaturación.Location = New System.Drawing.Point(378, 188)
        Me.btnFaturación.Name = "btnFaturación"
        Me.btnFaturación.Size = New System.Drawing.Size(123, 109)
        Me.btnFaturación.TabIndex = 3
        Me.btnFaturación.Text = "Facturación"
        Me.btnFaturación.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFaturación.UseSelectable = True
        '
        'btnSacarEntrada
        '
        Me.btnSacarEntrada.BackgroundImage = Global.GestionClubes.My.Resources.Resources.Recent_Items
        Me.btnSacarEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSacarEntrada.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSacarEntrada.Location = New System.Drawing.Point(234, 312)
        Me.btnSacarEntrada.Name = "btnSacarEntrada"
        Me.btnSacarEntrada.Size = New System.Drawing.Size(123, 109)
        Me.btnSacarEntrada.TabIndex = 2
        Me.btnSacarEntrada.Text = "Entrada"
        Me.btnSacarEntrada.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSacarEntrada.UseSelectable = True
        '
        'btnSocios
        '
        Me.btnSocios.BackgroundImage = Global.GestionClubes.My.Resources.Resources.Contacts
        Me.btnSocios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSocios.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSocios.Location = New System.Drawing.Point(234, 188)
        Me.btnSocios.Name = "btnSocios"
        Me.btnSocios.Size = New System.Drawing.Size(123, 109)
        Me.btnSocios.TabIndex = 1
        Me.btnSocios.Text = "Socios"
        Me.btnSocios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSocios.UseSelectable = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 507)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnPuerta)
        Me.Controls.Add(Me.btnFaturación)
        Me.Controls.Add(Me.btnSacarEntrada)
        Me.Controls.Add(Me.btnSocios)
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
    Friend WithEvents BeneficiariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BonosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeSociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpresiónDeCarnetsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportarSociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CuotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContabilidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnSocios As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSacarEntrada As MetroFramework.Controls.MetroButton
    Friend WithEvents btnFaturación As MetroFramework.Controls.MetroButton
    Friend WithEvents NuevaFacturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoProToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnPuerta As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents SociosToolStripMenuItem1 As ToolStripMenuItem
End Class
