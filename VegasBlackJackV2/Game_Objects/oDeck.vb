' Deck object to build and array list of what goes into a "deck"
Public Class oDeck
    Private AryCards As New ArrayList

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
    Public Function DealCard() As oCard
        'variables to handle storing information
        Dim ODeltCard As oCard
        Dim intRandomCard As Integer

        'Create a random number(card) generator. // intRandomCard is = a random number between 0(1) 
        'and the rest of the cards in the list -1.
        Dim Generator As System.Random = New System.Random()
        intRandomCard = Generator.Next(0, AryCards.Count - 1)

        'Pull a card from the deck then remove it from the arraylist to insure we don't have duplicate.
        ODeltCard = AryCards.Item(intRandomCard)
        AryCards.Remove(ODeltCard)

        'Return the pulled card to wherever this will be used.
        Return ODeltCard
    End Function

End Class
