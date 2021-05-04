namespace Juce.Scripting.Instructions
{
    public class UnityLogInstruction : SyncFlowInstruction
    {
        public const string ValueIn = nameof(ValueIn);

        public override void RegisterPorts()
        {
            AddInputPort<object>(ValueIn);
        }

        protected override void SyncExecute(ScriptingContext scriptingContext)
        {
            object value = GetInputPortValue<object>(ValueIn);

            if(value == null)
            {
                return;
            }

            UnityEngine.Debug.Log(value.ToString());
        }
    }
}
