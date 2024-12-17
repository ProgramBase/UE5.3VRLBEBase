using Script.CoreUObject;
using Script.AnimGraph;
using Script.IKRig;
using Script.Library;

namespace Script.IKRigEditor
{
	[PathName("/Script/IKRigEditor.IKRetargetAnimInstance")]
	public partial class UIKRetargetAnimInstance : UAnimPreviewInstance, IStaticClass
	{
		public FAnimNode_PreviewRetargetPose PreviewPoseNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewPoseNode, __ReturnBuffer);

					return *(FAnimNode_PreviewRetargetPose*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewPoseNode, __InBuffer);
				}
			}
		}

		public FAnimNode_RetargetPoseFromMesh RetargetNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RetargetNode, __ReturnBuffer);

					return *(FAnimNode_RetargetPoseFromMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RetargetNode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IKRigEditor.IKRetargetAnimInstance");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PreviewPoseNode = 0;

		private static uint __RetargetNode = 0;
	}
}