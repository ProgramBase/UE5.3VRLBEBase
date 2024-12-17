using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RVOAvoidanceInterface")]
	public partial class URVOAvoidanceInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.RVOAvoidanceInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.RVOAvoidanceInterface")]
	public interface IRVOAvoidanceInterface : IInterface
	{
	}
}