﻿namespace PatrickRandoNumber
{
    public class MyNumberGenerator
    {
        public int WhatsMyNumberByName(string name)
        {
            if (name == null || name.Length == 0) throw new ArgumentNullException("name");
            if (name == "Huh") throw new ArgumentException("name can't be huh!");

            var results = 0;

            var lengthOfName = name.Length;
            var randoGen = new Random();
            results = randoGen.Next(lengthOfName * 3);
            return results;
        }

        public int WhatsMyNumberByColor(string knownColor)
        {
            var results = 0;

            var lengthOfColor = knownColor.Length;
            var randoGen = new Random();
            results = randoGen.Next(lengthOfColor * 3);
            return results;
        }
    }

}