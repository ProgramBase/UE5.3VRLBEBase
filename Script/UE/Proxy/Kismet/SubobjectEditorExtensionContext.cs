using Script.CoreUObject;
using Script.Library;

namespace Script.Kismet
{
	[PathName("/Script/Kismet.SubobjectEditorExtensionContext")]
	public partial class USubobjectEditorExtensionContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Kismet.SubobjectEditorExtensionContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}