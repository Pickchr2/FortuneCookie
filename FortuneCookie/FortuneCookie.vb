'Christopher Pickens
'RCET0265
'Spring 2023
'Fortune Cookie
'https://github.com/Pickchr2/FortuneCookie.git

Option Explicit On
Option Strict On
Option Compare Text

Imports System

Module FortuneCookie
    Sub Main(args As String())
        Const NUMBEROFFORTUNES As Integer = 10
        Dim fortuneList(NUMBEROFFORTUNES) As String
        Dim chosenFortune As Integer
        Dim randomNumber As New Random()
        Dim userInput As String
        Dim userQuits As Boolean = False

        fortuneList(0) = "Some days you are the pigeon, some days you are the statue. Today, bring an umbrella."
        fortuneList(1) = "To truly find yourself you should play hide and seek alone."
        fortuneList(2) = "Two days from now, tomorrow will be yesterday."
        fortuneList(3) = "You are cleverly disguised as a responsible adult."
        fortuneList(4) = "Ask not what your fortune cookie can do for you, but what you can do for your fortune cookie. "
        fortuneList(5) = "The older you get the better you were."
        fortuneList(6) = "If at first you don?t succeed, skydiving is not for you."
        fortuneList(7) = "One who laughs at themself never runs out of things to laugh at."
        fortuneList(8) = "As long as you don?t sign up for anything new, you?ll do fine."
        fortuneList(9) = "This cookie is never going to give you up, never going to let you down."

        Do Until userQuits = True
            Console.WriteLine("Would you like me to read your fortune? Enter " & Chr(34) & "Y" & Chr(34) & " for yes, or any other key to quit.")
            userInput = Console.ReadLine()
            Select Case userInput
                Case "Y"
                    Console.WriteLine("")
                    chosenFortune = CInt(randomNumber.Next(NUMBEROFFORTUNES))
                    Console.WriteLine(fortuneList(chosenFortune))
                    Console.WriteLine("")
                Case Else
                    userQuits = True
            End Select
        Loop
    End Sub
End Module
