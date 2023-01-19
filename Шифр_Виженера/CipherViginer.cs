namespace Шифр_Виженера
{
    public static class CipherViginer
    {
        public static String EncriptionString(this String str, String key, rasc lang)
        {
            List<char> alphabet = new List<char>();
            const int firstChar = 0;
            int index = firstChar;//индекс символа в строке
            int indexCharString = 0;//индекс первого символа в алфавите
            int indexKey = firstChar;//текущий номер символа ключа
            string result = "";
            int countChar = str.Length;

            switch (lang)
            {
                case rasc.lat:
                    {
                        for (int i = 65; i < 123; i++)
                        {
                            if (char.IsLetter((char)i))
                                alphabet.Add((char)i);
                        }
                    }
                    break;
                case rasc.kir:
                    {
                        for (int i = 1040; i < 1072; i++)
                        {
                            if (char.IsLetter((char)i))
                                alphabet.Add((char)i);
                        }
                    } 
                    break;
                default:
                    {
                        throw new Exception("Выберите одну из раскладок");
                    }
            }
            for(int i = 0 ; i < str.Length; i++)
            {
                if (!alphabet.Contains(str[i]))
                {
                    result+= str[i];
                }
                else
                {
                    index = alphabet.FindIndex((char x) => x == str[i]);
                    var indexCipher = alphabet.FindIndex(x => x == key[indexKey]);
                    result += alphabet[(indexCipher + index) % alphabet.Count];
                    indexKey = (indexKey + 1) % key.Length;
                }
            }

            return result;
        }
    }

    public enum rasc
    {
        lat,
        kir
    }
     
}