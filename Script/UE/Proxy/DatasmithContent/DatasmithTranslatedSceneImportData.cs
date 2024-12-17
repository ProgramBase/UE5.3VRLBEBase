using Script.CoreUObject;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithTranslatedSceneImportData")]
	public partial class UDatasmithTranslatedSceneImportData : UDatasmithSceneImportData, IStaticClass
	{
		public TArray<UDatasmithOptionsBase> AdditionalOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AdditionalOptions, __ReturnBuffer);

					return *(TArray<UDatasmithOptionsBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AdditionalOptions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DatasmithContent.DatasmithTranslatedSceneImportData");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AdditionalOptions = 0;
	}
}