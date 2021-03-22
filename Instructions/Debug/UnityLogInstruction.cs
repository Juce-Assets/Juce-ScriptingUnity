using Juce.Scripting.Loging;

namespace Juce.Scripting.Instructions
{
    public class UnityLogInstruction : FlowInstruction
    {
        public const string ValueIn = nameof(ValueIn);

        public override void RegisterPorts()
        {
            AddInputPort<object>(ValueIn);
        }

        protected override void Execute(Script script, IScriptLogger scriptLogger)
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
