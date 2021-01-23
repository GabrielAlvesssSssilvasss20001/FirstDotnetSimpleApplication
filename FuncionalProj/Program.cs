using System;
using System.Globalization; 

namespace FuncionalProj
{
    class Program
    {
        static void Main(string[] args)
        {
            const int c = 30;
            Game[] games = new Game[c];

            Game pinnedGame =  new Game();
                pinnedGame.Title = "Batman - Arkham Knight, by Rocksteady (História Principal)";
                pinnedGame.Year = 2015;
                pinnedGame.Description = "\"Batman: Arkham Knight é um jogo eletrônico de ação-aventura produzido pela Rocksteady Studios e lançado mundialmente 23 de Junho de 2015 pela Warner Bros. Interactive Entertainment para PlayStation 4, Xbox One e Microsoft Windows.\"  WIKI";
                pinnedGame.Organization = "Gabriel Alves - Não tenho formação, sou jogador e a crítica é amadora, mas honesta";
                pinnedGame.Evaluation = " *EVITEI SPOILERS, MAS LEIA COM PRECAUÇÃO* \"A aventura definitiva do Homem-Morcego (trecho por TechTudo) \" contra os criminosos de Gotham City. Batman - Arkham Knight, o último título da épica trilogia desenvolvida pela Rocksteady, elevou o conceito dos jogos de super-heróis. Claro, grande parte do crédito deve ser dado aos seus antecessores, Arkham Asylum (), Arkham City () e até mesmo o avulso Arkham Origins (), desenvolvido pela Warner Bros Montréal, que construiram um legado por meio de uma história sólida, gameplay fluído, personagens marcantes e nostálgicos e trama envolvente. E, justamente por isso, que, para uma nova geração de consoles, não se esperava menos do encerramento da série de games do melhor detetive do mundo. Um jogo marcante, com uma história profunda, que mantém personagens clássicos de um jeito bastante inesperado e acrescenta outros, mais desafiadores, motivados por destruir o Batman e tomar o controle de Gotham de uma vez por todas. O gameplay é tão fluído quanto nos demais títulos e possui novas mecânicas, apesar de repetir uma boa parte das antigas. Precisar de pontos de upgrade para desbloquear algumas habilidades já conhecidas e EXTENSAMENTE usadas nos games anteriores talvez seja um dos únicos pontos frustrantes do jogo. A constução das três regiões principais de Gotham, entretanto, é surpreendente. Os gráficos incríveis e a cidade detalhada tornam sua exploração muito satisfatória, e as novas mecânicas ajudam bastante. Sem falar, é lógico, de um dos principais incrementos do jogo, o Batmóvel, que nos dá novas formas de combater o crime em Gotham: perseguições em alta velocidade, detruição em massa e combates pesados contra drones e helicópteros, fazendo uso da infantaria do modo combate. Assim, com uma continuação incrível e gráficos insanos (para constar: o jogo é de 2015!!!), Batman Arkham Knight merece o título de um dos melhores da geração passada (PS4, XBOX ONE) de vídeo-games e continua imperdível para a nova.";
                pinnedGame.Grade = 9.5;    

            games[0] = pinnedGame;

            int pos = 1;

            string option = ObterOpcao();

            while ((option.ToUpper() != "X") && (pos < c))
            {
                switch (option)
                {
                    case "1":
                            Game game =  new Game();
                            Console.WriteLine("Informe o título do Jogo: ");
                            game.Title = Console.ReadLine();
                            
                            Console.WriteLine("Informe o ano de lançamento do Jogo: ");
                            if(int.TryParse(Console.ReadLine(), out int year))
                            {
                                game.Year = year;    
                            } else
                            {
                                throw new Exception();
                            }

                            Console.WriteLine("Informe a descrição do Jogo: ");
                            game.Description = Console.ReadLine();

                            Console.WriteLine("Informe a organização avaliadora: ");
                            game.Organization = Console.ReadLine();

                            Console.WriteLine("Informe a avaliação extensa do Jogo: ");
                            game.Evaluation = Console.ReadLine();
                            
                            Console.WriteLine("Informe a nota do Jogo (entre 0 e 10): ");
                            if(double.TryParse(Console.ReadLine(), out double grade))
                            {
                                game.Grade = grade;    
                            } else
                            {
                                throw new Exception();
                            }

                            games[pos] = game;

                            pos++;

                        break;

                    case "2":
                            Console.WriteLine("");
                            Console.WriteLine("Lista de Jogos Registrados e Avaliados:");
                            foreach (var gameItem in games)
                            {
                                if (!string.IsNullOrEmpty(gameItem.Title))
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("********************************************");
                                    Console.WriteLine($"{gameItem.Title} - {gameItem.Year} \n ");
                                    Console.WriteLine($"{gameItem.Description} \n ");
                                    Console.WriteLine(" ********* Evaluation ********* ");
                                    Console.WriteLine($"Org: {gameItem.Organization} - Nota: {gameItem.Grade} \n ");
                                    Console.WriteLine($"Avaliação: {gameItem.Evaluation} \n ");
                                    Console.WriteLine("********************************************");
                                    Console.WriteLine("");
                                }
                            }
                        break;
                    case "3":
                            Conceito conceito;

                            double parametr = 8;
                            
                            for (int i = 0; i < c; i++)
                            {
                                if (!string.IsNullOrEmpty(games[i].Title))
                                {
                                    if (games[i].Grade.CompareTo(parametr) == 1)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("********************************************");
                                        Console.WriteLine($"{games[i].Title} - {games[i].Year} \n ");
                                        Console.WriteLine($"{games[i].Description} \n ");
                                        Console.WriteLine(" ********* Evaluation ********* ");
                                        Console.WriteLine($"Org: {games[i].Organization} - Nota: {games[i].Grade} \n ");
                                        Console.WriteLine($"Avaliação: {games[i].Evaluation} \n ");
                                        Console.WriteLine("********************************************");
                                        Console.WriteLine("");

                                        conceito = Conceito.A;
                                        Console.WriteLine($"Conceito do Jogo: {conceito}");
                                    }
                                }
                            }                            
                        break;                
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                option = ObterOpcao();
            }
        }

        private static string ObterOpcao()
        {
            Console.WriteLine("");
            Console.WriteLine("********************************************");
            Console.WriteLine("** Informe a opção desejada: **");
            Console.WriteLine("* Digite 1 para Inserir novo jogo e descrição // 1 - Insert a new game and its description *");
            Console.WriteLine("* Digite 2 para Listar jogos // 2 - List the inserted games *");
            Console.WriteLine("* Digite 3 para listar os jogos mais bem avaliados // 3 - List the greatest games in evaluation terms *");
            Console.WriteLine("* Digite X para SAIR - X - CLOSE the application *");
            Console.WriteLine("********************************************");
            Console.WriteLine("");

            string option = Console.ReadLine();
            return option;
        }
    }
}

// STEPS FOR A SIMPLE GAME EVALUATION APPLICATION:

// -> CHOICE MENU AND 'ObterOpcao' METHOD

// -> GAME STRUCTURE