public class ENGStrategy : ILanguageStrategy
{
    public string GetSentence(TextLine line) => line.ENGsentence;
}

public class THAIStrategy : ILanguageStrategy
{
    public string GetSentence(TextLine line) => line.Thaisentence;
}

public class JPStrategy : ILanguageStrategy
{
    public string GetSentence(TextLine line) => line.Jpsentence;
}
