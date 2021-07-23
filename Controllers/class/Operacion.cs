using System;
class Operacion{
    private Nodo cabecera;

    private Nodo referencia;
    private Nodo referencia2;
    private Nodo referenciaindice;
    private Nodo referenciabuscar;
    private Nodo refbuscarinsertar;

    public Operacion(){
        cabecera = new Nodo();
        cabecera.Siguiente = null;
    }

    public void Mostrar(){
        referencia = cabecera;
        while (referencia.Siguiente != null)
        {
            referencia = referencia.Siguiente;
            string d = referencia.Dato;
            Console.Write("{0} -> ", d);
        }
        Console.WriteLine();
    }

    public void Agregar(string pDato){
        referencia = cabecera;
        while (referencia.Siguiente != null){
            referencia = referencia.Siguiente;            
        }
        Nodo tpm = new Nodo();
        tpm.Dato += pDato;
        referencia.Siguiente = tpm;
    }    



    public Nodo Buscar(string pDato){

        referencia2 = cabecera;
        while (referencia2.Siguiente !=  null)
        {
            referencia2 = referencia2.Siguiente;
            if(referencia2.Dato == pDato){
                return referencia2;
            }
        }
        return null;
    }

    public Nodo BuscarAnterior(string pDato){
        referenciabuscar = cabecera;
        while (referenciabuscar.Siguiente != null && string.Compare(referenciabuscar.Siguiente.Dato, pDato) != 0)
        {
            referenciabuscar = referenciabuscar.Siguiente;
        }
        return referenciabuscar;

    }

    public int Buscarindice(string pDato){
        int indice = -1;
        referenciaindice = cabecera;
        while (referenciaindice.Siguiente != null)
        {
            referenciaindice = referenciaindice.Siguiente;
            indice++;
            if (string.Compare(referenciaindice.Dato, pDato) == 0)
            {
                return indice;
            }
        }
        return -1;
    }

         public void Borrar(string pDato){
         Nodo nodoanterior = BuscarAnterior(pDato);
         Nodo nodoencontrado = Buscar(pDato);

         if (nodoencontrado == null){
             return;
         }
         nodoanterior.Siguiente = nodoencontrado.Siguiente;
         nodoencontrado.Siguiente = null;         
         
     }    
     
     public void Insertar(string pDonde,string pValor ){
         refbuscarinsertar = Buscar(pDonde);
         if (refbuscarinsertar == null)
         {
             return;
         }
         Nodo tmp = new Nodo();
         tmp.Dato = pValor;
         tmp.Siguiente = refbuscarinsertar.Siguiente;
         refbuscarinsertar.Siguiente = tmp;
     }     

}