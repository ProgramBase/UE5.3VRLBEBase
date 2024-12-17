using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ParticleSystemFactoryNew")]
	public partial class UParticleSystemFactoryNew : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ParticleSystemFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}