Option Strict On

Imports System.ComponentModel

''' <summary>
''' Name:           DemoEventsCS
''' Author:         Alfred Masardo
''' Date:           01-Jan-2018
''' Description:    Demostrate some events and the data they produce.
''' </summary>
Public Class frmDemoEventsVB

    ''' <summary>
    ''' btnEnter_Click - Event that happens when the sender control Is clicked, in this case a Button.
    '''                - Displays event data.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' sender Is the control that has
        Dim control As Button = CType(sender, Button)

        If (TypeOf (e) Is MouseEventArgs) Then

            ' How the event was fired Like... 
            '      * Which mouse button was pressed. 
            '      * How many clicks. 
            '      * X coordinate of the mouse
            '      * Y coordinate of the mouse
            Dim eventArguments As MouseEventArgs = CType(e, MouseEventArgs)

            ' Display the event data
            lblEventOutput.Text = "Event Handler: btnEnter_Click" & vbCrLf &
                                    "Event: MouseDoubleClick" & vbCrLf &
                                    "Control: " & control.Name.ToString() & vbCrLf &
                                    "Control Data: " & control.Text & vbCrLf &
                                    "Mouse Button Clicked: " + eventArguments.Button.ToString() & vbCrLf &
                                    "# Of Clicks: " & eventArguments.Clicks.ToString() & vbCrLf &
                                    "X Coordinates: " & eventArguments.X.ToString() & vbCrLf &
                                    "Y Coordinates: " & eventArguments.Y.ToString()


        Else ' if the user tabbed to the button and click Enter

            ' since a mouse was not used there are no mouse events

            ' Display the event data
            lblEventOutput.Text = "Event Handler: btnEnter_Click" & vbCrLf &
                                    "Event: MouseDoubleClick" & vbCrLf &
                                    "Control: " & control.Name.ToString() & vbCrLf &
                                    "Control Data: " & control.Text

        End If

    End Sub

    Private Sub btnEnter_MouseHover(sender As Object, e As EventArgs) Handles btnEnter.MouseHover

        ' sender Is the control that Is 
        ' sending the event
        ' sender Is the control that has
        Dim control As Button = CType(sender, Button)

        ' Other Event arguments do Not pass anything

        ' Display the event data
        lblEventOutput.Text = "Event Handler: btnEnter_MouseHover" & vbCrLf &
                                    "Event: MouseHover" & vbCrLf &
                                    "Control: " & control.Name.ToString() & vbCrLf &
                                    "Control Data: " & control.Text

    End Sub

    ''' <summary>
    ''' lbLabelDemonstrator_Click - Event that happens when the sender control Is clicked, in this case a Label.
    '''                - Displays event data.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lbLabelDemonstrator_Click(sender As Object, e As EventArgs) Handles lbLabelDemonstrator.Click

        ' sender Is the control that has
        Dim control As Label = CType(sender, Label)

        ' How the event was fired Like... 
        '      * Which mouse button was pressed. 
        '      * How many clicks. 
        '      * X coordinate of the mouse
        '      * Y coordinate of the mouse
        Dim eventArguments As MouseEventArgs = CType(e, MouseEventArgs)

        ' Display the event data
        lblEventOutput.Text = "Event Handler: lbLabelDemonstrator_Click" & vbCrLf &
                                "Event: MouseDoubleClick" & vbCrLf &
                                "Control: " & control.Name.ToString() & vbCrLf &
                                "Control Data: " & control.Text & vbCrLf &
                                "Mouse Button Clicked: " + eventArguments.Button.ToString() & vbCrLf &
                                "# Of Clicks: " & eventArguments.Clicks.ToString() & vbCrLf &
                                "X Coordinates: " & eventArguments.X.ToString() & vbCrLf &
                                "Y Coordinates: " & eventArguments.Y.ToString()

    End Sub
    ''' <summary>
    ''' lbLabelDemonstrator_MouseHover - Event that happens when the mouse hovers over the sender control, in this case a Label.
    '''                                 - Displays event data.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lbLabelDemonstrator_MouseHover(sender As Object, e As EventArgs) Handles lbLabelDemonstrator.MouseHover

        ' sender Is the control that Is 
        ' sending the event
        ' sender Is the control that has
        Dim control As Label = CType(sender, Label)

        ' Other Event arguments do Not pass anything

        ' Display the event data
        lblEventOutput.Text = "Event Handler: lbLabelDemonstrator_MouseHover" & vbCrLf &
                                    "Event: MouseHover" & vbCrLf &
                                    "Control: " & control.Name.ToString() & vbCrLf &
                                    "Control Data: " & control.Text

    End Sub

    ''' <summary>
    ''' tbTextBoxDemonstrator_TextChanged - Event that happens when the Text property of the sender control, in this case a TextBox, is changed.
    '''                                     - Displays event data.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tbTextBoxDemonstrator_TextChanged(sender As Object, e As EventArgs) Handles tbTextBoxDemonstrator.TextChanged

        ' sender Is the control that Is 
        ' sending the event
        ' sender Is the control that has
        Dim control As TextBox = CType(sender, TextBox)

        ' Other Event arguments do Not pass anything

        ' Display the event data
        lblEventOutput.Text = "Event Handler: tbTextBoxDemonstrator_TextChanged" & vbCrLf &
                                    "Event: MouseHover" & vbCrLf &
                                    "Control: " & control.Name.ToString() & vbCrLf &
                                    "Control Data: " & control.Text

    End Sub

    ''' <summary>
    ''' tbTextBoxDemonstrator_MouseHover - Event that happens when the mouse hovers over the sender control, in this case a TextBox.
    '''                                 - Displays event data.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tbTextBoxDemonstrator_MouseHover(sender As Object, e As EventArgs) Handles tbTextBoxDemonstrator.MouseHover

        ' sender Is the control that Is 
        ' sending the event
        ' sender Is the control that has
        Dim control As TextBox = CType(sender, TextBox)

        ' Other Event arguments do Not pass anything

        ' Display the event data
        lblEventOutput.Text = "Event Handler: tbTextBoxDemonstrator_MouseHover" & vbCrLf &
                                    "Event: MouseHover" & vbCrLf &
                                    "Control: " & control.Name.ToString() & vbCrLf &
                                    "Control Data: " & control.Text

    End Sub

    ''' <summary>
    ''' btnReset_Click - Event that happens when the sender control Is clicked, in this case a Button.
    '''                - Clears the screen.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' loop through the controls on the form
        For Each control As Control In Me.Controls

            If TypeOf (control) Is TextBox Then

                control.Text = String.Empty

            ElseIf TypeOf (control) Is Label Then

                If CType(control, Label).BorderStyle = BorderStyle.Fixed3D Then

                    control.Text = String.Empty

                End If

            End If

        Next control

    End Sub

    ''' <summary>
    ''' btnExit_Click - Event that happens when the sender control Is clicked, in this case a Button.
    '''               - Commences the process of closing the form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit the form
        Me.Close()
    End Sub

    ''' <summary>
    ''' frmDemoEventsCS_FormClosing - Event that happens just prior to the form actually closing.
    '''                             - Checks to see if the user actually wants to close the form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmDemoEventsVB_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        ' Get the results from the MessageBox
        Dim resultOne As DialogResult = MessageBox.Show("Are you sure you wish you would like to close the form?", "Form Close", MessageBoxButtons.YesNo)

        ' If the user selected No
        If resultOne = DialogResult.No Then

            ' Then Cancel the Closing of the form
            e.Cancel = True

        Else

            ' Get the results from the MessageBox
            Dim resultTwo As DialogResult = MessageBox.Show("Really? You don't like me, FINE!", "Form Close", MessageBoxButtons.YesNo)

            ' If the user selected No
            If resultTwo = DialogResult.No Then

                ' Then Cancel the Closing of the form
                e.Cancel = True

            End If

        End If

    End Sub

    ''' <summary>
    ''' frmDemoEventsCS_MouseDoubleClick - Event that happens when the sender control (Form) Is double clicked.
    '''                - Displays event data.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmDemoEventsVB_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick

        ' sender Is the control that has
        Dim control As Form = CType(sender, Form)

        ' How the event was fired Like... 
        '      * Which mouse button was pressed. 
        '      * How many clicks. 
        '      * X coordinate of the mouse
        '      * Y coordinate of the mouse
        Dim eventArguments As MouseEventArgs = CType(e, MouseEventArgs)

        ' Display the event data
        lblEventOutput.Text = "Event Handler: frmDemoEventsVB_MouseDoubleClick" & vbCrLf &
                                "Event: MouseDoubleClick" & vbCrLf &
                                "Control: " & control.Name.ToString() & vbCrLf &
                                "Control Data: " & control.Text & vbCrLf &
                                "Mouse Button Clicked: " + eventArguments.Button.ToString() & vbCrLf &
                                "# Of Clicks: " & eventArguments.Clicks.ToString() & vbCrLf &
                                "X Coordinates: " & eventArguments.X.ToString() & vbCrLf &
                                "Y Coordinates: " & eventArguments.Y.ToString()

    End Sub

End Class
