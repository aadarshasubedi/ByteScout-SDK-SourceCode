﻿'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.Spreadsheet
Imports Bytescout.Spreadsheet.Charts
Imports System.IO


Module Module1

    Sub Main()


			Try
				' create new Spreadsheet object
				Dim spreadsheet As New Spreadsheet()

				' add new worksheet
				Dim sheet As Worksheet = spreadsheet.Workbook.Worksheets.Add("Sample")

				' add a random numbers
				Dim length As Integer = 10
				Dim rnd As New Random()
				For i As Integer = 0 To length - 1
					sheet.Cell(i, 0).Value = rnd.[Next](1, 10)
				Next

				' add charts to worksheet
				Dim pieChart As Chart = sheet.Charts.AddChartAndFitInto(1, 3, 16, 9, ChartType.Pie)
				pieChart.SeriesCollection.Add(New Series(sheet.Range(0, 0, length - 1, 0)))

				pieChart = sheet.Charts.AddChartAndFitInto(1, 10, 16, 16, ChartType.Pie3D)
				pieChart.SeriesCollection.Add(New Series(sheet.Range(0, 0, length - 1, 0)))

				pieChart = sheet.Charts.AddChartAndFitInto(1, 17, 16, 23, ChartType.PieOfPie)
				pieChart.SeriesCollection.Add(New Series(sheet.Range(0, 0, length - 1, 0)))

				pieChart = sheet.Charts.AddChartAndFitInto(17, 3, 32, 9, ChartType.PieExploded)
				pieChart.SeriesCollection.Add(New Series(sheet.Range(0, 0, length - 1, 0)))

				pieChart = sheet.Charts.AddChartAndFitInto(17, 10, 32, 16, ChartType.PieExploded3D)
				pieChart.SeriesCollection.Add(New Series(sheet.Range(0, 0, length - 1, 0)))

				pieChart = sheet.Charts.AddChartAndFitInto(17, 17, 32, 23, ChartType.BarOfPie)
				pieChart.SeriesCollection.Add(New Series(sheet.Range(0, 0, length - 1, 0)))

				If File.Exists("Output.xls") Then
					File.Delete("Output.xls")
				End If

				' Save it as XLS
				spreadsheet.SaveAs("Output.xls")

				' close the document
				spreadsheet.Close()

				' open output XLS


				Process.Start("Output.xls")
			Catch e As Exception
				Console.WriteLine("CAN NOT EXECUTE: " & e.ToString())
				Console.WriteLine("" & Chr(10) & "Press any key to exit")
				Console.ReadKey()
			End Try


    End Sub

End Module