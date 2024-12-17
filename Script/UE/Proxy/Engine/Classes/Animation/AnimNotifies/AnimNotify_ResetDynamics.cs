using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNotify_ResetDynamics")]
	public partial class UAnimNotify_ResetDynamics : UAnimNotify, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimNotify_ResetDynamics");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}