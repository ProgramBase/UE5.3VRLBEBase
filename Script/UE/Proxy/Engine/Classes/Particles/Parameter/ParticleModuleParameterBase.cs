using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleParameterBase")]
	public partial class UParticleModuleParameterBase : UParticleModule, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleParameterBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}