using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OlhePara : MonoBehaviour
{
    private Transform jogador;
    // Start is called before the first frame update
    void Start()
    {
        jogador = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(jogador);
    }
}
