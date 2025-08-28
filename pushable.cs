using UnityEngine;

public class pushable : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AudioSource AS;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (AS.isPlaying == false)
        {
            AS.Play();

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(AS.isPlaying) { AS.Stop(); }
    }
}
