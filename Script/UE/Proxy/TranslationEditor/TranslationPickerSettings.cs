using Script.CoreUObject;
using Script.Library;

namespace Script.TranslationEditor
{
	[PathName("/Script/TranslationEditor.TranslationPickerSettings")]
	public partial class UTranslationPickerSettings : UObject, IStaticClass
	{
		public bool bSubmitTranslationPickerChangesToLocalizationService
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSubmitTranslationPickerChangesToLocalizationService, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSubmitTranslationPickerChangesToLocalizationService, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TranslationEditor.TranslationPickerSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bSubmitTranslationPickerChangesToLocalizationService = 0;
	}
}