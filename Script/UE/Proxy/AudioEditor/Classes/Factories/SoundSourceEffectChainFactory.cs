using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundSourceEffectChainFactory")]
	public partial class USoundSourceEffectChainFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.SoundSourceEffectChainFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}