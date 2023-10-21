class Word
{
    private string _word;
    private Boolean _hidden;

    public Word(string word, Boolean hidden = false)
    {
        _word = word;
        _hidden = hidden;
    }

    public void Hide(Word word)
    {
        string temp = "";
        for (int x = 0; x < _word.Length; x++)
        {
            temp = $"{temp}" + "_";
        }
        _word = temp;
        _hidden = true;
    }

    public Boolean isHidden()
    {
        return _hidden;
    }

    public string getWord()
    {
        return _word;
    }
}