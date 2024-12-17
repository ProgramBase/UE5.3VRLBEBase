using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundfieldSubmixFactory")]
	public partial class USoundfieldSubmixFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.SoundfieldSubmixFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}