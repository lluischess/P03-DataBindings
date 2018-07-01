<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.existe = New System.Windows.Forms.Button()
        Me.buscarid = New System.Windows.Forms.TextBox()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.Button()
        Me.ultimo = New System.Windows.Forms.Button()
        Me.siguiente = New System.Windows.Forms.Button()
        Me.anterior = New System.Windows.Forms.Button()
        Me.primero = New System.Windows.Forms.Button()
        Me.buscar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.actualizar = New System.Windows.Forms.Button()
        Me.crear = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.User = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pais = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Postal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Estado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.direc2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.direc1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.apell = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'existe
        '
        Me.existe.Location = New System.Drawing.Point(440, 83)
        Me.existe.Margin = New System.Windows.Forms.Padding(2)
        Me.existe.Name = "existe"
        Me.existe.Size = New System.Drawing.Size(39, 24)
        Me.existe.TabIndex = 72
        Me.existe.Text = "?"
        Me.existe.UseVisualStyleBackColor = True
        Me.existe.Visible = False
        '
        'buscarid
        '
        Me.buscarid.Location = New System.Drawing.Point(21, 178)
        Me.buscarid.Margin = New System.Windows.Forms.Padding(2)
        Me.buscarid.Name = "buscarid"
        Me.buscarid.Size = New System.Drawing.Size(108, 20)
        Me.buscarid.TabIndex = 71
        '
        'cancelar
        '
        Me.cancelar.Location = New System.Drawing.Point(509, 97)
        Me.cancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(99, 61)
        Me.cancelar.TabIndex = 70
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        Me.cancelar.Visible = False
        '
        'guardar
        '
        Me.guardar.Location = New System.Drawing.Point(509, 34)
        Me.guardar.Margin = New System.Windows.Forms.Padding(2)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(99, 61)
        Me.guardar.TabIndex = 69
        Me.guardar.Text = "Guardar"
        Me.guardar.UseVisualStyleBackColor = True
        Me.guardar.Visible = False
        '
        'ultimo
        '
        Me.ultimo.Location = New System.Drawing.Point(456, 174)
        Me.ultimo.Margin = New System.Windows.Forms.Padding(2)
        Me.ultimo.Name = "ultimo"
        Me.ultimo.Size = New System.Drawing.Size(43, 24)
        Me.ultimo.TabIndex = 68
        Me.ultimo.Text = ">>"
        Me.ultimo.UseVisualStyleBackColor = True
        '
        'siguiente
        '
        Me.siguiente.Location = New System.Drawing.Point(409, 174)
        Me.siguiente.Margin = New System.Windows.Forms.Padding(2)
        Me.siguiente.Name = "siguiente"
        Me.siguiente.Size = New System.Drawing.Size(43, 24)
        Me.siguiente.TabIndex = 67
        Me.siguiente.Text = ">"
        Me.siguiente.UseVisualStyleBackColor = True
        '
        'anterior
        '
        Me.anterior.Location = New System.Drawing.Point(362, 174)
        Me.anterior.Margin = New System.Windows.Forms.Padding(2)
        Me.anterior.Name = "anterior"
        Me.anterior.Size = New System.Drawing.Size(43, 24)
        Me.anterior.TabIndex = 66
        Me.anterior.Text = "<"
        Me.anterior.UseVisualStyleBackColor = True
        '
        'primero
        '
        Me.primero.Location = New System.Drawing.Point(315, 174)
        Me.primero.Margin = New System.Windows.Forms.Padding(2)
        Me.primero.Name = "primero"
        Me.primero.Size = New System.Drawing.Size(43, 24)
        Me.primero.TabIndex = 65
        Me.primero.Text = "<<"
        Me.primero.UseVisualStyleBackColor = True
        '
        'buscar
        '
        Me.buscar.Location = New System.Drawing.Point(133, 176)
        Me.buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(89, 23)
        Me.buscar.TabIndex = 64
        Me.buscar.Text = "Buscar por ID"
        Me.buscar.UseVisualStyleBackColor = True
        '
        'eliminar
        '
        Me.eliminar.Location = New System.Drawing.Point(196, 216)
        Me.eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(88, 55)
        Me.eliminar.TabIndex = 63
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'actualizar
        '
        Me.actualizar.Location = New System.Drawing.Point(104, 216)
        Me.actualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.actualizar.Name = "actualizar"
        Me.actualizar.Size = New System.Drawing.Size(88, 55)
        Me.actualizar.TabIndex = 62
        Me.actualizar.Text = "Actualizar"
        Me.actualizar.UseVisualStyleBackColor = True
        '
        'crear
        '
        Me.crear.Location = New System.Drawing.Point(12, 216)
        Me.crear.Margin = New System.Windows.Forms.Padding(2)
        Me.crear.Name = "crear"
        Me.crear.Size = New System.Drawing.Size(88, 55)
        Me.crear.TabIndex = 61
        Me.crear.Text = "Nuevo Miembro"
        Me.crear.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(232, 111)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Contraseña"
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(333, 109)
        Me.pass.Margin = New System.Windows.Forms.Padding(2)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.ReadOnly = True
        Me.pass.Size = New System.Drawing.Size(103, 20)
        Me.pass.TabIndex = 59
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(232, 88)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Nombre de usuario"
        '
        'User
        '
        Me.User.Location = New System.Drawing.Point(333, 86)
        Me.User.Margin = New System.Windows.Forms.Padding(2)
        Me.User.Name = "User"
        Me.User.ReadOnly = True
        Me.User.Size = New System.Drawing.Size(103, 20)
        Me.User.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(232, 66)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Pais"
        '
        'pais
        '
        Me.pais.Location = New System.Drawing.Point(333, 63)
        Me.pais.Margin = New System.Windows.Forms.Padding(2)
        Me.pais.Name = "pais"
        Me.pais.ReadOnly = True
        Me.pais.Size = New System.Drawing.Size(103, 20)
        Me.pais.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(232, 43)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Código postal"
        '
        'Postal
        '
        Me.Postal.Location = New System.Drawing.Point(333, 40)
        Me.Postal.Margin = New System.Windows.Forms.Padding(2)
        Me.Postal.Name = "Postal"
        Me.Postal.ReadOnly = True
        Me.Postal.Size = New System.Drawing.Size(103, 20)
        Me.Postal.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(232, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Estado"
        '
        'Estado
        '
        Me.Estado.Location = New System.Drawing.Point(333, 18)
        Me.Estado.Margin = New System.Windows.Forms.Padding(2)
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Size = New System.Drawing.Size(103, 20)
        Me.Estado.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 111)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Dirección 2"
        '
        'direc2
        '
        Me.direc2.Location = New System.Drawing.Point(107, 109)
        Me.direc2.Margin = New System.Windows.Forms.Padding(2)
        Me.direc2.Name = "direc2"
        Me.direc2.ReadOnly = True
        Me.direc2.Size = New System.Drawing.Size(103, 20)
        Me.direc2.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 89)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Dirección 1"
        '
        'direc1
        '
        Me.direc1.Location = New System.Drawing.Point(107, 86)
        Me.direc1.Margin = New System.Windows.Forms.Padding(2)
        Me.direc1.Name = "direc1"
        Me.direc1.ReadOnly = True
        Me.direc1.Size = New System.Drawing.Size(103, 20)
        Me.direc1.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 66)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Apellido"
        '
        'apell
        '
        Me.apell.Location = New System.Drawing.Point(107, 63)
        Me.apell.Margin = New System.Windows.Forms.Padding(2)
        Me.apell.Name = "apell"
        Me.apell.ReadOnly = True
        Me.apell.Size = New System.Drawing.Size(103, 20)
        Me.apell.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Nombre"
        '
        'nom
        '
        Me.nom.Location = New System.Drawing.Point(107, 41)
        Me.nom.Margin = New System.Windows.Forms.Padding(2)
        Me.nom.Name = "nom"
        Me.nom.ReadOnly = True
        Me.nom.Size = New System.Drawing.Size(103, 20)
        Me.nom.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "ID"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(107, 18)
        Me.id.Margin = New System.Windows.Forms.Padding(2)
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(103, 20)
        Me.id.TabIndex = 41
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(Me.existe)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.nom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.apell)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.direc1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.direc2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Estado)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Postal)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.pass)
        Me.GroupBox1.Controls.Add(Me.pais)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.User)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 157)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dadas dels Membres"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 291)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.buscarid)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.guardar)
        Me.Controls.Add(Me.ultimo)
        Me.Controls.Add(Me.siguiente)
        Me.Controls.Add(Me.anterior)
        Me.Controls.Add(Me.primero)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.eliminar)
        Me.Controls.Add(Me.actualizar)
        Me.Controls.Add(Me.crear)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents existe As Button
    Friend WithEvents buscarid As TextBox
    Friend WithEvents cancelar As Button
    Friend WithEvents guardar As Button
    Friend WithEvents ultimo As Button
    Friend WithEvents siguiente As Button
    Friend WithEvents anterior As Button
    Friend WithEvents primero As Button
    Friend WithEvents buscar As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents actualizar As Button
    Friend WithEvents crear As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents pass As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents User As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pais As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Postal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Estado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents direc2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents direc1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents apell As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents id As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
