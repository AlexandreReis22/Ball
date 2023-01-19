using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour
{
    private float pontos;
    [SerializeField]
    private Text _NumPontos;    

    void Start()
    {
        
    }

    
    void Update()
    {
        int pontsInt = (int)pontos;
        if (managerGame.iniciou)
        {
            pontos += 3f * Time.deltaTime;
        }
        _NumPontos.text = pontsInt.ToString();
    }
}
