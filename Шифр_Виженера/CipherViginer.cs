namespace Шифр_Виженера
{
    public static class CipherViginer
    {
        public static String EncriptionString(this String str, String key, rasc lang)
        {
            List<char> alphabet = new List<char>();
            const int firstChar = 0;
            int index = firstChar;
            int indexKey = firstChar;
            string result = "";

            switch (lang)
            {
                case rasc.lat:
                    {
                        for (int i = 65; i < 91; i++)
                        {
                            alphabet.Add((char)i);
                        }
                    }
                    break;
                case rasc.kir:
                    {
                        for (int i = 1040; i < 1072; i++)
                        {
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
                //for(int j = 0; j)
                //index
                //result += alphabet[(firstChar + 1) % str.Length];
            }

            return str;
        }
    }

    public enum rasc
    {
        lat,
        kir
    }
}