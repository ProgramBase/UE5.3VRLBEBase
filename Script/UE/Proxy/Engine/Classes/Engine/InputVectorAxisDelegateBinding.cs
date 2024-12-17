using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputVectorAxisDelegateBinding")]
	public partial class UInputVectorAxisDelegateBinding : UInputAxisKeyDelegateBinding, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.InputVectorAxisDelegateBinding");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}