<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.bBackup = New System.Windows.Forms.Button()
        Me.bMalware = New System.Windows.Forms.Button()
        Me.bRestore = New System.Windows.Forms.Button()
        Me.bZeuS = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bBackup
        '
        Me.bBackup.Location = New System.Drawing.Point(12, 12)
        Me.bBackup.Name = "bBackup"
        Me.bBackup.Size = New System.Drawing.Size(129, 43)
        Me.bBackup.TabIndex = 0
        Me.bBackup.Text = "Backup Host File"
        Me.bBackup.UseVisualStyleBackColor = True
        '
        'bMalware
        '
        Me.bMalware.Location = New System.Drawing.Point(12, 61)
        Me.bMalware.Name = "bMalware"
        Me.bMalware.Size = New System.Drawing.Size(260, 43)
        Me.bMalware.TabIndex = 1
        Me.bMalware.Text = "Malware"
        Me.bMalware.UseVisualStyleBackColor = True
        '
        'bRestore
        '
        Me.bRestore.Location = New System.Drawing.Point(143, 12)
        Me.bRestore.Name = "bRestore"
        Me.bRestore.Size = New System.Drawing.Size(129, 43)
        Me.bRestore.TabIndex = 2
        Me.bRestore.Text = "Restore Host File"
        Me.bRestore.UseVisualStyleBackColor = True
        '
        'bZeuS
        '
        Me.bZeuS.Location = New System.Drawing.Point(12, 110)
        Me.bZeuS.Name = "bZeuS"
        Me.bZeuS.Size = New System.Drawing.Size(260, 43)
        Me.bZeuS.TabIndex = 3
        Me.bZeuS.Text = "ZeuS"
        Me.bZeuS.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.bZeuS)
        Me.Controls.Add(Me.bRestore)
        Me.Controls.Add(Me.bMalware)
        Me.Controls.Add(Me.bBackup)
        Me.Name = "MainForm"
        Me.Text = "Host File Modifier"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bBackup As System.Windows.Forms.Button
    Friend WithEvents bMalware As System.Windows.Forms.Button
    Friend WithEvents bRestore As System.Windows.Forms.Button
    Friend WithEvents bZeuS As System.Windows.Forms.Button

End Class
