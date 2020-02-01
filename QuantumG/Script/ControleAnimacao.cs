using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleAnimacao : MonoBehaviour
{
    Animator anim;
    [SerializeField] float velocidadeAnim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        InvokeRepeating("AlteraAnim", 1, 1);
    }
    
    void alteraAnim()
    {
        anim.speed = velocidadeAnim;

    }
}
