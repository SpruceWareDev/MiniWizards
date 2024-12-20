Public Class Game

    Public Const NAME As String = "Mini Wizards"
    Public Const VERSION As String = "0.0.1-ALPHA"

    Private _form As GameForm
    Private WithEvents _ticker As Timer

    Public Sub Initialize(form As GameForm)
        _form = form
        ' Setup Form
        With _form
            .FormBorderStyle = FormBorderStyle.FixedSingle
            .Text = $"{NAME} ({VERSION})"
        End With

        ' Setup Renderer
        Renderer.GetInstance().Initialize(_form)

        ' Setup Ticker
        _ticker = New Timer()
        With _ticker
            .Interval = 1000 / 60D
        End With
        _ticker.Start()
    End Sub

    Private Sub OnTick(sender As Object, e As EventArgs) Handles _ticker.Tick
        Renderer.GetInstance().Render()
    End Sub

    Public Sub OnClose()

    End Sub
End Class
