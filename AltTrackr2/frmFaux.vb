Public Class frmFaux
    Private Sub frmFaux_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmFaux_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        frmHome.Location = Me.Location
        frmHome.Size = Me.Size
    End Sub
End Class