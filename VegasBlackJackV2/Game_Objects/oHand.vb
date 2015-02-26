Public Class oHand
    'Create an arraylist to show and hold information of what goes into a hand.
    Public newHand As New ArrayList

    'Created a method to put a card into the hand (both player and dealer) 
    Public Sub addCard(ByVal Card As oCard)
        newHand.Add(Card)

    End Sub

End Class
