namespace DR
{
    public interface IRepository
    {
        object GetItem(int id);
    }

    public class Repository : IRepository
    {
        public object GetItem(int id)
        {
            if (id == 1)
                return new object();

            return null;
        }
    }

    public static class GlobalRepositorySingletone
    {
        private static IRepository _instance;

        public static IRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Repository();
                    
                return _instance;
            }
        }
    }
}