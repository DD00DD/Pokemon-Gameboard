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
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.picTitle = New System.Windows.Forms.PictureBox()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Transparent
        Me.btnPlay.FlatAppearance.BorderSize = 5
        Me.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.Gold
        Me.btnPlay.Location = New System.Drawing.Point(108, 492)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(478, 63)
        Me.btnPlay.TabIndex = 3
        Me.btnPlay.Text = "Press Enter to Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'picTitle
        '
        Me.picTitle.BackColor = System.Drawing.Color.Transparent
        Me.picTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picTitle.Location = New System.Drawing.Point(-1, -2)
        Me.picTitle.Name = "picTitle"
        Me.picTitle.Size = New System.Drawing.Size(711, 557)
        Me.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTitle.TabIndex = 0
        Me.picTitle.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.btnPlay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(706, 553)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.picTitle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picTitle As PictureBox
    Friend WithEvents btnPlay As Button
End Class
