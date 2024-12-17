using Script.CoreUObject;
using Script.AnimGraph;
using Script.ControlRig;
using Script.Library;

namespace Script.ControlRigDeveloper
{
	[PathName("/Script/ControlRigDeveloper.AnimGraphNode_ControlRig")]
	public partial class UAnimGraphNode_ControlRig : UAnimGraphNode_CustomProperty, IStaticClass
	{
		public FAnimNode_ControlRig Node
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Node, __ReturnBuffer);

					return *(FAnimNode_ControlRig*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigDeveloper.AnimGraphNode_ControlRig");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Node = 0;
	}
}