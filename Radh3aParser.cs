using System.Collections.Generic;
using System.IO;

namespace RD3LanguageInterpreter
{
    public static class Radh3aParser
    {
        public static List<string> Parse(string filePath)
        {
            var text = File.ReadAllText(filePath);

            var d3s = text.TrimFull();
            var ookList = new List<string>();

            var command = "";
            var index = 0;
            foreach (var ch in d3s.ToCharArray())
            {
                command += ch;
                if (index == 7)
                {
                    ookList.Add(command);
                    command = "";
                    index = 0;
                    continue;
                }
                index++;
            }

            return ookList;
        }
    }
}