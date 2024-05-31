using LLM.CheckSummer.Data;

namespace LLM.CheckSummer.Actions
{
    internal class ArgumentAction : IAction
    {
        private string[] arguments = new string[0];
        private DataMaintainer dataMaintainer = new DataMaintainer();

        public string[] GetData() => arguments;

        public IAction SetData(params string[] datas)
        {
            arguments = datas;
            return this;
        }

        /// <summary>
        /// Check for --compare or --compute args and does the action, 
        /// results in Registry.CurrentUser inside "LLM" Folder
        /// </summary>
        /// <param name="command">argument, either --compare or --compute</param>
        private void RunArg(string command)
        {
            switch (command)
            {
                case "--compare":
                    var comparer = new CompareAction();
                    comparer.SetData(arguments).Start();
                    dataMaintainer.Save(CompareAction.DATA_MAINTAINER_RESULT_KEY, comparer.Result.ToString());
                    dataMaintainer.Save(CompareAction.DATA_MAINTAINER_RESULT_READABLE_KEY, comparer.Info.ToString());
                    break;

                case "--compute":
                    var hash = new HashAction();
                    hash.SetData(arguments).Start();
                    dataMaintainer.Save(HashAction.DATA_MAINTAINER_RESULT_KEY, string.Join('\n', hash.ResultLines));
                    dataMaintainer.Save(HashAction.DATA_MAINTAINER_FILEPATH_KEY, hash.FilePath);
                    break;

                default:
                    Console.WriteLine("[ERROR] Nothing to do, either use --compute or --compare args");
                    Console.ReadKey();
                    break;

            }
        }

        public void Start() => RunArg(arguments[0]);
    }
}
