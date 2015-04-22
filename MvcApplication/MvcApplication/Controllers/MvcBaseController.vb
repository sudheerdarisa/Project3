'Imports System.Globalization
'Imports System.Diagnostics.Eventing.Reader
Imports System.Globalization


Namespace mvc.application
    Public Class MvcBaseController
        Inherits System.Web.Mvc.Controller

        Sub New()
            MyBase.New()

            ViewData("UniqueID") = New Random().Next()

            SetCustomCultureInfo()

        End Sub

#Region "Private Methods"

        Private Shared Sub SetCustomCultureInfo()
            Dim customCulture As CultureInfo = New CultureInfo("en-US")

            'HH means 24 hour time, while hh means 12 hour time
            customCulture.DateTimeFormat.LongDatePattern = "MM/dd/yyyy"
            customCulture.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
            customCulture.DateTimeFormat.ShortTimePattern = "hh:mm:ss"
            customCulture.DateTimeFormat.LongTimePattern = ""

            Threading.Thread.CurrentThread.CurrentCulture = customCulture
            Threading.Thread.CurrentThread.CurrentUICulture = customCulture
        End Sub

#End Region


        ''
        '' GET: /MvcBase

        'Function Index() As ActionResult
        '    Return View()
        'End Function

    End Class
End Namespace