using UnityEngine;

public class CheckWin : MonoBehaviour
{
    public bool win;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        win = false;
      
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount > 0)
        {
            if (transform.GetChild(0).GetComponent<Dragableitem>().winner == true)
            {
                win = true;
            }
            else
            {
                win = false;
            }
        }
        else
        {
            win = false;
        }
        Debug.Log(transform.childCount);
    }
}
