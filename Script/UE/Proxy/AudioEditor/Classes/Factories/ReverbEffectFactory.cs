using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.ReverbEffectFactory")]
	public partial class UReverbEffectFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.ReverbEffectFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}