using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cashier : MonoBehaviour
{
    public string password, passwordTyping;
    public TextMeshProUGUI ecran;
    public void keyPressed(int id){
        if(passwordTyping.Length < password.Length && id >= 0){
            passwordTyping+=id;
            ecran.text = passwordTyping;
        }
        if(id == -1)
            checkPassword();
    }
    void checkPassword(){
        if(passwordTyping == password){
            ecran.text = "OK";
            GetComponent<Animator>().SetTrigger("ouverture");
        }else{
            ecran.text = "WRONG";
            passwordTyping = "";
        }
    }
}
