using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlDialogo : MonoBehaviour
{
    private Queue<string> colaDialogos;
    Texts texto;
    [SerializeField] Text textoPantalla;

    public void ActivarCartel(Texts textoObjeto)
    {
        texto = textoObjeto;
    }

    public void ActivaTexto()
    {
        colaDialogos.Clear();
        foreach (string textoGuardar in texto.arrayTextos)
        {
            colaDialogos.Enqueue(textoGuardar);
        }
        SiguienteFrase();
    }

    public void SiguienteFrase()
    {
        if (colaDialogos.Count == 0)
        {
            CierraCartel();
            return;
        }

        string fraseActual = colaDialogos.Dequeue();   
        textoPantalla.text = fraseActual;
       
    }

    void CierraCartel()
    {

    }

}
