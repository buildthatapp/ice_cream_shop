<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIceCreamStore
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
        Me.pnlFlavors = New System.Windows.Forms.Panel()
        Me.lstbxFlavors = New System.Windows.Forms.ListBox()
        Me.pnlScoops = New System.Windows.Forms.Panel()
        Me.rdbtnThreeScoops = New System.Windows.Forms.RadioButton()
        Me.rdbtnTwoScoops = New System.Windows.Forms.RadioButton()
        Me.rdbtnOneScoop = New System.Windows.Forms.RadioButton()
        Me.pnlToppings = New System.Windows.Forms.Panel()
        Me.chkbxGummyWorms = New System.Windows.Forms.CheckBox()
        Me.chkbxCherrySyrup = New System.Windows.Forms.CheckBox()
        Me.chkbxChocolateChips = New System.Windows.Forms.CheckBox()
        Me.chkbxOreos = New System.Windows.Forms.CheckBox()
        Me.chkbxSprinkles = New System.Windows.Forms.CheckBox()
        Me.lblFlavor = New System.Windows.Forms.Label()
        Me.lblScoops = New System.Windows.Forms.Label()
        Me.lblToppings = New System.Windows.Forms.Label()
        Me.lblchargePerScoop = New System.Windows.Forms.Label()
        Me.lblchargePerTopping = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnPrintOrder = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlFlavors.SuspendLayout()
        Me.pnlScoops.SuspendLayout()
        Me.pnlToppings.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFlavors
        '
        Me.pnlFlavors.Controls.Add(Me.lstbxFlavors)
        Me.pnlFlavors.Location = New System.Drawing.Point(13, 56)
        Me.pnlFlavors.Name = "pnlFlavors"
        Me.pnlFlavors.Size = New System.Drawing.Size(137, 204)
        Me.pnlFlavors.TabIndex = 0
        '
        'lstbxFlavors
        '
        Me.lstbxFlavors.FormattingEnabled = True
        Me.lstbxFlavors.Items.AddRange(New Object() {"Chocolate", "Vanilla", "Cookie dough", "Strawberry", "Mint chip", "Mocha", "Cookies n cream"})
        Me.lstbxFlavors.Location = New System.Drawing.Point(4, 4)
        Me.lstbxFlavors.Name = "lstbxFlavors"
        Me.lstbxFlavors.Size = New System.Drawing.Size(120, 134)
        Me.lstbxFlavors.TabIndex = 0
        '
        'pnlScoops
        '
        Me.pnlScoops.Controls.Add(Me.rdbtnThreeScoops)
        Me.pnlScoops.Controls.Add(Me.rdbtnTwoScoops)
        Me.pnlScoops.Controls.Add(Me.rdbtnOneScoop)
        Me.pnlScoops.Location = New System.Drawing.Point(156, 56)
        Me.pnlScoops.Name = "pnlScoops"
        Me.pnlScoops.Size = New System.Drawing.Size(137, 204)
        Me.pnlScoops.TabIndex = 1
        '
        'rdbtnThreeScoops
        '
        Me.rdbtnThreeScoops.AutoSize = True
        Me.rdbtnThreeScoops.Location = New System.Drawing.Point(21, 82)
        Me.rdbtnThreeScoops.Name = "rdbtnThreeScoops"
        Me.rdbtnThreeScoops.Size = New System.Drawing.Size(68, 17)
        Me.rdbtnThreeScoops.TabIndex = 3
        Me.rdbtnThreeScoops.TabStop = True
        Me.rdbtnThreeScoops.Text = "3 scoops"
        Me.rdbtnThreeScoops.UseVisualStyleBackColor = True
        '
        'rdbtnTwoScoops
        '
        Me.rdbtnTwoScoops.AutoSize = True
        Me.rdbtnTwoScoops.Location = New System.Drawing.Point(21, 59)
        Me.rdbtnTwoScoops.Name = "rdbtnTwoScoops"
        Me.rdbtnTwoScoops.Size = New System.Drawing.Size(68, 17)
        Me.rdbtnTwoScoops.TabIndex = 2
        Me.rdbtnTwoScoops.TabStop = True
        Me.rdbtnTwoScoops.Text = "2 scoops"
        Me.rdbtnTwoScoops.UseVisualStyleBackColor = True
        '
        'rdbtnOneScoop
        '
        Me.rdbtnOneScoop.AutoSize = True
        Me.rdbtnOneScoop.Location = New System.Drawing.Point(21, 36)
        Me.rdbtnOneScoop.Name = "rdbtnOneScoop"
        Me.rdbtnOneScoop.Size = New System.Drawing.Size(63, 17)
        Me.rdbtnOneScoop.TabIndex = 1
        Me.rdbtnOneScoop.TabStop = True
        Me.rdbtnOneScoop.Text = "1 scoop"
        Me.rdbtnOneScoop.UseVisualStyleBackColor = True
        '
        'pnlToppings
        '
        Me.pnlToppings.Controls.Add(Me.chkbxGummyWorms)
        Me.pnlToppings.Controls.Add(Me.chkbxCherrySyrup)
        Me.pnlToppings.Controls.Add(Me.chkbxChocolateChips)
        Me.pnlToppings.Controls.Add(Me.chkbxOreos)
        Me.pnlToppings.Controls.Add(Me.chkbxSprinkles)
        Me.pnlToppings.Location = New System.Drawing.Point(299, 56)
        Me.pnlToppings.Name = "pnlToppings"
        Me.pnlToppings.Size = New System.Drawing.Size(137, 204)
        Me.pnlToppings.TabIndex = 2
        '
        'chkbxGummyWorms
        '
        Me.chkbxGummyWorms.AutoSize = True
        Me.chkbxGummyWorms.Location = New System.Drawing.Point(4, 96)
        Me.chkbxGummyWorms.Name = "chkbxGummyWorms"
        Me.chkbxGummyWorms.Size = New System.Drawing.Size(94, 17)
        Me.chkbxGummyWorms.TabIndex = 8
        Me.chkbxGummyWorms.Text = "Gummy worms"
        Me.chkbxGummyWorms.UseVisualStyleBackColor = True
        '
        'chkbxCherrySyrup
        '
        Me.chkbxCherrySyrup.AutoSize = True
        Me.chkbxCherrySyrup.Location = New System.Drawing.Point(4, 73)
        Me.chkbxCherrySyrup.Name = "chkbxCherrySyrup"
        Me.chkbxCherrySyrup.Size = New System.Drawing.Size(86, 17)
        Me.chkbxCherrySyrup.TabIndex = 7
        Me.chkbxCherrySyrup.Text = "Cherry Syrup"
        Me.chkbxCherrySyrup.UseVisualStyleBackColor = True
        '
        'chkbxChocolateChips
        '
        Me.chkbxChocolateChips.AutoSize = True
        Me.chkbxChocolateChips.Location = New System.Drawing.Point(4, 50)
        Me.chkbxChocolateChips.Name = "chkbxChocolateChips"
        Me.chkbxChocolateChips.Size = New System.Drawing.Size(102, 17)
        Me.chkbxChocolateChips.TabIndex = 6
        Me.chkbxChocolateChips.Text = "Chocolate chips"
        Me.chkbxChocolateChips.UseVisualStyleBackColor = True
        '
        'chkbxOreos
        '
        Me.chkbxOreos.AutoSize = True
        Me.chkbxOreos.Location = New System.Drawing.Point(3, 27)
        Me.chkbxOreos.Name = "chkbxOreos"
        Me.chkbxOreos.Size = New System.Drawing.Size(54, 17)
        Me.chkbxOreos.TabIndex = 5
        Me.chkbxOreos.Text = "Oreos"
        Me.chkbxOreos.UseVisualStyleBackColor = True
        '
        'chkbxSprinkles
        '
        Me.chkbxSprinkles.AutoSize = True
        Me.chkbxSprinkles.Location = New System.Drawing.Point(4, 4)
        Me.chkbxSprinkles.Name = "chkbxSprinkles"
        Me.chkbxSprinkles.Size = New System.Drawing.Size(69, 17)
        Me.chkbxSprinkles.TabIndex = 4
        Me.chkbxSprinkles.Text = "Sprinkles"
        Me.chkbxSprinkles.UseVisualStyleBackColor = True
        '
        'lblFlavor
        '
        Me.lblFlavor.AutoSize = True
        Me.lblFlavor.Location = New System.Drawing.Point(12, 29)
        Me.lblFlavor.Name = "lblFlavor"
        Me.lblFlavor.Size = New System.Drawing.Size(44, 13)
        Me.lblFlavor.TabIndex = 2
        Me.lblFlavor.Text = "Flavors:"
        '
        'lblScoops
        '
        Me.lblScoops.AutoSize = True
        Me.lblScoops.Location = New System.Drawing.Point(153, 29)
        Me.lblScoops.Name = "lblScoops"
        Me.lblScoops.Size = New System.Drawing.Size(46, 13)
        Me.lblScoops.TabIndex = 3
        Me.lblScoops.Text = "Scoops:"
        '
        'lblToppings
        '
        Me.lblToppings.AutoSize = True
        Me.lblToppings.Location = New System.Drawing.Point(296, 29)
        Me.lblToppings.Name = "lblToppings"
        Me.lblToppings.Size = New System.Drawing.Size(54, 13)
        Me.lblToppings.TabIndex = 4
        Me.lblToppings.Text = "Toppings:"
        '
        'lblchargePerScoop
        '
        Me.lblchargePerScoop.AutoSize = True
        Me.lblchargePerScoop.Location = New System.Drawing.Point(153, 263)
        Me.lblchargePerScoop.Name = "lblchargePerScoop"
        Me.lblchargePerScoop.Size = New System.Drawing.Size(68, 13)
        Me.lblchargePerScoop.TabIndex = 5
        Me.lblchargePerScoop.Text = "$1.00/scoop"
        '
        'lblchargePerTopping
        '
        Me.lblchargePerTopping.AutoSize = True
        Me.lblchargePerTopping.Location = New System.Drawing.Point(296, 263)
        Me.lblchargePerTopping.Name = "lblchargePerTopping"
        Me.lblchargePerTopping.Size = New System.Drawing.Size(68, 13)
        Me.lblchargePerTopping.TabIndex = 6
        Me.lblchargePerTopping.Text = "$.50/topping"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(299, 290)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 4
        Me.txtTotal.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(236, 296)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "Total"
        '
        'btnPrintOrder
        '
        Me.btnPrintOrder.Location = New System.Drawing.Point(95, 331)
        Me.btnPrintOrder.Name = "btnPrintOrder"
        Me.btnPrintOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintOrder.TabIndex = 9
        Me.btnPrintOrder.Text = "Print Order"
        Me.btnPrintOrder.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(239, 331)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 23)
        Me.Clear.TabIndex = 10
        Me.Clear.Text = "&Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(324, 331)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmIceCreamStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 366)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.btnPrintOrder)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblchargePerTopping)
        Me.Controls.Add(Me.lblchargePerScoop)
        Me.Controls.Add(Me.lblToppings)
        Me.Controls.Add(Me.lblScoops)
        Me.Controls.Add(Me.lblFlavor)
        Me.Controls.Add(Me.pnlToppings)
        Me.Controls.Add(Me.pnlScoops)
        Me.Controls.Add(Me.pnlFlavors)
        Me.Name = "frmIceCreamStore"
        Me.Text = "Ice Cream Store"
        Me.pnlFlavors.ResumeLayout(False)
        Me.pnlScoops.ResumeLayout(False)
        Me.pnlScoops.PerformLayout()
        Me.pnlToppings.ResumeLayout(False)
        Me.pnlToppings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlFlavors As Panel
    Friend WithEvents pnlScoops As Panel
    Friend WithEvents pnlToppings As Panel
    Friend WithEvents lblFlavor As Label
    Friend WithEvents lblScoops As Label
    Friend WithEvents lblToppings As Label
    Friend WithEvents lblchargePerScoop As Label
    Friend WithEvents lblchargePerTopping As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnPrintOrder As Button
    Friend WithEvents Clear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents rdbtnThreeScoops As RadioButton
    Friend WithEvents rdbtnTwoScoops As RadioButton
    Friend WithEvents rdbtnOneScoop As RadioButton
    Friend WithEvents lstbxFlavors As ListBox
    Friend WithEvents chkbxGummyWorms As CheckBox
    Friend WithEvents chkbxCherrySyrup As CheckBox
    Friend WithEvents chkbxChocolateChips As CheckBox
    Friend WithEvents chkbxOreos As CheckBox
    Friend WithEvents chkbxSprinkles As CheckBox
End Class
