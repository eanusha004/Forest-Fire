using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPlay : MonoBehaviour
{

    public ForestFire3D forestFire;
    public Countdown countdown;

    public float BurningTime = 20f;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player")) 
        {
             
            
            countdown.CurrentTime += BurningTime;
            countdown.Timerrunning = true;
            forestFire.gameRunning = false;
            forestFire.PutOutFire();
            Destroy(gameObject);

        }
    }

}