class Reference
{


    private static string _book;
    private static int _chapter;
    private static int _startVerse;
    private static int _endVerse;

    public static string reference()
    {

        _book ="Proverbs";
        _chapter = 3;
        _startVerse = 5;
        _endVerse= 6;
        string _fullRefrence = ($"{_book} {_chapter}: {_startVerse} - {_endVerse} ");

        return _fullRefrence;
    }



}