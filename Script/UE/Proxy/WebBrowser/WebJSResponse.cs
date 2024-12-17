using Script.CoreUObject;
using Script.Library;

namespace Script.WebBrowser
{
	[PathName("/Script/WebBrowser.WebJSResponse")]
	public partial class FWebJSResponse : FWebJSCallbackBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/WebBrowser.WebJSResponse");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWebJSResponse()
		{
		}

		public static bool operator ==(FWebJSResponse A, FWebJSResponse B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWebJSResponse A, FWebJSResponse B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWebJSResponse;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}