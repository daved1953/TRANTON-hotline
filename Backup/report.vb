Public Class report
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
    Friend WithEvents CallReport As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents CallReport1 As CustPhrs.CallReport
    Friend WithEvents CallreportConn As System.Data.OleDb.OleDbConnection
    Friend WithEvents CallVerified As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents btnAllData As System.Windows.Forms.Button
    Friend WithEvents btnUnverified As System.Windows.Forms.Button
    Friend WithEvents btnVerified As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents callUnverified As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Callverified1 As CustPhrs.Callverified
    Friend WithEvents CallUnverified1 As CustPhrs.CallUnverified
    Friend WithEvents Verified As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CallReport1 = New CustPhrs.CallReport()
        Me.CallReport = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.CallreportConn = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.CallVerified = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.btnAllData = New System.Windows.Forms.Button()
        Me.btnUnverified = New System.Windows.Forms.Button()
        Me.btnVerified = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.callUnverified = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.Callverified1 = New CustPhrs.Callverified()
        Me.CallUnverified1 = New CustPhrs.CallUnverified()
        Me.Verified = New System.Windows.Forms.DataGrid()
        CType(Me.CallReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Callverified1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CallUnverified1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Verified, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CallReport1
        '
        Me.CallReport1.DataSetName = "CallReport"
        Me.CallReport1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CallReport1.Namespace = "http://www.tempuri.org/CallReport.xsd"
        '
        'CallReport
        '
        Me.CallReport.DeleteCommand = Me.OleDbDeleteCommand1
        Me.CallReport.InsertCommand = Me.OleDbInsertCommand1
        Me.CallReport.SelectCommand = Me.OleDbSelectCommand1
        Me.CallReport.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ReportData", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AnonReq", "AnonReq"), New System.Data.Common.DataColumnMapping("CallDate", "CallDate"), New System.Data.Common.DataColumnMapping("CallStatus", "CallStatus"), New System.Data.Common.DataColumnMapping("CBtime", "CBtime"), New System.Data.Common.DataColumnMapping("Comments", "Comments"), New System.Data.Common.DataColumnMapping("Confirmation", "Confirmation"), New System.Data.Common.DataColumnMapping("DOB", "DOB"), New System.Data.Common.DataColumnMapping("Fname", "Fname"), New System.Data.Common.DataColumnMapping("Lang", "Lang"), New System.Data.Common.DataColumnMapping("Lname", "Lname"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("SID", "SID"), New System.Data.Common.DataColumnMapping("Subscriber", "Subscriber"), New System.Data.Common.DataColumnMapping("verified", "verified"), New System.Data.Common.DataColumnMapping("Verifiedby", "Verifiedby"), New System.Data.Common.DataColumnMapping("VerifiedDate", "VerifiedDate"), New System.Data.Common.DataColumnMapping("AutoID", "AutoID")})})
        Me.CallReport.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM ReportData WHERE (AutoID = ?) AND (AnonReq = ? OR ? IS NULL AND AnonR" & _
        "eq IS NULL) AND (CBtime = ? OR ? IS NULL AND CBtime IS NULL) AND (CallDate = ? O" & _
        "R ? IS NULL AND CallDate IS NULL) AND (CallStatus = ? OR ? IS NULL AND CallStatu" & _
        "s IS NULL) AND (Comments = ? OR ? IS NULL AND Comments IS NULL) AND (Confirmatio" & _
        "n = ? OR ? IS NULL AND Confirmation IS NULL) AND (DOB = ? OR ? IS NULL AND DOB I" & _
        "S NULL) AND (Fname = ? OR ? IS NULL AND Fname IS NULL) AND (Lang = ? OR ? IS NUL" & _
        "L AND Lang IS NULL) AND (Lname = ? OR ? IS NULL AND Lname IS NULL) AND (Phone = " & _
        "? OR ? IS NULL AND Phone IS NULL) AND (SID = ? OR ? IS NULL AND SID IS NULL) AND" & _
        " (Subscriber = ? OR ? IS NULL AND Subscriber IS NULL) AND (VerifiedDate = ? OR ?" & _
        " IS NULL AND VerifiedDate IS NULL) AND (Verifiedby = ? OR ? IS NULL AND Verified" & _
        "by IS NULL) AND (verified = ?)"
        Me.OleDbDeleteCommand1.Connection = Me.CallreportConn
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AutoID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "AutoID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnonReq", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnonReq", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnonReq1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnonReq", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBtime", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBtime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBtime1", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBtime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
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
        'CallreportConn
        '
        Me.CallreportConn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=CorPaccHL." & _
        "mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet" & _
        " OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;J" & _
        "et OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:G" & _
        "lobal Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create Sy" & _
        "stem Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale" & _
        " on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=F" & _
        "alse"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO ReportData(AnonReq, CallDate, CallStatus, CBtime, Comments, Confirmat" & _
        "ion, DOB, Fname, Lang, Lname, Phone, SID, Subscriber, verified, Verifiedby, Veri" & _
        "fiedDate) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.CallreportConn
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnonReq", System.Data.OleDb.OleDbType.VarWChar, 15, "AnonReq"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallDate", System.Data.OleDb.OleDbType.DBDate, 0, "CallDate"))
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
        Me.OleDbSelectCommand1.CommandText = "SELECT AnonReq, CallDate, CallStatus, CBtime, Comments, Confirmation, DOB, Fname," & _
        " Lang, Lname, Phone, SID, Subscriber, verified, Verifiedby, VerifiedDate, AutoID" & _
        " FROM ReportData"
        Me.OleDbSelectCommand1.Connection = Me.CallreportConn
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE ReportData SET AnonReq = ?, CallDate = ?, CallStatus = ?, CBtime = ?, Comm" & _
        "ents = ?, Confirmation = ?, DOB = ?, Fname = ?, Lang = ?, Lname = ?, Phone = ?, " & _
        "SID = ?, Subscriber = ?, verified = ?, Verifiedby = ?, VerifiedDate = ? WHERE (A" & _
        "utoID = ?) AND (AnonReq = ? OR ? IS NULL AND AnonReq IS NULL) AND (CBtime = ? OR" & _
        " ? IS NULL AND CBtime IS NULL) AND (CallDate = ? OR ? IS NULL AND CallDate IS NU" & _
        "LL) AND (CallStatus = ? OR ? IS NULL AND CallStatus IS NULL) AND (Comments = ? O" & _
        "R ? IS NULL AND Comments IS NULL) AND (Confirmation = ? OR ? IS NULL AND Confirm" & _
        "ation IS NULL) AND (DOB = ? OR ? IS NULL AND DOB IS NULL) AND (Fname = ? OR ? IS" & _
        " NULL AND Fname IS NULL) AND (Lang = ? OR ? IS NULL AND Lang IS NULL) AND (Lname" & _
        " = ? OR ? IS NULL AND Lname IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NU" & _
        "LL) AND (SID = ? OR ? IS NULL AND SID IS NULL) AND (Subscriber = ? OR ? IS NULL " & _
        "AND Subscriber IS NULL) AND (VerifiedDate = ? OR ? IS NULL AND VerifiedDate IS N" & _
        "ULL) AND (Verifiedby = ? OR ? IS NULL AND Verifiedby IS NULL) AND (verified = ?)" & _
        ""
        Me.OleDbUpdateCommand1.Connection = Me.CallreportConn
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnonReq", System.Data.OleDb.OleDbType.VarWChar, 15, "AnonReq"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallDate", System.Data.OleDb.OleDbType.DBDate, 0, "CallDate"))
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
        'CallVerified
        '
        Me.CallVerified.DeleteCommand = Me.OleDbDeleteCommand2
        Me.CallVerified.InsertCommand = Me.OleDbInsertCommand2
        Me.CallVerified.SelectCommand = Me.OleDbSelectCommand2
        Me.CallVerified.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ReportData", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AutoID", "AutoID"), New System.Data.Common.DataColumnMapping("CallID", "CallID"), New System.Data.Common.DataColumnMapping("Confirmation", "Confirmation"), New System.Data.Common.DataColumnMapping("SID", "SID"), New System.Data.Common.DataColumnMapping("Subscriber", "Subscriber"), New System.Data.Common.DataColumnMapping("Fname", "Fname"), New System.Data.Common.DataColumnMapping("Lname", "Lname"), New System.Data.Common.DataColumnMapping("DOB", "DOB"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("CBtime", "CBtime"), New System.Data.Common.DataColumnMapping("AnonReq", "AnonReq"), New System.Data.Common.DataColumnMapping("Lang", "Lang"), New System.Data.Common.DataColumnMapping("Comments", "Comments"), New System.Data.Common.DataColumnMapping("verified", "verified"), New System.Data.Common.DataColumnMapping("Verifiedby", "Verifiedby"), New System.Data.Common.DataColumnMapping("VerifiedDate", "VerifiedDate"), New System.Data.Common.DataColumnMapping("CallDate", "CallDate"), New System.Data.Common.DataColumnMapping("CallStatus", "CallStatus"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1")})})
        Me.CallVerified.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM ReportData WHERE (AutoID = ?) AND (CallDate = ? OR ? IS NULL AND Call" & _
        "Date IS NULL) AND (AnonReq = ? OR ? IS NULL AND AnonReq IS NULL) AND (CBtime = ?" & _
        " OR ? IS NULL AND CBtime IS NULL) AND (CallDate = ? OR ? IS NULL AND CallDate IS" & _
        " NULL) AND (CallID = ? OR ? IS NULL AND CallID IS NULL) AND (CallStatus = ? OR ?" & _
        " IS NULL AND CallStatus IS NULL) AND (Comments = ? OR ? IS NULL AND Comments IS " & _
        "NULL) AND (Confirmation = ? OR ? IS NULL AND Confirmation IS NULL) AND (DOB = ? " & _
        "OR ? IS NULL AND DOB IS NULL) AND (Fname = ? OR ? IS NULL AND Fname IS NULL) AND" & _
        " (Lang = ? OR ? IS NULL AND Lang IS NULL) AND (Lname = ? OR ? IS NULL AND Lname " & _
        "IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL) AND (SID = ? OR ? IS NUL" & _
        "L AND SID IS NULL) AND (Subscriber = ? OR ? IS NULL AND Subscriber IS NULL) AND " & _
        "(VerifiedDate = ? OR ? IS NULL AND VerifiedDate IS NULL) AND (Verifiedby = ? OR " & _
        "? IS NULL AND Verifiedby IS NULL) AND (verified = ?)"
        Me.OleDbDeleteCommand2.Connection = Me.CallreportConn
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AutoID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "AutoID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnonReq", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnonReq", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnonReq1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnonReq", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBtime", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBtime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBtime1", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBtime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate2", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate3", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallStatus", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallStatus", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallStatus1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallStatus", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Confirmation", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Confirmation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Confirmation1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Confirmation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DOB", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DOB1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fname1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lang", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lang", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lang1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lang", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lname1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SID", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SID1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Subscriber", System.Data.OleDb.OleDbType.VarWChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subscriber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Subscriber1", System.Data.OleDb.OleDbType.VarWChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subscriber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VerifiedDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VerifiedDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VerifiedDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VerifiedDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Verifiedby", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Verifiedby", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Verifiedby1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Verifiedby", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_verified", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "verified", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO ReportData(CallDate, AnonReq, CallID, CallStatus, CBtime, Comments, C" & _
        "onfirmation, DOB, Fname, Lang, Lname, Phone, SID, Subscriber, verified, Verified" & _
        "by, VerifiedDate) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.CallreportConn
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallDate", System.Data.OleDb.OleDbType.DBDate, 0, "CallDate"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnonReq", System.Data.OleDb.OleDbType.VarWChar, 15, "AnonReq"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallID", System.Data.OleDb.OleDbType.VarWChar, 20, "CallID"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallStatus", System.Data.OleDb.OleDbType.VarWChar, 50, "CallStatus"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CBtime", System.Data.OleDb.OleDbType.VarWChar, 25, "CBtime"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Comments", System.Data.OleDb.OleDbType.VarWChar, 255, "Comments"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Confirmation", System.Data.OleDb.OleDbType.VarWChar, 20, "Confirmation"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DOB", System.Data.OleDb.OleDbType.VarWChar, 50, "DOB"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Fname", System.Data.OleDb.OleDbType.VarWChar, 20, "Fname"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Lang", System.Data.OleDb.OleDbType.VarWChar, 10, "Lang"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Lname", System.Data.OleDb.OleDbType.VarWChar, 20, "Lname"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 50, "Phone"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("SID", System.Data.OleDb.OleDbType.VarWChar, 10, "SID"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Subscriber", System.Data.OleDb.OleDbType.VarWChar, 35, "Subscriber"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("verified", System.Data.OleDb.OleDbType.Boolean, 2, "verified"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Verifiedby", System.Data.OleDb.OleDbType.VarWChar, 20, "Verifiedby"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("VerifiedDate", System.Data.OleDb.OleDbType.DBDate, 0, "VerifiedDate"))
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT CallDate AS Expr1, AnonReq, AutoID, CallDate, CallID, CallStatus, CBtime, " & _
        "Comments, Confirmation, DOB, Fname, Lang, Lname, Phone, SID, Subscriber, verifie" & _
        "d, Verifiedby, VerifiedDate FROM ReportData WHERE (verified = - 1) ORDER BY Call" & _
        "Date"
        Me.OleDbSelectCommand2.Connection = Me.CallreportConn
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE ReportData SET CallDate = ?, AnonReq = ?, CallID = ?, CallStatus = ?, CBti" & _
        "me = ?, Comments = ?, Confirmation = ?, DOB = ?, Fname = ?, Lang = ?, Lname = ?," & _
        " Phone = ?, SID = ?, Subscriber = ?, verified = ?, Verifiedby = ?, VerifiedDate " & _
        "= ? WHERE (AutoID = ?) AND (CallDate = ? OR ? IS NULL AND CallDate IS NULL) AND " & _
        "(AnonReq = ? OR ? IS NULL AND AnonReq IS NULL) AND (CBtime = ? OR ? IS NULL AND " & _
        "CBtime IS NULL) AND (CallDate = ? OR ? IS NULL AND CallDate IS NULL) AND (CallID" & _
        " = ? OR ? IS NULL AND CallID IS NULL) AND (CallStatus = ? OR ? IS NULL AND CallS" & _
        "tatus IS NULL) AND (Comments = ? OR ? IS NULL AND Comments IS NULL) AND (Confirm" & _
        "ation = ? OR ? IS NULL AND Confirmation IS NULL) AND (DOB = ? OR ? IS NULL AND D" & _
        "OB IS NULL) AND (Fname = ? OR ? IS NULL AND Fname IS NULL) AND (Lang = ? OR ? IS" & _
        " NULL AND Lang IS NULL) AND (Lname = ? OR ? IS NULL AND Lname IS NULL) AND (Phon" & _
        "e = ? OR ? IS NULL AND Phone IS NULL) AND (SID = ? OR ? IS NULL AND SID IS NULL)" & _
        " AND (Subscriber = ? OR ? IS NULL AND Subscriber IS NULL) AND (VerifiedDate = ? " & _
        "OR ? IS NULL AND VerifiedDate IS NULL) AND (Verifiedby = ? OR ? IS NULL AND Veri" & _
        "fiedby IS NULL) AND (verified = ?)"
        Me.OleDbUpdateCommand2.Connection = Me.CallreportConn
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallDate", System.Data.OleDb.OleDbType.DBDate, 0, "CallDate"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnonReq", System.Data.OleDb.OleDbType.VarWChar, 15, "AnonReq"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallID", System.Data.OleDb.OleDbType.VarWChar, 20, "CallID"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallStatus", System.Data.OleDb.OleDbType.VarWChar, 50, "CallStatus"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CBtime", System.Data.OleDb.OleDbType.VarWChar, 25, "CBtime"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Comments", System.Data.OleDb.OleDbType.VarWChar, 255, "Comments"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Confirmation", System.Data.OleDb.OleDbType.VarWChar, 20, "Confirmation"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DOB", System.Data.OleDb.OleDbType.VarWChar, 50, "DOB"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Fname", System.Data.OleDb.OleDbType.VarWChar, 20, "Fname"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Lang", System.Data.OleDb.OleDbType.VarWChar, 10, "Lang"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Lname", System.Data.OleDb.OleDbType.VarWChar, 20, "Lname"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 50, "Phone"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("SID", System.Data.OleDb.OleDbType.VarWChar, 10, "SID"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Subscriber", System.Data.OleDb.OleDbType.VarWChar, 35, "Subscriber"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("verified", System.Data.OleDb.OleDbType.Boolean, 2, "verified"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Verifiedby", System.Data.OleDb.OleDbType.VarWChar, 20, "Verifiedby"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("VerifiedDate", System.Data.OleDb.OleDbType.DBDate, 0, "VerifiedDate"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AutoID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "AutoID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnonReq", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnonReq", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnonReq1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnonReq", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBtime", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBtime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBtime1", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBtime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate2", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate3", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallStatus", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallStatus", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallStatus1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallStatus", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Confirmation", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Confirmation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Confirmation1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Confirmation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DOB", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DOB1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fname1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lang", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lang", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lang1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lang", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lname1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SID", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SID1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Subscriber", System.Data.OleDb.OleDbType.VarWChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subscriber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Subscriber1", System.Data.OleDb.OleDbType.VarWChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subscriber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VerifiedDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VerifiedDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VerifiedDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VerifiedDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Verifiedby", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Verifiedby", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Verifiedby1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Verifiedby", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_verified", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "verified", System.Data.DataRowVersion.Original, Nothing))
        '
        'btnAllData
        '
        Me.btnAllData.Location = New System.Drawing.Point(72, 336)
        Me.btnAllData.Name = "btnAllData"
        Me.btnAllData.Size = New System.Drawing.Size(72, 32)
        Me.btnAllData.TabIndex = 1
        Me.btnAllData.Text = "Show All Records"
        '
        'btnUnverified
        '
        Me.btnUnverified.Location = New System.Drawing.Point(168, 336)
        Me.btnUnverified.Name = "btnUnverified"
        Me.btnUnverified.Size = New System.Drawing.Size(80, 32)
        Me.btnUnverified.TabIndex = 2
        Me.btnUnverified.Text = "Show Unverified"
        '
        'btnVerified
        '
        Me.btnVerified.Location = New System.Drawing.Point(264, 336)
        Me.btnVerified.Name = "btnVerified"
        Me.btnVerified.Size = New System.Drawing.Size(72, 32)
        Me.btnVerified.TabIndex = 3
        Me.btnVerified.Text = "Show Verified"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(592, 336)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(64, 32)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Exit"
        '
        'callUnverified
        '
        Me.callUnverified.DeleteCommand = Me.OleDbDeleteCommand3
        Me.callUnverified.InsertCommand = Me.OleDbInsertCommand3
        Me.callUnverified.SelectCommand = Me.OleDbSelectCommand3
        Me.callUnverified.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ReportData", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AutoID", "AutoID"), New System.Data.Common.DataColumnMapping("CallID", "CallID"), New System.Data.Common.DataColumnMapping("Confirmation", "Confirmation"), New System.Data.Common.DataColumnMapping("SID", "SID"), New System.Data.Common.DataColumnMapping("Subscriber", "Subscriber"), New System.Data.Common.DataColumnMapping("Fname", "Fname"), New System.Data.Common.DataColumnMapping("Lname", "Lname"), New System.Data.Common.DataColumnMapping("DOB", "DOB"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("CBtime", "CBtime"), New System.Data.Common.DataColumnMapping("AnonReq", "AnonReq"), New System.Data.Common.DataColumnMapping("Lang", "Lang"), New System.Data.Common.DataColumnMapping("Comments", "Comments"), New System.Data.Common.DataColumnMapping("verified", "verified"), New System.Data.Common.DataColumnMapping("Verifiedby", "Verifiedby"), New System.Data.Common.DataColumnMapping("VerifiedDate", "VerifiedDate"), New System.Data.Common.DataColumnMapping("CallDate", "CallDate"), New System.Data.Common.DataColumnMapping("CallStatus", "CallStatus"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("Expr2", "Expr2")})})
        Me.callUnverified.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM ReportData WHERE (AutoID = ?) AND (CallDate = ? OR ? IS NULL AND Call" & _
        "Date IS NULL) AND (verified = ?) AND (AnonReq = ? OR ? IS NULL AND AnonReq IS NU" & _
        "LL) AND (CBtime = ? OR ? IS NULL AND CBtime IS NULL) AND (CallDate = ? OR ? IS N" & _
        "ULL AND CallDate IS NULL) AND (CallID = ? OR ? IS NULL AND CallID IS NULL) AND (" & _
        "CallStatus = ? OR ? IS NULL AND CallStatus IS NULL) AND (Comments = ? OR ? IS NU" & _
        "LL AND Comments IS NULL) AND (Confirmation = ? OR ? IS NULL AND Confirmation IS " & _
        "NULL) AND (DOB = ? OR ? IS NULL AND DOB IS NULL) AND (Fname = ? OR ? IS NULL AND" & _
        " Fname IS NULL) AND (Lang = ? OR ? IS NULL AND Lang IS NULL) AND (Lname = ? OR ?" & _
        " IS NULL AND Lname IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL) AND (" & _
        "SID = ? OR ? IS NULL AND SID IS NULL) AND (Subscriber = ? OR ? IS NULL AND Subsc" & _
        "riber IS NULL) AND (VerifiedDate = ? OR ? IS NULL AND VerifiedDate IS NULL) AND " & _
        "(Verifiedby = ? OR ? IS NULL AND Verifiedby IS NULL) AND (verified = ?)"
        Me.OleDbDeleteCommand3.Connection = Me.CallreportConn
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AutoID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "AutoID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_verified", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "verified", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnonReq", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnonReq", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnonReq1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnonReq", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBtime", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBtime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBtime1", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBtime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate2", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate3", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallStatus", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallStatus", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallStatus1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallStatus", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Confirmation", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Confirmation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Confirmation1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Confirmation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DOB", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DOB1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fname1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lang", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lang", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lang1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lang", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lname1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SID", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SID1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Subscriber", System.Data.OleDb.OleDbType.VarWChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subscriber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Subscriber1", System.Data.OleDb.OleDbType.VarWChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subscriber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VerifiedDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VerifiedDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VerifiedDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VerifiedDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Verifiedby", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Verifiedby", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Verifiedby1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Verifiedby", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_verified1", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "verified", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO ReportData(verified, CallDate, AnonReq, CallID, CallStatus, CBtime, C" & _
        "omments, Confirmation, DOB, Fname, Lang, Lname, Phone, SID, Subscriber, Verified" & _
        "by, VerifiedDate) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand3.Connection = Me.CallreportConn
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("verified", System.Data.OleDb.OleDbType.Boolean, 2, "verified"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallDate", System.Data.OleDb.OleDbType.DBDate, 0, "CallDate"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnonReq", System.Data.OleDb.OleDbType.VarWChar, 15, "AnonReq"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallID", System.Data.OleDb.OleDbType.VarWChar, 20, "CallID"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallStatus", System.Data.OleDb.OleDbType.VarWChar, 50, "CallStatus"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CBtime", System.Data.OleDb.OleDbType.VarWChar, 25, "CBtime"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Comments", System.Data.OleDb.OleDbType.VarWChar, 255, "Comments"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Confirmation", System.Data.OleDb.OleDbType.VarWChar, 20, "Confirmation"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DOB", System.Data.OleDb.OleDbType.VarWChar, 50, "DOB"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Fname", System.Data.OleDb.OleDbType.VarWChar, 20, "Fname"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Lang", System.Data.OleDb.OleDbType.VarWChar, 10, "Lang"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Lname", System.Data.OleDb.OleDbType.VarWChar, 20, "Lname"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 50, "Phone"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SID", System.Data.OleDb.OleDbType.VarWChar, 10, "SID"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Subscriber", System.Data.OleDb.OleDbType.VarWChar, 35, "Subscriber"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Verifiedby", System.Data.OleDb.OleDbType.VarWChar, 20, "Verifiedby"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("VerifiedDate", System.Data.OleDb.OleDbType.DBDate, 0, "VerifiedDate"))
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT verified AS Expr1, CallDate AS Expr2, AnonReq, AutoID, CallDate, CallID, C" & _
        "allStatus, CBtime, Comments, Confirmation, DOB, Fname, Lang, Lname, Phone, SID, " & _
        "Subscriber, verified, Verifiedby, VerifiedDate FROM ReportData WHERE (verified =" & _
        " 0) ORDER BY CallDate"
        Me.OleDbSelectCommand3.Connection = Me.CallreportConn
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = "UPDATE ReportData SET verified = ?, CallDate = ?, AnonReq = ?, CallID = ?, CallSt" & _
        "atus = ?, CBtime = ?, Comments = ?, Confirmation = ?, DOB = ?, Fname = ?, Lang =" & _
        " ?, Lname = ?, Phone = ?, SID = ?, Subscriber = ?, Verifiedby = ?, VerifiedDate " & _
        "= ? WHERE (AutoID = ?) AND (CallDate = ? OR ? IS NULL AND CallDate IS NULL) AND " & _
        "(verified = ?) AND (AnonReq = ? OR ? IS NULL AND AnonReq IS NULL) AND (CBtime = " & _
        "? OR ? IS NULL AND CBtime IS NULL) AND (CallDate = ? OR ? IS NULL AND CallDate I" & _
        "S NULL) AND (CallID = ? OR ? IS NULL AND CallID IS NULL) AND (CallStatus = ? OR " & _
        "? IS NULL AND CallStatus IS NULL) AND (Comments = ? OR ? IS NULL AND Comments IS" & _
        " NULL) AND (Confirmation = ? OR ? IS NULL AND Confirmation IS NULL) AND (DOB = ?" & _
        " OR ? IS NULL AND DOB IS NULL) AND (Fname = ? OR ? IS NULL AND Fname IS NULL) AN" & _
        "D (Lang = ? OR ? IS NULL AND Lang IS NULL) AND (Lname = ? OR ? IS NULL AND Lname" & _
        " IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL) AND (SID = ? OR ? IS NU" & _
        "LL AND SID IS NULL) AND (Subscriber = ? OR ? IS NULL AND Subscriber IS NULL) AND" & _
        " (VerifiedDate = ? OR ? IS NULL AND VerifiedDate IS NULL) AND (Verifiedby = ? OR" & _
        " ? IS NULL AND Verifiedby IS NULL) AND (verified = ?)"
        Me.OleDbUpdateCommand3.Connection = Me.CallreportConn
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("verified", System.Data.OleDb.OleDbType.Boolean, 2, "verified"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallDate", System.Data.OleDb.OleDbType.DBDate, 0, "CallDate"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnonReq", System.Data.OleDb.OleDbType.VarWChar, 15, "AnonReq"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallID", System.Data.OleDb.OleDbType.VarWChar, 20, "CallID"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CallStatus", System.Data.OleDb.OleDbType.VarWChar, 50, "CallStatus"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CBtime", System.Data.OleDb.OleDbType.VarWChar, 25, "CBtime"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Comments", System.Data.OleDb.OleDbType.VarWChar, 255, "Comments"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Confirmation", System.Data.OleDb.OleDbType.VarWChar, 20, "Confirmation"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DOB", System.Data.OleDb.OleDbType.VarWChar, 50, "DOB"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Fname", System.Data.OleDb.OleDbType.VarWChar, 20, "Fname"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Lang", System.Data.OleDb.OleDbType.VarWChar, 10, "Lang"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Lname", System.Data.OleDb.OleDbType.VarWChar, 20, "Lname"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 50, "Phone"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SID", System.Data.OleDb.OleDbType.VarWChar, 10, "SID"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Subscriber", System.Data.OleDb.OleDbType.VarWChar, 35, "Subscriber"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Verifiedby", System.Data.OleDb.OleDbType.VarWChar, 20, "Verifiedby"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("VerifiedDate", System.Data.OleDb.OleDbType.DBDate, 0, "VerifiedDate"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AutoID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "AutoID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_verified", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "verified", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnonReq", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnonReq", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnonReq1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnonReq", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBtime", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBtime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CBtime1", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CBtime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate2", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallDate3", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallStatus", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallStatus", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CallStatus1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CallStatus", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Confirmation", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Confirmation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Confirmation1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Confirmation", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DOB", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DOB1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fname1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lang", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lang", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lang1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lang", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Lname1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SID", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SID1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Subscriber", System.Data.OleDb.OleDbType.VarWChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subscriber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Subscriber1", System.Data.OleDb.OleDbType.VarWChar, 35, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subscriber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VerifiedDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VerifiedDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VerifiedDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VerifiedDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Verifiedby", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Verifiedby", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Verifiedby1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Verifiedby", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_verified1", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "verified", System.Data.DataRowVersion.Original, Nothing))
        '
        'Callverified1
        '
        Me.Callverified1.DataSetName = "Callverified"
        Me.Callverified1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.Callverified1.Namespace = "http://www.tempuri.org/Callverified.xsd"
        '
        'CallUnverified1
        '
        Me.CallUnverified1.DataSetName = "CallUnverified"
        Me.CallUnverified1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CallUnverified1.Namespace = "http://www.tempuri.org/CallUnverified.xsd"
        '
        'Verified
        '
        Me.Verified.AlternatingBackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Verified.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.Verified.DataMember = "ReportData"
        Me.Verified.DataSource = Me.CallUnverified1
        Me.Verified.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Verified.Location = New System.Drawing.Point(24, 24)
        Me.Verified.Name = "Verified"
        Me.Verified.Size = New System.Drawing.Size(672, 304)
        Me.Verified.TabIndex = 6
        '
        'report
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 382)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Verified, Me.btnClose, Me.btnVerified, Me.btnUnverified, Me.btnAllData})
        Me.Name = "report"
        Me.Text = "Reports"
        CType(Me.CallReport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Callverified1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CallUnverified1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Verified, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CallUnverified1.Clear()
        callUnverified.Fill(CallUnverified1)
    End Sub

    Private Sub btnAllData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllData.Click
    End Sub

    Private Sub btnUnverified_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnverified.Click
    End Sub

    Private Sub btnVerified_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerified.Click

    End Sub
End Class
