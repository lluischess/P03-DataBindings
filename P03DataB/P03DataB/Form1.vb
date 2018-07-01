Imports System.Data.SqlClient

Public Class Form1
    Private con As SqlConnection
    Private dts As DataSet
    Private ada As SqlDataAdapter
    Private bmb As BindingManagerBase

    Dim Cambio = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con = New SqlConnection
        con.ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=COMPASSTRAVEL; Trusted_Connection=True;"
        con.Open()
        ada = New SqlDataAdapter("select * from MEMBERS order by MEMBERID", con)
        Dim cmBase As SqlCommandBuilder = New SqlCommandBuilder(ada)
        dts = New DataSet()
        ada.Fill(dts, "Members")


        AddHandler dts.Tables("Members").ColumnChanging, New DataColumnChangeEventHandler(AddressOf OnColumnChanging)
        AddHandler dts.Tables("Members").RowChanging, New DataRowChangeEventHandler(AddressOf OnRowChanging)

        ConstruirDataBinding()


    End Sub

    Private Sub OnColumnChanging(sender As Object, e As DataColumnChangeEventArgs)

        If (e.Column.ColumnName = "PASSWORD") Then
            If pass.Text.Count < 4 Then
                MsgBox("La Contraseña tiene que tener 4 - 8 letras")
                pass.Text = ""
                pass.Select()
            ElseIf pass.Text.Count <= 8 Then
                MsgBox("Es recomendable que la contraseña sea mayor que 8 letras")

            End If
        End If


        ' Miramos si el usuario existe
        If (e.Column.ColumnName = "USERNAME") Then
            Dim Buscar
            Dim userB
            Dim encontrado = False

            Buscar = User.Text

            For index As Integer = 0 To dts.Tables("Members").Rows.Count - 1
                userB = dts.Tables("Members").Rows(index)("USERNAME").ToString()
                If Buscar.Equals(userB) Then
                    encontrado = True
                    If encontrado = True Then
                        MsgBox("El nombre de usuario ya existe")
                        User.Text = ""
                    End If
                End If
            Next

        End If

    End Sub

    Private Sub OnRowChanging(sender As Object, e As DataRowChangeEventArgs)

    End Sub

    Private Sub ConstruirDataBinding()
        Dim oBind As Binding

        oBind = New Binding("Text", dts, "Members.MemberId")
        id.DataBindings.Add(oBind)
        oBind = Nothing

        oBind = New Binding("Text", dts, "Members.FirstName")
        nom.DataBindings.Add(oBind)
        oBind = Nothing

        oBind = New Binding("Text", dts, "Members.LastName")
        apell.DataBindings.Add(oBind)
        oBind = Nothing

        oBind = New Binding("Text", dts, "Members.Address1")
        direc1.DataBindings.Add(oBind)
        oBind = Nothing

        oBind = New Binding("Text", dts, "Members.Address2")
        direc2.DataBindings.Add(oBind)
        oBind = Nothing

        oBind = New Binding("Text", dts, "Members.State")
        Estado.DataBindings.Add(oBind)
        oBind = Nothing

        oBind = New Binding("Text", dts, "Members.PostalCode")
        Postal.DataBindings.Add(oBind)
        oBind = Nothing

        oBind = New Binding("Text", dts, "Members.Country")
        pais.DataBindings.Add(oBind)
        oBind = Nothing

        oBind = New Binding("Text", dts, "Members.UserName")
        User.DataBindings.Add(oBind)
        oBind = Nothing

        oBind = New Binding("Text", dts, "Members.Password")
        pass.DataBindings.Add(oBind)
        oBind = Nothing
        bmb = BindingContext(dts, "Members")
    End Sub

    Private Sub crear_Click(sender As Object, e As EventArgs) Handles crear.Click
        crear.Visible = False
        actualizar.Visible = False
        eliminar.Visible = False
        primero.Enabled = False
        anterior.Enabled = False
        siguiente.Enabled = False
        ultimo.Enabled = False
        'mostrar campos
        guardar.Visible = True
        cancelar.Visible = True
        existe.Visible = True
        'solo lectura
        nom.ReadOnly = False
        apell.ReadOnly = False
        direc1.ReadOnly = False
        direc2.ReadOnly = False
        Estado.ReadOnly = False
        Postal.ReadOnly = False
        pais.ReadOnly = False
        User.ReadOnly = False
        pass.ReadOnly = False

        bmb.AddNew()

    End Sub

    Private Sub actualizar_Click(sender As Object, e As EventArgs) Handles actualizar.Click
        crear.Visible = False
        actualizar.Visible = False
        eliminar.Visible = False
        primero.Enabled = False
        anterior.Enabled = False
        siguiente.Enabled = False
        ultimo.Enabled = False
        'mostrar campos
        guardar.Visible = True
        cancelar.Visible = True
        existe.Visible = True
        'solo lectura
        nom.ReadOnly = False
        apell.ReadOnly = False
        direc1.ReadOnly = False
        direc2.ReadOnly = False
        Estado.ReadOnly = False
        Postal.ReadOnly = False
        pais.ReadOnly = False
        User.ReadOnly = False
        pass.ReadOnly = False
    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click

        bmb.RemoveAt(bmb.Position)
        Dim dt As DataTable
        dt = dts.Tables("Members").GetChanges()
        If IsNothing(dt) Then
            MsgBox("No hay cambios para guardar")
        Else
            ada.Update(dt)
        End If
        dts.Tables("Members").AcceptChanges()
    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        bmb.EndCurrentEdit()
        crear.Visible = True
        actualizar.Visible = True
        eliminar.Visible = True
        primero.Enabled = True
        anterior.Enabled = True
        siguiente.Enabled = True
        ultimo.Enabled = True
        'Amagar campos
        guardar.Visible = False
        cancelar.Visible = False
        existe.Visible = False
        'solo lectura
        nom.ReadOnly = True
        apell.ReadOnly = True
        direc1.ReadOnly = True
        direc2.ReadOnly = True
        Estado.ReadOnly = True
        Postal.ReadOnly = True
        pais.ReadOnly = True
        User.ReadOnly = True
        pass.ReadOnly = True


        If nom.Text = "" Then
            MsgBox("Almenos pon un nombre")

        ElseIf User.Text = "" Then
            MsgBox("Almenos pon un nombre de usuario")

        End If

        Dim dt As DataTable
        dt = dts.Tables("Members").GetChanges()
        If IsNothing(dt) Then
            MsgBox("No hay cambios para guardar")
        Else
            ada.Update(dt)
        End If
        dts.Tables("Members").AcceptChanges()
    End Sub

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        bmb.CancelCurrentEdit()
        crear.Visible = True
        actualizar.Visible = True
        eliminar.Visible = True
        primero.Enabled = True
        anterior.Enabled = True
        siguiente.Enabled = True
        ultimo.Enabled = True
        'Amagar campos
        guardar.Visible = False
        cancelar.Visible = False
        existe.Visible = False
        'solo lectura
        nom.ReadOnly = True
        apell.ReadOnly = True
        direc1.ReadOnly = True
        direc2.ReadOnly = True
        Estado.ReadOnly = True
        Postal.ReadOnly = True
        pais.ReadOnly = True
        User.ReadOnly = True
        pass.ReadOnly = True
    End Sub

    Private Sub primero_Click(sender As Object, e As EventArgs) Handles primero.Click
        bmb.Position = 0
    End Sub

    Private Sub anterior_Click(sender As Object, e As EventArgs) Handles anterior.Click
        bmb.Position = bmb.Position - 1
    End Sub

    Private Sub siguiente_Click(sender As Object, e As EventArgs) Handles siguiente.Click
        bmb.Position = bmb.Position + 1
    End Sub

    Private Sub ultimo_Click(sender As Object, e As EventArgs) Handles ultimo.Click
        bmb.Position = bmb.Count - 1
    End Sub

    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        Dim idb
        Dim idT
        Dim encontrado = False

        idb = buscarid.Text

        For index As Integer = 0 To dts.Tables("Members").Rows.Count - 1
            idT = dts.Tables("Members").Rows(index)("MEMBERID").ToString()
            If idb.Equals(idT) Then
                encontrado = True
                bmb.Position = index

            End If
        Next
        If encontrado = False Then
            MsgBox("La id no existe")
        End If
    End Sub

    Private Sub existe_Click(sender As Object, e As EventArgs) Handles existe.Click
        Dim nom1 As String = nom.Text.Substring(0, 3)
        Dim app As String = apell.Text.Substring(apell.TextLength - 3)
        Dim username As String = nom1 & app

        User.Text = username
        User.Select()

    End Sub
End Class
