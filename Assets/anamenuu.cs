using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class anamenuu : MonoBehaviour
{
  
   public void oyunaGiris()
    {
        SceneManager.LoadScene("Level1");

    }
    public void cikisNokta()
    {
        Application.Quit();
    }
}
