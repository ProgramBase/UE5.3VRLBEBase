using Script.CoreUObject;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.ReimportSoundFactory")]
	public partial class UReimportSoundFactory : USoundFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.ReimportSoundFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}