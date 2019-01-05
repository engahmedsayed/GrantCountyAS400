namespace GrantCountyAs400.Web.Utils
{
    public static class TaxStatusFactory
    {
        public static string TaxStatusCodeToDescription(string taxStatus)
        {
            switch (taxStatus.ToUpperInvariant())
            {
                case "AE":
                    return "Atomic Energy";

                case "CA":
                    return "Common Area";

                case "CE":
                    return "Cemetery";

                case "CI":
                    return "City";

                case "CO":
                    return "County";

                case "DL":
                    return "Deleted Account";

                case "FD":
                    return "Fire District";

                case "FE":
                    return "Federal";

                case "FR":
                    return "Frat/Benev";

                case "HA":
                    return "Housing Authority";

                case "HD":
                    return "Hospital District";

                case "MU":
                    return "Municipal";

                case "NV":
                    return "Negative Value";

                case "OP":
                    return "Operation PR";

                case "PD":
                    return "Port District";

                case "PE":
                    return "Private Exempt";

                case "PU":
                    return "Public Utilities";

                case "RE":
                    return "Religious";

                case "SC":
                    return "School District";

                case "SP":
                    return "School Private";

                case "ST":
                    return "State";

                case "TT":
                    return "TaxT itle";

                case "TX":
                    return "Taxable";

                case "WD":
                    return "Water District";

                default:
                    return "";
            }
        }
    }
}