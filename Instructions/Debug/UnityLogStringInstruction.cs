namespace Juce.Scripting.Instructions
{
    public class UnityLogStringInstruction : FlowScriptInstruction
    {
        public const string ValueIn = nameof(ValueIn);

        public override void RegisterPorts()
        {
            AddInputPort<string>(ValueIn);
        }

        protected override void Execute()
        {
            string value = GetInputPortValue<string>(ValueIn);

            UnityEngine.Debug.Log(value);
        }
    }
}
