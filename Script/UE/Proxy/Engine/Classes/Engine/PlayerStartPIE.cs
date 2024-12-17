using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PlayerStartPIE")]
	public partial class APlayerStartPIE : APlayerStart, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PlayerStartPIE");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}