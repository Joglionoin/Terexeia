using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStat : MonoBehaviour
{

    public static float initPlayerAttack = 1;
    public static float initplayerSpeed = 0.03f;
    public static float playerSpeed;
    GameObject inv1;
    GameObject inv2;
    GameObject inv3;
    GameObject DeadText;
    GameObject DeathButtonMenu;

    public static string item1slot = "Empty";
    public static string item2slot = "Empty";
    public static string item3slot = "Empty";
    
    public static float maxPlayerHP = 420;
    public static float playerHP;
    public static float playerWeakness = 1;

    public static bool isCensored = false;


    private void Awake()
    {
        playerHP = maxPlayerHP;
        DeadText = GameObject.Find("DeathText");
        DeathButtonMenu = GameObject.Find("DeathButton");
        
    }
    

    void Start()
    {
        inv1 = GameObject.Find("inv1");
        inv2 = GameObject.Find("inv2");
        inv3 = GameObject.Find("inv3");

    }

    
    void Update()
    {
        

    }

    public static void DamageTaken(float raw)
    {
        playerHP -= raw * playerWeakness;
        if (playerHP <= 0)
        {
            SceneManager.LoadScene(3);
            
        }
    }

    public static void DropItem(string item)
    {
        if (item1slot == "Empty")
        {
            item1slot = item;
            
        }
        else if (item2slot == "Empty")
        {
            item2slot = item;
        }
        else if (item3slot == "Empty")
        {
            item3slot = item;
        }
        
    }

    public static void ResetSpeed()
    {
        playerSpeed = initplayerSpeed;
    }
    

    
}
