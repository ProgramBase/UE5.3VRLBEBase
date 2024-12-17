using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherEditor
{
	[PathName("/Script/HotPatcherEditor.SpecifyCookFilterSetting")]
	public partial class USpecifyCookFilterSetting : UObject, IStaticClass
	{
		public TArray<FDirectoryPath> AlwayCookFilters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AlwayCookFilters, __ReturnBuffer);

					return *(TArray<FDirectoryPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AlwayCookFilters, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherEditor.SpecifyCookFilterSetting");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AlwayCookFilters = 0;
	}
}