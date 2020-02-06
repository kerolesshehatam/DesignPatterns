namespace StatePattern.MeatStatus
{
    public class Rare : Doneness
    {
        private readonly UncookedStatus uncookedStatus;
        public Rare(Doneness state) : this(state.CurrentTemp, state.Steak)
        {
        }
        public Rare(double currentTemp, Steak steak)
        {
            this.currentTemp = currentTemp;
            this.steak = steak;
            Initialize();
        }

        private void Initialize()
        {
            lowerTemp = 130;
            upperTemp = 139.999999999999;
            canEat = true;
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
            if (currentTemp < lowerTemp)
            {
                steak.State = new UncookedStatus(this);
            }
            else if (currentTemp > upperTemp)
            {
                steak.State = new MediumRare(this);
            }
        }


    }
}