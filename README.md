# Raycast
Um estudo sobre o ray cast do unity

  É uma função física que projeta um raio invisível na cena, devolvendo um valor booleano que indica se a colisão desse raio acertou um alvo algum objeto.
from pathlib import Path

## Cena

Nesta cena, foi criado um um cubo no qual será fixado o script do raycast e sua origem. Junto com cápsulas prefabs para manterem sua tag "inimigo", e um plano.

![Cena]()

---

## Lançar e mostrar o ray ast

Nesta parte é laçado um raio um **raio vermelho** à sua frente.  
Esse raio é lançado a partir da posição atual do cubo e segue na direção em que ele está olhando (forward).

```csharp
Vector3 origin = transform.position;
Vector3 direction = transform.TransformDirection(Vector3.forward);
Debug.DrawRay(origin, direction * rayDistance, rayColor);
