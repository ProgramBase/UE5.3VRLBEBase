using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NullHLODBuilder")]
	public partial class UNullHLODBuilder : UHLODBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.NullHLODBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}