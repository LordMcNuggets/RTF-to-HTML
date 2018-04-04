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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Input_text1 = New System.Windows.Forms.RichTextBox()
        Me.Input_text2 = New System.Windows.Forms.RichTextBox()
        Me.Picture1 = New System.Windows.Forms.PictureBox()
        Me.Signature = New System.Windows.Forms.PictureBox()
        Me.Output_HTML = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Signature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Input_text1
        '
        Me.Input_text1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input_text1.Location = New System.Drawing.Point(12, 12)
        Me.Input_text1.Name = "Input_text1"
        Me.Input_text1.Size = New System.Drawing.Size(552, 155)
        Me.Input_text1.TabIndex = 0
        Me.Input_text1.Text = ""
        '
        'Input_text2
        '
        Me.Input_text2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input_text2.Location = New System.Drawing.Point(12, 299)
        Me.Input_text2.Name = "Input_text2"
        Me.Input_text2.Size = New System.Drawing.Size(552, 69)
        Me.Input_text2.TabIndex = 1
        Me.Input_text2.Text = ""
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Picture1.Location = New System.Drawing.Point(12, 173)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.Size = New System.Drawing.Size(203, 77)
        Me.Picture1.TabIndex = 2
        Me.Picture1.TabStop = False
        '
        'Signature
        '
        Me.Signature.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Signature.ImageLocation = ""
        Me.Signature.InitialImage = Nothing
        Me.Signature.Location = New System.Drawing.Point(12, 374)
        Me.Signature.Name = "Signature"
        Me.Signature.Size = New System.Drawing.Size(203, 113)
        Me.Signature.TabIndex = 3
        Me.Signature.TabStop = False
        '
        'Output_HTML
        '
        Me.Output_HTML.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Output_HTML.Location = New System.Drawing.Point(12, 524)
        Me.Output_HTML.Name = "Output_HTML"
        Me.Output_HTML.Size = New System.Drawing.Size(624, 96)
        Me.Output_HTML.TabIndex = 4
        Me.Output_HTML.Text = ""
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(283, 453)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 37)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Convert"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(529, 496)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 22)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Copy"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AllowDrop = True
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 37)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Select Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(529, 410)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 37)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Refresh"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Align Left", "Align Right", "Centre Image"})
        Me.ComboBox1.Location = New System.Drawing.Point(253, 173)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(213, 28)
        Me.ComboBox1.TabIndex = 16
        Me.ComboBox1.Text = "Choose image alignment ▼"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 493)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(120, 26)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Select image"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(644, 631)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Output_HTML)
        Me.Controls.Add(Me.Signature)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.Input_text2)
        Me.Controls.Add(Me.Input_text1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Converter"
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Signature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Input_text1 As RichTextBox
    Friend WithEvents Input_text2 As RichTextBox
    Friend WithEvents Picture1 As PictureBox
    Friend WithEvents Signature As PictureBox
    Friend WithEvents Output_HTML As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
End Class
