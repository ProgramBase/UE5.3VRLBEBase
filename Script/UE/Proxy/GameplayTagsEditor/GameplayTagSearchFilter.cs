using Script.CoreUObject;
using Script.ContentBrowser;
using Script.Library;

namespace Script.GameplayTagsEditor
{
	[PathName("/Script/GameplayTagsEditor.GameplayTagSearchFilter")]
	public partial class UGameplayTagSearchFilter : UContentBrowserFrontEndFilterExtension, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTagsEditor.GameplayTagSearchFilter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}