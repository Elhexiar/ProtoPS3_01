using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PossibleEvents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TurnWhite(bool hideAfterTouch)
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        if (hideAfterTouch)
        {
            gameObject.SetActive(false);
        }

        
    }

    public void EggAppears()
    {
        Debug.Log("The egg appears");
    }
    
    public void EggCracks()
    {
        Debug.Log("EggCracks");
    }

    public void EggSplits()
    {
        Debug.Log("EggSplits");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}