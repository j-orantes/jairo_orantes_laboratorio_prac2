Module Module1

	Sub Main()
		Dim opcion As Integer = 0
		Dim num1, num2 As Decimal
		Dim suma As Decimal
		Dim resta As Decimal
		Dim producto As Decimal
		Dim division As Decimal
		Console.Write("Ingrese el primer número: ")
		num1 = Console.ReadLine
		Console.Write("Ingrese el segundo número: ")
		num2 = Console.ReadLine
		Console.WriteLine("¿Qué operacion desea realizar? | Suma = 1 | Resta = 2 | Producto = 3 | División = 4 | Salir = 5 |")
		opcion = Console.ReadLine()
		If opcion = 1 Then
			suma = num1 + num2
			Console.WriteLine("Suma = " & suma)
		Else
			If opcion = 2 Then
				resta = num1 - num2
				Console.WriteLine("Resta = " & resta)
			Else
				If opcion = 3 Then
					producto = num1 * num2
					Console.WriteLine("Producto = " & producto)
				Else
					If opcion = 4 Then
						producto = num1 / num2
						Console.WriteLine("División = " & division)
					Else
						Console.WriteLine("Bye")
					End If

				End If
			End If

		End If

	End Sub






End Module
