<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbReporte = New System.Windows.Forms.ListBox()
        Me.lbAlumnosdestacados = New System.Windows.Forms.ListBox()
        Me.lbPromediogeneral = New System.Windows.Forms.Label()
        Me.lbMejorpromedio = New System.Windows.Forms.Label()
        Me.txtPromediogeneral = New System.Windows.Forms.TextBox()
        Me.txtMejorpromedio = New System.Windows.Forms.TextBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbReporte
        '
        Me.lbReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbReporte.FormattingEnabled = True
        Me.lbReporte.ItemHeight = 20
        Me.lbReporte.Location = New System.Drawing.Point(12, 93)
        Me.lbReporte.Name = "lbReporte"
        Me.lbReporte.Size = New System.Drawing.Size(459, 444)
        Me.lbReporte.TabIndex = 0
        '
        'lbAlumnosdestacados
        '
        Me.lbAlumnosdestacados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbAlumnosdestacados.FormattingEnabled = True
        Me.lbAlumnosdestacados.ItemHeight = 20
        Me.lbAlumnosdestacados.Location = New System.Drawing.Point(477, 93)
        Me.lbAlumnosdestacados.Name = "lbAlumnosdestacados"
        Me.lbAlumnosdestacados.Size = New System.Drawing.Size(506, 344)
        Me.lbAlumnosdestacados.TabIndex = 1
        '
        'lbPromediogeneral
        '
        Me.lbPromediogeneral.AutoSize = True
        Me.lbPromediogeneral.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbPromediogeneral.Location = New System.Drawing.Point(698, 464)
        Me.lbPromediogeneral.Name = "lbPromediogeneral"
        Me.lbPromediogeneral.Size = New System.Drawing.Size(139, 20)
        Me.lbPromediogeneral.TabIndex = 2
        Me.lbPromediogeneral.Text = "Promedio General:"
        '
        'lbMejorpromedio
        '
        Me.lbMejorpromedio.AutoSize = True
        Me.lbMejorpromedio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbMejorpromedio.Location = New System.Drawing.Point(635, 508)
        Me.lbMejorpromedio.Name = "lbMejorpromedio"
        Me.lbMejorpromedio.Size = New System.Drawing.Size(203, 20)
        Me.lbMejorpromedio.TabIndex = 3
        Me.lbMejorpromedio.Text = "Mejor promedio en general:"
        '
        'txtPromediogeneral
        '
        Me.txtPromediogeneral.Location = New System.Drawing.Point(858, 464)
        Me.txtPromediogeneral.Name = "txtPromediogeneral"
        Me.txtPromediogeneral.Size = New System.Drawing.Size(125, 27)
        Me.txtPromediogeneral.TabIndex = 4
        '
        'txtMejorpromedio
        '
        Me.txtMejorpromedio.Location = New System.Drawing.Point(858, 508)
        Me.txtMejorpromedio.Name = "txtMejorpromedio"
        Me.txtMejorpromedio.Size = New System.Drawing.Size(125, 27)
        Me.txtMejorpromedio.TabIndex = 5
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMostrar.Location = New System.Drawing.Point(748, 13)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(235, 71)
        Me.btnMostrar.TabIndex = 6
        Me.btnMostrar.Text = "Generar reporte"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 549)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.txtMejorpromedio)
        Me.Controls.Add(Me.txtPromediogeneral)
        Me.Controls.Add(Me.lbMejorpromedio)
        Me.Controls.Add(Me.lbPromediogeneral)
        Me.Controls.Add(Me.lbAlumnosdestacados)
        Me.Controls.Add(Me.lbReporte)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbReporte As ListBox
    Friend WithEvents lbAlumnosdestacados As ListBox
    Friend WithEvents lbPromediogeneral As Label
    Friend WithEvents lbMejorpromedio As Label
    Friend WithEvents txtPromediogeneral As TextBox
    Friend WithEvents txtMejorpromedio As TextBox
    Friend WithEvents btnMostrar As Button
End Class
