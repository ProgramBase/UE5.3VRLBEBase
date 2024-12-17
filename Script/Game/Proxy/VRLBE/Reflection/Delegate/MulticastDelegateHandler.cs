using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealCSharp
{
	[PathName("/Script/UnrealCSharp.MulticastDelegateHandler")]
	public partial class UMulticastDelegateHandler : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealCSharp.MulticastDelegateHandler");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void CSharpCallBack()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __CSharpCallBack);
			}
		}

		private static uint __CSharpCallBack = 0;
	}
}