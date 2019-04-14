<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Snake
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
        Me.components = New System.ComponentModel.Container()
        Me.pb_Field = New System.Windows.Forms.PictureBox()
        Me.tm_SnakeMover = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.pb_Field, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_Field
        '
        Me.pb_Field.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pb_Field.Location = New System.Drawing.Point(13, 23)
        Me.pb_Field.Name = "pb_Field"
        Me.pb_Field.Size = New System.Drawing.Size(705, 492)
        Me.pb_Field.TabIndex = 0
        Me.pb_Field.TabStop = False
        '
        'tm_SnakeMover
        '
        Me.tm_SnakeMover.Interval = 50
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(653, 541)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(712, 541)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 30)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Snake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 583)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pb_Field)
        Me.Name = "Snake"
        Me.Text = "Snake"
        CType(Me.pb_Field, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pb_Field As PictureBox
    Friend WithEvents tm_SnakeMover As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
