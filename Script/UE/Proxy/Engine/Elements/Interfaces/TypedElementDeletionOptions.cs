using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TypedElementDeletionOptions")]
	public partial class FTypedElementDeletionOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.TypedElementDeletionOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementDeletionOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTypedElementDeletionOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTypedElementDeletionOptions A, FTypedElementDeletionOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementDeletionOptions A, FTypedElementDeletionOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementDeletionOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bVerifyDeletionCanHappen
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bVerifyDeletionCanHappen, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bVerifyDeletionCanHappen, __InBuffer);
				}
			}
		}

		public bool bWarnAboutReferences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bWarnAboutReferences, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bWarnAboutReferences, __InBuffer);
				}
			}
		}

		public bool bWarnAboutSoftReferences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bWarnAboutSoftReferences, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bWarnAboutSoftReferences, __InBuffer);
				}
			}
		}

		private static uint __bVerifyDeletionCanHappen = 0;

		private static uint __bWarnAboutReferences = 0;

		private static uint __bWarnAboutSoftReferences = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}