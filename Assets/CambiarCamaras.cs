using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CambiarCamaras : MonoBehaviour
{
    
    public CinemachineVirtualCamera[] camaras;

    int index = 0;

    private void Start()
    {
        ModificarPrioridad(0);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(index == camaras.Length-1)
                index = 0;
            else
                index++;

            ModificarPrioridad(index);
        }
        if( Input.GetKey(KeyCode.LeftArrow))
        {
            if(index == 0)
                index = camaras.Length-1;
            else
                index--;

            ModificarPrioridad(index);
        }




    }

    void ModificarPrioridad(int _index)
    {
        for(int i = 0; i<camaras.Length; i++)
        {
            camaras[i].Priority = i == _index? 1:0;
        }
    }


    

}
