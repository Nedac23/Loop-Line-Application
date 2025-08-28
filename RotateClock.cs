using System.Threading;
using UnityEngine;

public class RotateClock : MonoBehaviour
{
    public float timer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 0;    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        transform.eulerAngles = new Vector3(0,0,transform.localEulerAngles.z - .006f);
    }
}
