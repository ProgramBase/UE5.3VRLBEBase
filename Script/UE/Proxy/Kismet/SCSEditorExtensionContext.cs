using Script.CoreUObject;
using Script.Library;

namespace Script.Kismet
{
	[PathName("/Script/Kismet.SCSEditorExtensionContext")]
	public partial class USCSEditorExtensionContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Kismet.SCSEditorExtensionContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}