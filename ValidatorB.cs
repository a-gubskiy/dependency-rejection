using System;

namespace DR
{
     public class ValidatorB : IValidtor
    {
        private Func<int, object> _getItem;

        public ValidatorB(Func<int, object> getItem)
        {
            _getItem = getItem;
        }

        public bool Validate(int itemId)
        {
            var item = _getItem(itemId);
            return item != null;
        }
    }
}