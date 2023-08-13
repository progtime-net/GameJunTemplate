namespace GameJun.Interfaces;

public abstract class AbstractCharacter
{
    protected int health;
    protected int defense;
    // Атаковать другого игрока
    public abstract void Attack(AbstractCharacter other);
    // Получить количество урона (учитывая параметр защиты)
    public abstract void Damage(int amount);
    public abstract bool IsAlive();
}