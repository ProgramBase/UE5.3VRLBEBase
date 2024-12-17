using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleAttractorBase")]
	public partial class UParticleModuleAttractorBase : UParticleModule, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleAttractorBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}