Class MainWindow
    Private liveTable As New oDealingTable


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        liveTable.startGame()
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        'Functions that happen when the "Hit" option is clicked.  first set variables
        liveTable.dealCardToPlayer()
    End Sub
End Class
