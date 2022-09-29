using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateState : MonoBehaviour
{
    public void UpdateState2()
    {
        if (GetComponent<Animator>().GetInteger("State") == 3)
        {
            GetComponent<Animator>().SetInteger("State", 0);
        }

        else
        {
            GetComponent<Animator>().SetInteger("State", GetComponent<Animator>().GetInteger("State") + 1);
        }
    }
}