using System;
using System.Linq;

public class Vettore {
    private int[] vettore;//parametro privato
    private int idx = 0;//parametro privato

    //costruttore vuoto che crea un vettore inizializzato zero 
    public Vettore()
    {
        vettore = new int[1];
        vettore[0] = 0;  
    }
   
    //costruttore che crea un vettore N interi
    public Vettore(int N)
    {
        //in caso n è negativo
        if(N <= 0)
            vettore = new int[0];
        else
            vettore = new int[N];
    }

    //metodo bool che aggiunge sempre in fondo il valore val e dice false se non ci riesce
    public bool Aggiungi( int val )
    {
        if(idx >= vettore.Length)
            return false;
        vettore[idx] = val;
        idx++;

        return true;
    }

    //metodo somma elementi
    public int Somma()
    {
        int retVal = 0;
        for(int idx = 0; idx < vettore.Length; idx++)
            retVal += vettore[idx];

        return retVal;
    }

    //metodo ultimo valore inserito
    public int Ultimo()
    {
        if(vettore.Length == 0)
            return 0;
            
        if(idx == 0)
            return vettore[idx];
        
        return vettore[idx-1];
    }

}