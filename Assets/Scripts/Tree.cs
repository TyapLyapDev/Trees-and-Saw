using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tree : MonoBehaviour
{
    [SerializeField] private int totalHP;
    private int hp;
    [SerializeField] Image HealthBarFill;
    // Start is called before the first frame update
    void Start()
    {
        hp = totalHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Hit();
    }
    public void Hit()
    {
        hp--;
        HealthBarFill.fillAmount = (float)hp / (float)totalHP;
        if (hp <= 0)
        {
            CutDown(); 
        }
    }

    private void CutDown()
    {
        GameController.instance.AddMoney(totalHP);
        TreeManager.instance.ReplaceTree(gameObject);
    }
}
