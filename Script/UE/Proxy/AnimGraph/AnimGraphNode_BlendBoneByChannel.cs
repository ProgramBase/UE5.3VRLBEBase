using Script.CoreUObject;
using Script.AnimGraphRuntime;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimGraphNode_BlendBoneByChannel")]
	public partial class UAnimGraphNode_BlendBoneByChannel : UAnimGraphNode_Base, IStaticClass
	{
		public FAnimNode_BlendBoneByChannel BlendNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlendNode, __ReturnBuffer);

					return *(FAnimNode_BlendBoneByChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlendNode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimGraphNode_BlendBoneByChannel");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __BlendNode = 0;
	}
}