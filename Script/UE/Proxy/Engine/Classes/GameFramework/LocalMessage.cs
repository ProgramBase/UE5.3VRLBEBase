using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LocalMessage")]
	public partial class ULocalMessage : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LocalMessage");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}