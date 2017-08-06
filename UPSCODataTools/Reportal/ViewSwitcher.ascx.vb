Imports Microsoft.AspNet.FriendlyUrls.Resolvers

Partial Class ViewSwitcher
    Inherits System.Web.UI.UserControl
    Protected Property CurrentView() As String
        Get
            Return m_CurrentView
        End Get
        Private Set(value As String)
            m_CurrentView = value
        End Set
    End Property
    Private m_CurrentView As String

    Protected Property AlternateView() As String
        Get
            Return m_AlternateView
        End Get
        Private Set(value As String)
            m_AlternateView = value
        End Set
    End Property
    Private m_AlternateView As String

    Protected Property SwitchUrl() As String
        Get
            Return m_SwitchUrl
        End Get
        Private Set(value As String)
            m_SwitchUrl = value
        End Set
    End Property
    Private m_SwitchUrl As String

    Protected Sub Page_Load(sender As Object, e As EventArgs)
        ' Determine current view

    End Sub
End Class
