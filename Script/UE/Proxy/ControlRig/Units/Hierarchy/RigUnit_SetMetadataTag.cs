using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_SetMetadataTag")]
	public partial class FRigUnit_SetMetadataTag : FRigUnitMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_SetMetadataTag");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_SetMetadataTag()
		{
		}

		public static bool operator ==(FRigUnit_SetMetadataTag A, FRigUnit_SetMetadataTag B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_SetMetadataTag A, FRigUnit_SetMetadataTag B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_SetMetadataTag;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigElementKey Item
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Item, __ReturnBuffer);

					return *(FRigElementKey*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Item, __InBuffer);
				}
			}
		}

		public FName Tag
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Tag, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Tag, __InBuffer);
				}
			}
		}

		public FCachedRigElement CachedIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CachedIndex, __ReturnBuffer);

					return *(FCachedRigElement*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CachedIndex, __InBuffer);
				}
			}
		}

		private static uint __Item = 0;

		private static uint __Tag = 0;

		private static uint __CachedIndex = 0;

	}
}