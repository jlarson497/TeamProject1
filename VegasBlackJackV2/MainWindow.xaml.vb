Class MainWindow
    Private liveTable As New oDealingTable
    'Set constants to be used in all of the coding.
    Public Const cntWinValue As Integer = 21
    Public Const cntDealerHold As Integer = 17

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

    End Sub

    Public Sub startGame()
        'This will get the game on the going, linking into the oDealingTable object.
        btnHit.IsEnabled = True
        btnStay.IsEnabled = True
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
        If liveTable.checkPlayerCards() = 1 Then
            btnHit.IsEnabled = False

        End If

    End Sub

    Public Sub playerHit()
        'This will deal another card to the player hand, update the count and repopulate the lstbox for the players cards
        liveTable.dealCardToPlayer()
        lblPlayerTotal.Content = "Player Total Is: " & liveTable.playerHand.CountTotal()
        liveTable.playerHand.PopulateListBox(lstPlayerCards)
        If liveTable.checkPlayerCards() = 1 Then
            btnHit.IsEnabled = False
            btnStay.IsEnabled = False
        End If

        If liveTable.checkDealerCards() = 1 Then
            btnHit.IsEnabled = False
            btnStay.IsEnabled = False
        End If

    End Sub

    Public Sub dealerHit()
        'This will deal another card to the player hand, update the count and repopulate the lstbox for the players cards
        liveTable.dealCardToDealer()
        lblDealerTotal.Content = "Dealer Total Is: " & liveTable.dealerHand.CountTotal()
        liveTable.dealerHand.PopulateListBox(lstDealerCards)
    End Sub

    Public Sub dealerPlay()
        Do While liveTable.dealerHand.CountTotal() < cntDealerHold
            dealerHit()
        Loop
        liveTable.checkDealerCards()
        If liveTable.dealerHand.CountTotal() < cntWinValue Then
            compareHands()
            btnHit.IsEnabled = False
            btnStay.IsEnabled = False
        End If

    End Sub

    Public Sub compareHands()
        If liveTable.dealerHand.CountTotal() >= liveTable.playerHand.CountTotal() Then
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
    'Add a help button to guide the user on how to better play the game.  Yey BlackJack!
    Private Sub btnHelp_Click(sender As Object, e As RoutedEventArgs) Handles btnHelp.Click
        MessageBox.Show("To start the game, press ""Start Game"" in the top center of the screen", "Help #1")
        MessageBox.Show("After cards are dealt if you want another card press ""Hit"" and press ""Stand"" when you're done.  Try not to go over 21!", "Help #2")
        MessageBox.Show("The dealer will then get cards to play, if the dealer gets 21 it wins.  If the dealer goes over 21, you win.  If the dealer beats your score it wins.", "Help #3")
        MessageBox.Show("Good luck!", "It's All You Now!")
    End Sub
End Class
