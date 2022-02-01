using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets instance;

    public Sprite pipeHeadSprite;

    public Transform pfPipeHead;
    public Transform pfPipeBody;

    public static GameAssets GetInstance()
    {
        return instance;
    }

    private void Awake()
    {
        instance = this;
    }
}
