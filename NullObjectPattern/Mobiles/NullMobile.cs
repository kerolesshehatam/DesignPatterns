namespace NullObjectPattern
{
    //our null object class implementing IMobile interface as a singleton  
    public class NullMobile : IMobile
    {
        private static readonly NullMobile _instance;
        private NullMobile()
        { }

        public static NullMobile Instance
        {
            get
            {
                if (_instance == null)
                {
                    return new NullMobile();
                }

                return _instance;
            }
        }

        //do nothing methods  
        public void TurnOff()
        { }

        public void TurnOn()
        { }
    }
}
