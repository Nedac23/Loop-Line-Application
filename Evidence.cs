
using UnityEngine;
using UnityEngine.UI;

public class Evidence : MonoBehaviour
{
    public GameObject player;
    public bool interact;
    private float timer;
    public float searchtimer;
    private bool runtimer;
    private GameObject player2;
    public GameObject Dobject;
    private DialugeScript dScript;
    public string[] lines;
    public bool freeze;
    public bool weapon;
    public Sprite m_Sprite;
    public GameObject image;
    // public AudioSource AS;
    private float timer3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer3 = 0;
        player2 = GameObject.Find("Player");
        player = GameObject.Find("Psprite");
        interact = false;
        timer = 0;
        searchtimer = 0;
        runtimer = false;
        dScript = Dobject.GetComponent<DialugeScript>();
        freeze = false;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer = Time.fixedDeltaTime + timer;
    
        if (interact == true && Input.GetKey("e") && timer > .5f && runtimer == false)
        {
            timer = 0;
            //resettimer = true;
            //searchtimer = 0;
            runtimer = true;
            if(weapon)
            {
                image.GetComponent<Image>().sprite = m_Sprite;
            }
            player2.GetComponent<PlayerMovement>().talk = true;
          
            //       if(AS.isPlaying == false) { AS.Play(); }
        }
        if(runtimer && freeze == false)
        {
            //timer3 = Time.fixedDeltaTime + timer3;
            //        timer3 = 
            //  player2.GetComponent<PlayerMovement>().talk = true;
            searchtimer = Time.fixedDeltaTime + searchtimer;
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            freeze = true;
            Dobject.SetActive(true);
            // pause = true;
            //   on = true;
            //timer = 0;
            // Dobject.SetActive(true);
            dScript.StartDialouge(lines,3);
            searchtimer = 0;
            this.gameObject.SetActive(false);
            

        }
        else
        {
            searchtimer = 0;
        }
        if (searchtimer > 2f && freeze == false)
        {
            searchtimer = 0;
           // runtimer = false;
           

        }

        //if (searchtimer > 2f && Dobject.activeSelf == false)
        //{
          //  searchtimer = 0;
            //this.gameObject.SetActive(false);
        //}
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("in");
        interact = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        interact= false;
        //Debug.Log("out");
    }
}
