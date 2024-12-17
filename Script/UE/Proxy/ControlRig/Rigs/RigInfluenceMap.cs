using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigInfluenceMap")]
	public partial class FRigInfluenceMap : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigInfluenceMap");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigInfluenceMap() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigInfluenceMap() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigInfluenceMap A, FRigInfluenceMap B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigInfluenceMap A, FRigInfluenceMap B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigInfluenceMap;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName EventName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EventName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EventName, __InBuffer);
				}
			}
		}

		public TArray<FRigInfluenceEntry> Entries
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Entries, __ReturnBuffer);

					return *(TArray<FRigInfluenceEntry>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Entries, __InBuffer);
				}
			}
		}

		public TMap<FRigElementKey, int> KeyToIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __KeyToIndex, __ReturnBuffer);

					return *(TMap<FRigElementKey, int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __KeyToIndex, __InBuffer);
				}
			}
		}

		private static uint __EventName = 0;

		private static uint __Entries = 0;

		private static uint __KeyToIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}