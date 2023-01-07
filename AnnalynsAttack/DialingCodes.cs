﻿using System.Collections;

namespace AnnalynsAttack
{
    class DialingCodes
    {

        public static Dictionary<int, string> GetEmptyDictionary()
        {
            return new Dictionary<int, string>();
        }

        public static Dictionary<int, string> GetExistingDictionary()
        {
            return new Dictionary<int, string> { {1, "United States of America"}, {55, "Brazil"}, {91, "India"} };
        }

        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            var newDictionary = GetEmptyDictionary(); 
            newDictionary.Add(countryCode, countryName);
            return newDictionary;
        }

        public static Dictionary<int, string> AddCountryToExistingDictionary(Dictionary<int,string> existingDictionary, int countryCode, string countryName)
        {
            existingDictionary.Add(countryCode, countryName);
            return existingDictionary;
        }

        public static string GetCountryNameFromDictionary(Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode) ? existingDictionary[countryCode] : string.Empty;
        }

        public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode);
        }

        public static Dictionary<int, string> UpdateDictionary(Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            if (existingDictionary.ContainsKey(countryCode)) existingDictionary[countryCode] = countryName;
            return existingDictionary;
        }
        public static Dictionary<int, string> RemoveCountryFromDictionary(Dictionary<int, string> existingDictionary, int countryCode)
        {
            existingDictionary.Remove(countryCode);
            return existingDictionary;
        }

        public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
        {
            string longestCountry = "";
            
            foreach (KeyValuePair<int, string> entry in existingDictionary)
            {
                if (entry.Value.Length > longestCountry.Length) longestCountry = entry.Value;
            }
            return longestCountry;
        }
    }
}
