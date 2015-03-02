Public Class oDealingTable
    'This will be the central point that brings everything else (deck, card, and hand) together
    'Grab the "blueprint" of oDeck and use it to create a working item called deck to be used.
    Public deck As New oDeck
    Public playerHand As New oHand
    Public dealerHand As New oHand

    'Build in method to start getting the game setup
    Public Sub startGame()
        deck.BuildDeck()
        dealCardToPlayer()
        dealCardToPlayer()
        dealCardToDealer()
        dealCardToDealer()
    End Sub

    Public Sub dealCardToPlayer()
        'Add cards to the player and dealer hands to work with.
        playerHand.addCard(deck.DealCard)

    End Sub

    Public Sub dealCardToDealer()
        'Deal cards to the dealer's hand to work with
        dealerHand.addCard(deck.DealCard)
    End Sub

    Public Sub checkPlayerCards()
        If playerHand.CountTotal = 21 Then
            MessageBox.Show("21! You win!")
        ElseIf playerHand.CountTotal >= 22 Then
            MessageBox.Show("You have gone bust. Dealer wins!")
        End If
    End Sub

    Public Sub checkDealerCards()
        If dealerHand.CountTotal = 21 Then
            MessageBox.Show("The dealer has gotten 21.  You lose!")
        ElseIf dealerHand.CountTotal >= 22 Then
            MessageBox.Show("The dealer has gone bust.  You win!")
        End If
    End Sub



End Class
