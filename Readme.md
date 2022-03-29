# Dig the grave

##### Jogo de plataforma onde você é um corvo e tentará sair do cemitério mas, nunca te disseram que seria tão difícil assim voltar a terra dos vivos. O objetivo sempre será voar o mais rápido, o mais ágil, sem colidir com os pedaços de madeira que atrapalham o seu caminho. 

<div align="center"><img src="https://img.itch.zone/aW1nLzg1Mjk1MTEuanBn/347x500/LNeUU%2F.jpg" alt="dig_the_grave.logo" width="60%"></div>

---

Meu objetivo aqui, foi recriar um clássico, com uma estética um pouco mais próxima ao meu gosto pessoal. Visto que o foco foi treinar meus conhecimentos em C# e programação, em geral, voltada a games, pude exercitar alguns conceitos vistos em materiais 3D porém, agora, pela primeira vez, articulando com 2D. 

Detalhes importantes como não precisar declarar uma variável pública para que a mesma apareça no Inspector, limitador de interação entre scripts e variáveis e até o uso de Variáveis Compartilhadas, que simplificam e unificam valores necessários para diferentes componentes. 

```csharp
[SerializeField]
    private GameObject botaoSair;
```

```csharp
public int Pontos {get; private set ;}
```

Sair do 3D para o 2D traz diferenças bem perceptíveis além dos vetores de posicionamento. A Unity, por padrão, segue o Vector3 mesmo em jogos que não fazem tanto uso do eixo Z diretamente. No entanto, foi bem claro que o 2D envolve controles de formas mais simples que o 3D, pelo menos no projeto atual. 

Além desses aspectos, revisei conteúdo relacionado a física dentro da engine tal como Rigid Bodies, Colliders e outros. Foi a primeira vez que construí um jogo praticamente do zero. Ficou em minhas mãos o trabalho de buscar assets, encaixar e criar uma atmosfera e unir desde som a UI. 

---

Inspirado pela dinâmica de Flappy Bird, Dig The Grave foi um projeto desenvolvido durante a minha Formação Jogos com Unity, da Alura. Todos os assets utilizados nesse arquivo foram obtidos através dos sites UnityStore e FreeSound. 