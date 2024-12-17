using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DrawSphereComponent")]
	public partial class UDrawSphereComponent : USphereComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DrawSphereComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}