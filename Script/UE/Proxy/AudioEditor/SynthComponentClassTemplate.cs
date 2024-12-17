using Script.CoreUObject;
using Script.GameProjectGeneration;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SynthComponentClassTemplate")]
	public partial class USynthComponentClassTemplate : UClassTemplate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.SynthComponentClassTemplate");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}