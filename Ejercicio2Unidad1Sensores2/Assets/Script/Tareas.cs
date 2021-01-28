using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tareas : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        Tarea1();
        Tarea2();
        Tarea3();
    }

    void Tarea1() {
        Debug.Log("tarea uno completa");
    }

    void Tarea2() { Debug.Log("tarea dos completa"); }

    void Tarea3() { Debug.Log("tarea tres completa"); }
}
