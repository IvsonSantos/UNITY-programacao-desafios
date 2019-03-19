using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayNaoNulo : MonoBehaviour
{

    int[] array = { 1, 2, 3, 4, 5};

    // Start is called before the first frame update
    void Start()
    {
        retornaArray();
        mudaArray();
        retornaArray();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void retornaArray()
    {
        foreach(int i in array)
        {
            print(i);
        }
    }

    void mudaArray()
    {
        int[] novo = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        this.array = novo;
    }
}
