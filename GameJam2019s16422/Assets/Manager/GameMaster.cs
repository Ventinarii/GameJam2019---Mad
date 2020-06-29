using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public GameObject Hero;
    public static HeroController HeroController;
    public static List<GameObject> Enemies = new List<GameObject>();
    
    void Start()
    {
        HeroController = Hero.GetComponent<HeroController>();
    }

    
    void Update()
    {
        
    }


}
