using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ShadingModelMaterialInput")]
	public partial class FShadingModelMaterialInput : FMaterialInput, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ShadingModelMaterialInput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FShadingModelMaterialInput()
		{
		}

		public static bool operator ==(FShadingModelMaterialInput A, FShadingModelMaterialInput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FShadingModelMaterialInput A, FShadingModelMaterialInput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FShadingModelMaterialInput;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}