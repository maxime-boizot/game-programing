using UnityEngine;

public class GenerationForme : MonoBehaviour
{
    public GameObject formePrefab;
    public int nombreDeColonnes = 1;
    public float espaceEntreFormes = 1.5f;
    public float vitesseDescente = 2f;
    public float tempsEntreGenerations = 2f;
    public Vector3 positionDeSpawn = new Vector3(0f, 3f, 8f);
    
    private void Start()
    {
        InvokeRepeating("GenererFormes", 0f, tempsEntreGenerations);
    }

    private void GenererFormes()
    {
        for (int i = 0; i < nombreDeColonnes; i++)
        {
            Vector3 position = positionDeSpawn + new Vector3(i * espaceEntreFormes + Random.Range(-7, 7), 0f, 0f);
            GameObject nouvelleForme = Instantiate(formePrefab, position, Quaternion.identity);
            nouvelleForme.AddComponent<MouvementForme>().Initialiser(vitesseDescente);
        }
    }
}