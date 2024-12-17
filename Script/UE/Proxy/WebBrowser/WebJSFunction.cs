using Script.CoreUObject;
using Script.Library;

namespace Script.WebBrowser
{
	[PathName("/Script/WebBrowser.WebJSFunction")]
	public partial class FWebJSFunction : FWebJSCallbackBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/WebBrowser.WebJSFunction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWebJSFunction()
		{
		}

		public static bool operator ==(FWebJSFunction A, FWebJSFunction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWebJSFunction A, FWebJSFunction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWebJSFunction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}