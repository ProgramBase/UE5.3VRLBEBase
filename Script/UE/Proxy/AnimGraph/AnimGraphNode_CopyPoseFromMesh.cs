using Script.CoreUObject;
using Script.AnimGraphRuntime;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimGraphNode_CopyPoseFromMesh")]
	public partial class UAnimGraphNode_CopyPoseFromMesh : UAnimGraphNode_Base, IStaticClass
	{
		public FAnimNode_CopyPoseFromMesh Node
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Node, __ReturnBuffer);

					return *(FAnimNode_CopyPoseFromMesh*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimGraphNode_CopyPoseFromMesh");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Node = 0;
	}
}