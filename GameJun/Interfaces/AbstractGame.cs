namespace GameJun.Interfaces;

public abstract class AbstractGame
{
    protected AbstractCharacter? player1;
    protected AbstractCharacter? player2;

    // Выбор класса игроков (ввод с клавиатуры)
    public abstract void SelectPlayers();
    // Запуск игры
    public abstract void Start();
    // Производит игровой шаг
    // (два игрока атакуют друг друга,
    // состояние игры после хода выводится на экран) 
    protected abstract void GameStep();
}