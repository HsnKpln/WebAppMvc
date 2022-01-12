using System.Diagnostics;

namespace WebAppMvc.injectOrnek
{
    public class MyDependency : IMyDependency
    {
        public void Log(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
