using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField]
    GameObject playerScoreBoardItem;

    [SerializeField]
    Transform playerlist;

    private void OnEnable()
    {
        //Recup une array de tous les joueurs
        Player[] players = GameManager.GetAllPlayers();

        foreach (Player player in players)
        {
            GameObject itemGO = Instantiate(playerScoreBoardItem, playerlist);
            PlayerScoreBoardItem item = itemGO.GetComponent<PlayerScoreBoardItem>();
            if(item != null)
            {
                item.Setup(player);
            }
        }
    }

    private void OnDisable()
    {
        foreach (Transform child in playerlist)
        {
            Destroy(child.gameObject);
        }
    }
}
