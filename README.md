🐸 Froggy Quest
🎮 Um jogo de plataforma 2D desenvolvido na Unity, onde você controla um sapo aventureiro coletando maçãs, evitando perigos e avançando por múltiplas fases até alcançar a grande vitória!

🕹️ Descrição do Jogo & Controles
🎯 Objetivo do Jogo

Ajude o sapo Froggy a:

✔ Coletar o maior número de maçãs 🍎
✔ Evitar armadilhas mortais (serras, espinhos, plataformas que caem)
✔ Derrotar inimigos
✔ Chegar ao checkpoint final de cada fase
✔ E, na fase 5, alcançar a tela de vitória! 🏆

Cada fase apresenta desafios mais difíceis, exigindo reflexos rápidos e controle preciso.

🕹️ Controles
Ação	Tecla
Mover para a direita	➡️
Mover para a esquerda	⬅️
Pular	Barra de Espaço
Pulo Duplo	Toque novamente Espaço no ar

📖 3️⃣ História do Jogo

Na floresta encantada de Greenwood, vive Froggy um jovem sapo sonhador que deseja alcançar o lendário Pomar Dourado, onde crescem maçãs mágicas capazes de conceder grande sabedoria.

Porém, este caminho não será fácil:

-Plataformas instáveis

-Armadilhas traiçoeiras

-Inimigos ferozes

Perigos crescentes a cada fase

Mesmo assim, Froggy segue firme, movido pela coragem e pelo desejo de provar seu valor.
Sua missão:

🍏 Coletar as maçãs, sobreviver aos desafios e chegar ao topo da floresta.
💛 E, na última fase, finalmente conquistar sua vitória gloriosa!

🎥 4️⃣ Vídeo do Jogo (Gameplay)

https://github.com/user-attachments/assets/02494fe5-79a9-4934-91e2-bd917ccc38f9


📸 5️⃣ Prints do Jogo

<img width="1399" height="580" alt="Menu" src="https://github.com/user-attachments/assets/ea3123e7-3938-4fcd-b594-bce44610439c" />
<img width="1211" height="505" alt="lv04" src="https://github.com/user-attachments/assets/3f61e36c-276f-4638-b4bc-944e7abe270f" />
<img width="1218" height="503" alt="lv3" src="https://github.com/user-attachments/assets/e5a6fa83-b5b8-44d2-99d1-7b045fa8b444" />
<img width="1212" height="505" alt="lv2" src="https://github.com/user-attachments/assets/fb6aeab2-49a3-4fc2-a4f3-c93e3542872e" />
<img width="1212" height="505" alt="lv1" src="https://github.com/user-attachments/assets/dd3745f4-f838-44fe-afea-c366337419d0" />
<img width="1396" height="575" alt="Game Over" src="https://github.com/user-attachments/assets/62d738be-0a82-4f5f-974c-ccbfe4d8cbfe" />
<img width="1403" height="574" alt="Final" src="https://github.com/user-attachments/assets/f48dbe07-9ce6-48ce-8808-a961decb2658" />



🧩 Detalhes Técnicos
🔧 Engine

Unity 6 / Unity 2022 (2D)

⚙️ Sistemas usados

-Rigidbody2D

-BoxCollider2D

-CircleCollider2D

-Trigger colliders

-AudioSource + AudioClip

-Canvas UI + Buttons

-Scene Management


🧠 Scripts Principais
Script	Função
Player.cs	Movimento, pulo e pulo duplo
Apple.cs	Coleta de maçãs e som de coleta
GameController.cs	Pontuação, Game Over, Vitória, reiniciar fase
FallingPlatform.cs	Plataformas que caem após contato
NextLevel.cs	Checar chegada ao checkpoint (troca de fases)
FinalCheckpoint.cs	Ativa tela de vitória na fase 5
Enemy.cs	IA inimiga simples, morte e animação

Correções, Melhoria e Funcionalidades Implementadas Durante o Projeto

Durante o desenvolvimento do Froggy Quest, diversos ajustes, correções e novas funcionalidades foram adicionadas para aprimorar a jogabilidade, estabilidade e qualidade geral do projeto. Abaixo estão as principais melhorias realizadas:

✔ Sistema de Game Over totalmente reconstruído

-Nova UI de Game Over criada.

-Implementado botão funcional de Reiniciar Fase.

-Som de derrota configurado.

-Game Over agora pausa a música corretamente.

✔ Adição de Música ao Jogo e Sistema de Áudio Corrigido

-Música de fundo adicionada ao menu e todas as fases.

-Criado prefab MusicManager dedicado para controlar as trilhas.

-Corrigido bug onde duas músicas tocavam ao mesmo tempo.

-Removido o uso incorreto de DontDestroyOnLoad, evitando música duplicada.

-Implementado controle de áudio dentro do GameController para:

-Parar música ao morrer.

-Parar música ao vencer.

-Reiniciar música ao reiniciar a fase.

✔ Correções importantes no código

-Corrigidos erros de NullReferenceException em:

-GameController

-ScoreText

-Painel de Game Over

-Checkpoints

-Ajustados scripts que dependiam de referências específicas entre cenas.

-Reorganização lógica do GameController:

-ShowGameOver()

-RestartCurrentLevel()

-ShowVictory()

-GoToMenu()

-Sistema agora estável entre troca de cenas.

✔ Criação da Tela de Vitória (Victory Screen)

-Criado painel Victory Panel com UI própria.

-Botão funcional de Voltar para o Menu implementado.

-Som de vitória adicionado (opcional).

-Música é interrompida ao vencer, igual no Game Over.

✔ Nova fase criada e configurada (lv_5)

-Fase final adicionada com:

-Plataformas

-Armadilhas

-Enemies

-Checkpoint final especial

-Implementado script FinalCheckpoint:

-Ao tocar nele → ativa Victory Panel

-Fluxo do jogo finalizado com ciclo completo:

-Menu → Fases → Vitória → Voltar ao Menu

✔ UI aprimorada entre todas as cenas

-Painel de Game Over reorganizado.

-Painel de Vitória configurado com:

-Texto grande e centralizado

-Botões com feedback

-Fundo escurecido para foco

-Menu inicial corrigido para funcionar com o novo GameController.

✔ Corretamente estruturado para apresentação

-Fases organizadas e funcionando isoladamente.

-Todas as referências ligadas manualmente:

-ScoreText

-GameOver Panel

-Victory Panel

-MusicManager

-Código limpo e comentado para facilitar avaliação.

✔ Outras melhorias gerais

-Ajustes de bugs na movimentação e colisões.

-Melhorias nos níveis e posicionamento de plataformas.

-Ajuste de volume, sons e efeitos.

-Revisão geral para manter a consistência do projeto.
