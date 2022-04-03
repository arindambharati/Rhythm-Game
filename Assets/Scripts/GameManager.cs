using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private AudioSource playMusic;
    [SerializeField] private BeatScroller beatScroller;
    [SerializeField] private bool startPlaying;

    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                //beatScroller.hasStarted = true;
                playMusic.Play();
            }
        }
    }

    public void HitNotes()
    {
        Debug.Log("Hitting notes on time");
    }

    public void MissedNotes()
    {
        Debug.Log("Missed notes");
    }
}
