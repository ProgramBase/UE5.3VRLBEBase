using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RootMotionSourceGroup")]
	public partial class FRootMotionSourceGroup : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.RootMotionSourceGroup");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRootMotionSourceGroup() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRootMotionSourceGroup() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRootMotionSourceGroup A, FRootMotionSourceGroup B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRootMotionSourceGroup A, FRootMotionSourceGroup B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRootMotionSourceGroup;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bHasAdditiveSources
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHasAdditiveSources, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHasAdditiveSources, __InBuffer);
				}
			}
		}

		public bool bHasOverrideSources
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHasOverrideSources, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHasOverrideSources, __InBuffer);
				}
			}
		}

		public bool bHasOverrideSourcesWithIgnoreZAccumulate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHasOverrideSourcesWithIgnoreZAccumulate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHasOverrideSourcesWithIgnoreZAccumulate, __InBuffer);
				}
			}
		}

		public bool bIsAdditiveVelocityApplied
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsAdditiveVelocityApplied, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsAdditiveVelocityApplied, __InBuffer);
				}
			}
		}

		public FRootMotionSourceSettings LastAccumulatedSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LastAccumulatedSettings, __ReturnBuffer);

					return *(FRootMotionSourceSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LastAccumulatedSettings, __InBuffer);
				}
			}
		}

		public FVector_NetQuantize10 LastPreAdditiveVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LastPreAdditiveVelocity, __ReturnBuffer);

					return *(FVector_NetQuantize10*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LastPreAdditiveVelocity, __InBuffer);
				}
			}
		}

		private static uint __bHasAdditiveSources = 0;

		private static uint __bHasOverrideSources = 0;

		private static uint __bHasOverrideSourcesWithIgnoreZAccumulate = 0;

		private static uint __bIsAdditiveVelocityApplied = 0;

		private static uint __LastAccumulatedSettings = 0;

		private static uint __LastPreAdditiveVelocity = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}