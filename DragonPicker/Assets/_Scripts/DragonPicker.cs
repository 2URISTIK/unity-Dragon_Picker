using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DragonPicker : MonoBehaviour
{
    public GameObject energyShieldPrefab;
    public int numEnergyShield=3;
    public float energyShieldButtomY = -6f;
    public float energyShieldRadius = 1.5f;
    public List<GameObject> basketList;
    private int Music1;
    private int Music2;
    private int Sound1;
    void Start()
    {
        Music1 = PlayerPrefs.GetInt("Music1");
        Music2= PlayerPrefs.GetInt("Music2");
        Sound1 = PlayerPrefs.GetInt("Sound1");
        if (Sound1 == 1 ) { numEnergyShield = 1; }
        basketList = new List<GameObject>();
        for (int i = 1; i <= numEnergyShield; i++)
        {
            GameObject tBasketGo = Instantiate<GameObject>(energyShieldPrefab);
            tBasketGo.transform.position = new Vector3(0, energyShieldButtomY, 0);
            tBasketGo.transform.localScale = new Vector3(1 * i, 1 * i, 1 * i);
            basketList.Add(tBasketGo);
        }
        
        if (Music1 == 0)
        {
            GetComponent<AudioSource>().enabled = false;
        }
    }
    void Update()
    {
    }
    public void DragonEggDestroyed()
    {
        GameObject[] tDragonEggArray =
        GameObject.FindGameObjectsWithTag("DragonEgg");
        foreach (GameObject tGO in tDragonEggArray)
        {
            Destroy(tGO);
        }
        int basketIndex = basketList.Count - 1;
        GameObject tBasketGo = basketList[basketIndex];
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGo);
        if (basketList.Count == 0)
        {
            SceneManager.LoadScene("_0Scene");
        }
    }
    public int GetMusic1()
    {
        return (Music1);
    }
    public int GetMusic2()
    {
        return (Music2);
    }
    public int GetSound1()
    {
        return (Sound1);
    }
}
