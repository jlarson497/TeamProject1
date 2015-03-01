'Card object of what makes a card.  use "oCard" to to better know when calling the object. 
Public Class oCard
    Public CardSuit As SuitEnum
    Public CardFace As CardFaceEnum
    Public bAceHigh As Boolean = True
    'sample function of how to handle Ace as Ace can be 1 and/or 11 depending on situation.
    'Further coding around Ace will be applied later.  This is subject to change
    Public Function Value() As Integer
        If CardFace = CardFaceEnum.Ace Then
            If bAceHigh = True Then
                Return 11
            Else
                Return 1
            End If
        End If
        If CardFace = CardFaceEnum.King Then Return 10
        If CardFace = CardFaceEnum.Queen Then Return 10
        If CardFace = CardFaceEnum.Jack Then Return 10
        Return CardFace
    End Function

    Public Overrides Function ToString() As String
        Return (CardFace.ToString & " of " & CardSuit.ToString)
    End Function

End Class
'Basic enum to set the suit
Public Enum SuitEnum
    Hearts = 0
    Diamonds = 1
    Clubs = 2
    Spades = 3
End Enum
'Basic enum to set the cards and their respective values.
Public Enum CardFaceEnum
    Ace = 1
    Two = 2
    Three = 3
    Four = 4
    Five = 5
    Six = 6
    Seven = 7
    Eight = 8
    Nine = 9
    Ten = 10
    Jack = 11
    Queen = 12
    King = 13
End Enum
