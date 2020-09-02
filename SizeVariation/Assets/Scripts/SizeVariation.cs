using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeVariation : MonoBehaviour
{
    private Vector3 ScaleChangePositive, ScaleChangeNegative;
    public GameObject Player;
    void Awake()
    {
        ScaleChangePositive = new Vector3(0.1f, 0.1f, 0.1f);//sets value to change of scale increase
        ScaleChangeNegative = new Vector3(-0.1f, -0.1f, -0.1f);// sets value change of scale decrease
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "SizeIncreaser")// increases local scale
        {
            Player.transform.localScale += ScaleChangePositive;
        }
        else if(other.gameObject.tag == "SizeDecreaser")// decreases loacl scale
        {
            Player.transform.localScale += ScaleChangeNegative;
        }
    }
}
