using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ObjectTraceWorldSubsystem")]
	public partial class UObjectTraceWorldSubsystem : UWorldSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ObjectTraceWorldSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}