using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimationCustomTransitionGraph")]
	public partial class UAnimationCustomTransitionGraph : UAnimationGraph, IStaticClass
	{
		public UAnimGraphNode_CustomTransitionResult MyResultNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MyResultNode, __ReturnBuffer);

					return *(UAnimGraphNode_CustomTransitionResult*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MyResultNode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimationCustomTransitionGraph");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MyResultNode = 0;
	}
}