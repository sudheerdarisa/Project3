Public Class AdministrationAreaRegistration
    Inherits AreaRegistration

    Public Overrides ReadOnly Property AreaName As String
        Get
            Return "Administration"
        End Get
    End Property

    Public Overrides Sub RegisterArea(ByVal context As System.Web.Mvc.AreaRegistrationContext)

        context.MapRoute("Administration_default", _
                         "Probation/{controller}/{action}/{id}", _
                         New With {.action = "Index", .id = UrlParameter.Optional}, _
                         Nothing, _
                         New String() {"my.mvc.application.Areas.Administration.Controllers"})
    End Sub

End Class
