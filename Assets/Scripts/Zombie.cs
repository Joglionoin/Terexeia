using UnityEngine;

public class Zombie : MonoBehaviour
{
    float zombieHP = 50000;
    float zombieDmg = 150;
    
    bool weak = false;

    void Awake()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnMouseDown()
    {

        GetComponent<SpriteRenderer>().color = Color.red;
        if (zombieHP > PlayerStat.initPlayerAttack)
        {
            zombieHP -= PlayerStat.initPlayerAttack;


        }

        else if (zombieHP <= PlayerStat.initPlayerAttack)
        {
            PlayerStat.DropItem("Green Ink");
            gameObject.SetActive(false);
        }
        if (weak == false)
        {
            PlayerStat.playerWeakness *= 2;
            weak = true;
        }
        
        PlayerStat.DamageTaken(zombieDmg);   

    }

    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
