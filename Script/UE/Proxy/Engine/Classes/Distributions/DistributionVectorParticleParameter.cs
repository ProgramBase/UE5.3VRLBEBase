using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DistributionVectorParticleParameter")]
	public partial class UDistributionVectorParticleParameter : UDistributionVectorParameterBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DistributionVectorParticleParameter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}