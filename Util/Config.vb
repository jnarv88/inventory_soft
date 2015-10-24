Namespace util
    Public Class Config

        Sub configGrid(ByVal data As DataGridView)
            For i As Integer = 0 To data.Columns.Count - 1
                data.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
        End Sub

    End Class
End Namespace

