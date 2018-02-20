/* Lista enlazada (no ordenada) en C */
 
#include <stdio.h>
#include <stdlib.h>
 
struct lista               /* Nuestra lista */
{
    int numero;             /* Solo guarda un numero */
    struct lista* sig;      /* Y el puntero al siguiente dato */
};
 
struct lista* CrearLista(int valor)  /* Crea la lista, claro */
{
    struct lista* r;        /* Variable auxiliar */
    r = (struct lista*) 
        malloc (sizeof(struct lista)); /* Reserva memoria */                           
    r->numero = valor;      /* Guarda el valor */
    r->sig = NULL;          /* No hay siguiente */
    return r;               /* Crea el struct lista* */
}
 
void MostrarLista ( struct lista *lista ) 
{
    if (lista) {                          /* Si realmente hay lista */
        printf("%d\n", lista->numero);    /* Escribe el valor */
        MostrarLista (lista->sig );       /* Y mira el siguiente */
    }
}
 
void InsertarLista( struct lista **lista, int valor) 
{
    struct lista* r;        /* Variable auxiliar, para reservar */
    struct lista* actual;   /* Otra auxiliar, para recorrer */
    
    r = CrearLista(valor);  /* Creamos un nuevo nodo */
    actual = *lista;        /* Y partimos desde el princio */
    
    if (!actual)                           
    {                       /* Si no hay lista, hay que crearla */
        *lista = r;         /* y hay que indicar donde debe comenzar */
    }
    else                    /*  Si hay lista */
    {
        while (actual->sig)
            actual = actual->sig;  /* Avanzo hasta el final */
        actual->sig = r;           /* Y el nuevo nodo será el final */
    }
}
 
int main() 
{
    struct lista* l;               /* La lista que crearemos */
    l = CrearLista(5);             /* Crea una lista e introduce un 5 */
    InsertarLista(&l, 3);          /* Inserta un 3 */
    InsertarLista(&l, 2);          /* Inserta un 2 */
    InsertarLista(&l, 6);          /* Inserta un 6 */
    MostrarLista(l);               /* Muestra la lista resultante */
    return 0;                      /* Se acabó */
}
