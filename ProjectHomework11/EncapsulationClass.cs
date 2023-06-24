namespace ProjectHomework11
{
    internal class EncapsulationClass
    {
        private int _number = 15;
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (_number > 10)
                {
                    value = _number;
                }
                else
                {
                    _number = value;
                }
            }
        }

        public int showPrivateNum()
        {
            return _number;
        }
    }
}
