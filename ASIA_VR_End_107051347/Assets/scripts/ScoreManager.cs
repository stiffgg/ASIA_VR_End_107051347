
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager: MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public int score;
    [Header("得分")]
    public int scoreIn = 2;
    [Header("進象音效")]
    public AudioClip soundIn;

    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "小雞雞")
        {
            AddScore();
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.root.name == "Player")
        {
            scoreIn = 2;
        }
    }

    private void AddScore()
    {
        score += scoreIn;
        textScore.text = "SCORE:" + score;
        aud.PlayOneShot(soundIn, Random.Range(1f, 2f));
    }
}


