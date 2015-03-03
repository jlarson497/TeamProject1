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

        'Counter to count up the value in the hand by running through each card that is held in the hand.
        For ctrIndexCounter = 0 To newHand.Count - 1
            ctrHandValue = ctrHandValue + CType(newHand.Item(ctrIndexCounter), oCard).Value

        Next

        'Using the code below adjust the Ace to low from high // this would make the statement False.
        If ctrHandValue > 21 And IfAnyAceHigh() = True Then
            'Flip the first high ace to low (1 from 11) // The following code is shorthand for using "Call" which is an optional command.
            FlipAce()

            'Return the Ace information and return the start of this code to run again if there are more Aces.  This will end once
            'we run out of Aces.
            Return CountTotal()
        End If

        Return ctrHandValue

    End Function
    Public Sub ResetAces()
        'Change the Ace's back to high to reset the math - don't want any miscalculations and junk.
        'Variable to hold information
        Dim ctrAceCounter As Integer
        Dim CardVar As oCard

        'If statement to look through the cards in the hand and find the ace.
        For ctrAceCounter = 0 To newHand.Count - 1
            CardVar = CType(newHand.Item(ctrAceCounter), oCard)
            If CardVar.CardFace = CardFaceEnum.Ace Then
                CardVar.bAceHigh = True

            End If
        Next

    End Sub
    Public Sub FlipAce()

        'Variable to hold information
        Dim ctrAceCounter As Integer
        Dim CardVar As oCard

        'If statement to look through the cards in the hand and find the ace.
        For ctrAceCounter = 0 To newHand.Count - 1
            CardVar = CType(newHand.Item(ctrAceCounter), oCard)
            If CardVar.CardFace = CardFaceEnum.Ace And CardVar.bAceHigh Then
                CardVar.bAceHigh = False
                'the return routine will make it so this runs this code once then leave.
                Return
            End If
        Next

    End Sub
    'Create a function to find the Ace in the hand, this will be used to eventually adjust the Ace between 1 and 11.
    Public Function IfAnyAceHigh() As Boolean

        'Variable to hold information
        Dim ctrAceCounter As Integer
        Dim CardVar As oCard

        'If statement to look through the cards in the hand and find the ace.
        For ctrAceCounter = 0 To newHand.Count - 1
            CardVar = CType(newHand.Item(ctrAceCounter), oCard)
            If CardVar.CardFace = CardFaceEnum.Ace And CardVar.bAceHigh Then
                Return True
            End If
        Next

        Return False

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
