using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gobackscript : MonoBehaviour
{
   public void goback(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
}
