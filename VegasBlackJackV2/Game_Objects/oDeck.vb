' Deck object to build and array list of what goes into a "deck"
Public Class oDeck
    Public AryCards As New ArrayList

    Public Sub BuildDeck()
        'create variables to hold info / New function used to set memory aside for the object created.
        'without the New function information won't be saved on the item that is created.
        Dim objCreatedCard As New oCard
        Dim intSuit As Integer
        Dim intFace As Integer

        'create a string to run through the cards of oCard and generate the deck, then place info to the
        'arraylist shown above.
        For intSuit = 0 To 3
            For intFace = 1 To 13
                objCreatedCard = New oCard
                objCreatedCard.CardFace = intFace
                objCreatedCard.CardSuit = intSuit
                'add the card to the list (card type) showing the the ()
                AryCards.Add(objCreatedCard)
            Next
        Next

    End Sub

End Class
