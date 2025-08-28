using UnityEngine;
using TMPro;
using System.Collections;


public class DialugeScript : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public GameObject[] characters;
    public string[] lines;
    public float textspeed;
    public int index;
    public GameObject player;
    public float distance;
    public GameObject character1;
    public bool good;
    private float timer;
    public bool begin;
    private float timerval;
    public AudioSource AS;
    public AudioSource Ev;
    public int val;
   //publ
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        good = true;
        textComponent.text = string.Empty;
        // StartDialouge();
        timer = 0;
        player.GetComponent<PlayerMovement>().talk = true;
        // Dobject.SetActive(true);
        //pause = true;
        //on = true;
        //timer = 0;
        //Dobject.SetActive(true);
        begin = true;
        StartDialouge(lines, 1);
        
        timerval = 5f;
    }

    // Update is called once per frame
    void Update()
    { timer = timer + Time.deltaTime;
        if (begin == false)
        {
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i].GetComponent<CharacterData>().on == true)
                {

                    good = true;
                    break;
                }
                else
                {
                    good = false;
                }
            }
        }
        /*
        for (int i = 0; i < characters.Length; i++)
        {
            if (characters[i].GetComponent<CharacterData>().on == false)
            {
                characters[i].GetComponent<CharacterData>().pause = false;
                good = false;
            }
        }
      */
        if (Input.GetKey("e") && good == true && timer > 0.5f )
        {
            if(AS.isPlaying == false && begin == false) { AS.Play(); }
            timer = 0;
            if (textComponent.text == lines[index])
         {
          NextLine();
               
        }
          else
            {
            StopAllCoroutines();
              textComponent.text = lines[index];
                if(AS.isPlaying)
                {
                    AS.Stop();
                }
           //     index = 0;
           }
          }
        else if(Input.GetKey("e") && lines.Length == 1 && timer > 0.5f)
        {
            player.GetComponent<PlayerMovement>().talk = false;
            textComponent.text = string.Empty;
            StopAllCoroutines(); gameObject.SetActive(false);
            //          textComponent.text = lines[index];
        }
        else if(timerval < 5f && Input.GetKey("e"))
        {
            timer = 0;
            if (Ev.isPlaying)
            {
                Ev.Stop();
            }
            if (textComponent.text == lines[index])
            {
                NextLine();

            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
                //     index = 0;
            }
        }
        else if(timer > timerval)
        {
            timer = 0;
           // good = true;
            if(Ev.isPlaying == false)
            {
                Ev.Play();
            }
            timerval = 4f;
            if (textComponent.text == lines[index])
            {
                NextLine();

            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
                //     index = 0;
            }
        }
         // Debug.Log("Bad Update");

    }
    public void StartDialouge(string[] lines, int val)
    {
        this.lines = lines;
        Debug.Log(lines[0]);
        index = 0;
        //    AS.Play();
        this.val = val;
        StartCoroutine(TypeLine());
        if(val == 1)
        {
           // AS.Play();
        }
        else if(val == 2)
        {
            //Ev.Play();
            AS.Play();
        }
        else if(val == 3)
        {
            Ev.Play();
        }
        
    }

    IEnumerator TypeLine()
    {
        foreach(char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textspeed);
        }
    }
   public void NextLine()
    {
        if(index < lines.Length - 1)
        {
            Debug.Log("Index:" + index);
            if(val == 3)
            {
                Ev.Stop();
            }
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            if (begin == false)
            {
                for (int i = 0; i < characters.Length; i++)
                {
                    if (characters[i].GetComponent<CharacterData>().pause == true)
                    {
                        characters[i].GetComponent<CharacterData>().pause = false;
                        break;
                    }

                }
            }

            //gameObject.SetActive(false);
            index = 0;

            player.GetComponent<PlayerMovement>().talk = false;
            textComponent.text = string.Empty;
            begin = false;
            good = false;
            timerval = 5f;
            if(Ev.isPlaying)
            {
                Ev.Stop();
            }
         
            if(AS.isPlaying)
            {
                AS.Stop();
            }
            gameObject.SetActive(false);
        }
    }
    public void StopDiolouge()
    {
        index = 0;
        textComponent.text = string.Empty;
        StopAllCoroutines();
    }

}
