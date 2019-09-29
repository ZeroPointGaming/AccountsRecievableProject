Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class SerializationWrapper

    Public Sub SerializeAccounts(Stream As FileStream, Acts As Accounts)
        Dim BinarySerializationAgent As New BinaryFormatter
        BinarySerializationAgent.Serialize(Stream, Acts)
        Stream.Close()
        Stream.Dispose()
    End Sub

    Public Function DeserializeAccounts(Stream As FileStream)
        Dim BinarySerializationAgent As New BinaryFormatter
        Dim ObjRet As New Accounts
        ObjRet = BinarySerializationAgent.Deserialize(Stream)
        Stream.Close()
        Stream.Dispose()
        Return ObjRet
    End Function
End Class


<Serializable>
Public Class Accounts
    Public Accounts As Dictionary(Of String, Account)
End Class

<Serializable>
Public Class Account
    Public Name As String = ""
    Public AccountNumnber As Integer = 0
    Public CreditAmmount As Integer = 0
    Public DebtAmmount As Integer = 0
    Public Payments As New Dictionary(Of String, Payment)
End Class

<Serializable>
Public Class Payment
    Public PaymentAmmount As Double = 0
    Public PaymentDate As String = ""
    Public PaymentID As String = ""
End Class