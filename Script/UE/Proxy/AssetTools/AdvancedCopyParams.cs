using Script.CoreUObject;
using Script.Library;

namespace Script.AssetTools
{
	[PathName("/Script/AssetTools.AdvancedCopyParams")]
	public partial class FAdvancedCopyParams : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AssetTools.AdvancedCopyParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAdvancedCopyParams() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAdvancedCopyParams() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAdvancedCopyParams A, FAdvancedCopyParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAdvancedCopyParams A, FAdvancedCopyParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAdvancedCopyParams;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}