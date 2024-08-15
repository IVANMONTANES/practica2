namespace EspacioCalculadora;

public class Calculadora{
    //campo dato//
    private double dato;

    //propiedad para obtener el valor del dato//
    public double Resultado
    {
        get => dato;
    }

    //definimos los metodos//
    public void Sumar(double termino){
        dato += termino;
    }
    public void Restar(double termino){
        dato -= termino;
    }
    public void Multiplicar(double termino){
        dato *= termino;
    }
    public void Dividir(double termino){
        if(termino == 0){
            Console.WriteLine("no se puede dividir en cero");
        }else{
            dato /= termino;
        }
        
    }
    public void Limpiar(){
        dato = 0;
    }

}