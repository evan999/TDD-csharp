﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTests
{
    public class StringUtils
    {
        public int FindNumberOfOccurences(string sentenceToScan, string characterToScanFor)
        {
            // TODO: Implement this method
            var stringToCheckAsCharacterArray = sentenceToScan.ToCharArray();
            var characterToCheckFor = Char.Parse(characterToScanFor);

            var numberOfOccurrences = 0;

            for (var charIdx = 0; charIdx < stringToCheckAsCharacterArray.GetUpperBound(0); charIdx++)
            {
                if (stringToCheckAsCharacterArray[charIdx] == characterToCheckFor)
                {
                    numberOfOccurrences++;
                }
            }
            return numberOfOccurrences;
        }
    }
}
