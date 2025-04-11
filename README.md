# Raycast
Um estudo sobre o ray cast do unity

  É uma função física que projeta um raio invisível na cena, devolvendo um valor booleano que indica se a colisão desse raio acertou um alvo algum objeto.
from pathlib import Path

## Cena

Nesta cena, foi criado um um cubo no qual será fixado o script do raycast e sua origem. Junto com cápsulas prefabs para manterem sua tag "inimigo", e um plano.

![Cena]()

---

## Lançar e mostrar o Raycast

Nesta parte é laçado um raio vermelho. Esse raio é lançado a partir da posição atual do cubo e segue na direção em que ele está olhando (forward).

```csharp
public float rayDistance = 2f; // define a distância do objeto
public Color rayColor = Color.red; // define a cor do raio como vermelho para a visualização do desenvolvedor

Vector3 origin = transform.position; // define o ponto de origem do raio como a posição atual do objeto
Vector3 direction = transform.TransformDirection(Vector3.forward); // define um direção fixa ao objeto que muda conforme a rotação do mesmo

Physics.Raycast(origin, direction, out RaycastHit hit, rayDistance) // lança o raio apartir dos valores ja definidos anteriormente

Debug.DrawRay(origin, direction * rayDistance, rayColor); // desenha o raio para visualização do desenvolvedor
```
![Cena]()
