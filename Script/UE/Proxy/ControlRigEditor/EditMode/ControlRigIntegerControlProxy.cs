using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigIntegerControlProxy")]
	public partial class UControlRigIntegerControlProxy : UControlRigControlsProxy, IStaticClass
	{
		public int Integer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Integer, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Integer, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigEditor.ControlRigIntegerControlProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Integer = 0;
	}
}