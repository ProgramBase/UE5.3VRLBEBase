using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleLocationWorldOffset")]
	public partial class UParticleModuleLocationWorldOffset : UParticleModuleLocation, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleLocationWorldOffset");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}