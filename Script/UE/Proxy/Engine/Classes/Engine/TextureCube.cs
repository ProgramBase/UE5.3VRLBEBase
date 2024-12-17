using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TextureCube")]
	public partial class UTextureCube : UTexture, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.TextureCube");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}