using System;

class Nodo{
    //los datos que vamos a almacenar
    private string dato;
    
    //crear un avariable (referenciaal nodo siguiente)
    private Nodo siguiente = null;
    
    //propiedades setter y getter
    public string Dato {get => dato ; set=> dato = value; }
    
    internal Nodo Siguiente { get => siguiente; set => siguiente = value;}

    //ver mas facil
    public override string ToString()
    {
        return string.Format("[{0}]",dato);

    }

}