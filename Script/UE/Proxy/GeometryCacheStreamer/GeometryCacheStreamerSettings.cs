using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.GeometryCacheStreamer
{
	[PathName("/Script/GeometryCacheStreamer.GeometryCacheStreamerSettings")]
	public partial class UGeometryCacheStreamerSettings : UDeveloperSettings, IStaticClass
	{
		public float LookAheadBuffer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LookAheadBuffer, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LookAheadBuffer, __InBuffer);
				}
			}
		}

		public float MaxMemoryAllowed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxMemoryAllowed, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxMemoryAllowed, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCacheStreamer.GeometryCacheStreamerSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __LookAheadBuffer = 0;

		private static uint __MaxMemoryAllowed = 0;
	}
}