using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftsManager : MonoBehaviour
{
    //1er TDA ARRAY
    [SerializeField] private GameObject[] giftsArray;
    [SerializeField] private int indexGiftsArray = 0;
    //2do TDA LIST
    [SerializeField] private List<GameObject> giftsList;
    [SerializeField] private int indexGiftsList = 0;
    //3er TDA STACK
    private Stack giftStack;
    //4to TDA QUEUE
    private Queue giftQueue;
    //5to TDA DYCTONARY
    Dictionary<string, GameObject> giftsDictionary;

    //My Camera
    [SerializeField] private Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        //ES NECESARIO INDICAR EL NUMERO DE ELEMENTOS DEL ARRAY (ESTÁTICO)
        giftsArray = new GameObject[3];
        // NO ES NECESARIO INDICAR EL NUMERO DE ELEMENTOS DE LA LISTA (DINÁMICO)
        giftsList = new List<GameObject>();
        //INSTANCIAR STACK
        giftStack = new Stack();
        //INSTANCIAR QUEUE
        giftQueue = new Queue();
        //INSTANCIAR DICTIONARY
        giftsDictionary = new Dictionary<string, GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            GameObject myGift = GetGift();
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = -mainCamera.transform.position.z;
            myGift.transform.position = mainCamera.ScreenToWorldPoint(mousePos);
            myGift.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {

            GameObject myGift = GetGiftDictonary("CandyCane");
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = -mainCamera.transform.position.z;
            myGift.transform.position = mainCamera.ScreenToWorldPoint(mousePos);
            myGift.SetActive(true);

        }
    }

    public void AddGift(GameObject gift)
    {
        /*AGREGAR REGALO A LA COLECCION DE TIPO ARRAY
         
        giftsArray[indexGiftsArray] = gift;
        indexGiftsArray++;
        */

        /* AGREGAR REGALO A LA COLLECCION DE TIPO LISTA
        giftsList.Add(gift);
        */

        /* AGREGAR ELEMENTO A LA PILA
        giftStack.Push(gift);
        */

        /* AGREGAR ELEMENTO A LA COLA */
        giftQueue.Enqueue(gift);
    }

    public void AddDictionary(string key, GameObject gift)
    {
        giftsDictionary.Add(key, gift);
    }

    public GameObject GetGift()
    {
        /* OBTENER REGALO DE LA LISTA CON INDICE
        GameObject gift = giftsList[indexGiftsList];
        indexGiftsList++;
        return gift;
        */
        /*  OBTENER REGALO DE LA PILA COMO GAME OBJECT
        return giftStack.Pop() as GameObject;
        */

        /* OBTENER REGALO DE LA COLA COMO GAME OBJECT */
        return giftQueue.Dequeue() as GameObject;
    }

    public GameObject GetGiftDictonary(string key)
    {
        return giftsDictionary[key];
    }
}
