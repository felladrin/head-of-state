using UnityEngine;

public class CursorController : MvcBehaviour
{
    static CursorController instance;

    public Texture2D cursorTexture;
    public Texture2D cursorOnHoverClickableTexture;
    public bool ccEnabled = true;

    public static CursorController Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        Invoke("SetCustomCursor", 0.0f);
        //DontDestroyOnLoad (gameObject);
    }

    void OnDisable()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        ccEnabled = false;
    }

    void SetCustomCursor()
    {
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
        ccEnabled = true;
    }

    public void OnHoverClickable()
    {
        if (ccEnabled)
            Cursor.SetCursor(cursorOnHoverClickableTexture, Vector2.zero, CursorMode.Auto);
    }

    public void OnExitClickable()
    {
        if (ccEnabled)
            Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
    }
}