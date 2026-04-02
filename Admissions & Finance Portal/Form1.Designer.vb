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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Label1 = New Label()
        txtAge = New TextBox()
        txtStudentName = New TextBox()
        GroupBox2 = New GroupBox()
        radPartTime = New RadioButton()
        radFullTime = New RadioButton()
        cboCourse = New ComboBox()
        chkHostel = New CheckBox()
        btnCalculate = New Button()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtAge)
        GroupBox1.Controls.Add(txtStudentName)
        GroupBox1.Location = New Point(31, 193)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(475, 222)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Personal Information:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 25)
        Label2.TabIndex = 3
        Label2.Text = "Age:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 25)
        Label1.TabIndex = 2
        Label1.Text = "Full Name:"
        ' 
        ' txtAge
        ' 
        txtAge.BorderStyle = BorderStyle.FixedSingle
        txtAge.Location = New Point(6, 173)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(379, 31)
        txtAge.TabIndex = 1
        ' 
        ' txtStudentName
        ' 
        txtStudentName.BorderStyle = BorderStyle.FixedSingle
        txtStudentName.Location = New Point(6, 79)
        txtStudentName.Name = "txtStudentName"
        txtStudentName.Size = New Size(379, 31)
        txtStudentName.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(radPartTime)
        GroupBox2.Controls.Add(radFullTime)
        GroupBox2.Location = New Point(31, 434)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(267, 210)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Enrollment Status:"
        ' 
        ' radPartTime
        ' 
        radPartTime.AutoSize = True
        radPartTime.Location = New Point(6, 98)
        radPartTime.Name = "radPartTime"
        radPartTime.Size = New Size(112, 29)
        radPartTime.TabIndex = 1
        radPartTime.TabStop = True
        radPartTime.Text = "Part-Time"
        radPartTime.UseVisualStyleBackColor = True
        ' 
        ' radFullTime
        ' 
        radFullTime.AutoSize = True
        radFullTime.Location = New Point(6, 40)
        radFullTime.Name = "radFullTime"
        radFullTime.Size = New Size(109, 29)
        radFullTime.TabIndex = 0
        radFullTime.TabStop = True
        radFullTime.Text = "Full-Time"
        radFullTime.UseVisualStyleBackColor = True
        ' 
        ' cboCourse
        ' 
        cboCourse.FormattingEnabled = True
        cboCourse.Items.AddRange(New Object() {"Computer Science", "Engineering", "Business Administration"})
        cboCourse.Location = New Point(495, 473)
        cboCourse.Name = "cboCourse"
        cboCourse.Size = New Size(270, 33)
        cboCourse.TabIndex = 2
        cboCourse.Tag = ""
        cboCourse.Text = "Select Course"
        ' 
        ' chkHostel
        ' 
        chkHostel.AutoSize = True
        chkHostel.Location = New Point(37, 668)
        chkHostel.Name = "chkHostel"
        chkHostel.Size = New Size(211, 29)
        chkHostel.TabIndex = 3
        chkHostel.Text = "Hostel Accomodation"
        chkHostel.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.Orange
        btnCalculate.Location = New Point(394, 645)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(371, 72)
        btnCalculate.TabIndex = 4
        btnCalculate.Text = "Process Admission"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(495, 434)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 25)
        Label3.TabIndex = 5
        Label3.Text = "Course Selection:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(180, 124)
        Label4.Name = "Label4"
        Label4.Size = New Size(462, 38)
        Label4.TabIndex = 6
        Label4.Text = "KAAF Admisions && Finance Portal"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(337, 37)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 73)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(800, 791)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnCalculate)
        Controls.Add(chkHostel)
        Controls.Add(cboCourse)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        ForeColor = Color.Maroon
        Name = "Form1"
        Text = "Kaaf Portal"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private txtAge As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Private radPartTime As RadioButton
    Private radFullTime As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents chkHostel As CheckBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
