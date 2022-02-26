<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IRSSubmission
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblPDFMsg = New System.Windows.Forms.Label()
        Me.lblXMLMsg = New System.Windows.Forms.Label()
        Me.lblManifestMsg = New System.Windows.Forms.Label()
        Me.btnSendSubmission = New System.Windows.Forms.Button()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnUploadXML = New System.Windows.Forms.Button()
        Me.lblXML = New System.Windows.Forms.Label()
        Me.btnManifest = New System.Windows.Forms.Button()
        Me.lblmanifest = New System.Windows.Forms.Label()
        Me.txtSubmissionID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.updManifest = New System.Windows.Forms.OpenFileDialog()
        Me.updXML = New System.Windows.Forms.OpenFileDialog()
        Me.updPDF = New System.Windows.Forms.OpenFileDialog()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnGetAck = New System.Windows.Forms.Button()
        Me.txtSubmissionIdAck = New System.Windows.Forms.TextBox()
        Me.lblSubmissionIdAck = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblPDFMsg)
        Me.Panel2.Controls.Add(Me.lblXMLMsg)
        Me.Panel2.Controls.Add(Me.lblManifestMsg)
        Me.Panel2.Controls.Add(Me.btnSendSubmission)
        Me.Panel2.Controls.Add(Me.btnPDF)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.btnUploadXML)
        Me.Panel2.Controls.Add(Me.lblXML)
        Me.Panel2.Controls.Add(Me.btnManifest)
        Me.Panel2.Controls.Add(Me.lblmanifest)
        Me.Panel2.Controls.Add(Me.txtSubmissionID)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(28, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(393, 424)
        Me.Panel2.TabIndex = 3
        '
        'lblPDFMsg
        '
        Me.lblPDFMsg.AutoSize = True
        Me.lblPDFMsg.Location = New System.Drawing.Point(140, 276)
        Me.lblPDFMsg.Name = "lblPDFMsg"
        Me.lblPDFMsg.Size = New System.Drawing.Size(0, 17)
        Me.lblPDFMsg.TabIndex = 14
        '
        'lblXMLMsg
        '
        Me.lblXMLMsg.AutoSize = True
        Me.lblXMLMsg.Location = New System.Drawing.Point(140, 218)
        Me.lblXMLMsg.Name = "lblXMLMsg"
        Me.lblXMLMsg.Size = New System.Drawing.Size(0, 17)
        Me.lblXMLMsg.TabIndex = 13
        '
        'lblManifestMsg
        '
        Me.lblManifestMsg.AutoSize = True
        Me.lblManifestMsg.Location = New System.Drawing.Point(140, 169)
        Me.lblManifestMsg.Name = "lblManifestMsg"
        Me.lblManifestMsg.Size = New System.Drawing.Size(0, 17)
        Me.lblManifestMsg.TabIndex = 12
        '
        'btnSendSubmission
        '
        Me.btnSendSubmission.Location = New System.Drawing.Point(107, 304)
        Me.btnSendSubmission.Name = "btnSendSubmission"
        Me.btnSendSubmission.Size = New System.Drawing.Size(200, 47)
        Me.btnSendSubmission.TabIndex = 11
        Me.btnSendSubmission.Text = "Send Submission"
        Me.btnSendSubmission.UseVisualStyleBackColor = True
        '
        'btnPDF
        '
        Me.btnPDF.Location = New System.Drawing.Point(143, 242)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(148, 24)
        Me.btnPDF.TabIndex = 10
        Me.btnPDF.Text = "Upload PDF file"
        Me.btnPDF.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "PDF Attachment"
        '
        'btnUploadXML
        '
        Me.btnUploadXML.Location = New System.Drawing.Point(143, 191)
        Me.btnUploadXML.Name = "btnUploadXML"
        Me.btnUploadXML.Size = New System.Drawing.Size(148, 24)
        Me.btnUploadXML.TabIndex = 8
        Me.btnUploadXML.Text = "Upload XML file"
        Me.btnUploadXML.UseVisualStyleBackColor = True
        '
        'lblXML
        '
        Me.lblXML.AutoSize = True
        Me.lblXML.Location = New System.Drawing.Point(29, 192)
        Me.lblXML.Name = "lblXML"
        Me.lblXML.Size = New System.Drawing.Size(62, 17)
        Me.lblXML.TabIndex = 7
        Me.lblXML.Text = "XML File"
        '
        'btnManifest
        '
        Me.btnManifest.Location = New System.Drawing.Point(143, 142)
        Me.btnManifest.Name = "btnManifest"
        Me.btnManifest.Size = New System.Drawing.Size(148, 24)
        Me.btnManifest.TabIndex = 6
        Me.btnManifest.Text = "Upload Manifest file"
        Me.btnManifest.UseVisualStyleBackColor = True
        '
        'lblmanifest
        '
        Me.lblmanifest.AutoSize = True
        Me.lblmanifest.Location = New System.Drawing.Point(29, 143)
        Me.lblmanifest.Name = "lblmanifest"
        Me.lblmanifest.Size = New System.Drawing.Size(61, 17)
        Me.lblmanifest.TabIndex = 5
        Me.lblmanifest.Text = "Manifest"
        '
        'txtSubmissionID
        '
        Me.txtSubmissionID.Location = New System.Drawing.Point(143, 95)
        Me.txtSubmissionID.Name = "txtSubmissionID"
        Me.txtSubmissionID.Size = New System.Drawing.Size(164, 23)
        Me.txtSubmissionID.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Submission ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(79, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(228, 26)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Send Submission Section"
        '
        'updManifest
        '
        Me.updManifest.FileName = "UploadManifest"
        '
        'updXML
        '
        Me.updXML.FileName = "updXML"
        '
        'updPDF
        '
        Me.updPDF.FileName = "updPDF"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnGetAck)
        Me.Panel3.Controls.Add(Me.txtSubmissionIdAck)
        Me.Panel3.Controls.Add(Me.lblSubmissionIdAck)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(442, 40)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(497, 422)
        Me.Panel3.TabIndex = 4
        '
        'btnGetAck
        '
        Me.btnGetAck.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetAck.Location = New System.Drawing.Point(199, 170)
        Me.btnGetAck.Name = "btnGetAck"
        Me.btnGetAck.Size = New System.Drawing.Size(164, 30)
        Me.btnGetAck.TabIndex = 12
        Me.btnGetAck.Text = "Get Acknowledgement"
        Me.btnGetAck.UseVisualStyleBackColor = True
        '
        'txtSubmissionIdAck
        '
        Me.txtSubmissionIdAck.Location = New System.Drawing.Point(199, 127)
        Me.txtSubmissionIdAck.Name = "txtSubmissionIdAck"
        Me.txtSubmissionIdAck.Size = New System.Drawing.Size(164, 20)
        Me.txtSubmissionIdAck.TabIndex = 6
        '
        'lblSubmissionIdAck
        '
        Me.lblSubmissionIdAck.AutoSize = True
        Me.lblSubmissionIdAck.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubmissionIdAck.Location = New System.Drawing.Point(88, 130)
        Me.lblSubmissionIdAck.Name = "lblSubmissionIdAck"
        Me.lblSubmissionIdAck.Size = New System.Drawing.Size(97, 17)
        Me.lblSubmissionIdAck.TabIndex = 5
        Me.lblSubmissionIdAck.Text = "Submission ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(102, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(272, 26)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Get Acknowledgement Section"
        '
        'IRSSubmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 500)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "IRSSubmission"
        Me.Text = "IRS Send Submission"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSubmissionID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblmanifest As Label
    Friend WithEvents btnManifest As Button
    Friend WithEvents updManifest As OpenFileDialog
    Friend WithEvents btnUploadXML As Button
    Friend WithEvents lblXML As Label
    Friend WithEvents updXML As OpenFileDialog
    Friend WithEvents btnPDF As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents updPDF As OpenFileDialog
    Friend WithEvents btnSendSubmission As Button
    Friend WithEvents lblPDFMsg As Label
    Friend WithEvents lblXMLMsg As Label
    Friend WithEvents lblManifestMsg As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtSubmissionIdAck As TextBox
    Friend WithEvents lblSubmissionIdAck As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnGetAck As Button
End Class
