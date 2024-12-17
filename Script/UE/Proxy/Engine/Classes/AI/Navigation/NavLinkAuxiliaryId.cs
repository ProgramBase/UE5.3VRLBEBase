using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NavLinkAuxiliaryId")]
	public partial class FNavLinkAuxiliaryId : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.NavLinkAuxiliaryId");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNavLinkAuxiliaryId() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNavLinkAuxiliaryId() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNavLinkAuxiliaryId A, FNavLinkAuxiliaryId B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNavLinkAuxiliaryId A, FNavLinkAuxiliaryId B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNavLinkAuxiliaryId;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ulong Id
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Id, __ReturnBuffer);

					return *(ulong*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(ulong*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Id, __InBuffer);
				}
			}
		}

		private static uint __Id = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}