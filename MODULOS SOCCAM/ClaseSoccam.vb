Imports System.Text.RegularExpressions

Public Class ClaseSoccam

    Private Declare Function CreateCaret Lib "user32" (ByVal hWnd As IntPtr, ByVal hBitmap As IntPtr, ByVal nWidth As Integer, ByVal nHeight As Integer) As Boolean
    Private Declare Function DestroyCaret Lib "user32" () As Long
    Private Declare Function SetCaretBlinkTime Lib "user32" (ByVal wMSeconds As Long) As Long
    Private Declare Function SetCaretPos Lib "user32" (ByVal x As Long, ByVal y As Long) As Long
    Private Declare Function ShowCaret Lib "user32" (ByVal hwnd As IntPtr) As Boolean
    Private Declare Function HideCaret Lib "user32" (ByVal hwnd As Long) As Long

    Private Property nombre As String = ""
    Public Property code As String = ""
    Public Property output As String = ""

    Dim savePath As String = ""
    Dim saveModPath As String = ""
    Dim Uri = New System.Uri("C:\\")
    Dim resourceCollection As New List(Of String)

    Private Sub loadResources(ByVal htmlCode As String, ByVal htmlFile As String)
        Dim path As String = htmlFile.Substring(0, htmlFile.LastIndexOf("\") + 1)
        Dim linkPattern As String = "<link.*rel=""stylesheet"".*>"
        Dim insideLinkPattern As String = "href="".*"""
        Dim tmpFile As String = ""
        Dim tmpStr As String = ""
        For Each match As Match In Regex.Matches(htmlCode, linkPattern)
            tmpFile = path + Regex.Match(match.Value, insideLinkPattern).Value.Remove(0, 6).Trim("""").Replace("/", "\")
            Dim sr As New IO.StreamReader(tmpFile, System.Text.Encoding.UTF8)
            tmpStr = sr.ReadToEnd
            tmpStr = "<style>" + tmpStr + "</style>"
            resourceCollection.Add(tmpStr)
        Next
    End Sub


    Public Sub ProcessModule()
        Dim strFunction As String = output.Replace("End Module", "") & vbTab & "Public Function "
        If nombre <> 0 Then strFunction &= nombre

        strFunction &= "() as String" & vbCrLf
        strFunction &= vbTab & vbTab & "Dim tmpStr as String = """"" & vbCrLf
        Dim tabs As String = vbTab & vbTab
        For Each line In code.Split(vbCrLf)
            Dim tmpLine As String = line.Replace("""", """""").Replace(vbTab, "").Trim(" ")
            If tmpLine.Length <> 0 Then
                If tmpLine.StartsWith("<!--") Then
                    strFunction &= tabs & tmpLine.Replace("<!--", "").Replace("-->", "").Trim(" ") & vbCrLf
                Else
                    strFunction &= tabs & "tmpStr &= """ & tmpLine & """ & vbCrLf" & vbCrLf
                End If

            End If
        Next
        strFunction &= vbTab & vbTab & "Return tmpStr" & vbCrLf
        strFunction &= vbTab & "End Function" & vbCrLf & vbCrLf & vbCrLf

        output = strFunction & "End Module"
    End Sub


    Public Function CamelCaseToUnderscore(ByVal str As String) As String
        Dim count As Integer = 0
        Dim finalString As String = str
        Dim inserts As New List(Of Integer)
        For Each letra In str
            If letra.ToString = str.Substring(count, 1).ToUpper Then
                inserts.Add(count)
            End If
            count += 1
        Next

        If inserts.Count > 0 Then
            inserts.Reverse()
            count = 0
            For i = str.Length - 1 To 0 Step -1
                If i = inserts(count) Then
                    finalString = finalString.Insert(i, "_")
                    count += 1
                    If count >= inserts.Count Then Exit For
                End If
            Next
        End If

        Return finalString
    End Function

    Public Function CapitalizeFirstLetter(ByVal str As String) As String
        If str.Length > 0 Then
            Dim fstLetter As String = str.Substring(0, 1).ToUpper
            str = fstLetter & str.Substring(1, str.Length - 1)
        End If
        Return str
    End Function

    Private Sub CrearTablas()
        Dim table_name As String = ""
        Dim campos As New List(Of String)
        output = ""

        For Each tmpLine As String In code.Split(vbCrLf)
            If tmpLine.Trim.StartsWith("#") Then Continue For
            If tmpLine.Trim.StartsWith("END TABLE") Then
                table_name = ""
                Dim tmpAllField As String = vbTab & "Const ALL As String = "
                Dim count As Integer = 0
                For Each tmpCampos In campos
                    tmpAllField &= tmpCampos
                    count += 1
                    If count <> campos.Count Then
                        tmpAllField &= " & "", "" & "
                    End If
                Next
                output &= tmpAllField & vbCrLf
                output &= "End Structure" & vbCrLf & vbCrLf
                campos.Clear()
                Continue For
            End If

            If tmpLine.Trim.StartsWith("TABLE") Then
                table_name &= tmpLine.Replace("TABLE", "").Trim
                nombre = table_name
                If nombre.EndsWith("s") Then
                    nombre = nombre.Remove(nombre.Length - 1, 1)
                End If
                output &= "Public Structure TABLA_" & CamelCaseToUnderscore(table_name).ToUpper & vbCrLf
                output &= vbTab & "Const TABLA_NOMBRE As String = """ & table_name & """" & vbCrLf
            Else
                If tmpLine.Trim.Contains("=") Then
                    Dim tmplne As String = tmpLine.Split("=")(0).Trim
                    Dim campo As String = CamelCaseToUnderscore(tmplne).ToUpper
                    campos.Add(campo)
                    output &= vbTab & "Const " & campo & " As String = TABLA_NOMBRE & ""_" & tmplne & """" & vbCrLf
                End If
            End If
        Next
    End Sub

    Private Function GenerarTabla(ByVal txt As String) As String
        Dim table_name As String = ""
        Dim campos As New List(Of String)
        Dim output As String = vbCrLf & vbCrLf
        For Each tmpLine As String In txt.Split(vbLf)
            If tmpLine.Trim.StartsWith("#") Then Continue For
            If tmpLine.Trim.StartsWith("END TABLE") Then
                table_name = ""
                Dim tmpAllField As String = vbTab & "Const ALL As String = "
                Dim count As Integer = 0
                For Each tmpCampos In campos
                    tmpAllField &= tmpCampos
                    count += 1
                    If count <> campos.Count Then
                        tmpAllField &= " & "", "" & "
                    End If
                Next
                output &= tmpAllField & vbCrLf
                output &= "End Structure" & vbCrLf & vbCrLf
                campos.Clear()
                Continue For
            End If

            If tmpLine.Trim.StartsWith("TABLE") Then
                table_name &= tmpLine.Replace("TABLE", "").Trim
                nombre = table_name
                If nombre.EndsWith("s") Then
                    nombre = nombre.Remove(nombre.Length - 1, 1)
                End If
                output &= "Public Structure TABLA" & vbCrLf
                output &= vbTab & "Const TABLA_NOMBRE As String = """ & table_name & """" & vbCrLf
            Else
                If tmpLine.Trim.Contains("=") Then
                    Dim tmplne As String = tmpLine.Split("=")(0).Trim
                    Dim campo As String = CamelCaseToUnderscore(tmplne).ToUpper
                    campos.Add(campo)
                    output &= vbTab & "Const " & campo & " As String = TABLA_NOMBRE & ""_" & tmplne & """" & vbCrLf
                End If
            End If
        Next

        output &= vbCrLf & vbCrLf


        Return output
    End Function

    Public Sub GenerarClase()
        Dim class_name As String = ""
        Dim campos As New List(Of String)

        Dim vars As New List(Of String)
        Dim varsType As New List(Of String)
        Dim sqlTablas As New List(Of String)

        For Each tmpLine As String In code.Split(vbLf)
            If tmpLine.Trim.StartsWith("#") Then Continue For

            ' Segundo paso primero, por si hay mas de una tabla

            If tmpLine.Trim.StartsWith("END TABLE") Then


                output &= AddEnums()
                output &= GenerarTabla(code)


                output &= AddNewSub()
                output &= AddInjectSQLSub() & vbCrLf & vbCrLf
                output &= AddLoadMeFunction(vars, varsType, campos)
                output &= AddLoadAllFunction(vars, varsType, campos)
                output &= AddSaveFunction(vars, varsType, campos)
                output &= AddDeleteFunction()
                output &= AddQuickSearch(vars, varsType, campos)

                output &= "End Class" & vbCrLf & vbCrLf
                campos.Clear()
                Continue For
            End If


            ' Primer paso, procesar las variables


            If tmpLine.Trim.StartsWith("TABLE") Then
                class_name = tmpLine.Replace("TABLE", "").Trim
                nombre = class_name
                class_name = CamelCaseToUnderscore(class_name).ToUpper
                If nombre.EndsWith("s") Then
                    nombre = nombre.Remove(nombre.Length - 1, 1)
                End If

                output &= "Imports helix" & vbCrLf
                output &= "Public Class " & nombre & vbCrLf
                output &= vbTab & "Public Property sqle As New SQLEngine" & vbCrLf
                output &= vbTab & "Public Property searchResult As New List(of " & nombre & ")" & vbCrLf & vbCrLf
            Else
                If tmpLine.Trim.Contains("=") Then
                    Dim tmplne As String = tmpLine.Split("=")(0).Trim

                    Dim tmpType As String = tmpLine.Split("=")(1).Trim
                    Dim defaultValue As String = ""

                    ' Cargar campo a la lista
                    Dim campo As String = "TABLA." & CamelCaseToUnderscore(tmplne).ToUpper
                    campos.Add(campo)

                    ' Cargar a la lista de variables
                    vars.Add(tmplne)


                    ' Cargar a la lista de tipo de variable
                    If (tmpType.ToLower.IndexOf("pk") >= 0) Then
                        varsType.Add("cLng")
                        tmpType = "Long"
                        defaultValue = "0"
                    ElseIf tmpType.ToLower.IndexOf("long") >= 0 Then
                        varsType.Add("cLng")
                        tmpType = "Long"
                        defaultValue = "0"
                    ElseIf tmpType.ToLower.IndexOf("int") >= 0 Then
                        varsType.Add("cInt")
                        tmpType = "Integer"
                        defaultValue = "0"
                    ElseIf tmpType.ToLower.IndexOf("bool") >= 0 Then
                        varsType.Add("cBool")
                        tmpType = "Boolean"
                        defaultValue = "False"
                    ElseIf (tmpType.ToLower.IndexOf("string") >= 0) Or (tmpType.ToLower.IndexOf("text") >= 0) Then
                        varsType.Add("cStr")
                        tmpType = "String"
                        defaultValue = """"""
                    ElseIf (tmpType.ToLower.IndexOf("money") >= 0) Or (tmpType.ToLower.IndexOf("percent") >= 0) Then
                        varsType.Add("cDec")
                        tmpType = "Decimal"
                        defaultValue = "0"
                    ElseIf tmpType.ToLower.IndexOf("byte") >= 0 Then
                        varsType.Add("cByte")
                        tmpType = "Byte"
                        defaultValue = "0"
                    ElseIf tmpType.ToLower.IndexOf("img") >= 0 Then
                        varsType.Add("Image")
                        tmpType = "Image"
                        defaultValue = "Nothing"
                    ElseIf tmpType.ToLower.IndexOf("date") >= 0 Or tmpType.ToLower.IndexOf("timestamp") >= 0 Then
                        varsType.Add("cDate")
                        tmpType = "Date"
                        If tmplne.ToLower = "modificado" Then
                            defaultValue = "Now"
                        Else
                            defaultValue = "#1/1/1970#"
                        End If
                    End If

                    output &= vbTab & "Public Property " & CapitalizeFirstLetter(tmplne) & " As " & tmpType & " = " & defaultValue & vbCrLf

                End If
            End If
        Next
    End Sub


    Public Function AddEnums() As String
        Dim tmpStr As String = ""
        tmpStr &= $"{vbTab}Public Enum Guardar as Integer" & vbCrLf
        tmpStr &= $"{vbTab}{vbTab}NUEVO = 0" & vbCrLf
        tmpStr &= $"{vbTab}{vbTab}EDITAR = 1" & vbCrLf
        tmpStr &= $"{vbTab}End Enum" & vbCrLf
        Return tmpStr

    End Function


    Public Function AddQuickSearch(ByVal lstVars As List(Of String), ByVal lstVarTypes As List(Of String), ByVal lstCampos As List(Of String)) As String
        Dim tmpStr As String = ""
        tmpStr &= "Public Function QuickSearch(ByVal columna As String, ByVal operador As SQLEngineQuery.OperatorCriteria, ByVal value As Object) As Integer" & vbCrLf
        tmpStr &= vbTab & "With sqle.Query" & vbCrLf
        tmpStr &= vbTab & vbTab & ".Reset()" & vbCrLf
        tmpStr &= vbTab & vbTab & ".TableName = TABLA.TABLA_NOMBRE" & vbCrLf
        tmpStr &= vbTab & vbTab & ".AddSelectColumn(TABLA.ALL)" & vbCrLf
        tmpStr &= vbTab & vbTab & ".SimpleSearch(columna.ToString, operador, value)" & vbCrLf
        tmpStr &= vbTab & vbTab & "If .Query() Then" & vbCrLf
        tmpStr &= vbTab & vbTab & vbTab & "Me.searchResult.Clear()" & vbCrLf
        tmpStr &= vbTab & vbTab & vbTab & "While .QueryRead" & vbCrLf
        tmpStr &= vbTab & vbTab & vbTab & vbTab & "Dim tmp As New " & nombre & vbCrLf
        Dim counter As Integer = 0
        For Each variable As String In lstVars
            tmpStr &= vbTab & vbTab & vbTab & vbTab & "tmp" & "." & variable & " = " & lstVarTypes(counter) & "(.GetQueryData(" & lstCampos(counter) & "))" & vbCrLf
            counter += 1
        Next
        tmpStr &= vbTab & vbTab & vbTab & vbTab & "searchResult.Add(tmp)" & vbCrLf
        tmpStr &= vbTab & vbTab & vbTab & "End While" & vbCrLf
        tmpStr &= vbTab & vbTab & vbTab & "Return .RecordCount" & vbCrLf
        tmpStr &= vbTab & vbTab & "End If" & vbCrLf
        tmpStr &= vbTab & "End With" & vbCrLf
        tmpStr &= vbTab & "Return 0" & vbCrLf
        tmpStr &= "End Function" & vbCrLf
        Return tmpStr
    End Function

    Public Function AddLoadMeFunction(ByVal lstVars As List(Of String), ByVal lstVarTypes As List(Of String), ByVal lstCampos As List(Of String)) As String

        Dim tablaName As String = lstCampos(0).Substring(0, lstCampos(0).LastIndexOf("."))

        Dim result As String = vbCrLf & vbCrLf

        result &= "Public Function LoadMe(ByVal myID As Integer) As Boolean" & vbCrLf
        result &= vbTab & "With sqle.Query" & vbCrLf

        result &= vbTab & vbTab & ".Reset()" & vbCrLf
        result &= vbTab & vbTab & ".TableName = " & tablaName & ".TABLA_NOMBRE" & vbCrLf
        result &= vbTab & vbTab & ".AddSelectColumn(" & tablaName & ".ALL)" & vbCrLf
        result &= vbTab & vbTab & ".SimpleSearch(" & lstCampos(0) & ", SQLEngineQuery.OperatorCriteria.Igual, myID)" & vbCrLf

        result &= vbTab & vbTab & "If .Query Then" & vbCrLf
        result &= vbTab & vbTab & vbTab & "If .RecordCount >= 1 Then" & vbCrLf
        result &= vbTab & vbTab & vbTab & vbTab & ".QueryRead()" & vbCrLf

        Dim counter As Integer = 0
        For Each variable As String In lstVars
            If counter < lstVarTypes.Count Then
                result &= vbTab & vbTab & vbTab & vbTab & variable & " = " & lstVarTypes(counter) & "(.GetQueryData(" & lstCampos(counter) & "))" & vbCrLf
                counter += 1
            End If
        Next

        result &= vbTab & vbTab & vbTab & vbTab & "Return True" & vbCrLf
        result &= vbTab & vbTab & vbTab & "Else" & vbCrLf
        result &= vbTab & vbTab & vbTab & vbTab & "Return False" & vbCrLf
        result &= vbTab & vbTab & vbTab & "End If" & vbCrLf
        result &= vbTab & vbTab & "Else" & vbCrLf
        result &= vbTab & vbTab & vbTab & "Return False" & vbCrLf
        result &= vbTab & vbTab & "End If" & vbCrLf
        result &= vbTab & "End With" & vbCrLf
        result &= "End Function" & vbCrLf & vbCrLf

        Return result

    End Function


    Public Function AddLoadAllFunction(ByVal lstVars As List(Of String), ByVal lstVarTypes As List(Of String), ByVal lstCampos As List(Of String)) As String
        Dim tablaName As String = lstCampos(0).Substring(0, lstCampos(0).LastIndexOf("."))

        Dim result As String = vbCrLf & vbCrLf

        result &= "Public Function LoadAll(ByRef dt As DataTable) As Boolean" & vbCrLf
        result &= vbTab & "With sqle.Query" & vbCrLf
        result &= vbTab & vbTab & ".Reset()" & vbCrLf
        result &= vbTab & vbTab & ".TableName = " & tablaName & ".TABLA_NOMBRE" & vbCrLf
        result &= vbTab & vbTab & ".AddSelectColumn(" & tablaName & ".ALL)" & vbCrLf
        result &= vbTab & vbTab & ".SimpleSearch(" & tablaName & ".DELETED" & ", SQLEngineQuery.OperatorCriteria.Igual, False)" & vbCrLf
        result &= vbTab & vbTab & "Return .Query(True, dt)" & vbCrLf
        result &= vbTab & "End With" & vbCrLf
        result &= "End Function" & vbCrLf & vbCrLf

        Return result

    End Function

    Public Function AddSaveFunction(ByVal lstVars As List(Of String), ByVal lstVarTypes As List(Of String), ByVal lstCampos As List(Of String)) As String
        Dim tablaName As String = lstCampos(0).Substring(0, lstCampos(0).LastIndexOf("."))

        Dim result As String = vbCrLf & vbCrLf
        Dim counter As Integer = 0

        result &= "Public Function Save(ByVal editMode As GUARDAR) As Boolean" & vbCrLf
        result &= vbTab & "Select Case editMode" & vbCrLf


        result &= vbTab & vbTab & "Case 0" & vbCrLf
        result &= vbTab & vbTab & vbTab & "With sqle.Insert" & vbCrLf
        result &= vbTab & vbTab & vbTab & vbTab & ".Reset()" & vbCrLf
        result &= vbTab & vbTab & vbTab & vbTab & ".TableName = " & tablaName & ".TABLA_NOMBRE" & vbCrLf
        counter = 0
        For Each variable As String In lstVars

            ' Omitir el ID porque no se puede modificar
            If lstVars(counter).ToLower = "id" Then
                counter += 1
                Continue For
            End If

            If lstVars(counter).Contains("modificado") Then
                result &= vbTab & vbTab & vbTab & vbTab & ".AddColumnValue(" & lstCampos(counter) & ", Now)" & vbCrLf
            Else
                result &= vbTab & vbTab & vbTab & vbTab & ".AddColumnValue(" & lstCampos(counter) & ", " & lstVars(counter) & ")" & vbCrLf
            End If


            counter += 1
        Next

        result &= vbTab & vbTab & vbTab & vbTab & "Dim lastID As Integer = 0" & vbCrLf
        result &= vbTab & vbTab & vbTab & vbTab & "If .Insert(lastID) Then" & vbCrLf
        result &= vbTab & vbTab & vbTab & vbTab & vbTab & lstVars(0) & " = lastID" & vbCrLf
        result &= vbTab & vbTab & vbTab & vbTab & vbTab & "Return True" & vbCrLf
        result &= vbTab & vbTab & vbTab & vbTab & "Else" & vbCrLf
        result &= vbTab & vbTab & vbTab & vbTab & vbTab & "Return False" & vbCrLf
        result &= vbTab & vbTab & vbTab & vbTab & "End If" & vbCrLf
        result &= vbTab & vbTab & vbTab & "End With" & vbCrLf


        result &= vbTab & vbTab & "Case 1" & vbCrLf
        result &= vbTab & vbTab & vbTab & "With sqle.Update" & vbCrLf
        result &= vbTab & vbTab & vbTab & vbTab & ".Reset()" & vbCrLf
        result &= vbTab & vbTab & vbTab & vbTab & ".TableName = " & tablaName & ".TABLA_NOMBRE" & vbCrLf
        counter = 0
        For Each variable As String In lstVars

            ' Omitir el ID porque no se puede modificar
            If lstVars(counter).ToLower = "id" Then
                counter += 1
                Continue For
            End If

            If lstVars(counter).Contains("modificado") Then
                result &= vbTab & vbTab & vbTab & vbTab & ".AddColumnValue(" & lstCampos(counter) & ", Now)" & vbCrLf
            Else
                result &= vbTab & vbTab & vbTab & vbTab & ".AddColumnValue(" & lstCampos(counter) & ", " & lstVars(counter) & ")" & vbCrLf
            End If
            counter += 1
        Next
        result &= vbTab & vbTab & vbTab & vbTab & ".SimpleSearch(" & lstCampos(0) & ", SQLEngineQuery.OperatorCriteria.Igual, Id)" & vbCrLf
        result &= vbTab & vbTab & vbTab & vbTab & "Return .Update" & vbCrLf
        result &= vbTab & vbTab & vbTab & "End With" & vbCrLf

        result &= vbTab & vbTab & "Case Else" & vbCrLf
        result &= vbTab & vbTab & vbTab & "Return False" & vbCrLf
        result &= vbTab & "End Select" & vbCrLf
        result &= "End Function" & vbCrLf & vbCrLf

        Return result
    End Function


    Public Function AddNewSub() As String
        Dim tmpStr As String = ""
        tmpStr &= "Public Sub New()" & vbCrLf
        tmpStr &= "End Sub" & vbCrLf & vbCrLf & vbCrLf

        tmpStr &= "Public Sub New(ByVal iSqle As SQLEngine)" & vbCrLf
        tmpStr &= vbTab & "Me.sqle.RequireCredentials = iSqle.RequireCredentials" & vbCrLf
        tmpStr &= vbTab & "Me.sqle.Username = iSqle.Username" & vbCrLf
        tmpStr &= vbTab & "Me.sqle.Password = iSqle.Password" & vbCrLf
        tmpStr &= vbTab & "Me.sqle.dbType = iSqle.dbType" & vbCrLf
        tmpStr &= vbTab & "Me.sqle.Path = iSqle.Path" & vbCrLf
        tmpStr &= vbTab & "Me.sqle.DatabaseName = iSqle.DatabaseName" & vbCrLf
        tmpStr &= vbTab & "If iSqle.IsStarted Then" & vbCrLf
        tmpStr &= vbTab & vbTab & "Me.sqle.ColdBoot()" & vbCrLf
        tmpStr &= vbTab & "Else" & vbCrLf
        tmpStr &= vbTab & vbTab & "Me.sqle.Start()" & vbCrLf
        tmpStr &= vbTab & "End If" & vbCrLf
        tmpStr &= "End Sub" & vbCrLf
        Return tmpStr
    End Function

    Public Function AddInjectSQLSub() As String
        Dim tmpStr As String = ""
        tmpStr &= "Public Sub InjectSQL(ByVal iSqle As SQLEngine)" & vbCrLf
        tmpStr &= vbTab & "Me.sqle.RequireCredentials = iSqle.RequireCredentials" & vbCrLf
        tmpStr &= vbTab & "Me.sqle.Username = iSqle.Username" & vbCrLf
        tmpStr &= vbTab & "Me.sqle.Password = iSqle.Password" & vbCrLf
        tmpStr &= vbTab & "Me.sqle.dbType = iSqle.dbType" & vbCrLf
        tmpStr &= vbTab & "Me.sqle.Path = iSqle.Path" & vbCrLf
        tmpStr &= vbTab & "Me.sqle.DatabaseName = iSqle.DatabaseName" & vbCrLf
        tmpStr &= vbTab & "If iSqle.IsStarted Then" & vbCrLf
        tmpStr &= vbTab & vbTab & "Me.sqle.ColdBoot()" & vbCrLf
        tmpStr &= vbTab & "Else" & vbCrLf
        tmpStr &= vbTab & vbTab & "Me.sqle.Start()" & vbCrLf
        tmpStr &= vbTab & "End If" & vbCrLf
        tmpStr &= "End Sub" & vbCrLf
        Return tmpStr
    End Function

    Public Function AddDeleteFunction() As String
        Dim tmpStr As String = ""
        tmpStr &= "Public Function Delete(Optional ByVal hard As Boolean = False) As Boolean" & vbCrLf
        tmpStr &= vbTab & "If hard Then" & vbCrLf
        tmpStr &= vbTab & vbTab & "With sqle.Delete" & vbCrLf
        tmpStr &= vbTab & vbTab & vbTab & ".Reset()" & vbCrLf
        tmpStr &= vbTab & vbTab & vbTab & ".TableName = TABLA.TABLA_NOMBRE" & vbCrLf
        tmpStr &= vbTab & vbTab & vbTab & ".SimpleSearch(TABLA.ID, SQLEngineUpdate.OperatorCriteria.Igual, id)" & vbCrLf
        tmpStr &= vbTab & vbTab & vbTab & "Return .Delete" & vbCrLf
        tmpStr &= vbTab & vbTab & "End With" & vbCrLf
        tmpStr &= vbTab & "Else" & vbCrLf
        tmpStr &= vbTab & vbTab & "With sqle.Update" & vbCrLf
        tmpStr &= vbTab & vbTab & vbTab & ".Reset()" & vbCrLf
        tmpStr &= vbTab & vbTab & vbTab & ".TableName = TABLA.TABLA_NOMBRE" & vbCrLf
        tmpStr &= vbTab & vbTab & vbTab & ".AddColumnValue(TABLA.DELETED, True)" & vbCrLf
        tmpStr &= vbTab & vbTab & vbTab & ".AddColumnValue(TABLA.MODIFICADO, Now)" & vbCrLf
        tmpStr &= vbTab & vbTab & vbTab & ".SimpleSearch(TABLA.ID, SQLEngineUpdate.OperatorCriteria.Igual, id)" & vbCrLf
        tmpStr &= vbTab & vbTab & vbTab & "Return .Update" & vbCrLf
        tmpStr &= vbTab & vbTab & "End With" & vbCrLf
        tmpStr &= vbTab & "End If" & vbCrLf
        tmpStr &= "End Function" & vbCrLf
        Return tmpStr
    End Function

    Public Function AddDeleteFunction(ByVal lstVars As List(Of String), ByVal lstVarTypes As List(Of String), ByVal lstCampos As List(Of String)) As String
        Dim tablaName As String = lstCampos(0).Substring(0, lstCampos(0).LastIndexOf("."))

        Dim result As String = vbCrLf & vbCrLf
        Dim counter As Integer = 0

        result &= "Public Function Delete(Optional ByVal dbID As Integer = 0) As Boolean" & vbCrLf
        result &= vbTab & "Dim delId As Integer = 0" & vbCrLf


        result &= vbTab & "If dbID <> 0 Then" & vbCrLf
        result &= vbTab & vbTab & "delId = dbID" & vbCrLf
        result &= vbTab & "Else" & vbCrLf
        result &= vbTab & vbTab & "delId = Me." & lstVars(0) & vbCrLf
        result &= vbTab & "End If" & vbCrLf


        result &= vbTab & "With sqle.Update" & vbCrLf
        result &= vbTab & vbTab & ".Reset()" & vbCrLf
        result &= vbTab & vbTab & ".TableName = " & tablaName & ".TABLA_NOMBRE" & vbCrLf
        result &= vbTab & vbTab & ".AddColumnValue(" & lstCampos(lstCampos.Count - 2) & ", True )" & vbCrLf
        result &= vbTab & vbTab & ".SimpleSearch(" & lstCampos(0) & ", SQLEngineQuery.OperatorCriteria.Igual, delID)" & vbCrLf
        result &= vbTab & vbTab & "Return .Update" & vbCrLf
        result &= vbTab & "End With" & vbCrLf
        result &= "End Function" & vbCrLf & vbCrLf
        Return result
    End Function
End Class
