'Card object of what makes a card.  use "oCard" to to better know when calling the object. 
Public Class oCard
    Public CardSuit As SuitEnum
    Public CardFace As CardFaceEnum
    Public bAceLow As Boolean = False
    'sample function of how to handle Ace as Ace can be 1 and/or 11 depending on situation.
    'Further coding around Ace will be applied later.  This is subject to change
    Public Function Value() As Integer
        If CardFace = CardFaceEnum.Ace Then
            If bAceLow Then Return 1
        End If
        Return CardFace
    End Function

End Class
'Basic enum to set the suit
Public Enum SuitEnum
    Heart = 0
    Diamond = 1
    Club = 2
    Spade = 3
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
