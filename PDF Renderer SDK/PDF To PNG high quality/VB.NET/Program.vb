'*******************************************************************
'       ByteScout PDF Renderer SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************


Imports Bytescout.PDFRenderer


Class Program
	Friend Shared Sub Main(args As String())

        ' Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
		Dim renderer As New RasterRenderer()
		renderer.RegistrationName = "demo"
		renderer.RegistrationKey = "demo"


		' set high quality resolution 600 dpi (600 dots per inch)
		renderer.Resolution = 600


		' Load PDF document.
		renderer.LoadDocumentFromFile("multipage.pdf")

		For i As Integer = 0 To renderer.GetPageCount() - 1
			' Render first page of the document to PNG image file.
			renderer.RenderPageToFile(i, RasterOutputFormat.PNG, "image" & i & ".png")
		Next

		' Open the first output file in default image viewer.
		System.Diagnostics.Process.Start("image0.png")
	End Sub
End Class
