using UnityEngine;

public class SC_DamageReceiver : MonoBehaviour, IEntity
{
    
    public float playerHP = 100;
    public SC_CharacterController playerController;
    public SC_WeaponManager weaponManager;

    public void ApplyDamage(float points)
    {
        playerHP -= points;
        Debug.Log(points);

        if (playerHP <= 0)
        {
            
            playerController.canMove = false;
            playerHP = 0;
        }
    }
}