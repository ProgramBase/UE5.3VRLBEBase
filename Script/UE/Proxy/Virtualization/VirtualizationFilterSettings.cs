using Script.CoreUObject;
using Script.Library;

namespace Script.Virtualization
{
	[PathName("/Script/Virtualization.VirtualizationFilterSettings")]
	public partial class UVirtualizationFilterSettings : UObject, IStaticClass
	{
		public TArray<FString> ExcludePackagePaths
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExcludePackagePaths, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExcludePackagePaths, __InBuffer);
				}
			}
		}

		public TArray<FString> IncludePackagePaths
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __IncludePackagePaths, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __IncludePackagePaths, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Virtualization.VirtualizationFilterSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ExcludePackagePaths = 0;

		private static uint __IncludePackagePaths = 0;
	}
}