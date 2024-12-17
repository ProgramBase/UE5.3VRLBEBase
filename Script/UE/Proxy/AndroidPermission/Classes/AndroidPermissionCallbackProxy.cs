using Script.CoreUObject;
using Script.Library;

namespace Script.AndroidPermission
{
	[PathName("/Script/AndroidPermission.AndroidPermissionCallbackProxy")]
	public partial class UAndroidPermissionCallbackProxy : UObject, IStaticClass
	{
		public FAndroidPermissionDynamicDelegate OnPermissionsGrantedDynamicDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPermissionsGrantedDynamicDelegate, __ReturnBuffer);

					return *(FAndroidPermissionDynamicDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPermissionsGrantedDynamicDelegate, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AndroidPermission.AndroidPermissionCallbackProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __OnPermissionsGrantedDynamicDelegate = 0;
	}
}