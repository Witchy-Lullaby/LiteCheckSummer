using System.Text;

namespace LLM.CheckSummer.Actions
{
    internal class CompareAction : IAction
    {
        /// <summary>
        /// Result of matching:
        /// <br></br>true = 2 same checksums, they r matched 
        /// <br></br>false = different checksums, didnt match
        /// </summary>
        public bool Result { get; private set; }
        public StringBuilder Info { get; private set; } = new StringBuilder();

        private string pathDataFirstFile = string.Empty;
        private string pathDataSecondFile = string.Empty;
        private string separatorFirstFile = string.Empty;
        private string separatorSecondFile = string.Empty;

        public const string DATA_MAINTAINER_RESULT_KEY = "COMPARE_HASH_ACTION_RESULT";
        public const string DATA_MAINTAINER_RESULT_READABLE_KEY = "COMPARE_HASH_ACTION_RESULT_READABLE";

        public string[] GetData() => new string[5] { "--compare", pathDataFirstFile, pathDataSecondFile, separatorFirstFile, separatorSecondFile };

        public IAction SetData(params string[] data)
        {
            pathDataFirstFile = data[1];
            pathDataSecondFile = data[2];
            separatorFirstFile = data.Length > 3 ? data[3] : ":";
            separatorSecondFile = data.Length > 4 ? data[4] : ":";

            Console.WriteLine($"[SET DATA]\nFirstFile: {pathDataFirstFile} \nSecondFile: {pathDataSecondFile} \nFirst Separator: {separatorFirstFile} | Second Separator: {separatorSecondFile}\n\n");
            return this;
        }

        public void Start() => Compare(pathDataFirstFile, pathDataSecondFile, separatorFirstFile, separatorSecondFile);

        public bool Compare()
        {
            string[] data = GetData();
            Result = Compare(data[1], data[2], data[3], data[4]);
            return Result;
        }

        public bool Compare(string pathDataFirstFile, string pathDataSecondFile, string separatorFirstFile, string separatorSecondFile)
        {
            string[] firstFileLines = File.ReadAllLines(pathDataFirstFile);
            string[] secondFileLines = File.ReadAllLines(pathDataSecondFile);

            bool isEqualLength = firstFileLines.Length == secondFileLines.Length;

            Info.AppendLine($"[INFO] LINE LENGTH MATCH: {isEqualLength}");

            if (!isEqualLength)
            {
                Info.AppendLine("[ERROR] No need to check further since length arent matching, they are NOT equal");
                return false;
            }

            for (int i = 0; i < firstFileLines.Length; i++)
            {
                if (firstFileLines[i].Length <= 2) continue; //prob empty line we dont care about that
                string[] split = firstFileLines[i].Split(separatorFirstFile);
                if (split == null || split.Length < 2)
                {
                    Info.AppendLine($"[ERROR] We tried to split hash with path in half but we couldn't, double check separator, you gave us: '{separatorFirstFile}', but looks like they separated between with other symbol");
                    return false;
                }
                string firstHash = split[1]; //first file separator TODO: custom player separator

                if (!CheckPair(firstHash, secondFileLines, separatorSecondFile))
                {
                    Info.AppendLine($"[ERROR] We tried our best my dudes, but nothing with this hash: {firstHash} was found in second file, you might wanna double check your separator or second file just doesnt have this hash..");
                    return false;
                }
            }

            Info.AppendLine($"\n[SUCCESS] They purrfectly matched each other, 100%");
            return true;
        }

        private bool CheckPair(string firstHash, string[] whereToCheck, string separator = ":")
        {
            foreach (string secondLine in whereToCheck)
            {
                string[] split = secondLine.Split(separator);
                if (split == null || split.Length < 2) return false; //wrong separator we couldnt cut

                string secondHash = secondLine.Split(separator)[1]; //second file separator TODO: custom player separator
                if (secondHash != firstHash) continue; //didnt find match, check next

                return true; //we did it boys, we found the pair
            }

            return false; //sadge, we did our best iterating entire stack but nothing was found :C
        }


    }
}
