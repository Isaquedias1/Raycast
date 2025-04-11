# 🎯 Raycast

O Raycast é uma função da física que projeta um raio invisível na cena e retorna um valor booleano, indicando se esse raio colidiu com algum objeto.

---

## 🎮 Cena Inicial

Nesta cena, foi criado um **cubo**, que serve como origem do Raycast e recebe o script.  
Também foram adicionadas algumas **cápsulas com a tag "inimigo"** (usando Prefabs) e um **plano** para dar contexto visual à cena.

![Cena](CAMINHO/DA/IMAGEM1.png)

---

## 🚀 Lançar e Visualizar o Raycast

Nesta parte, um **raio vermelho** é lançado a partir da posição atual do cubo e segue a direção para onde ele está virado (`forward`).

```csharp
public float rayDistance = 2f; // Define a distância do raio
public Color rayColor = Color.red; // Define a cor do raio (apenas visual)

Vector3 origin = transform.position; // Origem do raio: posição do cubo
Vector3 direction = transform.TransformDirection(Vector3.forward); // Direção do raio: frente do cubo, considerando sua rotação

Physics.Raycast(origin, direction, out RaycastHit hit, rayDistance); // Lança o raio
Debug.DrawRay(origin, direction * rayDistance, rayColor); // Desenha o raio no editor
```
