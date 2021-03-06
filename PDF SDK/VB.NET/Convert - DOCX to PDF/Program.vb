'*******************************************************************
'       ByteScout PDF SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.PDF.Converters

''' <summary>
''' This example demonstrates how to convert Microsoft Word DOCX document to PDF document.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create converter instance
        Using converter As New DocxToPdfConverter()

            ' Perform conversion
            converter.ConvertDocxToPdf("sample.docx", "result.pdf")

        End Using

        ' Open result document in default PDF viewer
        Process.Start("result.pdf")

    End Sub

End Class
