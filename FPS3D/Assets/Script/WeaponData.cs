using UnityEngine;

[CreateAssetMenu(fileName = "WeaponData", menuName = "My Game/Weapon Data")]
public class WeaponData : ScriptableObject
{
    public string name = "Rifle gun";
    public float damage = 20f;
    public float range = 100f;

    public float fireRate = 0f;

    public int magazineSize = 10;
    public float reloadTime = 1.5f;

    public GameObject graphics;
}
