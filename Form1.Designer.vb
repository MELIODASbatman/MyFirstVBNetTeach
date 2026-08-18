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
        lblname = New Label()
        lblcourse = New Label()
        lblcollage = New Label()
        txtname = New TextBox()
        txtcourse = New TextBox()
        txtcollage = New TextBox()
        btndisplay = New Button()
        SuspendLayout()
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Location = New Point(71, 32)
        lblname.Name = "lblname"
        lblname.Size = New Size(39, 15)
        lblname.TabIndex = 0
        lblname.Text = "Name"
        ' 
        ' lblcourse
        ' 
        lblcourse.AutoSize = True
        lblcourse.Location = New Point(71, 82)
        lblcourse.Name = "lblcourse"
        lblcourse.Size = New Size(44, 15)
        lblcourse.TabIndex = 1
        lblcourse.Text = "Course"
        ' 
        ' lblcollage
        ' 
        lblcollage.AutoSize = True
        lblcollage.Location = New Point(71, 134)
        lblcollage.Name = "lblcollage"
        lblcollage.Size = New Size(47, 15)
        lblcollage.TabIndex = 2
        lblcollage.Text = "Collage"
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(136, 29)
        txtname.Name = "txtname"
        txtname.Size = New Size(154, 23)
        txtname.TabIndex = 3
        ' 
        ' txtcourse
        ' 
        txtcourse.Location = New Point(136, 82)
        txtcourse.Name = "txtcourse"
        txtcourse.Size = New Size(154, 23)
        txtcourse.TabIndex = 4
        ' 
        ' txtcollage
        ' 
        txtcollage.Location = New Point(136, 131)
        txtcollage.Name = "txtcollage"
        txtcollage.Size = New Size(154, 23)
        txtcollage.TabIndex = 5
        ' 
        ' btndisplay
        ' 
        btndisplay.Location = New Point(110, 196)
        btndisplay.Name = "btndisplay"
        btndisplay.Size = New Size(75, 23)
        btndisplay.TabIndex = 6
        btndisplay.Text = "Display"
        btndisplay.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btndisplay)
        Controls.Add(txtcollage)
        Controls.Add(txtcourse)
        Controls.Add(txtname)
        Controls.Add(lblcollage)
        Controls.Add(lblcourse)
        Controls.Add(lblname)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblname As Label
    Friend WithEvents lblcourse As Label
    Friend WithEvents lblcollage As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtcourse As TextBox
    Friend WithEvents txtcollage As TextBox
    Friend WithEvents btndisplay As Button

End Class
