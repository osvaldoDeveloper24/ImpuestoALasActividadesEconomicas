Public Class ImpuestoActividadEconomica

    Public Shared instance As ImpuestoActividadEconomica
    Private Sub New()
    End Sub

    Public Shared Function obtenerIntancia() As ImpuestoActividadEconomica
        If (instance Is Nothing) Then
            instance = New ImpuestoActividadEconomica()
        End If
        Return instance
    End Function
    Public Function calcularImpuesto(monto As Double) As Double
        Dim rangos As Double() = {0.01, 500.01, 1000.01, 2000.01, 3000.01, 8000.01, 18000.01, 30000.01, 60000.01, 100000.01, 200000.01, 300000.01, 400000.01, 500000.01, 1000000.01}
        Dim precios As Double() = {1.5, 1.5, 3, 6, 9, 15, 39, 63, 93, 125, 195, 255, 300, 340, 490}
        Dim adicional As Double() = {0, 3, 3, 3, 2, 2, 2, 1, 0.8, 0.7, 0.6, 0.45, 0.4, 0.3, 0.18}
        Dim respuesta As Double

        For i As Integer = rangos.Length - 1 To 0 Step -1
            If monto >= rangos(i) Then
                respuesta = ((monto - rangos(i)) / 1000) * adicional(i) + precios(i)
                Exit For
            End If
        Next

        Return Math.Round(respuesta, 2)
    End Function

End Class
