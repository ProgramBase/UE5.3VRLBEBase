using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleEventSendToGame")]
	public partial class UParticleModuleEventSendToGame : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleEventSendToGame");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}