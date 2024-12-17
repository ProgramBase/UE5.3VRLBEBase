using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SMInstanceManager")]
	public partial class USMInstanceManager : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SMInstanceManager");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.SMInstanceManager")]
	public interface ISMInstanceManager : IInterface
	{
	}
}