using System.Text.RegularExpressions;

/*
^ - буквосочетание в начале строки
$ - буквосечетание в конце строки
. - любой символ
\. - точка
\s - любой white space
\S - любой сивол кроме white space
\w - любой сивол буквы или цифры: a-zA-Z0-9
\W - любой сивол кроме буквы или цифры
\d - любой символ цифры
\D - любой символ кроме цифры

+ - предыдущий символ повторяется от 1 и более раз
* - предыдущий символ повторяется от 0 и более раз
? - предыдущий символ повторяется от 0 или 1 раз

[^abc]
{6:8}
 
*/


string str = "Бык Тупогуб утупогубенький бычок, у быка бела губа была тупа";

Regex regex = new Regex(@"б(\w*)", RegexOptions.IgnoreCase);

var matches = regex.Matches(str);
if(matches.Count > 0 )
{
    foreach(Match match in matches)
        Console.WriteLine(match.Value);
}

string[] phones = { "123 456-78-90", "1234567890", "123-45", "(999) 999-9999" };

Regex regexPhone = new(@".*\d{3}.*\d{3}.*\d{2}.*\d{2}.*");
foreach(string p in phones)
{
    if(regexPhone.IsMatch(p))
        Console.WriteLine(p);
}

Regex regexEmail = new(@"^[\w_]+[\w\._]*[\w]+[\w\._]*@[\w\._]+\.\w+$");

string[] emails = { "aaaaa@bbbb", "12345@aaa.fff.ccc", "kjhkjhkh", "_a@_._" };

foreach(string e in emails)
    if(regexEmail.IsMatch(e))
        Console.WriteLine(e);

