using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AndroidPermission
{
	[PathName("/Script/AndroidPermission.AndroidPermissionFunctionLibrary")]
	public partial class UAndroidPermissionFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AndroidPermission.AndroidPermissionFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool CheckPermission(FString permission)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = permission?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckPermission, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static UAndroidPermissionCallbackProxy AcquirePermissions(TArray<FString> permissions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = permissions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AcquirePermissions, __InBuffer, __ReturnBuffer);

				return *(UAndroidPermissionCallbackProxy*)__ReturnBuffer;
			}
		}

		private static uint __CheckPermission = 0;

		private static uint __AcquirePermissions = 0;
	}
}