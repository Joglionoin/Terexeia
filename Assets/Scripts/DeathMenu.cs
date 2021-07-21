using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DeathMenu : MonoBehaviour
{
    
    void Awake()
    {
        
        if (PlayerStat.isCensored == false)
        {
            GetComponent<Text>().text = "You Died";

        }   
        else if (PlayerStat.isCensored == true)
        {
            GetComponent<Text>().text = "You lost your rights to live";
        }    
    }

    private void Update()
    {
        
    }


    public void MenuButton()
    {
        
        SceneManager.LoadScene(0);
    }


}
