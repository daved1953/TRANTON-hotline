﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.0.3705.288
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class CallReport
    Inherits DataSet
    
    Private tableReportData As ReportDataDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("ReportData")) Is Nothing) Then
                Me.Tables.Add(New ReportDataDataTable(ds.Tables("ReportData")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property ReportData As ReportDataDataTable
        Get
            Return Me.tableReportData
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As CallReport = CType(MyBase.Clone,CallReport)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("ReportData")) Is Nothing) Then
            Me.Tables.Add(New ReportDataDataTable(ds.Tables("ReportData")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableReportData = CType(Me.Tables("ReportData"),ReportDataDataTable)
        If (Not (Me.tableReportData) Is Nothing) Then
            Me.tableReportData.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "CallReport"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/CallReport.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableReportData = New ReportDataDataTable
        Me.Tables.Add(Me.tableReportData)
    End Sub
    
    Private Function ShouldSerializeReportData() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub ReportDataRowChangeEventHandler(ByVal sender As Object, ByVal e As ReportDataRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ReportDataDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnAnonReq As DataColumn
        
        Private columnCallDate As DataColumn
        
        Private columnCallStatus As DataColumn
        
        Private columnCBtime As DataColumn
        
        Private columnComments As DataColumn
        
        Private columnConfirmation As DataColumn
        
        Private columnDOB As DataColumn
        
        Private columnFname As DataColumn
        
        Private columnLang As DataColumn
        
        Private columnLname As DataColumn
        
        Private columnPhone As DataColumn
        
        Private columnSID As DataColumn
        
        Private columnSubscriber As DataColumn
        
        Private columnverified As DataColumn
        
        Private columnVerifiedby As DataColumn
        
        Private columnVerifiedDate As DataColumn
        
        Private columnAutoID As DataColumn
        
        Friend Sub New()
            MyBase.New("ReportData")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property AnonReqColumn As DataColumn
            Get
                Return Me.columnAnonReq
            End Get
        End Property
        
        Friend ReadOnly Property CallDateColumn As DataColumn
            Get
                Return Me.columnCallDate
            End Get
        End Property
        
        Friend ReadOnly Property CallStatusColumn As DataColumn
            Get
                Return Me.columnCallStatus
            End Get
        End Property
        
        Friend ReadOnly Property CBtimeColumn As DataColumn
            Get
                Return Me.columnCBtime
            End Get
        End Property
        
        Friend ReadOnly Property CommentsColumn As DataColumn
            Get
                Return Me.columnComments
            End Get
        End Property
        
        Friend ReadOnly Property ConfirmationColumn As DataColumn
            Get
                Return Me.columnConfirmation
            End Get
        End Property
        
        Friend ReadOnly Property DOBColumn As DataColumn
            Get
                Return Me.columnDOB
            End Get
        End Property
        
        Friend ReadOnly Property FnameColumn As DataColumn
            Get
                Return Me.columnFname
            End Get
        End Property
        
        Friend ReadOnly Property LangColumn As DataColumn
            Get
                Return Me.columnLang
            End Get
        End Property
        
        Friend ReadOnly Property LnameColumn As DataColumn
            Get
                Return Me.columnLname
            End Get
        End Property
        
        Friend ReadOnly Property PhoneColumn As DataColumn
            Get
                Return Me.columnPhone
            End Get
        End Property
        
        Friend ReadOnly Property SIDColumn As DataColumn
            Get
                Return Me.columnSID
            End Get
        End Property
        
        Friend ReadOnly Property SubscriberColumn As DataColumn
            Get
                Return Me.columnSubscriber
            End Get
        End Property
        
        Friend ReadOnly Property verifiedColumn As DataColumn
            Get
                Return Me.columnverified
            End Get
        End Property
        
        Friend ReadOnly Property VerifiedbyColumn As DataColumn
            Get
                Return Me.columnVerifiedby
            End Get
        End Property
        
        Friend ReadOnly Property VerifiedDateColumn As DataColumn
            Get
                Return Me.columnVerifiedDate
            End Get
        End Property
        
        Friend ReadOnly Property AutoIDColumn As DataColumn
            Get
                Return Me.columnAutoID
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As ReportDataRow
            Get
                Return CType(Me.Rows(index),ReportDataRow)
            End Get
        End Property
        
        Public Event ReportDataRowChanged As ReportDataRowChangeEventHandler
        
        Public Event ReportDataRowChanging As ReportDataRowChangeEventHandler
        
        Public Event ReportDataRowDeleted As ReportDataRowChangeEventHandler
        
        Public Event ReportDataRowDeleting As ReportDataRowChangeEventHandler
        
        Public Overloads Sub AddReportDataRow(ByVal row As ReportDataRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddReportDataRow( _
                    ByVal AnonReq As String,  _
                    ByVal CallDate As Date,  _
                    ByVal CallStatus As String,  _
                    ByVal CBtime As String,  _
                    ByVal Comments As String,  _
                    ByVal Confirmation As String,  _
                    ByVal DOB As String,  _
                    ByVal Fname As String,  _
                    ByVal Lang As String,  _
                    ByVal Lname As String,  _
                    ByVal Phone As String,  _
                    ByVal SID As String,  _
                    ByVal Subscriber As String,  _
                    ByVal verified As Boolean,  _
                    ByVal Verifiedby As String,  _
                    ByVal VerifiedDate As Date) As ReportDataRow
            Dim rowReportDataRow As ReportDataRow = CType(Me.NewRow,ReportDataRow)
            rowReportDataRow.ItemArray = New Object() {AnonReq, CallDate, CallStatus, CBtime, Comments, Confirmation, DOB, Fname, Lang, Lname, Phone, SID, Subscriber, verified, Verifiedby, VerifiedDate, Nothing}
            Me.Rows.Add(rowReportDataRow)
            Return rowReportDataRow
        End Function
        
        Public Function FindByAutoID(ByVal AutoID As Integer) As ReportDataRow
            Return CType(Me.Rows.Find(New Object() {AutoID}),ReportDataRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As ReportDataDataTable = CType(MyBase.Clone,ReportDataDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New ReportDataDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnAnonReq = Me.Columns("AnonReq")
            Me.columnCallDate = Me.Columns("CallDate")
            Me.columnCallStatus = Me.Columns("CallStatus")
            Me.columnCBtime = Me.Columns("CBtime")
            Me.columnComments = Me.Columns("Comments")
            Me.columnConfirmation = Me.Columns("Confirmation")
            Me.columnDOB = Me.Columns("DOB")
            Me.columnFname = Me.Columns("Fname")
            Me.columnLang = Me.Columns("Lang")
            Me.columnLname = Me.Columns("Lname")
            Me.columnPhone = Me.Columns("Phone")
            Me.columnSID = Me.Columns("SID")
            Me.columnSubscriber = Me.Columns("Subscriber")
            Me.columnverified = Me.Columns("verified")
            Me.columnVerifiedby = Me.Columns("Verifiedby")
            Me.columnVerifiedDate = Me.Columns("VerifiedDate")
            Me.columnAutoID = Me.Columns("AutoID")
        End Sub
        
        Private Sub InitClass()
            Me.columnAnonReq = New DataColumn("AnonReq", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAnonReq)
            Me.columnCallDate = New DataColumn("CallDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCallDate)
            Me.columnCallStatus = New DataColumn("CallStatus", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCallStatus)
            Me.columnCBtime = New DataColumn("CBtime", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCBtime)
            Me.columnComments = New DataColumn("Comments", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnComments)
            Me.columnConfirmation = New DataColumn("Confirmation", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnConfirmation)
            Me.columnDOB = New DataColumn("DOB", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDOB)
            Me.columnFname = New DataColumn("Fname", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFname)
            Me.columnLang = New DataColumn("Lang", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnLang)
            Me.columnLname = New DataColumn("Lname", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnLname)
            Me.columnPhone = New DataColumn("Phone", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPhone)
            Me.columnSID = New DataColumn("SID", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSID)
            Me.columnSubscriber = New DataColumn("Subscriber", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSubscriber)
            Me.columnverified = New DataColumn("verified", GetType(System.Boolean), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnverified)
            Me.columnVerifiedby = New DataColumn("Verifiedby", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnVerifiedby)
            Me.columnVerifiedDate = New DataColumn("VerifiedDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnVerifiedDate)
            Me.columnAutoID = New DataColumn("AutoID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAutoID)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnAutoID}, true))
            Me.columnAutoID.AutoIncrement = true
            Me.columnAutoID.AllowDBNull = false
            Me.columnAutoID.Unique = true
        End Sub
        
        Public Function NewReportDataRow() As ReportDataRow
            Return CType(Me.NewRow,ReportDataRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New ReportDataRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(ReportDataRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ReportDataRowChangedEvent) Is Nothing) Then
                RaiseEvent ReportDataRowChanged(Me, New ReportDataRowChangeEvent(CType(e.Row,ReportDataRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ReportDataRowChangingEvent) Is Nothing) Then
                RaiseEvent ReportDataRowChanging(Me, New ReportDataRowChangeEvent(CType(e.Row,ReportDataRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ReportDataRowDeletedEvent) Is Nothing) Then
                RaiseEvent ReportDataRowDeleted(Me, New ReportDataRowChangeEvent(CType(e.Row,ReportDataRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ReportDataRowDeletingEvent) Is Nothing) Then
                RaiseEvent ReportDataRowDeleting(Me, New ReportDataRowChangeEvent(CType(e.Row,ReportDataRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveReportDataRow(ByVal row As ReportDataRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ReportDataRow
        Inherits DataRow
        
        Private tableReportData As ReportDataDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableReportData = CType(Me.Table,ReportDataDataTable)
        End Sub
        
        Public Property AnonReq As String
            Get
                Try 
                    Return CType(Me(Me.tableReportData.AnonReqColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReportData.AnonReqColumn) = value
            End Set
        End Property
        
        Public Property CallDate As Date
            Get
                Try 
                    Return CType(Me(Me.tableReportData.CallDateColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReportData.CallDateColumn) = value
            End Set
        End Property
        
        Public Property CallStatus As String
            Get
                Try 
                    Return CType(Me(Me.tableReportData.CallStatusColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReportData.CallStatusColumn) = value
            End Set
        End Property
        
        Public Property CBtime As String
            Get
                Try 
                    Return CType(Me(Me.tableReportData.CBtimeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReportData.CBtimeColumn) = value
            End Set
        End Property
        
        Public Property Comments As String
            Get
                Try 
                    Return CType(Me(Me.tableReportData.CommentsColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReportData.CommentsColumn) = value
            End Set
        End Property
        
        Public Property Confirmation As String
            Get
                Try 
                    Return CType(Me(Me.tableReportData.ConfirmationColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReportData.ConfirmationColumn) = value
            End Set
        End Property
        
        Public Property DOB As String
            Get
                Try 
                    Return CType(Me(Me.tableReportData.DOBColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReportData.DOBColumn) = value
            End Set
        End Property
        
        Public Property Fname As String
            Get
                Try 
                    Return CType(Me(Me.tableReportData.FnameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReportData.FnameColumn) = value
            End Set
        End Property
        
        Public Property Lang As String
            Get
                Try 
                    Return CType(Me(Me.tableReportData.LangColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReportData.LangColumn) = value
            End Set
        End Property
        
        Public Property Lname As String
            Get
                Try 
                    Return CType(Me(Me.tableReportData.LnameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReportData.LnameColumn) = value
            End Set
        End Property
        
        Public Property Phone As String
            Get
                Try 
                    Return CType(Me(Me.tableReportData.PhoneColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReportData.PhoneColumn) = value
            End Set
        End Property
        
        Public Property SID As String
            Get
                Try 
                    Return CType(Me(Me.tableReportData.SIDColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReportData.SIDColumn) = value
            End Set
        End Property
        
        Public Property Subscriber As String
            Get
                Try 
                    Return CType(Me(Me.tableReportData.SubscriberColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReportData.SubscriberColumn) = value
            End Set
        End Property
        
        Public Property verified As Boolean
            Get
                Try 
                    Return CType(Me(Me.tableReportData.verifiedColumn),Boolean)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReportData.verifiedColumn) = value
            End Set
        End Property
        
        Public Property Verifiedby As String
            Get
                Try 
                    Return CType(Me(Me.tableReportData.VerifiedbyColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReportData.VerifiedbyColumn) = value
            End Set
        End Property
        
        Public Property VerifiedDate As Date
            Get
                Try 
                    Return CType(Me(Me.tableReportData.VerifiedDateColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReportData.VerifiedDateColumn) = value
            End Set
        End Property
        
        Public Property AutoID As Integer
            Get
                Return CType(Me(Me.tableReportData.AutoIDColumn),Integer)
            End Get
            Set
                Me(Me.tableReportData.AutoIDColumn) = value
            End Set
        End Property
        
        Public Function IsAnonReqNull() As Boolean
            Return Me.IsNull(Me.tableReportData.AnonReqColumn)
        End Function
        
        Public Sub SetAnonReqNull()
            Me(Me.tableReportData.AnonReqColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCallDateNull() As Boolean
            Return Me.IsNull(Me.tableReportData.CallDateColumn)
        End Function
        
        Public Sub SetCallDateNull()
            Me(Me.tableReportData.CallDateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCallStatusNull() As Boolean
            Return Me.IsNull(Me.tableReportData.CallStatusColumn)
        End Function
        
        Public Sub SetCallStatusNull()
            Me(Me.tableReportData.CallStatusColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCBtimeNull() As Boolean
            Return Me.IsNull(Me.tableReportData.CBtimeColumn)
        End Function
        
        Public Sub SetCBtimeNull()
            Me(Me.tableReportData.CBtimeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCommentsNull() As Boolean
            Return Me.IsNull(Me.tableReportData.CommentsColumn)
        End Function
        
        Public Sub SetCommentsNull()
            Me(Me.tableReportData.CommentsColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsConfirmationNull() As Boolean
            Return Me.IsNull(Me.tableReportData.ConfirmationColumn)
        End Function
        
        Public Sub SetConfirmationNull()
            Me(Me.tableReportData.ConfirmationColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDOBNull() As Boolean
            Return Me.IsNull(Me.tableReportData.DOBColumn)
        End Function
        
        Public Sub SetDOBNull()
            Me(Me.tableReportData.DOBColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsFnameNull() As Boolean
            Return Me.IsNull(Me.tableReportData.FnameColumn)
        End Function
        
        Public Sub SetFnameNull()
            Me(Me.tableReportData.FnameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsLangNull() As Boolean
            Return Me.IsNull(Me.tableReportData.LangColumn)
        End Function
        
        Public Sub SetLangNull()
            Me(Me.tableReportData.LangColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsLnameNull() As Boolean
            Return Me.IsNull(Me.tableReportData.LnameColumn)
        End Function
        
        Public Sub SetLnameNull()
            Me(Me.tableReportData.LnameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPhoneNull() As Boolean
            Return Me.IsNull(Me.tableReportData.PhoneColumn)
        End Function
        
        Public Sub SetPhoneNull()
            Me(Me.tableReportData.PhoneColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSIDNull() As Boolean
            Return Me.IsNull(Me.tableReportData.SIDColumn)
        End Function
        
        Public Sub SetSIDNull()
            Me(Me.tableReportData.SIDColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSubscriberNull() As Boolean
            Return Me.IsNull(Me.tableReportData.SubscriberColumn)
        End Function
        
        Public Sub SetSubscriberNull()
            Me(Me.tableReportData.SubscriberColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsverifiedNull() As Boolean
            Return Me.IsNull(Me.tableReportData.verifiedColumn)
        End Function
        
        Public Sub SetverifiedNull()
            Me(Me.tableReportData.verifiedColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsVerifiedbyNull() As Boolean
            Return Me.IsNull(Me.tableReportData.VerifiedbyColumn)
        End Function
        
        Public Sub SetVerifiedbyNull()
            Me(Me.tableReportData.VerifiedbyColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsVerifiedDateNull() As Boolean
            Return Me.IsNull(Me.tableReportData.VerifiedDateColumn)
        End Function
        
        Public Sub SetVerifiedDateNull()
            Me(Me.tableReportData.VerifiedDateColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ReportDataRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As ReportDataRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As ReportDataRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As ReportDataRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
