<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculadora))
        Me.b1 = New System.Windows.Forms.Button()
        Me.b2 = New System.Windows.Forms.Button()
        Me.b3 = New System.Windows.Forms.Button()
        Me.b4 = New System.Windows.Forms.Button()
        Me.b5 = New System.Windows.Forms.Button()
        Me.b6 = New System.Windows.Forms.Button()
        Me.b7 = New System.Windows.Forms.Button()
        Me.b8 = New System.Windows.Forms.Button()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.b9 = New System.Windows.Forms.Button()
        Me.b0 = New System.Windows.Forms.Button()
        Me.bpunto = New System.Windows.Forms.Button()
        Me.bigual = New System.Windows.Forms.Button()
        Me.bdividir = New System.Windows.Forms.Button()
        Me.bmultiplicar = New System.Windows.Forms.Button()
        Me.brestar = New System.Windows.Forms.Button()
        Me.bsumar = New System.Windows.Forms.Button()
        Me.bborrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(3, 198)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(54, 55)
        Me.b1.TabIndex = 0
        Me.b1.Text = "1"
        Me.b1.UseVisualStyleBackColor = True
        '
        'b2
        '
        Me.b2.Location = New System.Drawing.Point(63, 198)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(54, 55)
        Me.b2.TabIndex = 1
        Me.b2.Text = "2"
        Me.b2.UseVisualStyleBackColor = True
        '
        'b3
        '
        Me.b3.Location = New System.Drawing.Point(123, 198)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(54, 55)
        Me.b3.TabIndex = 2
        Me.b3.Text = "3"
        Me.b3.UseVisualStyleBackColor = True
        '
        'b4
        '
        Me.b4.Location = New System.Drawing.Point(3, 137)
        Me.b4.Name = "b4"
        Me.b4.Size = New System.Drawing.Size(54, 55)
        Me.b4.TabIndex = 3
        Me.b4.Text = "4"
        Me.b4.UseVisualStyleBackColor = True
        '
        'b5
        '
        Me.b5.Location = New System.Drawing.Point(63, 137)
        Me.b5.Name = "b5"
        Me.b5.Size = New System.Drawing.Size(54, 55)
        Me.b5.TabIndex = 4
        Me.b5.Text = "5"
        Me.b5.UseVisualStyleBackColor = True
        '
        'b6
        '
        Me.b6.Location = New System.Drawing.Point(123, 137)
        Me.b6.Name = "b6"
        Me.b6.Size = New System.Drawing.Size(54, 55)
        Me.b6.TabIndex = 5
        Me.b6.Text = "6"
        Me.b6.UseVisualStyleBackColor = True
        '
        'b7
        '
        Me.b7.Location = New System.Drawing.Point(3, 76)
        Me.b7.Name = "b7"
        Me.b7.Size = New System.Drawing.Size(54, 55)
        Me.b7.TabIndex = 6
        Me.b7.Text = "7"
        Me.b7.UseVisualStyleBackColor = True
        '
        'b8
        '
        Me.b8.Location = New System.Drawing.Point(63, 76)
        Me.b8.Name = "b8"
        Me.b8.Size = New System.Drawing.Size(54, 55)
        Me.b8.TabIndex = 7
        Me.b8.Text = "8"
        Me.b8.UseVisualStyleBackColor = True
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(3, 12)
        Me.TxtResultado.MaximumSize = New System.Drawing.Size(500, 500)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.Size = New System.Drawing.Size(174, 20)
        Me.TxtResultado.TabIndex = 80
        '
        'b9
        '
        Me.b9.Location = New System.Drawing.Point(123, 76)
        Me.b9.Name = "b9"
        Me.b9.Size = New System.Drawing.Size(54, 55)
        Me.b9.TabIndex = 9
        Me.b9.Text = "9"
        Me.b9.UseVisualStyleBackColor = True
        '
        'b0
        '
        Me.b0.Location = New System.Drawing.Point(63, 259)
        Me.b0.Name = "b0"
        Me.b0.Size = New System.Drawing.Size(54, 55)
        Me.b0.TabIndex = 10
        Me.b0.Text = "0"
        Me.b0.UseVisualStyleBackColor = True
        '
        'bpunto
        '
        Me.bpunto.Location = New System.Drawing.Point(3, 259)
        Me.bpunto.Name = "bpunto"
        Me.bpunto.Size = New System.Drawing.Size(54, 55)
        Me.bpunto.TabIndex = 11
        Me.bpunto.Text = "."
        Me.bpunto.UseVisualStyleBackColor = True
        '
        'bigual
        '
        Me.bigual.Location = New System.Drawing.Point(183, 259)
        Me.bigual.Name = "bigual"
        Me.bigual.Size = New System.Drawing.Size(54, 55)
        Me.bigual.TabIndex = 12
        Me.bigual.Text = "="
        Me.bigual.UseVisualStyleBackColor = True
        '
        'bdividir
        '
        Me.bdividir.Location = New System.Drawing.Point(183, 12)
        Me.bdividir.Name = "bdividir"
        Me.bdividir.Size = New System.Drawing.Size(54, 55)
        Me.bdividir.TabIndex = 13
        Me.bdividir.Text = "/"
        Me.bdividir.UseVisualStyleBackColor = True
        '
        'bmultiplicar
        '
        Me.bmultiplicar.Location = New System.Drawing.Point(183, 76)
        Me.bmultiplicar.Name = "bmultiplicar"
        Me.bmultiplicar.Size = New System.Drawing.Size(54, 55)
        Me.bmultiplicar.TabIndex = 14
        Me.bmultiplicar.Text = "*"
        Me.bmultiplicar.UseVisualStyleBackColor = True
        '
        'brestar
        '
        Me.brestar.Location = New System.Drawing.Point(183, 137)
        Me.brestar.Name = "brestar"
        Me.brestar.Size = New System.Drawing.Size(54, 55)
        Me.brestar.TabIndex = 15
        Me.brestar.Text = "-"
        Me.brestar.UseVisualStyleBackColor = True
        '
        'bsumar
        '
        Me.bsumar.Location = New System.Drawing.Point(183, 198)
        Me.bsumar.Name = "bsumar"
        Me.bsumar.Size = New System.Drawing.Size(54, 55)
        Me.bsumar.TabIndex = 16
        Me.bsumar.Text = "+"
        Me.bsumar.UseVisualStyleBackColor = True
        '
        'bborrar
        '
        Me.bborrar.Location = New System.Drawing.Point(123, 259)
        Me.bborrar.Name = "bborrar"
        Me.bborrar.Size = New System.Drawing.Size(54, 55)
        Me.bborrar.TabIndex = 17
        Me.bborrar.Text = "Del"
        Me.bborrar.UseVisualStyleBackColor = True
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(242, 322)
        Me.Controls.Add(Me.bborrar)
        Me.Controls.Add(Me.bsumar)
        Me.Controls.Add(Me.brestar)
        Me.Controls.Add(Me.bmultiplicar)
        Me.Controls.Add(Me.bdividir)
        Me.Controls.Add(Me.bigual)
        Me.Controls.Add(Me.bpunto)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.b9)
        Me.Controls.Add(Me.b8)
        Me.Controls.Add(Me.b7)
        Me.Controls.Add(Me.b6)
        Me.Controls.Add(Me.b5)
        Me.Controls.Add(Me.b4)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.b0)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents b1 As Button
    Friend WithEvents b2 As Button
    Friend WithEvents b3 As Button
    Friend WithEvents b4 As Button
    Friend WithEvents b5 As Button
    Friend WithEvents b6 As Button
    Friend WithEvents b7 As Button
    Friend WithEvents b8 As Button
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents b9 As Button
    Friend WithEvents b0 As Button
    Friend WithEvents bpunto As Button
    Friend WithEvents bigual As Button
    Friend WithEvents bdividir As Button
    Friend WithEvents bmultiplicar As Button
    Friend WithEvents brestar As Button
    Friend WithEvents bsumar As Button
    Friend WithEvents bborrar As Button
End Class
