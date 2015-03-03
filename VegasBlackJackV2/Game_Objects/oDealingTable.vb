Public Class oDealingTable
    'This will be the central point that brings everything else (deck, card, and hand) together
    'Grab the "blueprint" of oDeck and use it to create a working item called deck to be used.
    Public deck As New oDeck
    Public playerHand As New oHand
    Public dealerHand As New oHand
    'Set constants to be used in all of the coding.
    Public Const cntWinValue As Integer = 21
    Public Const cntDealerHold As Integer = 17

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

        'Check the values and insure that all Aces are the proper values
        playerHand.ResetAces()
    End Sub

    Public Sub dealCardToDealer()
        'Deal cards to the dealer's hand to work with
        dealerHand.addCard(deck.DealCard)

        'Check the values and insure that all Aces are the proper values
        dealerHand.ResetAces()
    End Sub

    Public Function checkPlayerCards()
        If playerHand.CountTotal = cntWinValue Then
            MessageBox.Show("21! You win!")
            Return 1
        ElseIf playerHand.CountTotal > cntWinValue Then
            MessageBox.Show("You have gone bust. Dealer wins!")
            Return 1
        Else
            Return 0
        End If


    End Function

    Public Function checkDealerCards()
        If dealerHand.CountTotal = cntWinValue Then
            MessageBox.Show("The dealer has gotten 21.  You lose!")
            Return 1
        ElseIf dealerHand.CountTotal > cntWinValue Then
            MessageBox.Show("The dealer has gone bust.  You win!")
            Return 1
        Else
            Return 0
        End If

    End Function

End Class
