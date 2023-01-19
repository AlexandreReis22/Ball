using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerGame: MonoBehaviour
{
    public static bool iniciou;    

    private void Update()
    {
        if (iniciou)
        {
            cenarioManager.velChao += 0.1f * Time.deltaTime;
        }
    }
}
