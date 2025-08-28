
using UnityEngine;

public class Doors : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int keycode;
    private inventory IVscript;
    private GameObject Inventory;
    private float distance;
    private GameObject player;
    private DialugeScript dScript;
    public GameObject Dobject;
    public string[] lines;
    public bool freeze;
    public bool broken;

    void Start()
    {
        broken = false;
        freeze = false;
        player = GameObject.Find("Player");
        Inventory = GameObject.Find("Inventory");
        IVscript = Inventory.GetComponent<inventory>();
        dScript = Dobject.GetComponent<DialugeScript>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //   distance = Vector2.Distance(player.transform.position, this.gameObject.transform.position);
        switch (keycode)
        {
            case 0:
                break;
            case 1:
                if (IVscript.keyone == true)
                {
                    freeze = true;
                    broken = true;
                    //this.gameObject.SetActive(false);
                }
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                break;
        }
        if(broken == true)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            player.GetComponent<PlayerMovement>().talk = true;
            Dobject.SetActive(true);
            // pause = true;
            //   on = true;
            //timer = 0;
            // Dobject.SetActive(true);
            freeze = true;
            dScript.StartDialouge(lines,4);
        }
    }
    
    public void OnCollisionExit2D(Collision2D collision)
    {
        freeze = false;
        Debug.Log("nothit");
    }
}
