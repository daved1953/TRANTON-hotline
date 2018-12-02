Public Class Main

    Inherits System.Windows.Forms.Form

    Public Shared lcnt(5) As Integer               'used to track certain loops like birthdate and area code phone number get digits
    Public Shared Strxp(5) As String            'used when collecting loop data like area code and phone number or  birthdate information
    Public Shared VapFile(5) As String
    Public Shared Vapcom As String
    Public Shared tmpConNum(5) As String
    Public Shared Conf(5) As String


    'Data Constructs
    Public Shared qmdataset As New DataSet()      'QMaster DataSet
    Public Shared qmtable As DataTable = qmdataset.Tables.Add("QmasterDT") 'Data Table that holds question Logic
    Public Shared dmdataset As New DataSet()      'Dmaker DS
    Public Shared dmtable As DataTable = dmdataset.Tables.Add("dmasterDT") 'DataTable that holds discesion branch info
    'Public Shared RepDataDS As New DataSet()   'Report DataSet
    'Public Shared Reptable As DataTable = RepDataDS.Tables.Add("RepDataT") 'DataTable that holds update info for the header record
    'Public Shared RDtable As DataTable = RepDataDS.Tables.Add("RespDataT") 'DataTable that holds Update detail options selected for quistions
    Public Shared RDrow(5) As DataRow
    'Public Shared Reprow As DataRow
    Public Shared Reprow(5) As DataRow
    Public Shared repdata(5, 2, 20) As String
    Public Shared Linecalls(4) As Int16


    Public Shared QID(5) As String              'Array that contains current Question ID
    Public Shared MaxD(5) As String             'The max total of responses used to build answer phrases
    Public Shared NxtQID(5) As String           'The next Question ID
    Public Shared QType(5) As String            'Used to determin the question type
    Public Shared Dindex(5) As Integer          'Index of selected option for decision maker
    Friend WithEvents cmdStart As Button
    Public Shared MDXindex(5) As Integer        'index on MX questions to advance to next Q


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
    Friend WithEvents VbvFrame1 As Pronexus.VBVoice.VBVFrame
    Friend WithEvents LineGroup1 As Pronexus.VBVoice.LineGroup
    Friend WithEvents OnHook1 As Pronexus.VBVoice.OnHook
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents Msurvey As Pronexus.VBVoice.GetDigits
    Friend WithEvents InitGreet As Pronexus.VBVoice.PlayGreeting
    Friend WithEvents Spanish As Pronexus.VBVoice.Lang
    Friend WithEvents LangSelect As Pronexus.VBVoice.GetDigits
    Friend WithEvents Playresponse As Pronexus.VBVoice.GetDigits
    Friend WithEvents User1 As Pronexus.VBVoice.User
    Friend WithEvents LblSpeed As System.Windows.Forms.Label
    Friend WithEvents SpeedControl As System.Windows.Forms.NumericUpDown
    Friend WithEvents VolumeControl As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblVolume As System.Windows.Forms.Label
    Friend WithEvents openstatment As Pronexus.VBVoice.PlayGreeting
    Friend WithEvents L7000 As Pronexus.VBVoice.PlayGreeting
    Friend WithEvents L7001 As Pronexus.VBVoice.GetDigits
    Friend WithEvents L7002 As Pronexus.VBVoice.GetDigits
    Friend WithEvents L7003 As Pronexus.VBVoice.GetDigits
    Friend WithEvents L7004 As Pronexus.VBVoice.Record
    Friend WithEvents L7007 As Pronexus.VBVoice.GetDigits
    Friend WithEvents L7008 As Pronexus.VBVoice.GetDigits
    Friend WithEvents confDOB As Pronexus.VBVoice.GetDigits
    Friend WithEvents ConfACPhone As Pronexus.VBVoice.GetDigits
    Friend WithEvents L7005 As Pronexus.VBVoice.GetDigits
    Friend WithEvents GetCoID As Pronexus.VBVoice.GetDigits
    Friend WithEvents L7009 As Pronexus.VBVoice.GetDigits
    Friend WithEvents ConfBest As Pronexus.VBVoice.GetDigits
    Friend WithEvents Confirmation As Pronexus.VBVoice.PlayGreeting
    Friend WithEvents L7010 As Pronexus.VBVoice.GetDigits
    Friend WithEvents ConfCOID As Pronexus.VBVoice.GetDigits
    Friend WithEvents L7014 As Pronexus.VBVoice.PlayGreeting
    Friend WithEvents checkdata As System.Windows.Forms.Button
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents myResAdapt As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents myrepadapt As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents L7013 As Pronexus.VBVoice.GetDigits
    Friend WithEvents L7012 As Pronexus.VBVoice.GetDigits
    Friend WithEvents PlaySpecial As Pronexus.VBVoice.PlayGreeting
    Friend WithEvents L6006 As Pronexus.VBVoice.Record
    Friend WithEvents Linestatus1 As Pronexus.VBVoice.Linestatus
    'Friend WithEvents MyResData1 As CustPhrs.myresdata
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Myrepdata1 As CustPhrs.myrepdata
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Myresdata1 As CustPhrs.myresdata
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.VbvFrame1 = New Pronexus.VBVoice.VBVFrame()
        Me.PlaySpecial = New Pronexus.VBVoice.PlayGreeting()
        Me.LineGroup1 = New Pronexus.VBVoice.LineGroup()
        Me.Msurvey = New Pronexus.VBVoice.GetDigits()
        Me.OnHook1 = New Pronexus.VBVoice.OnHook()
        Me.InitGreet = New Pronexus.VBVoice.PlayGreeting()
        Me.Spanish = New Pronexus.VBVoice.Lang()
        Me.LangSelect = New Pronexus.VBVoice.GetDigits()
        Me.Playresponse = New Pronexus.VBVoice.GetDigits()
        Me.User1 = New Pronexus.VBVoice.User()
        Me.openstatment = New Pronexus.VBVoice.PlayGreeting()
        Me.L7000 = New Pronexus.VBVoice.PlayGreeting()
        Me.L7001 = New Pronexus.VBVoice.GetDigits()
        Me.L7002 = New Pronexus.VBVoice.GetDigits()
        Me.L7003 = New Pronexus.VBVoice.GetDigits()
        Me.L7004 = New Pronexus.VBVoice.Record()
        Me.L7007 = New Pronexus.VBVoice.GetDigits()
        Me.L7008 = New Pronexus.VBVoice.GetDigits()
        Me.confDOB = New Pronexus.VBVoice.GetDigits()
        Me.ConfACPhone = New Pronexus.VBVoice.GetDigits()
        Me.L7005 = New Pronexus.VBVoice.GetDigits()
        Me.GetCoID = New Pronexus.VBVoice.GetDigits()
        Me.L7009 = New Pronexus.VBVoice.GetDigits()
        Me.ConfBest = New Pronexus.VBVoice.GetDigits()
        Me.L7010 = New Pronexus.VBVoice.GetDigits()
        Me.Confirmation = New Pronexus.VBVoice.PlayGreeting()
        Me.L7014 = New Pronexus.VBVoice.PlayGreeting()
        Me.ConfCOID = New Pronexus.VBVoice.GetDigits()
        Me.L7013 = New Pronexus.VBVoice.GetDigits()
        Me.L7012 = New Pronexus.VBVoice.GetDigits()
        Me.L6006 = New Pronexus.VBVoice.Record()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.LblSpeed = New System.Windows.Forms.Label()
        Me.SpeedControl = New System.Windows.Forms.NumericUpDown()
        Me.VolumeControl = New System.Windows.Forms.NumericUpDown()
        Me.LblVolume = New System.Windows.Forms.Label()
        Me.checkdata = New System.Windows.Forms.Button()
        Me.myResAdapt = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.myrepadapt = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.Linestatus1 = New Pronexus.VBVoice.Linestatus()
        Me.Myrepdata1 = New CustPhrs.myrepdata()
        Me.Myresdata1 = New CustPhrs.myresdata()
        Me.cmdStart = New System.Windows.Forms.Button()
        CType(Me.VbvFrame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VbvFrame1.SuspendLayout()
        CType(Me.PlaySpecial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Msurvey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OnHook1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InitGreet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Spanish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LangSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Playresponse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.openstatment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.L7000, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.L7001, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.L7002, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.L7003, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.L7004, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.L7007, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.L7008, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.confDOB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfACPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.L7005, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetCoID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.L7009, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfBest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.L7010, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Confirmation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.L7014, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfCOID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.L7013, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.L7012, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.L6006, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpeedControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Linestatus1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Myrepdata1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Myresdata1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VbvFrame1
        '
        Me.VbvFrame1.Controls.Add(Me.PlaySpecial)
        Me.VbvFrame1.Controls.Add(Me.LineGroup1)
        Me.VbvFrame1.Controls.Add(Me.Msurvey)
        Me.VbvFrame1.Controls.Add(Me.OnHook1)
        Me.VbvFrame1.Controls.Add(Me.InitGreet)
        Me.VbvFrame1.Controls.Add(Me.Spanish)
        Me.VbvFrame1.Controls.Add(Me.LangSelect)
        Me.VbvFrame1.Controls.Add(Me.Playresponse)
        Me.VbvFrame1.Controls.Add(Me.User1)
        Me.VbvFrame1.Controls.Add(Me.openstatment)
        Me.VbvFrame1.Controls.Add(Me.L7000)
        Me.VbvFrame1.Controls.Add(Me.L7001)
        Me.VbvFrame1.Controls.Add(Me.L7002)
        Me.VbvFrame1.Controls.Add(Me.L7003)
        Me.VbvFrame1.Controls.Add(Me.L7004)
        Me.VbvFrame1.Controls.Add(Me.L7007)
        Me.VbvFrame1.Controls.Add(Me.L7008)
        Me.VbvFrame1.Controls.Add(Me.confDOB)
        Me.VbvFrame1.Controls.Add(Me.ConfACPhone)
        Me.VbvFrame1.Controls.Add(Me.L7005)
        Me.VbvFrame1.Controls.Add(Me.GetCoID)
        Me.VbvFrame1.Controls.Add(Me.L7009)
        Me.VbvFrame1.Controls.Add(Me.ConfBest)
        Me.VbvFrame1.Controls.Add(Me.L7010)
        Me.VbvFrame1.Controls.Add(Me.Confirmation)
        Me.VbvFrame1.Controls.Add(Me.L7014)
        Me.VbvFrame1.Controls.Add(Me.ConfCOID)
        Me.VbvFrame1.Controls.Add(Me.L7013)
        Me.VbvFrame1.Controls.Add(Me.L7012)
        Me.VbvFrame1.Controls.Add(Me.L6006)
        Me.VbvFrame1.Location = New System.Drawing.Point(115, 10)
        Me.VbvFrame1.Name = "VbvFrame1"
        Me.VbvFrame1.PropertyBag = resources.GetString("VbvFrame1.PropertyBag")
        Me.VbvFrame1.Size = New System.Drawing.Size(856, 475)
        Me.VbvFrame1.TabIndex = 9
        '
        'PlaySpecial
        '
        Me.PlaySpecial.Location = New System.Drawing.Point(282, 315)
        Me.PlaySpecial.Name = "PlaySpecial"
        Me.PlaySpecial.PropertyBag = resources.GetString("PlaySpecial.PropertyBag")
        Me.PlaySpecial.TabIndex = 54
        '
        'LineGroup1
        '
        Me.LineGroup1.Location = New System.Drawing.Point(24, 35)
        Me.LineGroup1.Name = "LineGroup1"
        Me.LineGroup1.PropertyBag = resources.GetString("LineGroup1.PropertyBag")
        Me.LineGroup1.TabIndex = 1
        '
        'Msurvey
        '
        Me.Msurvey.Location = New System.Drawing.Point(646, 215)
        Me.Msurvey.Name = "Msurvey"
        Me.Msurvey.PropertyBag = resources.GetString("Msurvey.PropertyBag")
        Me.Msurvey.TabIndex = 2
        '
        'OnHook1
        '
        Me.OnHook1.Location = New System.Drawing.Point(752, 129)
        Me.OnHook1.Name = "OnHook1"
        Me.OnHook1.PropertyBag = resources.GetString("OnHook1.PropertyBag")
        Me.OnHook1.TabIndex = 4
        '
        'InitGreet
        '
        Me.InitGreet.Location = New System.Drawing.Point(136, 55)
        Me.InitGreet.Name = "InitGreet"
        Me.InitGreet.PropertyBag = resources.GetString("InitGreet.PropertyBag")
        Me.InitGreet.TabIndex = 10
        '
        'Spanish
        '
        Me.Spanish.Location = New System.Drawing.Point(336, 69)
        Me.Spanish.Name = "Spanish"
        Me.Spanish.PropertyBag = resources.GetString("Spanish.PropertyBag")
        Me.Spanish.TabIndex = 11
        '
        'LangSelect
        '
        Me.LangSelect.Location = New System.Drawing.Point(240, 35)
        Me.LangSelect.Name = "LangSelect"
        Me.LangSelect.PropertyBag = resources.GetString("LangSelect.PropertyBag")
        Me.LangSelect.TabIndex = 12
        '
        'Playresponse
        '
        Me.Playresponse.Location = New System.Drawing.Point(568, 42)
        Me.Playresponse.Name = "Playresponse"
        Me.Playresponse.PropertyBag = resources.GetString("Playresponse.PropertyBag")
        Me.Playresponse.TabIndex = 13
        '
        'User1
        '
        Me.User1.Location = New System.Drawing.Point(144, 250)
        Me.User1.Name = "User1"
        Me.User1.PropertyBag = resources.GetString("User1.PropertyBag")
        Me.User1.TabIndex = 14
        '
        'openstatment
        '
        Me.openstatment.Location = New System.Drawing.Point(432, 42)
        Me.openstatment.Name = "openstatment"
        Me.openstatment.PropertyBag = resources.GetString("openstatment.PropertyBag")
        Me.openstatment.TabIndex = 24
        '
        'L7000
        '
        Me.L7000.Location = New System.Drawing.Point(88, 2065)
        Me.L7000.Name = "L7000"
        Me.L7000.PropertyBag = resources.GetString("L7000.PropertyBag")
        Me.L7000.TabIndex = 30
        '
        'L7001
        '
        Me.L7001.Location = New System.Drawing.Point(200, 2046)
        Me.L7001.Name = "L7001"
        Me.L7001.PropertyBag = resources.GetString("L7001.PropertyBag")
        Me.L7001.TabIndex = 31
        '
        'L7002
        '
        Me.L7002.Location = New System.Drawing.Point(304, 2046)
        Me.L7002.Name = "L7002"
        Me.L7002.PropertyBag = resources.GetString("L7002.PropertyBag")
        Me.L7002.TabIndex = 32
        '
        'L7003
        '
        Me.L7003.Location = New System.Drawing.Point(400, 2046)
        Me.L7003.Name = "L7003"
        Me.L7003.PropertyBag = resources.GetString("L7003.PropertyBag")
        Me.L7003.TabIndex = 33
        '
        'L7004
        '
        Me.L7004.Location = New System.Drawing.Point(648, 2046)
        Me.L7004.Name = "L7004"
        Me.L7004.PropertyBag = resources.GetString("L7004.PropertyBag")
        Me.L7004.TabIndex = 34
        '
        'L7007
        '
        Me.L7007.Location = New System.Drawing.Point(160, 2212)
        Me.L7007.Name = "L7007"
        Me.L7007.PropertyBag = resources.GetString("L7007.PropertyBag")
        Me.L7007.TabIndex = 35
        '
        'L7008
        '
        Me.L7008.Location = New System.Drawing.Point(272, 2222)
        Me.L7008.Name = "L7008"
        Me.L7008.PropertyBag = resources.GetString("L7008.PropertyBag")
        Me.L7008.TabIndex = 36
        '
        'confDOB
        '
        Me.confDOB.Location = New System.Drawing.Point(480, 2046)
        Me.confDOB.Name = "confDOB"
        Me.confDOB.PropertyBag = resources.GetString("confDOB.PropertyBag")
        Me.confDOB.TabIndex = 37
        '
        'ConfACPhone
        '
        Me.ConfACPhone.Location = New System.Drawing.Point(376, 2212)
        Me.ConfACPhone.Name = "ConfACPhone"
        Me.ConfACPhone.PropertyBag = resources.GetString("ConfACPhone.PropertyBag")
        Me.ConfACPhone.TabIndex = 38
        '
        'L7005
        '
        Me.L7005.Location = New System.Drawing.Point(160, 2332)
        Me.L7005.Name = "L7005"
        Me.L7005.PropertyBag = resources.GetString("L7005.PropertyBag")
        Me.L7005.TabIndex = 39
        '
        'GetCoID
        '
        Me.GetCoID.Location = New System.Drawing.Point(248, 2332)
        Me.GetCoID.Name = "GetCoID"
        Me.GetCoID.PropertyBag = resources.GetString("GetCoID.PropertyBag")
        Me.GetCoID.TabIndex = 40
        '
        'L7009
        '
        Me.L7009.Location = New System.Drawing.Point(488, 2212)
        Me.L7009.Name = "L7009"
        Me.L7009.PropertyBag = resources.GetString("L7009.PropertyBag")
        Me.L7009.TabIndex = 41
        '
        'ConfBest
        '
        Me.ConfBest.Location = New System.Drawing.Point(616, 2222)
        Me.ConfBest.Name = "ConfBest"
        Me.ConfBest.PropertyBag = resources.GetString("ConfBest.PropertyBag")
        Me.ConfBest.TabIndex = 42
        '
        'L7010
        '
        Me.L7010.Location = New System.Drawing.Point(432, 2342)
        Me.L7010.Name = "L7010"
        Me.L7010.PropertyBag = resources.GetString("L7010.PropertyBag")
        Me.L7010.TabIndex = 43
        '
        'Confirmation
        '
        Me.Confirmation.Location = New System.Drawing.Point(520, 2332)
        Me.Confirmation.Name = "Confirmation"
        Me.Confirmation.PropertyBag = resources.GetString("Confirmation.PropertyBag")
        Me.Confirmation.TabIndex = 44
        '
        'L7014
        '
        Me.L7014.Location = New System.Drawing.Point(488, 284)
        Me.L7014.Name = "L7014"
        Me.L7014.PropertyBag = resources.GetString("L7014.PropertyBag")
        Me.L7014.TabIndex = 47
        '
        'ConfCOID
        '
        Me.ConfCOID.Location = New System.Drawing.Point(344, 2332)
        Me.ConfCOID.Name = "ConfCOID"
        Me.ConfCOID.PropertyBag = resources.GetString("ConfCOID.PropertyBag")
        Me.ConfCOID.TabIndex = 48
        '
        'L7013
        '
        Me.L7013.Location = New System.Drawing.Point(384, 215)
        Me.L7013.Name = "L7013"
        Me.L7013.PropertyBag = resources.GetString("L7013.PropertyBag")
        Me.L7013.TabIndex = 50
        '
        'L7012
        '
        Me.L7012.Location = New System.Drawing.Point(624, 2332)
        Me.L7012.Name = "L7012"
        Me.L7012.PropertyBag = resources.GetString("L7012.PropertyBag")
        Me.L7012.TabIndex = 51
        '
        'L6006
        '
        Me.L6006.Location = New System.Drawing.Point(80, 2268)
        Me.L6006.Name = "L6006"
        Me.L6006.PropertyBag = resources.GetString("L6006.PropertyBag")
        Me.L6006.TabIndex = 53
        '
        'cmdStop
        '
        Me.cmdStop.Location = New System.Drawing.Point(885, 491)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(75, 22)
        Me.cmdStop.TabIndex = 6
        Me.cmdStop.Text = "Stop"
        '
        'LblSpeed
        '
        Me.LblSpeed.Location = New System.Drawing.Point(812, 432)
        Me.LblSpeed.Name = "LblSpeed"
        Me.LblSpeed.Size = New System.Drawing.Size(55, 15)
        Me.LblSpeed.TabIndex = 17
        Me.LblSpeed.Text = "Speed"
        '
        'SpeedControl
        '
        Me.SpeedControl.Location = New System.Drawing.Point(896, 428)
        Me.SpeedControl.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SpeedControl.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.SpeedControl.Name = "SpeedControl"
        Me.SpeedControl.Size = New System.Drawing.Size(31, 20)
        Me.SpeedControl.TabIndex = 18
        '
        'VolumeControl
        '
        Me.VolumeControl.Location = New System.Drawing.Point(896, 465)
        Me.VolumeControl.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.VolumeControl.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.VolumeControl.Name = "VolumeControl"
        Me.VolumeControl.Size = New System.Drawing.Size(32, 20)
        Me.VolumeControl.TabIndex = 20
        '
        'LblVolume
        '
        Me.LblVolume.Location = New System.Drawing.Point(812, 467)
        Me.LblVolume.Name = "LblVolume"
        Me.LblVolume.Size = New System.Drawing.Size(71, 16)
        Me.LblVolume.TabIndex = 19
        Me.LblVolume.Text = "Volume"
        '
        'checkdata
        '
        Me.checkdata.Location = New System.Drawing.Point(722, 489)
        Me.checkdata.Name = "checkdata"
        Me.checkdata.Size = New System.Drawing.Size(80, 24)
        Me.checkdata.TabIndex = 49
        Me.checkdata.Text = "Reports"
        '
        'myResAdapt
        '
        Me.myResAdapt.DeleteCommand = Me.OleDbDeleteCommand1
        Me.myResAdapt.InsertCommand = Me.OleDbInsertCommand1
        Me.myResAdapt.SelectCommand = Me.OleDbSelectCommand1
        Me.myResAdapt.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Respdata", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("CallID", "CallID"), New System.Data.Common.DataColumnMapping("QID", "QID"), New System.Data.Common.DataColumnMapping("Dcollect", "Dcollect")})})
        Me.myResAdapt.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Respdata WHERE (id = ?) AND (CallID = ? OR ? IS NULL AND CallID IS NU" &
    "LL) AND (Dcollect = ? OR ? IS NULL AND Dcollect IS NULL) AND (QID = ? OR ? IS NU" &
    "LL AND QID IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CallID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CallID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Dcollect", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dcollect", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Dcollect1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dcollect", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_QID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_QID1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = resources.GetString("OleDbConnection1.ConnectionString")
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Respdata(CallID, Dcollect, QID) VALUES (?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CallID", System.Data.OleDb.OleDbType.VarWChar, 20, "CallID"), New System.Data.OleDb.OleDbParameter("Dcollect", System.Data.OleDb.OleDbType.VarWChar, 10, "Dcollect"), New System.Data.OleDb.OleDbParameter("QID", System.Data.OleDb.OleDbType.VarWChar, 5, "QID")})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT CallID, Dcollect, id, QID FROM Respdata"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CallID", System.Data.OleDb.OleDbType.VarWChar, 20, "CallID"), New System.Data.OleDb.OleDbParameter("Dcollect", System.Data.OleDb.OleDbType.VarWChar, 10, "Dcollect"), New System.Data.OleDb.OleDbParameter("QID", System.Data.OleDb.OleDbType.VarWChar, 5, "QID"), New System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CallID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CallID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Dcollect", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dcollect", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Dcollect1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dcollect", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_QID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_QID1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'myrepadapt
        '
        Me.myrepadapt.DeleteCommand = Me.OleDbDeleteCommand2
        Me.myrepadapt.InsertCommand = Me.OleDbInsertCommand2
        Me.myrepadapt.SelectCommand = Me.OleDbSelectCommand2
        Me.myrepadapt.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ReportData", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AnonReq", "AnonReq"), New System.Data.Common.DataColumnMapping("AutoID", "AutoID"), New System.Data.Common.DataColumnMapping("CallDate", "CallDate"), New System.Data.Common.DataColumnMapping("CallStatus", "CallStatus"), New System.Data.Common.DataColumnMapping("CBtime", "CBtime"), New System.Data.Common.DataColumnMapping("Comments", "Comments"), New System.Data.Common.DataColumnMapping("Confirmation", "Confirmation"), New System.Data.Common.DataColumnMapping("DOB", "DOB"), New System.Data.Common.DataColumnMapping("Fname", "Fname"), New System.Data.Common.DataColumnMapping("Lang", "Lang"), New System.Data.Common.DataColumnMapping("Lname", "Lname"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("SID", "SID"), New System.Data.Common.DataColumnMapping("Subscriber", "Subscriber"), New System.Data.Common.DataColumnMapping("verified", "verified"), New System.Data.Common.DataColumnMapping("Verifiedby", "Verifiedby"), New System.Data.Common.DataColumnMapping("VerifiedDate", "VerifiedDate"), New System.Data.Common.DataColumnMapping("CallID", "CallID")})})
        Me.myrepadapt.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = resources.GetString("OleDbDeleteCommand2.CommandText")
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_AutoID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "AutoID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_AnonReq", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnonReq", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_AnonReq1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnonReq", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CBtime", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBtime", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CBtime1", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBtime", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CallDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CallDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CallID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CallID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CallStatus", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallStatus", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CallStatus1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallStatus", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Confirmation", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Confirmation", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Confirmation1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Confirmation", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DOB", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOB", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DOB1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOB", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fname", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fname1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fname", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Lang", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lang", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Lang1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lang", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Lname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lname", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Lname1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lname", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SID", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SID1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Subscriber", System.Data.OleDb.OleDbType.VarWChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subscriber", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Subscriber1", System.Data.OleDb.OleDbType.VarWChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subscriber", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_VerifiedDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VerifiedDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_VerifiedDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VerifiedDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Verifiedby", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Verifiedby", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Verifiedby1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Verifiedby", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_verified", System.Data.OleDb.OleDbType.[Boolean], 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "verified", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = resources.GetString("OleDbInsertCommand2.CommandText")
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("AnonReq", System.Data.OleDb.OleDbType.VarWChar, 5, "AnonReq"), New System.Data.OleDb.OleDbParameter("CallDate", System.Data.OleDb.OleDbType.DBDate, 0, "CallDate"), New System.Data.OleDb.OleDbParameter("CallStatus", System.Data.OleDb.OleDbType.VarWChar, 50, "CallStatus"), New System.Data.OleDb.OleDbParameter("CBtime", System.Data.OleDb.OleDbType.VarWChar, 25, "CBtime"), New System.Data.OleDb.OleDbParameter("Comments", System.Data.OleDb.OleDbType.VarWChar, 255, "Comments"), New System.Data.OleDb.OleDbParameter("Confirmation", System.Data.OleDb.OleDbType.VarWChar, 20, "Confirmation"), New System.Data.OleDb.OleDbParameter("DOB", System.Data.OleDb.OleDbType.VarWChar, 50, "DOB"), New System.Data.OleDb.OleDbParameter("Fname", System.Data.OleDb.OleDbType.VarWChar, 20, "Fname"), New System.Data.OleDb.OleDbParameter("Lang", System.Data.OleDb.OleDbType.VarWChar, 10, "Lang"), New System.Data.OleDb.OleDbParameter("Lname", System.Data.OleDb.OleDbType.VarWChar, 20, "Lname"), New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 50, "Phone"), New System.Data.OleDb.OleDbParameter("SID", System.Data.OleDb.OleDbType.VarWChar, 10, "SID"), New System.Data.OleDb.OleDbParameter("Subscriber", System.Data.OleDb.OleDbType.VarWChar, 35, "Subscriber"), New System.Data.OleDb.OleDbParameter("verified", System.Data.OleDb.OleDbType.[Boolean], 2, "verified"), New System.Data.OleDb.OleDbParameter("Verifiedby", System.Data.OleDb.OleDbType.VarWChar, 20, "Verifiedby"), New System.Data.OleDb.OleDbParameter("VerifiedDate", System.Data.OleDb.OleDbType.DBDate, 0, "VerifiedDate"), New System.Data.OleDb.OleDbParameter("CallID", System.Data.OleDb.OleDbType.VarWChar, 20, "CallID")})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT AnonReq, AutoID, CallDate, CallStatus, CBtime, Comments, Confirmation, DOB" &
    ", Fname, Lang, Lname, Phone, SID, Subscriber, verified, Verifiedby, VerifiedDate" &
    ", CallID FROM ReportData"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = resources.GetString("OleDbUpdateCommand2.CommandText")
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("AnonReq", System.Data.OleDb.OleDbType.VarWChar, 5, "AnonReq"), New System.Data.OleDb.OleDbParameter("CallDate", System.Data.OleDb.OleDbType.DBDate, 0, "CallDate"), New System.Data.OleDb.OleDbParameter("CallStatus", System.Data.OleDb.OleDbType.VarWChar, 50, "CallStatus"), New System.Data.OleDb.OleDbParameter("CBtime", System.Data.OleDb.OleDbType.VarWChar, 25, "CBtime"), New System.Data.OleDb.OleDbParameter("Comments", System.Data.OleDb.OleDbType.VarWChar, 255, "Comments"), New System.Data.OleDb.OleDbParameter("Confirmation", System.Data.OleDb.OleDbType.VarWChar, 20, "Confirmation"), New System.Data.OleDb.OleDbParameter("DOB", System.Data.OleDb.OleDbType.VarWChar, 50, "DOB"), New System.Data.OleDb.OleDbParameter("Fname", System.Data.OleDb.OleDbType.VarWChar, 20, "Fname"), New System.Data.OleDb.OleDbParameter("Lang", System.Data.OleDb.OleDbType.VarWChar, 10, "Lang"), New System.Data.OleDb.OleDbParameter("Lname", System.Data.OleDb.OleDbType.VarWChar, 20, "Lname"), New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 50, "Phone"), New System.Data.OleDb.OleDbParameter("SID", System.Data.OleDb.OleDbType.VarWChar, 10, "SID"), New System.Data.OleDb.OleDbParameter("Subscriber", System.Data.OleDb.OleDbType.VarWChar, 35, "Subscriber"), New System.Data.OleDb.OleDbParameter("verified", System.Data.OleDb.OleDbType.[Boolean], 2, "verified"), New System.Data.OleDb.OleDbParameter("Verifiedby", System.Data.OleDb.OleDbType.VarWChar, 20, "Verifiedby"), New System.Data.OleDb.OleDbParameter("VerifiedDate", System.Data.OleDb.OleDbType.DBDate, 0, "VerifiedDate"), New System.Data.OleDb.OleDbParameter("CallID", System.Data.OleDb.OleDbType.VarWChar, 20, "CallID"), New System.Data.OleDb.OleDbParameter("Original_AutoID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "AutoID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_AnonReq", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnonReq", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_AnonReq1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnonReq", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CBtime", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBtime", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CBtime1", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBtime", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CallDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CallDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CallID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CallID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CallStatus", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallStatus", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CallStatus1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallStatus", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Confirmation", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Confirmation", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Confirmation1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Confirmation", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DOB", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOB", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DOB1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOB", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fname", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fname1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fname", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Lang", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lang", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Lang1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lang", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Lname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lname", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Lname1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lname", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SID", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SID1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Subscriber", System.Data.OleDb.OleDbType.VarWChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subscriber", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Subscriber1", System.Data.OleDb.OleDbType.VarWChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subscriber", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_VerifiedDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VerifiedDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_VerifiedDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VerifiedDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Verifiedby", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Verifiedby", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Verifiedby1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Verifiedby", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_verified", System.Data.OleDb.OleDbType.[Boolean], 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "verified", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Linestatus1
        '
        Me.Linestatus1.Location = New System.Drawing.Point(161, 519)
        Me.Linestatus1.Name = "Linestatus1"
        Me.Linestatus1.PropertyBag = resources.GetString("Linestatus1.PropertyBag")
        Me.Linestatus1.Size = New System.Drawing.Size(628, 81)
        Me.Linestatus1.TabIndex = 55
        Me.Linestatus1.TabStop = False
        '
        'Myrepdata1
        '
        Me.Myrepdata1.DataSetName = "myrepdata"
        Me.Myrepdata1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.Myrepdata1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Myresdata1
        '
        Me.Myresdata1.DataSetName = "myresdata"
        Me.Myresdata1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.Myresdata1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(808, 491)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(75, 22)
        Me.cmdStart.TabIndex = 56
        Me.cmdStart.Text = "Start"
        '
        'Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1257, 615)
        Me.Controls.Add(Me.VbvFrame1)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.checkdata)
        Me.Controls.Add(Me.VolumeControl)
        Me.Controls.Add(Me.LblVolume)
        Me.Controls.Add(Me.SpeedControl)
        Me.Controls.Add(Me.LblSpeed)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.Linestatus1)
        Me.Name = "Main"
        Me.Text = "Corporate Accountability Hotline V4.0 .NET"
        CType(Me.VbvFrame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VbvFrame1.ResumeLayout(False)
        CType(Me.PlaySpecial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Msurvey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OnHook1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InitGreet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Spanish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LangSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Playresponse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.openstatment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.L7000, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.L7001, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.L7002, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.L7003, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.L7004, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.L7007, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.L7008, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.confDOB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfACPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.L7005, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetCoID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.L7009, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfBest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.L7010, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Confirmation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.L7014, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfCOID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.L7013, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.L7012, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.L6006, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpeedControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Linestatus1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Myrepdata1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Myresdata1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error GoTo err1
        If Not VbvFrame1.SystemStarted() Then VbvFrame1.StartSystem(True)
        Exit Sub
err1:
        MsgBox("Start System Error: " & Err.Number & Chr(13) & Err.Description)
    End Sub

    Private Sub cmdStop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        On Error GoTo err1
        If VbvFrame1.SystemStarted() Then VbvFrame1.StopSystem(True)

        Exit Sub
err1:
        MsgBox("Stop System Error: " & Err.Number & Chr(13) & Err.Description)
    End Sub


    Private Sub Msurvey_EnterEvent(ByVal sender As System.Object, ByVal e As AxVBVoiceLib._DGetdgEvents_EnterEvent) Handles Msurvey.EnterEvent
        'First Play greeting ** Should load from Data Base as Well
        'PhraseLoader()
        'Dim Vapfile As String
        Dim i As Integer
        Dim GetResp As String = String.Empty
        Dim GRpress As String = String.Empty
        Dim VP As Integer
        Dim VP1 As Integer
        Dim Chnl As Integer
        Chnl = e.channel

        VapFile(Chnl) = "CAH" & LTrim(QID(Chnl)).Substring(0, 3) & "0.vap"
        Vapcom = "CAHcommons.vap"
        Select Case QType(Chnl) 'send to appropriate control for processing
            Case Is = "Y"  'yes /no
                e.greeting.InsertNamedPhrase(0, VapFile(Chnl), QID(Chnl))
                GRpress = "press 1 for yes or press 2 for no"
                e.greeting.InsertNamedPhrase(1, Vapcom, GRpress)

            Case Is = "MX" ' Multi choice and answer
                VP = 0
                If MDXindex(Chnl) = 0 Then
                    e.greeting.InsertNamedPhrase(VP, VapFile(Chnl), QID(Chnl))
                    MDXindex(Chnl) = 1
                    VP = VP + 1
                End If
                GetResp = QID(Chnl) + "." + LTrim(Str(MDXindex(Chnl)))
                e.greeting.InsertNamedPhrase(VP, VapFile(Chnl), GetResp)
                e.greeting.InsertNamedPhrase(VP + 1, Vapcom, "press 1 for yes or press 2 for no")

            Case Is = "M"  ' Multi choice only one answer
                e.greeting.InsertNamedPhrase(0, VapFile(Chnl), QID(Chnl))
                VP = 1
                For i = 1 To MaxD(Chnl)
                    GetResp = QID(Chnl) + "." + LTrim(Str(i))
                    GRpress = "press" + " " + LTrim(Str(i))
                    VP1 = VP + 1
                    e.greeting.InsertNamedPhrase(VP, VapFile(Chnl), GetResp)
                    e.greeting.InsertNamedPhrase(VP1, Vapcom, GRpress)
                    VP = VP1 + 1
                Next
            Case Is = "MD"   'Multi with decision branch based on answer
                e.greeting.InsertNamedPhrase(0, VapFile(Chnl), QID(Chnl))
                VP = 1
                For i = 1 To MaxD(Chnl)
                    GetResp = QID(Chnl) + "." + LTrim(Str(i))
                    GRpress = "press" + " " + LTrim(Str(i))
                    VP1 = VP + 1
                    e.greeting.InsertNamedPhrase(VP, VapFile(Chnl), GetResp)
                    e.greeting.InsertNamedPhrase(VP1, Vapcom, GRpress)
                    VP = VP1 + 1
                Next
            Case Is = "YMD"  'Yes/No with a Decision based on answer
                e.greeting.InsertNamedPhrase(0, VapFile(Chnl), QID(Chnl))
                GRpress = "press 1 for yes or press 2 for no"
                e.greeting.InsertNamedPhrase(1, Vapcom, GRpress)

            Case Is = "SP"  'Special handling
                e.greeting.InsertNamedPhrase(0, VapFile(Chnl), QID(Chnl))
                'Case Is = "Y"  'Yes/No with a Decision
            Case Is = "SPMD"  ' special handling and decision
                e.greeting.InsertNamedPhrase(0, VapFile(Chnl), QID(Chnl))
                'Case Is = "Y"  'Yes/No with a Decision


        End Select



    End Sub


    Private Sub LineGroup1_Exit(ByVal sender As Object, ByVal e As AxVBVoiceLib._DLineGroupEvents_ExitEvent) Handles LineGroup1.Exit
        'Place All House Cleaning in here clear all array for channel leaving
        Dim Chnl As Integer
        Dim Ser As String 'Temporary Serial number for linking database tables

        Chnl = e.channel
        Conf(Chnl) = ""
        Ser = Format(Now(), "ddMMyyHHmmss")
        tmpConNum(Chnl) = "NC" & LTrim(Str(Chnl)) & "-" & Ser


        'add a new row into the Reportdata table
        'Reprow(Chnl) = MyResData1.Tables("reportdata").NewRow()
        'Reprow(Chnl)("Confirmation") = tmpConNum(Chnl)
        'Reprow(Chnl)("CallDate") = Now()
        'myresdata1.Tables("ReportData").Columns.Item
        Reprow(Chnl) = Myrepdata1.Tables("ReportData").NewRow()
        recordRepData(e.channel, "CallID", tmpConNum(Chnl))
        recordRepData(e.channel, "CallDate", Now())

        'Dim i As Integer
        'Dim itmz As Integer = myresdata1.Tables("ReportData").Columns.Count - 1
        'For i = 0 To itmz   'Clears Current Channel array
        '    repdata(Chnl, 0, i) = ""
        '    repdata(Chnl, 1, i) = ""
        'Next
        'repdata(Chnl, 0, 2) = "CallDate"
        'repdata(Chnl, 1, 2) = CStr(Now())
        'repdata(Chnl, 0, 6) = "Confirmation"
        'repdata(Chnl, 1, 6) = tmpConNum(Chnl)
        ' added on 02/18/05 for bug fix on voice card and VBV 5.0 where if volume or 
        'speed is changed on first call it would hang voice card.

        If Linecalls(Chnl) > 0 Then
            LineGroup1.PlaySpeed(Chnl) = SpeedControl.Value + 1
            LineGroup1.PlayVolume(Chnl) = VolumeControl.Value
        Else
            Linecalls(Chnl) = Linecalls(Chnl) + 1
        End If
        NxtQID(Chnl) = 5003
        QProc(Chnl)

        'L7000.TakeCall(Chnl)   'For Debug jump to a control

    End Sub

    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dbconn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=CorPaccHL.mdb")
        Dim adapter As New OleDb.OleDbDataAdapter()
        Dim qmquery As String       'Use for Select String
        Dim dmquery As String

        'Set Question master DataTable
        Dim pkCol As DataColumn = qmtable.Columns.Add("QID", Type.GetType("System.String"))
        qmtable.Columns.Add("QType", Type.GetType("System.String"))
        qmtable.Columns.Add("MaxDigits", Type.GetType("System.String"))
        qmtable.Columns.Add("NextQID", Type.GetType("System.String"))
        qmtable.Columns.Add("Question", Type.GetType("System.String"))
        qmtable.PrimaryKey = New DataColumn() {pkCol}

        'Set Decision Maker DataTable
        Dim pkCol1 As DataColumn = dmtable.Columns.Add("QID", Type.GetType("System.String"))
        dmtable.Columns.Add("R1", Type.GetType("System.String"))
        dmtable.Columns.Add("R2", Type.GetType("System.String"))
        dmtable.Columns.Add("R3", Type.GetType("System.String"))
        dmtable.Columns.Add("R4", Type.GetType("System.String"))
        dmtable.Columns.Add("R5", Type.GetType("System.String"))
        dmtable.Columns.Add("R6", Type.GetType("System.String"))
        dmtable.Columns.Add("R7", Type.GetType("System.String"))
        dmtable.Columns.Add("R8", Type.GetType("System.String"))
        dmtable.Columns.Add("R9", Type.GetType("System.String"))
        dmtable.PrimaryKey = New DataColumn() {pkCol1}


        Try
            'qmaster.Open()
            ' Insert code to process data.
            'MsgBox("success")
            '   Dim i As Integer
            'For i = 0 To 4
            '    NxtQID(i) = "5003"
            'Next i
            qmquery = "Select * from QMaster"
            dmquery = "Select * from Dmaker"
            'repq = "Select * from ReportData Where 'Confirmation'=1"
            'respq = "Select * from Respdata Where 'Confirmation'=1"
            dbconn.Open()
            adapter.SelectCommand = New OleDb.OleDbCommand(qmquery, dbconn)
            adapter.Fill(qmdataset, "QMasterDT")
            adapter.SelectCommand = New OleDb.OleDbCommand(dmquery, dbconn)
            adapter.Fill(dmdataset, "DMasterDT")
            'adapter.SelectCommand = New OleDb.OleDbCommand(repq, dbconn)
            'adapter.Fill(qmdataset, "RepDataT")
            'adapter.SelectCommand = New OleDb.OleDbCommand(respq, dbconn)
            'adapter.Fill(dmdataset, "RespdataT")
            myResAdapt.Fill(Myresdata1, "Respdata")
            myrepadapt.Fill(Myrepdata1, "ReportData")

            dbconn.Close()

            'DataGrid1.SetDataBinding(qmdataset, "QMasterDT")
            'qmrow.Text = Qmdataset1.

        Catch ex As Exception
            MessageBox.Show("Main.load: " + ex.Message)
            'Finally
            '    qmaster.Close()
        End Try

    End Sub


    Private Sub QProc(ByVal channel As Integer) 'follows NextQID to load next question parameters
        Dim rowFoundRow As DataRow
        '  Dim getnext As String
        Dim Chnl As Integer
        Chnl = channel
        If NxtQID(Chnl) = "0" Then MDNextQID(Chnl) 'In the event of a decision must get new NextQID based on selection

        Try
            'getnext = NxtQID(Chnl)
            rowFoundRow = qmtable.Rows.Find(NxtQID(Chnl))
            If Not (rowFoundRow Is Nothing) Then
                QID(Chnl) = rowFoundRow(0)
                MaxD(Chnl) = rowFoundRow(2)
                QType(Chnl) = rowFoundRow(1)
                NxtQID(Chnl) = rowFoundRow(3)

                'MessageBox.Show(CType(rowFoundRow(4), String))
            Else
                'MessageBox.Show("A row with the primary key of " & _
                'getnext & " could not be found")
            End If
        Catch ex As Exception
            MessageBox.Show("Question Loop: " + ex.Message)
            'Finally
            '    qmaster.Close()
        Finally
            'qmrow.Text = NxtQID(Chnl)

        End Try
    End Sub



    Private Sub MDNextQID(ByVal chnl As Integer)
        Dim dmkr As DataRow

        'Load up the dmaker array
        dmkr = dmtable.Rows.Find(QID(chnl))
        If Not (dmkr Is Nothing) Then
            NxtQID(chnl) = dmkr(Dindex(chnl))
        Else
            'MessageBox.Show("WTFH " getnext & " could not be found")
        End If

    End Sub




    Private Overloads Sub Playresponse_EnterEvent(ByVal sender As System.Object, ByVal e As AxVBVoiceLib._DGetdgEvents_EnterEvent) Handles Playresponse.EnterEvent
        'Dim Vapfile As String
        ' Dim i As Integer
        Dim Rvap As String
        '   Dim DigitEntered As Integer
        Dim Chnl As Integer
        Chnl = e.channel
        Dindex(Chnl) = Msurvey.Digits(Chnl)

        'Vapfile = "HH5000.vap"  'To Do Case this when long Vaps by phrase segments or database it
        Rvap = "CAHcommons.vap"   ' Need different lead in on response based on type of question 
        Select Case QType(Chnl)
            Case Is = "Y"
                User1.TakeCall(Chnl)
            Case Is = "YMD"
                User1.TakeCall(Chnl)
            Case Is = "SP"
                User1.TakeCall(Chnl)
            Case Is = "SPMD"
                User1.TakeCall(Chnl)
            Case Is = "MX"

                MDXindex(Chnl) = MDXindex(Chnl) + 1
                If MDXindex(Chnl) = MaxD(Chnl) Then
                    User1.TakeCall(Chnl)
                Else
                    Msurvey.TakeCall(Chnl)
                End If

            Case Else
                e.greeting.InsertNamedPhrase(0, Rvap, "you have selected") 'Youv'e Selected
                e.greeting.InsertNamedPhrase(1, VapFile(Chnl), QID(Chnl) + "." + LTrim(Str(Dindex(Chnl))))
                e.greeting.InsertNamedPhrase(2, Rvap, "if this statment is correct press 1 if this stament is not correct press 2") 'If this is correct 1 not 2

        End Select



    End Sub
    Sub recordRepData(ByVal Chnl As Integer, ByVal field As String, ByVal repd As Object)
        Reprow(Chnl)(field) = repd

    End Sub

    Sub RecordData(ByVal Chnl As Integer)
        'Dim RDrow As DataRow
        ' record the response to temp table based on channel name
        'Dim RDtable As New myresdata.RespdataDataTable()
        RDrow(Chnl) = Myresdata1.Tables("respdata").NewRow()
        RDrow(Chnl)("CallID") = tmpConNum(Chnl)
        RDrow(Chnl)("QID") = QID(Chnl)
        RDrow(Chnl)("Dcollect") = QID(Chnl) + "." + LTrim(Str(Dindex(Chnl)))
        Myresdata1.Tables("Respdata").Rows.Add(RDrow(Chnl))


        'myRepAdapt.Update(myresdata1, "Respdata")

    End Sub
    Private Sub User1_EnterEvent(ByVal sender As System.Object, ByVal e As AxVBVoiceLib._DUserEvents_EnterEvent) Handles User1.EnterEvent

        Dim Chnl As Integer
        Chnl = e.channel
        MDXindex(Chnl) = 0   'For all MX type Q reset the indexr

        If NxtQID(Chnl) = 0 Then MDNextQID(Chnl)
        'This Occurs on some questions where the next Question 
        'is unknown until the user presses a digit

        QProc(Chnl)  'loads next question parameters
        Select Case QType(Chnl) 'send to appropriate control for processing
            Case Is = "Y"  'yes /no
                Msurvey.TakeCall(Chnl)
            Case Is = "MX"
                Msurvey.TakeCall(Chnl)
            Case Is = "M"
                Msurvey.TakeCall(Chnl)
            Case Is = "MD"
                Msurvey.TakeCall(Chnl)
            Case Is = "YMD"
                Msurvey.TakeCall(Chnl)
            Case Is = "SP"
                Msurvey.TakeCall(Chnl)
            Case Is = "SP*"
                PlaySpecial.TakeCall(Chnl)
            Case Is = "SPMD"
                Msurvey.TakeCall(Chnl)
            Case Else
                Select Case QID(Chnl)
                    Case Is = "7000"
                        L7000.TakeCall(Chnl)
                    Case Is = "6006"
                        L6006.TakeCall(Chnl)
                    Case Is = "7005"
                        L7005.TakeCall(Chnl)
                    Case Else
                End Select


        End Select

    End Sub



    Private Sub Playresponse_Exit(ByVal sender As Object, ByVal e As AxVBVoiceLib._DGetdgEvents_ExitEvent) Handles Playresponse.Exit
        'on exit if mx you must loop until they press 1 that 
        'they have finished answers to this mx
        If QType(e.channel) = "MX" Then
            If Dindex(e.channel) = 1 Then   'Only record MX yes Response
                Dindex(e.channel) = MDXindex(e.channel) - 1
                RecordData(e.channel)
            End If

        Else
            Dim check As Integer
            check = Playresponse.Digits(e.channel)
            If check = 1 Then
                If QID(e.channel) = "6004" Then
                    Dim Anon As String = String.Empty
                    Select Case Msurvey.Digits(e.channel)
                        Case Is = 1
                            Anon = "Anon"
                        Case Is = 2
                            Anon = "Not"
                        Case Is = 3
                            Anon = "Confidential"
                    End Select
                    recordRepData(e.channel, "AnonReq", Anon)
                End If
                RecordData(e.channel)
            End If
        End If
    End Sub



    Private Sub confDOB_EnterEvent(ByVal sender As Object, ByVal e As AxVBVoiceLib._DGetdgEvents_EnterEvent) Handles confDOB.EnterEvent
        Dim NewPhrase As Object
        Dim DOB As String
        Dim Chnl As Integer
        Dim Rvap As String
        Chnl = e.channel
        Rvap = "CAHcommons.vap"   ' Need different lead in on response based on type of question 
        DOB = L7001.Digits(Chnl) & "/" & L7002.Digits(Chnl) & "/19" & L7003.Digits(Chnl)
        NewPhrase = New VBVoiceLib.Phrase()   'CreateObject("vbv.phrase")
        NewPhrase.PhrsType = VBVoiceLib.vbvPhraseTypeConstants.vbvSYSPHRASE
        NewPhrase.Type = VBVoiceLib.vbvSysPhraseConstants.vbvSayDate

        NewPhrase.PhraseData1 = DOB
        NewPhrase.PhraseData2 = "Day,MonthName,Year"
        e.greeting.InsertNamedPhrase(0, Rvap, "you have entered")
        e.greeting.InsertPhrase(1, NewPhrase)
        e.greeting.InsertNamedPhrase(2, Rvap, "If this is Correct Press 1 If this is Not")

    End Sub

    Private Sub ConfACPhone_EnterEvent(ByVal sender As System.Object, ByVal e As AxVBVoiceLib._DGetdgEvents_EnterEvent) Handles ConfACPhone.EnterEvent
        Dim NewPhrase As Object
        Dim phone As String
        Dim Chnl As Integer
        Dim Rvap As String
        Chnl = e.channel
        Rvap = "CAHcommons.vap"   ' Need different lead in on response based on type of question 
        phone = L7007.Digits(Chnl) & L7008.Digits(Chnl)

        NewPhrase = New VBVoiceLib.Phrase()   'CreateObject("vbv.phrase")
        NewPhrase.PhrsType = VBVoiceLib.vbvPhraseTypeConstants.vbvSYSPHRASE
        NewPhrase.Type = VBVoiceLib.vbvSysPhraseConstants.vbvDigits

        NewPhrase.PhraseData1 = phone
        e.greeting.InsertNamedPhrase(0, Rvap, "you have entered")
        e.greeting.InsertPhrase(1, NewPhrase)
        e.greeting.InsertNamedPhrase(2, Rvap, "If this is Correct Press 1 If this is Not")

    End Sub

    Private Sub ConfBest_EnterEvent(ByVal sender As System.Object, ByVal e As AxVBVoiceLib._DGetdgEvents_EnterEvent) Handles ConfBest.EnterEvent
        Dim Vap(5) As String
        '  Dim i As Integer
        Dim Rvap As String
        Dim DigitEntered As Integer
        Dim Chnl As Integer
        Chnl = e.channel

        Vap(Chnl) = "CAH7000.vap"  'To Do Case this when long Vaps by phrase segments or database it
        Rvap = "CAHcommons.vap"   ' Need different lead in on response based on type of question 

        DigitEntered = L7009.Digits(Chnl)
        e.greeting.InsertNamedPhrase(0, Rvap, "you have entered")
        e.greeting.InsertNamedPhrase(1, Vap(Chnl), "7009." + LTrim(Str(DigitEntered)))
        e.greeting.InsertNamedPhrase(2, Rvap, "If this is Correct Press 1 If this is Not")

    End Sub


    Private Sub ConfCOID_EnterEvent(ByVal sender As System.Object, ByVal e As AxVBVoiceLib._DGetdgEvents_EnterEvent) Handles ConfCOID.EnterEvent
        Dim NewPhrase As Object
        Dim COID As String
        Dim Chnl As Integer
        Dim Rvap As String
        Chnl = e.channel
        Rvap = "CAHcommons.vap"   ' Need different lead in on response based on type of question 
        COID = GetCoID.Digits(Chnl)

        NewPhrase = New VBVoiceLib.Phrase()   'CreateObject("vbv.phrase")
        NewPhrase.PhrsType = VBVoiceLib.vbvPhraseTypeConstants.vbvSYSPHRASE
        NewPhrase.Type = VBVoiceLib.vbvSysPhraseConstants.vbvDigits

        NewPhrase.PhraseData1 = COID
        e.greeting.InsertNamedPhrase(0, Rvap, "you have entered")
        e.greeting.InsertPhrase(1, NewPhrase)
        e.greeting.InsertNamedPhrase(2, Rvap, "If this is Correct Press 1 If this is Not")

    End Sub

    Private Sub Confirmation_EnterEvent(ByVal sender As System.Object, ByVal e As AxVBVoiceLib._DPlayGreetingEvents_EnterEvent) Handles Confirmation.EnterEvent
        Dim NewPhrase As Object
        'Dim Conf As String
        Dim Chnl As Integer
        Dim Rvap As String
        Dim RC(5) As String
        Chnl = e.channel
        RC(Chnl) = Microsoft.VisualBasic.Right(Str(Myrepdata1.Tables("Reportdata").Rows.Count + 1000), 3)
        Rvap = "CAHcommons.vap"   ' Need different lead in on response based on type of question 
        Conf(Chnl) = Format(Now(), "ddMM") & Chnl & RC(Chnl)
        NewPhrase = New VBVoiceLib.Phrase()   'CreateObject("vbv.phrase")
        NewPhrase.PhrsType = VBVoiceLib.vbvPhraseTypeConstants.vbvSYSPHRASE
        NewPhrase.Type = VBVoiceLib.vbvSysPhraseConstants.vbvDigits

        NewPhrase.PhraseData1 = Conf(Chnl)
        e.greeting.InsertNamedPhrase(0, Rvap, "Your Confirmation Number is")
        e.greeting.InsertPhrase(1, NewPhrase)
        e.greeting.InsertNamedPhrase(2, Rvap, "Write it Down")
    End Sub


    Private Sub checkdata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkdata.Click
        Dim Report1 As New report()
        Report1.Visible = True

    End Sub

    Private Sub LineGroup1_Disconnect(ByVal sender As Object, ByVal e As AxVBVoiceLib._DLineGroupEvents_DisconnectEvent) Handles LineGroup1.Disconnect
        Dim Chnl As Integer = e.channel
        Dim Linestat(5) As String
        'Determin reason or disconnect
        Select Case e.reason
            Case Is = 0
                Linestat(Chnl) = "Completed Normal"
            Case Is = 1
                Linestat(Chnl) = "Terminated on a system error"
            Case Is = 2
                Linestat(Chnl) = "Hung-up prematurely"
            Case Is = 3
                Linestat(Chnl) = "Terminated on invalid or no digits"
            Case Is = 4
                Linestat(Chnl) = "System stops because of  the StopSys­tem"
            Case Else
                Linestat(Chnl) = "Termination Undetermined"
        End Select
        recordRepData(e.channel, "CallStatus", Linestat(Chnl))
        If Conf(Chnl) <> "" Then
            'If Confirmation number was generated need to Update Confirmation Number to report
            Reprow(Chnl)("Confirmation") = Conf(Chnl)
        Else 'Assigns Temp Confirmation Number to Record

            Reprow(Chnl)("Confirmation") = tmpConNum(Chnl)
            'Also copies it to Tconfirmation which is needed to relationship with RespData
            Reprow(Chnl)("CallID") = tmpConNum(Chnl)
        End If
        'copies The Temp Conf # to Tconfirmation which is needed to relationship with RespData
        Reprow(Chnl)("CallID") = tmpConNum(Chnl)
        '
        Myrepdata1.Tables("Reportdata").Rows.Add(Reprow(Chnl))
        myResAdapt.Update(Myresdata1, "Respdata")      'Write Data from DataSet to db
        myrepadapt.Update(Myrepdata1, "Reportdata")




    End Sub


    Private Sub LangSelect_Exit(ByVal sender As Object, ByVal e As AxVBVoiceLib._DGetdgEvents_ExitEvent) Handles LangSelect.Exit
        Dim lang As String

        If LangSelect.Digits(e.channel) = 1 Then
            lang = "English"
        Else
            lang = "Spanish"
        End If
        recordRepData(e.channel, "Lang", lang)


    End Sub

    Private Sub confDOB_Exit(ByVal sender As Object, ByVal e As AxVBVoiceLib._DGetdgEvents_ExitEvent) Handles confDOB.Exit
        Dim DOB As String = String.Empty
        Dim Chnl As Integer = e.channel
        If confDOB.Digits(e.channel) = 1 Then
            DOB = L7001.Digits(Chnl) & "/" & L7002.Digits(Chnl) & "/19" & L7003.Digits(Chnl)
        End If
        'Reprow(e.channel)("DOB") = DOB
        recordRepData(e.channel, "DOB", DOB)
        'repdata(Chnl, 7) = DOB
    End Sub

    Private Sub ConfACPhone_Exit(ByVal sender As Object, ByVal e As AxVBVoiceLib._DGetdgEvents_ExitEvent) Handles ConfACPhone.Exit
        Dim ACPhone As String
        ACPhone = CStr(L7007.Digits(e.channel)) & CStr(L7008.Digits(e.channel))
        If ConfACPhone.Digits(e.channel) = 1 Then
            'Reprow(e.channel)("Phone") = ACPhone
            recordRepData(e.channel, "Phone", ACPhone)
        End If
    End Sub

    Private Sub ConfCOID_Exit(ByVal sender As Object, ByVal e As AxVBVoiceLib._DGetdgEvents_ExitEvent) Handles ConfCOID.Exit
        Dim ConID As String
        If ConfCOID.Digits(e.channel) = 1 Then
            ConID = GetCoID.Digits(e.channel)
            'Reprow(e.channel)("SID") = ConID
            recordRepData(e.channel, "SID", ConID)
        End If

    End Sub

    Private Sub ConfBest_Exit(ByVal sender As Object, ByVal e As AxVBVoiceLib._DGetdgEvents_ExitEvent) Handles ConfBest.Exit
        Dim ConBest As String = String.Empty
        If ConfBest.Digits(e.channel) = 1 Then
            Select Case L7009.Digits(e.channel)
                Case Is = 1
                    ConBest = "9:00am to 12:00pm"
                Case Is = 2
                    ConBest = "12:00pm to 5:00 Pm"
                Case Is = 3
                    ConBest = "5:00pm to 9:00 Pm"
            End Select
            recordRepData(e.channel, "CBTime", ConBest)
        End If
    End Sub

    Private Sub VbvFrame1_ShutDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VbvFrame1.ShutDown

    End Sub

    Private Sub L7013a_EnterEvent(ByVal sender As System.Object, ByVal e As AxVBVoiceLib._DGetdgEvents_EnterEvent) Handles L7013.EnterEvent

    End Sub

    Private Sub PlaySpecial_EnterEvent(ByVal sender As Object, ByVal e As AxVBVoiceLib._DPlayGreetingEvents_EnterEvent) Handles PlaySpecial.EnterEvent
        Dim Chnl As Integer
        Chnl = e.channel
        VapFile(Chnl) = "CAH" & LTrim(QID(Chnl)).Substring(0, 3) & "0.vap"
        e.greeting.InsertNamedPhrase(0, VapFile(Chnl), QID(Chnl))

    End Sub

    Private Sub Msurvey_Exit(ByVal sender As Object, ByVal e As AxVBVoiceLib._DGetdgEvents_ExitEvent) Handles Msurvey.Exit
        Dim Chnl As Integer = e.channel
        Dindex(Chnl) = Msurvey.Digits(Chnl)

        Select Case QType(Chnl)
            Case Is = "Y"
                RecordData(e.channel)
                User1.TakeCall(Chnl)
            Case Is = "YMD"
                RecordData(e.channel)
                User1.TakeCall(Chnl)
            Case Is = "SP"
                RecordData(e.channel)
                User1.TakeCall(Chnl)
            Case Is = "SPMD"
                RecordData(e.channel)
                User1.TakeCall(Chnl)
            Case Is = "MX"

                MDXindex(Chnl) = MDXindex(Chnl) + 1
                If MDXindex(Chnl) = MaxD(Chnl) Then
                    If Dindex(e.channel) = 1 Then   'Only record MX yes Response
                        Dindex(e.channel) = MDXindex(e.channel) - 1
                        RecordData(e.channel)
                    End If
                    User1.TakeCall(Chnl)
                Else
                    If Dindex(e.channel) = 1 Then   'Only record MX yes Response
                        Dindex(e.channel) = MDXindex(e.channel) - 1
                        RecordData(e.channel)
                    End If
                    Msurvey.TakeCall(Chnl)
                End If
        End Select
    End Sub

    Private Sub L7004_EnterEvent(ByVal sender As System.Object, ByVal e As AxVBVoiceLib._DRecordEvents_EnterEvent) Handles L7004.EnterEvent
        Dim Chnl As Integer = e.channel
        L7004.FileName(Chnl) = tmpConNum(Chnl) + ".wav" 'renames msg file as Call Id
    End Sub

    Private Sub L6006_EnterEvent(ByVal sender As System.Object, ByVal e As AxVBVoiceLib._DRecordEvents_EnterEvent) Handles L6006.EnterEvent
        Dim Chnl As Integer = e.channel
        L6006.FileName(Chnl) = tmpConNum(Chnl) + ".wav" 'renames Anon Call as Call ID
    End Sub


    Private Sub Spanish_Exit(ByVal sender As Object, ByVal e As AxVBVoiceLib._DLangEvents_ExitEvent) Handles Spanish.Exit
        Dim Chnl As Integer
        Chnl = e.channel
        LineGroup1.PlaySpeed(Chnl) = SpeedControl.Value
        LineGroup1.PlayVolume(Chnl) = VolumeControl.Value
    End Sub

    Private Sub InitGreet_EnterEvent(ByVal sender As System.Object, ByVal e As AxVBVoiceLib._DPlayGreetingEvents_EnterEvent) Handles InitGreet.EnterEvent
        '  Dim NewPhrase As Object
        Dim Chnl As Integer
        Dim Rvap As String
        Chnl = e.channel
        Rvap = "CAH5000.vap"   ' 
        e.greeting.InsertNamedPhrase(0, Rvap, "5000-" + CStr(Chnl))
    End Sub

    '    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
    '        On Error GoTo err1
    '        If Not VbvFrame1.SystemStarted() Then VbvFrame1.StartSystem(True)
    '        Exit Sub
    'err1:
    '        MsgBox("Start System Error: " & Err.Number & Chr(13) & Err.Description)
    '    End Sub
End Class
