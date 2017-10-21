Module Module1

    Sub Merge(ByVal arr() As Integer, ByVal aux() As Integer, ByVal low As Integer, ByVal mid As Integer, ByVal high As Integer)
        Dim i As Integer = low
        Dim j As Integer = mid + 1
        Dim k As Integer = low

        While i <= mid And j <= high
            If arr(i) < arr(j) Then
                aux(k) = arr(i)
                k += 1
                i += 1
            Else
                aux(k) = arr(j)
                k += 1
                j += 1
            End If
        End While

        While i <= mid
            aux(k) = arr(i)
            k += 1
            i += 1
        End While

        For t = low To high
            arr(t) = aux(t)
        Next


    End Sub


    Sub mergesort(ByVal arr() As Integer, ByVal aux() As Integer, ByVal low As Integer, ByVal high As Integer)
        If low = high Then
            Return
        End If

        Dim mid As Integer = (low + high) \ 2

        mergesort(arr, aux, low, mid)
        mergesort(arr, aux, mid + 1, high)

        Merge(arr, aux, low, mid, high)

    End Sub

    Sub printArray(ByVal arr() As Integer)

        For i = 0 To UBound(arr)
            Console.Write(arr(i) & " ")
        Next

        Console.WriteLine("")

    End Sub

    Sub Main()

        'Need to use inplace Merge method instead of using aux array

        Dim arr() As Integer = {20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1}
        Dim aux() As Integer = {20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1}

        printArray(arr)

        mergesort(arr, aux, 0, UBound(arr))

        printArray(arr)

    End Sub

End Module
