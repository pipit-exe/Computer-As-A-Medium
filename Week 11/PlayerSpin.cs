using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSpin : MonoBehaviour
{
    public Animator animator;
    public PlayerMana playerMana;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Spin();
    }

    void Spin()
    {
        if (Keyboard.current.rKey.wasPressedThisFrame && playerMana.mana >= 10)
        {
            animator.SetBool("spin", true);
            playerMana.mana -= 10;
        }
        else
        {
            animator.SetBool("spin", false);
        }
    }
}
