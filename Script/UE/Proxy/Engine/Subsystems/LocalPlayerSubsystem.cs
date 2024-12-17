using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LocalPlayerSubsystem")]
	public partial class ULocalPlayerSubsystem : USubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LocalPlayerSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}