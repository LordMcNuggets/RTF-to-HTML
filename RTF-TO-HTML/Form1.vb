Public Class Form1
    Public Property SelectedFolder As Object
    Dim alignment_for_Img1 As String = ""


    Public Function ConvertToHTML1(ByVal Input_Text As RichTextBox) _
               As String
        ' Takes a RichTextBox control and returns a
        ' simple HTML-formatted version of its contents
        Dim strHTML As String
        Dim strColour As String
        Dim blnBold As Boolean
        Dim blnItalic As Boolean
        Dim blnUnderlined As Boolean
        Dim strFont As String
        Dim shtSize As Short
        Dim lngOriginalStart As Long
        Dim lngOriginalLength As Long
        Dim intCount As Integer



        ' If nothing in the box, exit
        If Input_Text.Text.Length = 0 Then Exit Function
        ' Store original selections, then select first character
        lngOriginalStart = 0
        lngOriginalLength = Input_Text.TextLength
        Input_Text.Select(0, 1)
        ' Add HTML header
        strHTML = "<html>"
        ' Set up initial parameters
        strColour = Input_Text.SelectionColor.ToKnownColor.ToString
        blnBold = Input_Text.SelectionFont.Bold
        blnItalic = Input_Text.SelectionFont.Italic
        blnUnderlined = Input_Text.SelectionFont.Underline
        strFont = Input_Text.SelectionFont.FontFamily.Name
        shtSize = Input_Text.SelectionFont.Size


        ' Include first 'style' parameters in the HTML
        strHTML += "<span style=""font-family: " & strFont &
          "; font-size: " & shtSize & "pt; color: " _
                          & strColour & """>"
        ' Include bold tag, if required
        If blnBold = True Then
            strHTML += "<b>"
        End If
        ' Include underline tag, if required
        If blnUnderlined = True Then
            strHTML += "<u>"
        End If

        ' Include italic tag, if required
        If blnItalic = True Then
            strHTML += "<i>"
        End If
        ' Finally, add our first character
        strHTML += "<br>Dear Sir/Madam, </br>"
        strHTML += Input_Text.Text.Substring(0, 1)
        ' Loop around all remaining characters
        For intCount = 2 To Input_Text.Text.Length
            ' Select current character
            Input_Text.Select(intCount - 1, 1)
            ' If this is a line break, add HTML tag
            If Input_Text.Text.Substring(intCount - 1, 1) =
                   Convert.ToChar(10) Then
                strHTML += "<br>"
            End If
            ' Check/implement any changes in style
            If Input_Text.SelectionColor.ToKnownColor.ToString <>
               strColour Or Input_Text.SelectionFont.FontFamily.Name _
          <> strFont Or Input_Text.SelectionFont.Size <> shtSize _
          Then
                strHTML += "</span><span style=""font-family: " _
             & Input_Text.SelectionFont.FontFamily.Name &
             "; font-size: " & Input_Text.SelectionFont.Size &
             "pt; color: " &
             Input_Text.SelectionColor.ToKnownColor.ToString & """>"
            End If
            ' Check for bold changes
            If Input_Text.SelectionFont.Bold <> blnBold Then
                If Input_Text.SelectionFont.Bold = False Then
                    strHTML += "</b>"
                Else
                    strHTML += "<b>"
                End If
            End If
            ' Check for underline changes
            If Input_Text.SelectionFont.Underline <> blnUnderlined Then
                If Input_Text.SelectionFont.Underline = False Then
                    strHTML += "</u>"
                Else
                    strHTML += "<u>"
                End If
            End If
            ' Check for italic changes
            If Input_Text.SelectionFont.Italic <> blnItalic Then
                If Input_Text.SelectionFont.Italic = False Then
                    strHTML += "</i>"
                Else
                    strHTML += "<i>"
                End If
            End If
            ' Add the actual character
            strHTML += Mid(Input_Text.Text, intCount, 1)
            ' Update variables with current style
            strColour = Input_Text.SelectionColor.ToKnownColor.ToString
            blnBold = Input_Text.SelectionFont.Bold
            blnUnderlined = Input_Text.SelectionFont.Underline
            blnItalic = Input_Text.SelectionFont.Italic
            strFont = Input_Text.SelectionFont.FontFamily.Name
            shtSize = Input_Text.SelectionFont.Size
        Next
        ' Close off any open bold/italic tags
        If blnBold = True Then strHTML += ""
        If blnUnderlined = True Then strHTML += ""
        If blnItalic = True Then strHTML += ""
        ' Terminate outstanding HTML tags
        strHTML += "</span></br>"
        ' Restore original RichTextBox selection
        Input_Text.Select(lngOriginalStart, lngOriginalLength)
        ' Return HTML
        Return strHTML
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function

    Public Function ConvertToHTML2(ByVal Input_Text As RichTextBox) _
               As String
        ' Takes a RichTextBox control and returns a
        ' simple HTML-formatted version of its contents
        Dim strHTML As String
        Dim strColour As String
        Dim blnBold As Boolean
        Dim blnItalic As Boolean
        Dim blnUnderlined As Boolean
        Dim strFont As String
        Dim shtSize As Short
        Dim lngOriginalStart As Long
        Dim lngOriginalLength As Long
        Dim intCount As Integer



        ' If nothing in the box, exit
        If Input_Text.Text.Length = 0 Then Exit Function
        ' Store original selections, then select first character
        lngOriginalStart = 0
        lngOriginalLength = Input_Text.TextLength
        Input_Text.Select(0, 1)
        ' Add HTML header
        strHTML = "<br>"
        ' Set up initial parameters
        strColour = Input_Text.SelectionColor.ToKnownColor.ToString
        blnBold = Input_Text.SelectionFont.Bold
        blnUnderlined = Input_Text.SelectionFont.Underline
        blnItalic = Input_Text.SelectionFont.Italic
        strFont = Input_Text.SelectionFont.FontFamily.Name
        shtSize = Input_Text.SelectionFont.Size


        ' Include first 'style' parameters in the HTML
        strHTML += "<span style=""font-family: " & strFont &
          "; font-size: " & shtSize & "pt; color: " _
                          & strColour & """>"
        ' Include bold tag, if required
        If blnBold = True Then
            strHTML += "<b>"
        End If
        ' Include underline tag, if required
        If blnUnderlined = True Then
            strHTML += "<u>"
        End If
        ' Include italic tag, if required
        If blnItalic = True Then
            strHTML += "<i>"
        End If
        ' Finally, add our first character

        strHTML += Input_Text.Text.Substring(0, 1)
        ' Loop around all remaining characters
        For intCount = 2 To Input_Text.Text.Length
            ' Select current character
            Input_Text.Select(intCount - 1, 1)
            ' If this is a line break, add HTML tag
            If Input_Text.Text.Substring(intCount - 1, 1) =
                   Convert.ToChar(10) Then
                strHTML += "<br>"
            End If
            ' Check/implement any changes in style
            If Input_Text.SelectionColor.ToKnownColor.ToString <>
               strColour Or Input_Text.SelectionFont.FontFamily.Name _
          <> strFont Or Input_Text.SelectionFont.Size <> shtSize _
          Then
                strHTML += "</span><span style=""font-family: " _
             & Input_Text.SelectionFont.FontFamily.Name &
             "; font-size: " & Input_Text.SelectionFont.Size &
             "pt; color: " &
             Input_Text.SelectionColor.ToKnownColor.ToString & """>"
            End If
            ' Check for bold changes
            If Input_Text.SelectionFont.Bold <> blnBold Then
                If Input_Text.SelectionFont.Bold = False Then
                    strHTML += "</b>"
                Else
                    strHTML += "<b>"
                End If
            End If
            ' Check for underline changes
            If Input_Text.SelectionFont.Underline <> blnUnderlined Then
                If Input_Text.SelectionFont.Underline = False Then
                    strHTML += "</u>"
                Else
                    strHTML += "<u>"
                End If
            End If
            ' Check for italic changes
            If Input_Text.SelectionFont.Italic <> blnItalic Then
                If Input_Text.SelectionFont.Italic = False Then
                    strHTML += "</i>"
                Else
                    strHTML += "<i>"
                End If
            End If
            ' Add the actual character
            strHTML += Mid(Input_Text.Text, intCount, 1)
            ' Update variables with current style
            strColour = Input_Text.SelectionColor.ToKnownColor.ToString
            blnBold = Input_Text.SelectionFont.Bold
            blnUnderlined = Input_Text.SelectionFont.Underline
            blnItalic = Input_Text.SelectionFont.Italic
            strFont = Input_Text.SelectionFont.FontFamily.Name
            shtSize = Input_Text.SelectionFont.Size
        Next
        ' Close off any open bold/italic tags
        If blnBold = True Then strHTML += ""
        If blnUnderlined = True Then strHTML += ""
        If blnItalic = True Then strHTML += ""
        ' Terminate outstanding HTML tags
        strHTML += "</span></br>"
        ' Restore original RichTextBox selection
        Input_Text.Select(lngOriginalStart, lngOriginalLength)
        ' Return HTML
        Return strHTML
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Clipboard.Clear()
        Clipboard.SetText(Output_HTML.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim v As String = "C:\Users\Emmanuel\Pictures\Saved Pictures\trolltunga.jpg"
        'Picture1.Image = Image.FromFile(v)
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ' TextBox1.Text = OpenFileDialog1.FileName
            Picture1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'For searched picture
        Dim var1 As String
        var1 = Picture1.ImageLocation.ToString()
        Dim strHTMLpic1 As String
        strHTMLpic1 = "<br>"
        strHTMLpic1 += "<img " & alignment_for_Img1
        strHTMLpic1 += "src = '" & var1 & "'> </br>"

        'For hardcoded image
        Dim var2 As String
        var2 = Signature.ImageLocation.ToString()
        Dim strHTMLpic2 As String
        strHTMLpic2 = "<br>"
        strHTMLpic2 += "<img src = '" & var2 & "'> </br></html>"

        'Putting everything together
        Output_HTML.Text = ConvertToHTML1(Input_text1) & strHTMLpic1 & ConvertToHTML2(Input_text2) & strHTMLpic2
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Output_HTML.Text = ""
        Input_text1.Text = ""
        Input_text2.Text = ""
        Picture1.ImageLocation = Nothing
        alignment_for_Img1 = ""
    End Sub

    Public Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Align Left" Then
            alignment_for_Img1 = "align='left'"
        End If
        If ComboBox1.SelectedItem = "Align Right" Then
            alignment_for_Img1 = "align='right'"
        End If
        If ComboBox1.SelectedItem = "Centre Image" Then
            alignment_for_Img1 = "align='middle'"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        OpenFileDialog2.InitialDirectory = "C:\Users\Emmanuel\Desktop\Blanche Birger - RTF to HTML\Mailer\Mailer form\Mailer form\assets"
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            Signature.ImageLocation = OpenFileDialog2.FileName
        End If
    End Sub
End Class