using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStuff : MonoBehaviour
{
    public GameObject Credits_stuff;
    public GameObject CheckWinObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("sfhsldkjf");
        //Credits_stuff.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGame()
    {
        Debug.Log("ChangeScene");
        SceneManager.LoadScene(2);

    }
    public void Credits()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(1);
    }

    public void ReturnToStart()
    {
        SceneManager.LoadScene(0);
    }

    public void CheckWinFunc()
    {
        if(CheckWinObject.GetComponent<WinState>().Won == true)
        {
            GoToWinScreen();
        }
        else
        {
            GoToLoseScreen();
        }
    }
    public void GoToWinScreen()
    {
        SceneManager.LoadScene(3);
    }

    public void GoToLoseScreen()
    {
        SceneManager.LoadScene(4);
    }

    public void CloseApplication()
    {
        StopAllCoroutines();
        Application.Quit();
    }
}
