namespace DR
{
    public class ValidatorA : IValidtor
    {
        private IRepository _repository;

        public ValidatorA(IRepository repository)
        {
            _repository = repository;
        }

        public bool Validate(int itemId)
        {
            var item = _repository.GetItem(itemId);
            return item != null;
        }
    }

}