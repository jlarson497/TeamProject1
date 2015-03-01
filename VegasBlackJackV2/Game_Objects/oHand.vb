Public Class oHand
    'Create an arraylist to show and hold information of what goes into a hand.
    Public newHand As New ArrayList

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


    Public Sub PopulateListBox(ByRef lstCards As ListBox)
        'create a counter to work through the player and dealer hands and add them to the listboxes that are being displayed.
        'Create a listbox which displays other listbox information. We should be able to see the player and dealer cards in these boxes.
        Dim strCardText As String
        Dim intDefaultCounter As Integer
        'Refresh or otherwise clear the current listboxes - don't want to repeat already stated info.
        lstCards.Items.Clear()
        'Show the card information in the hands.
        For intDefaultCounter = 0 To newHand.Count - 1
            strCardText = newHand(intDefaultCounter).ToString
            lstCards.Items.Add(strCardText)
        Next
    End Sub

    Public Sub clearPlayerHand()
        newHand.Clear()
    End Sub

    Public Sub clearDealerHand()
        newHand.Clear()
    End Sub

End Class
