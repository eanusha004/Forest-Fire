using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    public float CurrentTime = 0f;
    public float StartingTime = 20f;
    public TMP_Text CountdownText;
    public ForestFire3D forestFire;

    public bool Timerrunning;


    // Start is called before the first frame update
    void Start()
    {
        CurrentTime = StartingTime;
    
    }

    // Update is called once per frame
    void Update()
    {

        if (Timerrunning)
        {
            forestFire.PauseGame(true);
            CurrentTime -= 1 * Time.deltaTime;
            CountdownText.text = CurrentTime.ToString("0");
            print(CurrentTime);

            if (CurrentTime < 0) 
            {
                forestFire.PauseGame(false);
                forestFire.gameRunning = true;
                Timerrunning= false;
                CurrentTime = StartingTime;
                forestFire.PutInFire();
            }

        }




    }
}
