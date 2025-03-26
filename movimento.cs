using UnityEngine;

public class movimento : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Velocidade de movimento
    private float moveSpeed = 12;
    // Velocidade de rota��o
    public float rotationSpeed = 200f;

    void Update()
    {
        // Entrada de movimento (W, S ou Setas para frente e tr�s)
        float moveInput = Input.GetAxis("Vertical");

        // Entrada de rota��o (A, D ou Setas para os lados)
        float rotationInput = Input.GetAxis("Horizontal");

        // Move o objeto para frente ou para tr�s
        transform.Translate(Vector3.forward * moveInput * moveSpeed * Time.deltaTime);

        // Rotaciona o objeto para a esquerda ou direita
        transform.Rotate(Vector3.up * rotationInput * rotationSpeed * Time.deltaTime);
    }
}
