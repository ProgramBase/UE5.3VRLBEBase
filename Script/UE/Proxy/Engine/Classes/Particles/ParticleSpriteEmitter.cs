using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleSpriteEmitter")]
	public partial class UParticleSpriteEmitter : UParticleEmitter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleSpriteEmitter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}