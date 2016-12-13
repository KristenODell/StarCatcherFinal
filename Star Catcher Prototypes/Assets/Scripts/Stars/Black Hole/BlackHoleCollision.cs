using UnityEngine;
using System.Collections;

public class BlackHoleCollision : MonoBehaviour
{

    private StarCounter starCounter;


    void Awake()
    {
        starCounter = GameObject.Find("Star Counter").GetComponent<StarCounter>();
    }



    void OnTriggerEnter()
    {
        starCounter.starCount = starCounter.starCount - 3;
    }

}
