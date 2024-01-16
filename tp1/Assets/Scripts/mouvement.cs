using UnityEngine;

public class MouvementForme : MonoBehaviour
{
    private float vitesseDescente;

    public void Initialiser(float descente)
    {
        vitesseDescente = descente;
    }

    void Update()
    {
        transform.Translate(Vector3.down * vitesseDescente * Time.deltaTime);
    }
}