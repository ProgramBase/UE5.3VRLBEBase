using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LevelEditor2DSettings")]
	public partial class ULevelEditor2DSettings : UDeveloperSettings, IStaticClass
	{
		public bool bEnable2DWidget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnable2DWidget, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnable2DWidget, __InBuffer);
				}
			}
		}

		public bool bEnableSnapLayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableSnapLayers, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableSnapLayers, __InBuffer);
				}
			}
		}

		public ELevelEditor2DAxis SnapAxis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SnapAxis, __ReturnBuffer);

					return *(ELevelEditor2DAxis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SnapAxis, __InBuffer);
				}
			}
		}

		public TArray<FMode2DLayer> SnapLayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SnapLayers, __ReturnBuffer);

					return *(TArray<FMode2DLayer>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SnapLayers, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.LevelEditor2DSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bEnable2DWidget = 0;

		private static uint __bEnableSnapLayers = 0;

		private static uint __SnapAxis = 0;

		private static uint __SnapLayers = 0;
	}
}