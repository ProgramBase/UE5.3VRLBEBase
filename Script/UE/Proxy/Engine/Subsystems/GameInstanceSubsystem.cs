using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.GameInstanceSubsystem")]
	public partial class UGameInstanceSubsystem : USubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.GameInstanceSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}