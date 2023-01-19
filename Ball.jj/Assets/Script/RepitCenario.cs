using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepitCenario : MonoBehaviour
{
    public cenarioManager _cenarioManager;
    public bool chaoIns;
    public float vel;


    private void Start()
    {
        _cenarioManager = FindObjectOfType(typeof(cenarioManager)) as cenarioManager;
    }
    void Update()
    {
        vel = cenarioManager.velChao;
        if (!chaoIns)
        {
            if (transform.position.x <= 0)
            {
                chaoIns = true;
                GameObject objTempChao = Instantiate(_cenarioManager.cenario);
                objTempChao.transform.position = new Vector3(transform.position.x + _cenarioManager.chaoTam, transform.position.y, 0);
            }
        }
        if(transform.position.x <= _cenarioManager.chaoDes) 
        {
            Destroy(this.gameObject);
        }

    }

    void FixedUpdate()
    {
        movechao();
    }

    void movechao()
    {
        transform.Translate(Vector2.left * cenarioManager.velChao * Time.deltaTime);
    }

}
