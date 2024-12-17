using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimationSharing
{
	[PathName("/Script/AnimationSharing.AnimationSetup")]
	public partial class FAnimationSetup : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimationSharing.AnimationSetup");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimationSetup() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimationSetup() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimationSetup A, FAnimationSetup B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimationSetup A, FAnimationSetup B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimationSetup;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UAnimSequence AnimSequence
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AnimSequence, __ReturnBuffer);

					return *(UAnimSequence*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AnimSequence, __InBuffer);
				}
			}
		}

		public TSubclassOf<UAnimSharingStateInstance> AnimBlueprint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AnimBlueprint, __ReturnBuffer);

					return *(TSubclassOf<UAnimSharingStateInstance>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AnimBlueprint, __InBuffer);
				}
			}
		}

		public FPerPlatformInt NumRandomizedInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumRandomizedInstances, __ReturnBuffer);

					return *(FPerPlatformInt*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumRandomizedInstances, __InBuffer);
				}
			}
		}

		public FPerPlatformBool Enabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Enabled, __ReturnBuffer);

					return *(FPerPlatformBool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Enabled, __InBuffer);
				}
			}
		}

		private static uint __AnimSequence = 0;

		private static uint __AnimBlueprint = 0;

		private static uint __NumRandomizedInstances = 0;

		private static uint __Enabled = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}