using Script.CoreUObject;
using Script.Library;

namespace Script.TraceDataFiltering
{
	[PathName("/Script/TraceDataFiltering.SharedFilterPresetContainer")]
	public partial class USharedFilterPresetContainer : UObject, IStaticClass
	{
		public TArray<FFilterData> SharedPresets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SharedPresets, __ReturnBuffer);

					return *(TArray<FFilterData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SharedPresets, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TraceDataFiltering.SharedFilterPresetContainer");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SharedPresets = 0;
	}
}