using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    //private static Image HealthBarImage;

    public GameObject[] npcs;
    private void onEnable(){
        if (npcs == null)
            npcs = GameObject.FindGameObjectsWithTag("NPC");

        foreach (GameObject npc in npcs)
        {
            Instantiate(npc, npc.transform.position, npc.transform.rotation);
            //SetHealthBarColor(Color.red);
        }
    }
    /*public static void SetHealthBarColor(Color healthColor)
    {
        HealthBarImage.color = healthColor;
    }

    private void Start()
    {
        HealthBarImage = GetComponent<Image>();
    }*/
}
