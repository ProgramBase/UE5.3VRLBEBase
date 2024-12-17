using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SMInstanceManagerProvider")]
	public partial class USMInstanceManagerProvider : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SMInstanceManagerProvider");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.SMInstanceManagerProvider")]
	public interface ISMInstanceManagerProvider : IInterface
	{
	}
}