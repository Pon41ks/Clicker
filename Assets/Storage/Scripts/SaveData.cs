[System.Serializable]
public class SaveData 
{
    private static SaveData _current;
    public static SaveData Current
    {
        get => _current ??= new SaveData
        {
            coinsCount = 0,
            levels = new [] {true, false, false, false, false, false}
        };
        set
        {
            if (value != null)
            {
                _current = value;
            }
        }
    }

    public int coinsCount;
    public bool[] levels;
}
