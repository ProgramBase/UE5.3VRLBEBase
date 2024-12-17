using Script.CoreUObject;
using Script.Library;

namespace Script.TraceDataFiltering
{
	[PathName("/Script/TraceDataFiltering.LocalFilterPresetContainer")]
	public partial class ULocalFilterPresetContainer : UObject, IStaticClass
	{
		public TArray<FFilterData> UserPresets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UserPresets, __ReturnBuffer);

					return *(TArray<FFilterData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UserPresets, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TraceDataFiltering.LocalFilterPresetContainer");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __UserPresets = 0;
	}
}