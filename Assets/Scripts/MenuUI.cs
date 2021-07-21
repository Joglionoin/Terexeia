using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    GameObject healthSlider;
    GameObject textHP;
    GameObject dmgSlider;
    GameObject textAD;
    GameObject SpeedSlider;
    GameObject textSpeed;
    

    private void Awake()
    {
        dmgSlider = GameObject.Find("AttackSlider");
        textAD = GameObject.Find("DisplayAttackText");
        textAD.GetComponent<Text>().text = $"Player Attack: {PlayerStat.initPlayerAttack}";
        dmgSlider.GetComponent<Slider>().value = PlayerStat.initPlayerAttack;
        healthSlider = GameObject.Find("HealthSlider");
        textHP = GameObject.Find("DisplayHealthText");
        textHP.GetComponent<Text>().text = $"Player Health: {PlayerStat.maxPlayerHP}";
        healthSlider.GetComponent<Slider>().value = PlayerStat.maxPlayerHP;
        SpeedSlider = GameObject.Find("SpeedSlider");
        textSpeed = GameObject.Find("DisplaySpeedText");
        textSpeed.GetComponent<Text>().text = $"Player Speed: {PlayerStat.initplayerSpeed}";

    }

    public void playGame()
    {
        SceneManager.LoadScene(1);
        PlayerStat.ResetSpeed();
    }

    public void optionMenu()
    {
        SceneManager.LoadScene(2);
        
        
    }

    public void quitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    public void backClick()
    {
        SceneManager.LoadScene(0);


    }

    public void SliderADValueChanged()
    {
        PlayerStat.initPlayerAttack = dmgSlider.GetComponent<Slider>().value;
        textAD.GetComponent<Text>().text = $"Player Attack: {dmgSlider.GetComponent<Slider>().value}";
    }

    public void SliderHPValueChanged()
    {
        PlayerStat.maxPlayerHP = healthSlider.GetComponent<Slider>().value;
        textHP.GetComponent<Text>().text = $"Player Health: {healthSlider.GetComponent<Slider>().value}";
    }

    public void SliderSpeedValueChanged()
    {
        PlayerStat.initplayerSpeed = SpeedSlider.GetComponent<Slider>().value;
        textSpeed.GetComponent<Text>().text = $"Player Speed: {SpeedSlider.GetComponent<Slider>().value}";
    }


}
