using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LineBatchComponent")]
	public partial class ULineBatchComponent : UPrimitiveComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LineBatchComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}