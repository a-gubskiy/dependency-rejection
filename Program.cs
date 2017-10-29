using System;

namespace DR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var itemId = 1;
            IRepository repository = new Repository();


            IValidtor validatorA = new ValidatorA(repository);
            IValidtor validatorB = new ValidatorB(GetItem);
            IValidtor validatorC = new ValidatorC();

            var resultA = validatorA.Validate(itemId);
            var resultB = validatorB.Validate(itemId);
            var resultC = validatorC.Validate(itemId);
        }

        public static object GetItem(int itemId)
        {
            IRepository repository = new Repository();
            return repository.GetItem(itemId);
        }
    }
}
