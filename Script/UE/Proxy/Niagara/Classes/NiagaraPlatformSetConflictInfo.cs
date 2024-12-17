using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraPlatformSetConflictInfo")]
	public partial class FNiagaraPlatformSetConflictInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraPlatformSetConflictInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraPlatformSetConflictInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraPlatformSetConflictInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraPlatformSetConflictInfo A, FNiagaraPlatformSetConflictInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraPlatformSetConflictInfo A, FNiagaraPlatformSetConflictInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraPlatformSetConflictInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int SetAIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SetAIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SetAIndex, __InBuffer);
				}
			}
		}

		public int SetBIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SetBIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SetBIndex, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraPlatformSetConflictEntry> Conflicts
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Conflicts, __ReturnBuffer);

					return *(TArray<FNiagaraPlatformSetConflictEntry>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Conflicts, __InBuffer);
				}
			}
		}

		private static uint __SetAIndex = 0;

		private static uint __SetBIndex = 0;

		private static uint __Conflicts = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}