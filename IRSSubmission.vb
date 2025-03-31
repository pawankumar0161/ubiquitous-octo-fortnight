Imports MeF.Client
Imports MeF.Client.Services.MSIServices
Imports MeF.Client.Services.TransmitterServices
Imports MeF.Client.Services.InputComposition
Imports MeF.Client.EfileAttachments
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web
Imports RestSharp
Imports Newtonsoft.Json
Imports System.Xml

Public Class IRSSubmission

    '********************THIS SECTION FOR UPLOADING MANIFEST FILE ********************************
    Private Sub btnManifest_Click(sender As Object, e As EventArgs) Handles btnManifest.Click

        'To where your opendialog box get starting location. My initial directory location Is desktop.
        updManifest.InitialDirectory = "C://Desktop"
        '//Your opendialog box title name.
        updManifest.Title = "Select file to be upload."
        '//which type file format you want to upload in database. just add them.
        updManifest.Filter = "Select Valid Document(*.xml)| *.xml"
        '//FilterIndex property represents the index of the filter currently selected in the file dialog box.
        updManifest.FilterIndex = 1
        Try

            If updManifest.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                'Cheking for file uploaded by user
                If (updManifest.CheckFileExists) Then
                    'Getting the path for the file uploaded by user
                    Dim Path = System.IO.Path.GetFullPath(updManifest.FileName)
                    'I used msg box to pop-up the path values to user
                    MessageBox.Show(Path)
                    'I also added lbl to application for user, you can do it as per your application need
                    lblManifestMsg.Text = updManifest.FileName
                Else
                    'Here is validations msg
                    MessageBox.Show("Please Upload document.")
                End If
            End If

        Catch ex As Exception
            'Here goes the error msg if any
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    '********************THIS SECTION FOR UPLOADING XML FILE ********************************
    Private Sub btnUploadXML_Click(sender As Object, e As EventArgs) Handles btnUploadXML.Click
        'To where your opendialog box get starting location. My initial directory location Is desktop.
        updXML.InitialDirectory = "C://Desktop"
        '//Your opendialog box title name.
        updXML.Title = "Select file to be upload."
        '//which type file format you want to upload in database. just add them.
        updXML.Filter = "Select Valid Document(*.xml)| *.xml"
        '//FilterIndex property represents the index of the filter currently selected in the file dialog box.
        updXML.FilterIndex = 1
        Try
            If updXML.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                If (updXML.CheckFileExists) Then
                    'Get full path for XML file here
                    Dim Path = System.IO.Path.GetFullPath(updXML.FileName)
                    'Display to user or handle as per your application structure 
                    MessageBox.Show(Path)
                    lblXMLMsg.Text = updXML.FileName
                Else
                    'Validation msg goes here
                    MessageBox.Show("Please Upload document.")
                End If
            End If
        Catch ex As Exception
            'Here goes the exceptions
            MessageBox.Show(ex.Message.ToString())
        End Try

    End Sub


    '********************THIS SECTION FOR UPLOADING PDF FILE ********************************
    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        'To where your opendialog box get starting location. My initial directory location Is desktop.
        updPDF.InitialDirectory = "C://Desktop"
        '//Your opendialog box title name.
        updPDF.Title = "Select file to be upload."
        '//which type file format you want to upload in database. just add them.
        updPDF.Filter = "Select Valid Document(*.pdf)| *.pdf"
        '//FilterIndex property represents the index of the filter currently selected in the file dialog box.
        updPDF.FilterIndex = 1
        Try
            If updPDF.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                If (updPDF.CheckFileExists) Then
                    Dim Path = System.IO.Path.GetFullPath(updPDF.FileName)
                    MessageBox.Show(Path)
                    lblPDFMsg.Text = updPDF.FileName
                Else
                    MessageBox.Show("Please Upload document.")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    '******************** THIS SECTION FOR SEND SUBMISSIONS ********************************
    Private Sub btnSendSubmission_Click(sender As Object, e As EventArgs) Handles btnSendSubmission.Click

        Try

            'Create object of SubmissionBuilder over here
            Dim builder = New SubmissionBuilder()
            'We need input SubmissionID as input for this
            Dim SubmissionID As String = txtSubmissionID.Text
            'Use the manifest file name uploaded earlier and create "manifest" for submission
            Dim fileBytes = File.ReadAllBytes(updManifest.FileName)
            Dim manifest64 As String = Convert.ToBase64String(fileBytes)
            Dim xml641 = File.ReadAllBytes(updXML.FileName)
            Dim xml64 As String = Convert.ToBase64String(xml641)
            Dim pdf2 = "" 'File.ReadAllBytes(updPDF.FileName)
            Dim pdf264 As String = "" 'Convert.ToBase64String(pdf2)
            'Dim client = New RestClient("Http://aimcorp-002-site6.gtempurl.com/api/values/login")
            Dim client = New RestClient("https://localhost:44300/api/values/login")
            Dim request = New RestRequest(Method.POST)
            request.AddHeader("cache-control", "no-cache")
            request.AddHeader("content-type", "application/json")
            'BELOW IS FOR TESTING

            request.AddParameter("application/json", "{" & vbLf & "    ""etin"": ""24634"", " & vbLf & "    ""appSysId"": ""66011601"", " & vbLf & "    ""submissionId"": """ + SubmissionID + """, " & vbLf & "    ""Manifest"": """ + manifest64 + """, " & vbLf & "    ""XML"": """ + xml64 + """, " & vbLf & "    ""PDF"": """ + pdf264 + """," & vbLf & "    ""environment"": ""P""" & vbLf & "}", ParameterType.RequestBody)


            Dim response As IRestResponse = client.Execute(request)
            Dim checkresult = response
            Dim item As SubmissionResponse = JsonConvert.DeserializeObject(Of SubmissionResponse)(checkresult.Content)
            Dim result As String = ""
            result += "Submission ID : " + item.data.MessageID + Environment.NewLine
            result += "SubmissionReceivedTs : " + item.data.Relatesto + Environment.NewLine
            result += "Status : " + item.data.Statustxt + Environment.NewLine
            MessageBox.Show(result)
        Catch ex As Exception
            'Here goes the errors if any
            MessageBox.Show(ex.Message.ToString())
        End Try

    End Sub

    '******************** THIS SECTION FOR ACKKNOWLEDGEMENT ********************************

    Private Sub btnGetAck_Click(sender As Object, e As EventArgs) Handles btnGetAck.Click
        Try

            'Dim client = New RestClient("Http://aimcorp-002-site6.gtempurl.com/api/values/ack")
            Dim client = New RestClient("https://localhost:44300/api/values/ack")
            Dim request = New RestRequest(Method.POST)
            request.AddHeader("postman-token", "ff39a466-c98d-18ec-2a80-4678ff97bbc0")
            request.AddHeader("cache-control", "no-cache")
            request.AddHeader("content-type", "application/json")
            'BELOW IS FOR TESTING


            request.AddParameter("application/json", "{" & vbCrLf & "    ""etin"":""24634""," & vbCrLf & "    ""appSysId"":""66011601""," & vbCrLf & "    ""submissionId"":""" + txtSubmissionIdAck.Text + """," & vbCrLf & "    ""environment"":""P""" & vbCrLf & "}" & vbCrLf, ParameterType.RequestBody)

            Dim response As IRestResponse = client.Execute(request)
            Dim result = response
            Dim item As AckResponse = JsonConvert.DeserializeObject(Of AckResponse)(result.Content)
            Dim root As String = "C://Acknowledgement"
            If Not Directory.Exists(root) Then
                Directory.CreateDirectory(root)
            End If
            Dim AcceptanceStatusTxt = ""
            Dim AcceptanceFlag = True
            Dim ErrorMessageTxt = ""
            Dim ErrorMessageFlag = True
            If item.data.content IsNot Nothing AndAlso item.data.content.Length > 0 Then
                Dim utfString = Encoding.UTF8.GetString(item.data.content, 0, item.data.content.Length)
                Dim strArrayEle As String() = utfString.Split("<".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)

                For Each data In strArrayEle
                    If data.Contains("AcceptanceStatusTxt>") And AcceptanceFlag = True Then
                        AcceptanceStatusTxt = data.Replace("AcceptanceStatusTxt>", "")
                        AcceptanceFlag = False
                        'AcceptanceStatusTxt = AcceptanceStatusTxt.Replace("</AcceptanceStatusTxt>", "")
                    End If
                    If data.Contains("ErrorMessageTxt>") And ErrorMessageFlag = True Then
                        ErrorMessageTxt = data.Replace("ErrorMessageTxt>", "")
                        ErrorMessageFlag = False
                        'ErrorMessageTxt = ErrorMessageTxt.Replace("</ErrorMessageTxt>", "")
                    End If
                Next
                File.WriteAllBytes("C://Acknowledgement/" + txtSubmissionIdAck.Text + ".xml", item.data.content)
            Else
                ErrorMessageTxt = "No ACK Found with SubmissionID"
            End If



            Dim output = "MessageID  :  " + item.data.MessageID + Environment.NewLine + "AcceptanceStatusTxt  :  " + AcceptanceStatusTxt + Environment.NewLine + "ErrorMessageTxt  :  " + ErrorMessageTxt
            MessageBox.Show(output)


        Catch ex As Exception
            'Here goes the error msgs if any
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub
    Public Class AckResponse
        Public Property output As String
        Public Property data As data
    End Class
    Public Class data
        Public Property MessageID As String
        Public Property content As Byte()
        Public Property Relatesto As String
        Public Property Statustxt As String
    End Class
    Public Class SubmissionResponse
        Public Property output As String
        Public Property data As Submissiondata
    End Class
    Public Class Submissiondata
        Public Property MessageID As String
        Public Property Relatesto As String
        Public Property Statustxt As String
    End Class
End Class
