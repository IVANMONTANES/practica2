using EspacioCalculadora;
Calculadora calculadora = new Calculadora();
bool seguir = true;
do{
    Console.WriteLine("1 sumar");
    Console.WriteLine("2 restar");
    Console.WriteLine("3 multiplicar");
    Console.WriteLine("4 dividir");
    Console.WriteLine("5 limpiar");
    Console.WriteLine("6 salir");
    Console.WriteLine("eliga una opcion:");
    string opcionCadena = Console.ReadLine();
    int opcion = 0;
    if(int.TryParse(opcionCadena, out opcion)){
        if(opcion >= 1 && opcion <= 5){
            if(opcion != 5){
            Console.WriteLine("ingrese un numero");
            string numeroCadena = Console.ReadLine();
            double numero;
            if(double.TryParse(numeroCadena,out numero)){
                switch(opcion){
                    case 1: calculadora.Sumar(numero); break;
                    case 2: calculadora.Restar(numero); break;
                    case 3: calculadora.Multiplicar(numero); break;
                    case 4: calculadora.Dividir(numero); break;
                }
            }
            }else{
                calculadora.Limpiar();
            }
            Console.WriteLine("valor Actual: "+calculadora.Resultado);
        }else if(opcion == 6){
        Console.WriteLine("saliendo");
        seguir = false;
    }else{
        Console.WriteLine("no se indico una opcion valida");
    } 
    }else{
        Console.WriteLine("no se indico un numero");
    }
}while(seguir);
