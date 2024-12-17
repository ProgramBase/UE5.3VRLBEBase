using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorPerformanceProjectSettings")]
	public partial class UEditorPerformanceProjectSettings : UDeveloperSettings, IStaticClass
	{
		public EScreenPercentageMode RealtimeScreenPercentageMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RealtimeScreenPercentageMode, __ReturnBuffer);

					return *(EScreenPercentageMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RealtimeScreenPercentageMode, __InBuffer);
				}
			}
		}

		public EScreenPercentageMode MobileScreenPercentageMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MobileScreenPercentageMode, __ReturnBuffer);

					return *(EScreenPercentageMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MobileScreenPercentageMode, __InBuffer);
				}
			}
		}

		public EScreenPercentageMode VRScreenPercentageMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VRScreenPercentageMode, __ReturnBuffer);

					return *(EScreenPercentageMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VRScreenPercentageMode, __InBuffer);
				}
			}
		}

		public EScreenPercentageMode PathTracerScreenPercentageMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PathTracerScreenPercentageMode, __ReturnBuffer);

					return *(EScreenPercentageMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PathTracerScreenPercentageMode, __InBuffer);
				}
			}
		}

		public EScreenPercentageMode NonRealtimeScreenPercentageMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NonRealtimeScreenPercentageMode, __ReturnBuffer);

					return *(EScreenPercentageMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NonRealtimeScreenPercentageMode, __InBuffer);
				}
			}
		}

		public float ManualScreenPercentage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ManualScreenPercentage, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ManualScreenPercentage, __InBuffer);
				}
			}
		}

		public int MinViewportRenderingResolution
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinViewportRenderingResolution, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinViewportRenderingResolution, __InBuffer);
				}
			}
		}

		public int MaxViewportRenderingResolution
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxViewportRenderingResolution, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxViewportRenderingResolution, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.EditorPerformanceProjectSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __RealtimeScreenPercentageMode = 0;

		private static uint __MobileScreenPercentageMode = 0;

		private static uint __VRScreenPercentageMode = 0;

		private static uint __PathTracerScreenPercentageMode = 0;

		private static uint __NonRealtimeScreenPercentageMode = 0;

		private static uint __ManualScreenPercentage = 0;

		private static uint __MinViewportRenderingResolution = 0;

		private static uint __MaxViewportRenderingResolution = 0;
	}
}