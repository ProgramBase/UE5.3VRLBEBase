using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavLinkCustomInstanceData")]
	public partial class FNavLinkCustomInstanceData : FActorComponentInstanceData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NavigationSystem.NavLinkCustomInstanceData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNavLinkCustomInstanceData()
		{
		}

		public static bool operator ==(FNavLinkCustomInstanceData A, FNavLinkCustomInstanceData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNavLinkCustomInstanceData A, FNavLinkCustomInstanceData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNavLinkCustomInstanceData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FNavLinkId CustomLinkId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CustomLinkId, __ReturnBuffer);

					return *(FNavLinkId*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CustomLinkId, __InBuffer);
				}
			}
		}

		public FNavLinkAuxiliaryId AuxiliaryCustomLinkId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AuxiliaryCustomLinkId, __ReturnBuffer);

					return *(FNavLinkAuxiliaryId*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AuxiliaryCustomLinkId, __InBuffer);
				}
			}
		}

		private static uint __CustomLinkId = 0;

		private static uint __AuxiliaryCustomLinkId = 0;

	}
}