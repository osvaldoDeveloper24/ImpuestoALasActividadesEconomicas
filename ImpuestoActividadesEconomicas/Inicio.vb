Imports System.Threading
Public Class Inicio
    Dim impuesto As ImpuestoActividadEconomica = ImpuestoActividadEconomica.obtenerIntancia()
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Try
            Dim monto As Double = Double.Parse(TextMonto.Text)
            If (monto < 0) Then
                MessageBox.Show("Ingrese una cantidad positiva.", "INGRESAR DATO POSITIVO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (String.IsNullOrWhiteSpace(monto)) Then
                MessageBox.Show("Debe ingresar un valor.", "CAMPO VACÍO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            TextResultado.Text = impuesto.calcularImpuesto(monto)
        Catch ex As Exception
            MessageBox.Show("No se puede hacer el cálculo", "FALTA INTRODUCIR DATO POSITIVO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
