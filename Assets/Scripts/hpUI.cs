using UnityEngine;
using UnityEngine.UI;


public class hpUI : MonoBehaviour
{



    GameObject treeLeft;
    GameObject treeRight;
    
    
    
    



    public void Awake()
    {
        treeLeft = GameObject.Find("HPindicator");
        treeRight = GameObject.Find("HPindicator2");
        

    }

    void Update()
    {
        

        gameObject.GetComponent<Text>().text = $"HEALTH: {PlayerStat.playerHP}";
        treeLeft.GetComponent<Text>().text = tree.treeHealth.ToString();
        treeRight.GetComponent<Text>().text = tree.treeHealth.ToString();


    }

    

}
