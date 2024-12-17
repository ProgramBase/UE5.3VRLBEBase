using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleCollisionBase")]
	public partial class UParticleModuleCollisionBase : UParticleModule, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleCollisionBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}