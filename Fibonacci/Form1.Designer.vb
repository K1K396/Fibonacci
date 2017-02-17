<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtParametro = New System.Windows.Forms.TextBox()
        Me.btnFibonacci = New System.Windows.Forms.Button()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Serie de Fibonacci"
        '
        'txtParametro
        '
        Me.txtParametro.Location = New System.Drawing.Point(16, 36)
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(230, 20)
        Me.txtParametro.TabIndex = 1
        '
        'btnFibonacci
        '
        Me.btnFibonacci.Location = New System.Drawing.Point(92, 62)
        Me.btnFibonacci.Name = "btnFibonacci"
        Me.btnFibonacci.Size = New System.Drawing.Size(75, 23)
        Me.btnFibonacci.TabIndex = 2
        Me.btnFibonacci.Text = "Fibonacci"
        Me.btnFibonacci.UseVisualStyleBackColor = True
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Location = New System.Drawing.Point(16, 92)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(230, 20)
        Me.txtRespuesta.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 132)
        Me.Controls.Add(Me.txtRespuesta)
        Me.Controls.Add(Me.btnFibonacci)
        Me.Controls.Add(Me.txtParametro)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Serie de Fibonacci"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtParametro As TextBox
    Friend WithEvents btnFibonacci As Button
    Friend WithEvents txtRespuesta As TextBox
End Class
