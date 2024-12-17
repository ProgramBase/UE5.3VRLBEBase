using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RigidBodyBase")]
	public partial class ARigidBodyBase : AActor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.RigidBodyBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}