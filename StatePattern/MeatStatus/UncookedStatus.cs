namespace StatePattern.MeatStatus
{
    public class UncookedStatus : Doneness
    {
        public UncookedStatus(Doneness state)
        {
            currentTemp = state.CurrentTemp;
            steak = state.Steak;
            Initialize();
        }

        private void Initialize()
        {
            lowerTemp = 0;
            upperTemp = 130;
            canEat = false;
        }
        public override void IncreaseTemp(double temp)
        {
            currentTemp += temp;
            DonenessCheck();
        }

        public override void DecreaseTemp(double temp)
        {
            currentTemp -= temp;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (currentTemp > upperTemp)
            {
                steak.State = new Rare(this);
            }
        }


    }
}
