Class MainWindow
    Private liveTable As New oDealingTable
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


    End Sub

    Public Sub startGame()
        'This will get the game on the going, linking into the oDealingTable object.
        liveTable.playerHand.clearPlayerHand()
        liveTable.dealerHand.clearDealerHand()
        lstDealerCards.Items.Clear()
        lstPlayerCards.Items.Clear()
        liveTable.startGame()


        'create a counter to work through the player and dealer hands and add them to the listboxes that are being displayed.
        'Create  a listbox which displays other listbox information.  We should be able to see the player and dealer cards in these boxes.
        Dim strCardText As String
        Dim intDefaultCounter As Integer

        For intDefaultCounter = 0 To liveTable.playerHand.newHand.Count - 1
            strCardText = liveTable.playerHand.newHand(intDefaultCounter).ToString
            lstPlayerCards.Items.Add(strCardText)
        Next

        For intDefaultCounter = 0 To liveTable.dealerHand.newHand.Count - 1
            strCardText = liveTable.dealerHand.newHand(intDefaultCounter).ToString
            lstDealerCards.Items.Add(strCardText)
        Next

        'Display the player code information 
        lblPlayerTotal.Content = "Player Total Is: " & liveTable.playerHand.CountTotal()
        lblDealerTotal.Content = "Dealer Total Is: " & liveTable.dealerHand.CountTotal()
    End Sub

    Public Sub playerHit()
        'This will deal another card to the player hand, update the count and repopulate the lstbox for the players cards
        liveTable.dealCardToPlayer()
        lblPlayerTotal.Content = "Player Total Is: " & liveTable.playerHand.CountTotal()
        liveTable.playerHand.PopulateListBox(lstPlayerCards)

    End Sub

    Public Sub dealerHit()
        'This will deal another card to the player hand, update the count and repopulate the lstbox for the players cards
        liveTable.dealCardToDealer()
        lblDealerTotal.Content = "Dealer Total Is: " & liveTable.dealerHand.CountTotal()
        liveTable.dealerHand.PopulateListBox(lstDealerCards)
    End Sub

    Public Sub dealerPlay()
        Do While liveTable.dealerHand.CountTotal() < 17
            dealerHit()
        Loop
        compareHands()
    End Sub

    Public Sub compareHands()
        If liveTable.dealerHand.CountTotal() > liveTable.playerHand.CountTotal() Then
            MessageBox.Show("The dealer has won")
        Else
            MessageBox.Show("You have beaten the dealer!")
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As RoutedEventArgs) Handles btnStart.Click
        startGame()

    End Sub

    Private Sub btnHit_Click(sender As Object, e As RoutedEventArgs) Handles btnHit.Click
        playerHit()
    End Sub

    Private Sub btnStay_Click(sender As Object, e As RoutedEventArgs) Handles btnStay.Click
        dealerPlay()
    End Sub
End Class
