Public Class ReportData
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents objmyrepdata As CustPhrs.myrepdata
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancelAll As System.Windows.Forms.Button
    Friend WithEvents lblAnonReq As System.Windows.Forms.Label
    Friend WithEvents lblAutoID As System.Windows.Forms.Label
    Friend WithEvents lblCallDate As System.Windows.Forms.Label
    Friend WithEvents lblCallStatus As System.Windows.Forms.Label
    Friend WithEvents lblCBtime As System.Windows.Forms.Label
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents lblConfirmation As System.Windows.Forms.Label
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents lblFname As System.Windows.Forms.Label
    Friend WithEvents editAnonReq As System.Windows.Forms.TextBox
    Friend WithEvents editAutoID As System.Windows.Forms.TextBox
    Friend WithEvents editCallDate As System.Windows.Forms.TextBox
    Friend WithEvents editCallStatus As System.Windows.Forms.TextBox
    Friend WithEvents editCBtime As System.Windows.Forms.TextBox
    Friend WithEvents editComments As System.Windows.Forms.TextBox
    Friend WithEvents editConfirmation As System.Windows.Forms.TextBox
    Friend WithEvents editDOB As System.Windows.Forms.TextBox
    Friend WithEvents editFname As System.Windows.Forms.TextBox
    Friend WithEvents lblLang As System.Windows.Forms.Label
    Friend WithEvents lblLname As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblSID As System.Windows.Forms.Label
    Friend WithEvents lblSubscriber As System.Windows.Forms.Label
    Friend WithEvents lblverified As System.Windows.Forms.Label
    Friend WithEvents lblVerifiedby As System.Windows.Forms.Label
    Friend WithEvents lblVerifiedDate As System.Windows.Forms.Label
    Friend WithEvents lblCallID As System.Windows.Forms.Label
    Friend WithEvents editLang As System.Windows.Forms.TextBox
    Friend WithEvents editLname As System.Windows.Forms.TextBox
    Friend WithEvents editPhone As System.Windows.Forms.TextBox
    Friend WithEvents editSID As System.Windows.Forms.TextBox
    Friend WithEvents editSubscriber As System.Windows.Forms.TextBox
    Friend WithEvents editverified As System.Windows.Forms.CheckBox
    Friend WithEvents editVerifiedby As System.Windows.Forms.TextBox
    Friend WithEvents editVerifiedDate As System.Windows.Forms.TextBox
    Friend WithEvents editCallID As System.Windows.Forms.TextBox
    Friend WithEvents btnNavFirst As System.Windows.Forms.Button
    Friend WithEvents btnNavPrev As System.Windows.Forms.Button
    Friend WithEvents lblNavLocation As System.Windows.Forms.Label
    Friend WithEvents btnNavNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.objmyrepdata = New CustPhrs.myrepdata()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancelAll = New System.Windows.Forms.Button()
        Me.lblAnonReq = New System.Windows.Forms.Label()
        Me.lblAutoID = New System.Windows.Forms.Label()
        Me.lblCallDate = New System.Windows.Forms.Label()
        Me.lblCallStatus = New System.Windows.Forms.Label()
        Me.lblCBtime = New System.Windows.Forms.Label()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.editAnonReq = New System.Windows.Forms.TextBox()
        Me.editAutoID = New System.Windows.Forms.TextBox()
        Me.editCallDate = New System.Windows.Forms.TextBox()
        Me.editCallStatus = New System.Windows.Forms.TextBox()
        Me.editCBtime = New System.Windows.Forms.TextBox()
        Me.editComments = New System.Windows.Forms.TextBox()
        Me.editConfirmation = New System.Windows.Forms.TextBox()
        Me.editDOB = New System.Windows.Forms.TextBox()
        Me.editFname = New System.Windows.Forms.TextBox()
        Me.lblLang = New System.Windows.Forms.Label()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblSID = New System.Windows.Forms.Label()
        Me.lblSubscriber = New System.Windows.Forms.Label()
        Me.lblverified = New System.Windows.Forms.Label()
        Me.lblVerifiedby = New System.Windows.Forms.Label()
        Me.lblVerifiedDate = New System.Windows.Forms.Label()
        Me.lblCallID = New System.Windows.Forms.Label()
        Me.editLang = New System.Windows.Forms.TextBox()
        Me.editLname = New System.Windows.Forms.TextBox()
        Me.editPhone = New System.Windows.Forms.TextBox()
        Me.editSID = New System.Windows.Forms.TextBox()
        Me.editSubscriber = New System.Windows.Forms.TextBox()
        Me.editverified = New System.Windows.Forms.CheckBox()
        Me.editVerifiedby = New System.Windows.Forms.TextBox()
        Me.editVerifiedDate = New System.Windows.Forms.TextBox()
        Me.editCallID = New System.Windows.Forms.TextBox()
        Me.btnNavFirst = New System.Windows.Forms.Button()
        Me.btnNavPrev = New System.Windows.Forms.Button()
        Me.lblNavLocation = New System.Windows.Forms.Label()
        Me.btnNavNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        CType(Me.objmyrepdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'objmyrepdata
        '
        Me.objmyrepdata.DataSetName = "myrepdata"
        Me.objmyrepdata.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objmyrepdata.Namespace = "http://www.tempuri.org/myrepdata.xsd"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(648, 416)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "&Load"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(16, 416)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "&Update"
        '
        'btnCancelAll
        '
        Me.btnCancelAll.Location = New System.Drawing.Point(104, 416)
        Me.btnCancelAll.Name = "btnCancelAll"
        Me.btnCancelAll.TabIndex = 2
        Me.btnCancelAll.Text = "Ca&ncel All"
        '
        'lblAnonReq
        '
        Me.lblAnonReq.Location = New System.Drawing.Point(24, 32)
        Me.lblAnonReq.Name = "lblAnonReq"
        Me.lblAnonReq.Size = New System.Drawing.Size(96, 23)
        Me.lblAnonReq.TabIndex = 3
        Me.lblAnonReq.Text = "Anonymity Status"
        '
        'lblAutoID
        '
        Me.lblAutoID.Location = New System.Drawing.Point(760, 352)
        Me.lblAutoID.Name = "lblAutoID"
        Me.lblAutoID.Size = New System.Drawing.Size(32, 23)
        Me.lblAutoID.TabIndex = 4
        Me.lblAutoID.Text = "AutoID"
        Me.lblAutoID.Visible = False
        '
        'lblCallDate
        '
        Me.lblCallDate.Location = New System.Drawing.Point(24, 88)
        Me.lblCallDate.Name = "lblCallDate"
        Me.lblCallDate.Size = New System.Drawing.Size(48, 23)
        Me.lblCallDate.TabIndex = 5
        Me.lblCallDate.Text = "CallDate"
        '
        'lblCallStatus
        '
        Me.lblCallStatus.Location = New System.Drawing.Point(192, 88)
        Me.lblCallStatus.Name = "lblCallStatus"
        Me.lblCallStatus.Size = New System.Drawing.Size(64, 23)
        Me.lblCallStatus.TabIndex = 6
        Me.lblCallStatus.Text = "CallStatus"
        '
        'lblCBtime
        '
        Me.lblCBtime.Location = New System.Drawing.Point(248, 96)
        Me.lblCBtime.Name = "lblCBtime"
        Me.lblCBtime.Size = New System.Drawing.Size(48, 23)
        Me.lblCBtime.TabIndex = 7
        Me.lblCBtime.Text = "CBtime"
        '
        'lblComments
        '
        Me.lblComments.Location = New System.Drawing.Point(40, 160)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(80, 23)
        Me.lblComments.TabIndex = 8
        Me.lblComments.Text = "Comments"
        '
        'lblConfirmation
        '
        Me.lblConfirmation.Location = New System.Drawing.Point(24, 24)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(80, 23)
        Me.lblConfirmation.TabIndex = 9
        Me.lblConfirmation.Text = "Confirmation"
        '
        'lblDOB
        '
        Me.lblDOB.Location = New System.Drawing.Point(40, 128)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(38, 23)
        Me.lblDOB.TabIndex = 10
        Me.lblDOB.Text = "DOB"
        '
        'lblFname
        '
        Me.lblFname.Location = New System.Drawing.Point(40, 64)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(64, 23)
        Me.lblFname.TabIndex = 11
        Me.lblFname.Text = "First Name"
        '
        'editAnonReq
        '
        Me.editAnonReq.BackColor = System.Drawing.SystemColors.Info
        Me.editAnonReq.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objmyrepdata, "ReportData.AnonReq"))
        Me.editAnonReq.Location = New System.Drawing.Point(128, 32)
        Me.editAnonReq.Name = "editAnonReq"
        Me.editAnonReq.ReadOnly = True
        Me.editAnonReq.Size = New System.Drawing.Size(168, 20)
        Me.editAnonReq.TabIndex = 12
        Me.editAnonReq.Text = ""
        '
        'editAutoID
        '
        Me.editAutoID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objmyrepdata, "ReportData.AutoID"))
        Me.editAutoID.Location = New System.Drawing.Point(776, 376)
        Me.editAutoID.Name = "editAutoID"
        Me.editAutoID.Size = New System.Drawing.Size(16, 20)
        Me.editAutoID.TabIndex = 13
        Me.editAutoID.Text = ""
        Me.editAutoID.Visible = False
        '
        'editCallDate
        '
        Me.editCallDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objmyrepdata, "ReportData.CallDate"))
        Me.editCallDate.Location = New System.Drawing.Point(112, 88)
        Me.editCallDate.Name = "editCallDate"
        Me.editCallDate.Size = New System.Drawing.Size(56, 20)
        Me.editCallDate.TabIndex = 14
        Me.editCallDate.Text = ""
        '
        'editCallStatus
        '
        Me.editCallStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objmyrepdata, "ReportData.CallStatus"))
        Me.editCallStatus.Location = New System.Drawing.Point(248, 88)
        Me.editCallStatus.Name = "editCallStatus"
        Me.editCallStatus.TabIndex = 15
        Me.editCallStatus.Text = ""
        '
        'editCBtime
        '
        Me.editCBtime.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objmyrepdata, "ReportData.CBtime"))
        Me.editCBtime.Location = New System.Drawing.Point(312, 96)
        Me.editCBtime.Name = "editCBtime"
        Me.editCBtime.TabIndex = 16
        Me.editCBtime.Text = ""
        '
        'editComments
        '
        Me.editComments.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objmyrepdata, "ReportData.Comments"))
        Me.editComments.Location = New System.Drawing.Point(128, 160)
        Me.editComments.Multiline = True
        Me.editComments.Name = "editComments"
        Me.editComments.Size = New System.Drawing.Size(328, 72)
        Me.editComments.TabIndex = 17
        Me.editComments.Text = ""
        '
        'editConfirmation
        '
        Me.editConfirmation.BackColor = System.Drawing.SystemColors.Info
        Me.editConfirmation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objmyrepdata, "ReportData.Confirmation"))
        Me.editConfirmation.Location = New System.Drawing.Point(112, 24)
        Me.editConfirmation.Name = "editConfirmation"
        Me.editConfirmation.ReadOnly = True
        Me.editConfirmation.TabIndex = 18
        Me.editConfirmation.Text = ""
        '
        'editDOB
        '
        Me.editDOB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objmyrepdata, "ReportData.DOB"))
        Me.editDOB.Location = New System.Drawing.Point(128, 128)
        Me.editDOB.Name = "editDOB"
        Me.editDOB.TabIndex = 19
        Me.editDOB.Text = ""
        '
        'editFname
        '
        Me.editFname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objmyrepdata, "ReportData.Fname"))
        Me.editFname.Location = New System.Drawing.Point(128, 64)
        Me.editFname.Name = "editFname"
        Me.editFname.TabIndex = 20
        Me.editFname.Text = ""
        '
        'lblLang
        '
        Me.lblLang.Location = New System.Drawing.Point(224, 16)
        Me.lblLang.Name = "lblLang"
        Me.lblLang.Size = New System.Drawing.Size(56, 23)
        Me.lblLang.TabIndex = 21
        Me.lblLang.Text = "Language"
        '
        'lblLname
        '
        Me.lblLname.Location = New System.Drawing.Point(248, 64)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(64, 23)
        Me.lblLname.TabIndex = 22
        Me.lblLname.Text = "Last Name"
        '
        'lblPhone
        '
        Me.lblPhone.Location = New System.Drawing.Point(40, 96)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(42, 23)
        Me.lblPhone.TabIndex = 23
        Me.lblPhone.Text = "Phone"
        '
        'lblSID
        '
        Me.lblSID.Location = New System.Drawing.Point(24, 56)
        Me.lblSID.Name = "lblSID"
        Me.lblSID.Size = New System.Drawing.Size(80, 23)
        Me.lblSID.TabIndex = 24
        Me.lblSID.Text = "Subscriber ID"
        '
        'lblSubscriber
        '
        Me.lblSubscriber.Location = New System.Drawing.Point(184, 56)
        Me.lblSubscriber.Name = "lblSubscriber"
        Me.lblSubscriber.Size = New System.Drawing.Size(64, 23)
        Me.lblSubscriber.TabIndex = 25
        Me.lblSubscriber.Text = "Subscriber"
        '
        'lblverified
        '
        Me.lblverified.Location = New System.Drawing.Point(208, 16)
        Me.lblverified.Name = "lblverified"
        Me.lblverified.Size = New System.Drawing.Size(16, 23)
        Me.lblverified.TabIndex = 26
        Me.lblverified.Text = "verified"
        Me.lblverified.Visible = False
        '
        'lblVerifiedby
        '
        Me.lblVerifiedby.Location = New System.Drawing.Point(16, 24)
        Me.lblVerifiedby.Name = "lblVerifiedby"
        Me.lblVerifiedby.Size = New System.Drawing.Size(64, 23)
        Me.lblVerifiedby.TabIndex = 27
        Me.lblVerifiedby.Text = "Verified by"
        '
        'lblVerifiedDate
        '
        Me.lblVerifiedDate.Location = New System.Drawing.Point(16, 48)
        Me.lblVerifiedDate.Name = "lblVerifiedDate"
        Me.lblVerifiedDate.Size = New System.Drawing.Size(72, 23)
        Me.lblVerifiedDate.TabIndex = 28
        Me.lblVerifiedDate.Text = "Verified Date"
        '
        'lblCallID
        '
        Me.lblCallID.Location = New System.Drawing.Point(768, 312)
        Me.lblCallID.Name = "lblCallID"
        Me.lblCallID.Size = New System.Drawing.Size(16, 23)
        Me.lblCallID.TabIndex = 29
        Me.lblCallID.Text = "CallID"
        Me.lblCallID.Visible = False
        '
        'editLang
        '
        Me.editLang.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objmyrepdata, "ReportData.Lang"))
        Me.editLang.Location = New System.Drawing.Point(288, 16)
        Me.editLang.Name = "editLang"
        Me.editLang.Size = New System.Drawing.Size(56, 20)
        Me.editLang.TabIndex = 30
        Me.editLang.Text = ""
        '
        'editLname
        '
        Me.editLname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objmyrepdata, "ReportData.Lname"))
        Me.editLname.Location = New System.Drawing.Point(312, 64)
        Me.editLname.Name = "editLname"
        Me.editLname.Size = New System.Drawing.Size(144, 20)
        Me.editLname.TabIndex = 31
        Me.editLname.Text = ""
        '
        'editPhone
        '
        Me.editPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objmyrepdata, "ReportData.Phone"))
        Me.editPhone.Location = New System.Drawing.Point(128, 96)
        Me.editPhone.Name = "editPhone"
        Me.editPhone.TabIndex = 32
        Me.editPhone.Text = ""
        '
        'editSID
        '
        Me.editSID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objmyrepdata, "ReportData.SID"))
        Me.editSID.Location = New System.Drawing.Point(112, 56)
        Me.editSID.Name = "editSID"
        Me.editSID.Size = New System.Drawing.Size(56, 20)
        Me.editSID.TabIndex = 33
        Me.editSID.Text = ""
        '
        'editSubscriber
        '
        Me.editSubscriber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objmyrepdata, "ReportData.Subscriber"))
        Me.editSubscriber.Location = New System.Drawing.Point(248, 56)
        Me.editSubscriber.Name = "editSubscriber"
        Me.editSubscriber.Size = New System.Drawing.Size(144, 20)
        Me.editSubscriber.TabIndex = 34
        Me.editSubscriber.Text = ""
        '
        'editverified
        '
        Me.editverified.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.objmyrepdata, "ReportData.verified"))
        Me.editverified.Location = New System.Drawing.Point(232, 16)
        Me.editverified.Name = "editverified"
        Me.editverified.Size = New System.Drawing.Size(24, 24)
        Me.editverified.TabIndex = 35
        '
        'editVerifiedby
        '
        Me.editVerifiedby.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objmyrepdata, "ReportData.Verifiedby"))
        Me.editVerifiedby.Location = New System.Drawing.Point(96, 24)
        Me.editVerifiedby.Name = "editVerifiedby"
        Me.editVerifiedby.TabIndex = 36
        Me.editVerifiedby.Text = ""
        '
        'editVerifiedDate
        '
        Me.editVerifiedDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objmyrepdata, "ReportData.VerifiedDate"))
        Me.editVerifiedDate.Location = New System.Drawing.Point(96, 48)
        Me.editVerifiedDate.Name = "editVerifiedDate"
        Me.editVerifiedDate.TabIndex = 37
        Me.editVerifiedDate.Text = ""
        '
        'editCallID
        '
        Me.editCallID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objmyrepdata, "ReportData.CallID"))
        Me.editCallID.Location = New System.Drawing.Point(776, 328)
        Me.editCallID.Name = "editCallID"
        Me.editCallID.Size = New System.Drawing.Size(8, 20)
        Me.editCallID.TabIndex = 38
        Me.editCallID.Text = ""
        Me.editCallID.Visible = False
        '
        'btnNavFirst
        '
        Me.btnNavFirst.Location = New System.Drawing.Point(336, 416)
        Me.btnNavFirst.Name = "btnNavFirst"
        Me.btnNavFirst.Size = New System.Drawing.Size(40, 23)
        Me.btnNavFirst.TabIndex = 39
        Me.btnNavFirst.Text = "<<"
        '
        'btnNavPrev
        '
        Me.btnNavPrev.Location = New System.Drawing.Point(376, 416)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(35, 23)
        Me.btnNavPrev.TabIndex = 40
        Me.btnNavPrev.Text = "<"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.BackColor = System.Drawing.Color.White
        Me.lblNavLocation.Location = New System.Drawing.Point(416, 416)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Size = New System.Drawing.Size(95, 23)
        Me.lblNavLocation.TabIndex = 41
        Me.lblNavLocation.Text = "No Records"
        Me.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNavNext
        '
        Me.btnNavNext.Location = New System.Drawing.Point(504, 416)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(35, 23)
        Me.btnNavNext.TabIndex = 42
        Me.btnNavNext.Text = ">"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(544, 416)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(40, 23)
        Me.btnLast.TabIndex = 43
        Me.btnLast.Text = ">>"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(200, 416)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "&Cancel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblDOB, Me.lblCBtime, Me.lblFname, Me.editPhone, Me.lblPhone, Me.editFname, Me.editLname, Me.lblLname, Me.editCBtime, Me.editDOB, Me.editComments, Me.lblComments, Me.lblAnonReq, Me.editAnonReq})
        Me.GroupBox1.Location = New System.Drawing.Point(24, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 240)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Caller Info"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblConfirmation, Me.editConfirmation, Me.lblLang, Me.editLang, Me.lblSID, Me.editSID, Me.lblSubscriber, Me.editSubscriber, Me.lblCallDate, Me.editCallDate, Me.editCallStatus, Me.lblCallStatus})
        Me.GroupBox2.Location = New System.Drawing.Point(24, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 128)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Subscriber Info"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblverified, Me.editverified, Me.editVerifiedby, Me.lblVerifiedby, Me.editVerifiedDate, Me.lblVerifiedDate})
        Me.GroupBox3.Location = New System.Drawing.Point(472, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(208, 80)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Caller Verified"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ReportData", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AutoID", "AutoID"), New System.Data.Common.DataColumnMapping("CallID", "CallID"), New System.Data.Common.DataColumnMapping("Confirmation", "Confirmation"), New System.Data.Common.DataColumnMapping("SID", "SID"), New System.Data.Common.DataColumnMapping("Subscriber", "Subscriber"), New System.Data.Common.DataColumnMapping("Fname", "Fname"), New System.Data.Common.DataColumnMapping("Lname", "Lname"), New System.Data.Common.DataColumnMapping("DOB", "DOB"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("CBtime", "CBtime"), New System.Data.Common.DataColumnMapping("AnonReq", "AnonReq"), New System.Data.Common.DataColumnMapping("Lang", "Lang"), New System.Data.Common.DataColumnMapping("Comments", "Comments"), New System.Data.Common.DataColumnMapping("verified", "verified"), New System.Data.Common.DataColumnMapping("Verifiedby", "Verifiedby"), New System.Data.Common.DataColumnMapping("VerifiedDate", "VerifiedDate"), New System.Data.Common.DataColumnMapping("CallDate", "CallDate"), New System.Data.Common.DataColumnMapping("CallStatus", "CallStatus")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM ReportData WHERE (AutoID = ?) AND (AnonReq = ? OR ? IS NULL AND AnonR" & _
        "eq IS NULL) AND (CBtime = ? OR ? IS NULL AND CBtime IS NULL) AND (CallDate = ? O" & _
        "R ? IS NULL AND CallDate IS NULL) AND (CallID = ? OR ? IS NULL AND CallID IS NUL" & _
        "L) AND (CallStatus = ? OR ? IS NULL AND CallStatus IS NULL) AND (Comments = ? OR" & _
        " ? IS NULL AND Comments IS NULL) AND (Confirmation = ? OR ? IS NULL AND Confirma" & _
        "tion IS NULL) AND (DOB = ? OR ? IS NULL AND DOB IS NULL) AND (Fname = ? OR ? IS " & _
        "NULL AND Fname IS NULL) AND (Lang = ? OR ? IS NULL AND Lang IS NULL) AND (Lname " & _
        "= ? OR ? IS NULL AND Lname IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NUL" & _
        "L) AND (SID = ? OR ? IS NULL AND SID IS NULL) AND (Subscriber = ? OR ? IS NULL A" & _
        "ND Subscriber IS NULL) AND (VerifiedDate = ? OR ? IS NULL AND VerifiedDate IS NU" & _
        "LL) AND (Verifiedby = ? OR ? IS NULL AND Verifiedby IS NULL) AND (verified = ?)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AutoID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "AutoID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnonReq", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnonReq", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnonReq1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnonReq", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBtime", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBtime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBtime1", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBtime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallStatus", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallStatus", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallStatus1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallStatus", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Confirmation", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Confirmation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Confirmation1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Confirmation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DOB", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DOB1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fname1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lang", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lang", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lang1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lang", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lname1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SID", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SID1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Subscriber", System.Data.OleDb.OleDbType.VarWChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subscriber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Subscriber1", System.Data.OleDb.OleDbType.VarWChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subscriber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VerifiedDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VerifiedDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VerifiedDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VerifiedDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Verifiedby", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Verifiedby", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Verifiedby1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Verifiedby", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_verified", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "verified", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program" & _
        " Files\Pronexus\VBVoice\examples\dotnet\CustPhrs\bin\CorPaccHL.mdb;Mode=Share De" & _
        "ny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry P" & _
        "ath="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database" & _
        " Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transa" & _
        "ctions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=Fal" & _
        "se;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False" & _
        ";Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO ReportData(AnonReq, CallDate, CallID, CallStatus, CBtime, Comments, C" & _
        "onfirmation, DOB, Fname, Lang, Lname, Phone, SID, Subscriber, verified, Verified" & _
        "by, VerifiedDate) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnonReq", System.Data.OleDb.OleDbType.VarWChar, 15, "AnonReq"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallDate", System.Data.OleDb.OleDbType.DBDate, 0, "CallDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallID", System.Data.OleDb.OleDbType.VarWChar, 20, "CallID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallStatus", System.Data.OleDb.OleDbType.VarWChar, 50, "CallStatus"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CBtime", System.Data.OleDb.OleDbType.VarWChar, 25, "CBtime"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Comments", System.Data.OleDb.OleDbType.VarWChar, 255, "Comments"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Confirmation", System.Data.OleDb.OleDbType.VarWChar, 20, "Confirmation"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DOB", System.Data.OleDb.OleDbType.VarWChar, 50, "DOB"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Fname", System.Data.OleDb.OleDbType.VarWChar, 20, "Fname"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Lang", System.Data.OleDb.OleDbType.VarWChar, 10, "Lang"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Lname", System.Data.OleDb.OleDbType.VarWChar, 20, "Lname"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 50, "Phone"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SID", System.Data.OleDb.OleDbType.VarWChar, 10, "SID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Subscriber", System.Data.OleDb.OleDbType.VarWChar, 35, "Subscriber"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("verified", System.Data.OleDb.OleDbType.Boolean, 2, "verified"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Verifiedby", System.Data.OleDb.OleDbType.VarWChar, 20, "Verifiedby"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("VerifiedDate", System.Data.OleDb.OleDbType.DBDate, 0, "VerifiedDate"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT AnonReq, AutoID, CallDate, CallID, CallStatus, CBtime, Comments, Confirmat" & _
        "ion, DOB, Fname, Lang, Lname, Phone, SID, Subscriber, verified, Verifiedby, Veri" & _
        "fiedDate FROM ReportData WHERE (verified = 'False')"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE ReportData SET AnonReq = ?, CallDate = ?, CallID = ?, CallStatus = ?, CBti" & _
        "me = ?, Comments = ?, Confirmation = ?, DOB = ?, Fname = ?, Lang = ?, Lname = ?," & _
        " Phone = ?, SID = ?, Subscriber = ?, verified = ?, Verifiedby = ?, VerifiedDate " & _
        "= ? WHERE (AutoID = ?) AND (AnonReq = ? OR ? IS NULL AND AnonReq IS NULL) AND (C" & _
        "Btime = ? OR ? IS NULL AND CBtime IS NULL) AND (CallDate = ? OR ? IS NULL AND Ca" & _
        "llDate IS NULL) AND (CallID = ? OR ? IS NULL AND CallID IS NULL) AND (CallStatus" & _
        " = ? OR ? IS NULL AND CallStatus IS NULL) AND (Comments = ? OR ? IS NULL AND Com" & _
        "ments IS NULL) AND (Confirmation = ? OR ? IS NULL AND Confirmation IS NULL) AND " & _
        "(DOB = ? OR ? IS NULL AND DOB IS NULL) AND (Fname = ? OR ? IS NULL AND Fname IS " & _
        "NULL) AND (Lang = ? OR ? IS NULL AND Lang IS NULL) AND (Lname = ? OR ? IS NULL A" & _
        "ND Lname IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL) AND (SID = ? OR" & _
        " ? IS NULL AND SID IS NULL) AND (Subscriber = ? OR ? IS NULL AND Subscriber IS N" & _
        "ULL) AND (VerifiedDate = ? OR ? IS NULL AND VerifiedDate IS NULL) AND (Verifiedb" & _
        "y = ? OR ? IS NULL AND Verifiedby IS NULL) AND (verified = ?)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnonReq", System.Data.OleDb.OleDbType.VarWChar, 15, "AnonReq"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallDate", System.Data.OleDb.OleDbType.DBDate, 0, "CallDate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallID", System.Data.OleDb.OleDbType.VarWChar, 20, "CallID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallStatus", System.Data.OleDb.OleDbType.VarWChar, 50, "CallStatus"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CBtime", System.Data.OleDb.OleDbType.VarWChar, 25, "CBtime"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Comments", System.Data.OleDb.OleDbType.VarWChar, 255, "Comments"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Confirmation", System.Data.OleDb.OleDbType.VarWChar, 20, "Confirmation"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DOB", System.Data.OleDb.OleDbType.VarWChar, 50, "DOB"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Fname", System.Data.OleDb.OleDbType.VarWChar, 20, "Fname"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Lang", System.Data.OleDb.OleDbType.VarWChar, 10, "Lang"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Lname", System.Data.OleDb.OleDbType.VarWChar, 20, "Lname"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 50, "Phone"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SID", System.Data.OleDb.OleDbType.VarWChar, 10, "SID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Subscriber", System.Data.OleDb.OleDbType.VarWChar, 35, "Subscriber"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("verified", System.Data.OleDb.OleDbType.Boolean, 2, "verified"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Verifiedby", System.Data.OleDb.OleDbType.VarWChar, 20, "Verifiedby"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("VerifiedDate", System.Data.OleDb.OleDbType.DBDate, 0, "VerifiedDate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AutoID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "AutoID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnonReq", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnonReq", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnonReq1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnonReq", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBtime", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBtime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBtime1", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBtime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallStatus", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallStatus", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallStatus1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallStatus", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Confirmation", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Confirmation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Confirmation1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Confirmation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DOB", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DOB1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fname1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lang", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lang", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lang1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lang", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lname1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SID", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SID1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Subscriber", System.Data.OleDb.OleDbType.VarWChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subscriber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Subscriber1", System.Data.OleDb.OleDbType.VarWChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subscriber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VerifiedDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VerifiedDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VerifiedDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VerifiedDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Verifiedby", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Verifiedby", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Verifiedby1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Verifiedby", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_verified", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "verified", System.Data.DataRowVersion.Original, Nothing))
        '
        'ReportData
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(752, 447)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3, Me.GroupBox2, Me.GroupBox1, Me.btnLoad, Me.btnUpdate, Me.btnCancelAll, Me.lblAutoID, Me.editAutoID, Me.lblCallID, Me.editCallID, Me.btnNavFirst, Me.btnNavPrev, Me.lblNavLocation, Me.btnNavNext, Me.btnLast, Me.btnCancel})
        Me.Name = "ReportData"
        Me.Text = "ReportData"
        CType(Me.objmyrepdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(objmyrepdata, "ReportData").CancelCurrentEdit()
        Me.objmyrepdata_PositionChanged()

    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            'Attempt to update the datasource.
            Me.UpdateDataSet()
        Catch eUpdate As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        End Try
        Me.objmyrepdata_PositionChanged()

    End Sub
    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objmyrepdata_PositionChanged()

    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavFirst.Click
        Me.BindingContext(objmyrepdata, "ReportData").Position = 0
        Me.objmyrepdata_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(objmyrepdata, "ReportData").Position = (Me.objmyrepdata.Tables("ReportData").Rows.Count - 1)
        Me.objmyrepdata_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavPrev.Click
        Me.BindingContext(objmyrepdata, "ReportData").Position = (Me.BindingContext(objmyrepdata, "ReportData").Position - 1)
        Me.objmyrepdata_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavNext.Click
        Me.BindingContext(objmyrepdata, "ReportData").Position = (Me.BindingContext(objmyrepdata, "ReportData").Position + 1)
        Me.objmyrepdata_PositionChanged()

    End Sub
    Private Sub objmyrepdata_PositionChanged()
        Me.lblNavLocation.Text = (((Me.BindingContext(objmyrepdata, "ReportData").Position + 1).ToString + " of  ") _
                    + Me.BindingContext(objmyrepdata, "ReportData").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAll.Click
        Me.objmyrepdata.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As CustPhrs.myrepdata = New CustPhrs.myrepdata()
        Dim objDataSetUpdated As System.Data.DataSet = New CustPhrs.myrepdata()
        'Stop any current edits.
        Me.BindingContext(objmyrepdata, "ReportData").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objmyrepdata.GetChanges, CustPhrs.myrepdata)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                objDataSetUpdated = Me.objmyrepdata.Clone
            Catch eUpdate As System.Exception
                'Add your error handling code here.
                Throw eUpdate
            End Try
            'Add your code to check the returned dataset for any errors that may have been
            'pushed into the row object's error.
            Try
                objmyrepdata.Merge(objDataSetUpdated)
            Catch eUpdateMerge As System.Exception
                'Add exception handling code here
                Throw eUpdateMerge
            End Try
            'Commit the changes that were just merged
            'This moves any rows marked as updated, inserted or changed to being marked as original values
            objmyrepdata.AcceptChanges()
        End If

    End Sub
    Public Sub LoadDataSet()
        'Create a new dataset to hold the records returned from the call to FillDataSet.
        'A temporary dataset is used because filling the existing dataset would
        'require the databindings to be rebound.
        Dim objDataSetTemp As CustPhrs.myrepdata
        objDataSetTemp = New CustPhrs.myrepdata()
        Try
            'Attempt to fill the temporary dataset.
            objDataSetTemp = Me.objmyrepdata.Clone

        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            objmyrepdata.Clear()
            'Merge the records into the main dataset.
            objmyrepdata.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
End Class
