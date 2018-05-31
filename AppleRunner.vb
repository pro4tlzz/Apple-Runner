Public Class Apple_Runner
    Dim xpos As Integer
    Dim ypos As Integer
    'Creates variables for use in moving sprite
    Dim collision As Boolean = False
    'Creates variable for use in detecting collision
    Dim current_score As Integer = 0
    'Creates variable for holding score

    Dim golden_apple As Boolean = False
    'Used for golden apple collison which stops the game
    Dim timercountdown As Integer = 50
    Dim SoundInst As New SoundClass




    Public Class SoundClass
        Declare Auto Function PlaySound Lib "winmm.dll" (ByVal name _
           As String, ByVal hmod As Integer, ByVal flags As Integer) As Integer
        'Name specifies the sound file when the SND_FILENAME flag is set.
        'Hmod specifies an executable file handle.
        'Hmod must be Nothing if the SND_RESOURCE flag is not set.
        'Flags specifies which flags are set. 

        'The PlaySound documentation lists all valid flags.
        Public Const SND_SYNC = &H0          'Play synchronously
        Public Const SND_ASYNC = &H1         'Play asynchronously
        Public Const SND_FILENAME = &H20000  'Name is file name
        Public Const SND_RESOURCE = &H40004  'Name is resource name or atom

        Public Sub PlaySoundFile(ByVal filename As String)
            'Plays a sound from filename.
            PlaySound(filename, Nothing, SND_FILENAME Or SND_ASYNC)
        End Sub
    End Class




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xpos = Me.PicSprite.Location.X
        ypos = Me.PicSprite.Location.Y

        'Reports X and Y details
    End Sub




    Private Sub MOVE_sprite_left()
        'Sets new point
        Me.PicSprite.Location = New Point(xpos, ypos)
        'Moves left by 3
        xpos = xpos - 3
        'Sets new point
        Me.PicSprite.Location = New Point(xpos, ypos)
        'Loads left sprite image
        Me.PicSprite.Image = My.Resources.man_going_left
    End Sub
    Private Sub MOVE_sprite_right()
        'Sets new point
        Me.PicSprite.Location = New Point(xpos, ypos)
        'Moves right by 3
        xpos = xpos + 3
        'Sets new point
        Me.PicSprite.Location = New Point(xpos, ypos)
        'Loads right sprite image
        Me.PicSprite.Image = My.Resources.man_going_right
    End Sub
    Private Sub MOVE_sprite_up()
        'Sets new point
        Me.PicSprite.Location = New Point(xpos, ypos)
        'Moves up by 3
        ypos = ypos - 3
        'Sets new point
        Me.PicSprite.Location = New Point(xpos, ypos)
        Me.PicSprite.Image = My.Resources.man_going_up
        'Loads upwards sprite image
    End Sub
    Private Sub MOVE_sprite_down()
        'Sets new point
        Me.PicSprite.Location = New Point(xpos, ypos)
        ypos = ypos + 3
        'Moves down by 3
        'Sets new point
        Me.PicSprite.Location = New Point(xpos, ypos)
        Me.PicSprite.Image = My.Resources.man_going_down
        'Loads downwards sprite image
    End Sub



    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxKeyInput.KeyDown
        If PicSprite.Bounds.IntersectsWith(PictureBox1.Bounds) Then
            'Controls sprite collision with apple
            'Sets collision to true
            collision = True
            current_score = current_score + 100
            'Adds score
            Me.LabelScore.Text = current_score
            'Outputs score
            collision = False
            'Sets collision to false to stop looping
            'Plays sound
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox1.Visible = False
            'Hides apple
            Me.PictureBox1.Top = -100000000
            'Moves apple out of collision range
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox2.Visible = False
            Me.PictureBox2.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox3.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox3.Visible = False
            Me.PictureBox3.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox4.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox4.Visible = False
            Me.PictureBox4.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox5.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox5.Visible = False
            Me.PictureBox5.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox6.Visible = False
            Me.PictureBox6.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox7.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox7.Visible = False
            Me.PictureBox7.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox8.Visible = False
            Me.PictureBox8.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox9.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox9.Visible = False
            Me.PictureBox9.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox10.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox10.Visible = False
            Me.PictureBox10.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox11.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox11.Visible = False
            Me.PictureBox11.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox12.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox12.Visible = False
            Me.PictureBox12.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox13.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox13.Visible = False
            Me.PictureBox13.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox14.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox14.Visible = False
            Me.PictureBox14.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox15.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox15.Visible = False
            Me.PictureBox15.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox16.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox16.Visible = False
            Me.PictureBox16.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox17.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox17.Visible = False
            Me.PictureBox17.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox18.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox18.Visible = False
            Me.PictureBox18.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox19.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox19.Visible = False
            Me.PictureBox19.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox20.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox20.Visible = False
            Me.PictureBox20.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox21.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox21.Visible = False
            Me.PictureBox21.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox22.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox22.Visible = False
            Me.PictureBox22.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox23.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox23.Visible = False
            Me.PictureBox23.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox24.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox24.Visible = False
            Me.PictureBox24.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox25.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox25.Visible = False
            Me.PictureBox25.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox26.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox26.Visible = False
            Me.PictureBox26.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox27.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox27.Visible = False
            Me.PictureBox27.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox28.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox28.Visible = False
            Me.PictureBox28.Top = -100000000
        End If

        If PicSprite.Bounds.IntersectsWith(PictureBox29.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox29.Visible = False
            Me.PictureBox29.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox30.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox30.Visible = False
            Me.PictureBox30.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox31.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox31.Visible = False
            Me.PictureBox31.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox32.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox32.Visible = False
            Me.PictureBox32.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox33.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox33.Visible = False
            Me.PictureBox33.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox34.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox34.Visible = False
            Me.PictureBox34.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox35.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox35.Visible = False
            Me.PictureBox35.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox36.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox36.Visible = False
            Me.PictureBox36.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox37.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox37.Visible = False
            Me.PictureBox37.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox38.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox38.Visible = False
            Me.PictureBox38.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox39.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox39.Visible = False
            Me.PictureBox39.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox40.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox40.Visible = False
            Me.PictureBox40.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox41.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox41.Visible = False
            Me.PictureBox41.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox42.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox42.Visible = False
            Me.PictureBox42.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox43.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox43.Visible = False
            Me.PictureBox43.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox44.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox44.Visible = False
            Me.PictureBox44.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox45.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox45.Visible = False
            Me.PictureBox45.Top = -100000000
        End If

        If PicSprite.Bounds.IntersectsWith(PictureBox46.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox46.Visible = False
            Me.PictureBox46.Top = -100000000
        End If

        If PicSprite.Bounds.IntersectsWith(PictureBox47.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox47.Visible = False
            Me.PictureBox47.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox48.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox48.Visible = False
            Me.PictureBox48.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox49.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox49.Visible = False
            Me.PictureBox49.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox50.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox50.Visible = False
            Me.PictureBox50.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox51.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox51.Visible = False
            Me.PictureBox51.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox52.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox52.Visible = False
            Me.PictureBox52.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox53.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox53.Visible = False
            Me.PictureBox53.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox54.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox54.Visible = False
            Me.PictureBox54.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox55.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox55.Visible = False
            Me.PictureBox55.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox56.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox56.Visible = False
            Me.PictureBox56.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox57.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox57.Visible = False
            Me.PictureBox57.Top = -100000000
        End If

        If PicSprite.Bounds.IntersectsWith(PictureBox58.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox58.Visible = False
            Me.PictureBox58.Top = -100000000
        End If

        If PicSprite.Bounds.IntersectsWith(PictureBox59.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox59.Visible = False
            Me.PictureBox59.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox60.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox60.Visible = False
            Me.PictureBox60.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox61.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox61.Visible = False
            Me.PictureBox61.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox62.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox62.Visible = False
            Me.PictureBox62.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox63.Bounds) Then
            collision = True
            current_score = current_score + 100
            Me.LabelScore.Text = current_score
            collision = False
            My.Computer.Audio.Play(My.Resources.Mario_Coin, AudioPlayMode.Background)
            Me.PictureBox63.Visible = False
            Me.PictureBox63.Top = -100000000
        End If
        If PicSprite.Bounds.IntersectsWith(PictureBox64.Bounds) Then
            'Plays sound and stops timers, this hides Golden_Apple PictureBox and moves it out of range
            My.Computer.Audio.Play(My.Resources.mario_level_complete, AudioPlayMode.Background)
            TimerDown.Enabled = False
            TimerDown.Stop()
            TimerRemaining.Stop()
            TimerRemaining.Enabled = False
            'Controls collison with golden apple
            'Sets collision to true
            collision = True
            'Outputs score
            Me.LabelScore.Text = current_score

            'Shows game over message
            MessageBox.Show("Well done, you have completed the game and you scored " & current_score)
            'Disables collision
            collision = False
            'Hides golden apple
            Me.PictureBox64.Visible = False
            'Moves golden apple out of range
            Me.PictureBox64.Top = -100000000
            'Sets golden apple to true
            golden_apple = True
            'Ends game
            End
        End If

        If PicSprite.Bounds.IntersectsWith(Label1.Bounds) Then
            'Shows game over message and stops timers

            'Stops timerdown which controls Countdown
            TimerDown.Stop()
            'Stops actual Timer which the game uses to stop the game
            TimerRemaining.Stop()
            MessageBox.Show("Game Over")
            'Ends game
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label2.Bounds) Then
            TimerRemaining.Stop()


            TimerDown.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label3.Bounds) Then
            TimerDown.Stop()


            TimerRemaining.Stop()
            MessageBox.Show("Game Over")
            End
        End If

        If PicSprite.Bounds.IntersectsWith(Label4.Bounds) Then
            TimerRemaining.Stop()


            TimerDown.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label5.Bounds) Then
            TimerRemaining.Stop()



            TimerDown.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label6.Bounds) Then
            TimerDown.Stop()


            TimerRemaining.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label7.Bounds) Then
            TimerRemaining.Stop()

            TimerDown.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label8.Bounds) Then
            TimerDown.Stop()


            TimerRemaining.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label9.Bounds) Then
            TimerRemaining.Stop()


            TimerDown.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label10.Bounds) Then
            TimerDown.Stop()

            TimerRemaining.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label11.Bounds) Then
            TimerRemaining.Stop()


            TimerDown.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label12.Bounds) Then
            TimerDown.Stop()

            TimerRemaining.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label13.Bounds) Then
            TimerDown.Stop()

            TimerRemaining.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label14.Bounds) Then
            TimerDown.Stop()


            TimerRemaining.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label15.Bounds) Then
            TimerRemaining.Stop()


            TimerDown.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label16.Bounds) Then
            TimerRemaining.Stop()

            TimerDown.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label17.Bounds) Then
            TimerDown.Stop()

            TimerRemaining.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label18.Bounds) Then
            TimerRemaining.Stop()


            TimerDown.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label19.Bounds) Then
            TimerDown.Stop()

            TimerRemaining.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label20.Bounds) Then
            TimerDown.Stop()

            TimerRemaining.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label21.Bounds) Then
            TimerRemaining.Stop()

            TimerDown.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label22.Bounds) Then
            TimerDown.Stop()

            TimerRemaining.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label23.Bounds) Then
            TimerDown.Stop()

            TimerRemaining.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label24.Bounds) Then
            TimerDown.Stop()

            TimerRemaining.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label25.Bounds) Then
            TimerDown.Stop()

            TimerRemaining.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label26.Bounds) Then
            TimerDown.Stop()

            TimerRemaining.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label27.Bounds) Then
            TimerDown.Stop()

            TimerRemaining.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label28.Bounds) Then
            TimerDown.Stop()

            TimerRemaining.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label29.Bounds) Then
            TimerRemaining.Stop()

            TimerDown.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label30.Bounds) Then
            TimerDown.Stop()

            TimerRemaining.Stop()
            MessageBox.Show("Game Gver")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label31.Bounds) Then
            TimerRemaining.Stop()

            TimerDown.Stop()
            MessageBox.Show("Game Over")
            End
        End If
        If PicSprite.Bounds.IntersectsWith(Label32.Bounds) Then
            TimerDown.Stop()

            TimerRemaining.Stop()
            MessageBox.Show("Game Over")
            End
        End If



        'Moves sprite, user input required
        If e.KeyCode = Keys.Left Then
            MOVE_sprite_left()
        End If
        If e.KeyCode = Keys.Right Then
            MOVE_sprite_right()
        End If
        If e.KeyCode = Keys.Down Then
            MOVE_sprite_down()
        End If
        If e.KeyCode = Keys.Up Then
            MOVE_sprite_up()
        End If
        If e.KeyCode = Keys.A Then
            MOVE_sprite_left()
        End If
        If e.KeyCode = Keys.D Then
            MOVE_sprite_right()
        End If
        If e.KeyCode = Keys.S Then
            MOVE_sprite_down()
        End If
        If e.KeyCode = Keys.W Then
            MOVE_sprite_up()
        End If

    End Sub





    Private Sub TimerRE_Tick(sender As Object, e As EventArgs) Handles TimerRemaining.Tick


        'When time is over the timer is disabled and message is displayed
        TimerRemaining.Enabled = False

        MessageBox.Show("Out of Time")

        End

    End Sub


    Private Sub TimerDown_Tick(sender As Object, e As EventArgs) Handles TimerDown.Tick
        'Uses TimerCountDown variable to minus 1 at a rate of every second to give the illusion of a countdown, Default Value is 50 in the form which means it counts down from 50
        timercountdown = timercountdown - 1
        'Outputs Timer Countdown to Label
        Me.LabelTimeLeft.Text = timercountdown
        'Stops timerdown when countdown reaches 0 and disables it
        If timercountdown = 0 Then
            TimerDown.Enabled = False
            TimerDown.Stop()
        End If
        'Stops timerdown when Golden_Apple = True, also disables timer
        If golden_apple = True Then
            TimerDown.Enabled = False
            TimerDown.Stop()
        End If


    End Sub





    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PicSprite_Click(sender As Object, e As EventArgs) Handles PicSprite.Click

    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs) Handles Label35.Click

    End Sub
End Class

