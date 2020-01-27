using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadscene : MonoBehaviour
{
    public string Nextscene;
    public void LoadNextScene()
    {
        SceneManager.LoadScene(Nextscene);
    }

    public void TeacherMenu()
    {
        SceneManager.LoadScene(sceneName: "2FloorSelection");
    }

    public void StudentMenu()
    {
        SceneManager.LoadScene(sceneName: "2FloorSelectionStudent");
    }
}
