public class LanguageContext
{
    public ILanguageStrategy Strategy { get; private set; }

    public void SetStrategy(ILanguageStrategy strategy)
    {
        Strategy = strategy;
    }

    public string GetText(TextLine line)
    {
        return Strategy.GetSentence(line);
    }
}
