using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimationBlendSpaceSampleGraph")]
	public partial class UAnimationBlendSpaceSampleGraph : UAnimationGraph, IStaticClass
	{
		public UAnimGraphNode_BlendSpaceSampleResult ResultNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ResultNode, __ReturnBuffer);

					return *(UAnimGraphNode_BlendSpaceSampleResult*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ResultNode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimationBlendSpaceSampleGraph");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ResultNode = 0;
	}
}