using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleSubUVBase")]
	public partial class UParticleModuleSubUVBase : UParticleModule, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleSubUVBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}