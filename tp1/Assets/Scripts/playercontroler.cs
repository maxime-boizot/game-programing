using UnityEngine;

public class DeplacementCarreau : MonoBehaviour
{
    public float vitesse = 5f;

    void Update()
    {
        float deplacementHorizontal = Input.GetAxis("Horizontal");
        float deplacementVertical = Input.GetAxis("Vertical");
        
        Vector2 deplacement = new Vector2(deplacementHorizontal, deplacementVertical);
        
        transform.Translate(deplacement * vitesse * Time.deltaTime);
    }
}

