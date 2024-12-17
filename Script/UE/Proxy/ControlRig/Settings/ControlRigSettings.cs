using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigSettings")]
	public partial class UControlRigSettings : UDeveloperSettings, IStaticClass
	{
		public TSoftObjectPtr<UControlRigShapeLibrary> DefaultShapeLibrary
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultShapeLibrary, __ReturnBuffer);

					return *(TSoftObjectPtr<UControlRigShapeLibrary>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultShapeLibrary, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRig.ControlRigSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DefaultShapeLibrary = 0;
	}
}