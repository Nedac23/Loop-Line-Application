using UnityEngine;

public class inventory : MonoBehaviour
{
    public bool keyone;
    public bool keytwo;
    public GameObject Waitress;
    public string[] newlines;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        keyone = false;
        keytwo = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(keyone) { Waitress.GetComponent<CharacterData>().lines = newlines; }
    }
}
