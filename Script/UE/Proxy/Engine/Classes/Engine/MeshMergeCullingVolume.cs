using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MeshMergeCullingVolume")]
	public partial class AMeshMergeCullingVolume : AVolume, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MeshMergeCullingVolume");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}