Public Class frmPUC
    'This holds the value for Total Quantity of all work orders
    Private _totalQuantity As Double
    Public Property TotalQuantity() As Double
        Get
            Return _totalQuantity
        End Get
        Set(ByVal value As Double)
            _totalQuantity = value
        End Set
    End Property
    'This holds the value for all man hours available for calculation (People * Hours allotted to work)
    Private _totalManhours As Double
    Public Property TotalManHours() As Double
        Get
            Return _totalManhours
        End Get
        Set(ByVal value As Double)
            _totalManhours = value
        End Set
    End Property
    'this is the function that runs when clicking the "Add To List" button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddToList.Click
        'This sets the workOrder Number to an empty string
        Dim woNumber As String = ""
        'This sets the qty of the current Work Order to zero
        Dim woQty As Double = 0

        'This checks to ensure that the text of the WorkOrder Qty field is not blank
        If txtWOQty.Text <> Nothing Then
            'This converts the text of the qty textbox to a double
            Try
                woQty = Convert.ToDouble(txtWOQty.Text)

            Catch ex As Exception
                'if the text cannot be converted, it takes it as zero
                txtWOQty.Text = 0
                woQty = 0
            End Try
        End If

        'this dynamically creates a button to be added to the list of buttons that will hold record details
        Dim cb As New Button()
        'this sets the names, colors and sizes of the controls that will be added to flp1 (Flow Layout Panel)
        cb.Name = "cb" + woQty.ToString() + flp1.Controls.Count.ToString()
        cb.ForeColor = Color.Black
        cb.BackColor = Color.LemonChiffon
        cb.Height = 20
        cb.Width = 250
        'This adds a dynamic event handler to the buttons at runtime, allowing them to have events such as 'Click'
        AddHandler cb.Click, AddressOf cb_Click

        'ensure that the Qty is greater than zero for the current work order
        If woQty > 0 Then
            'update the Total Quantity of all the workorders
            TotalQuantity += woQty
            'set the text of the button to show the current Work Order Qty and the calculated hours allotted that workorder
            cb.Text = "This: " + woQty.ToString("F") + "_          Hrs/Wo:" + CalculateHoursPerWO(woQty)
            'set the text of the Total quantity label in a 2 digit formatted string such as 12.34
            lblTotalQuantity.Text = TotalQuantity.ToString("F")
            'set the text of the Total Unit Hours label in a 2 digit formatted string such as 12.34
            lblUnitHours.Text = CalculateHoursPerTotalUnits().ToString("F")
            'Add the button to the Flow Layout Panel, they automatically wrap in flow layout panel
            flp1.Controls.Add(cb)
            'clear the text box that has the WO Qty of the current WO
            txtWOQty.Clear()
            'return focus to that textbox to ready them for the next entry
            txtWOQty.Focus()
        End If
    End Sub
    'Possible future addition of button click events, like if they want to delete a specific Work Order entry
    Private Sub cb_Click(sender As Object, e As EventArgs)
        ' create a button
        'Dim b As Button
        'cast the object that was clicked as a button to let the program know what it is and access its properties
        'b = DirectCast(sender, Button)
        'remove the current button from the flow layout panel
        'flp1.Controls.Remove(b)
        'Now update the values of the remaining buttons and labels
        'UpdateText()
    End Sub

    Private Sub txtHoursToWork_TextChanged(sender As Object, e As EventArgs) Handles txtHoursToWork.TextChanged, txtPeopleCount.TextChanged
        'upon a change of the text in either the hours to work textbox or the number of people textbox, update all text
        UpdateText()
    End Sub

    Private Sub UpdateText()
        'this is a variable to hold the number of people available to work
        Dim peopleCount As Double
        'this is a variable to hold the number of hours that will be worked
        Dim hoursCount As Double

        'check to see if the objects (textboxes) have been created and then check their values (this will be skipped on load - prior to creation)
        'as this fires 1 time prior to textbox creation and you will get a null reference without it
        If txtHoursToWork.IsHandleCreated AndAlso txtPeopleCount.IsHandleCreated _
        AndAlso txtPeopleCount.Text <> Nothing AndAlso txtHoursToWork.Text <> Nothing Then
            'if everything is good set the values for the local variables to the values entered in the textboxes, converting
            'the strings (text) to Double numbers that we can perform calculations on

            peopleCount = Convert.ToDouble(txtPeopleCount.Text)
            hoursCount = Convert.ToDouble(txtHoursToWork.Text)
            'Set the value of the Global Variable for Total Man Hours to a product of the people times the hours
            TotalManHours = peopleCount * hoursCount
        Else
            'if everything is now good, just set the value to 0
            TotalManHours = 0
        End If
        'set the text of the Man Hours label equal to the total Man Hours calculated here
        lblManHours.Text = TotalManHours
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'call the launch method ---- placed in a seperate method to be able to be called again by CLEAR
        Launch()
    End Sub

    Private Sub Launch()
        'sets the Tab Index to 0 which refers to the index property set in design view 
        Me.TabIndex = 0
        'sets the default click event for the form (ENTER  BUTTON)
        Me.AcceptButton = btnAddToList
        'Set the focus to the people count textbox
        Me.txtPeopleCount.Focus()
        'select the text so they can just start typing upon loading of the program
        Me.txtPeopleCount.Select()
    End Sub
    'clears everything on the form and resets to a "Fresh Start" of the form
    Private Sub ClearAll()
        TotalQuantity = 0
        TotalManHours = 0
        txtPeopleCount.Text = 0
        txtWOQty.Text = 0
        txtHoursToWork.Text = 0
        flp1.Controls.Clear()
        lblUnitHours.Text = 0
        lblTotalQuantity.Text = 0
        lblManHours.Text = 0
    End Sub
    'Function that takes a single parameter (WO QTY) and returns a string that can then be used as text
    Private Function CalculateHoursPerWO(ByVal woQty As Double) As String
        If TotalQuantity > 0 AndAlso woQty > 0 Then
            Return (woQty * CalculateHoursPerTotalUnits()).ToString("F")
        Else Return "0"
        End If

    End Function
    'Function that Calculates the total hours per units
    Private Function CalculateHoursPerTotalUnits() As Double
        Return (TotalManHours / TotalQuantity)
    End Function
    'Method (Sub) that fires when the CLEAR button is clicked
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ClearAll()
        Launch()
    End Sub

    Private Sub UpdateCounts(sender As Object, e As EventArgs) Handles lblTotalQuantity.TextChanged
        'when the number changes in the totalQty label, this will fire
        'Check to see if there are controls (buttons) in the flow control panel
        If flp1.Controls.Count() > 0 Then
            'If there are, check each one for values and update them
            For Each b As Button In flp1.Controls
                'create variables to take in an input string like 
                '"This: 200 _          Hrs/Wo:8.76", which is what is on the dynamic buttons in the flp

                'this sets the string to the entire text of the current button
                Dim currentButtonText As String = b.Text
                'this creates an array of strings that will split whenever it sees the _ character, so it splits it thusly:
                '"[This: 200 ] and [_          Hrs/Wo:8.76]
                Dim woQtyString() As String = currentButtonText.Split("_")
                'this then takes the first string [This: 200 ] and splits it into 2 values at the :
                'we end up getting 2 more strings ([This:] and [200])
                Dim woQtyString2() As String = woQtyString(0).Split(":")
                'we are now taking that value (200) and setting it to the variable that we can then re-use in our calculation
                Dim woQty As String = woQtyString2(1)
                'We are now reconstructing our string to have the origianl data [This: 200 ] concatenated with the text from the 
                'calculated portion as some of the inputs have changed since it was created
                b.Text = woQtyString(0) + "_          Hrs/Wo:" + CalculateHoursPerWO(woQty)

            Next
        End If
    End Sub
End Class
