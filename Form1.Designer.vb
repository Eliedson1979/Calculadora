<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnMais = New System.Windows.Forms.Button()
        Me.btnMenos = New System.Windows.Forms.Button()
        Me.btnVezes = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtValor1
        '
        Me.txtValor1.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor1.Location = New System.Drawing.Point(138, 15)
        Me.txtValor1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtValor1.Multiline = True
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(302, 47)
        Me.txtValor1.TabIndex = 0
        '
        'txtValor2
        '
        Me.txtValor2.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor2.Location = New System.Drawing.Point(138, 70)
        Me.txtValor2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtValor2.Multiline = True
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(302, 47)
        Me.txtValor2.TabIndex = 1
        '
        'txtResultado
        '
        Me.txtResultado.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.Location = New System.Drawing.Point(138, 204)
        Me.txtResultado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtResultado.Multiline = True
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(302, 47)
        Me.txtResultado.TabIndex = 2
        '
        'btnMais
        '
        Me.btnMais.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMais.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMais.Location = New System.Drawing.Point(16, 126)
        Me.btnMais.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMais.Name = "btnMais"
        Me.btnMais.Size = New System.Drawing.Size(100, 70)
        Me.btnMais.TabIndex = 3
        Me.btnMais.Text = "+"
        Me.btnMais.UseVisualStyleBackColor = False
        '
        'btnMenos
        '
        Me.btnMenos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMenos.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenos.Location = New System.Drawing.Point(124, 126)
        Me.btnMenos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(100, 70)
        Me.btnMenos.TabIndex = 4
        Me.btnMenos.Text = "-"
        Me.btnMenos.UseVisualStyleBackColor = False
        '
        'btnVezes
        '
        Me.btnVezes.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnVezes.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVezes.Location = New System.Drawing.Point(232, 126)
        Me.btnVezes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVezes.Name = "btnVezes"
        Me.btnVezes.Size = New System.Drawing.Size(100, 70)
        Me.btnVezes.TabIndex = 5
        Me.btnVezes.Text = "X"
        Me.btnVezes.UseVisualStyleBackColor = False
        '
        'btnDividir
        '
        Me.btnDividir.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnDividir.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDividir.Location = New System.Drawing.Point(340, 126)
        Me.btnDividir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(100, 70)
        Me.btnDividir.TabIndex = 6
        Me.btnDividir.Text = "/"
        Me.btnDividir.UseVisualStyleBackColor = False
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.Red
        Me.btnLimpar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.Location = New System.Drawing.Point(292, 259)
        Me.btnLimpar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(148, 28)
        Me.btnLimpar.TabIndex = 7
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Digite o Numero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Digite o Numero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Resultado Geral"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(457, 309)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnDividir)
        Me.Controls.Add(Me.btnVezes)
        Me.Controls.Add(Me.btnMenos)
        Me.Controls.Add(Me.btnMais)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora V5.1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnMais As Button
    Friend WithEvents btnMenos As Button
    Friend WithEvents btnVezes As Button
    Friend WithEvents btnDividir As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
