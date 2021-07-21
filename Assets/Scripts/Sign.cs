using UnityEngine;
using UnityEngine.SceneManagement;


public class Sign : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(5);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }


}
