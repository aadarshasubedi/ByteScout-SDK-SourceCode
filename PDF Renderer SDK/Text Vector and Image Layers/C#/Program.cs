//*******************************************************************
//       ByteScout PDF Renderer SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;

using Bytescout.PDFRenderer;


namespace PDF2PNG
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
			RasterRenderer renderer = new RasterRenderer();
			renderer.RegistrationName = "demo";
			renderer.RegistrationKey = "demo";

			// enable text layer rendering
			renderer.TextLayerEnabled = true;
			// DISABLE vector rendering
			renderer.VectorLayerEnabled = true;
			// DISABLE image layer rendering
			renderer.ImageLayerEnabled = true;
			

			// Load PDF document.
			renderer.LoadDocumentFromFile("multipage.pdf");

			for (int i = 0; i < renderer.GetPageCount(); i++)
			{
				// Render first page of the document to PNG image file.
				renderer.RenderPageToFile(i, RasterOutputFormat.PNG, "image" + i + ".png");
			}

			// Open the first output file in default image viewer.
			System.Diagnostics.Process.Start("image0.png");
		}
	}
}
