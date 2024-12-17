using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SlateTextureAtlasInterface")]
	public partial class USlateTextureAtlasInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SlateTextureAtlasInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.SlateTextureAtlasInterface")]
	public interface ISlateTextureAtlasInterface : IInterface
	{
	}
}