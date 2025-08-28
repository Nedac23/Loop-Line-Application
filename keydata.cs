
using UnityEngine;

public class keydata : MonoBehaviour
{
    private float distance;
    private GameObject player;
    private inventory IVscript;
    private GameObject Inventory;
    public int doorcode;
    public bool freeze;
    private DialugeScript dScript;
    public GameObject Dobject;
    public string[] lines;
    //private string doorstring;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
        Inventory = GameObject.Find("Inventory");
        IVscript = Inventory.GetComponent<inventory>();
        dScript = Dobject.GetComponent<DialugeScript>();


    }

    // Update is called once per frame
    void Update()
    {
        /*
        distance = Vector2.Distance(player.transform.position, this.gameObject.transform.position);
        if(distance < 1f && Input.GetMouseButton(0))
        {
            IVscript.keyone = true;
            this.gameObject.SetActive(false);
        }
        */

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (Input.GetMouseButton(0))
        //{
        if(collision.collider.gameObject.layer == 7)
        {
            switch (doorcode)
            {
                case 0:
                    break;
                case 1:
                    IVscript.keyone = true;
                    this.gameObject.SetActive(false);
                    break;
                case 2:
                    IVscript.keytwo = true;
                    this.gameObject.SetActive(false);
                    break;


            }
            if (freeze == false)
            {
                player.GetComponent<PlayerMovement>().talk = true;
                Dobject.SetActive(true);
                // pause = true;
                //   on = true;
                //timer = 0;
                // Dobject.SetActive(true);
                freeze = true;
                dScript.StartDialouge(lines, 4);
            }
        }
        //}

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        freeze = false;
    }
}
