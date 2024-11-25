using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form1 : Form
    {
        // Instância de um objeto Random para gerar números aleatórios
        Random random = new Random();

        // Lista de ícones que serão usados no jogo da memória
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        public Form1()
        {
            InitializeComponent();
            // Atribui os ícones de forma aleatória aos quadrados do jogo
            AssignIconsToSquares();
        }

        /// <summary>
        /// Atribui cada ícone da lista de ícones a um dos quadrados no layout do jogo.
        /// </summary>
        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                // Verifica se o controle atual é um Label
                Label iconLabel = control as Label;

                // Define a cor do texto igual à cor de fundo para ocultar os ícones inicialmente
                if (iconLabel != null)
                {
                    iconLabel.ForeColor = iconLabel.BackColor;

                    // Escolhe um ícone aleatório da lista e o remove para evitar repetições
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        // Variável para armazenar o primeiro ícone clicado
        Label firstClicked = null;

        // Variável para armazenar o segundo ícone clicado
        Label secondClicked = null;

        /// <summary>
        /// Evento acionado quando um quadrado (ícone) é clicado pelo jogador.
        /// </summary>
        private void label_click(object sender, EventArgs e)
        {
            // Se o timer está ativo, ignorar os cliques até ele parar
            if (timer1.Enabled)
                return;

            // Obtém o Label clicado
            Label clickedLabel = sender as Label;

            // Se o jogador já clicou duas vezes, ignorar cliques adicionais
            if (secondClicked != null)
                return;

            if (clickedLabel != null)
            {
                // Ignora cliques em ícones já revelados
                if (clickedLabel.ForeColor == Color.White)
                    return;

                // Verifica se este é o primeiro clique do par
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.White; // Revela o ícone
                    return;
                }

                // Caso contrário, é o segundo clique do par
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.White; // Revela o ícone

                // Verifica se o jogador ganhou após este clique
                CheckForWinner();

                // Se os dois ícones clicados são iguais, resetar as variáveis sem esconder os ícones
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                // Caso contrário, inicia o timer para esconder os ícones após um curto intervalo
                timer1.Start();
            }
        }

        /// <summary>
        /// Evento acionado pelo Timer para esconder ícones não correspondentes.
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Para o timer
            timer1.Stop();

            // Esconde os ícones que não correspondem
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Reseta as variáveis para permitir novos cliques
            firstClicked = null;
            secondClicked = null;
        }

        /// <summary>
        /// Verifica se todos os pares foram encontrados e o jogador ganhou.
        /// </summary>
        private void CheckForWinner()
        {
            // Itera por todos os Labels no layout para verificar se ainda existem ícones ocultos
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    // Se encontrar um ícone oculto, o jogo ainda não acabou
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            // Se nenhum ícone oculto for encontrado, o jogador venceu
            SoundPlayer splayer = new SoundPlayer(@"C:\Windows\Media\Ring06.wav");
            splayer.Play(); // Reproduz um som de vitória
            MessageBox.Show("Parabéns! Você venceu!", "Jogo da Memória"); // Mostra uma mensagem de vitória

            // Fecha o jogo após a vitória
            Close();
        }
    }
}
