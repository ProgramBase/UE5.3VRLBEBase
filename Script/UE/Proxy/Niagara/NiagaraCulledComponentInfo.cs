using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraCulledComponentInfo")]
	public partial class FNiagaraCulledComponentInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraCulledComponentInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraCulledComponentInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraCulledComponentInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraCulledComponentInfo A, FNiagaraCulledComponentInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraCulledComponentInfo A, FNiagaraCulledComponentInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraCulledComponentInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}