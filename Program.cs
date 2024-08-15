using clases;
void MostrarDatos(Empleado empleado){
    Console.WriteLine("-----------EMPLEADO MAS PROXIMO A JUBILARSE------------");
    Console.WriteLine("nombre completo: "+empleado.nombre+" "+empleado.apellido);
    Console.WriteLine("fecha de nacimiento: "+empleado.fechaNac.ToString("dd/MM/yyyy"));
    if(empleado.estadoCivil == 'C'){
        Console.WriteLine("Estado civil: CASADO");
    }else{
        Console.WriteLine("Estado Civil: SOLTERO");
    }
    Console.WriteLine("fecha de ingreso a la empresa: "+empleado.fechaIngreso.ToString("dd/MM/yyyy"));
    Console.WriteLine("Cargo: "+empleado.cargo);
    empleado.antiguedad();
    empleado.edad();
    empleado.calcular_Jubilacion();
}

Empleado[] empleados = new Empleado[3];
 empleados[0] = new Empleado("ivan","montañes",new DateTime(2005,1,27),'S',new DateTime(2023,8,15),650000,Cargos.Especialista);
 empleados[1] = new Empleado("santiago","gonzales",new DateTime(1988,1,27),'C',new DateTime(1999,3,27),550000,Cargos.Ingeniero);
 empleados[2] = new Empleado("bruno","galvan",new DateTime(1986,4,6),'C',new DateTime(2001,7,2),600000,Cargos.Auxiliar);
double totalSalarios = 0;
int indice = 0,contador = 0,auxiliar = 999;
//usamos el bucle foreach para calcular los salarios y el mas proximo a jubilarse//
foreach(var empleado in empleados){
    empleado.calcular_Jubilacion();
    if(empleado.jubilacion <= auxiliar){
        auxiliar = empleado.jubilacion;
        indice = contador;
    }
    empleado.Calcular_salario();
    totalSalarios += empleado.salario;
    contador++;
}
Console.WriteLine("monto total a pagar $"+totalSalarios);
MostrarDatos(empleados[indice]);



