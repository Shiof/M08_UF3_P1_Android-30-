using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public Texts textos;

    private void OnMouseDown()
    {
        FindObjectOfType<ControlDialogo>().ActivarCartel(textos);
    }

}
