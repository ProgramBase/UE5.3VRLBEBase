using Script.CoreUObject;
using Script.AnimGraph;
using Script.IKRig;
using Script.Library;

namespace Script.IKRigEditor
{
	[PathName("/Script/IKRigEditor.IKRigAnimInstance")]
	public partial class UIKRigAnimInstance : UAnimPreviewInstance, IStaticClass
	{
		public FAnimNode_IKRig IKRigNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __IKRigNode, __ReturnBuffer);

					return *(FAnimNode_IKRig*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __IKRigNode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IKRigEditor.IKRigAnimInstance");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __IKRigNode = 0;
	}
}