using Script.CoreUObject;
using Script.AnimGraphRuntime;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimGraphNode_RotationOffsetBlendSpaceGraph")]
	public partial class UAnimGraphNode_RotationOffsetBlendSpaceGraph : UAnimGraphNode_BlendSpaceGraphBase, IStaticClass
	{
		public FAnimNode_RotationOffsetBlendSpaceGraph Node
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Node, __ReturnBuffer);

					return *(FAnimNode_RotationOffsetBlendSpaceGraph*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Node, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimGraphNode_RotationOffsetBlendSpaceGraph");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Node = 0;
	}
}