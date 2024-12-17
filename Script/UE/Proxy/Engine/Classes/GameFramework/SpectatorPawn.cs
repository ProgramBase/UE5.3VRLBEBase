using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SpectatorPawn")]
	public partial class ASpectatorPawn : ADefaultPawn, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SpectatorPawn");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}