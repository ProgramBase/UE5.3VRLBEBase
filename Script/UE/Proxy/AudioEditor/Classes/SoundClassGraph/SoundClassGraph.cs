using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundClassGraph")]
	public partial class USoundClassGraph : UEdGraph, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.SoundClassGraph");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}