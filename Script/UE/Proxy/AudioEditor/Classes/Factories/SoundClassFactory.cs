using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundClassFactory")]
	public partial class USoundClassFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.SoundClassFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}