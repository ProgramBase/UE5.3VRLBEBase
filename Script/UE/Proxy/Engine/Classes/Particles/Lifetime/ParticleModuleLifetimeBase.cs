using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleLifetimeBase")]
	public partial class UParticleModuleLifetimeBase : UParticleModule, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleLifetimeBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}