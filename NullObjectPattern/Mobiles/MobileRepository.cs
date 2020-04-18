namespace NullObjectPattern
{
    public class MobileRepository
    {
        public IMobile GetMobileByName(string mobileName)
        {
            IMobile mobile = NullMobile.Instance;
            switch (mobileName)
            {
                case "sony":
                    mobile = new SonyXperia();
                    break;

                case "apple":
                    mobile = new AppleIPhone();
                    break;

                case "samsung":
                    mobile = new SamsungGalaxy();
                    break;
            }
            return mobile;
        }
    }
}
