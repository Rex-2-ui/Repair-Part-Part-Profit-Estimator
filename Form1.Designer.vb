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
        components = New ComponentModel.Container()
        GroupBox1 = New GroupBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        ToolTip1 = New ToolTip(components)
        ToolTip2 = New ToolTip(components)
        ToolTip3 = New ToolTip(components)
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.Highlight
        GroupBox1.Location = New Point(26, 22)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(813, 103)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Part Information"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(240, 65)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(400, 27)
        TextBox2.TabIndex = 6
        TextBox2.Text = "Radiator, Ford Escort"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(240, 20)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(400, 27)
        TextBox1.TabIndex = 2
        TextBox1.Text = "X456YVK98"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.Desktop
        Label2.Location = New Point(56, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 20)
        Label2.TabIndex = 1
        Label2.Text = "Part Description"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(56, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 20)
        Label1.TabIndex = 0
        Label1.Text = "Part Identifier"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Controls.Add(TextBox5)
        GroupBox2.Controls.Add(TextBox6)
        GroupBox2.Controls.Add(TextBox7)
        GroupBox2.Controls.Add(TextBox8)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = SystemColors.HotTrack
        GroupBox2.Location = New Point(26, 162)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(575, 299)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Price, Cost, Storage, Profit"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(256, 47)
        TextBox3.Name = "TextBox3"
        TextBox3.RightToLeft = RightToLeft.Yes
        TextBox3.Size = New Size(274, 30)
        TextBox3.TabIndex = 7
        TextBox3.Text = "123.45"
        ToolTip1.SetToolTip(TextBox3, "Displays the Retail Price")
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(256, 89)
        TextBox4.Name = "TextBox4"
        TextBox4.RightToLeft = RightToLeft.Yes
        TextBox4.Size = New Size(274, 30)
        TextBox4.TabIndex = 8
        TextBox4.Text = "73.45"
        ToolTip2.SetToolTip(TextBox4, "Displays Wholesale Cost")
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(351, 130)
        TextBox5.Name = "TextBox5"
        TextBox5.RightToLeft = RightToLeft.Yes
        TextBox5.Size = New Size(179, 30)
        TextBox5.TabIndex = 9
        TextBox5.Text = "2"
        ToolTip3.SetToolTip(TextBox5, "Displays Number of Items")
        ' 
        ' TextBox6
        ' 
        TextBox6.Enabled = False
        TextBox6.Location = New Point(256, 166)
        TextBox6.Name = "TextBox6"
        TextBox6.ReadOnly = True
        TextBox6.RightToLeft = RightToLeft.Yes
        TextBox6.Size = New Size(274, 30)
        TextBox6.TabIndex = 10
        TextBox6.TabStop = False
        ' 
        ' TextBox7
        ' 
        TextBox7.Enabled = False
        TextBox7.Location = New Point(256, 212)
        TextBox7.Name = "TextBox7"
        TextBox7.ReadOnly = True
        TextBox7.RightToLeft = RightToLeft.Yes
        TextBox7.Size = New Size(274, 30)
        TextBox7.TabIndex = 11
        TextBox7.TabStop = False
        ' 
        ' TextBox8
        ' 
        TextBox8.Enabled = False
        TextBox8.Location = New Point(256, 259)
        TextBox8.Name = "TextBox8"
        TextBox8.ReadOnly = True
        TextBox8.RightToLeft = RightToLeft.Yes
        TextBox8.Size = New Size(274, 30)
        TextBox8.TabIndex = 12
        TextBox8.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = SystemColors.ControlText
        Label8.Location = New Point(56, 266)
        Label8.Name = "Label8"
        Label8.Size = New Size(89, 23)
        Label8.TabIndex = 6
        Label8.Text = "Net Profit:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = SystemColors.ControlText
        Label7.Location = New Point(56, 219)
        Label7.Name = "Label7"
        Label7.Size = New Size(140, 23)
        Label7.TabIndex = 5
        Label7.Text = "Storage Charges:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = SystemColors.ControlText
        Label6.Location = New Point(56, 175)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 23)
        Label6.TabIndex = 4
        Label6.Text = "Gross Profit:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.Desktop
        Label5.Location = New Point(56, 137)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 23)
        Label5.TabIndex = 3
        Label5.Text = "Quantity:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(56, 96)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 23)
        Label4.TabIndex = 2
        Label4.Text = "Wholesale Cost:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(56, 54)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 23)
        Label3.TabIndex = 1
        Label3.Text = "Retail Price:"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(699, 207)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 2
        Button1.Text = "Compute"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(699, 265)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 3
        Button2.Text = "Reset Form"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(699, 328)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 4
        Button3.Text = "Total Net Profit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(699, 390)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 5
        Button4.Text = "Exit"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AcceptButton = Button1
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        CancelButton = Button2
        ClientSize = New Size(877, 497)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = " "
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip

End Class
