bool passwordLengthControl = false;
string password = null;

while (passwordLengthControl==false)
{
    Console.Write("Lütfen parolanızı giriniz=");
	password= Console.ReadLine();
	if (password.Length<6)
	{
		Console.WriteLine("Parolanız minimum 6 karakkterli olmalıdır!");
	}
	else
	{
		passwordLengthControl= true;
	}
}

bool bearingLetters = false;
bool bearingDigits = false;
bool bearingSpecialChars = false;


foreach (char c in password)
{
   
    if (Char.IsLetter(c))
    {
        bearingLetters = true;
    }
    if (Char.IsDigit(c))
    {
        bearingDigits = true;
    }
    if (!Char.IsLetterOrDigit(c))
    {
        bearingSpecialChars = true;
    }
}

if (bearingLetters && bearingDigits && bearingSpecialChars)
{
    Console.WriteLine("Güçlü parola: Parola  harf,  rakam ve alfanümerik olmayan karakterlerden oluşuyor.");
}
else if (bearingLetters && bearingDigits || bearingLetters && bearingSpecialChars || bearingDigits && bearingSpecialChars)
{
    Console.WriteLine("Orta parola: Parola  harf-rakam, harf-alfanümerik olmayan veya rakam-alfanümerik olmayan karakterler ikililerinden oluşuyor.");
}
else
{
    Console.WriteLine("Zayıf parola: Parola sadece  harf, sadece rakam veya sadece alfanümerik olmayan karakterlerden oluşuyor.");
}