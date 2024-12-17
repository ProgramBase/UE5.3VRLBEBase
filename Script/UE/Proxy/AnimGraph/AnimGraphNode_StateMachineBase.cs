using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimGraphNode_StateMachineBase")]
	public partial class UAnimGraphNode_StateMachineBase : UAnimGraphNode_Base, IStaticClass
	{
		public UAnimationStateMachineGraph EditorStateMachineGraph
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditorStateMachineGraph, __ReturnBuffer);

					return *(UAnimationStateMachineGraph*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditorStateMachineGraph, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimGraphNode_StateMachineBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EditorStateMachineGraph = 0;
	}
}