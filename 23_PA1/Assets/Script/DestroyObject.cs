using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DestroyObject : MonoBehaviour
{
    //Life time is the displayed timed
    public float lifetime = 5f;
    public float currentTime = 0f;

    [SerializeField] Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = lifetime;
    }

    // Update is called once per frame
    void Update()
    {
        //Minus 1 Sec 
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("Timer: 0");

        //If run out of time change to lose scene
        if(currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene("Lose");
        }
        
    }
    
}
