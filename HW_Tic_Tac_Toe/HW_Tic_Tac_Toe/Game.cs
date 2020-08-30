using System;

namespace HW_Tic_Tac_Toe
{
    public class Game
    {
        private Player _player1 = new Player
        {
            Name = "Hráč číslo 1"
        };

        private Player _player2 = new Player
        {
            Name = "Hráč číslo 2"
        };

        private char[,] _playingField = new char[,]
        {
            {
                '_','_','_'
            },
            {
                '_','_','_'
            },
            {
                '_','_','_'
            }
        };

        private int GetCoordinate(string coordinate)
        {
            do
            {
                Console.WriteLine("{0}: ", coordinate);
                var userInput = Console.ReadLine();
                if (Int32.TryParse(userInput, out int result))
                {
                    return result - 1;
                }
                else
                {
                    Console.WriteLine("Chyba v zadané hodnotě.");
                    Console.WriteLine("Zadejte hodnotu souřadnice {0}.", coordinate);
                }

            } while (true);
        }

        private bool IsFieldProper(int x, int y)
        {
            if (x >= 0 && x < _playingField.GetLength(1) && y >= 0 && y < _playingField.GetLength(0))
            {
                return (_playingField[y, x] == '_') ? true : false;
            }
            else
            {
                return false;
            }
        }

        private void DrawField()
        {
            for (int y = _playingField.GetLength(0) - 1; y >= 0 ; y--)
            {
                for (int x = 0; x < _playingField.GetLength(1); x++)
                {
                    Console.Write("{0} ", _playingField[y, x]);
                }

                Console.WriteLine();
            }
        }

        private void ClearField()
        {
            for (int y = 0; y < _playingField.GetLength(0); y++)
            {
                for (int x = 0; x < _playingField.GetLength(1); x++)
                {
                    _playingField[y, x] = '_';
                }
            }
        }

        private bool IsTie()
        {
            var isTie = true;

            for (int y = 0; y < _playingField.GetLength(0); y++)
            {
                for (int x = 0; x < _playingField.GetLength(1); x++)
                {
                    if (_playingField[y, x] == '_')
                    {
                        isTie = false;
                        break;
                    }
                     
                }
            }

            return isTie;
        }

        private bool IsWinner()
        {
            bool winner = true;

            for (int i = 0; (i < _playingField.GetLength(0) && i < _playingField.GetLength(1)); i++)
            {
                if ((_playingField[0, 0] != _playingField[i, i]) || _playingField[i, i] == '_')
                {
                    winner = false;
                }
            }

            if (winner == true)
            {
                return true;
            }
            else
            {
                winner = true;
            }

            for (int j = 0; (j < _playingField.GetLength(0) && j < _playingField.GetLength(1)); j++)
            {
                if ((_playingField[_playingField.GetLength(0) - 1, 0] != _playingField[_playingField.GetLength(0) - 1 - j, j]) || _playingField[_playingField.GetLength(0) - 1 - j, j] == '_')
                {
                    winner = false;
                }
            }

            if (winner == true)
            {
                return true;
            }
            else
            {
                winner = true;
            }

            for (int y = 0; y < _playingField.GetLength(0); y++)
            {
                for (int x = 0; x < _playingField.GetLength(1); x++)
                {
                    if ((_playingField[y, 0] != _playingField[y, x]) || _playingField[y, x] == '_')
                    {
                        winner = false;
                    }
                }

                if (winner == true)
                {
                    return true;
                }
                else
                {
                    winner = true;
                }
            }

            for (int x = 0; x < _playingField.GetLength(1); x++)
            {
                for (int y = 0; y < _playingField.GetLength(0); y++)
                {
                    if ((_playingField[0, x] != _playingField[y, x]) || _playingField[y, x] == '_')
                    {
                        winner = false;
                    }
                }

                if (winner == true)
                {
                    return true;
                }
                else
                {
                    winner = true;
                }
            }

            return false;
        }

        private void Move(Player player)
        {
            do
            {
                Console.Clear();                
                DrawField();
                Console.WriteLine();
                Console.WriteLine("Na tahu je: {0}", player.Name);
                Console.WriteLine("Zvolte souřadnice: ");
                var coordinateX = GetCoordinate("X");
                var coordinateY = GetCoordinate("Y");

                if (IsFieldProper(coordinateX, coordinateY))
                {
                    _playingField[coordinateY, coordinateX] = player.Symbol;
                    DrawField();
                    break;
                }
                else
                {
                    Console.WriteLine("Políčko se zadanými souřadnicemi je buď obsazené nebo mimo rozsah hracího pole.");
                    Console.WriteLine("Zkuste to znovu.");
                }

                Console.WriteLine("Stiskněte libovolnou klávesu...");
                Console.ReadKey();

            } while (true);
        }

        private void PlayGame()
        {
            var activePlayer = _player1;
            var waitingPlayer = _player2;

            do
            {
                Move(activePlayer);
                Console.Clear();
                DrawField();

                if (IsTie())
                {
                    Console.WriteLine();
                    Console.WriteLine("Remíza!");
                    break;
                }

                if (IsWinner())
                {
                    Console.WriteLine();
                    Console.WriteLine("{0} je vítěz!", activePlayer.Name);
                    break;
                }

                var switchedPlayers = Player.SwitchPlayer(activePlayer, waitingPlayer);
                activePlayer = switchedPlayers.activePlayer;
                waitingPlayer = switchedPlayers.waitingPlayer;
            } while (true);

            Console.WriteLine();
            Console.WriteLine("Chcete začít novou hru?");
            Console.WriteLine();
            Console.WriteLine("Pokud ano, zmáčkněte ENTER.");
            Console.WriteLine("Pokud ne, zmáčkněte kteroukoli jinou klávenu.");
            var doContinue = Console.ReadKey().Key;
            if (doContinue == ConsoleKey.Enter)
            {
                StartAnotherGame();
            }
                
        }

        private void StartAnotherGame()
        {
            ClearField();
            PlayGame();
        }

        public void StartNewGame()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Zvolte si symbol stiskem klávesy o nebo x: ");
                char userInput = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (userInput == 'o' || userInput == 'x')
                {
                    _player1.Symbol = userInput;
                    _player2.Symbol = (userInput == 'o') ? 'x' : 'o';
                    Console.WriteLine("{0} má symbol: {1}", _player1.Name, _player1.Symbol);
                    Console.WriteLine("{0} má symbol: {1}", _player2.Name, _player2.Symbol);
                    Console.WriteLine();
                    Console.WriteLine("Stiskněte libovolnou klávesu...");
                    Console.ReadKey();
                    PlayGame();
                }
                else
                {
                    Console.WriteLine("Byl zvolen symbol, který není v nabídce. Zvolte si prosím symbol z nabídky.");
                }
            } while (true);
        }
    }
}
