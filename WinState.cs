using UnityEngine;

public class WinState : MonoBehaviour
{
    public GameObject check1;
    public GameObject check2;
    public bool Won;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Won = true;
    }

    // Update is called once per frame
    void Update()
    {
            if(check1.GetComponent<CheckWin>().win == true && check2.GetComponent<CheckWin>().win == true) 
        {
            Won = true;
        
        }
        else
        {
            Won = false;    
        }
    }
}
