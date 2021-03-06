//*******************************************************************
//       ByteScout PDF SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System.Diagnostics;
using Bytescout.PDF.Converters;

namespace ConvertHtmlToPdf
{
	/// <summary>
	/// This example demonstrates how to convert HTML file to PDF document.
	/// </summary>
	class Program
	{
		static void Main()
		{
            // Create converter instance
            using (HtmlToPdfConverter converter = new HtmlToPdfConverter())
		    {
                // Perform conversion
		        converter.ConvertHtmlToPdf("sample.html", "result.pdf");
		    }

		    // Open result document in default PDF viewer
		    Process.Start("result.pdf");
		}
	}
}
