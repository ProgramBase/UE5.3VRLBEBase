using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowserData
{
	[PathName("/Script/ContentBrowserData.ContentBrowserDataMenuContext_AddNewMenu")]
	public partial class UContentBrowserDataMenuContext_AddNewMenu : UObject, IStaticClass
	{
		public TArray<FName> SelectedPaths
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedPaths, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedPaths, __InBuffer);
				}
			}
		}

		public bool bContainsValidPackagePath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bContainsValidPackagePath, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bContainsValidPackagePath, __InBuffer);
				}
			}
		}

		public bool bCanBeModified
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCanBeModified, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCanBeModified, __InBuffer);
				}
			}
		}

		public EContentBrowserDataMenuContext_AddNewMenuDomain OwnerDomain
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OwnerDomain, __ReturnBuffer);

					return *(EContentBrowserDataMenuContext_AddNewMenuDomain*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OwnerDomain, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ContentBrowserData.ContentBrowserDataMenuContext_AddNewMenu");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SelectedPaths = 0;

		private static uint __bContainsValidPackagePath = 0;

		private static uint __bCanBeModified = 0;

		private static uint __OwnerDomain = 0;
	}
}