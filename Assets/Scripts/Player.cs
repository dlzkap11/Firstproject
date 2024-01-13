using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class Marine
{
    public int hp;
    


    public void Test() { }
}

public class Player : MonoBehaviour
{
    [SerializeField]
    int level;
    [SerializeField]
    int hp;
    [SerializeField]
    string id;

    //public GameObject _managers;
    Managers manager;

    // Start is called before the first frame update
    void Start()
    {

        Marine m = new Marine();
        m.Test();

        m.hp = 100;




        Managers.Instance.PlaySound();
        
        GameObject ga = GameObject.Find("@Managers");
        Managers managers = ga.GetComponent<Managers>();


        SpriteRenderer sr = ga.GetComponent<SpriteRenderer>();

        //Managers managers = _managers.GetComponent<Managers>();
        managers.PlaySound();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
