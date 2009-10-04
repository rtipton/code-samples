Imports System
Namespace DelegateTest
    Public Delegate Sub TestDelegate(ByVal message As String)

    Class Program
        Public Shared Sub Display(ByVal message As String)
            Console.WriteLine("")
            Console.WriteLine("The string entered is : " + message)
        End Sub

        Shared Sub Main(ByVal args As String())
            '-- Instantiate the delegate
            Dim t As New TestDelegate(AddressOf Display)

            '-- Input some text
            Console.WriteLine("Please enter a string:")
            Dim message As String = Console.ReadLine()

            '-- Invoke the delegate
            t(message)
            Console.ReadLine()
        End Sub
    End Class
End Namespace

