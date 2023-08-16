Public Class Prueba
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        consultar()

    End Sub



    Protected Sub txtIngresar_Click(sender As Object, e As EventArgs) Handles txtIngresar.Click
        Try
            Dim iCarreras As New Negocios.Carreras
            Dim eCarreras As New Entidades.Carreras

            eCarreras.codigo = txtCodigo.Text
            eCarreras.nombre = txtNombre.Text
            eCarreras.grado = txtGrado.Text
            eCarreras.estado = IIf(chkEstado.Checked, 1, 0)

            iCarreras.insertarCarrera(eCarreras)


        Catch ex As Exception

        End Try


    End Sub

    Public Sub consultar()
        Dim iCarreras As New Negocios.Carreras

        gvCarreras.DataSource = iCarreras.consultarCarrera()
        gvCarreras.DataBind()


    End Sub



End Class