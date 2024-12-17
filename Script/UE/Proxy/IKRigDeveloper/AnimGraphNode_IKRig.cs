using Script.CoreUObject;
using Script.AnimGraph;
using Script.IKRig;
using Script.Library;

namespace Script.IKRigDeveloper
{
	[PathName("/Script/IKRigDeveloper.AnimGraphNode_IKRig")]
	public partial class UAnimGraphNode_IKRig : UAnimGraphNode_CustomProperty, IStaticClass
	{
		public FAnimNode_IKRig Node
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Node, __ReturnBuffer);

					return *(FAnimNode_IKRig*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IKRigDeveloper.AnimGraphNode_IKRig");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Node = 0;
	}
}