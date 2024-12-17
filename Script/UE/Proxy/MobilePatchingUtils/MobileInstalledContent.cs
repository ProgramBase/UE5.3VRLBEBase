using Script.CoreUObject;
using Script.Library;

namespace Script.MobilePatchingUtils
{
	[PathName("/Script/MobilePatchingUtils.MobileInstalledContent")]
	public partial class UMobileInstalledContent : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MobilePatchingUtils.MobileInstalledContent");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="PakOrder">
		/// : Content pak priority
		/// </param>
		/// <param name="MountPoint">
		/// : Path to mount the pak at
		/// </param>
		public virtual bool Mount(int PakOrder, FString MountPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = PakOrder;

				*(nint*)(__InBuffer + 4) = MountPoint?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Mount, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetInstalledContentSize()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetInstalledContentSize, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetDiskFreeSpace()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDiskFreeSpace, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __Mount = 0;

		private static uint __GetInstalledContentSize = 0;

		private static uint __GetDiskFreeSpace = 0;
	}
}