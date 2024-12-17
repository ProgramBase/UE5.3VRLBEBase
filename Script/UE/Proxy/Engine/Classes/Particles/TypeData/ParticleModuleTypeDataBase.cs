using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleTypeDataBase")]
	public partial class UParticleModuleTypeDataBase : UParticleModule, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleTypeDataBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}