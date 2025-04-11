# Raycast
Um estudo sobre o ray cast do unity

  É uma função física que projeta um raio invisível na cena, devolvendo um valor booleano que indica se a colisão desse raio acertou um alvo algum objeto.

```
using UnityEngine;

public class raycast : MonoBehaviour
{
    public float rayDistance = 2f;
    public Color rayColor = Color.red;

    void Update()
    {
        // Posição e direção do raio baseada na rotação atual do objeto
        Vector3 origin = transform.position;
        Vector3 direction = transform.TransformDirection(Vector3.forward);

        
        // Lança o raio
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
        // Desenha o raio na cena para visualização
        Debug.DrawRay(origin, direction * rayDistance, rayColor);
    }
}
```
