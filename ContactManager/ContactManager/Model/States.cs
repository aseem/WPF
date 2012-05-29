using System.Collections.Generic;

namespace ContactManager.Model
{
    public static class States
    {
        private static readonly List<string> _names;

        static States()
        {
            _names = new List<string>(50);

            _names.Add("Alabama");
            _names.Add("Alaska");
            _names.Add("Arizona");
            _names.Add("Arkansas");
            _names.Add("California");
            _names.Add("Colorado");
            _names.Add("Connecticut");
            _names.Add("Delaware");
            _names.Add("Florida");
            _names.Add("Georgia");
            _names.Add("Hawaii");
            _names.Add("Idaho");
            _names.Add("Illinois");
            _names.Add("Indiana");
            _names.Add("Iowa");
            _names.Add("Kansas");
            _names.Add("Kentucky");
            _names.Add("Louisiana");
            _names.Add("Maine");
            _names.Add("Maryland");
            _names.Add("Massachusetts");
            _names.Add("Michigan");
            _names.Add("Minnesota");
            _names.Add("Mississippi");
            _names.Add("Missouri");
            _names.Add("Montana");
            _names.Add("Nebraska");
            _names.Add("Nevada");
            _names.Add("New Hampshire");
            _names.Add("New Jersey");
            _names.Add("New Mexico");
            _names.Add("New York");
            _names.Add("North Carolina");
            _names.Add("North Dakota");
            _names.Add("Ohio");
            _names.Add("Oklahoma");
            _names.Add("Oregon");
            _names.Add("Pennsylvania");
            _names.Add("Rhode Island");
            _names.Add("South Carolina");
            _names.Add("South Dakota");
            _names.Add("Tennessee");
            _names.Add("Texas");
            _names.Add("Utah");
            _names.Add("Vermont");
            _names.Add("Virginia");
            _names.Add("Washington");
            _names.Add("West Virginia");
            _names.Add("Wisconsin");
            _names.Add("Wyoming");
        }

        public static IList<string> GetNames()
        {
            return _names;
        }
    }
}