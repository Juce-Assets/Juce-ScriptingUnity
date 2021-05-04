using UnityEngine;

namespace Juce.Scripting.Instructions
{
    public class GetTransformPositionInstruction : SyncInstruction
    {
        public const string TransformIn = nameof(TransformIn);
        public const string LocalBoolIn = nameof(LocalBoolIn);
        public const string PositionVector3Out = nameof(PositionVector3Out);

        public override void RegisterPorts()
        {
            AddInputPort<Transform>(TransformIn);
            AddInputPort<bool>(LocalBoolIn);
            AddOutputPort<Vector3>(PositionVector3Out);
        }

        protected override void SyncExecute(ScriptingContext scriptingContext)
        {
            Transform transform = GetInputPortValue<Transform>(TransformIn);
            bool local = GetInputPortValue<bool>(LocalBoolIn);

            if (transform == null)
            {
                return;
            }

            Vector3 position;

            if(local)
            {
                position = transform.localPosition;
            }
            else
            {
                position = transform.position;
            }

            SetOutputPortValue(PositionVector3Out, position);
        }
    }
}
