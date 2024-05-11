
namespace LLM.CheckSummer.Actions
{
    internal interface IAction
    {
        public void Start();

        public string[] GetData();
        public void SetData(params string[] datas);
    }
}
