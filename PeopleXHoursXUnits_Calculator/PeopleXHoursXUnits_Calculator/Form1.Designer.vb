<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPUC
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
        Me.btnAddToList = New System.Windows.Forms.Button()
        Me.lblWOQuantity = New System.Windows.Forms.Label()
        Me.txtWOQty = New System.Windows.Forms.TextBox()
        Me.lblPeopleCount = New System.Windows.Forms.Label()
        Me.txtPeopleCount = New System.Windows.Forms.TextBox()
        Me.txtHoursToWork = New System.Windows.Forms.TextBox()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblManHours = New System.Windows.Forms.Label()
        Me.lblPeopleHours = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUnitHours = New System.Windows.Forms.Label()
        Me.flp1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTotalQuantity = New System.Windows.Forms.Label()
        Me.lblForTotalQty = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddToList
        '
        Me.btnAddToList.Location = New System.Drawing.Point(14, 102)
        Me.btnAddToList.Name = "btnAddToList"
        Me.btnAddToList.Size = New System.Drawing.Size(100, 23)
        Me.btnAddToList.TabIndex = 4
        Me.btnAddToList.Text = "Add WO Info"
        Me.btnAddToList.UseVisualStyleBackColor = True
        '
        'lblWOQuantity
        '
        Me.lblWOQuantity.AutoSize = True
        Me.lblWOQuantity.Location = New System.Drawing.Point(3, 8)
        Me.lblWOQuantity.Name = "lblWOQuantity"
        Me.lblWOQuantity.Size = New System.Drawing.Size(45, 13)
        Me.lblWOQuantity.TabIndex = 3
        Me.lblWOQuantity.Text = "WO Qty"
        '
        'txtWOQty
        '
        Me.txtWOQty.Location = New System.Drawing.Point(6, 24)
        Me.txtWOQty.Name = "txtWOQty"
        Me.txtWOQty.Size = New System.Drawing.Size(100, 20)
        Me.txtWOQty.TabIndex = 3
        '
        'lblPeopleCount
        '
        Me.lblPeopleCount.AutoSize = True
        Me.lblPeopleCount.Location = New System.Drawing.Point(154, 0)
        Me.lblPeopleCount.Name = "lblPeopleCount"
        Me.lblPeopleCount.Size = New System.Drawing.Size(62, 13)
        Me.lblPeopleCount.TabIndex = 5
        Me.lblPeopleCount.Text = "# of People"
        '
        'txtPeopleCount
        '
        Me.txtPeopleCount.Location = New System.Drawing.Point(157, 15)
        Me.txtPeopleCount.Name = "txtPeopleCount"
        Me.txtPeopleCount.Size = New System.Drawing.Size(100, 20)
        Me.txtPeopleCount.TabIndex = 0
        Me.txtPeopleCount.Text = "0"
        '
        'txtHoursToWork
        '
        Me.txtHoursToWork.Location = New System.Drawing.Point(157, 53)
        Me.txtHoursToWork.Name = "txtHoursToWork"
        Me.txtHoursToWork.Size = New System.Drawing.Size(100, 20)
        Me.txtHoursToWork.TabIndex = 1
        Me.txtHoursToWork.Text = "0"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(154, 38)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(86, 13)
        Me.lblHours.TabIndex = 7
        Me.lblHours.Text = "# Hours to Work"
        '
        'lblManHours
        '
        Me.lblManHours.AutoSize = True
        Me.lblManHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManHours.Location = New System.Drawing.Point(152, 86)
        Me.lblManHours.MaximumSize = New System.Drawing.Size(300, 0)
        Me.lblManHours.Name = "lblManHours"
        Me.lblManHours.Size = New System.Drawing.Size(25, 25)
        Me.lblManHours.TabIndex = 9
        Me.lblManHours.Text = "0"
        '
        'lblPeopleHours
        '
        Me.lblPeopleHours.AutoSize = True
        Me.lblPeopleHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblPeopleHours.Location = New System.Drawing.Point(154, 111)
        Me.lblPeopleHours.Name = "lblPeopleHours"
        Me.lblPeopleHours.Size = New System.Drawing.Size(82, 15)
        Me.lblPeopleHours.TabIndex = 10
        Me.lblPeopleHours.Text = "People Hours"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.Location = New System.Drawing.Point(140, 56)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(14, 13)
        Me.lblX.TabIndex = 11
        Me.lblX.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(149, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Hours Per Unit"
        '
        'lblUnitHours
        '
        Me.lblUnitHours.AutoSize = True
        Me.lblUnitHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitHours.Location = New System.Drawing.Point(60, 273)
        Me.lblUnitHours.MaximumSize = New System.Drawing.Size(300, 0)
        Me.lblUnitHours.Name = "lblUnitHours"
        Me.lblUnitHours.Size = New System.Drawing.Size(25, 25)
        Me.lblUnitHours.TabIndex = 12
        Me.lblUnitHours.Text = "0"
        '
        'flp1
        '
        Me.flp1.AutoScroll = True
        Me.flp1.Location = New System.Drawing.Point(12, 130)
        Me.flp1.Name = "flp1"
        Me.flp1.Size = New System.Drawing.Size(269, 135)
        Me.flp1.TabIndex = 14
        '
        'lblTotalQuantity
        '
        Me.lblTotalQuantity.AutoSize = True
        Me.lblTotalQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQuantity.Location = New System.Drawing.Point(14, 68)
        Me.lblTotalQuantity.MaximumSize = New System.Drawing.Size(300, 0)
        Me.lblTotalQuantity.Name = "lblTotalQuantity"
        Me.lblTotalQuantity.Size = New System.Drawing.Size(25, 25)
        Me.lblTotalQuantity.TabIndex = 15
        Me.lblTotalQuantity.Text = "0"
        '
        'lblForTotalQty
        '
        Me.lblForTotalQty.AutoSize = True
        Me.lblForTotalQty.Location = New System.Drawing.Point(3, 47)
        Me.lblForTotalQty.Name = "lblForTotalQty"
        Me.lblForTotalQty.Size = New System.Drawing.Size(73, 13)
        Me.lblForTotalQty.TabIndex = 16
        Me.lblForTotalQty.Text = "Total Quantity"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(260, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmPUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 303)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblForTotalQty)
        Me.Controls.Add(Me.lblTotalQuantity)
        Me.Controls.Add(Me.flp1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUnitHours)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.lblPeopleHours)
        Me.Controls.Add(Me.lblManHours)
        Me.Controls.Add(Me.txtHoursToWork)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.txtPeopleCount)
        Me.Controls.Add(Me.lblPeopleCount)
        Me.Controls.Add(Me.txtWOQty)
        Me.Controls.Add(Me.lblWOQuantity)
        Me.Controls.Add(Me.btnAddToList)
        Me.Name = "frmPUC"
        Me.Text = "People Unit Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddToList As Button
    Friend WithEvents lblWOQuantity As Label
    Friend WithEvents txtWOQty As TextBox
    Friend WithEvents lblPeopleCount As Label
    Friend WithEvents txtPeopleCount As TextBox
    Friend WithEvents txtHoursToWork As TextBox
    Friend WithEvents lblHours As Label
    Friend WithEvents lblManHours As Label
    Friend WithEvents lblPeopleHours As Label
    Friend WithEvents lblX As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUnitHours As Label
    Friend WithEvents flp1 As FlowLayoutPanel
    Friend WithEvents lblTotalQuantity As Label
    Friend WithEvents lblForTotalQty As Label
    Friend WithEvents Button1 As Button
End Class
