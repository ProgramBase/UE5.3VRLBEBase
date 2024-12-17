using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.VoiceChannel")]
	public partial class UVoiceChannel : UChannel, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.VoiceChannel");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}