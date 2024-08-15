using System.Security.Cryptography;

namespace clases;

public enum Cargos{
    Auxiliar = 0,
    Administrativo = 1,
    Ingeniero = 2,
    Especialista = 3,
    Investigador = 4
}
public class Empleado{
    private string Nombre;
    private string Apellido;
    private DateTime FechaNac;
    private char EstadoCivil;
    private DateTime FechaIngreso;
    private double SueldoBasico;
    private Cargos Cargo;
    private int Edad;
    private int Antiguedad;
    private double Salario;
    private int Jubilacion;

    public Empleado(string nombre, string apellido, DateTime fechaNac, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
    {
        Nombre = nombre;
        Apellido = apellido;
        FechaNac = fechaNac;
        EstadoCivil = estadoCivil;
        FechaIngreso = fechaIngreso;
        SueldoBasico = sueldoBasico;
        Cargo = cargo;
    }

    public string nombre { get => Nombre; set => Nombre = value; }
    public string apellido { get => Apellido; set => Apellido = value; }
    public DateTime fechaNac { get => FechaNac; set => FechaNac = value; }
    public char estadoCivil { get => EstadoCivil; set => EstadoCivil = value; }
    public DateTime fechaIngreso { get => FechaIngreso; set => FechaIngreso = value; }
    public double sueldoBasico { get => SueldoBasico; set => SueldoBasico = value; }
    public double salario { get => Salario; set => Salario = value; }
    internal Cargos cargo { get => Cargo; set => Cargo = value; }
    public int jubilacion { get => Jubilacion; set => Jubilacion = value; }


    //metodos//
    public void antiguedad(){
        DateTime fechaActual = DateTime.Now;
         Antiguedad = fechaActual.Year - FechaIngreso.Year;
        if(fechaActual.Month < FechaIngreso.Month){
            Antiguedad--;
        }else if(fechaActual.Month == FechaIngreso.Month){
            if(fechaActual.Day < fechaIngreso.Day){
                Antiguedad--;
            }
        }
        Console.WriteLine("antiguedad del empleado: "+Antiguedad+" años");
    }

    public void edad(){
        DateTime fechaActual = DateTime.Now;
        Edad = fechaActual.Year-FechaNac.Year;
        if(fechaActual.Month < fechaNac.Month){
            Edad--;
        }else if(fechaActual.Month == FechaNac.Month){
            if(fechaActual.Day < FechaNac.Day){
                Edad--;
            }
        }
        Console.WriteLine("edad del empleado: "+Edad+" años");
    }

    public void calcular_Jubilacion(){
        Jubilacion = 65 - Edad;
        Console.WriteLine("le faltan "+jubilacion+" años para jubilarse");
    }

    public void Calcular_salario(){
        
        double adicional = 0;
        //aumento segun antiguedad//
            if(Antiguedad <= 20){
                adicional = (Antiguedad *SueldoBasico)/100;
            }else{
                adicional = (25*SueldoBasico)/100;
            }
        //aumento segun cargo//
            if((int)Cargo == 2 || (int)Cargo == 3){
                adicional *= 1.5;
            }
        //aumento segun estado civil//
            if(EstadoCivil == 'C'){
                adicional += 150000;
            }
        Salario = sueldoBasico+adicional;
        
    }
}