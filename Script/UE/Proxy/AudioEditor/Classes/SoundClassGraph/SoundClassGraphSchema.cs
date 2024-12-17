using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundClassGraphSchema")]
	public partial class USoundClassGraphSchema : UEdGraphSchema, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.SoundClassGraphSchema");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}