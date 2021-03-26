using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class BaseClass
    {
        public virtual async Task<(bool success, string message)> DoTheThing(int p1, object p2) => await Task.FromResult((true, ""));
    }
}
