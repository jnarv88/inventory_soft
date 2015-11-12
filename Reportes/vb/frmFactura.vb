'Imports System.Drawing.Printing
'Imports System.Drawing.Imaging
'Imports System.IO
'Imports Microsoft.Reporting.WinForms
Public Class frmFactura
    'Private m_currentPageIndex As Integer
    'Private m_streams As IList(Of Stream)

    'Private Sub ReportViewer1_Print(ByVal sender As System.Object, ByVal e As Microsoft.Reporting.WinForms.ReportPrintEventArgs) Handles ReportViewer1.Print
    '    Me.Close()
    'End Sub

   
    'Private Sub PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
    '    Dim pageImage As New Metafile(m_streams(m_currentPageIndex))

    '    ' Adjust rectangular area with printer margins.
    '    Dim adjustedRect As New Rectangle(ev.PageBounds.Left - CInt(ev.PageSettings.HardMarginX), _
    '                                      ev.PageBounds.Top - CInt(ev.PageSettings.HardMarginY), _
    '                                      ev.PageBounds.Width, _
    '                                      ev.PageBounds.Height)

    '    ' Draw a white background for the report
    '    ev.Graphics.FillRectangle(Brushes.White, adjustedRect)

    '    ' Draw the report content
    '    ev.Graphics.DrawImage(pageImage, adjustedRect)

    '    ' Prepare for the next page. Make sure we haven't hit the end.
    '    m_currentPageIndex += 1
    '    ev.HasMorePages = (m_currentPageIndex < m_streams.Count)
    'End Sub

    'Private Sub Print()
    '    If m_streams Is Nothing OrElse m_streams.Count = 0 Then
    '        Throw New Exception("Error: no stream to print.")
    '    End If
    '    Dim printDoc As New PrintDocument()
    '    If Not printDoc.PrinterSettings.IsValid Then
    '        Throw New Exception("Error: cannot find the default printer.")
    '    Else
    '        AddHandler printDoc.PrintPage, AddressOf PrintPage
    '        m_currentPageIndex = 0
    '        printDoc.Print()
    '    End If
    'End Sub

    'Private Sub frmFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    '    Me.ReportViewer1.PrintDialog()
    'End Sub
End Class