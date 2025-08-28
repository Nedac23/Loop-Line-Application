using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float x;
    public float y;
    public float yspeed;
    public float xspeed;
    public bool book;
    public float timer;
    public GameObject cam;
    public bool talk;
    public GameObject suspects;
    public GameObject weapons;
    public GameObject top;
    public GameObject toptitle;
    public GameObject weaponstitle;
    public GameObject suspectstitle;
    public GameObject top2;
    public float camdepth;
    public GameObject character;
    public GameObject button;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 0;
        book = false;
       rb = GetComponent<Rigidbody2D>();
        talk = false;
        suspects.SetActive(false);
        weapons.SetActive(false);
        top.SetActive(false);
        weaponstitle.SetActive(false);
        toptitle.SetActive(false);
        suspectstitle.SetActive(false);
        top2.SetActive(false);
        button.SetActive(false);
        character = GameObject.Find("Psprite");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        x = 0;
        y = 0;
        timer = timer + Time.fixedDeltaTime;
        /*

        */
        if(talk == true)
        {
            rb.linearVelocity = new Vector2(x, y);
        }
        else if(book == false)
        {
            //cam.transform.parent = transform;
            //cam.transform.position = new Vector3(transform.position.x, transform.position.y, -10);

            if (Input.GetKey("w"))
            {
                y = y + yspeed;
                // rb.linearVelocity = new Vector2(0, 1f);
            }
            if (Input.GetKey("d"))
            {
                transform.GetComponent<BoxCollider2D>().offset = new Vector2(-.03f, -0.40f);
                character.GetComponent<SpriteRenderer>().flipX = true;
                x = x + xspeed;
                //rb.linearVelocity = new Vector2(1f, 0f);
            }
            if (Input.GetKey("a"))
            {
                transform.GetComponent<BoxCollider2D>().offset = new Vector2(.11f, -0.40f);
                character.GetComponent<SpriteRenderer>().flipX = false;

                x = x - xspeed;
                //rb.linearVelocity = new Vector2(-1f, 0f);
            }
            if (Input.GetKey("s"))
            {
                y = y - yspeed;
                //rb.linearVelocity = new Vector2(0, -1f);
            }
          
            rb.linearVelocity = new Vector2(x, y);
        }
        if(book == false)
            {
                cam.transform.parent = transform;
                cam.transform.position = new Vector3(transform.position.x, transform.position.y, camdepth);
                suspects.SetActive(false);
                weapons.SetActive(false);
                top.SetActive(false);
            weaponstitle.SetActive(false);
            toptitle.SetActive(false);
            suspectstitle.SetActive(false);
            top2.SetActive(false);
            button.SetActive(false);
         //   if (Input.GetKey(KeyCode.Tab) && timer > .5f && talk == false)
           //     {
             //       timer = 0;
               //     book = true;
                //}
            }
        else if(book == true && talk == false)
        {
        //    if (Input.GetKey(KeyCode.Tab) && timer > .5f)
          //  {
            //    book = false;
              //  timer = 0;
            //}
            cam.transform.parent = null;
            cam.transform.position = new Vector3(0f, 50f, camdepth);
            suspects.SetActive(true);
            weapons.SetActive(true);
            top.SetActive(true);
            weaponstitle.SetActive(true);
            toptitle.SetActive(true);
            suspectstitle.SetActive(true);
            top2.SetActive(true);
            button.SetActive(true);
        }



    }
}
