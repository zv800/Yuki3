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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.CehckforbadPross = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckForBadFiles = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.errorrow = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.RemoveVirus = New System.ComponentModel.BackgroundWorker()
        Me.DelVirusRemover = New System.Windows.Forms.Timer(Me.components)
        Me.KillFalseP = New System.Windows.Forms.Timer(Me.components)
        Me.Wait2DisPros = New System.ComponentModel.BackgroundWorker()
        Me.Memzopenweb = New System.Windows.Forms.Timer(Me.components)
        Me.Timer10 = New System.Windows.Forms.Timer(Me.components)
        Me.Stilluseingthispclol = New System.Windows.Forms.Timer(Me.components)
        Me.fakememz = New System.ComponentModel.BackgroundWorker()
        Me.CopyIexmeme = New System.Windows.Forms.Timer(Me.components)
        Me.fucked = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 20000
        '
        'Timer2
        '
        Me.Timer2.Interval = 10000
        '
        'Timer3
        '
        Me.Timer3.Interval = 10000
        '
        'CehckforbadPross
        '
        Me.CehckforbadPross.Enabled = True
        Me.CehckforbadPross.Interval = 3000
        '
        'Timer4
        '
        '
        'Timer5
        '
        Me.Timer5.Interval = 10000
        '
        'CheckForBadFiles
        '
        Me.CheckForBadFiles.Enabled = True
        Me.CheckForBadFiles.Interval = 4000
        '
        'Timer6
        '
        Me.Timer6.Interval = 5000
        '
        'Timer7
        '
        Me.Timer7.Enabled = True
        Me.Timer7.Interval = 70
        '
        'errorrow
        '
        '
        'RemoveVirus
        '
        '
        'DelVirusRemover
        '
        Me.DelVirusRemover.Interval = 4000
        '
        'KillFalseP
        '
        '
        'Wait2DisPros
        '
        '
        'Memzopenweb
        '
        '
        'Stilluseingthispclol
        '
        Me.Stilluseingthispclol.Interval = 10000
        '
        'fakememz
        '
        '
        'CopyIexmeme
        '
        Me.CopyIexmeme.Interval = 1
        '
        'fucked
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 208)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "Yuki"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents CehckforbadPross As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents CheckForBadFiles As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Timer7 As Timer
    Friend WithEvents errorrow As Timer
    Friend WithEvents Timer8 As Timer
    Friend WithEvents RemoveVirus As System.ComponentModel.BackgroundWorker
    Friend WithEvents DelVirusRemover As Timer
    Friend WithEvents KillFalseP As Timer
    Friend WithEvents Wait2DisPros As System.ComponentModel.BackgroundWorker
    Friend WithEvents Memzopenweb As Timer
    Friend WithEvents Timer10 As Timer
    Friend WithEvents Stilluseingthispclol As Timer
    Friend WithEvents fakememz As System.ComponentModel.BackgroundWorker
    Friend WithEvents CopyIexmeme As Timer
    Friend WithEvents fucked As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
End Class
