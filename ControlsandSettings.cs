using Unity.VisualScripting;
using UnityEngine;

public class ControlsandSettings : MonoBehaviour
{
    private GameObject player;
    private GameObject controls;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
        controls = GameObject.Find("Controls");
        controls.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetBookTrue()
    {
       if(player.GetComponent<PlayerMovement>().book == true)
        {
            player.GetComponent<PlayerMovement>().book = false;
        }
        else
        {
            player.GetComponent<PlayerMovement>().book = true;
        }
    }

    public void Settings()
    {
        if (player.GetComponent<PlayerMovement>().talk == false) 
        {
            if (controls.activeSelf == true)
            {
                controls.SetActive(false);
            }
            else
            {
                controls.SetActive(true);
            }
        }
        else
        {
            controls.SetActive(false);
        }
    }




}
