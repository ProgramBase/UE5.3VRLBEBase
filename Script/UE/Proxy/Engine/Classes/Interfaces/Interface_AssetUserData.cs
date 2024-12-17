using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Interface_AssetUserData")]
	public partial class UInterface_AssetUserData : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.Interface_AssetUserData");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.Interface_AssetUserData")]
	public interface IInterface_AssetUserData : IInterface
	{
	}
}