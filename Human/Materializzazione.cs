namespace Human
{
    public class Materializzazione
    {

        public IEnumerable<int> CountUntil10()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }


        public List<int> CountUntil10Materializzato()
        {
            var list = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            return list;
        }
    }
}
