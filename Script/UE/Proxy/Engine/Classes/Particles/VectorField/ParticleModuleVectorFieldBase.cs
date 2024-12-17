using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleVectorFieldBase")]
	public partial class UParticleModuleVectorFieldBase : UParticleModule, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleVectorFieldBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}