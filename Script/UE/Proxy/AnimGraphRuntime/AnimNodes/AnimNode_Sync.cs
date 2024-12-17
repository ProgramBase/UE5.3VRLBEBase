using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_Sync")]
	public partial class FAnimNode_Sync : FAnimNode_Base, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_Sync");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_Sync()
		{
		}

		public static bool operator ==(FAnimNode_Sync A, FAnimNode_Sync B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_Sync A, FAnimNode_Sync B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_Sync;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPoseLink Source
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Source, __ReturnBuffer);

					return *(FPoseLink*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Source, __InBuffer);
				}
			}
		}

		public FName GroupName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GroupName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GroupName, __InBuffer);
				}
			}
		}

		public EAnimGroupRole GroupRole
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GroupRole, __ReturnBuffer);

					return *(EAnimGroupRole*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GroupRole, __InBuffer);
				}
			}
		}

		private static uint __Source = 0;

		private static uint __GroupName = 0;

		private static uint __GroupRole = 0;

	}
}