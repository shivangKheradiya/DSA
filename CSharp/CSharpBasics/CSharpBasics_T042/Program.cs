using System;
using System.Linq;

namespace CSharpBasics_T042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] users = { "abc", "def" };
            try
            {
                if (users.Contains("abc"))
                {
                    throw new UserAlreadyLogIn("People is loged In");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
            }
        }
    }

    public class UserAlreadyLogIn : Exception
    {
        public UserAlreadyLogIn() { }
        public UserAlreadyLogIn(string message) : base(message) { }
        public UserAlreadyLogIn(string message, Exception inner) : base(message, inner) { }
        protected UserAlreadyLogIn(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
