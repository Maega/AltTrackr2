Public Class frmFaux

    Private Sub frmFaux_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        frmHome.Location = Me.Location
        frmHome.Size = Me.Size
    End Sub
End Class