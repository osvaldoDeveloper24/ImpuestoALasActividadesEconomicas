<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextMonto = New System.Windows.Forms.TextBox()
        Me.TextResultado = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cascadia Mono", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese el monto $"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cascadia Mono", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(609, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Impuesto a las actividades económicas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cascadia Mono", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total a pagar $"
        '
        'TextMonto
        '
        Me.TextMonto.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextMonto.Location = New System.Drawing.Point(284, 150)
        Me.TextMonto.Multiline = True
        Me.TextMonto.Name = "TextMonto"
        Me.TextMonto.Size = New System.Drawing.Size(255, 43)
        Me.TextMonto.TabIndex = 3
        Me.TextMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextResultado
        '
        Me.TextResultado.Enabled = False
        Me.TextResultado.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextResultado.Location = New System.Drawing.Point(262, 260)
        Me.TextResultado.Multiline = True
        Me.TextResultado.Name = "TextResultado"
        Me.TextResultado.Size = New System.Drawing.Size(255, 43)
        Me.TextResultado.TabIndex = 4
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCalcular.Font = New System.Drawing.Font("Cascadia Code", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(586, 260)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(177, 52)
        Me.btnCalcular.TabIndex = 5
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.TextResultado)
        Me.Controls.Add(Me.TextMonto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextMonto As TextBox
    Friend WithEvents TextResultado As TextBox
    Friend WithEvents btnCalcular As Button
End Class
