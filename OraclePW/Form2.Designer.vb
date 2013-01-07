<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtResult = New System.Windows.Forms.TextBox
        Me.lblPos = New System.Windows.Forms.Label
        Me.btnDefault = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnPrev = New System.Windows.Forms.Button
        Me.txtPos = New System.Windows.Forms.TextBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.txtHASH = New System.Windows.Forms.TextBox
        Me.txtPASS = New System.Windows.Forms.TextBox
        Me.txtPW_HASH = New System.Windows.Forms.TextBox
        Me.btnBruteForce = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Load Password List"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(13, 194)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResult.Size = New System.Drawing.Size(390, 67)
        Me.txtResult.TabIndex = 1
        '
        'lblPos
        '
        Me.lblPos.AutoSize = True
        Me.lblPos.Location = New System.Drawing.Point(182, 18)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(16, 13)
        Me.lblPos.TabIndex = 2
        Me.lblPos.Text = "of"
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(13, 165)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(75, 23)
        Me.btnDefault.TabIndex = 4
        Me.btnDefault.Text = "Is PW User?"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(272, 12)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(31, 23)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(244, 12)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(31, 23)
        Me.btnPrev.TabIndex = 6
        Me.btnPrev.Text = "<<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'txtPos
        '
        Me.txtPos.Location = New System.Drawing.Point(145, 15)
        Me.txtPos.Name = "txtPos"
        Me.txtPos.ReadOnly = True
        Me.txtPos.Size = New System.Drawing.Size(31, 20)
        Me.txtPos.TabIndex = 7
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(204, 15)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(31, 20)
        Me.txtTotal.TabIndex = 8
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(13, 56)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(163, 20)
        Me.txtUser.TabIndex = 9
        '
        'txtHASH
        '
        Me.txtHASH.Location = New System.Drawing.Point(13, 83)
        Me.txtHASH.Name = "txtHASH"
        Me.txtHASH.ReadOnly = True
        Me.txtHASH.Size = New System.Drawing.Size(163, 20)
        Me.txtHASH.TabIndex = 10
        '
        'txtPASS
        '
        Me.txtPASS.Location = New System.Drawing.Point(204, 56)
        Me.txtPASS.Name = "txtPASS"
        Me.txtPASS.ReadOnly = True
        Me.txtPASS.Size = New System.Drawing.Size(164, 20)
        Me.txtPASS.TabIndex = 11
        '
        'txtPW_HASH
        '
        Me.txtPW_HASH.Location = New System.Drawing.Point(204, 82)
        Me.txtPW_HASH.Name = "txtPW_HASH"
        Me.txtPW_HASH.ReadOnly = True
        Me.txtPW_HASH.Size = New System.Drawing.Size(164, 20)
        Me.txtPW_HASH.TabIndex = 12
        '
        'btnBruteForce
        '
        Me.btnBruteForce.Location = New System.Drawing.Point(145, 165)
        Me.btnBruteForce.Name = "btnBruteForce"
        Me.btnBruteForce.Size = New System.Drawing.Size(75, 23)
        Me.btnBruteForce.TabIndex = 13
        Me.btnBruteForce.Text = "Brute Force"
        Me.btnBruteForce.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 272)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(412, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(111, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 294)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnBruteForce)
        Me.Controls.Add(Me.txtPW_HASH)
        Me.Controls.Add(Me.txtPASS)
        Me.Controls.Add(Me.txtHASH)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtPos)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.lblPos)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Password Auditer"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents lblPos As System.Windows.Forms.Label
    Friend WithEvents btnDefault As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents txtPos As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtHASH As System.Windows.Forms.TextBox
    Friend WithEvents txtPASS As System.Windows.Forms.TextBox
    Friend WithEvents txtPW_HASH As System.Windows.Forms.TextBox
    Friend WithEvents btnBruteForce As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
