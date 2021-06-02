using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killfeed : MonoBehaviour
{
    [SerializeField]
    GameObject killfeedItemPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.onPlayerKilledCallBack += OnKill;
    }

    public void OnKill(string player, string source)
    {
        GameObject go = Instantiate(killfeedItemPrefab, transform);
        go.GetComponent<KillfeedItem>().Setup(player, source);
        Destroy(go, 3f);
    }
}
