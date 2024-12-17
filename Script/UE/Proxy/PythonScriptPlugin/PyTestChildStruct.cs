using Script.CoreUObject;
using Script.Library;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.PyTestChildStruct")]
	public partial class FPyTestChildStruct : FPyTestStruct, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/PythonScriptPlugin.PyTestChildStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPyTestChildStruct()
		{
		}

		public static bool operator ==(FPyTestChildStruct A, FPyTestChildStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPyTestChildStruct A, FPyTestChildStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPyTestChildStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}