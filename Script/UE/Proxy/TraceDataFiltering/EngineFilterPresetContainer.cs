using Script.CoreUObject;
using Script.Library;

namespace Script.TraceDataFiltering
{
	[PathName("/Script/TraceDataFiltering.EngineFilterPresetContainer")]
	public partial class UEngineFilterPresetContainer : UObject, IStaticClass
	{
		public TArray<FFilterData> EnginePresets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EnginePresets, __ReturnBuffer);

					return *(TArray<FFilterData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EnginePresets, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TraceDataFiltering.EngineFilterPresetContainer");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EnginePresets = 0;
	}
}