class Scripture
{
    private List<Word> _scripture = new List<Word>();
    private Reference _reference;

    public Scripture()
    {
        string temp = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        string[] parts = temp.Split(" ");
        foreach (string part in parts)
        {
            Word content = new Word(part);
            _scripture.Add(content);
        }

        _reference = new Reference("John", 3, 16);
    }

    public Scripture(string scripture, string book, int chapter, int verse)
    {
        string[] parts = scripture.Split(" ");
        foreach (string part in parts)
        {
            Word content = new Word(part);
            _scripture.Add(content);
        }

        _reference = new Reference(book, chapter, verse);
    }

    public Scripture(string scripture, string book, int chapter, int verseStart, int verseEnd)
    {
        string[] parts = scripture.Split(" ");
        foreach (string part in parts)
        {
            Word content = new Word(part);
            _scripture.Add(content);
        }

        _reference = new Reference(book, chapter, verseStart, verseEnd);
    }

    public void HideWords(int difficulty)
    {
        Random rng = new Random();
        Boolean hide =  Hidden();
        int i = 0;

        if (difficulty == 2)
        {
            while (i < 2 && !hide)
            {
                int random = rng.Next(_scripture.Count());
                if (!_scripture[random].isHidden())
                {
                    _scripture[random].Hide(_scripture[random]);
                    i++;
                    hide = Hidden();
                }
            }
        }
        else if (difficulty == 4)
        {
            while (i < 4 && !hide)
            {
                int random = rng.Next(_scripture.Count());
                if (!_scripture[random].isHidden())
                {
                    _scripture[random].Hide(_scripture[random]);
                    i++;
                    hide = Hidden();
                }
            }
        }
        else if (difficulty == 6)
        {
            while (i < 6 && !hide)
            {
                int random = rng.Next(_scripture.Count());
                if (!_scripture[random].isHidden())
                {
                    _scripture[random].Hide(_scripture[random]);
                    i++;
                    hide = Hidden();
                }
            }
        }
    }

    public void DisplayScripture()
    {
        Console.Write(_reference.RefToString() + " ");
        foreach (Word word in _scripture)
        {
            Console.Write($"{word.getWord()} ");
        }
    }

    public Boolean Hidden()
    {
        Boolean hidden =  true;
        foreach (Word word in _scripture)
        {
            if (!word.isHidden())
            {
                hidden = false;
            }
        }

        return hidden;
    }
}