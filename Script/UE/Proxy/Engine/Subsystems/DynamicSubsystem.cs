using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DynamicSubsystem")]
	public partial class UDynamicSubsystem : USubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DynamicSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}