using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleRotationRateBase")]
	public partial class UParticleModuleRotationRateBase : UParticleModule, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleRotationRateBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}