using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.SynthesisEditor
{
	[PathName("/Script/SynthesisEditor.SynthesisEditorSettings")]
	public partial class USynthesisEditorSettings : UDeveloperSettings, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SynthesisEditor.SynthesisEditorSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}