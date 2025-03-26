using UnityEngine;

public class raycast : MonoBehaviour
{
    public float rayDistance = 2f;
    public Color rayColor = Color.red;

    void Update()
    {
        // Posi��o e dire��o do raio baseada na rota��o atual do objeto
        Vector3 origin = transform.position;
        Vector3 direction = transform.TransformDirection(Vector3.forward);

        
        // Lan�a o raio
        if (Physics.Raycast(origin, direction, out RaycastHit hit, rayDistance))
        {
            Debug.Log("Raycast atingiu: " + hit.collider.gameObject.name);
            if (hit.collider.gameObject.CompareTag("inimigo")) 
            {
                if (Input.GetKey(KeyCode.E))
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
        // Desenha o raio na cena para visualiza��o
        Debug.DrawRay(origin, direction * rayDistance, rayColor);
    }
}
