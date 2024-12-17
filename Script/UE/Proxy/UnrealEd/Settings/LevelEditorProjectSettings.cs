using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LevelEditorProjectSettings")]
	public partial class ULevelEditorProjectSettings : UDeveloperSettings, IStaticClass
	{
		public bool bEnableViewportSMInstanceSelection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableViewportSMInstanceSelection, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableViewportSMInstanceSelection, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.LevelEditorProjectSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bEnableViewportSMInstanceSelection = 0;
	}
}