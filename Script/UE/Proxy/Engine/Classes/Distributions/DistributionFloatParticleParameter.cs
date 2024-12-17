using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DistributionFloatParticleParameter")]
	public partial class UDistributionFloatParticleParameter : UDistributionFloatParameterBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DistributionFloatParticleParameter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}