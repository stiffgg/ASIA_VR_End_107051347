
using UnityEngine;
using UnityEngine.SceneManagement;


    public class GameManager : MonoBehaviour
    {
        public void RestartGame()
        {
            SceneManager.LoadScene("大象倒地機");
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }

