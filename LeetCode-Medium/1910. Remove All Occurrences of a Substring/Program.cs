namespace _1910._Remove_All_Occurrences_of_a_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveOccurrences("daabcbaabcbc", "abc"));
        }


        public static string RemoveOccurrences(string s, string part)
        {

            int index;
            while ((index = s.IndexOf(part)) != -1)
            {
                s = s.Remove(index, part.Length);
            }
            return s;

        }
    }
}