/*Un balde en este juego tiene distintas caractersticas como ser la capacitad total del
mismo, la cantidad de liquido que hay en su interior ( que no puede ser mayor a la
capacidad del balde) y un color. 

Estas caractersticas (capacidad ) de cada balde no pueden estar "hardcodeadas" dentro de la clase sino que deben ser atributos que se puedan congurar por parametros (en el constructor, por ejemplo) ya que durante el juego se usaran distintos baldes.
Tambien se pide implementar algunos metodos como determinar si esta vaco, 
si esta lleno, 
metodos para agregarle liquido al balde,
algunos constructores y un metodo muy especial llamado vuelcaEn(Balde destino)
que vuelva el contenido del balde actual en el balde destino, sin que se pierda nada del liquido, claro. Ademas, 
*****************************************************************************************
se necesita que tenga un metodo que pueda mostrar en pantalla mediante un dibujo simple cuanta capacidad tiene el balde y cuanto liquido tiene.
*/
class Balde{
 double capacidad;
 double contenido;
 string color;
double resta; 
 public Balde(double cap, double cont, string color){
    capacidad = cap;
    this.color = color;
    contenido = cont;
    resta = capacidad-contenido;
    if(contenido > capacidad){
        contenido= 0;
        Console.WriteLine("El balde no puede contener mas de: "+capacidad);
    }
 }
    public override string ToString()
    {
        return $"El balde es {color}, tiene una capacidad de {capacidad} lts y contiene {contenido} lts.";
    }
    public void baldeVacio(){
        if(contenido == capacidad) {
        Console.WriteLine($"balde {color} lleno");
        Console.WriteLine($"|----------|");
        Console.WriteLine($"|----------|");
        Console.WriteLine($"|----------|");
        Console.WriteLine($"|----------|");
        
        }else if (contenido < 0 || contenido == 0 ) {
        Console.WriteLine($"balde {color} vacio");//mejorar
        Console.WriteLine($"|          |");
        Console.WriteLine($"|          |");
        Console.WriteLine($"|          |");
        Console.WriteLine($"|          |");
        }
                 
    }
    public void agregar(double cant){
        if((cant <= resta)  && cant <= capacidad){
        contenido += cant; 
        Console.WriteLine($"se le agregaron {cant} lts., ahora el balde {color} tiene un contenido de:{contenido} lts.");
        }else{
            Console.WriteLine($"No se puede cargar más liquido en el balde {color}");
            Console.WriteLine($"Se intento agregar {cant} lts en el balde {color} y sólo se pueden agregar {resta} lts");
        }
    }
    public void quitar(double cant){
        double saldo=0;
        if(cant <= contenido && contenido > 0){
        saldo = contenido -= cant;
        Console.WriteLine($"Le quitamos {cant} lts. al balde {color}, y nos quedan {saldo} lts.");
        } else{
            Console.WriteLine($"No se le pueden quitar {cant} lts. al balde {color}, de {contenido} lts");
            
        }
        
    }
    public void vuelcaEn(Balde x, Balde y, double paso){
        Console.WriteLine(x.ToString());
        Console.WriteLine(y.ToString());
        x.quitar(paso);
        y.agregar(paso); 
    }
}
