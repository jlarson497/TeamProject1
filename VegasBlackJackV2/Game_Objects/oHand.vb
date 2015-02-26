Public Class oHand
    'Create an arraylist to show and hold information of what goes into a hand.
    Private newHand As New ArrayList

    'Created a method to put a card into the hand (both player and dealer) 
    Public Sub addCard(ByVal Card As oCard)
        newHand.Add(Card)
    End Sub

    'Function to count the value total in the hand then return the total
    Public Function CountTotal() As Integer
        Dim ctrHandValue As Integer
        Dim ctrIndexCounter As Integer

        'Counter to count up the value in the hand by checki...
        For ctrIndexCounter = 0 To newHand.Count - 1
            ctrHandValue = ctrHandValue + CType(newHand.Item(ctrIndexCounter), oCard).Value
        Next

        Return ctrHandValue

    End Function

End Class
