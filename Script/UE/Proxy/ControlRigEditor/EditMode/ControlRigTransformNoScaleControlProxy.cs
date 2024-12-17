using Script.CoreUObject;
using Script.AnimationCore;
using Script.Library;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigTransformNoScaleControlProxy")]
	public partial class UControlRigTransformNoScaleControlProxy : UControlRigControlsProxy, IStaticClass
	{
		public FTransformNoScale Transform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Transform, __ReturnBuffer);

					return *(FTransformNoScale*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Transform, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigEditor.ControlRigTransformNoScaleControlProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Transform = 0;
	}
}