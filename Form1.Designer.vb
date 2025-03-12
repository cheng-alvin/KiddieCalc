<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        addend1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        addend2 = New TextBox()
        Label1 = New Label()
        ans = New TextBox()
        Button5 = New Button()
        Button6 = New Button()
        SuspendLayout()
        ' 
        ' addend1
        ' 
        addend1.Location = New Point(81, 289)
        addend1.Name = "addend1"
        addend1.Size = New Size(125, 38)
        addend1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(285, 446)
        Button1.Name = "Button1"
        Button1.Size = New Size(122, 90)
        Button1.TabIndex = 1
        Button1.Text = "/"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(285, 83)
        Button2.Name = "Button2"
        Button2.Size = New Size(122, 90)
        Button2.TabIndex = 2
        Button2.Text = "+"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(285, 206)
        Button3.Name = "Button3"
        Button3.Size = New Size(122, 90)
        Button3.TabIndex = 3
        Button3.Text = "-"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(285, 324)
        Button4.Name = "Button4"
        Button4.Size = New Size(122, 90)
        Button4.TabIndex = 4
        Button4.Text = "*"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' addend2
        ' 
        addend2.Location = New Point(484, 289)
        addend2.Name = "addend2"
        addend2.Size = New Size(125, 38)
        addend2.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(682, 296)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 31)
        Label1.TabIndex = 6
        Label1.Text = "="
        ' 
        ' ans
        ' 
        ans.Location = New Point(791, 289)
        ans.Name = "ans"
        ans.Size = New Size(125, 38)
        ans.TabIndex = 7
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(782, 570)
        Button5.Name = "Button5"
        Button5.Size = New Size(150, 46)
        Button5.TabIndex = 8
        Button5.Text = "Exit"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(615, 570)
        Button6.Name = "Button6"
        Button6.Size = New Size(150, 46)
        Button6.TabIndex = 9
        Button6.Text = "Clear"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(14F, 31F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(995, 653)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(ans)
        Controls.Add(Label1)
        Controls.Add(addend2)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(addend1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents addend1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents addend2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ans As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button

End Class
