namespace Human
{
    public static class ExtensionPerson
    {
        public static string CompleteName(this Person person)
        {
            return $"{person.Surname} {person.Name}";
        }


        public static string DeleteCharA(this string myString)
        {
            return myString.Replace("A", string.Empty);
        }
    }
}
