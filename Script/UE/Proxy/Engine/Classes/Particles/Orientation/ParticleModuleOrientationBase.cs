using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleOrientationBase")]
	public partial class UParticleModuleOrientationBase : UParticleModule, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleOrientationBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}