﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class depositAmount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(depositAmount))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.AMMOUNT_box = New System.Windows.Forms.RichTextBox()
        Me.Account_type = New System.Windows.Forms.RichTextBox()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Receipt_Slot = New System.Windows.Forms.Button()
        Me.Swipe_Slot = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ButtonDec = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.Backspace_Button = New System.Windows.Forms.Button()
        Me.No_Button = New System.Windows.Forms.Button()
        Me.Go_Button = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(494, 494)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(28, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(273, 264)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'AMMOUNT_box
        '
        Me.AMMOUNT_box.Location = New System.Drawing.Point(116, 126)
        Me.AMMOUNT_box.Name = "AMMOUNT_box"
        Me.AMMOUNT_box.ReadOnly = True
        Me.AMMOUNT_box.Size = New System.Drawing.Size(90, 22)
        Me.AMMOUNT_box.TabIndex = 43
        Me.AMMOUNT_box.Text = ""
        '
        'Account_type
        '
        Me.Account_type.Location = New System.Drawing.Point(116, 171)
        Me.Account_type.Name = "Account_type"
        Me.Account_type.ReadOnly = True
        Me.Account_type.Size = New System.Drawing.Size(90, 22)
        Me.Account_type.TabIndex = 44
        Me.Account_type.Text = ""
        '
        'Back_Button
        '
        Me.Back_Button.Location = New System.Drawing.Point(45, 230)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(53, 23)
        Me.Back_Button.TabIndex = 45
        Me.Back_Button.Text = "Back"
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Receipt_Slot
        '
        Me.Receipt_Slot.BackColor = System.Drawing.Color.Transparent
        Me.Receipt_Slot.BackgroundImage = CType(resources.GetObject("Receipt_Slot.BackgroundImage"), System.Drawing.Image)
        Me.Receipt_Slot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Receipt_Slot.Location = New System.Drawing.Point(329, 32)
        Me.Receipt_Slot.Name = "Receipt_Slot"
        Me.Receipt_Slot.Size = New System.Drawing.Size(124, 32)
        Me.Receipt_Slot.TabIndex = 46
        Me.Receipt_Slot.Text = "Receipt Slot"
        Me.Receipt_Slot.UseVisualStyleBackColor = False
        '
        'Swipe_Slot
        '
        Me.Swipe_Slot.BackColor = System.Drawing.Color.Transparent
        Me.Swipe_Slot.BackgroundImage = CType(resources.GetObject("Swipe_Slot.BackgroundImage"), System.Drawing.Image)
        Me.Swipe_Slot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Swipe_Slot.Location = New System.Drawing.Point(329, 88)
        Me.Swipe_Slot.Name = "Swipe_Slot"
        Me.Swipe_Slot.Size = New System.Drawing.Size(124, 32)
        Me.Swipe_Slot.TabIndex = 47
        Me.Swipe_Slot.Text = "Swipe Slot"
        Me.Swipe_Slot.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Location = New System.Drawing.Point(329, 288)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(124, 28)
        Me.Button11.TabIndex = 48
        Me.Button11.Text = "Deposit Slot"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.Location = New System.Drawing.Point(101, 288)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(124, 28)
        Me.Button12.TabIndex = 49
        Me.Button12.Text = "Withdraw Slot"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(101, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 34)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(143, 322)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 34)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(185, 322)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(36, 34)
        Me.Button3.TabIndex = 52
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(101, 362)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 34)
        Me.Button4.TabIndex = 53
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(143, 362)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(36, 34)
        Me.Button5.TabIndex = 54
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(185, 362)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(36, 34)
        Me.Button6.TabIndex = 55
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(101, 402)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(36, 34)
        Me.Button7.TabIndex = 56
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(143, 402)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(36, 34)
        Me.Button8.TabIndex = 57
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(185, 402)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(36, 34)
        Me.Button9.TabIndex = 58
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'ButtonDec
        '
        Me.ButtonDec.BackgroundImage = CType(resources.GetObject("ButtonDec.BackgroundImage"), System.Drawing.Image)
        Me.ButtonDec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonDec.Image = CType(resources.GetObject("ButtonDec.Image"), System.Drawing.Image)
        Me.ButtonDec.Location = New System.Drawing.Point(185, 442)
        Me.ButtonDec.Name = "ButtonDec"
        Me.ButtonDec.Size = New System.Drawing.Size(36, 34)
        Me.ButtonDec.TabIndex = 95
        Me.ButtonDec.Text = "•"
        Me.ButtonDec.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.BackgroundImage = CType(resources.GetObject("Button0.BackgroundImage"), System.Drawing.Image)
        Me.Button0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button0.Image = CType(resources.GetObject("Button0.Image"), System.Drawing.Image)
        Me.Button0.Location = New System.Drawing.Point(101, 442)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(78, 34)
        Me.Button0.TabIndex = 94
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'Backspace_Button
        '
        Me.Backspace_Button.BackColor = System.Drawing.Color.Transparent
        Me.Backspace_Button.BackgroundImage = CType(resources.GetObject("Backspace_Button.BackgroundImage"), System.Drawing.Image)
        Me.Backspace_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Backspace_Button.Location = New System.Drawing.Point(227, 362)
        Me.Backspace_Button.Name = "Backspace_Button"
        Me.Backspace_Button.Size = New System.Drawing.Size(36, 34)
        Me.Backspace_Button.TabIndex = 93
        Me.Backspace_Button.Text = "←"
        Me.Backspace_Button.UseVisualStyleBackColor = False
        '
        'No_Button
        '
        Me.No_Button.BackColor = System.Drawing.Color.Transparent
        Me.No_Button.BackgroundImage = CType(resources.GetObject("No_Button.BackgroundImage"), System.Drawing.Image)
        Me.No_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.No_Button.Location = New System.Drawing.Point(227, 322)
        Me.No_Button.Name = "No_Button"
        Me.No_Button.Size = New System.Drawing.Size(36, 34)
        Me.No_Button.TabIndex = 92
        Me.No_Button.Text = "✕"
        Me.No_Button.UseVisualStyleBackColor = False
        '
        'Go_Button
        '
        Me.Go_Button.BackColor = System.Drawing.Color.Transparent
        Me.Go_Button.BackgroundImage = CType(resources.GetObject("Go_Button.BackgroundImage"), System.Drawing.Image)
        Me.Go_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Go_Button.Location = New System.Drawing.Point(227, 402)
        Me.Go_Button.Name = "Go_Button"
        Me.Go_Button.Size = New System.Drawing.Size(36, 34)
        Me.Go_Button.TabIndex = 91
        Me.Go_Button.Text = "○"
        Me.Go_Button.UseVisualStyleBackColor = False
        '
        'depositAmount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 481)
        Me.Controls.Add(Me.ButtonDec)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.Backspace_Button)
        Me.Controls.Add(Me.No_Button)
        Me.Controls.Add(Me.Go_Button)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Swipe_Slot)
        Me.Controls.Add(Me.Receipt_Slot)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.Account_type)
        Me.Controls.Add(Me.AMMOUNT_box)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "depositAmount"
        Me.Text = "depositAmount"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents AMMOUNT_box As System.Windows.Forms.RichTextBox
    Friend WithEvents Account_type As System.Windows.Forms.RichTextBox
    Friend WithEvents Back_Button As System.Windows.Forms.Button
    Friend WithEvents Receipt_Slot As System.Windows.Forms.Button
    Friend WithEvents Swipe_Slot As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents ButtonDec As System.Windows.Forms.Button
    Friend WithEvents Button0 As System.Windows.Forms.Button
    Friend WithEvents Backspace_Button As System.Windows.Forms.Button
    Friend WithEvents No_Button As System.Windows.Forms.Button
    Friend WithEvents Go_Button As System.Windows.Forms.Button
End Class
