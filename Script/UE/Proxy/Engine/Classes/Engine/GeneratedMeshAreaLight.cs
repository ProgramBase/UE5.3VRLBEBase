using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.GeneratedMeshAreaLight")]
	public partial class AGeneratedMeshAreaLight : ASpotLight, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.GeneratedMeshAreaLight");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}