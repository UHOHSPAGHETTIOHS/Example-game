using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float totalHP;
    public float HP;
    // Start is called before the first frame update
    void Awake()
    {
        HP = totalHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            HP -= PlayerVariables.playerDamage;
        }
    }


}
