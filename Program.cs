﻿

namespace CSharpDay;

class Program
{
    static void Main(string[] args)
    {
        var gameLogic = new GameLogic();
        gameLogic.StartGame();
    }
}

class GameLogic
{
    private Player _player;
    private bool _isGameOver = false;

    public void StartGame()
    {
        Init();

        while (!_isGameOver)
        {
            InputHandler();
        }

        Console.WriteLine("게임이 종료되었습니다.");
    }

    private void InputHandler()
    {
        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Escape)
        {
            _isGameOver = true;
        }
    }

    private void Init()
    {
        Console.Clear();
        Console.WriteLine("스파르타 던전에 오신것을 환영합니다.\n이름을 입력하세요.");
        string? playerName = Console.ReadLine();

        if (string.IsNullOrEmpty(playerName))
        {
            Console.WriteLine("잘못된 이름입니다.");
        }
        else
        {
            _player = new Player(playerName);
            Console.WriteLine($"{_player.name}님, 입장하셨습니다.");
        }
    }
}

class Player
{
    public string name;

    public Player(string name)
    {
        this.name = name;
    }
}
