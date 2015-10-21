<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListadoSocios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_socio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlf_fijo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlf_movil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.recibos_pte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.num_socio, Me.nombre, Me.apellidos, Me.tlf_fijo, Me.tlf_movil, Me.recibos_pte})
        Me.DataGridView1.Location = New System.Drawing.Point(40, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1027, 334)
        Me.DataGridView1.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        '
        'num_socio
        '
        Me.num_socio.HeaderText = "Núm. Socio"
        Me.num_socio.Name = "num_socio"
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'apellidos
        '
        Me.apellidos.HeaderText = "Apellidos"
        Me.apellidos.Name = "apellidos"
        '
        'tlf_fijo
        '
        Me.tlf_fijo.HeaderText = "Teléfono Fijo"
        Me.tlf_fijo.Name = "tlf_fijo"
        '
        'tlf_movil
        '
        Me.tlf_movil.HeaderText = "Teléfono Móvil"
        Me.tlf_movil.Name = "tlf_movil"
        '
        'recibos_pte
        '
        Me.recibos_pte.HeaderText = "Recibos Pendientes"
        Me.recibos_pte.Name = "recibos_pte"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(168, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(185, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 685)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents num_socio As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellidos As DataGridViewTextBoxColumn
    Friend WithEvents tlf_fijo As DataGridViewTextBoxColumn
    Friend WithEvents tlf_movil As DataGridViewTextBoxColumn
    Friend WithEvents recibos_pte As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
End Class
