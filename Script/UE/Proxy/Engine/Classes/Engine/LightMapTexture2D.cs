using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LightMapTexture2D")]
	public partial class ULightMapTexture2D : UTexture2D, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LightMapTexture2D");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}