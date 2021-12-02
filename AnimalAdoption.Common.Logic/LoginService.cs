using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class LoginService
    {
        public string[] GetLoginIds()
        {
            return new string[]
            {
                "pencil",
                "flower",
                "icecream",
                "basketball",
                "orange",
                "placeholder"
            };
        }

        public string GetLoginUserFromId(string id)
        {
            //switch name to convert from object to name
            string name = "";
            switch (id)
            {
                case "pencil":
                    name = "sangmoon";
                    break;
                case "flower":
                    name = "chulman";
                    break;
                case "icecream":
                    name = "jaeduk";
                    break;
                case "basketball":
                    name = "chanjae";
                    break;
                case "orange":
                    name = "michael";
                    break;
                case "placeholder":
                    name = "Placeholder ";
                    break;
            }
            return name;
        }
    }
}
