namespace Juce.Scripting.Instructions
{
    public class UnityLogInstruction : FlowScriptInstruction
    {
        public const string ValueIn = nameof(ValueIn);

        public override void RegisterPorts()
        {
            AddInputPort<object>(ValueIn);
        }

        protected override void Execute(Script script)
        {
            object value = GetInputPortValue<object>(ValueIn);

            UnityEngine.Debug.Log(value.ToString());
        }
    }
}
