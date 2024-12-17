using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleEventBase")]
	public partial class UParticleModuleEventBase : UParticleModule, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleEventBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}