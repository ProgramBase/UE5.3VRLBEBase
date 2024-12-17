using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleMaterialBase")]
	public partial class UParticleModuleMaterialBase : UParticleModule, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleMaterialBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}