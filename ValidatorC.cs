namespace DR
{
    public class ValidatorC : IValidtor
    {
        public bool Validate(int itemId)
        {
            var item = GlobalRepositorySingletone.Instance.GetItem(itemId);
            return item != null;
        }
    }
}