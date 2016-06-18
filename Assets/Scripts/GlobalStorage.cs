using UnityEngine;

public class GlobalStorage : MonoBehaviour
{
    public HumanGender PlayerGender;
    public string PlayerTitle;
    public string PlayerName;
    public string DomainName;

    #region Singleton definition
    public static GlobalStorage Instance { get; private set; }

    void GrantSingleInstance()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);
    }
    #endregion
    
    [SerializeField]
    bool paused;

    public bool Paused
    {
        get
        {
            return paused;
        }
        set
        {
            paused = value;
            EventManager.InvokeGamePaused(paused);
        }
    }

    void Awake()
    {
        GrantSingleInstance();
        DontDestroyOnLoad(gameObject);
    }
}