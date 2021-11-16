using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    //ENFOQUE POCO EFECTIVO SIN SINGLETON
    [SerializeField] private GiftsManager GiftsManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("CLICKED "+gameObject.name);
        GiftsManager.AddGift(gameObject);
        GiftsManager.AddDictionary(gameObject.name, gameObject);
        gameObject.SetActive(false);
    }
    
}
