using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{

    public void GoToMainMenu(){
        Application.LoadLevel("menu");
    }

    public void GoToMenuModel(){
        Application.LoadLevel("MenuModel");
    }

    public void GoToModelGantung(){
        Application.LoadLevel("ModelGantung");
    }

    public void GoToModelRak(){
        Application.LoadLevel("ModelRak");
    }

    public void GoToModelTegak(){
        Application.LoadLevel("ModelTegak");
    }

    public void GoToModelTempel(){
        Application.LoadLevel("ModelTempel");
    }

    public void GoToPanduan(){
        Application.LoadLevel("Panduan");
    }

    public void GoToTentang(){
        Application.LoadLevel("Tentang");
    }

    public void GoToARCameraGantung(){
        Application.LoadLevel("AR_Camera_Gantung");
    }

    public void GoToARCameraTegak(){
        Application.LoadLevel("AR_Camera_Tegak");
    }

    public void GoToARCameraRak(){
        Application.LoadLevel("AR_Camera_Rak");
    }

    public void GoToARCameraTempel(){
        Application.LoadLevel("AR_Camera_Tempel");
    }

    public void URL(){
        Application.OpenURL("https://drive.google.com/drive/folders/17t2GGkaVx8CSiDx971ZVVERvltXcre2n?usp=sharing");
    }

    public void GoToKeluar(){
        Application.LoadLevel("Keluar");
    }

    public void ExitApplication(){
        Application.Quit();
    }

}
