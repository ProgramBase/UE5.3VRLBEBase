using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DialogueSoundWaveProxy")]
	public partial class UDialogueSoundWaveProxy : USoundBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DialogueSoundWaveProxy");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}