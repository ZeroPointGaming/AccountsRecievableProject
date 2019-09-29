Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class Form1
    Private AccountsFile As String = Directory.GetCurrentDirectory + "\Accounts.bin"
    Private AccountManager As New Accounts
    Private SerializationManager As New BinaryFormatter
    Private LocalAccounts As New Dictionary(Of String, Account)
    Private LocalAccoutnManager As New Accounts With {.Accounts = LocalAccounts}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAccounts()
    End Sub

    Private Sub ResetForm()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        AccountNameTxt.Text = ""
        NewAccountNameTxt.Text = ""
        AddPaymentTxt.Text = ""
        AddIntrestTxt.Text = ""
        AddDebtTxt.Text = ""
        LastPayDateTxt.Text = ""
        LastPaymentTxt.Text = ""
        AmmountOwedTxt.Text = ""
        LocalAccounts.Clear()
    End Sub

    Private Sub LoadAccounts()
        ResetForm()

        If Not File.Exists(AccountsFile) Then
            Dim StreamManager As New FileStream(AccountsFile, FileMode.OpenOrCreate)
            MessageBox.Show("Accounts file does not exist, creating it now!")

            StreamManager.Close()
            StreamManager.Dispose()

        Else
            Dim StreamManager As New FileStream(AccountsFile, FileMode.Open)
            Try
                LocalAccoutnManager = SerializationManager.Deserialize(StreamManager)
                LocalAccounts = LocalAccoutnManager.Accounts

                For Each account In LocalAccounts
                    ListBox1.Items.Add(account.Key.ToString())
                Next

                StreamManager.Close()
                StreamManager.Dispose()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub SaveAccounts()
        'Calc totals
        For Each account In LocalAccoutnManager.Accounts
            Dim total As Integer = 0

            For Each payment In account.Value.Payments
                total += payment.Value.PaymentAmmount
            Next

            account.Value.DebtAmmount = total
        Next

        'save
        If Not File.Exists(AccountsFile) Then
            Dim StreamManager As New FileStream(AccountsFile, FileMode.OpenOrCreate)
            MessageBox.Show("Accounts file does not exist, creating it now!")

            StreamManager.Close()
            StreamManager.Dispose()
        Else
            Dim StreamManager As New FileStream(AccountsFile, FileMode.Open)
            Try
                SerializationManager.Serialize(StreamManager, LocalAccoutnManager)
            Catch ex As Exception

            End Try
            StreamManager.Close()
            StreamManager.Dispose()
        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveAccounts()
    End Sub

    Private Sub LoadBtn_Click(sender As Object, e As EventArgs) Handles LoadBtn.Click
        LoadAccounts()
    End Sub

    Private Sub DeleteLastPaymentBtn_Click(sender As Object, e As EventArgs) Handles DeleteLastPaymentBtn.Click
        If ListBox2.Items.Count = 0 Then
            MsgBox("No payment to remove.")
        Else
            Try
                LocalAccounts(ListBox1.SelectedItem.ToString()).Payments.Remove(LocalAccounts(ListBox1.SelectedItem.ToString()).Payments.LastOrDefault.Key.ToString())
                ListBox2.Items.RemoveAt(ListBox2.Items.Count - 1)

                If Not LocalAccounts(ListBox1.SelectedItem.ToString()).Payments.Count = 0 Then
                    LastPayDateTxt.Text = LocalAccounts(ListBox1.SelectedItem.ToString()).Payments.LastOrDefault.Value.PaymentDate.ToString()
                    LastPaymentTxt.Text = LocalAccounts(ListBox1.SelectedItem.ToString()).Payments.LastOrDefault.Value.PaymentAmmount.ToString()
                Else
                    LastPayDateTxt.Text = ""
                    LastPaymentTxt.Text = ""
                End If

                If My.Settings.Autosave = True Then
                    SaveAccounts()
                End If
            Catch ex As Exception
                MsgBox("Error removing last payment.")
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub AddIntrestBtn_Click(sender As Object, e As EventArgs) Handles AddIntrestBtn.Click
        If Not AddIntrestTxt.Text = "" Then
            Try
                LocalAccounts(ListBox1.SelectedItem.ToString).DebtAmmount += LocalAccounts(ListBox1.SelectedItem.ToString).DebtAmmount * Convert.ToDouble(AddIntrestTxt.Text)
                AmmountOwedTxt.Text = LocalAccounts(ListBox1.SelectedItem.ToString).DebtAmmount.ToString
            Catch ex As Exception

            End Try
        End If

        If My.Settings.Autosave = True Then
            SaveAccounts()
        End If

        AddIntrestTxt.Text = ""
    End Sub

    Private Sub AddPaymentBtn_Click(sender As Object, e As EventArgs) Handles AddPaymentBtn.Click
        If ListBox1.SelectedItem Is Nothing Then

        Else
            Try
                Dim Invoice As New Payment With {
                .PaymentAmmount = Convert.ToDouble(AddPaymentTxt.Text),
                .PaymentDate = DateAndTime.DateString.ToString(),
                .PaymentID = "" 'Hash the date+ammount with sha1?
                }

                If Not LocalAccounts(ListBox1.SelectedItem.ToString()).Payments.ContainsKey(Invoice.PaymentAmmount) Then
                    LocalAccounts(ListBox1.SelectedItem.ToString()).Payments.Add(Invoice.PaymentAmmount, Invoice)
                    ListBox2.Items.Add("Payment Date: " + Invoice.PaymentDate + "   " + "Payment Ammount: " + Invoice.PaymentAmmount.ToString())
                    LocalAccounts(ListBox1.SelectedItem.ToString()).DebtAmmount += Invoice.PaymentAmmount
                    AmmountOwedTxt.Text = LocalAccounts(ListBox1.SelectedItem.ToString()).DebtAmmount.ToString()
                    LastPaymentTxt.Text = Invoice.PaymentAmmount
                    LastPayDateTxt.Text = Invoice.PaymentDate
                    AddPaymentTxt.Text = ""
                End If

                If My.Settings.Autosave = True Then
                    SaveAccounts()
                End If
            Catch ex As Exception
                MsgBox("Error adding payment.")
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub AddDebtBtn_Click(sender As Object, e As EventArgs) Handles AddDebtBtn.Click
        If ListBox1.SelectedItem Is Nothing Then

        Else
            Try
                Dim Invoice As New Payment With {
                .PaymentAmmount = Convert.ToDouble(AddDebtTxt.Text),
                .PaymentDate = DateAndTime.DateString.ToString(),
                .PaymentID = "" 'Hash the date+ammount with sha1?
                }

                If Not LocalAccounts(ListBox1.SelectedItem.ToString()).Payments.ContainsKey(Invoice.PaymentAmmount) Then
                    LocalAccounts(ListBox1.SelectedItem.ToString()).Payments.Add(Invoice.PaymentAmmount, Invoice)
                    ListBox2.Items.Add("Payment Date: " + Invoice.PaymentDate.ToString() + "   " + "Payment Ammount: " + Invoice.PaymentAmmount.ToString())
                    LocalAccounts(ListBox1.SelectedItem.ToString()).DebtAmmount += Invoice.PaymentAmmount
                    AmmountOwedTxt.Text = LocalAccounts(ListBox1.SelectedItem.ToString()).DebtAmmount.ToString()
                    LastPaymentTxt.Text = Invoice.PaymentAmmount.ToString()
                    LastPayDateTxt.Text = Invoice.PaymentDate.ToString()
                    AddDebtTxt.Text = ""
                End If

                If My.Settings.Autosave = True Then
                    SaveAccounts()
                End If
            Catch ex As Exception
                MsgBox("Error adding debt.")
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub CreateAccountBtn_Click(sender As Object, e As EventArgs) Handles CreateAccountBtn.Click
        If Not NewAccountNameTxt.Text = "" Then
            If Not LocalAccounts.ContainsKey(NewAccountNameTxt.Text) Then
                Dim NewAccount As New Account With {
                    .Name = NewAccountNameTxt.Text,
                    .CreditAmmount = 0,
                    .DebtAmmount = 0
                }

                ListBox1.Items.Add(NewAccount.Name)
                LocalAccounts.Add(NewAccount.Name, NewAccount)
            Else
                MsgBox("Account already exists!")
            End If

            If My.Settings.Autosave = True Then
                SaveAccounts()
            End If
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            ListBox2.Items.Clear()

            Dim account = LocalAccounts(ListBox1.SelectedItem.ToString())
            AccountNameTxt.Text = account.Name.ToString()
            AmmountOwedTxt.Text = account.DebtAmmount.ToString()

            If account.Payments.Count = 0 Then
                LastPayDateTxt.Text = ""
                LastPaymentTxt.Text = ""
            Else
                For Each payment In account.Payments
                    ListBox2.Items.Add("Payment Date: " + payment.Value.PaymentDate.ToString() + "   " + "Payment Ammount: " + payment.Value.PaymentAmmount.ToString()) 'add id when id conversion is done
                Next
                LastPayDateTxt.Text = account.Payments.LastOrDefault.Value.PaymentDate.ToString()
                LastPaymentTxt.Text = account.Payments.LastOrDefault.Value.PaymentAmmount.ToString()
            End If
        Catch ex As Exception
            'supress errors if u dont select an initial index then it will alwyas throw an error
        End Try
    End Sub

    Private Sub ListBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox1.KeyDown
        Try
            If e.KeyCode = Keys.Delete Then
                Dim Areyousure As New DialogResult
                Areyousure = MessageBox.Show("Are you sure you want to delete that account", "Are you sure?", MessageBoxButtons.YesNo)

                If Areyousure = DialogResult.Yes Then
                    LocalAccounts.Remove(CType(ListBox1.SelectedItem.ToString(), String))
                    ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
                Else

                End If

                If ListBox1.Items.Count = 0 Then
                    ListBox2.Items.Clear()
                    AccountNameTxt.Text = ""
                    AmmountOwedTxt.Text = ""
                    LastPayDateTxt.Text = ""
                    LastPaymentTxt.Text = ""
                Else

                End If

                If My.Settings.Autosave = True Then
                    SaveAccounts()
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SettingsBtn_Click(sender As Object, e As EventArgs) Handles SettingsBtn.Click
        Settings.Show()
    End Sub
End Class
