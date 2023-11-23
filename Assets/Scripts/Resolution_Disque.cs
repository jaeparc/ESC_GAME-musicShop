using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class Resolution_Disque : MonoBehaviour
{
    
    public XRSimpleInteractable levier;
    public Animator m_Animator;

    public Animator Petit_Animator;

    public Animator Moyen_Animator;

    public Animator Grand_Animator;

    public bool execute;
    //

    public GameObject cassettePrefab, cassetteInstance;
    public Transform cassetteAppearancePos;

    bool reussi = false;
    public List<bool> Liste_Resolution = new List<bool>{false,false,false,false,false,false};

    public void Check_Resolution()
    {
        for (int i = 0; i < 5; i++ )
        {
            if(Liste_Resolution[i] == false)
            {
                Debug.Log("fals");
                break;
            }else{
                Debug.Log("tru");
                reussi = true;
            }
        }
        if(reussi)
        {
            Petit_Animator.enabled = true;
            Moyen_Animator.enabled = true;
            Grand_Animator.enabled = true;


            Petit_Animator.SetTrigger("Tourne");
            Moyen_Animator.SetTrigger("Tourne");
            Grand_Animator.SetTrigger("tourne");
            levier.enabled = false;

            popCassette();
        }
    }

    public void popCassette(){
        if(cassetteInstance == null)
            cassetteInstance = Instantiate(cassettePrefab,cassetteAppearancePos);
    }

    public void Switch_Bool()
    {
        if(execute)
            execute = false;
        else
            execute = true;
    }

    void Start()
    {
        execute = true;
    }
}   


