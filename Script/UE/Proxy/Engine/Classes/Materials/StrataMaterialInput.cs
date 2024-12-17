using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StrataMaterialInput")]
	public partial class FStrataMaterialInput : FMaterialInput, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.StrataMaterialInput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStrataMaterialInput()
		{
		}

		public static bool operator ==(FStrataMaterialInput A, FStrataMaterialInput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStrataMaterialInput A, FStrataMaterialInput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStrataMaterialInput;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}