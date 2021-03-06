'*******************************************************************
'       ByteScout PDF SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.IO
Imports Bytescout.PDF.Converters

''' <summary>
''' This example demonstrates how to convert Microsoft Word DOCX document to HTML file.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create converter instance
        Using converter As New DocxToHtmlConverter()

            ' Perform conversion
            converter.ConvertDocxToHtml("sample.docx", "result.html", False)

        End Using

        ' Open result document in Internet Explorer
        Process.Start("iexplore.exe", Path.GetFullPath("result.html"))

    End Sub

End Class
