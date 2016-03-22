﻿'*******************************************************************
'       ByteScout SWF To Video SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode

Imports System.Diagnostics
Imports BytescoutSWFToVideo

Class Program
	Friend Shared Sub Main(args As String())
		' Create an instance of SWFToVideo ActiveX object
		Dim converter As New SWFToVideo()

		' Set debug log
		'converter.SetLogFile("log.txt");

		' Register SWFToVideo
		converter.RegistrationName = "demo"
		converter.RegistrationKey = "demo"

		' Enable trasparency - set BEFORE setting input SWF filename
		converter.RGBAMode = True

        ' Set input SWF file
       	converter.InputSWFFileName = "Shapes.swf"
	

		' Extract all frames to .\Output sub-folder
		converter.ConvertAllToPNG(".\Output")

	' release resources
	System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)
	converter = null


		' Open the first extracted frame in default application
		Process.Start("frame0.png")
	End Sub
End Class