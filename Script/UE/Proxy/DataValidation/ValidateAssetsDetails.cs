using Script.CoreUObject;
using Script.Library;

namespace Script.DataValidation
{
	[PathName("/Script/DataValidation.ValidateAssetsDetails")]
	public partial class FValidateAssetsDetails : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DataValidation.ValidateAssetsDetails");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FValidateAssetsDetails() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FValidateAssetsDetails() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FValidateAssetsDetails A, FValidateAssetsDetails B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FValidateAssetsDetails A, FValidateAssetsDetails B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FValidateAssetsDetails;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}