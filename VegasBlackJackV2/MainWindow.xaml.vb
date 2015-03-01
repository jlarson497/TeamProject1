Class MainWindow
    Private liveTable As New oDealingTable
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


    End Sub

    Private Sub btnStart_Click(sender As Object, e As RoutedEventArgs) Handles btnStart.Click
        'This will get the game on the going, linking into the oDealingTable object.
        liveTable.startGame()

        'create a counter to work through the player and dealer hands and add them to the listboxes that are being displayed.
        'Create  a listbox which displays other listbox information.  We should be able to see the player and dealer cards in these boxes.
        Dim strCardText As String
        Dim intDefaultCounter As Integer

        For intDefaultCounter = 0 To liveTable.playerHand.newHand.Count - 1
            strCardText = liveTable.playerHand.newHand(intDefaultCounter).ToString
            lstPlayerCards.Items.Add(strCardText)
        Next

        'Display the player code information 
        lblPlayerTotal.Content = "Player Total Is: " & liveTable.playerHand.CountTotal()



    End Sub
End Class
