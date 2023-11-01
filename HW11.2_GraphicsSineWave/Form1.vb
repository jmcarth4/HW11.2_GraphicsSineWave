'Jessica McArthur
'RCET 3371
'1 November 23
'HW 11.2 Graph sine waves

'Draws sine, tanget and cosine waves in picture box. Waveform resizes with form. 
Public Class Form1
    Public centerX, centerY, currentX, currentY, lastX, lastY As Integer      'Variables to plot line
    Public penColor As Pen                                                    'Variable to set color of pen


    Private Sub SineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SineToolStripMenuItem.Click
        Dim R, pi2, Vinst, stepX As Double                                    'Variables to calculate output
        Dim Period, Vp, loopX As Integer

        lastX = 0
        lastY = 0
        Me.Refresh()                                                          'Refresh picture box
        centerX = PictureBox1.Size.Width / 2                                  'Calculation to produce Y variable
        centerY = PictureBox1.Size.Height / 2
        Period = centerX
        lastX = 0
        lastY = centerY
        pi2 = (2 * Math.PI)
        Vp = centerY / 2
        stepX = centerX / 360

        Do Until loopX > PictureBox1.Size.Width                               'Draw sine wave width of picture box
            Vinst = centerY - (Vp * (Math.Sin(pi2 * (loopX / Period))))
            PictureBox1.CreateGraphics.DrawLine(penColor, lastX, lastY, loopX, CInt(Vinst))
            lastX = loopX
            loopX += stepX
            lastY = Vinst
        Loop

    End Sub

    Private Sub TanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TanToolStripMenuItem.Click
        Dim R, pi2, Vinst, stepX As Double                                  'Variables to calculate output
        Dim Period, Vp, loopX As Integer

        lastX = 0
        lastY = 0
        Me.Refresh()                                                        'Refresh picture box
        centerX = PictureBox1.Size.Width / 2                                'Calculation to produce Y variable
        centerY = PictureBox1.Size.Height / 2
        Period = centerX
        lastX = 0
        lastY = centerY
        pi2 = (2 * Math.PI)
        Vp = centerY / 20
        stepX = centerX / 360
        Do Until loopX > PictureBox1.Size.Width                             'Draw tangent wave width of picture box
            Vinst = centerY - (Vp * (Math.Tan(pi2 * (loopX / Period))))
            Try
                PictureBox1.CreateGraphics.DrawLine(penColor, lastX, lastY, loopX, CInt(Vinst))
                lastY = Vinst
            Catch err As Exception
            End Try
            lastX = loopX
            loopX += stepX
        Loop
    End Sub
    Private Sub CosineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CosineToolStripMenuItem.Click
        Dim R, pi2, Vinst, stepX As Double                                  'Variables to calculate output
        Dim Period, Vp, loopX As Integer

        lastX = 0
        lastY = 0
        Me.Refresh()                                                        'Refresh picture box
        centerX = PictureBox1.Size.Width / 2                                'Calculation to produce Y variable
        centerY = PictureBox1.Size.Height / 2
        Period = centerX
        lastX = 0
        lastY = centerY
        pi2 = (2 * Math.PI)
        Vp = centerY / 2
        stepX = centerX / 360
        Do Until loopX > PictureBox1.Size.Width                             'Draw cosine wave width of picture box
            Vinst = centerY - (Vp * (Math.Cos(pi2 * (loopX / Period))))
            If (Vinst - lastY) < -10 Then lastY = Vinst
            PictureBox1.CreateGraphics.DrawLine(penColor, lastX, lastY, loopX, CInt(Vinst))
            lastX = loopX
            loopX += stepX
            lastY = Vinst
        Loop
    End Sub

    'Changes color of pen when color name selected in menu
    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        penColor = Pens.Green
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        penColor = Pens.Blue
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        penColor = Pens.Red
    End Sub

    Private Sub YellowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YellowToolStripMenuItem.Click
        penColor = Pens.Yellow
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        penColor = Pens.White
    End Sub
    'Ends program when 'quit' selected in menu
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        End
    End Sub
    'Loads default pen color to white
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        penColor = Pens.White
    End Sub
End Class
