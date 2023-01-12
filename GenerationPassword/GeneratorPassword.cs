namespace GenerationPassword
{
    public static class GeneratorPassword
    {
        public static string[] Generate(int countPassword, int countChar) 
        {
            string[] passwords = new string[countPassword];

            Random rnd = new Random();

            for(int i = 0; i < countPassword; i++)
            {
                var password = "";


                for (int j = 0; j < countChar; j++)
                {
                    int caps = rnd.Next(2);
                    if (caps == 0)
                    {
                        password += (char)rnd.Next(65, 91);
                    }
                    else
                    {
                        password += (char)rnd.Next(97, 123);
                    }
                }
                passwords[i] = password;
            }
            return passwords;
        }
    }
}