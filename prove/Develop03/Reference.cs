class Reference
{
    private string _book;
    private int _chapter;
    private string _verse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = $"{verse}";
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verse = $"{verseStart}-{verseEnd}";
    }

    public string RefToString()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}