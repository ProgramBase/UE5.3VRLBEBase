using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;

namespace Script.StatusBar
{
	[PathName("/Script/StatusBar.StatusBarSubsystem")]
	public partial class UStatusBarSubsystem : UEditorSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/StatusBar.StatusBarSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}