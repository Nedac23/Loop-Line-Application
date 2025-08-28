using System;
using UnityEngine;
using UnityEngine.UI;

public class CharacterData : MonoBehaviour
{
    public string[] lines;
    public float distance;
    public GameObject player;
    private DialugeScript dScript;
    public GameObject Dobject;
    public bool on;
    private float timer;
    public bool pause;
    private bool firstframe;
    //Image image;
    public GameObject image;
    //Set this in the Inspector
    public Sprite m_Sprite;
    public AudioSource AS;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        firstframe = true;
        pause = false;
        on = false;
        timer = 0;
        dScript = Dobject.GetComponent<DialugeScript>();
        //Dobject.SetActive(false);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        distance = Vector2.Distance(player.transform.position, this.gameObject.transform.position);
        if (firstframe == true)
        {
           // Dobject.SetActive(false);
            firstframe=false;
        }
        if (!pause) {
            timer += Time.fixedDeltaTime;
           

            if (Input.GetKey("e") && distance < 3f && timer > 1f)
            {
                // if(AS.isPlaying == false)
                //{
                //  AS.Play();
                //}
                //dScript.good = true;
                player.GetComponent<PlayerMovement>().talk = true;
                Dobject.SetActive(true);
                pause = true;
                on = true;
                timer = 0;
                Dobject.SetActive(true);
                dScript.StartDialouge(lines,2);
                image.GetComponent<Image>().sprite = m_Sprite;
         
            }
             
        }
        if(distance > 3f)
        {
            //   Debug.Log("")

         //   player.GetComponent<PlayerMovement>().talk = false;
            pause = false;
        }
    }

    public void StopD()
    {
        dScript.StopDiolouge();
        StopAllCoroutines();
        Dobject.SetActive(false);
    }
}

