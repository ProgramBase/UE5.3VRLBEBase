using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Interface_CollisionDataProvider")]
	public partial class UInterface_CollisionDataProvider : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.Interface_CollisionDataProvider");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.Interface_CollisionDataProvider")]
	public interface IInterface_CollisionDataProvider : IInterface
	{
	}
}