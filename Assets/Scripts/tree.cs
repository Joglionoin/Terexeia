using UnityEngine;


public class tree : MonoBehaviour
{
    public static float treeHealth = 69;
    float treeDmg = 42.0f;
    

    void Awake()
    {
        
    }

    
    void Update()
    {
        
    }
    
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        if (treeHealth > PlayerStat.initPlayerAttack)
        {
            treeHealth -= PlayerStat.initPlayerAttack;
            
            
        }

        else if (treeHealth <= PlayerStat.initPlayerAttack)
        {
            PlayerStat.DropItem("Wood");
            gameObject.SetActive(false);
        }
        PlayerStat.DamageTaken(treeDmg);

    }
    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
