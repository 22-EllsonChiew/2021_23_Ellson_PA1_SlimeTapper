using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public UIScript UIScore;
    

    Vector2 screensBound;

    public AudioSource SquishSound;
    // GameObject Slimeprefads;


    // Start is called before the first frame update
    void Start()
    {
        screensBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        //game play controller
        if(Input.GetMouseButtonDown(0))
        {
            

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


            RaycastHit hit;
            

            if (Physics.Raycast(ray, out hit))
            {
                
                //Slimeprefads = hit.collider.gameObject;
                SpawnCubes();
                UIScore.ScoreIncrement();
                Destroy(this.gameObject);
                PlaySound();

            }

        }
    }

    void SpawnCubes()
    {
        //Spawn Cube Instantiate
        Vector3 position = new Vector3(Random.Range(-screensBound.x, screensBound.x), Random.Range(-screensBound.y, screensBound.y), 0);
        Instantiate(gameObject, position, Quaternion.identity);
    }
    public void PlaySound()
    {
        //sound Effect
        SquishSound.Play();

    }
}



