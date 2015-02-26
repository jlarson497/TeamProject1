Public Class oDealingTable
    'This will be the central point that brings everything else (deck, card, and hand) together
    'Grab the "blueprint" of oDeck and use it to create a working item called deck to be used.
    Public deck As New oDeck
    Public playerHand As New oHand
    Public dealerHand As New oHand

    'Build in method to start getting the game setup
    Public Sub startGame()
        deck.BuildDeck()
    End Sub

    Public Sub dealCardToPlayer()
        'And I broke it and don't know how to fix it....
        playerHand.addCard(deck.AryCards(0))
    End Sub

End Class
