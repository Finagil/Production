Module mTasaAplicable

    Public Sub TasaAplicable(ByVal cTipar As String, ByVal cTipta As String, ByVal nPlazo As Integer, ByVal nIvaEq As Decimal, ByVal lRD As Boolean, ByVal nRD As Byte, ByVal lDG As Boolean, ByVal nDG As Byte, ByVal dsAgil As DataSet, ByRef nTasas As Decimal, ByRef nDifer As Decimal, ByRef nPorOp As Decimal)

        ' Esta función determina la tasa aplicable a un contrato (si es tasa fija),
        ' el diferencial (si es un contrato con tasa variable) y 
        ' el porcentaje de valor residual (si se trata de un arrendamiento puro)

        ' Declaración de variables de conexión ADO .NET

        Dim drTasasAplicables As DataRowCollection
        Dim drTasaAplicable As DataRow

        If cTipta <> "7" Then

            ' Se trata de un crédito a Tasa Variable

            If cTipar = "F" Then

                ' Arrendamiento Financiero

                If nIvaEq = 0 Then
                    drTasasAplicables = dsAgil.Tables("TVAFsinIVA").Rows
                    For Each drTasaAplicable In drTasasAplicables
                        If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                            nDifer = drTasaAplicable("Diferencial Aplicable")
                            If lRD = True Then
                                If nRD = 1 Then
                                    nDifer = drTasaAplicable("1 RD")
                                ElseIf nRD = 2 Then
                                    nDifer = drTasaAplicable("2 RD")
                                ElseIf nRD = 3 Then
                                    nDifer = drTasaAplicable("3 RD")
                                End If
                            End If
                            If lDG = True Then
                                nTasas = drTasaAplicable("Depósito")
                                If nDG = 1 Then
                                    nTasas = drTasaAplicable("5% DG")
                                ElseIf nDG = 2 Then
                                    nTasas = drTasaAplicable("10% DG")
                                ElseIf nDG = 3 Then
                                    nTasas = drTasaAplicable("15% DG")
                                End If
                            End If
                        End If
                    Next
                Else
                    drTasasAplicables = dsAgil.Tables("TVAFconIVA").Rows
                    For Each drTasaAplicable In drTasasAplicables
                        If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                            nDifer = drTasaAplicable("Diferencial Aplicable")
                            If lRD = True Then
                                If lDG = True Then
                                    If nRD = 1 Then
                                        nDifer = drTasaAplicable("1 RD y DG")
                                    ElseIf nRD = 2 Then
                                        nDifer = drTasaAplicable("2 RD y DG")
                                    ElseIf nRD = 3 Then
                                        nDifer = drTasaAplicable("3 RD y DG")
                                    End If
                                Else
                                    If nRD = 1 Then
                                        nDifer = drTasaAplicable("1 RD")
                                    ElseIf nRD = 2 Then
                                        nDifer = drTasaAplicable("2 RD")
                                    ElseIf nRD = 3 Then
                                        nDifer = drTasaAplicable("3 RD")
                                    End If
                                End If
                            Else
                                If lDG = True Then
                                    nTasas = drTasaAplicable("Depósito")
                                    If nDG = 1 Then
                                        nTasas = drTasaAplicable("5% DG")
                                    ElseIf nDG = 2 Then
                                        nTasas = drTasaAplicable("10% DG")
                                    ElseIf nDG = 3 Then
                                        nTasas = drTasaAplicable("15% DG")
                                    End If
                                End If
                            End If
                        End If
                    Next
                End If

            ElseIf cTipar = "P" Then

                ' Arrendamiento Puro

                drTasasAplicables = dsAgil.Tables("TVAP").Rows

                For Each drTasaAplicable In drTasasAplicables
                    If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                        nDifer = drTasaAplicable("Diferencial Aplicable")
                        nPorOp = drTasaAplicable("VR")
                        If lRD = True Then
                            If nRD = 1 Then
                                nPorOp = drTasaAplicable("VR 1RD")
                            ElseIf nRD = 2 Then
                                nPorOp = drTasaAplicable("VR 2RD")
                            ElseIf nRD = 3 Then
                                nPorOp = drTasaAplicable("VR 3RD")
                            End If
                        End If
                        If lDG = True Then
                            nTasas = drTasaAplicable("Depósito")
                            If nDG = 1 Then
                                nTasas = drTasaAplicable("5% DG")
                            ElseIf nDG = 2 Then
                                nTasas = drTasaAplicable("10% DG")
                            ElseIf nDG = 3 Then
                                nTasas = drTasaAplicable("15% DG")
                            End If
                        End If
                    End If
                Next

            ElseIf cTipar = "R" Then

                ' Crédito Refaccionario

                drTasasAplicables = dsAgil.Tables("TVCR").Rows
                For Each drTasaAplicable In drTasasAplicables
                    If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                        nDifer = drTasaAplicable("Diferencial Aplicable")
                        If lDG = True Then
                            If nDG = 1 Then
                                nDifer = drTasaAplicable("5% DG")
                            ElseIf nDG = 2 Then
                                nDifer = drTasaAplicable("10% DG")
                            ElseIf nDG = 3 Then
                                nDifer = drTasaAplicable("15% DG")
                            End If
                        End If
                    End If
                Next

            ElseIf cTipar = "S" Then

                ' Crédito Simple

                drTasasAplicables = dsAgil.Tables("TVCS").Rows
                For Each drTasaAplicable In drTasasAplicables
                    If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                        nDifer = drTasaAplicable("Diferencial Aplicable")
                        If lDG = True Then
                            If nDG = 1 Then
                                nDifer = drTasaAplicable("5% DG")
                            ElseIf nDG = 2 Then
                                nDifer = drTasaAplicable("10% DG")
                            ElseIf nDG = 3 Then
                                nDifer = drTasaAplicable("15% DG")
                            End If
                        End If
                    End If
                Next

            End If

        End If

        If cTipta = "7" Then

            ' Se trata de un crédito a Tasa Fija

            If cTipar = "F" Then

                ' Arrendamiento Financiero

                If nIvaEq = 0 Then
                    drTasasAplicables = dsAgil.Tables("AFsinIVA").Rows
                    For Each drTasaAplicable In drTasasAplicables
                        If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                            nTasas = drTasaAplicable("Tasa Aplicable")
                            If lRD = True Then
                                If nRD = 1 Then
                                    nTasas = drTasaAplicable("1 RD")
                                ElseIf nRD = 2 Then
                                    nTasas = drTasaAplicable("2 RD")
                                ElseIf nRD = 3 Then
                                    nTasas = drTasaAplicable("3 RD")
                                End If
                            End If
                            If lDG = True Then
                                nTasas = drTasaAplicable("Depósito")
                                If nDG = 1 Then
                                    nTasas = drTasaAplicable("5% DG")
                                ElseIf nDG = 2 Then
                                    nTasas = drTasaAplicable("10% DG")
                                ElseIf nDG = 3 Then
                                    nTasas = drTasaAplicable("15% DG")
                                End If
                            End If
                        End If
                    Next
                Else
                    drTasasAplicables = dsAgil.Tables("AFconIVA").Rows
                    For Each drTasaAplicable In drTasasAplicables
                        If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                            nTasas = drTasaAplicable("Tasa Aplicable")
                            If lRD = True Then
                                If lDG = True Then
                                    If nRD = 1 Then
                                        nTasas = drTasaAplicable("1 RD y DG")
                                    ElseIf nRD = 2 Then
                                        nTasas = drTasaAplicable("2 RD y DG")
                                    ElseIf nRD = 3 Then
                                        nTasas = drTasaAplicable("3 RD y DG")
                                    End If
                                Else
                                    If nRD = 1 Then
                                        nTasas = drTasaAplicable("1 RD")
                                    ElseIf nRD = 2 Then
                                        nTasas = drTasaAplicable("2 RD")
                                    ElseIf nRD = 3 Then
                                        nTasas = drTasaAplicable("3 RD")
                                    End If
                                End If
                            Else
                                If lDG = True Then
                                    nTasas = drTasaAplicable("Depósito")
                                    If nDG = 1 Then
                                        nTasas = drTasaAplicable("5% DG")
                                    ElseIf nDG = 2 Then
                                        nTasas = drTasaAplicable("10% DG")
                                    ElseIf nDG = 3 Then
                                        nTasas = drTasaAplicable("15% DG")
                                    End If
                                End If
                            End If
                        End If
                    Next
                End If

            End If

            If cTipar = "P" Then

                ' Arrendamiento Puro

                drTasasAplicables = dsAgil.Tables("AP").Rows
                For Each drTasaAplicable In drTasasAplicables
                    If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                        nTasas = drTasaAplicable("Tasa Aplicable")
                        nPorOp = drTasaAplicable("VR")
                        If lRD = True Then
                            If nRD = 1 Then
                                nPorOp = drTasaAplicable("VR 1RD")
                            ElseIf nRD = 2 Then
                                nPorOp = drTasaAplicable("VR 2RD")
                            ElseIf nRD = 3 Then
                                nPorOp = drTasaAplicable("VR 3RD")
                            End If
                        End If
                        If lDG = True Then
                            If nDG = 1 Then
                                nPorOp = drTasaAplicable("VR 1RD")
                            ElseIf nDG = 2 Then
                                nPorOp = drTasaAplicable("VR 2RD")
                            ElseIf nDG = 3 Then
                                nPorOp = drTasaAplicable("VR 3RD")
                            End If
                        End If
                    End If
                Next

            End If

            If cTipar = "R" Then

                ' Crédito Refaccionario

                drTasasAplicables = dsAgil.Tables("CR").Rows
                For Each drTasaAplicable In drTasasAplicables
                    If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                        nTasas = drTasaAplicable("Tasa Aplicable")
                        If lDG = True Then
                            If nDG = 1 Then
                                nTasas = drTasaAplicable("5% DG")
                            ElseIf nDG = 2 Then
                                nTasas = drTasaAplicable("10% DG")
                            ElseIf nDG = 3 Then
                                nTasas = drTasaAplicable("15% DG")
                            End If
                        End If
                    End If
                Next

            End If

            If cTipar = "S" Then

                ' Crédito Simple

                drTasasAplicables = dsAgil.Tables("CS").Rows
                For Each drTasaAplicable In drTasasAplicables
                    If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                        nTasas = drTasaAplicable("Tasa Aplicable")
                        If lDG = True Then
                            If nDG = 1 Then
                                nTasas = drTasaAplicable("5% DG")
                            ElseIf nDG = 2 Then
                                nTasas = drTasaAplicable("10% DG")
                            ElseIf nDG = 3 Then
                                nTasas = drTasaAplicable("15% DG")
                            End If
                        End If
                    End If
                Next

            End If

        End If

    End Sub

    Public Sub TasaAplicablePASIVA(ByVal cTipar As String, ByVal cTipta As String, ByVal nPlazo As Integer, ByVal nIvaEq As Decimal, ByVal lRD As Boolean, ByVal nRD As Byte, ByVal lDG As Boolean, ByVal nDG As Byte, ByVal dsAgil As DataSet, ByRef nTasasP As Decimal, ByRef nDiferP As Decimal, ByRef nPorOp As Decimal)

        ' Esta función determina la tasa aplicable a un contrato (si es tasa fija),
        ' el diferencial (si es un contrato con tasa variable) y 
        ' el porcentaje de valor residual (si se trata de un arrendamiento puro)

        ' Declaración de variables de conexión ADO .NET

        Dim drTasasAplicables As DataRowCollection
        Dim drTasaAplicable As DataRow

        If cTipta <> "7" Then

            ' Se trata de un crédito a Tasa Variable

            If cTipar = "F" Then

                ' Arrendamiento Financiero

                If nIvaEq = 0 Then
                    drTasasAplicables = dsAgil.Tables("TVAFsinIVA").Rows
                    For Each drTasaAplicable In drTasasAplicables
                        If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                            nDiferP = drTasaAplicable("Diferencial Aplicable")
                            If lRD = True Then
                                If nRD = 1 Then
                                    nDiferP = drTasaAplicable("1 RD")
                                ElseIf nRD = 2 Then
                                    nDiferP = drTasaAplicable("2 RD")
                                ElseIf nRD = 3 Then
                                    nDiferP = drTasaAplicable("3 RD")
                                End If
                            End If
                            If lDG = True Then
                                nTasasP = drTasaAplicable("Depósito")
                                If nDG = 1 Then
                                    nTasasP = drTasaAplicable("5% DG")
                                ElseIf nDG = 2 Then
                                    nTasasP = drTasaAplicable("10% DG")
                                ElseIf nDG = 3 Then
                                    nTasasP = drTasaAplicable("15% DG")
                                End If
                            End If
                        End If
                    Next
                Else
                    drTasasAplicables = dsAgil.Tables("TVAFconIVA").Rows
                    For Each drTasaAplicable In drTasasAplicables
                        If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                            nDiferP = drTasaAplicable("Diferencial Aplicable")
                            If lRD = True Then
                                If lDG = True Then
                                    If nRD = 1 Then
                                        nDiferP = drTasaAplicable("1 RD y DG")
                                    ElseIf nRD = 2 Then
                                        nDiferP = drTasaAplicable("2 RD y DG")
                                    ElseIf nRD = 3 Then
                                        nDiferP = drTasaAplicable("3 RD y DG")
                                    End If
                                Else
                                    If nRD = 1 Then
                                        nDiferP = drTasaAplicable("1 RD")
                                    ElseIf nRD = 2 Then
                                        nDiferP = drTasaAplicable("2 RD")
                                    ElseIf nRD = 3 Then
                                        nDiferP = drTasaAplicable("3 RD")
                                    End If
                                End If
                            Else
                                If lDG = True Then
                                    nTasasP = drTasaAplicable("Depósito")
                                    If nDG = 1 Then
                                        nTasasP = drTasaAplicable("5% DG")
                                    ElseIf nDG = 2 Then
                                        nTasasP = drTasaAplicable("10% DG")
                                    ElseIf nDG = 3 Then
                                        nTasasP = drTasaAplicable("15% DG")
                                    End If
                                End If
                            End If
                        End If
                    Next
                End If

            ElseIf cTipar = "P" Then

                ' Arrendamiento Puro

                drTasasAplicables = dsAgil.Tables("TVAP").Rows

                For Each drTasaAplicable In drTasasAplicables
                    If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                        nDiferP = drTasaAplicable("Diferencial Aplicable")
                        nPorOp = drTasaAplicable("VR")
                        If lRD = True Then
                            If nRD = 1 Then
                                nPorOp = drTasaAplicable("VR 1RD")
                            ElseIf nRD = 2 Then
                                nPorOp = drTasaAplicable("VR 2RD")
                            ElseIf nRD = 3 Then
                                nPorOp = drTasaAplicable("VR 3RD")
                            End If
                        End If
                        If lDG = True Then
                            nTasasP = drTasaAplicable("Depósito")
                            If nDG = 1 Then
                                nTasasP = drTasaAplicable("5% DG")
                            ElseIf nDG = 2 Then
                                nTasasP = drTasaAplicable("10% DG")
                            ElseIf nDG = 3 Then
                                nTasasP = drTasaAplicable("15% DG")
                            End If
                        End If
                    End If
                Next

            ElseIf cTipar = "R" Then

                ' Crédito Refaccionario

                drTasasAplicables = dsAgil.Tables("TVCR").Rows
                For Each drTasaAplicable In drTasasAplicables
                    If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                        nDiferP = drTasaAplicable("Diferencial Aplicable")
                        If lDG = True Then
                            If nDG = 1 Then
                                nDiferP = drTasaAplicable("5% DG")
                            ElseIf nDG = 2 Then
                                nDiferP = drTasaAplicable("10% DG")
                            ElseIf nDG = 3 Then
                                nDiferP = drTasaAplicable("15% DG")
                            End If
                        End If
                    End If
                Next

            ElseIf cTipar = "S" Then

                ' Crédito Simple

                drTasasAplicables = dsAgil.Tables("TVCS").Rows
                For Each drTasaAplicable In drTasasAplicables
                    If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                        nDiferP = drTasaAplicable("Diferencial Aplicable")
                        If lDG = True Then
                            If nDG = 1 Then
                                nDiferP = drTasaAplicable("5% DG")
                            ElseIf nDG = 2 Then
                                nDiferP = drTasaAplicable("10% DG")
                            ElseIf nDG = 3 Then
                                nDiferP = drTasaAplicable("15% DG")
                            End If
                        End If
                    End If
                Next

            End If

        End If

        If cTipta = "7" Then

            ' Se trata de un crédito a Tasa Fija

            If cTipar = "F" Then

                ' Arrendamiento Financiero

                If nIvaEq = 0 Then
                    drTasasAplicables = dsAgil.Tables("AFsinIVA").Rows
                    For Each drTasaAplicable In drTasasAplicables
                        If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                            nTasasP = drTasaAplicable("Tasa Aplicable")
                            If lRD = True Then
                                If nRD = 1 Then
                                    nTasasP = drTasaAplicable("1 RD")
                                ElseIf nRD = 2 Then
                                    nTasasP = drTasaAplicable("2 RD")
                                ElseIf nRD = 3 Then
                                    nTasasP = drTasaAplicable("3 RD")
                                End If
                            End If
                            If lDG = True Then
                                nTasasP = drTasaAplicable("Depósito")
                                If nDG = 1 Then
                                    nTasasP = drTasaAplicable("5% DG")
                                ElseIf nDG = 2 Then
                                    nTasasP = drTasaAplicable("10% DG")
                                ElseIf nDG = 3 Then
                                    nTasasP = drTasaAplicable("15% DG")
                                End If
                            End If
                        End If
                    Next
                Else
                    drTasasAplicables = dsAgil.Tables("AFconIVA").Rows
                    For Each drTasaAplicable In drTasasAplicables
                        If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                            nTasasP = drTasaAplicable("Tasa Aplicable")
                            If lRD = True Then
                                If lDG = True Then
                                    If nRD = 1 Then
                                        nTasasP = drTasaAplicable("1 RD y DG")
                                    ElseIf nRD = 2 Then
                                        nTasasP = drTasaAplicable("2 RD y DG")
                                    ElseIf nRD = 3 Then
                                        nTasasP = drTasaAplicable("3 RD y DG")
                                    End If
                                Else
                                    If nRD = 1 Then
                                        nTasasP = drTasaAplicable("1 RD")
                                    ElseIf nRD = 2 Then
                                        nTasasP = drTasaAplicable("2 RD")
                                    ElseIf nRD = 3 Then
                                        nTasasP = drTasaAplicable("3 RD")
                                    End If
                                End If
                            Else
                                If lDG = True Then
                                    nTasasP = drTasaAplicable("Depósito")
                                    If nDG = 1 Then
                                        nTasasP = drTasaAplicable("5% DG")
                                    ElseIf nDG = 2 Then
                                        nTasasP = drTasaAplicable("10% DG")
                                    ElseIf nDG = 3 Then
                                        nTasasP = drTasaAplicable("15% DG")
                                    End If
                                End If
                            End If
                        End If
                    Next
                End If

            End If

            If cTipar = "P" Then

                ' Arrendamiento Puro

                drTasasAplicables = dsAgil.Tables("AP").Rows
                For Each drTasaAplicable In drTasasAplicables
                    If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                        nTasasP = drTasaAplicable("Tasa Aplicable")
                        nPorOp = drTasaAplicable("VR")
                        If lRD = True Then
                            If nRD = 1 Then
                                nPorOp = drTasaAplicable("VR 1RD")
                            ElseIf nRD = 2 Then
                                nPorOp = drTasaAplicable("VR 2RD")
                            ElseIf nRD = 3 Then
                                nPorOp = drTasaAplicable("VR 3RD")
                            End If
                        End If
                        If lDG = True Then
                            If nDG = 1 Then
                                nPorOp = drTasaAplicable("VR 1RD")
                            ElseIf nDG = 2 Then
                                nPorOp = drTasaAplicable("VR 2RD")
                            ElseIf nDG = 3 Then
                                nPorOp = drTasaAplicable("VR 3RD")
                            End If
                        End If
                    End If
                Next

            End If

            If cTipar = "R" Then

                ' Crédito Refaccionario

                drTasasAplicables = dsAgil.Tables("CR").Rows
                For Each drTasaAplicable In drTasasAplicables
                    If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                        nTasasP = drTasaAplicable("Tasa Aplicable")
                        If lDG = True Then
                            If nDG = 1 Then
                                nTasasP = drTasaAplicable("5% DG")
                            ElseIf nDG = 2 Then
                                nTasasP = drTasaAplicable("10% DG")
                            ElseIf nDG = 3 Then
                                nTasasP = drTasaAplicable("15% DG")
                            End If
                        End If
                    End If
                Next

            End If

            If cTipar = "S" Then

                ' Crédito Simple

                drTasasAplicables = dsAgil.Tables("CS").Rows
                For Each drTasaAplicable In drTasasAplicables
                    If nPlazo >= drTasaAplicable("Límite Inferior") And nPlazo <= drTasaAplicable("Límite Superior") Then
                        nTasasP = drTasaAplicable("Tasa Aplicable")
                        If lDG = True Then
                            If nDG = 1 Then
                                nTasasP = drTasaAplicable("5% DG")
                            ElseIf nDG = 2 Then
                                nTasasP = drTasaAplicable("10% DG")
                            ElseIf nDG = 3 Then
                                nTasasP = drTasaAplicable("15% DG")
                            End If
                        End If
                    End If
                Next

            End If

        End If

    End Sub

    Public Function CalculaTIR_PASIVA(Anexo As String) As Decimal
        Dim TIR As Decimal
        Try
            Dim Periodo As Integer
            Dim nDiasFact As Integer
            Dim X As Integer
            Dim F1 As Date
            Dim F2 As Date
            Dim Datos(1) As Double
            Dim ds As New RiesgosDS
            Dim ta As New RiesgosDSTableAdapters.AnexosTIRTableAdapter
            Dim tav As New RiesgosDSTableAdapters.EdoctavTIRTableAdapter
            ta.Fill(ds.AnexosTIR, Anexo)
            tav.Fill(ds.EdoctavTIR, Anexo)
            Dim rr As RiesgosDS.AnexosTIRRow = ds.AnexosTIR.Rows(0)
            If ds.EdoctavTIR.Rows.Count > 0 Then
                ReDim Datos(ds.EdoctavTIR.Rows.Count)
                Datos(0) = (rr.MontoFinanciado - rr.Comis) * -1
                F1 = CTOD(rr.Fechacon)
                For Each r As RiesgosDS.EdoctavTIRRow In ds.EdoctavTIR.Rows
                    X += 1
                    F2 = CTOD(r.Feven)
                    nDiasFact = DateDiff(DateInterval.Day, F1, F2)
                    Datos(X) = r.Abcap + Math.Round(r.Saldo * rr.TasasPasivo / 36000 * nDiasFact, 2) '+ r.comFega
                    F1 = F2
                Next
            End If
            If rr.IsVencimientoNull Then
                Select Case rr.DiasPrimerVecn
                    Case >= 360
                        Periodo = 1
                    Case >= 180
                        Periodo = 2
                    Case >= 120
                        Periodo = 3
                    Case >= 90
                        Periodo = 4
                    Case >= 60
                        Periodo = 6
                    Case >= 16
                        Periodo = 12
                    Case = 15
                        Periodo = 24
                    Case = 14
                        Periodo = 26
                    Case < 14
                        Periodo = 52
                End Select
            Else
                Select Case rr.Vencimiento.ToUpper
                    Case "ANUAL"
                        Periodo = 1
                    Case "SEMESTRAL"
                        Periodo = 2
                    Case "CUATRIMIESTRAL"
                        Periodo = 3
                    Case "TRIMESTRAL"
                        Periodo = 4
                    Case "BIMESTRAL"
                        Periodo = 6
                    Case "MENSUAL"
                        Periodo = 12
                    Case "QUINCENAL"
                        Periodo = 24
                    Case "CATORCENAL"
                        Periodo = 26
                    Case "SEMANAL"
                        Periodo = 52
                End Select
            End If
            TIR = ((1 + (IRR(Datos, 0))) ^ Periodo) - 1
            ta.UpdateTIRpasiva(TIR, Anexo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Math.Round(TIR * 100, 4)
    End Function

    Public Function CalculaTIR_ACTIVA(Anexo As String) As Decimal
        Dim TIR As Decimal
        Try
            Dim Periodo As Integer = 0
            Dim X As Integer = 0

            Dim Datos(1) As Double
            Dim ds As New RiesgosDS
            Dim ta As New RiesgosDSTableAdapters.AnexosTIRTableAdapter
            Dim tav As New RiesgosDSTableAdapters.EdoctavTIRTableAdapter
            ta.Fill(ds.AnexosTIR, Anexo)
            tav.Fill(ds.EdoctavTIR, Anexo)
            Dim rr As RiesgosDS.AnexosTIRRow = ds.AnexosTIR.Rows(0)
            If ds.EdoctavTIR.Rows.Count > 0 Then
                ReDim Datos(ds.EdoctavTIR.Rows.Count)
                Datos(0) = (rr.MontoFinanciado - rr.Comis) * -1
                For Each r As RiesgosDS.EdoctavTIRRow In ds.EdoctavTIR.Rows
                    X += 1
                    Datos(X) = r.Abcap + r.Inter '+ r.comFega
                Next
            End If
            If rr.IsVencimientoNull Then
                Select Case rr.DiasPrimerVecn
                    Case >= 360
                        Periodo = 1
                    Case >= 180
                        Periodo = 2
                    Case >= 120
                        Periodo = 3
                    Case >= 90
                        Periodo = 4
                    Case >= 60
                        Periodo = 6
                    Case >= 16
                        Periodo = 12
                    Case = 15
                        Periodo = 24
                    Case = 14
                        Periodo = 26
                    Case < 14
                        Periodo = 52
                End Select
            Else
                Select Case rr.Vencimiento.ToUpper
                    Case "ANUAL"
                        Periodo = 1
                    Case "SEMESTRAL"
                        Periodo = 2
                    Case "CUATRIMIESTRAL"
                        Periodo = 3
                    Case "TRIMESTRAL"
                        Periodo = 4
                    Case "BIMESTRAL"
                        Periodo = 6
                    Case "MENSUAL"
                        Periodo = 12
                    Case "QUINCENAL"
                        Periodo = 24
                    Case "CATORCENAL"
                        Periodo = 26
                    Case "SEMANAL"
                        Periodo = 52
                End Select
            End If
            TIR = ((1 + (IRR(Datos, 0))) ^ Periodo) - 1
            ta.UpdateTIRactiva(TIR, Anexo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Math.Round(TIR * 100, 4)
    End Function

End Module
