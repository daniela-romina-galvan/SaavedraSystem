<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.picVisto = New System.Windows.Forms.PictureBox()
        Me.cbLista = New System.Windows.Forms.ComboBox()
        Me.cbItem = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbPrefijo = New System.Windows.Forms.TextBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbNumero = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbDNI = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbApellido = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbBuscar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        CType(Me.picVisto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picVisto
        '
        Me.picVisto.Image = Global.Formularios_Saavedra.My.Resources.Resources.visto
        Me.picVisto.Location = New System.Drawing.Point(344, 225)
        Me.picVisto.Name = "picVisto"
        Me.picVisto.Size = New System.Drawing.Size(23, 23)
        Me.picVisto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVisto.TabIndex = 49
        Me.picVisto.TabStop = False
        '
        'cbLista
        '
        Me.cbLista.FormattingEnabled = True
        Me.cbLista.Location = New System.Drawing.Point(107, 256)
        Me.cbLista.Name = "cbLista"
        Me.cbLista.Size = New System.Drawing.Size(223, 21)
        Me.cbLista.TabIndex = 48
        '
        'cbItem
        '
        Me.cbItem.FormattingEnabled = True
        Me.cbItem.Location = New System.Drawing.Point(107, 195)
        Me.cbItem.Name = "cbItem"
        Me.cbItem.Size = New System.Drawing.Size(223, 21)
        Me.cbItem.TabIndex = 47
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(173, 168)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(10, 13)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "-"
        '
        'tbPrefijo
        '
        Me.tbPrefijo.Location = New System.Drawing.Point(107, 165)
        Me.tbPrefijo.Name = "tbPrefijo"
        Me.tbPrefijo.Size = New System.Drawing.Size(60, 20)
        Me.tbPrefijo.TabIndex = 45
        '
        'btnCargar
        '
        Me.btnCargar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCargar.ForeColor = System.Drawing.Color.White
        Me.btnCargar.Location = New System.Drawing.Point(220, 312)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(110, 36)
        Me.btnCargar.TabIndex = 44
        Me.btnCargar.Text = "Cargar Cliente"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'btnVender
        '
        Me.btnVender.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnVender.ForeColor = System.Drawing.Color.White
        Me.btnVender.Location = New System.Drawing.Point(107, 312)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(107, 36)
        Me.btnVender.TabIndex = 43
        Me.btnVender.Text = "Vender Formulario"
        Me.btnVender.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(43, 255)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 26)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Lista de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Precios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tbNumero
        '
        Me.tbNumero.Location = New System.Drawing.Point(107, 226)
        Me.tbNumero.Name = "tbNumero"
        Me.tbNumero.Size = New System.Drawing.Size(223, 20)
        Me.tbNumero.TabIndex = 41
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(43, 229)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 13)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Número"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(43, 198)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 13)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Item"
        '
        'tbTelefono
        '
        Me.tbTelefono.Location = New System.Drawing.Point(189, 165)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(141, 20)
        Me.tbTelefono.TabIndex = 38
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(43, 168)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Teléfono"
        '
        'tbDireccion
        '
        Me.tbDireccion.Location = New System.Drawing.Point(107, 135)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(223, 20)
        Me.tbDireccion.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(43, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Dirección"
        '
        'tbDNI
        '
        Me.tbDNI.Location = New System.Drawing.Point(107, 105)
        Me.tbDNI.Name = "tbDNI"
        Me.tbDNI.Size = New System.Drawing.Size(223, 20)
        Me.tbDNI.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(43, 107)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "DNI"
        '
        'tbApellido
        '
        Me.tbApellido.Location = New System.Drawing.Point(107, 75)
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(223, 20)
        Me.tbApellido.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(43, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Apellido"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(107, 43)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(223, 20)
        Me.tbNombre.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(43, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Nombre"
        '
        'tbBuscar
        '
        Me.tbBuscar.Location = New System.Drawing.Point(518, 29)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(271, 20)
        Me.tbBuscar.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(437, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Buscar Cliente"
        '
        'dgvMain
        '
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Location = New System.Drawing.Point(440, 58)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.Size = New System.Drawing.Size(349, 305)
        Me.dgvMain.TabIndex = 26
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.picVisto)
        Me.Controls.Add(Me.cbLista)
        Me.Controls.Add(Me.cbItem)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.tbPrefijo)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.btnVender)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.tbNumero)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.tbTelefono)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.tbDireccion)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tbDNI)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tbApellido)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbBuscar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dgvMain)
        Me.Name = "Inicio"
        Me.Size = New System.Drawing.Size(811, 378)
        CType(Me.picVisto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picVisto As PictureBox
    Friend WithEvents cbLista As ComboBox
    Friend WithEvents cbItem As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tbPrefijo As TextBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnVender As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents tbNumero As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tbDNI As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvMain As DataGridView
End Class
