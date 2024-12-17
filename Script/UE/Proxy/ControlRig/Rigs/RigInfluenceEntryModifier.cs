using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigInfluenceEntryModifier")]
	public partial class FRigInfluenceEntryModifier : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigInfluenceEntryModifier");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigInfluenceEntryModifier() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigInfluenceEntryModifier() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigInfluenceEntryModifier A, FRigInfluenceEntryModifier B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigInfluenceEntryModifier A, FRigInfluenceEntryModifier B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigInfluenceEntryModifier;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigElementKey> AffectedList
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AffectedList, __ReturnBuffer);

					return *(TArray<FRigElementKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AffectedList, __InBuffer);
				}
			}
		}

		private static uint __AffectedList = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}