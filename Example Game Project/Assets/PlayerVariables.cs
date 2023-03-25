using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVariables : MonoBehaviour
{
    public static bool isHitting;
    public static float playerDamage;

    private void Update()
    {
        if (isHitting)
        {
            playerDamage = 50;
        }
    }
}
