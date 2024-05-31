
namespace LLM.CheckSummer.Actions
{
    internal interface IAction
    {
        public void Start();

        public string[] GetData();
        public IAction SetData(params string[] datas);
    }
}
